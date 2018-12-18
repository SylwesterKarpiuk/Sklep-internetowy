using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop___videopoint.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}