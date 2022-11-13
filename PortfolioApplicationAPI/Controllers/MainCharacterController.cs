using Microsoft.AspNetCore.Mvc;

namespace PortfolioApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class MainCharacterController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<MainCharacterController> _logger;

    public MainCharacterController(ILogger<MainCharacterController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<MainCharacter> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new MainCharacter
        {
            BirthDate = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

