using Microsoft.EntityFrameworkCore;

namespace ApplicationProduct.Models
{
    public class Product
    {
        public int productId { set; get; }
        public string productName { set; get; }
        public int UnitPrice { set; get; }
        public int Quantity { set; get; }
        public string category { set; get; }
    }
    //create database

    public class ProductDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

    }
}
