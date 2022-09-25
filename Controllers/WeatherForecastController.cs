using Microsoft.AspNetCore.Mvc;

namespace Rozetka.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<User> Get()
        {
            return Enumerable.Range(1, 2).Select(index => new User
            {
                Id = Operations.Read(index).Id,
                Name = Operations.Read(index).Name,
                Surname = Operations.Read(index).Surname,
            })
            .ToArray();
        }
    }
}