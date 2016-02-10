using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using AngularWebAPIPagination.Models;

namespace AngularWebAPIPagination
{
    public class DbInit:CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            var random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                context.Products.AddOrUpdate(p => p.Id, new Product
                {
                    Name = "Product " + i,
                    Price = random.Next(1,100) * i,
                    Qty = random.Next(1, 100) * i,
                    Date = DateTime.Now.AddDays(random.Next(1, 100))
                });
            }
        }
    }
}