using Microsoft.EntityFrameworkCore;

namespace ProductCatalogService.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        protected ProductDbContext()
        {
        }
    }
}
