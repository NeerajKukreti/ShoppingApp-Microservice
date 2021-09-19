using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI
{
    public class ProductContext
    {
        public IMongoCollection<Product> products { get; set; }

        public ProductContext(IConfiguration configuration) 
        {
            MongoClient client = new MongoClient(configuration["Databasesetting:ConnectionString"]);
            var db = client.GetDatabase(configuration["Databasesetting:DatabaseName"]);
            products = db.GetCollection<Product>(configuration["Databasesetting:CollectionName"]);
            SeedData(products);
        }

        private static void SeedData(IMongoCollection<Product> mongoCollection) {
            bool existProduct = mongoCollection.Find(p => true).Any();

            if (!existProduct) {
                mongoCollection.InsertMany(getProducts());
            }
        }

        private static IEnumerable<Product> getProducts() {
            return new List<Product>{
             new Product{
              
               Category = "Smart Phone",
                Description = "Apple smart phone",
                 ImageFile = "product1.jpg",
                  Name = "Iphone 12",
                   Price = 1000m
             },
             new Product{
             
               Category = "Smart Phone",
                Description = "Samsung smart phone",
                 ImageFile = "product2.jpg",
                  Name = "S10",
                   Price = 1000m
             },
             new Product{
            
               Category = "Smart Phone",
                Description = "Mi 10IE",
                 ImageFile = "product3.jpg",
                  Name = "S10",
                   Price = 1000m
             },

        };
    }
    }
}
