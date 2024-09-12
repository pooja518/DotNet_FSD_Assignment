using ApplicationProduct.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationProduct.Repositories;
using ApplicationProduct.Services;
using Microsoft.EntityFrameworkCore;

namespace ApplicationProduct.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService _services;
        public ProductController(IProductService services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_services.GetAllProducts());
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _services.GetProductById(id);
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
            
             _services.CreateProduct(product);
             return Ok(new { status = "New product details added in server" });
           
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product) 
        { 
            _services.UpdateProduct(product);
            return Ok(new { status = "Product details updated in server" });
        }

        [HttpDelete("(id")]
        public IActionResult DeleteProductById(int id) 
        {
            _services.DeleteProductById(id);
            return Ok(new { status = "product details are deleted from server" });

        }

        [HttpGet("/category/{category}")]
        public IActionResult GetCategoryProducts(string category)
        {
           List<Product> obj =  _services.GetCategoryProducts(category);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return Ok(new {status = "No products in the required category"});
            }

        }
        [HttpGet("outofstock")]
        public IActionResult GetOutOfStockProducts()
        {
            List<Product> obj = _services.GetOutOfStockProducts();
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return Ok(new { status = "All products are available right now" });
            }


        }
        [HttpGet("/price/{min},{max}")]
        public IActionResult GetPriceRangeProducts(int min,int max)
        {
            List <Product> obj = _services.GetPriceRangeProducts(min,max);
            if (obj != null) 
            {
                return Ok(obj);
            }
            else
            {
                return Ok(new { status = "No products in the given range" });
            }
        }
        [HttpGet("/category")]
        public IActionResult GetCategoryNames()
        {
            HashSet<string> obj = _services.GetCategoryNames();
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return Ok(new { status = "No products catogories to display" });
            }
        }
    }
}
