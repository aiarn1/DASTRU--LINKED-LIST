using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_Act10_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue and display menu
            MyQueue q = new MyQueue(); 
            int choice;
            do
            { 
                // Selection menu
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n--- Queue Menu ---");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Display");
                Console.WriteLine("0. Exit");
                Console.Write("Choose a number: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("\nEnter number: ");
                            int num = int.Parse(Console.ReadLine());
                            q.Enqueue(num);
                            break;
                        case 2:
                            q.Dequeue();
                            break;
                        case 3:
                            q.Display();
                            break;
                        case 0:
                            Console.WriteLine("Program ended.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid choice Please select 1-3 only.");
                            break;
                    }
                }
                // Handle any exceptions 
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message); choice = -1;
                }
            } while (choice != 0);
        }
    }
}

