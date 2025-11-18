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
                    Description = "Football (soccer) is the world’s most popular sport, played between two teams of eleven players on a rectangular field. The main objective is to score by moving the ball into the opponent's goal using any part of the body except the hands and arms. Modern football involves tactics, formations, and varied playing styles, with leagues and tournaments spanning from local competitions to global events like the FIFA World Cup.",
                    LatestNews = "Alonso ‘accepts’ Arsenal offer for Real Madrid star as the Gunners prepare a major double transfer move worth £105m, signalling a significant shift in their midfield and forward planning.",
                    Rules = "https://www.thefa.com/football-rules-governance/lawsandrules",
                    News = "https://www.football365.com/news/alonso-accepts-arsenal-offer-for-real-madrid-star-as-gunners-will-pay-35m-in-105m-double-swoop",
                    Video = "https://www.youtube.com/watch?v=JN60DCgRu3E"
                },

                "basketball" => new
                {
                    Sport = "Basketball",
                    Description = "Basketball is a fast-paced indoor sport played by two teams of five players each. Players move the ball by passing or dribbling with the aim of shooting it into the opposing team's hoop. The sport emphasizes athleticism, teamwork, strategy, and rapid transitions between offense and defense. It features global leagues, with the NBA being the most followed professional basketball league worldwide.",
                    LatestNews = "Mavericks’ Anthony Davis has been ruled out for an additional 7–10 days as he continues recovery, impacting team rotations and raising questions about upcoming fixture competitiveness.",
                    
                        Rules = "https://fiba.basketball/official-rules",
                        News = "https://africa.espn.com/nba/story/_/id/46992281/mavericks-anthony-davis-least-another-7-10-days",
                        Video = "https://africa.espn.com/video/clip/_/id/46994679"
                    
                },

                "baseball" => new
                {
                    Sport = "Baseball",
                    Description = "Baseball is a bat-and-ball sport played between two teams of nine players. The game revolves around batting, pitching, and fielding as teams attempt to score runs by advancing around four bases arranged in a diamond. Baseball is widely regarded as America’s pastime, featuring strategic plays such as bunting, stealing bases, and bullpen management. Professional leagues emphasize player development, seasonal statistics, and postseason drama.",
                    LatestNews = "Naylor is reportedly nearing a 5-year deal to return to the Mariners, marking a significant long-term investment for the franchise ahead of the upcoming season.",
                    
                        Rules = "https://www.nbcolympics.com/news/baseball-101-rules",
                        News = "https://www.mlb.com/news/josh-naylor-mariners-contract",
                        Video = "https://www.youtube.com/watch?v=X3spvBlvGKI"
                    
                },

                "cricket" => new
                {
                    Sport = "Cricket",
                    Description = "Cricket is a bat-and-ball game played between two teams, involving innings of batting and bowling. Teams attempt to score runs while the opposition tries to take wickets through bowling strategies and fielding formations. The sport spans multiple formats, including Test matches, One Day Internationals, and T20 cricket, each offering unique pacing, strategies, and excitement. Its global popularity is especially strong in countries like India, England, Australia, and South Africa.",
                    LatestNews = "The Bavuma–Bosch moment is being highlighted as a turning point during Harmer's standout Test performance at Eden Gardens, reshaping match momentum and tactical decisions.",
                    
                        Rules = "https://www.lords.org/mcc/the-laws-of-cricket-2d35b4b95a4a67ae8f9c76f258a84aa8",
                        News = "https://www.espncricinfo.com/story/ind-vs-sa-1st-test-temba-bavuma-rishabh-pant-and-simon-harmer-speak-after-the-game-1511422",
                        Video = "https://www.espncricinfo.com/cricket-videos/ind-vs-sa-1st-test-temba-bavuma-gives-south-africa-bowlers-enough-to-play-with-1511394"
                    
                },

                "golf" => new
                {
                    Sport = "Golf",
                    Description = "Golf is a precision sport where players use various clubs to hit a small ball into a series of holes on a course in as few strokes as possible. It emphasizes accuracy, technique, mental discipline, and course management. Golf is played recreationally and professionally worldwide, with major tournaments such as The Masters, The Open Championship, and the Ryder Cup showcasing elite talent.",
                    LatestNews = "Qualifiers for all 2026 Signature Events, THE PLAYERS Championship, and major tournaments have been officially outlined, shaping the competitive landscape for the upcoming season.",
                    
                        Rules = "https://www.randa.org/rog/the-rules-of-golf",
                        News = "https://www.pgatour.com/article/news/golfbet/major-qualifiers",
                        Video = "https://www.youtube.com/watch?v=lN3B9B25V7U"
                    
                },

                "motogp" => new
                {
                    Sport = "MotoGP",
                    Description = "MotoGP is the premier class of motorcycle road racing, featuring prototype bikes of up to 1,000cc. It’s known for its high-speed, technically advanced machines, and global Grand Prix calendar. Riders and teams compete in a series of races around the world, balancing risk, strategy, and sheer horsepower. The championship is managed by Dorna Sports and sanctioned by the FIM." ,
                    LatestNews = "The 2026 MotoGP calendar has been revealed with 22 Grands Prix across five continents, including a historic return to Brazil and marking the final season of the 1000cc era.",
                    
                        Rules = "https://www.motogp.com/en/news/2025/03/11/what-are-the-motogp-rules-a-complete-overview/521386",
                        News = "https://www.motogp.com/en/news",
                        Video = "https://www.youtube.com/watch?v=LJ2b45M7vL0"
                    
                },

                "f1" or "formula1" or "formula 1" => new
                {
                    Sport = "Formula 1",
                    Description = "Formula 1 is the pinnacle of open-wheel motorsport, featuring high-performance cars competing across global circuits in Grand Prix events. Teams combine engineering innovation, aerodynamics, pit strategy, and driver skill to earn championship points throughout the season. The sport is known for intense rivalries, rapid technological evolution, and worldwide fan engagement.",
                    LatestNews = "Perez says he has rediscovered his passion for Formula 1 after his challenging Red Bull exit, promising that his upcoming Cadillac debut will ‘surprise people’ with improved performance and renewed motivation.",
                    
                        Rules = "https://www.formula1.com/en/latest/article/the-beginners-guide-to-the-formula-1-weekend.5RFZzGXNhEi9AEuMXwo987",
                        News = "https://www.formula1.com/en/latest/article/i-think-we-will-surprise-people-perez-on-falling-back-in-love-with-f1-after.37UOTZRkMnK3qHTmuCObFX",
                        Video = "https://youtu.be/zYpKWBXhcik?si=QGBKRHp4460wEGRq"
                    
                },

                "endurance" or "enduranceracing" or "endurance racing" => new
                {
                    Sport = "Endurance Racing",
                    Description = "Endurance racing centers on long-distance events where multiple drivers share a single car, testing durability, consistency, strategy, and stamina. Iconic races like the 24 Hours of Le Mans, Nürburgring 24h, and Daytona place extreme demands on both drivers and machinery. Teams must manage pit strategies, mechanical reliability, nighttime driving, and unpredictable weather.",
                    LatestNews = "A detailed look at Max Verstappen’s much-anticipated Nürburgring GT race debut provides insights into his preparation, expectations, and how this event fits into his broader racing ambitions.",
                    
                        Rules = "https://auto.howstuffworks.com/auto-racing/motorsports/endurance-racing.htm",
                        News = "https://www.motorsport.com/f1/news/everything-you-need-to-know-about-max-verstappens-nurburgring-race-debut/10758599/",
                        Video = "https://www.youtube.com/watch?v=Hzn8hE9A7xQ"
                    
                },

                "tennis" => new
                {
                    Sport = "Tennis",
                    Description = "Tennis is a racket sport played on a rectangular court where players hit a ball over a net, aiming to land it within the opponent’s court in a way that prevents a successful return. The game can be played in singles or doubles formats and requires agility, precision, strategy, and mental toughness. Tennis features major events such as the Australian Open, French Open, Wimbledon, and the US Open.",
                    LatestNews = "Carlos Alcaraz reflected on Jannik Sinner’s resilience following their Nitto ATP Finals clash, praising how Sinner consistently ‘comes back stronger’ and raises his level under pressure.",
                    
                        Rules = "https://www.masterclass.com/articles/how-to-play-tennis",
                        News = "https://www.atptour.com/en/news/alcaraz-nitto-atp-finals-2025-final-reaction-sunday",
                        Video = "https://www.skysports.com/tennis/video/19514/13471406/atp-finals-jannik-sinner-breaks-after-double-hit-in-big-slice-of-luck"
                    
                },

                _ => null
            };

            if (data == null)
                return NotFound(new { Message = "Sport not found." });

            return Ok(data);
        }
    }
}
