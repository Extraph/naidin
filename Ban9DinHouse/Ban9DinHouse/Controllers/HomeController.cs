using Ban9DinHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ban9DinHouse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ShoppingModel shopingmodels = new ShoppingModel();
            shopingmodels.products = App.App.MyProducts;
            shopingmodels.cart = App.App.Cart;
            return View(shopingmodels);
        }

    }
}
