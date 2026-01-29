
using Microsoft.AspNetCore.Mvc;

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
    [HttpGet("random")]
    public IActionResult GetRandomCat()
    {
        var random = new Random();
        var randomImagePath = _catImage[random.Next(_catImage.Length)];
        var response = new
        {
            url = randomImagePath,
            width = 300,
            height = 200,
            message = "Här är en fin katt!"
        };
        return Ok(response);

    }
}