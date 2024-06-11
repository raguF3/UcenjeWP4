using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using System.Security.Cryptography.X509Certificates;
>>>>>>> 6f1f6cd3cedc1913ed80485b5ee23ac75e1b49bc

namespace WebAPI.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
<<<<<<< HEAD
                TemperatureC = 18,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [Route("Hello)")]
        public string Hello()
        {
            return "Hello world";

        }
}
=======
                TemperatureC = 19,
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();


            [HttpPost]
            [Route("hello")] 


            {

                return "Hello World ";
            
            }
        }
    }
>>>>>>> 6f1f6cd3cedc1913ed80485b5ee23ac75e1b49bc
}
