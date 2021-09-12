using Shopping.client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.client.Data
{
    public static class ProductDBContext
    {
        public static readonly List<Product> Products = new List<Product>{
             new Product{
              Id =1,
               Category = "Smart Phone",
                Description = "Apple smart phone",
                 ImageFile = "product1.jpg",
                  Name = "Iphone 12",
                   Price = 1000m
             },
             new Product{
              Id =3,
               Category = "Smart Phone",
                Description = "Samsung smart phone",
                 ImageFile = "product2.jpg",
                  Name = "S10",
                   Price = 1000m
             },
        };
    }
}
