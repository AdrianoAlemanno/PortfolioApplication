using Microsoft.AspNetCore.Mvc;

namespace PortfolioApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class PortfolioController : ControllerBase
{
    private readonly ILogger<PortfolioController> _logger;

    public PortfolioController(ILogger<PortfolioController> logger)
    {
        _logger = logger;
    }

    [HttpGet("User")]
    public MainCharacter GetUserData()
    {
        return new MainCharacter
        (
            "Adriano",
            "Alemanno",
            DateOnly.FromDateTime(new DateTime(1990, 11, 24)),
            null,
            null,
            null
        );
    }
}

