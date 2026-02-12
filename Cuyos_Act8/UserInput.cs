using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8
{
    class UserInput
    {
        public static int GetInt(string message)
        {
            // This method prompts the user for an integer input and handles invalid input gracefully
            while (true)
            {
                try
                {
                    Console.Write(message);
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ResetColor();
                }
            }
        }
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
        

