using Microsoft.AspNetCore.Mvc;
using MainService.Models;

[ApiController]
[Route("[controller]")]
public class TextsController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] TextRequestDto request)
    {
        var text = request.Text;
        Console.WriteLine($"Получен текст: {text}");
        return Ok("Текст успешно принят");
    }
}