using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorWASM_JwtAuth.Shared;
using Microsoft.AspNetCore.Authorization;

namespace BlazorWASM_JwtAuth.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

       [HttpGet]
		[Authorize] // NOTE: THIS LINE OF CODE IS NEWLY ADDED
		public IEnumerable<WeatherForecast> Get()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)],
				UserName = User.Identity.Name
			});
		}

		// NOTE: THIS ENTIRE METHOD IS NEWLY ADDED
		[HttpGet("{date}")]
		[Authorize]
		public WeatherForecast Get(DateTime date)
		{
			var rng = new Random();
			return new WeatherForecast
			{
				Date = date,
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)],
				UserName = User.Identity.Name
			};
		}
    }
}
