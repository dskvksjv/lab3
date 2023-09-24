using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TimeController : ControllerBase
{
    [HttpGet("time")]
    public IActionResult GetTime([FromServices] ServiceTime serviceTime)
    {
        var time = serviceTime.GetTime();
        return Ok(time);
    }
}
