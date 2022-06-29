using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication50.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication50.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {   
        static int empid=1;
        static List<Employee> EmpList = new List<Employee>()
            {
                new Employee(){EmpId=empid++,EmpName="Iron Man",EmpDept="Avengers",EmpLoc="Newyork"},
                new Employee(){EmpId=empid++,EmpName="Captain America",EmpDept="Avengers",EmpLoc="Newyork"},
                new Employee(){EmpId=empid++,EmpName="Wolverine",EmpDept="X Men",EmpLoc="Japan"},
                new Employee(){EmpId=empid++,EmpName="Thor",EmpDept="Avengers",EmpLoc="Asgaurd"},

            };
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return EmpList;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return EmpList.Find(s=>s.EmpId==id);
            
            
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            value.EmpId = empid++;
            EmpList.Add(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            int index = EmpList.FindIndex(s => s.EmpId == id);
            if(index==-1)
            {
                throw new ArgumentOutOfRangeException("out of index");
            }
            EmpList.RemoveAt(index);
            EmpList.Add(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int index = EmpList.FindIndex(s => s.EmpId == id);
            if (index == -1)
            {
                throw new ArgumentOutOfRangeException("out of index");
            }
            EmpList.RemoveAt(index);
        }
    }
}
