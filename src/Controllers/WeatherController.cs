using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWeather()
        {
            var weatherData = new
            {
                TemperatureC = 25,
                Summary = "Sunny"
            };

            return Ok(weatherData);
        }
    }
}