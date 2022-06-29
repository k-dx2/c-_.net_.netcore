using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication26.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerbsController : ControllerBase
    {
        // GET: api/<VerbsController>
        [HttpGet]
        public string Get()
        {
            return "This is GET Verb";
        }

            // GET api/<VerbsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "This is Get Verb "+ id;
        }

        // POST api/<VerbsController>
        [HttpPost]
        public string Post()
        {
            return "This is POST  Verb";
        }

        // PUT api/<VerbsController>/5
        [HttpPut]
        public string Put()
        {
            return "This is PUT Verb";
        }

        // DELETE api/<VerbsController>/5
        [HttpDelete]
        public string Delete()
        {
            return "This is DELETE Verb";
        }
    }
}
