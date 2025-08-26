using ProductCatalogService.Models;

namespace ProductCatalogService.Services
{
    public class ProductService
    {
        private readonly ProductDbContext _dbContext;

        public ProductService(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Products> GetAll()=> _dbContext.Products.ToList();
        public Products GetById(int id) => _dbContext.Products.Find(id);
        public void Add(Products product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
    }
}
