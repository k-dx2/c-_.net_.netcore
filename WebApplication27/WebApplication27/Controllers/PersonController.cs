﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            List<Person> PList = new List<Person>();
            PList.Add(new Person() {PersonId=101,FirstName="Kunal",LastName="Dekate",Location="Nagpur" });
            PList.Add(new Person() { PersonId = 102, FirstName = "Amal", LastName = "Singh", Location = "Delhi" });
            PList.Add(new Person() { PersonId = 103, FirstName = "Adarsh", LastName = "Kapoor", Location = "Mumbai" });


            return PList.ToArray();

        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
