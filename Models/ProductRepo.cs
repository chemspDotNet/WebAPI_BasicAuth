using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_BasicAuth.Models
{
    public class ProductRepo
    {
        List<Product> products = new List<Product>() { };
        
        public  List<Product> GetProducts()
        {
            var products = new List<Product>();
            for(int i = 101; i <= 25; i++)
            {
                products.Add(new Product()
                {
                    Name = i.ToString(),
                    ID = i,
                    Manufacturer = "Manufacturer" + i.ToString(),
                    price = 1000 + i,

                }) ;
            }
            return products;
        }
    }
}