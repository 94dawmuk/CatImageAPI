using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/v1/cats")]
public class CatController : ControllerBase
{
    private readonly string[] _catImage = new[]
    {
        "/cats/cat1.png",
        "/cats/cat2.png",
        "/cats/cat3.png"
    };

    private readonly ILogger<CatController> _logger;

    public CatController(ILogger<CatController> logger)
    {
        _logger = logger;
    }

    [HttpGet("random")]
    public IActionResult GetRandomCat()
    {
        try
        {
            var random = new Random();
            var randomImagePath = _catImage[random.Next(_catImage.Length)];

            _logger.LogInformation($"Returning random cat image: {randomImagePath}");

            var response = new
            {
                url = randomImagePath,
                width = 300,
                height = 200,
                message = "Här är en fin katt!"
            };
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting random cat image");
            return StatusCode(500, new { error = "Något gick fel vid hämtning av kattbild", details = ex.Message });
        }
    }
}