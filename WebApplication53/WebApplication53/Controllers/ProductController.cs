using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication53.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication53.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> ProdList = new List<Product>()
            {
                new Product()
                { ProdId="P101",
                  ProdName="Dairy Milk Silk",
                  ProdCategory="Choclates",
                  ProdMfDate= new DateTime(2021,03,02),
                  ProdExpDate= new DateTime(2023,03,02)                



                } ,
                new Product()
                {
                  ProdId="P102",
                  ProdName="Amul Dark Choclate",
                  ProdCategory="Choclates",
                  ProdMfDate= new DateTime(2021,03,02),
                  ProdExpDate= new DateTime(2023,03,02)

                },
                new Product()
                {
                  ProdId="P103",
                  ProdName="Lays",
                  ProdCategory="Snacks",
                  ProdMfDate= new DateTime(2021,03,02),
                  ProdExpDate= new DateTime(2023,03,02)

                },
                new Product()
                {
                    ProdId="P104",
                  ProdName="Kurkure",
                  ProdCategory="Snacks",
                  ProdMfDate= new DateTime(2021,03,02),
                  ProdExpDate= new DateTime(2023,03,02)

                }
            };
        
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProdList;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return ProdList[id-1];
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product val)
        {
            ProdList.Add(val);

        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product val)
        {
            ProdList.RemoveAt(id-1);
            ProdList.Add(val);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProdList.RemoveAt(id-1);
        }
    }
}
