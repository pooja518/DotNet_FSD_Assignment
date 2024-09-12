using ApplicationProduct.Models;

namespace ApplicationProduct.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProductById(int id);
        List<Product> GetCategoryProducts(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetPriceRangeProducts(int min,int max);
        HashSet<string> GetCategoryNames();
    }
}
