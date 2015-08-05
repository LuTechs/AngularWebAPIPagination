using System.Data.Entity;

namespace AngularWebAPIPagination.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
            : base("defaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Product> Products { get; set; }
    }
}