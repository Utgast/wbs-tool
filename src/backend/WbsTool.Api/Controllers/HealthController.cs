using Microsoft.AspNetCore.Mvc;

namespace WbsTool.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "ok",
            service = "WbsTool.Api",
            timestamp = DateTime.UtcNow
        });
    }
}