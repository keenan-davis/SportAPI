namespace SportsTriviaAPI.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Category { get; set; } = "Sports";
        public string Difficulty { get; set; } = "easy";
        public string Text { get; set; } = "";
        public string CorrectAnswer { get; set; } = "";
        public List<string> Options { get; set; } = new();
    }

    public class GameResult
    {
        public int Score { get; set; }
        public int TotalQuestions { get; set; }
        public string Category { get; set; } = "Sports";
        public string Difficulty { get; set; } = "easy";
        public double Accuracy => TotalQuestions > 0 ? (double)Score / TotalQuestions * 100 : 0;
    }

    public class AnswerRequest
    {
        public int QuestionId { get; set; }
        public string UserAnswer { get; set; } = "";
    }
    public class GameRequest
    {
        public string? Category { get; set; } 
        public string? Difficulty { get; set; } 
        public int NumberOfQuestions { get; set; } = 5;
        public List<AnswerRequest>? Answers { get; set; } // optional answers submitted by the player
    }
    public class VerifyResponse
    {
        public bool IsCorrect { get; set; }
        public string CorrectAnswer { get; set; } = "";
    }
    public class SportInfo
    {
        public string Sport { get; set; } = "Unknown";
        public string Description { get; set; } = "";
        public string LatestNews { get; set; } = "";
        public string Link { get; set; } = "";
    }
}