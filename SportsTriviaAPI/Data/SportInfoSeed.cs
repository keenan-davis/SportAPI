using SportsTriviaAPI.Models;
using System.Collections.Generic;

namespace SportsTriviaAPI.Data
{
    public static class SportInfoSeed
    {
        public static List<SportInfo> All = new List<SportInfo>
        {
            new SportInfo
            {
                Sport = "Soccer",
                Description = "Soccer is played by two teams of 11 players, aiming to score goals by getting the ball into the opponent's net.",
                LatestNews = "Lionel Messi joins Inter Miami in 2023",
                Link = "https://www.fifa.com/news/lionel-messi-joins-inter-miami"
            },
            new SportInfo
            {
                Sport = "Basketball",
                Description = "Basketball is played by two teams of 5 players, aiming to score points by shooting the ball through the opponent's hoop.",
                LatestNews = "Golden State Warriors win 2022–23 NBA Championship",
                Link = "https://www.nba.com/news/warriors-win-2023-championship"
            },
            new SportInfo
            {
                Sport = "Tennis",
                Description = "Tennis is played individually or in pairs, with players hitting a ball over a net to the opponent's side, trying to win points and games.",
                LatestNews = "Novak Djokovic wins latest Grand Slam title",
                Link = "https://www.atptour.com/en/news"
            },
            new SportInfo
            {
                Sport = "Formula 1",
                Description = "Formula 1 is a high-speed car racing sport on circuits around the world, with teams competing for drivers’ and constructors’ championships.",
                LatestNews = "Max Verstappen wins 2023 F1 World Championship",
                Link = "https://www.formula1.com/en/latest.html"
            },
            new SportInfo
            {
                Sport = "MotoGP",
                Description = "MotoGP is motorcycle racing at the highest level, with riders competing on road circuits to achieve fastest lap times and race wins.",
                LatestNews = "Francesco Bagnaia wins 2023 MotoGP World Championship",
                Link = "https://www.motogp.com/en/news"
            },
            new SportInfo
            {
                Sport = "Baseball",
                Description = "Baseball is played by two teams of 9 players each, with the goal to score runs by hitting a pitched ball and running around bases.",
                LatestNews = "Texas Rangers reach the 2023 MLB postseason",
                Link = "https://www.mlb.com/news"
            },
            new SportInfo
            {
                Sport = "Cricket",
                Description = "Cricket is played between two teams of 11 players; teams bat and bowl in innings, trying to score more runs than the opponent.",
                LatestNews = "India wins the 2023 ICC Cricket World Cup",
                Link = "https://www.icc-cricket.com/news"
            },
            new SportInfo
            {
                Sport = "Golf",
                Description = "Golf is an individual sport where players use clubs to hit a ball into a series of holes on a course in as few strokes as possible.",
                LatestNews = "Scottie Scheffler wins the 2023 Masters Tournament",
                Link = "https://www.pgatour.com/news.html"
            },
            new SportInfo
            {
                Sport = "Endurance Racing",
                Description = "Endurance racing involves teams of drivers competing over long-distance races, testing speed, reliability, and strategy.",
                LatestNews = "Toyota wins 2023 24 Hours of Le Mans",
                Link = "https://www.lemans.org/en/news"
            }
        };
    }
}
