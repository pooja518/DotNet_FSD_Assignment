using ApplicationProduct.Models;
using ApplicationProduct.Repositories;
namespace ApplicationProduct.Services;

public class ProductService : IProductService
{
    public IProductRepository _context;
    public ProductService(IProductRepository context) 
    {
        _context = context;
    }
    public List<Product> GetAllProducts()
    {
        return _context.GetAllProducts();
    }
    public Product GetProductById(int id)
    {
        return _context.GetProductById(id);
    }
    public void CreateProduct(Product product)
    { 
        _context.CreateProduct(product);
    }
    public void UpdateProduct(Product product) 
    {
        _context.UpdateProduct(product);
    }
    public void DeleteProductById(int id)
    {
        _context.DeleteProductById(id);
    }
    public List<Product> GetCategoryProducts(string category)
    {
        return _context.GetCategoryProducts(category);
    }

    public List<Product> GetOutOfStockProducts()
    {
        return _context.GetOutOfStockProducts();
    }
    public List<Product> GetPriceRangeProducts(int min,int max)
    {
        return _context.GetPriceRangeProducts(min,max);
    }
    public HashSet<string> GetCategoryNames()
    {
        return _context.GetCategoryNames();
    }
}
