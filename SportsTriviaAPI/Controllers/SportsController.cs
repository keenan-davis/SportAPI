using Microsoft.AspNetCore.Mvc;

namespace SportsQuizAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {
        private static readonly List<string> Sports = new()
        {
            "Football",
            "Formula 1",
            "MotoGP",
            "Endurance Racing",
            "Tennis",
            "Basketball",
            "Baseball",
            "Cricket",
            "Golf"
        };

        [HttpGet]
        public IActionResult GetAllSports()
        {
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
