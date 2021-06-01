using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiDemo1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        List<WeatherForecast> list = new List<WeatherForecast>
        {
            new WeatherForecast(){Date=Convert.ToDateTime(12/05/2015), TemperatureC=25,Summary = "Sweltering"},
            new WeatherForecast(){Date=Convert.ToDateTime(10/09/2015), TemperatureC=14,Summary = "Scorching"},
            new WeatherForecast(){Date=Convert.ToDateTime(20/06/2015), TemperatureC=20,Summary = "Chilly"}
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return list;
        }
    }
}
