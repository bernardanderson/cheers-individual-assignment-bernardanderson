using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variables section 
            String greeting = "What's your name?";
            String birthday_request = "What's your birthday?";
            String prompt = "> ";
            String cheer_prefix = "Give me ";
            String requires_an = "aeiolnfshrmx"; // An array of characters that require the prefix "an"
            String [] user_birth_info;
            DateTime user_birth_date;
            Int32 current_day_of_year = DateTime.Today.DayOfYear;
            Int32 user_day_of_year;          
            Int32 days_away;

            Console.WriteLine(greeting);
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower(); // Read from terminal to a variable
            Console.WriteLine(birthday_request);
            Console.Write(prompt);
            String user_birthdate = Console.ReadLine(); // Read user birth date from terminal to a variable

            for (int i = 0; i <user_name.Length; i++) {
                if (requires_an.IndexOf(user_name[i]) > -1 ) {
                    Console.WriteLine(cheer_prefix + "an.. " + user_name[i]);
                } else {
                    Console.WriteLine(cheer_prefix + "a..  " + user_name[i]);
                }
            }

            // user_name.ToUpper() is turning the user's name to uppercase.
            // ToUpper() is finctionality specific to strings.
            // ToUpper accepts no arguments
            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!\n");

            user_birth_info = user_birthdate.Split(new Char [] {'/'} );
            user_birth_date = new DateTime(DateTime.Today.Year, Convert.ToInt32(user_birth_info[0]), Convert.ToInt32(user_birth_info[1]));
            user_day_of_year = user_birth_date.DayOfYear;

            if (user_day_of_year > current_day_of_year) {
                days_away = user_day_of_year - current_day_of_year;
                Console.WriteLine("Your birthday is " + days_away + " days away!");
            } else if (user_day_of_year < current_day_of_year) {
                Int32 user_birth_days_following_year = user_birth_date.AddYears(1).DayOfYear;
                Int32 days_in_current_year = new DateTime(user_birth_date.Year, 12, 31).DayOfYear;
                days_away = user_birth_days_following_year + (days_in_current_year - current_day_of_year);
                Console.WriteLine("Your birthday is " + days_away + " days away!");
            } else {
                Console.WriteLine("It's Your Birthday!! Happy Birthday!!");
            }
        }
    }
}
