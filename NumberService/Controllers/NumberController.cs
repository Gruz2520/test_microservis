using Microsoft.AspNetCore.Mvc;
using MainService.Models;

[ApiController]
[Route("[controller]")]
public class NumbersController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] NumberRequestDto request)
    {
        var number = request.Number;
        Console.WriteLine($"Получено число: {number}");
        return Ok("Число успешно принято");
    }
}