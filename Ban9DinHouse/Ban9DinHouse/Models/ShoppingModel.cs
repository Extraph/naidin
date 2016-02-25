using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ban9DinHouse.Models
{
    public class ShoppingModel
    {
        public List<ProductMaster> products { get; set; }
        public ShoppingCart cart { get; set; }
    }
}