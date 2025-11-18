using Microsoft.AspNetCore.Mvc;
using SportsTriviaAPI.Data;
using SportsTriviaAPI.Models;

namespace SportsTriviaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private static readonly Random Random = new();

        // GET: api/questions
        [HttpGet]
        public ActionResult<IEnumerable<Question>> GetAll()
        {
            return Ok(QuestionsSeed.Questions);
        }

        // GET: api/questions/1001
        [HttpGet("{id:int}")]
        public ActionResult<Question> GetById(int id)
        {
            var question = QuestionsSeed.Questions.FirstOrDefault(q => q.Id == id);
            if (question == null)
                return NotFound(new { Message = $"Question with ID {id} not found." });

            return Ok(question);
        }

        // GET: api/questions/filter?category=Soccer&difficulty=Easy&page=1&pageSize=5
        [HttpGet("filter")]
        public ActionResult<IEnumerable<Question>> GetFiltered(
            [FromQuery] string? category = null,
            [FromQuery] string? difficulty = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            var query = QuestionsSeed.Questions.AsEnumerable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(difficulty))
                query = query.Where(q => q.Difficulty.Equals(difficulty, StringComparison.OrdinalIgnoreCase));

            var totalAvailable = query.Count();

            var filteredQuestions = query
                .OrderBy(q => Random.Next()) // shuffle
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            if (!filteredQuestions.Any())
                return NotFound(new { Message = "No questions found for the given criteria." });

            return Ok(new
            {
                TotalAvailable = totalAvailable,
                Page = page,
                PageSize = pageSize,
                Questions = filteredQuestions
            });
        }

        // POST: api/questions/verify
        [HttpPost("verify")]
        public ActionResult<VerifyResponse> VerifyAnswer([FromBody] AnswerRequest request)
        {
            var question = QuestionsSeed.Questions.FirstOrDefault(q => q.Id == request.QuestionId);
            if (question == null)
                return NotFound(new { Message = $"Question with ID {request.QuestionId} not found." });

            var isCorrect = string.Equals(question.CorrectAnswer, request.UserAnswer, StringComparison.OrdinalIgnoreCase);

            return Ok(new VerifyResponse
            {
                IsCorrect = isCorrect,
                CorrectAnswer = question.CorrectAnswer
            });
        }
        // POST: api/questions/game
        [HttpPost("game")]
        public ActionResult<GameResult> PlayGame([FromBody] GameRequest request)
        {
            var query = QuestionsSeed.Questions.AsEnumerable();

            if (!string.IsNullOrEmpty(request.Category))
                query = query.Where(q => q.Category.Equals(request.Category, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(request.Difficulty))
                query = query.Where(q => q.Difficulty.Equals(request.Difficulty, StringComparison.OrdinalIgnoreCase));

            var totalAvailable = query.Count();
            if (totalAvailable == 0)
                return NotFound(new { Message = "No questions found for the given criteria." });

            var questions = query
                .OrderBy(q => Random.Next()) 
                .Take(request.NumberOfQuestions)
                .ToList();

            int score = 0;

            if (request.Answers != null && request.Answers.Any())
            {
                foreach (var answer in request.Answers)
                {
                    var question = questions.FirstOrDefault(q => q.Id == answer.QuestionId);
                    if (question != null && string.Equals(question.CorrectAnswer, answer.UserAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        score++;
                    }
                }
            }

            return Ok(new GameResult
            {
                Score = score,
                TotalQuestions = questions.Count,
                Category = request.Category ?? "All",
                Difficulty = request.Difficulty ?? "All"
            });
        }

    }
}

