using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tenta.Models
{
    public class BusinessContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public BusinessContext() : base("BusinessDB")
        {
            Database.SetInitializer<BusinessContext>(new BusinessContextInitializer());
        }

        public class BusinessContextInitializer : DropCreateDatabaseAlways<BusinessContext>
        {
            protected override void Seed(BusinessContext context)
            {
                DummyData(context);
            }

            public void DummyData(BusinessContext context)
            {
                Store store1 = new Store()
                {
                    StoreId = 1,
                    Name = "ICA",
                    Adress = "Storgatan 5",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            ProductId = 1,
                            Name = "Hallon",
                            ProductText = "Goda hallon",
                            ProductNumber = 45,
                            Price = 49.90,
                            ProductsInStock = 200,
                            StoreId = 1,
                        },
                        new Product()
                        {
                            ProductId = 2,
                            Name = "Jordgubbar",
                            ProductText = "Goda jordgubbar",
                            ProductNumber = 48,
                            Price = 39.90,
                            ProductsInStock = 250,
                            StoreId = 1,
                        }
                    }
                };
                Store store2 = new Store()
                {
                    StoreId = 2,
                    Name = "H&M",
                    Adress = "Brogatan 15",
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            ProductId = 1,
                            Name = "T-shirt",
                            ProductText = "Cool T-shirt av tyg",
                            ProductNumber = 145,
                            Price = 149.90,
                            ProductsInStock = 94,
                            StoreId = 2,
                        },
                        new Product()
                        {
                            ProductId = 2,
                            Name = "Jeans",
                            ProductText = "Tajta jeans yeeah",
                            ProductNumber = 48,
                            Price = 400,
                            ProductsInStock = 52,
                            StoreId = 2,
                        }
                    }
                };          
                context.Stores.Add(store1);
                context.Stores.Add(store2);
                context.SaveChanges();
            }
        }
    }
}