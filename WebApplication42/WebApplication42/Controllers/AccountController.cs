using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication42.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication42.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private static IAccount _repo = new AccountRepo();
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return _repo.ShowAll();
         }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public Account Get(int id)
        {
           return _repo.Show(id);
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] Account value)
        {
            _repo.Add(value);
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Account value)
        {
            _repo.Update(id, value);
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Del(id);
        }
    }
}
