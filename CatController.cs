using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

[ApiControllerAttribute]
[Route("api/v1/cats")]
public class CatController : ControllerBase
{
    [HttpGet("random")]
    public IActionResult GetRandomCat()
    {
        var response = new
        {
            url = "https://cdn.omlet.com/images/originals/breed_abyssinian_cat.jpg",
            width = 300,
            height = 200,
            message = "Här är en fin katt!"
        };
        return Ok(response);
        
    }
}