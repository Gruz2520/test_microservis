using Microsoft.AspNetCore.Mvc;

namespace NumberService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] int number)
        {
            // Тут можно добавить логику сохранения числа
            Console.WriteLine($"Получено число: {number}");

            return Ok("Число успешно получено");
        }
    }
}