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
            String prompt = "> ";
            String cheer_prefix = "Give me ";
            String requires_an = "aeiolnfshrmx"; // An array of characters that require the prefix "an"

            Console.WriteLine(greeting);
            Console.Write(prompt);
            String user_name = Console.ReadLine().ToLower(); // Read from terminal to a variable

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

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");
        }
    }
}
