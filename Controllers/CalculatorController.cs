using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("sum")]
    public ActionResult<double> Sum([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(a + b);
    }

    [HttpGet("subtract")]
    public ActionResult<double> Subtract([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(a - b);
    }

    [HttpGet("multiply")]
    public ActionResult<double> Multiply([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(a * b);
    }

    [HttpGet("divide")]
    public ActionResult<double> Divide([FromQuery] double a, [FromQuery] double b)
    {
        if (b == 0)
            return BadRequest("Parameter 'b' must not be zero.");
        return Ok(a / b);
    }
}