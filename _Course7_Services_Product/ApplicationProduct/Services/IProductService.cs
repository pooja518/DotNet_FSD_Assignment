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
    }
}
