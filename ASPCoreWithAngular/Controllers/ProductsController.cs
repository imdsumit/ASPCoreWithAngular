using ASPCoreWithAngular.Models;
using ASPCoreWithAngular.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPCoreWithAngular.Controllers
{
    [Produces("application/json")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        [Route("api/Product")]
        public IEnumerable<Product> GetProducts()
        {
            return productService.ListProducts();
        }
                
        // POST: api/Products
        [HttpPost]
        [Route("api/Product/Create")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            productService.AddProduct(product);

            return CreatedAtAction("GetProducts", product);
        }
    }
}