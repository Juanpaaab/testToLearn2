using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
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

        public int sumar(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        [Route("getHola")]
        public ActionResult get()
        {
            return Ok();
        }

        public int restar(int a, int b)
        {
            return a - b;
        }

        public string frase(string frase)
        {
            return frase;
        }

        public string frase2(string frase2)
        {
            return frase2;
        }
    }
}