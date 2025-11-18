using Microsoft.AspNetCore.Mvc;

namespace SportsQuizAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthController : ControllerBase
    {
        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            return Ok(new { status = "ok" });
        }
    }
}