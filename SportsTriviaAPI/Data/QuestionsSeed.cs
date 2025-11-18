using SportsTriviaAPI.Models;

namespace SportsTriviaAPI.Data
{
    public class QuestionsSeed
    {
        public static List<Question> Questions = new List<Question>
        {
            // FOOTBALL
            // Easy (1001–1010)
            new Question { Id = 1001, Category = "Football", Difficulty = "easy", Text = "Which country won the 2018 FIFA World Cup?", Options = new () { "France", "Croatia", "Brazil", "Germany" }, CorrectAnswer = "France" },
            new Question { Id = 1002, Category = "Football", Difficulty = "easy", Text = "How many players are on the field per soccer team?", Options = new() { "9", "10", "11", "12" }, CorrectAnswer = "11" },
            new Question { Id = 1003, Category = "Football", Difficulty = "easy", Text = "What is the name of the governing body of world soccer?", Options = new() { "UEFA", "CAF", "FIFA", "FA" }, CorrectAnswer = "FIFA" },
            new Question { Id = 1004, Category = "Football", Difficulty = "easy", Text = "Which player is known as 'CR7'?", Options = new() { "Cristiano Ronaldo", "Lionel Messi", "Neymar Jr.", "Kylian Mbappé" }, CorrectAnswer = "Cristiano Ronaldo" },
            new Question { Id = 1005, Category = "Football", Difficulty = "easy", Text = "Which country hosts the Premier League?", Options = new() { "Spain", "Italy", "England", "Germany" }, CorrectAnswer = "England" },
            new Question { Id = 1006, Category = "Football", Difficulty = "easy", Text = "What part of the body cannot be used in soccer?", Options = new() { "Feet", "Head", "Chest", "Hands" }, CorrectAnswer = "Hands" },
            new Question { Id = 1007, Category = "Football", Difficulty = "easy", Text = "What is the name of Barcelona’s stadium?", Options = new() { "Santiago Bernabéu", "Camp Nou", "Emirates Stadium", "Allianz Arena" }, CorrectAnswer = "Camp Nou" },
            new Question { Id = 1008, Category = "Football", Difficulty = "easy", Text = "Which country won the 2010 World Cup?", Options = new() { "Netherlands", "Germany", "Spain", "Brazil" }, CorrectAnswer = "Spain" },
            new Question { Id = 1009, Category = "Football", Difficulty = "easy", Text = "What card is shown for serious fouls?", Options = new() { "Blue", "Yellow", "Red", "Green" }, CorrectAnswer = "Red" },
            new Question { Id = 1010, Category = "Football", Difficulty = "easy", Text = "How long is a standard soccer match?", Options = new() { "60 min", "75 min", "90 min", "100 min" }, CorrectAnswer = "90 min" },

            // Medium (1011–1020)
            new Question { Id = 1011, Category = "Football", Difficulty = "medium", Text = "Who won the Ballon d'Or in 2021?", Options = new() { "Messi", "Lewandowski", "Ronaldo", "Modrić" }, CorrectAnswer = "Messi" },
            new Question { Id = 1012, Category = "Football", Difficulty = "medium", Text = "Which club did Erling Haaland play for before Manchester City?", Options = new() { "Salzburg", "Dortmund", "Molde", "Leeds" }, CorrectAnswer = "Dortmund" },
            new Question { Id = 1013, Category = "Football", Difficulty = "medium", Text = "Which nation has the most World Cup titles?", Options = new() { "Brazil", "Germany", "Italy", "Argentina" }, CorrectAnswer = "Brazil" },
            new Question { Id = 1014, Category = "Football", Difficulty = "medium", Text = "Which Spanish club is nicknamed 'Los Blancos'?", Options = new() { "Barcelona", "Real Madrid", "Sevilla", "Valencia" }, CorrectAnswer = "Real Madrid" },
            new Question { Id = 1015, Category = "Football", Difficulty = "medium", Text = "Who is the Premier League’s all-time top scorer?", Options = new() { "Wayne Rooney", "Sergio Agüero", "Alan Shearer", "Harry Kane" }, CorrectAnswer = "Alan Shearer" },
            new Question { Id = 1016, Category = "Football", Difficulty = "medium", Text = "Which club is known as 'The Red Devils'?", Options = new() { "Liverpool", "Bayern Munich", "Man United", "Benfica" }, CorrectAnswer = "Man United" },
            new Question { Id = 1017, Category = "Football", Difficulty = "medium", Text = "Which country hosted the 2014 World Cup?", Options = new() { "Brazil", "South Africa", "Russia", "Germany" }, CorrectAnswer = "Brazil" },
            new Question { Id = 1018, Category = "Football", Difficulty = "medium", Text = "Which African country has won the AFCON the most times?", Options = new() { "Nigeria", "Egypt", "Cameroon", "Ghana" }, CorrectAnswer = "Egypt" },
            new Question { Id = 1019, Category = "Football", Difficulty = "medium", Text = "Which club did Lionel Messi join in 2023?", Options = new() { "PSG", "Inter Miami", "Barcelona", "Man City" }, CorrectAnswer = "Inter Miami" },
            new Question { Id = 1020, Category = "Football", Difficulty = "medium", Text = "Which manager has the most Premier League titles?", Options = new() { "Pep Guardiola", "José Mourinho", "Arsène Wenger", "Alex Ferguson" }, CorrectAnswer = "Alex Ferguson" },

            // Hard (1021–1030)
            new Question { Id = 1021, Category = "Football", Difficulty = "hard", Text = "Which goalkeeper has the most clean sheets in Premier League history?", Options = new() { "Petr Čech", "Edwin van der Sar", "David Seaman", "Alisson Becker" }, CorrectAnswer = "Petr Čech" },
            new Question { Id = 1022, Category = "Football", Difficulty = "hard", Text = "Which club won the first-ever Champions League (European Cup) in 1956?", Options = new() { "Barcelona", "Benfica", "Real Madrid", "Inter Milan" }, CorrectAnswer = "Real Madrid" },
            new Question { Id = 1023, Category = "Football", Difficulty = "hard", Text = "Who is the youngest goal scorer in World Cup history?", Options = new() { "Pelé", "Mbappé", "Maradona", "Rooney" }, CorrectAnswer = "Pelé" },
            new Question { Id = 1024, Category = "Football", Difficulty = "hard", Text = "Which nation won the first FIFA World Cup in 1930?", Options = new() { "Brazil", "Uruguay", "Argentina", "Italy" }, CorrectAnswer = "Uruguay" },
            new Question { Id = 1025, Category = "Football", Difficulty = "hard", Text = "Which manager won the treble with Manchester United in 1999?", Options = new() { "Alex Ferguson", "Ron Atkinson", "David Moyes", "Jürgen Klopp" }, CorrectAnswer = "Alex Ferguson" },
            new Question { Id = 1026, Category = "Football", Difficulty = "hard", Text = "Which African player has the most Premier League goals?", Options = new() { "Salah", "Drogba", "Mané", "Adebayor" }, CorrectAnswer = "Salah" },
            new Question { Id = 1027, Category = "Football", Difficulty = "hard", Text = "Which Italian club is known as 'La Vecchia Signora'?", Options = new() { "AC Milan", "Juventus", "Roma", "Napoli" }, CorrectAnswer = "Juventus" },
            new Question { Id = 1028, Category = "Football", Difficulty = "hard", Text = "Which player scored the 'Hand of God' goal?", Options = new() { "Maradona", "Pelé", "Baggio", "Lineker" }, CorrectAnswer = "Maradona" },
            new Question { Id = 1029, Category = "Football", Difficulty = "hard", Text = "Which club has won the most UEFA Champions League titles?", Options = new() { "Barcelona", "Real Madrid", "Liverpool", "AC Milan" }, CorrectAnswer = "Real Madrid" },
            new Question { Id = 1030, Category = "Football", Difficulty = "hard", Text = "Which country has appeared in the most World Cup finals?", Options = new() { "Brazil", "Germany", "Italy", "Argentina" }, CorrectAnswer = "Germany" },
            
            // FORMULA 1 
            // Easy (2001–2010)
            new Question {
                Id = 2001,
                Category = "F1",
                Difficulty = "easy",
                Text = "How many wheels does an F1 car have?",
                CorrectAnswer = "4",
                Options = new List<string>{"4","6","3","2"}
            },
            new Question {
                Id = 2002,
                Category = "F1",
                Difficulty = "easy",
                Text = "Which team is known for its red cars?",
                CorrectAnswer = "Ferrari",
                Options = new List<string>{"Ferrari","Mercedes","McLaren","Red Bull"}
            },
            new Question {
                Id = 2003,
                Category = "F1",
                Difficulty = "easy",
                Text = "What color flag ends an F1 race?",
                CorrectAnswer = "Checkered",
                Options = new List<string>{"Checkered","Red","Green","Blue"}
            },
            new Question {
                Id = 2004,
                Category = "F1",
                Difficulty = "easy",
                Text = "Who won the 2023 F1 World Championship?",
                CorrectAnswer = "Max Verstappen",
                Options = new List<string>{"Max Verstappen","Lewis Hamilton","Lando Norris","Charles Leclerc"}
            },
            new Question {
                Id = 2005,
                Category = "F1",
                Difficulty = "easy",
                Text = "Which country hosts the Monaco GP?",
                CorrectAnswer = "Monaco",
                Options = new List<string>{"Monaco","France","Italy","Spain"}
            },
            new Question {
                Id = 2006,
                Category = "F1",
                Difficulty = "easy",
                Text = "What does 'DRS' stand for?",
                CorrectAnswer = "Drag Reduction System",
                Options = new List<string>{"Drag Reduction System","Downforce Rear Sync","Drive Reaction System","Dynamic Racing Setup"}
            },
            new Question {
                Id = 2007,
                Category = "F1",
                Difficulty = "easy",
                Text = "What surface does F1 race on?",
                CorrectAnswer = "Tarmac",
                Options = new List<string>{"Tarmac","Gravel","Dirt","Sand"}
            },
            new Question {
                Id = 2008,
                Category = "F1",
                Difficulty = "easy",
                Text = "What is the top governing body of F1?",
                CorrectAnswer = "FIA",
                Options = new List<string>{"FIA","FIM","NASCAR","UEFA"}
            },
            new Question {
                Id = 2009,
                Category = "F1",
                Difficulty = "easy",
                Text = "Which team has a silver livery?",
                CorrectAnswer = "Mercedes",
                Options = new List<string>{"Mercedes","Ferrari","Aston Martin","Williams"}
            },
            new Question {
                Id = 2010,
                Category = "F1",
                Difficulty = "easy",
                Text = "Where is Silverstone located?",
                CorrectAnswer = "United Kingdom",
                Options = new List<string>{"United Kingdom","USA","Germany","Belgium"}
            },

            // Medium (2011–2020)
            new Question {
                Id = 2011,
                Category = "F1",
                Difficulty = "medium",
                Text = "Which circuit is known as 'The Temple of Speed'?",
                CorrectAnswer = "Monza",
                Options = new List<string>{"Monza","Spa","Silverstone","Suzuka"}
            },
            new Question {
                Id = 2012,
                Category = "F1",
                Difficulty = "medium",
                Text = "Who holds the record for most pole positions?",
                CorrectAnswer = "Lewis Hamilton",
                Options = new List<string>{"Lewis Hamilton","Sebastian Vettel","Ayrton Senna","Michael Schumacher"}
            },
            new Question {
                Id = 2013,
                Category = "F1",
                Difficulty = "medium",
                Text = "Which country hosted the first F1 race in 1950?",
                CorrectAnswer = "United Kingdom",
                Options = new List<string>{"United Kingdom","Italy","USA","Monaco"}
            },
            new Question {
                Id = 2014,
                Category = "F1",
                Difficulty = "medium",
                Text = "What year did hybrid engines debut?",
                CorrectAnswer = "2014",
                Options = new List<string>{"2014","2010","2016","2012"}
            },
            new Question {
                Id = 2015,
                Category = "F1",
                Difficulty = "medium",
                Text = "Which team did Ayrton Senna win 3 championships with?",
                CorrectAnswer = "McLaren",
                Options = new List<string>{"McLaren","Lotus","Williams","Ferrari"}
            },
            new Question {
                Id = 2016,
                Category = "F1",
                Difficulty = "medium",
                Text = "Which track has the famous Eau Rouge corner?",
                CorrectAnswer = "Spa",
                Options = new List<string>{"Spa","Monaco","Interlagos","Suzuka"}
            },
            new Question {
                Id = 2017,
                Category = "F1",
                Difficulty = "medium",
                Text = "What country is Red Bull Racing based in?",
                CorrectAnswer = "United Kingdom",
                Options = new List<string>{"United Kingdom","Austria","Germany","USA"}
            },
            new Question {
                Id = 2018,
                Category = "F1",
                Difficulty = "medium",
                Text = "Who was the 2016 F1 World Champion?",
                CorrectAnswer = "Nico Rosberg",
                Options = new List<string>{"Nico Rosberg","Lewis Hamilton","Sebastian Vettel","Fernando Alonso"}
            },
            new Question {
                Id = 2019,
                Category = "F1",
                Difficulty = "medium",
                Text = "Where is the Suzuka circuit located?",
                CorrectAnswer = "Japan",
                Options = new List<string>{"Japan","China","Malaysia","South Korea"}
            },
            new Question {
                Id = 2020,
                Category = "F1",
                Difficulty = "medium",
                Text = "Which team uses a 'bull' logo?",
                CorrectAnswer = "Red Bull Racing",
                Options = new List<string>{"Red Bull Racing","AlphaTauri","Ferrari","Haas"}
            },

            // Hard (2021–2030)
            new Question {
                Id = 2021,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which driver achieved the first Grand Slam (pole, win, fastest lap, led every lap)?",
                CorrectAnswer = "Alberto Ascari",
                Options = new List<string>{"Alberto Ascari","Jim Clark","Ayrton Senna","Michael Schumacher"}
            },
            new Question {
                Id = 2022,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which year was the 'ground effect' era banned?",
                CorrectAnswer = "1983",
                Options = new List<string>{"1983","1980","1986","1990"}
            },
            new Question {
                Id = 2023,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which driver has the longest career in races started?",
                CorrectAnswer = "Fernando Alonso",
                Options = new List<string>{"Fernando Alonso","Kimi Räikkönen","Rubens Barrichello","Lewis Hamilton"}
            },
            new Question {
                Id = 2024,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which team ran the fan car (Brabham BT46B)?",
                CorrectAnswer = "Brabham",
                Options = new List<string>{"Brabham","Lotus","Williams","Ferrari"}
            },
            new Question {
                Id = 2025,
                Category = "F1",
                Difficulty = "hard",
                Text = "What was Michael Schumacher's debut year?",
                CorrectAnswer = "1991",
                Options = new List<string>{"1991","1990","1992","1989"}
            },
            new Question {
                Id = 2026,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which driver won the 1999 European GP in chaotic conditions?",
                CorrectAnswer = "Johnny Herbert",
                Options = new List<string>{"Johnny Herbert","Heinz-Harald Frentzen","Mika Häkkinen","David Coulthard"}
            },
            new Question {
                Id = 2027,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which constructor built the MP4/4?",
                CorrectAnswer = "McLaren",
                Options = new List<string>{"McLaren","Williams","Ferrari","Benetton"}
            },
            new Question {
                Id = 2028,
                Category = "F1",
                Difficulty = "hard",
                Text = "Who won Ferrari's last WDC before 2000?",
                CorrectAnswer = "Jody Scheckter",
                Options = new List<string>{"Jody Scheckter","Niki Lauda","Gilles Villeneuve","Michael Schumacher"}
            },
            new Question {
                Id = 2029,
                Category = "F1",
                Difficulty = "hard",
                Text = "Which circuit hosted the first night race?",
                CorrectAnswer = "Singapore",
                Options = new List<string>{"Singapore","Bahrain","Abu Dhabi","Qatar"}
            },
            new Question {
                Id = 2030,
                Category = "F1",
                Difficulty = "hard",
                Text = "What team did Juan Manuel Fangio win his final title with?",
                CorrectAnswer = "Mercedes",
                Options = new List<string>{"Mercedes","Maserati","Ferrari","Alfa Romeo"}
            },
                    
            // MOTOGP 
            // Easy (3001–3010)
            new Question {
                Id = 3001,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "What type of vehicles race in MotoGP?",
                CorrectAnswer = "Motorcycles",
                Options = new List<string>{"Motorcycles","Cars","ATVs","Go-Karts"}
            },
            new Question {
                Id = 3002,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "Who is known as 'The Doctor'?",
                CorrectAnswer = "Valentino Rossi",
                Options = new List<string>{"Valentino Rossi","Marc Márquez","Jorge Lorenzo","Casey Stoner"}
            },
            new Question {
                Id = 3003,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "Which manufacturer uses the 'Yamaha' name?",
                CorrectAnswer = "Yamaha",
                Options = new List<string>{"Yamaha","Honda","Ducati","KTM"}
            },
            new Question {
                Id = 3004,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "How many wheels does a MotoGP bike have?",
                CorrectAnswer = "2",
                Options = new List<string>{"2","3","4","1"}
            },
            new Question {
                Id = 3005,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "Which rider has the #93?",
                CorrectAnswer = "Marc Márquez",
                Options = new List<string>{"Marc Márquez","Rossi","Bagnaia","Quartararo"}
            },
            new Question {
                Id = 3006,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "What does 'GP' stand for?",
                CorrectAnswer = "Grand Prix",
                Options = new List<string>{"Grand Prix","Gear Performance","Global Power","Grip Precision"}
            },
            new Question {
                Id = 3007,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "Which country hosts the Mugello GP?",
                CorrectAnswer = "Italy",
                Options = new List<string>{"Italy","Spain","USA","Japan"}
            },
            new Question {
                Id = 3008,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "What color flag stops a MotoGP race?",
                CorrectAnswer = "Red",
                Options = new List<string>{"Red","Yellow","Blue","Green"}
            },
            new Question {
                Id = 3009,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "Which manufacturer is red in MotoGP?",
                CorrectAnswer = "Ducati",
                Options = new List<string>{"Ducati","Honda","KTM","Aprilia"}
            },
            new Question {
                Id = 3010,
                Category = "MotoGP",
                Difficulty = "easy",
                Text = "What is MotoGP's governing body?",
                CorrectAnswer = "FIM",
                Options = new List<string>{"FIM","FIA","UEC","IRTA"}
            },

            // Medium (3011–3020)
            new Question {
                Id = 3011,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Who won the 2021 MotoGP Championship?",
                CorrectAnswer = "Fabio Quartararo",
                Options = new List<string>{"Fabio Quartararo","Marc Márquez","Bagnaia","Rossi"}
            },
            new Question {
                Id = 3012,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which track is known as 'The Cathedral of Speed'?",
                CorrectAnswer = "Assen",
                Options = new List<string>{"Assen","Mugello","Silverstone","Sepang"}
            },
            new Question {
                Id = 3013,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which manufacturer does Marc Márquez ride for (2024)?",
                CorrectAnswer = "Ducati",
                Options = new List<string>{"Ducati","Honda","Yamaha","Aprilia"}
            },
            new Question {
                Id = 3014,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Who holds the most premier-class titles?",
                CorrectAnswer = "Giacomo Agostini",
                Options = new List<string>{"Giacomo Agostini","Rossi","Márquez","Lorenzo"}
            },
            new Question {
                Id = 3015,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which country hosts the Phillip Island race?",
                CorrectAnswer = "Australia",
                Options = new List<string>{"Australia","Spain","USA","France"}
            },
            new Question {
                Id = 3016,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "What year did MotoGP switch to four-stroke engines?",
                CorrectAnswer = "2002",
                Options = new List<string>{"2002","2000","2005","1998"}
            },
            new Question {
                Id = 3017,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which team uses an orange livery?",
                CorrectAnswer = "KTM",
                Options = new List<string>{"KTM","Ducati","Yamaha","Honda"}
            },
            new Question {
                Id = 3018,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Who was Rossi's long-time rival?",
                CorrectAnswer = "Casey Stoner",
                Options = new List<string>{"Casey Stoner","Lorenzo","Pedrosa","Biaggi"}
            },
            new Question {
                Id = 3019,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which track features the Corkscrew?",
                CorrectAnswer = "Laguna Seca",
                Options = new List<string>{"Laguna Seca","Sepang","Assen","Qatar"}
            },
            new Question {
                Id = 3020,
                Category = "MotoGP",
                Difficulty = "medium",
                Text = "Which rider moved to Aprilia in 2023?",
                CorrectAnswer = "Maverick Viñales",
                Options = new List<string>{"Maverick Viñales","Joan Mir","Zarco","Binder"}
            },

            // Hard (3021–3030)
            new Question {
                Id = 3021,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which rider won titles in both 500cc and MotoGP eras?",
                CorrectAnswer = "Valentino Rossi",
                Options = new List<string>{"Valentino Rossi","Agostini","Márquez","Doohan"}
            },
            new Question {
                Id = 3022,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which manufacturer introduced the first seamless gearbox?",
                CorrectAnswer = "Honda",
                Options = new List<string>{"Honda","Yamaha","Ducati","Aprilia"}
            },
            new Question {
                Id = 3023,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which rider earned the nickname 'Kentucky Kid'?",
                CorrectAnswer = "Nicky Hayden",
                Options = new List<string>{"Nicky Hayden","Edwards","Roberts Jr.","Spencer"}
            },
            new Question {
                Id = 3024,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which track has the longest straight in MotoGP?",
                CorrectAnswer = "Mugello",
                Options = new List<string>{"Mugello","Qatar","Sepang","Texas"}
            },
            new Question {
                Id = 3025,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which rider won the 2007 MotoGP title?",
                CorrectAnswer = "Casey Stoner",
                Options = new List<string>{"Casey Stoner","Rossi","Pedrosa","Edwards"}
            },
            new Question {
                Id = 3026,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Who is the youngest MotoGP champion?",
                CorrectAnswer = "Marc Márquez",
                Options = new List<string>{"Marc Márquez","Rossi","Lorenzo","Pedrosa"}
            },
            new Question {
                Id = 3027,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which manufacturer returned to MotoGP in 2015?",
                CorrectAnswer = "Suzuki",
                Options = new List<string>{"Suzuki","Aprilia","BMW","Kawasaki"}
            },
            new Question {
                Id = 3028,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Who won the final 500cc race in 2001?",
                CorrectAnswer = "Valentino Rossi",
                Options = new List<string>{"Valentino Rossi","Gibernau","Capirossi","Biaggi"}
            },
            new Question {
                Id = 3029,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which rider achieved the 'Triple Crown' in 2019?",
                CorrectAnswer = "Marc Márquez",
                Options = new List<string>{"Marc Márquez","Rins","Dovi","Quartararo"}
            },
            new Question {
                Id = 3030,
                Category = "MotoGP",
                Difficulty = "hard",
                Text = "Which team has the nickname 'The Noale Factory'?",
                CorrectAnswer = "Aprilia",
                Options = new List<string>{"Aprilia","KTM","Ducati","Honda"}
            },

            // ENDURANCE RACING (4001–4030)
            // EASY (4001–4005)
            new Question {
                Id = 4001,
                Category = "Endurance Racing",
                Difficulty = "easy",
                Text = "Which famous race lasts 24 hours and is part of the Triple Crown of Motorsport?",
                CorrectAnswer = "24 Hours of Le Mans",
                Options = new() { "24 Hours of Le Mans", "Daytona 500", "Monaco GP", "Indy 500" }
            },

            new Question {
                Id = 4002,
                Category = "Endurance Racing",
                Difficulty = "easy",
                Text = "Which country hosts the 24 Hours of Le Mans?",
                CorrectAnswer = "France",
                Options = new() { "France", "Germany", "Italy", "United States" }
            },

            new Question {
                Id = 4003,
                Category = "Endurance Racing",
                Difficulty = "easy",
                Text = "What type of race format is typical in endurance racing?",
                CorrectAnswer = "Team-based long-distance racing",
                Options = new() { "Team-based long-distance racing", "One-lap sprints", "Time trials", "Drag races" }
            },

            new Question {
                Id = 4004,
                Category = "Endurance Racing",
                Difficulty = "easy",
                Text = "Which manufacturer dominated Le Mans in the 2010s with hybrid technology?",
                CorrectAnswer = "Toyota",
                Options = new() { "Toyota", "Ferrari", "Porsche", "Audi" }
            },

            new Question {
                Id = 4005,
                Category = "Endurance Racing",
                Difficulty = "easy",
                Text = "Which US-based series includes races like Daytona and Sebring?",
                CorrectAnswer = "IMSA",
                Options = new() { "IMSA", "NASCAR", "IndyCar", "MotoAmerica" }
            },

            // MEDIUM (4011–4015) 
            new Question {
                Id = 4011,
                Category = "Endurance Racing",
                Difficulty = "medium",
                Text = "Which manufacturer has the most overall wins at the 24 Hours of Le Mans?",
                CorrectAnswer = "Porsche",
                Options = new() { "Porsche", "Audi", "Ferrari", "Bentley" }
            },

            new Question {
                Id = 4012,
                Category = "Endurance Racing",
                Difficulty = "medium",
                Text = "Which class replaced LMP1 as the top category in endurance racing?",
                CorrectAnswer = "Hypercar",
                Options = new() { "Hypercar", "GT Pro", "LMP2", "Touring Car" }
            },

            new Question {
                Id = 4013,
                Category = "Endurance Racing",
                Difficulty = "medium",
                Text = "Which circuit hosts the famous 12 Hours of Sebring?",
                CorrectAnswer = "Sebring International Raceway",
                Options = new() { "Sebring International Raceway", "Spa-Francorchamps", "Silverstone", "Road Atlanta" }
            },

            new Question {
                Id = 4014,
                Category = "Endurance Racing",
                Difficulty = "medium",
                Text = "Which series features events like the 6 Hours of Spa and 6 Hours of Fuji?",
                CorrectAnswer = "World Endurance Championship (WEC)",
                Options = new() { "World Endurance Championship (WEC)", "IMSA", "GT World Challenge", "IndyCar" }
            },

            new Question {
                Id = 4015,
                Category = "Endurance Racing",
                Difficulty = "medium",
                Text = "Which team was known for its diesel-powered dominance at Le Mans?",
                CorrectAnswer = "Audi",
                Options = new() { "Audi", "Toyota", "Mercedes", "Peugeot" }
            },

            // HARD (4021–4030) 
            new Question {
                Id = 4021,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which driver has the most 24 Hours of Le Mans victories?",
                CorrectAnswer = "Tom Kristensen",
                Options = new() { "Tom Kristensen", "Jacky Ickx", "Allan McNish", "Emanuele Pirro" }
            },

            new Question {
                Id = 4022,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which rule limits how long each driver can stay in the car during an endurance race?",
                CorrectAnswer = "Minimum and maximum drive-time regulations",
                Options = new() { "Minimum and maximum drive-time regulations", "Track-time penalties", "Overtaking windows", "Fuel stint limitations" }
            },

            new Question {
                Id = 4023,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which team broke Audi’s Le Mans streak by winning in 2015?",
                CorrectAnswer = "Porsche",
                Options = new() { "Porsche", "Toyota", "Peugeot", "Ferrari" }
            },

            new Question {
                Id = 4024,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "In what year did Ford famously defeat Ferrari at Le Mans?",
                CorrectAnswer = "1966",
                Options = new() { "1966", "1964", "1968", "1970" }
            },

            new Question {
                Id = 4025,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "What is the standard race duration for most WEC Hypercar events?",
                CorrectAnswer = "6 hours",
                Options = new() { "6 hours", "3 hours", "12 hours", "4 hours" }
            },

            new Question {
                Id = 4026,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which circuit is known for the iconic Eau Rouge–Raidillon section used in endurance racing?",
                CorrectAnswer = "Spa-Francorchamps",
                Options = new() { "Spa-Francorchamps", "Nürburgring", "Laguna Seca", "Suzuka" }
            },

            new Question {
                Id = 4027,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which hybrid system powered Porsche's 919 Hybrid during its dominance?",
                CorrectAnswer = "ERS-K + ERS-H dual system",
                Options = new() { "ERS-K + ERS-H dual system", "KERS only", "MGU-H only", "Flywheel energy system" }
            },

            new Question {
                Id = 4028,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which GT class was removed from WEC after the 2023 season?",
                CorrectAnswer = "GTE Pro",
                Options = new() { "GTE Pro", "GT3", "GT2", "GTLM" }
            },

            new Question {
                Id = 4029,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which manufacturer returned to Le Mans in 2023 with the 499P Hypercar?",
                CorrectAnswer = "Ferrari",
                Options = new() { "Ferrari", "Cadillac", "Peugeot", "Bentley" }
            },

            new Question {
                Id = 4030,
                Category = "Endurance Racing",
                Difficulty = "hard",
                Text = "Which event includes both day and night stages at the Nürburgring?",
                CorrectAnswer = "Nürburgring 24 Hours",
                Options = new() { "Nürburgring 24 Hours", "Spa 24 Hours", "Dubai 24 Hours", "Bathurst 12 Hour" }
            },
            // TENNIS 
            // EASY (5001–5010)
            new Question {
                Id = 5001,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which Grand Slam is played on clay courts?",
                CorrectAnswer = "French Open",
                Options = new() { "French Open", "Wimbledon", "US Open", "Australian Open" }
            },

            new Question {
                Id = 5002,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Who has won the most Wimbledon men’s singles titles?",
                CorrectAnswer = "Roger Federer",
                Options = new() { "Roger Federer", "Rafael Nadal", "Novak Djokovic", "Pete Sampras" }
            },

            new Question {
                Id = 5003,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "How many points are needed to win a standard tennis game?",
                CorrectAnswer = "4",
                Options = new() { "3", "4", "5", "6" }
            },

            new Question {
                Id = 5004,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which Grand Slam is played on grass?",
                CorrectAnswer = "Wimbledon",
                Options = new() { "Wimbledon", "French Open", "US Open", "Australian Open" }
            },

            new Question {
                Id = 5005,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "How many sets are played in men’s Grand Slam singles matches?",
                CorrectAnswer = "5",
                Options = new() { "3", "4", "5", "2" }
            },

            new Question {
                Id = 5006,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which country does Serena Williams represent?",
                CorrectAnswer = "USA",
                Options = new() { "USA", "UK", "Spain", "Australia" }
            },

            new Question {
                Id = 5007,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "What is the term for a score of 40–40?",
                CorrectAnswer = "Deuce",
                Options = new() { "Love", "Deuce", "Advantage", "Break" }
            },

            new Question {
                Id = 5008,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which tournament is considered the first Grand Slam of the year?",
                CorrectAnswer = "Australian Open",
                Options = new() { "Australian Open", "French Open", "Wimbledon", "US Open" }
            },

            new Question {
                Id = 5009,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which female player has won the most Grand Slam singles titles?",
                CorrectAnswer = "Margaret Court",
                Options = new() { "Margaret Court", "Serena Williams", "Steffi Graf", "Martina Navratilova" }
            },

            new Question {
                Id = 5010,
                Category = "Tennis",
                Difficulty = "easy",
                Text = "Which surface is used at the US Open?",
                CorrectAnswer = "Hard court",
                Options = new() { "Hard court", "Grass", "Clay", "Carpet" }
            },

            //  MEDIUM (5011–5020)
            new Question {
                Id = 5011,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Who is nicknamed 'Rafa' in tennis?",
                CorrectAnswer = "Rafael Nadal",
                Options = new() { "Rafael Nadal", "Roger Federer", "Novak Djokovic", "Andy Murray" }
            },

            new Question {
                Id = 5012,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which player completed the Golden Slam by winning all four majors and Olympic gold in a single year?",
                CorrectAnswer = "Steffi Graf",
                Options = new() { "Steffi Graf", "Serena Williams", "Martina Hingis", "Venus Williams" }
            },

            new Question {
                Id = 5013,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which male player has achieved the Career Grand Slam most recently?",
                CorrectAnswer = "Novak Djokovic",
                Options = new() { "Novak Djokovic", "Roger Federer", "Rafael Nadal", "Andy Murray" }
            },

            new Question {
                Id = 5014,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "What is the name of the trophy awarded to the Wimbledon men’s singles champion?",
                CorrectAnswer = "Gentlemen's Singles Trophy",
                Options = new() { "Gentlemen's Singles Trophy", "Venus Rosewater Dish", "US Open Trophy", "Davis Cup" }
            },

            new Question {
                Id = 5015,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which male player has the fastest recorded serve in tennis history?",
                CorrectAnswer = "Sam Groth",
                Options = new() { "Sam Groth", "Ivo Karlović", "Andy Roddick", "John Isner" }
            },

            new Question {
                Id = 5016,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which country hosts the French Open?",
                CorrectAnswer = "France",
                Options = new() { "France", "Spain", "Italy", "UK" }
            },

            new Question {
                Id = 5017,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "What is the term for winning a game without losing a point?",
                CorrectAnswer = "Love game",
                Options = new() { "Love game", "Ace", "Break", "Deuce" }
            },

            new Question {
                Id = 5018,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which tournament uses a tiebreak at 6–6 in the final set?",
                CorrectAnswer = "US Open",
                Options = new() { "US Open", "Wimbledon", "French Open", "Australian Open" }
            },

            new Question {
                Id = 5019,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which male player is known for his 'one-handed backhand'?",
                CorrectAnswer = "Roger Federer",
                Options = new() { "Roger Federer", "Rafael Nadal", "Novak Djokovic", "Andy Murray" }
            },

            new Question {
                Id = 5020,
                Category = "Tennis",
                Difficulty = "medium",
                Text = "Which Grand Slam has a retractable roof to avoid rain delays?",
                CorrectAnswer = "Wimbledon",
                Options = new() { "Wimbledon", "US Open", "French Open", "Australian Open" }
            },

            // HARD (5021–5030)
            new Question {
                Id = 5021,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which female player was the youngest to win a Grand Slam singles title in the Open Era?",
                CorrectAnswer = "Martina Hingis",
                Options = new() { "Martina Hingis", "Monica Seles", "Serena Williams", "Steffi Graf" }
            },

            new Question {
                Id = 5022,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Who holds the record for the most consecutive weeks as world No. 1 in men’s singles?",
                CorrectAnswer = "Novak Djokovic",
                Options = new() { "Novak Djokovic", "Roger Federer", "Pete Sampras", "Ivan Lendl" }
            },

            new Question {
                Id = 5023,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which player won all four Grand Slams in a single calendar year in 1969?",
                CorrectAnswer = "Rod Laver",
                Options = new() { "Rod Laver", "Bjorn Borg", "Andre Agassi", "Roger Federer" }
            },

            new Question {
                Id = 5024,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which male player has the most ATP Masters 1000 titles?",
                CorrectAnswer = "Novak Djokovic",
                Options = new() { "Novak Djokovic", "Rafael Nadal", "Roger Federer", "Pete Sampras" }
            },

            new Question {
                Id = 5025,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "What is the surface of the Australian Open?",
                CorrectAnswer = "Hard court",
                Options = new() { "Hard court", "Grass", "Clay", "Carpet" }
            },

            new Question {
                Id = 5026,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Who won the most French Open men’s singles titles in the Open Era?",
                CorrectAnswer = "Rafael Nadal",
                Options = new() { "Rafael Nadal", "Bjorn Borg", "Novak Djokovic", "Roger Federer" }
            },

            new Question {
                Id = 5027,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which tournament is nicknamed 'The Happy Slam'?",
                CorrectAnswer = "Australian Open",
                Options = new() { "Australian Open", "US Open", "French Open", "Wimbledon" }
            },

            new Question {
                Id = 5028,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Who won the men’s singles gold at the 2012 London Olympics?",
                CorrectAnswer = "Andy Murray",
                Options = new() { "Andy Murray", "Roger Federer", "Novak Djokovic", "Rafael Nadal" }
            },

            new Question {
                Id = 5029,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which female player holds the record for the most consecutive Grand Slam singles titles?",
                CorrectAnswer = "Martina Navratilova",
                Options = new() { "Martina Navratilova", "Steffi Graf", "Serena Williams", "Margaret Court" }
            },

            new Question {
                Id = 5030,
                Category = "Tennis",
                Difficulty = "hard",
                Text = "Which player completed the Career Golden Slam in both singles and doubles?",
                CorrectAnswer = "Serena Williams",
                Options = new() { "Serena Williams", "Venus Williams", "Martina Hingis", "Steffi Graf" }
            },

            // BASKETBALL (6001–6030)
            // EASY (6001–6010)
            new Question {
                Id = 6001,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many points is a standard free throw worth?",
                CorrectAnswer = "1",
                Options = new() { "1", "2", "3", "4" }
            },

            new Question {
                Id = 6002,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many players are on the court per team in standard basketball?",
                CorrectAnswer = "5",
                Options = new() { "4", "5", "6", "7" }
            },

            new Question {
                Id = 6003,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which league is considered the top professional basketball league in the USA?",
                CorrectAnswer = "NBA",
                Options = new() { "NBA", "WNBA", "EuroLeague", "NCAA" }
            },

            new Question {
                Id = 6004,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "What is the height of a standard basketball hoop from the floor?",
                CorrectAnswer = "10 feet",
                Options = new() { "8 feet", "9 feet", "10 feet", "11 feet" }
            },

            new Question {
                Id = 6005,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which player is known as 'King James'?",
                CorrectAnswer = "LeBron James",
                Options = new() { "LeBron James", "Michael Jordan", "Kobe Bryant", "Kevin Durant" }
            },

            new Question {
                Id = 6006,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which team has won the most NBA championships?",
                CorrectAnswer = "Boston Celtics",
                Options = new() { "Boston Celtics", "Los Angeles Lakers", "Chicago Bulls", "Golden State Warriors" }
            },

            new Question {
                Id = 6007,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many points is a standard three-point shot worth?",
                CorrectAnswer = "3",
                Options = new() { "2", "3", "4", "5" }
            },

            new Question {
                Id = 6008,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which country invented basketball?",
                CorrectAnswer = "USA",
                Options = new() { "USA", "Canada", "Spain", "China" }
            },

            new Question {
                Id = 6009,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which female player is famous for playing in the WNBA and winning 4 Olympic gold medals?",
                CorrectAnswer = "Diana Taurasi",
                Options = new() { "Diana Taurasi", "Sue Bird", "Lisa Leslie", "Tamika Catchings" }
            },

            new Question {
                Id = 6010,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which position is typically responsible for bringing the ball up the court?",
                CorrectAnswer = "Point guard",
                Options = new() { "Point guard", "Shooting guard", "Center", "Power forward" }
            },

            // MEDIUM (6011–6020)
            new Question {
                Id = 6011,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which NBA player scored 100 points in a single game?",
                CorrectAnswer = "Wilt Chamberlain",
                Options = new() { "Wilt Chamberlain", "Michael Jordan", "Kobe Bryant", "LeBron James" }
            },

            new Question {
                Id = 6012,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team drafted Kobe Bryant in 1996?",
                CorrectAnswer = "Charlotte Hornets",
                Options = new() { "Charlotte Hornets", "Los Angeles Lakers", "Chicago Bulls", "New York Knicks" }
            },

            new Question {
                Id = 6013,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player is known as 'The Black Mamba'?",
                CorrectAnswer = "Kobe Bryant",
                Options = new() { "Kobe Bryant", "Michael Jordan", "Shaquille O'Neal", "LeBron James" }
            },

            new Question {
                Id = 6014,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team won the NBA championship in 2020?",
                CorrectAnswer = "Los Angeles Lakers",
                Options = new() { "Los Angeles Lakers", "Miami Heat", "Toronto Raptors", "Golden State Warriors" }
            },

            new Question {
                Id = 6015,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player has the most career NBA points scored?",
                CorrectAnswer = "LeBron James",
                Options = new() { "LeBron James", "Kareem Abdul-Jabbar", "Karl Malone", "Michael Jordan" }
            },

            new Question {
                Id = 6016,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player is famous for the 'Sky Hook' shot?",
                CorrectAnswer = "Kareem Abdul-Jabbar",
                Options = new() { "Kareem Abdul-Jabbar", "Michael Jordan", "Shaquille O'Neal", "Dirk Nowitzki" }
            },

            new Question {
                Id = 6017,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team won the first NBA championship?",
                CorrectAnswer = "Philadelphia Warriors",
                Options = new() { "Philadelphia Warriors", "Boston Celtics", "Chicago Stags", "New York Knicks" }
            },

            new Question {
                Id = 6018,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player has the most NBA Finals MVP awards?",
                CorrectAnswer = "Michael Jordan",
                Options = new() { "Michael Jordan", "LeBron James", "Kobe Bryant", "Shaquille O'Neal" }
            },

            new Question {
                Id = 6019,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which European player won NBA MVP in 2019?",
                CorrectAnswer = "Giannis Antetokounmpo",
                Options = new() { "Giannis Antetokounmpo", "Luka Dončić", "Dirk Nowitzki", "Nikola Jokić" }
            },

            new Question {
                Id = 6020,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which NBA team is nicknamed 'The Splash Brothers'?",
                CorrectAnswer = "Golden State Warriors",
                Options = new() { "Golden State Warriors", "Boston Celtics", "Los Angeles Lakers", "Miami Heat" }
            },

            // HARD (6021–6030)
            new Question {
                Id = 6021,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player was the first to record a quadruple-double in NBA history?",
                CorrectAnswer = "Nate Thurmond",
                Options = new() { "Nate Thurmond", "Hakeem Olajuwon", "David Robinson", "Wilt Chamberlain" }
            },

            new Question {
                Id = 6022,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA coach has the most career wins?",
                CorrectAnswer = "Don Nelson",
                Options = new() { "Don Nelson", "Gregg Popovich", "Phil Jackson", "Pat Riley" }
            },

            new Question {
                Id = 6023,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA team was originally based in Seattle?",
                CorrectAnswer = "Supersonics",
                Options = new() { "Supersonics", "Thunder", "Lakers", "Celtics" }
            },

            new Question {
                Id = 6024,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Who was the first international player to be drafted first overall in the NBA?",
                CorrectAnswer = "Yao Ming",
                Options = new() { "Yao Ming", "Dirk Nowitzki", "Andrew Bogut", "Manu Ginóbili" }
            },

            new Question {
                Id = 6025,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player scored the most points in a single NBA Finals game?",
                CorrectAnswer = "Elgin Baylor",
                Options = new() { "Elgin Baylor", "Michael Jordan", "Kobe Bryant", "LeBron James" }
            },

            new Question {
                Id = 6026,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which team holds the record for most wins in a single NBA regular season?",
                CorrectAnswer = "Golden State Warriors",
                Options = new() { "Golden State Warriors", "Chicago Bulls", "Los Angeles Lakers", "San Antonio Spurs" }
            },

            new Question {
                Id = 6027,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player was known as 'The Answer'?",
                CorrectAnswer = "Allen Iverson",
                Options = new() { "Allen Iverson", "Michael Jordan", "LeBron James", "Kobe Bryant" }
            },

            new Question {
                Id = 6028,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA player has the most career triple-doubles?",
                CorrectAnswer = "Russell Westbrook",
                Options = new() { "Russell Westbrook", "Magic Johnson", "Oscar Robertson", "LeBron James" }
            },

            new Question {
                Id = 6029,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which team won the first WNBA championship in 1997?",
                CorrectAnswer = "Houston Comets",
                Options = new() { "Houston Comets", "Los Angeles Sparks", "New York Liberty", "Phoenix Mercury" }
            },

            new Question {
                Id = 6030,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA player was nicknamed 'Big Fundamental'?",
                CorrectAnswer = "Tim Duncan",
                Options = new() { "Tim Duncan", "Shaquille O'Neal", "Kevin Garnett", "Dirk Nowitzki" }
            },

            // BASKETBALL (7001–7030)
            // EASY (7001–7010) 
            new Question {
                Id = 7001,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many points is a standard free throw worth?",
                CorrectAnswer = "1",
                Options = new() { "1", "2", "3", "4" }
            },

            new Question {
                Id = 7002,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many players are on the court per team in standard basketball?",
                CorrectAnswer = "5",
                Options = new() { "4", "5", "6", "7" }
            },

            new Question {
                Id = 7003,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which league is considered the top professional basketball league in the USA?",
                CorrectAnswer = "NBA",
                Options = new() { "NBA", "WNBA", "EuroLeague", "NCAA" }
            },

            new Question {
                Id = 7004,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "What is the height of a standard basketball hoop from the floor?",
                CorrectAnswer = "10 feet",
                Options = new() { "8 feet", "9 feet", "10 feet", "11 feet" }
            },

            new Question {
                Id = 7005,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which player is known as 'King James'?",
                CorrectAnswer = "LeBron James",
                Options = new() { "LeBron James", "Michael Jordan", "Kobe Bryant", "Kevin Durant" }
            },

            new Question {
                Id = 7006,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which team has won the most NBA championships?",
                CorrectAnswer = "Boston Celtics",
                Options = new() { "Boston Celtics", "Los Angeles Lakers", "Chicago Bulls", "Golden State Warriors" }
            },

            new Question {
                Id = 7007,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "How many points is a standard three-point shot worth?",
                CorrectAnswer = "3",
                Options = new() { "2", "3", "4", "5" }
            },

            new Question {
                Id = 7008,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which country invented basketball?",
                CorrectAnswer = "USA",
                Options = new() { "USA", "Canada", "Spain", "China" }
            },

            new Question {
                Id = 7009,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which female player is famous for playing in the WNBA and winning 4 Olympic gold medals?",
                CorrectAnswer = "Diana Taurasi",
                Options = new() { "Diana Taurasi", "Sue Bird", "Lisa Leslie", "Tamika Catchings" }
            },

            new Question {
                Id = 7010,
                Category = "Basketball",
                Difficulty = "easy",
                Text = "Which position is typically responsible for bringing the ball up the court?",
                CorrectAnswer = "Point guard",
                Options = new() { "Point guard", "Shooting guard", "Center", "Power forward" }
            },

            // MEDIUM (7011–7020) 
            new Question {
                Id = 7011,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which NBA player scored 100 points in a single game?",
                CorrectAnswer = "Wilt Chamberlain",
                Options = new() { "Wilt Chamberlain", "Michael Jordan", "Kobe Bryant", "LeBron James" }
            },

            new Question {
                Id = 7012,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team drafted Kobe Bryant in 1996?",
                CorrectAnswer = "Charlotte Hornets",
                Options = new() { "Charlotte Hornets", "Los Angeles Lakers", "Chicago Bulls", "New York Knicks" }
            },

            new Question {
                Id = 7013,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player is known as 'The Black Mamba'?",
                CorrectAnswer = "Kobe Bryant",
                Options = new() { "Kobe Bryant", "Michael Jordan", "Shaquille O'Neal", "LeBron James" }
            },

            new Question {
                Id = 7014,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team won the NBA championship in 2020?",
                CorrectAnswer = "Los Angeles Lakers",
                Options = new() { "Los Angeles Lakers", "Miami Heat", "Toronto Raptors", "Golden State Warriors" }
            },

            new Question {
                Id = 7015,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player has the most career NBA points scored?",
                CorrectAnswer = "LeBron James",
                Options = new() { "LeBron James", "Kareem Abdul-Jabbar", "Karl Malone", "Michael Jordan" }
            },

            new Question {
                Id = 7016,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player is famous for the 'Sky Hook' shot?",
                CorrectAnswer = "Kareem Abdul-Jabbar",
                Options = new() { "Kareem Abdul-Jabbar", "Michael Jordan", "Shaquille O'Neal", "Dirk Nowitzki" }
            },

            new Question {
                Id = 7017,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which team won the first NBA championship?",
                CorrectAnswer = "Philadelphia Warriors",
                Options = new() { "Philadelphia Warriors", "Boston Celtics", "Chicago Stags", "New York Knicks" }
            },

            new Question {
                Id = 7018,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which player has the most NBA Finals MVP awards?",
                CorrectAnswer = "Michael Jordan",
                Options = new() { "Michael Jordan", "LeBron James", "Kobe Bryant", "Shaquille O'Neal" }
            },

            new Question {
                Id = 7019,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which European player won NBA MVP in 2019?",
                CorrectAnswer = "Giannis Antetokounmpo",
                Options = new() { "Giannis Antetokounmpo", "Luka Dončić", "Dirk Nowitzki", "Nikola Jokić" }
            },

            new Question {
                Id = 7020,
                Category = "Basketball",
                Difficulty = "medium",
                Text = "Which NBA team is nicknamed 'The Splash Brothers'?",
                CorrectAnswer = "Golden State Warriors",
                Options = new() { "Golden State Warriors", "Boston Celtics", "Los Angeles Lakers", "Miami Heat" }
            },

            // HARD (7021–7030)
            new Question {
                Id = 7021,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player was the first to record a quadruple-double in NBA history?",
                CorrectAnswer = "Nate Thurmond",
                Options = new() { "Nate Thurmond", "Hakeem Olajuwon", "David Robinson", "Wilt Chamberlain" }
            },

            new Question {
                Id = 7022,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA coach has the most career wins?",
                CorrectAnswer = "Don Nelson",
                Options = new() { "Don Nelson", "Gregg Popovich", "Phil Jackson", "Pat Riley" }
            },

            new Question {
                Id = 7023,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA team was originally based in Seattle?",
                CorrectAnswer = "Supersonics",
                Options = new() { "Supersonics", "Thunder", "Lakers", "Celtics" }
            },

            new Question {
                Id = 7024,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Who was the first international player to be drafted first overall in the NBA?",
                CorrectAnswer = "Yao Ming",
                Options = new() { "Yao Ming", "Dirk Nowitzki", "Andrew Bogut", "Manu Ginóbili" }
            },

            new Question {
                Id = 7025,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player scored the most points in a single NBA Finals game?",
                CorrectAnswer = "Elgin Baylor",
                Options = new() { "Elgin Baylor", "Michael Jordan", "Kobe Bryant", "LeBron James" }
            },

            new Question {
                Id = 7026,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which team holds the record for most wins in a single NBA regular season?",
                CorrectAnswer = "Golden State Warriors",
                Options = new() { "Golden State Warriors", "Chicago Bulls", "Los Angeles Lakers", "San Antonio Spurs" }
            },

            new Question {
                Id = 7027,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which player was known as 'The Answer'?",
                CorrectAnswer = "Allen Iverson",
                Options = new() { "Allen Iverson", "Michael Jordan", "LeBron James", "Kobe Bryant" }
            },

            new Question {
                Id = 7028,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA player has the most career triple-doubles?",
                CorrectAnswer = "Russell Westbrook",
                Options = new() { "Russell Westbrook", "Magic Johnson", "Oscar Robertson", "LeBron James" }
            },

            new Question {
                Id = 7029,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which team won the first WNBA championship in 1997?",
                CorrectAnswer = "Houston Comets",
                Options = new() { "Houston Comets", "Los Angeles Sparks", "New York Liberty", "Phoenix Mercury" }
            },

            new Question {
                Id = 7030,
                Category = "Basketball",
                Difficulty = "hard",
                Text = "Which NBA player was nicknamed 'Big Fundamental'?",
                CorrectAnswer = "Tim Duncan",
                Options = new() { "Tim Duncan", "Shaquille O'Neal", "Kevin Garnett", "Dirk Nowitzki" }
            },

            // BASEBALL (8001–8030)
            // EASY (8001–8010)
            new Question {
                Id = 8001,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "How many bases are there on a standard baseball field?",
                CorrectAnswer = "4",
                Options = new() { "3", "4", "5", "6" }
            },

            new Question {
                Id = 8002,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "How many players are on the field for one team at a time?",
                CorrectAnswer = "9",
                Options = new() { "7", "8", "9", "10" }
            },

            new Question {
                Id = 8003,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "Which league is considered the top professional baseball league in the USA?",
                CorrectAnswer = "MLB",
                Options = new() { "MLB", "NCAA", "Minor League", "AAA League" }
            },

            new Question {
                Id = 8004,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "How many innings are in a standard professional baseball game?",
                CorrectAnswer = "9",
                Options = new() { "7", "8", "9", "10" }
            },

            new Question {
                Id = 8005,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "Which player throws the ball to the batter?",
                CorrectAnswer = "Pitcher",
                Options = new() { "Catcher", "Pitcher", "First Baseman", "Shortstop" }
            },

            new Question {
                Id = 8006,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "Which team won the 2020 MLB World Series?",
                CorrectAnswer = "Los Angeles Dodgers",
                Options = new() { "Los Angeles Dodgers", "Tampa Bay Rays", "New York Yankees", "Houston Astros" }
            },

            new Question {
                Id = 8007,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "What is it called when a batter hits the ball and runs around all bases to score?",
                CorrectAnswer = "Home run",
                Options = new() { "Double", "Triple", "Home run", "Single" }
            },

            new Question {
                Id = 8008,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "Which player catches pitches from the pitcher?",
                CorrectAnswer = "Catcher",
                Options = new() { "Catcher", "Pitcher", "Shortstop", "First Baseman" }
            },

            new Question {
                Id = 8009,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "Which country is credited with inventing modern baseball?",
                CorrectAnswer = "USA",
                Options = new() { "USA", "Canada", "Japan", "Cuba" }
            },

            new Question {
                Id = 8010,
                Category = "Baseball",
                Difficulty = "easy",
                Text = "How many strikes result in a strikeout?",
                CorrectAnswer = "3",
                Options = new() { "2", "3", "4", "5" }
            },

            // MEDIUM (8011–8020) 
            new Question {
                Id = 8011,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which pitcher threw the only perfect game in World Series history?",
                CorrectAnswer = "Don Larsen",
                Options = new() { "Don Larsen", "Sandy Koufax", "Nolan Ryan", "Bob Gibson" }
            },

            new Question {
                Id = 8012,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which team has the most World Series titles?",
                CorrectAnswer = "New York Yankees",
                Options = new() { "New York Yankees", "Boston Red Sox", "Los Angeles Dodgers", "San Francisco Giants" }
            },

            new Question {
                Id = 8013,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "What term is used when a batter reaches first base safely after hitting the ball?",
                CorrectAnswer = "Single",
                Options = new() { "Single", "Double", "Triple", "Home run" }
            },

            new Question {
                Id = 8014,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which MLB player is known as 'The Sultan of Swat'?",
                CorrectAnswer = "Babe Ruth",
                Options = new() { "Babe Ruth", "Lou Gehrig", "Mickey Mantle", "Ty Cobb" }
            },

            new Question {
                Id = 8015,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which pitcher holds the record for the most career strikeouts?",
                CorrectAnswer = "Nolan Ryan",
                Options = new() { "Nolan Ryan", "Sandy Koufax", "Pedro Martinez", "Roger Clemens" }
            },

            new Question {
                Id = 8016,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which MLB team plays at Fenway Park?",
                CorrectAnswer = "Boston Red Sox",
                Options = new() { "Boston Red Sox", "New York Yankees", "Chicago Cubs", "Los Angeles Dodgers" }
            },

            new Question {
                Id = 8017,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which player holds the record for most career home runs?",
                CorrectAnswer = "Barry Bonds",
                Options = new() { "Barry Bonds", "Hank Aaron", "Babe Ruth", "Alex Rodriguez" }
            },

            new Question {
                Id = 8018,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which MLB team is nicknamed 'The Cubs'?",
                CorrectAnswer = "Chicago Cubs",
                Options = new() { "Chicago Cubs", "Chicago White Sox", "Detroit Tigers", "Cleveland Indians" }
            },

            new Question {
                Id = 8019,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which position usually stands between second and third base?",
                CorrectAnswer = "Shortstop",
                Options = new() { "Shortstop", "Second baseman", "Third baseman", "Catcher" }
            },

            new Question {
                Id = 8020,
                Category = "Baseball",
                Difficulty = "medium",
                Text = "Which MLB player won the most MVP awards in the American League?",
                CorrectAnswer = "Babe Ruth",
                Options = new() { "Babe Ruth", "Ted Williams", "Mickey Mantle", "Albert Pujols" }
            },

            // HARD (8021–8030)
            new Question {
                Id = 8021,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which MLB team was originally the Brooklyn Dodgers?",
                CorrectAnswer = "Los Angeles Dodgers",
                Options = new() { "Los Angeles Dodgers", "San Francisco Giants", "New York Yankees", "Boston Red Sox" }
            },

            new Question {
                Id = 8022,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Who is the youngest player to hit 500 career home runs?",
                CorrectAnswer = "Alex Rodriguez",
                Options = new() { "Alex Rodriguez", "Albert Pujols", "Mickey Mantle", "Mark McGwire" }
            },

            new Question {
                Id = 8023,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which player hit a walk-off home run in Game 7 of the 1993 World Series?",
                CorrectAnswer = "Joe Carter",
                Options = new() { "Joe Carter", "Kirby Puckett", "Darryl Strawberry", "Frank Thomas" }
            },

            new Question {
                Id = 8024,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which pitcher threw 7 no-hitters in his MLB career?",
                CorrectAnswer = "Nolan Ryan",
                Options = new() { "Nolan Ryan", "Sandy Koufax", "Cy Young", "Bob Feller" }
            },

            new Question {
                Id = 8025,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which MLB player is known for breaking the 'color barrier'?",
                CorrectAnswer = "Jackie Robinson",
                Options = new() { "Jackie Robinson", "Willie Mays", "Hank Aaron", "Roberto Clemente" }
            },

            new Question {
                Id = 8026,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which MLB team has a logo featuring a Native American chief?",
                CorrectAnswer = "Cleveland Indians",
                Options = new() { "Cleveland Indians", "Kansas City Royals", "Chicago White Sox", "Minnesota Twins" }
            },

            new Question {
                Id = 8027,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which stadium is nicknamed 'The House That Ruth Built'?",
                CorrectAnswer = "Yankee Stadium",
                Options = new() { "Yankee Stadium", "Fenway Park", "Dodger Stadium", "Wrigley Field" }
            },

            new Question {
                Id = 8028,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which MLB pitcher has the most career wins?",
                CorrectAnswer = "Cy Young",
                Options = new() { "Cy Young", "Nolan Ryan", "Greg Maddux", "Roger Clemens" }
            },

            new Question {
                Id = 8029,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which MLB player hit the 'called shot' in the 1932 World Series?",
                CorrectAnswer = "Babe Ruth",
                Options = new() { "Babe Ruth", "Lou Gehrig", "Jimmie Foxx", "Joe DiMaggio" }
            },

            new Question {
                Id = 8030,
                Category = "Baseball",
                Difficulty = "hard",
                Text = "Which team won the most consecutive World Series titles (5) from 1949–1953?",
                CorrectAnswer = "New York Yankees",
                Options = new() { "New York Yankees", "Boston Red Sox", "St. Louis Cardinals", "Chicago Cubs" }
            },

            // CRICKET (9001–9030) 
            // EASY (9001–9010) 
            new Question {
                Id = 9001,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "How many players are on a cricket team?",
                CorrectAnswer = "11",
                Options = new() { "10", "11", "12", "9" }
            },

            new Question {
                Id = 9002,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which format of cricket is the shortest?",
                CorrectAnswer = "T20",
                Options = new() { "Test", "ODI", "T20", "First-class" }
            },

            new Question {
                Id = 9003,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "What is the term for six runs scored from one ball?",
                CorrectAnswer = "Six",
                Options = new() { "Four", "Six", "Triple", "Double" }
            },

            new Question {
                Id = 9004,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which country won the first Cricket World Cup in 1975?",
                CorrectAnswer = "West Indies",
                Options = new() { "Australia", "England", "West Indies", "India" }
            },

            new Question {
                Id = 9005,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "How many balls are there in an over?",
                CorrectAnswer = "6",
                Options = new() { "4", "5", "6", "8" }
            },

            new Question {
                Id = 9006,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which country is known as the 'Men in Blue'?",
                CorrectAnswer = "India",
                Options = new() { "India", "Australia", "Pakistan", "England" }
            },

            new Question {
                Id = 9007,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which piece of equipment is used by the batter to hit the ball?",
                CorrectAnswer = "Bat",
                Options = new() { "Bat", "Ball", "Gloves", "Helmet" }
            },

            new Question {
                Id = 9008,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "What is it called when a batter is dismissed without scoring?",
                CorrectAnswer = "Duck",
                Options = new() { "Duck", "Goose", "Owl", "Eagle" }
            },

            new Question {
                Id = 9009,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which player delivers the ball to the batter?",
                CorrectAnswer = "Bowler",
                Options = new() { "Bowler", "Batsman", "Fielder", "Wicketkeeper" }
            },

            new Question {
                Id = 9010,
                Category = "Cricket",
                Difficulty = "easy",
                Text = "Which fielding position stands behind the stumps?",
                CorrectAnswer = "Wicketkeeper",
                Options = new() { "Wicketkeeper", "Slip", "Point", "Mid-on" }
            },

            // MEDIUM (9011–9020) 
            new Question {
                Id = 9011,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which country has won the most Cricket World Cups?",
                CorrectAnswer = "Australia",
                Options = new() { "Australia", "India", "West Indies", "England" }
            },

            new Question {
                Id = 9012,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which bowler is known for the 'Doosra' delivery?",
                CorrectAnswer = "Saqlain Mushtaq",
                Options = new() { "Shane Warne", "Muttiah Muralitharan", "Saqlain Mushtaq", "Anil Kumble" }
            },

            new Question {
                Id = 9013,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which player has scored the most runs in Test cricket history?",
                CorrectAnswer = "Sachin Tendulkar",
                Options = new() { "Brian Lara", "Ricky Ponting", "Jacques Kallis", "Sachin Tendulkar" }
            },

            new Question {
                Id = 9014,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which country won the 2019 Cricket World Cup?",
                CorrectAnswer = "England",
                Options = new() { "England", "New Zealand", "India", "Australia" }
            },

            new Question {
                Id = 9015,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which cricket format is played over five days?",
                CorrectAnswer = "Test",
                Options = new() { "ODI", "T20", "Test", "First-class" }
            },

            new Question {
                Id = 9016,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which country is the home of the Ashes series?",
                CorrectAnswer = "England",
                Options = new() { "Australia", "England", "India", "South Africa" }
            },

            new Question {
                Id = 9017,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Who has taken the most wickets in ODI cricket history?",
                CorrectAnswer = "Muttiah Muralitharan",
                Options = new() { "Glenn McGrath", "Wasim Akram", "Muttiah Muralitharan", "Chaminda Vaas" }
            },

            new Question {
                Id = 9018,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "What is the maximum number of overs in a standard ODI match per team?",
                CorrectAnswer = "50",
                Options = new() { "20", "40", "50", "60" }
            },

            new Question {
                Id = 9019,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which country’s team is nicknamed 'Proteas'?",
                CorrectAnswer = "South Africa",
                Options = new() { "South Africa", "Australia", "New Zealand", "Pakistan" }
            },

            new Question {
                Id = 9020,
                Category = "Cricket",
                Difficulty = "medium",
                Text = "Which bowler is famous for the 'Googly' delivery?",
                CorrectAnswer = "Bertie Tait (or leg-spinner, traditionally)",
                Options = new() { "Bertie Tait", "Shane Warne", "Anil Kumble", "Muttiah Muralitharan" }
            },

            // HARD (9021–9030) 
            new Question {
                Id = 9021,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which batsman has the highest individual score in Test cricket?",
                CorrectAnswer = "Brian Lara",
                Options = new() { "Brian Lara", "Donald Bradman", "Chris Gayle", "Mahela Jayawardene" }
            },

            new Question {
                Id = 9022,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which team won the first ICC T20 World Cup in 2007?",
                CorrectAnswer = "India",
                Options = new() { "India", "Pakistan", "Australia", "Sri Lanka" }
            },

            new Question {
                Id = 9023,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Who holds the record for the fastest century in ODIs?",
                CorrectAnswer = "AB de Villiers",
                Options = new() { "AB de Villiers", "Chris Gayle", "Viv Richards", "Shahid Afridi" }
            },

            new Question {
                Id = 9024,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which bowler has the best bowling figures in a Test innings?",
                CorrectAnswer = "Jim Laker",
                Options = new() { "Jim Laker", "Muttiah Muralitharan", "Anil Kumble", "Shane Warne" }
            },

            new Question {
                Id = 9025,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which country won the ICC Champions Trophy in 2013?",
                CorrectAnswer = "India",
                Options = new() { "India", "England", "Sri Lanka", "South Africa" }
            },

            new Question {
                Id = 9026,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Who has taken the most wickets in Test cricket history?",
                CorrectAnswer = "Muttiah Muralitharan",
                Options = new() { "Shane Warne", "Muttiah Muralitharan", "James Anderson", "Anil Kumble" }
            },

            new Question {
                Id = 9027,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which cricketer is known as 'The Wall'?",
                CorrectAnswer = "Rahul Dravid",
                Options = new() { "Rahul Dravid", "Sachin Tendulkar", "Jacques Kallis", "Kumar Sangakkara" }
            },

            new Question {
                Id = 9028,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which country has hosted the most Cricket World Cups?",
                CorrectAnswer = "England",
                Options = new() { "England", "Australia", "India", "West Indies" }
            },

            new Question {
                Id = 9029,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which bowler bowled the 'Ball of the Century' to Mike Gatting?",
                CorrectAnswer = "Shane Warne",
                Options = new() { "Shane Warne", "Muttiah Muralitharan", "Curtly Ambrose", "Glenn McGrath" }
            },

            new Question {
                Id = 9030,
                Category = "Cricket",
                Difficulty = "hard",
                Text = "Which batsman scored 400 not out in a Test innings?",
                CorrectAnswer = "Brian Lara",
                Options = new() { "Brian Lara", "Don Bradman", "Chris Gayle", "Virender Sehwag" }
            },

            // GOLF (10001–10030)
            // EASY (10001–10010) 
            new Question {
                Id = 10001,
                Category = "Golf",
                Difficulty = "easy",
                Text = "How many holes are in a standard round of golf?",
                CorrectAnswer = "18",
                Options = new() { "9", "18", "12", "24" }
            },

            new Question {
                Id = 10002,
                Category = "Golf",
                Difficulty = "easy",
                Text = "What is the term for a score of one under par on a hole?",
                CorrectAnswer = "Birdie",
                Options = new() { "Birdie", "Eagle", "Bogey", "Par" }
            },

            new Question {
                Id = 10003,
                Category = "Golf",
                Difficulty = "easy",
                Text = "Which club is typically used for tee shots on long holes?",
                CorrectAnswer = "Driver",
                Options = new() { "Putter", "Wedge", "Driver", "Iron" }
            },

            new Question {
                Id = 10004,
                Category = "Golf",
                Difficulty = "easy",
                Text = "Which major golf tournament is played at Augusta National?",
                CorrectAnswer = "The Masters",
                Options = new() { "US Open", "The Open Championship", "PGA Championship", "The Masters" }
            },

            new Question {
                Id = 10005,
                Category = "Golf",
                Difficulty = "easy",
                Text = "What is the term for a score of two under par on a hole?",
                CorrectAnswer = "Eagle",
                Options = new() { "Birdie", "Eagle", "Bogey", "Albatross" }
            },

            new Question {
                Id = 10006,
                Category = "Golf",
                Difficulty = "easy",
                Text = "Which piece of equipment is used to hit the ball into the hole on the green?",
                CorrectAnswer = "Putter",
                Options = new() { "Driver", "Putter", "Iron", "Wedge" }
            },

            new Question {
                Id = 10007,
                Category = "Golf",
                Difficulty = "easy",
                Text = "Which country is home to the Old Course at St Andrews?",
                CorrectAnswer = "Scotland",
                Options = new() { "England", "Scotland", "USA", "Ireland" }
            },

            new Question {
                Id = 10008,
                Category = "Golf",
                Difficulty = "easy",
                Text = "What is the standard term for the number of strokes a skilled golfer is expected to take on a hole?",
                CorrectAnswer = "Par",
                Options = new() { "Par", "Birdie", "Eagle", "Bogey" }
            },

            new Question {
                Id = 10009,
                Category = "Golf",
                Difficulty = "easy",
                Text = "What is the term for a score of one over par on a hole?",
                CorrectAnswer = "Bogey",
                Options = new() { "Birdie", "Bogey", "Double Bogey", "Eagle" }
            },

            new Question {
                Id = 10010,
                Category = "Golf",
                Difficulty = "easy",
                Text = "Which famous golfer is known as 'Tiger'?",
                CorrectAnswer = "Tiger Woods",
                Options = new() { "Phil Mickelson", "Tiger Woods", "Rory McIlroy", "Jack Nicklaus" }
            },

            // MEDIUM (10011–10020)
            new Question {
                Id = 10011,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which golfer has won the most major championships?",
                CorrectAnswer = "Jack Nicklaus",
                Options = new() { "Tiger Woods", "Jack Nicklaus", "Arnold Palmer", "Ben Hogan" }
            },

            new Question {
                Id = 10012,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which golf tournament is the oldest of the four majors?",
                CorrectAnswer = "The Open Championship",
                Options = new() { "The Masters", "US Open", "The Open Championship", "PGA Championship" }
            },

            new Question {
                Id = 10013,
                Category = "Golf",
                Difficulty = "medium",
                Text = "What is the term for three under par on a single hole?",
                CorrectAnswer = "Albatross",
                Options = new() { "Eagle", "Albatross", "Condor", "Birdie" }
            },

            new Question {
                Id = 10014,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which country is Rory McIlroy from?",
                CorrectAnswer = "Northern Ireland",
                Options = new() { "Ireland", "Northern Ireland", "Scotland", "England" }
            },

            new Question {
                Id = 10015,
                Category = "Golf",
                Difficulty = "medium",
                Text = "What is the name of the trophy awarded to the winner of The Masters?",
                CorrectAnswer = "Green Jacket",
                Options = new() { "Claret Jug", "Green Jacket", "Wanamaker Trophy", "U.S. Open Trophy" }
            },

            new Question {
                Id = 10016,
                Category = "Golf",
                Difficulty = "medium",
                Text = "What is a 'fade' in golf?",
                CorrectAnswer = "A shot that curves slightly to the right (for right-handed golfers)",
                Options = new() { "A shot that curves left", "A shot that curves right", "A shot straight down the middle", "A low shot" }
            },

            new Question {
                Id = 10017,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which course hosts the US Open golf tournament?",
                CorrectAnswer = "Varies each year",
                Options = new() { "Pebble Beach", "Augusta National", "Varies each year", "St Andrews" }
            },

            new Question {
                Id = 10018,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which famous golfer is nicknamed 'The Golden Bear'?",
                CorrectAnswer = "Jack Nicklaus",
                Options = new() { "Tiger Woods", "Phil Mickelson", "Jack Nicklaus", "Arnold Palmer" }
            },

            new Question {
                Id = 10019,
                Category = "Golf",
                Difficulty = "medium",
                Text = "What is a 'green in regulation'?",
                CorrectAnswer = "Reaching the green in two strokes fewer than par for the hole",
                Options = new() { "Hitting the green in one shot", "Reaching the green in par strokes", "Reaching the green in two strokes fewer than par", "Finishing under par" }
            },

            new Question {
                Id = 10020,
                Category = "Golf",
                Difficulty = "medium",
                Text = "Which golfer won the 2019 Masters Tournament?",
                CorrectAnswer = "Tiger Woods",
                Options = new() { "Rory McIlroy", "Tiger Woods", "Dustin Johnson", "Phil Mickelson" }
            },

            // HARD (10021–10030) 
            new Question {
                Id = 10021,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer holds the record for most consecutive cuts made in major championships?",
                CorrectAnswer = "Tiger Woods",
                Options = new() { "Tiger Woods", "Jack Nicklaus", "Phil Mickelson", "Rory McIlroy" }
            },

            new Question {
                Id = 10022,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer has the lowest score in a single round in PGA Tour history?",
                CorrectAnswer = "Jim Furyk",
                Options = new() { "Tiger Woods", "Jim Furyk", "Dustin Johnson", "Phil Mickelson" }
            },

            new Question {
                Id = 10023,
                Category = "Golf",
                Difficulty = "hard",
                Text = "What is the term for a hole completed in four strokes under par?",
                CorrectAnswer = "Condor",
                Options = new() { "Albatross", "Condor", "Eagle", "Double Eagle" }
            },

            new Question {
                Id = 10024,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer was the first to win all four major championships in a single calendar year?",
                CorrectAnswer = "None",
                Options = new() { "Tiger Woods", "Jack Nicklaus", "Ben Hogan", "No one" }
            },

            new Question {
                Id = 10025,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which country is home to Royal Portrush Golf Club?",
                CorrectAnswer = "Northern Ireland",
                Options = new() { "Ireland", "Scotland", "Northern Ireland", "England" }
            },

            new Question {
                Id = 10026,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer famously made a comeback to win the 2019 Masters after 11 years?",
                CorrectAnswer = "Tiger Woods",
                Options = new() { "Phil Mickelson", "Tiger Woods", "Rory McIlroy", "Jordan Spieth" }
            },

            new Question {
                Id = 10027,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer holds the record for most wins in a single PGA Tour season?",
                CorrectAnswer = "Byron Nelson",
                Options = new() { "Tiger Woods", "Jack Nicklaus", "Byron Nelson", "Sam Snead" }
            },

            new Question {
                Id = 10028,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer has the most European Tour victories?",
                CorrectAnswer = "Seve Ballesteros",
                Options = new() { "Seve Ballesteros", "Rory McIlroy", "Nick Faldo", "Bernhard Langer" }
            },

            new Question {
                Id = 10029,
                Category = "Golf",
                Difficulty = "hard",
                Text = "What is the term for a shot that curves sharply to the left for a right-handed golfer?",
                CorrectAnswer = "Hook",
                Options = new() { "Slice", "Hook", "Fade", "Draw" }
            },

            new Question {
                Id = 10030,
                Category = "Golf",
                Difficulty = "hard",
                Text = "Which golfer is nicknamed 'Lefty'?",
                CorrectAnswer = "Phil Mickelson",
                Options = new() { "Phil Mickelson", "Tiger Woods", "Rory McIlroy", "Arnold Palmer" }
            },
        };
    }
}
