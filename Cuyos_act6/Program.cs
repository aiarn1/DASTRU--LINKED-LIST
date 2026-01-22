using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cuyos_act6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // ACTIVITY 6: Inserting Nodes to the Linked List

            // Create Linked List
            LinkedList<string> list = new LinkedList<string>();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Title
            Console.WriteLine("--- Enter 5 Favorite Teacher Last Names ---\n");

            // Loop to Input 5 Names
            for (int i = 0; i < 5; i++)
            {
                // Input Favorite Teacher Last Name
                Console.Write("Favorite Teacher's "+ (i + 1) +  ": ");
                string name = Console.ReadLine();
                list.AddLast(name);
            }
            
            // Display Output
            Console.WriteLine("\n----- List of Favorite Teachers ----- ");
            foreach (string name in list)
            {         
                Console.Write(name + " -> ");
            }
            Console.ReadKey();

        }
    }
}
