using Ban9DinHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ban9DinHouse.App
{
    public static class App
    {
        public static ShoppingCart Cart = new ShoppingCart() { orders = new List<OrderDetail>()};
        
        public static List<ProductMaster> MyProducts = new List<ProductMaster>(){
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 1", SKU = "HP001", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 2", SKU = "HP002", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 3", SKU = "HP003", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 4", SKU = "HP004", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 5", SKU = "HP005", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 6", SKU = "HP006", VAT = 0, price = 100 },
        new ProductMaster() { id = 1, catalog = 1, Name = "Harry potter EP 7", SKU = "HP007", VAT = 0, price = 100 }
        };
    }
}