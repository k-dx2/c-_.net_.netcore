using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication28.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilePhoneController : ControllerBase
    {
        static List<string> phones = new List<string>() { "Apple", "Samsung", "Google", "Nokia" };
        // GET: api/<MobilePhoneController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return phones;
        }

        // GET api/<MobilePhoneController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return phones[id];
        }

        // POST api/<MobilePhoneController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            phones.Add(value);
        }

        // PUT api/<MobilePhoneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            phones[id] = value;
        }

        // DELETE api/<MobilePhoneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            phones.RemoveAt(id);
        }
    }
}
