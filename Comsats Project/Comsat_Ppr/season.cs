
//? Q3: List Handler
namespace NaturalSeason
{
    class SeasonFinder
    {
        public static void DetermineSeason()
        {
            // Getting user input for month && day
            Console.Write("Input the month (e.g. January, February etc.): ");
            string month = Console.ReadLine().ToLower();

            Console.Write("Input the day: ");
            int day = int.Parse(Console.ReadLine());


            string season = GetSeason(month, day);

            if (season != null)
            {
                Console.WriteLine("Season is {0}.", season);
            }
            else
            {
                Console.WriteLine("Invalid month or day");
            }

        }

        // Season Logic
        private static string GetSeason(string month, int day)
        {
            if ((month == "march" && day >= 20) || month == "april" || month == "may" || (month == "june" && day <= 21))
            {
                return "Spring";
            }
            else if ((month == "june" && day >= 21) || month == "july" || month == "august" || (month == "september" && day < 23))
            {
                return "Summer";
            }
            else if ((month == "september" && day >= 23) || month == "october" || month == "november" || (month == "december" && day < 21))
            {
                return "Autumn";

            }
            else if ((month == "december" && day >= 21) || month == "january" || month == "february" || (month == "march" && day < 20))
            {
                return "Winter";
            }
            else
            {
                return null;
            }

        }
    }
}