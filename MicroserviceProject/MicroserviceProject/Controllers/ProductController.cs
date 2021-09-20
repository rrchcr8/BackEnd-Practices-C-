using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceProject.Controllers
{
    [ApiController]
    //[Route("controller]s")]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Products;

        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get( int id)
        {
            return Products.Single(x=>x.Id==id);

        }

        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            product.Id = Products.Count() + 1;
            Products.Add(product);

            return CreatedAtAction(
                "Get", new { id=product.Id }, product
                );
        }

        [HttpPut("{productId}")]
        public ActionResult Update(int productId, Product product)
        {
            
            var originalEntry = Products.Single(x => x.Id == productId);
            
            originalEntry.Name = product.Name;
            originalEntry.Description = product.Description;
            originalEntry.Price = product.Price;

            return NoContent();
        }

        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id=1,
                Name = "Guitarra eléctrica",
                Price = 1200,
                Description = "Idel para tocar música"
            },
            new Product
            {
                Id=2,
                Name = "Bajo eléctrico",
                Price = 1500,
                Description = "Idel para tocar música"
            },            
        };
    }
}
