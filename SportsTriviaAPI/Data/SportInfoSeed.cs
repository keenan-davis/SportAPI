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
                Description = "Soccer is played by two teams of 11 players, aiming to score goals by getting the ball into the opponent's net. The game is known for its continuous flow, strategic passing, and reliance on player positioning and teamwork. It is the world’s most popular sport, governed by FIFA and played in major leagues and international competitions across the globe.",
                LatestNews = "Lionel Messi joins Inter Miami in 2023, marking one of the biggest transfers in MLS history and bringing unprecedented global attention to the league as fans anticipate his impact on American soccer.",
                Link = "https://www.fifa.com/news/lionel-messi-joins-inter-miami"
            },
            new SportInfo
            {
                Sport = "Basketball",
                Description = "Basketball is played by two teams of 5 players, aiming to score points by shooting the ball through the opponent's hoop. The sport is fast-paced, emphasizing dribbling, passing, tactical plays, and athleticism. It is overseen by the NBA at the professional level, with global tournaments like the FIBA World Cup further expanding its influence.",
                LatestNews = "Golden State Warriors win the 2022–23 NBA Championship after a dominant playoff performance, solidifying their dynasty and showcasing the continued brilliance of Stephen Curry and the team's strong core.",
                Link = "https://www.nba.com/news/warriors-win-2023-championship"
            },
            new SportInfo
            {
                Sport = "Tennis",
                Description = "Tennis is played individually or in pairs, with players hitting a ball over a net to the opponent’s court while using technique, footwork, and strategy to win points, games, and sets. The sport includes prestigious tournaments known as the Grand Slams, attracting top players from around the world.",
                LatestNews = "Novak Djokovic wins another Grand Slam title, further extending his record-breaking achievements and reinforcing his status as one of the greatest tennis players of all time.",
                Link = "https://www.atptour.com/en/news"
            },
            new SportInfo
            {
                Sport = "Formula 1",
                Description = "Formula 1 is a high-speed global motorsport featuring cutting-edge race cars engineered for extreme performance. Teams and drivers compete across international circuits, focusing on aerodynamics, strategy, pit stops, and driver skill to win the Drivers’ and Constructors’ Championships.",
                LatestNews = "Max Verstappen wins the 2023 F1 World Championship, continuing his dominant streak in the sport and securing another title for Red Bull Racing after a season of remarkable consistency and race victories.",
                Link = "https://www.formula1.com/en/latest.html"
            },
            new SportInfo
            {
                Sport = "MotoGP",
                Description = "MotoGP is the premier class of motorcycle racing, featuring high-performance bikes capable of incredible speed and agility. Riders compete on road circuits worldwide, relying on precision, reflexes, and racecraft to outperform their rivals.",
                LatestNews = "Francesco Bagnaia wins the 2023 MotoGP World Championship after an intense season, showcasing exceptional riding skill and strategic excellence for the Ducati team.",
                Link = "https://www.motogp.com/en/news"
            },
            new SportInfo
            {
                Sport = "Baseball",
                Description = "Baseball is played by two teams of 9 players each, focusing on batting, pitching, and fielding to score runs by hitting a ball and advancing around bases. The sport is known for its deep strategy, statistical analysis, and long-standing traditions in leagues like Major League Baseball.",
                LatestNews = "Texas Rangers reach the 2023 MLB postseason, marking a strong comeback season and positioning the team as a major contender with impressive performances throughout the year.",
                Link = "https://www.mlb.com/news"
            },
            new SportInfo
            {
                Sport = "Cricket",
                Description = "Cricket involves two teams of 11 players competing in batting and bowling innings. The sport includes multiple formats—from Test matches to T20 games—requiring a blend of technique, strategy, and endurance. It is especially popular in countries like India, England, Australia, and South Africa.",
                LatestNews = "India wins the 2023 ICC Cricket World Cup after delivering dominating performances throughout the tournament, showcasing world-class batting, bowling, and fielding in a historic victory.",
                Link = "https://www.icc-cricket.com/news"
            },
            new SportInfo
            {
                Sport = "Golf",
                Description = "Golf is an individual precision sport where players use clubs to hit a ball across varying terrains toward a series of holes. The objective is to complete the course in the fewest strokes possible. Professional golf features major tournaments such as the Masters, U.S. Open, and PGA Championship.",
                LatestNews = "Scottie Scheffler wins the 2023 Masters Tournament, demonstrating exceptional consistency and solidifying his position among the top golfers in the world with a commanding performance.",
                Link = "https://www.pgatour.com/news.html"
            },
            new SportInfo
            {
                Sport = "Endurance Racing",
                Description = "Endurance racing features long-distance motorsport events where teams of drivers rotate over several hours or even 24-hour periods. Success requires reliability, strategy, fuel management, and teamwork, making races like the 24 Hours of Le Mans iconic in motorsport history.",
                LatestNews = "Toyota wins the 2023 24 Hours of Le Mans, continuing their strong run in endurance racing with an excellent team performance that balanced speed, reliability, and strategy.",
                Link = "https://www.lemans.org/en/news"
            }

        };
    }
}
