// https://localhost:7130/api/math/add?a=1&b=3
// https://localhost:7130/api/math/div?a=1&b=3
// https://localhost:7130/api/math/sub?a=1&b=3
// https://localhost:7130/api/math/mult?a=1&b=3

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly CalcService _calcService;

    public MathController(CalcService calcService)
    {
        _calcService = calcService;
    }

    [HttpGet("add")]
    public IActionResult Add(int a, int b)
    {
        var result = _calcService.Add(a, b);
        return Ok($"{a} + {b} = {result}");
    }

    [HttpGet("sub")]
    public IActionResult Sub(int a, int b)
    {
        var result = _calcService.Sub(a, b);
        return Ok($"{a} - {b} = {result}");
    }

    [HttpGet("mult")]
    public IActionResult Mult(int a, int b)
    {
        var result = _calcService.Mult(a, b);
        return Ok($"{a} * {b} = {result}");
    }

    [HttpGet("div")]
    public IActionResult Div(int a, int b)
    {
        try
        {
            var result = _calcService.Div(a, b);
            return Ok($"{a} / {b} = {result}");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
