using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreEcommerce.Models;
using Microsoft.AspNetCore.Http.Extensions;

namespace CoreEcommerce.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private ApplicationContext context;
        private IProductRepository productRepository;

        public ProductsController(ApplicationContext context)
        {
            this.productRepository = new ProductRepository(context);
            this.context = context;
        }

        // GET: api/Products
        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "GetProductsID")]
        public Product Get(int id)
        {
            return productRepository.GetProductByID(id);
        }
        
        // POST: api/Products
        [HttpPost(Name = "PostProducts")]
        public ActionResult Post([FromBody]Product product)
        {
            if (ModelState.IsValid)
            {
                product = productRepository.CreateProduct(product);
                return Created(new Uri(Request.GetDisplayUrl() + "/" + product.productId), product);
            }
            return BadRequest(ModelState.Select(x => x.Value.Errors.ToList()));
        }
        
        // PUT: api/Products/5
        [HttpPut(Name = "PutProducts")]
        public void Put([FromBody]Product product)
        {
            productRepository.UpdateProduct(product);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteProducts")]
        public void Delete(int id)
        {
            productRepository.DeleteProduct(id);
        }
    }
}
