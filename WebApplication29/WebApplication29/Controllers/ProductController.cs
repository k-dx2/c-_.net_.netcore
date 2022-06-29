using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication29.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication29.Controllers
{   
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static readonly IProductRepository Repository = new ProductRepository();

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return Repository.GetAllProduct();
           
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            Product item = Repository.GetProduct(id);
            if(item==null)
            {
               throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);

            }
            return item;

        }

        // POST api/<ProductController>
        [HttpPost]
        public string PostProduct([FromBody] Product value)
        {
            value=Repository.AddProduct(value);

            return "Added Successfully";
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void PutProduct(int id, [FromBody] Product value)
        {
            value.Id = id;
            if(!Repository.UpdateProduct(value))
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            Product item = Repository.GetProduct(id);
            if(item==null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            Repository.RemoveProduct(id);
        }
    }
}
