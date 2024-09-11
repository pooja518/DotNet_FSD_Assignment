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




    }
}
