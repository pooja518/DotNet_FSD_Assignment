using ApplicationProduct.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductDbContext _context;
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_context.products.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _context.products.Find(id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound(new {status = "Requested product details does not exist"});
            }
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product) 
        {
            
             _context.products.Add(product);
             _context.SaveChanges();
             return Ok(new { status = "New product details added in server" });
           
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product) 
        { 
            _context.products.Update(product);
            _context.SaveChanges();
            return Ok(new { status = "Product details updated in server" });
        }

        [HttpDelete("(id")]
        public IActionResult DeleteProductById(int id) 
        {
            Product obj = _context.products.Find(id);
            if (obj != null)
            {
                _context.products.Remove(obj);
                _context.SaveChanges();
                return Ok(new { status = "product details are deleted from server" });
            }
            else
            {
                return NotFound(new { status = "Requested product details does not exists" });
            }
        }
    }
}
