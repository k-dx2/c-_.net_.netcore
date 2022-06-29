using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebApplication33.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication33.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {   static readonly ICustRepo Repository = new CustRepo();
       
        

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Repository.ShowAllCust();
        }

        
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            Customer c = Repository.ShowCust(id);

            if(c==null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            return c;
        }

        
        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            return Repository.AddCust(value);
        }

        
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Customer value)
        {
            return Repository.UpdateCust(id, value);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return Repository.DelCust(id);

        }
    }
}
