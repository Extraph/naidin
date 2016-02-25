using Ban9DinHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ban9DinHouse.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            ShoppingCart shoppingcart = App.App.Cart;
            shoppingcart.discount = calculate(shoppingcart);
            return View(shoppingcart);
        }

        [HttpPost]
        public ActionResult Add(string sku, int qty)
        {
            ProductMaster prod = App.App.MyProducts.Where(i => i.SKU == sku).FirstOrDefault();
            OrderDetail order = new OrderDetail() { QTY = qty, products = prod, orderNumber = int.Parse(DateTime.Now.ToString("yyHHmmss")) };
            if (App.App.Cart.orders.Exists(i => i.products.SKU == sku))
            {
                OrderDetail modify = App.App.Cart.orders.Where(i => i.products.SKU == sku).FirstOrDefault();
                App.App.Cart.orders.Remove(modify);
                modify.QTY += qty;
                App.App.Cart.orders.Add(modify);
            }
            else
            {
                App.App.Cart.orders.Add(order);
            }

            int count = App.App.Cart.orders.Count;
            ShoppingModel shoppingmodels = new ShoppingModel();
            shoppingmodels.products = App.App.MyProducts;
            shoppingmodels.cart = App.App.Cart;
            return View("../Home/Index", shoppingmodels);
        }

        public ActionResult RemoveOrderItem(string sku)
        {
            OrderDetail order = App.App.Cart.orders.Where(i => i.products.SKU == sku).FirstOrDefault();
            App.App.Cart.orders.Remove(order);
            ShoppingCart shoppingcart = App.App.Cart;
            shoppingcart.discount = calculate(shoppingcart);
            return View("Index", shoppingcart);
        }
        public ActionResult Clear()
        {
            App.App.Cart.orders = new List<OrderDetail>();
            ShoppingModel shoppingmodels = new ShoppingModel();
            shoppingmodels.products = App.App.MyProducts;
            shoppingmodels.cart = App.App.Cart;
            return View("../Home/Index", shoppingmodels);
        }

        decimal calculate(ShoppingCart cart)
        {
            decimal _discount = 0M;
            decimal percent = 0.0M;
            List<OrderDetail> order = new List<OrderDetail>();
            cart.orders.ToList().ForEach(i => order.Add(new OrderDetail(i)));
            while (order.Count >= 2)
            {
                order = order.Where(i => i.QTY > 0).ToList();
                if (order.Count(i => i.QTY > 0) < 2 || order.Count < 2)
                {
                    break;
                }
                if (order.Count <= 7)
                {
                    percent = (decimal)((order.Count - 1) * 10 / 100.0M);
                }
                else
                {
                    percent = (decimal)0.6M;
                }
                decimal total = order.Where(item => item.QTY > 0).Sum(i => i.products.price);
                _discount = _discount + (total * percent);
                order.ToList().ForEach(i => i.QTY--);
            }
            order = null;
            return _discount;
        }
    }
}
