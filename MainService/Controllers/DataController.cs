using Microsoft.AspNetCore.Mvc;

namespace MainService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly NumberClient _numberClient;
        private readonly TextClient _textClient;

        public DataController(NumberClient numberClient, TextClient textClient)
        {
            _numberClient = numberClient;
            _textClient = textClient;
        }

        [HttpPost("number")]
        public async Task<IActionResult> HandleNumber([FromBody] int number)
        {
            var result = await _numberClient.SendNumberAsync(number);
            return Ok(result);
        }

        [HttpPost("text")]
        public async Task<IActionResult> HandleText([FromBody] string text)
        {
            var result = await _textClient.SendTextAsync(text);
            return Ok(result);
        }
    }
}