using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_BasicAuth.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int price { get; set; }
    }
}