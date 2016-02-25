using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ban9DinHouse.Models
{
    public class ProductMaster
    {
        public int id { get; set; }
        public int catalog { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public decimal VAT { get; set; }
    }
}