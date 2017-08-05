using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreEcommerce.Models;

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
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Products
        [HttpPost(Name = "PostProducts")]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Products/5
        [HttpPut("{id}", Name = "PutProducts")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteProducts")]
        public void Delete(int id)
        {
        }
    }
}
