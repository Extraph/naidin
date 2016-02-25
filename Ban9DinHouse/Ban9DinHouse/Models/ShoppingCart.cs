using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ban9DinHouse.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        public List<OrderDetail> orders { get; set; }
        public decimal discount { get; set; }

    }
}