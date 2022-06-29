using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        static List<string> names = new List<string>()
        {
            "Amar","Akbar","Anthanoy","Amit"

        };
        // GET: api/<NamesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return names;
        }

        // GET api/<NamesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return names[id];

        }

        // POST api/<NamesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            names.Add(value);
        }

        // PUT api/<NamesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            names[id] = value;
        }

        // DELETE api/<NamesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            names.RemoveAt(id);
        }
    }
}
