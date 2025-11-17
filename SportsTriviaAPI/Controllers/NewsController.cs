using Microsoft.AspNetCore.Mvc;

namespace SportsQuizAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        [HttpGet("{sport}")]
        public IActionResult GetNews(string sport)
        {
            var key = sport.Trim().ToLower();

            var data = key switch
            {
                "football" => new
                {
                    Sport = "Football",
                    Description = "Football (soccer) is played between two teams of eleven players. The objective is to score goals by getting the ball into the opponent's net.",
                    LatestNews = "Alonso ‘accepts’ Arsenal offer for Real Madrid star as Gunners ‘will pay’ £35m in £105m double swoop",
                    Links = new
                    {
                        Rules = "https://www.thefa.com/football-rules-governance/lawsandrules",
                        News = "https://www.football365.com/news/alonso-accepts-arsenal-offer-for-real-madrid-star-as-gunners-will-pay-35m-in-105m-double-swoop",
                        Video = "https://www.youtube.com/watch?v=JN60DCgRu3E"
                    }
                },

                "basketball" => new
                {
                    Sport = "Basketball",
                    Description = "Two teams of five compete to score points by shooting a ball through the opponent’s hoop.",
                    LatestNews = "Mavericks' Anthony Davis out at least another 7-10 days",
                    Links = new
                    {
                        Rules = "https://fiba.basketball/official-rules",
                        News = "https://africa.espn.com/nba/story/_/id/46992281/mavericks-anthony-davis-least-another-7-10-days",
                        Video = "https://africa.espn.com/video/clip/_/id/46994679"
                    }
                },

                "baseball" => new
                {
                    Sport = "Baseball",
                    Description = "Teams of nine players alternate batting and fielding to score runs by running around four bases.",
                    LatestNews = "Naylor nearing 5-year deal to return to Mariners (source)\r\n2:55 AM UTC",
                    Links = new
                    {
                        Rules = "https://www.nbcolympics.com/news/baseball-101-rules",
                        News = "https://www.mlb.com/news/josh-naylor-mariners-contract",
                        Video = "https://www.youtube.com/watch?v=X3spvBlvGKI"
                    }
                },

                "cricket" => new
                {
                    Sport = "Cricket",
                    Description = "Cricket features batting and bowling innings where teams attempt to score runs and take wickets.",
                    LatestNews = "The Bavuma-Bosch 'turning point' in Harmer's Test at Eden Gardens",
                    Links = new
                    {
                        Rules = "https://www.lords.org/mcc/the-laws-of-cricket-2d35b4b95a4a67ae8f9c76f258a84aa8",
                        News = "https://www.espncricinfo.com/story/ind-vs-sa-1st-test-temba-bavuma-rishabh-pant-and-simon-harmer-speak-after-the-game-1511422",
                        Video = "https://www.espncricinfo.com/cricket-videos/ind-vs-sa-1st-test-temba-bavuma-gives-south-africa-bowlers-enough-to-play-with-1511394"
                    }
                },

                "golf" => new
                {
                    Sport = "Golf",
                    Description = "Players aim to hit a ball into a series of holes in as few strokes as possible.",
                    LatestNews = "Qualifiers for all 2026 Signature Events, THE PLAYERS and majors",
                    Links = new
                    {
                        Rules = "https://www.randa.org/rog/the-rules-of-golf",
                        News = "https://www.pgatour.com/article/news/golfbet/major-qualifiers",
                        Video = "https://www.youtube.com/watch?v=lN3B9B25V7U"
                    }
                },

                "f1" or "formula1" or "formula 1" => new
                {
                    Sport = "Formula 1",
                    Description = "F1 involves open-wheel cars competing in global Grand Prix races for championship points.",
                    LatestNews = "‘I think we will surprise people’ – Perez on falling back in love with F1 after ‘difficult’ Red Bull exit and his hopes for Cadillac debut",
                    Links = new
                    {
                        Rules = "https://www.formula1.com/en/latest/article/the-beginners-guide-to-the-formula-1-weekend.5RFZzGXNhEi9AEuMXwo987",
                        News = "https://www.formula1.com/en/latest/article/i-think-we-will-surprise-people-perez-on-falling-back-in-love-with-f1-after.37UOTZRkMnK3qHTmuCObFX",
                        Video = "https://youtu.be/Ng2epDq-Lo0"
                    }
                },

                "endurance" => new
                {
                    Sport = "Endurance Racing",
                    Description = "Endurance racing involves long multi-driver events like the 24 Hours of Le Mans.",
                    LatestNews = "Everything you need to know about Max Verstappen's Nurburgring GT race debut",
                    Links = new
                    {
                        Rules = "https://auto.howstuffworks.com/auto-racing/motorsports/endurance-racing.htm",
                        News = "https://www.motorsport.com/f1/news/everything-you-need-to-know-about-max-verstappens-nurburgring-race-debut/10758599/",
                        Video = "https://www.youtube.com/watch?v=Hzn8hE9A7xQ"
                    }
                },

                "tennis" => new
                {
                    Sport = "Tennis",
                    Description = "Tennis involves hitting a ball over a net so the opponent cannot return it. Played in singles or doubles.",
                    LatestNews = "Alcaraz reflects on Sinner following Nitto ATP Finals clash: 'He always comes back stronger'",
                    Links = new
                    {
                        Rules = "https://www.masterclass.com/articles/how-to-play-tennis",
                        News = "https://www.atptour.com/en/news/alcaraz-nitto-atp-finals-2025-final-reaction-sunday",
                        Video = "https://www.skysports.com/tennis/video/19514/13471406/atp-finals-jannik-sinner-breaks-after-double-hit-in-big-slice-of-luck"
                    }
                },

                _ => null
            };

            if (data == null)
                return NotFound(new { Message = "Sport not found." });

            return Ok(data);
        }
    }
}
