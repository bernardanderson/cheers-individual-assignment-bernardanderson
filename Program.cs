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
            Console.WriteLine("What's your name?");
            Console.Write("> ");
            String user_name = Console.ReadLine(); // Read from terminal to a variable

            // user_name.ToUpper() is turning the user's name to uppercase.
            // ToUpper() is finctionality specific to strings.
            // ToUpper accepts no arguments

            Console.WriteLine(user_name.ToUpper() + " is.. GRAND!");
        }
    }
}
