using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication32.Models;
namespace WebApplication32.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        //private readonly IOperationTransient _transient;
        //private readonly IOperationSingleton _singleton;
        //private readonly IOperationScoped _scoped;

        private readonly IOperationSingleton _singleton;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOperationSingleton op)//IOperationScoped op //IOperationTransient op  IOpeartionSingleton op
        {
            _logger = logger;

            //_transient = op;
           _singleton = op;
           // _scoped = op;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //Console.WriteLine(_transient.OperationID);
            //Console.WriteLine(_scoped.OperationID);
            //Console.WriteLine(_singleton.OperationID);
            Console.WriteLine(_singleton.OperationID);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
