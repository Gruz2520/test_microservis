using Microsoft.AspNetCore.Mvc;

namespace TextService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] string text)
        {
            // Просто логируем полученный текст
            Console.WriteLine($"Получен текст: {text}");

            return Ok("Текст успешно принят");
        }
    }
}