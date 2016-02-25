using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ban9DinHouse.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
            orderNumber = 0;
            products = new ProductMaster();
            QTY = 0;
        }
        public OrderDetail(OrderDetail order)
        {
            orderNumber = order.orderNumber;
            products = order.products;
            QTY = order.QTY;
        }
        public int orderNumber { get; set; }
        public ProductMaster products { get; set; }
        public int QTY { get; set; }

    }
}