using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // ACTIVITY 7:  Inserting Nodes with Exception Handling

            // Create a LinkedList to store teacher last names
            LinkedList<string> list = new LinkedList<string>();
            int count = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Ask how many names to input (with exception handling)
            try
            {
                Console.Write("How many favorite teacher last names will you input?: ");
                count = int.Parse(Console.ReadLine());

                if (count <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\tNumber must be greater than zero.");
                }
            }
            catch (FormatException)
            {           
                Console.WriteLine("Invalid input! Please enter a numeric value.");
                Console.ReadKey(); return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message);
                Console.ReadKey(); return;
            }
            // Input teacher last names
            Console.WriteLine("\n--- Enter Favorite Teacher Last Names ---\n");
            for (int i = 0; i < count; i++)
            {
                Console.Write("Favorite Teacher " + (i + 1) + ": ");
                string name = Console.ReadLine();
                list.AddLast(name);
            }
            // Display original linked list
            Console.WriteLine("\n----- Original Linked List -----");
            foreach (string name in list)
            {
                Console.Write(name + " -> ");
            }
            // Convert LinkedList to Array
            string[] nameArray = new string[list.Count];
            list.CopyTo(nameArray, 0);
            // Sort the array
            Array.Sort(nameArray);
            // Display sorted elements
            Console.WriteLine("\n\n----- Sorted Linked List Elements -----");
            foreach (string name in nameArray)
            {
                Console.Write(name + " -> ");
            }
            Console.WriteLine("Null");
            Console.ReadKey();
        }
    }
    
}
