using Microsoft.AspNetCore.Mvc;

namespace SportsQuizAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {
        // List of supported sports for dropdowns / selection menus
        private static readonly List<string> Sports = new()
        {
            "Soccer",
            "Formula 1",
            "MotoGP",
            "Endurance",
            "Tennis",
            "Basketball",
            "Baseball",
            "Cricket",
            "Golf"
        };

        [HttpGet]
        public IActionResult GetAllSports()
        {
            // Return sports plus helpful endpoints for the Android app
            var response = Sports.Select(sport => new
            {
                Name = sport,
                NewsEndpoint = $"/api/news/{sport.ToLower().Replace(" ", "")}",
                RulesEndpoint = $"/api/rules/{sport.ToLower().Replace(" ", "")}",
                QuestionsEndpoint = $"/api/questions?category={sport.Replace(" ", "%20")}"
            });

            return Ok(response);
        }
    }
}
