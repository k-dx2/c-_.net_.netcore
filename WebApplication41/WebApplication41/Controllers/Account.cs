using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication41.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication41.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Account : ControllerBase
    {
        private readonly IAccountSingleton _singleton;
        private readonly IAccountScoped _scoped;
        private readonly IAccountTransient _transient;

        public Account(IAccountTransient p)
        {
          //  _singleton = p;
            _transient = p;
           // _scoped = p;
         }
    // GET: api/<Account>
    [HttpGet]
        public string Get()
        {
            //return "Account ID: "+_singleton.GetAccountDetails();
            return "Account ID: " +_transient.GetAccountDetails();
            //  return "Account ID: "+ _scoped.GetAccountDetails();
        }

        // GET api/<Account>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Account>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Account>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Account>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
