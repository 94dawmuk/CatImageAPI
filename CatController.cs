
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1/cats")]
public class CatController : ControllerBase
{
    [HttpGet("random")]
    public IActionResult GetRandomCat()
    {
        var response = new
        {
            url = "https://cataas.com/cat",
            width = 300,
            height = 200,
            message = "Här är en fin katt!"
        };
        return Ok(response);
    }
}