using ApplicationProduct.Models;

namespace ApplicationProduct.Repositories
{
    public class ProductRepository : IProductRepository  
    {
        ProductDbContext _context;
        public ProductRepository(ProductDbContext context) 
        { 
            _context = context;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.products.ToList();
            return products;
        }
        public Product GetProductById(int id)
        {
            Product product = _context.products.Find(id);
            return product;
        }
        public void CreateProduct(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.products.Update(product);
            _context.SaveChanges();
        }
        public void DeleteProductById(int id)
        {
            Product obj = _context.products.Find(id);
            _context.products.Remove(obj);
            _context.SaveChanges();
        }
        public List<Product> GetCategoryProducts(string category)
        {
            List<Product> products = _context.products.Where(p => p.category == category).ToList();
            return products;
        }
        public List<Product> GetOutOfStockProducts()
        {
            List<Product> products = _context.products.Where(p => p.Quantity == 0).ToList();
            return products;
        }
        public List<Product> GetPriceRangeProducts(int min, int max)
        {
            List<Product> products = _context.products.Where(p=> p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            return products;
        }
        public HashSet<string> GetCategoryNames()
        {
            HashSet<string> category = _context.products.Select(p => p.category).ToHashSet();
            return category;
            
        }



    }
}
