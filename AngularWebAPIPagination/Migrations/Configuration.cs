using AngularWebAPIPagination.Models;

namespace AngularWebAPIPagination.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularWebAPIPagination.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AngularWebAPIPagination.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                context.Products.AddOrUpdate(p => p.Id, new Product
                {
                    Name = "Product " + i,
                    Price = 2 * i,
                    Qty = 3 * i,
                    Date = DateTime.Now.AddDays(random.Next(1, 100))
                });
            }
        }
    }
}
