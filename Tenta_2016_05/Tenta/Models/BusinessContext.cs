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
                    Products = new List<Product>()
                    {
                        new Product()
                        {
                            ProductId = 2,
                        }
                    }
                };
                context.Stores.Add(store1);
                context.SaveChanges();
            }
        }
    }
}