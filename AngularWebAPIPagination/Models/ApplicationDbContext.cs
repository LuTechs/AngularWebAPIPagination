using System.Data.Entity;

namespace AngularWebAPIPagination.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("defaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}