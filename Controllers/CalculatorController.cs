using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CalculatorController : Controller
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new { a, b, result });
        }

        [HttpGet("subtract")]
        public IActionResult GetSubtract([FromQuery] int a, [FromQuery] int b)
        {
            var result = a - b;
            return Ok(new { a, b, result });
        }

        [HttpGet("multiply")]
        public IActionResult GetMultiply([FromQuery] int a, [FromQuery] int b)
        {
            var result = a * b;
            return Ok(new { a, b, result });
        }

        [HttpGet("divide")]
        public IActionResult GetDivide([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0)
                return BadRequest("No se puede dividir entre cero.");

            var result = (double)a / b;
            return Ok(new { a, b, result });
        }
    }
}