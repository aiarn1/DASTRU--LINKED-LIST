using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the sports manager and start the main menu loop
            ManageSports manager = new ManageSports();
            bool exit = false;
            while (!exit)
            {
                try
                {
                    // Display the main menu with options for the user
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n----- SPORTS REGISTRATION SYSTEM -----");
                    Console.WriteLine("[1] Register Athlete");
                    Console.WriteLine("[2] Remove Athlete");
                    Console.WriteLine("[3] Display Athletes");
                    Console.WriteLine("[4] Exit");
                  
                    // Get the user's choice and what action to perform             
                    int choice = UserInput.GetInt("\nChoose an option: ");
                    if (choice == 1)
                    {
                        RegisterAthlete(manager);
                    }
                    else if (choice == 2)
                    {
                        string id = UserInput.GetString("\nEnter Athlete ID to remove: ");
                        manager.Remove(id);
                    }
                    else if (choice == 3)
                    {
                        manager.Display();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Exiting program...");
                        exit = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please choose 1–4.");
                        Console.ResetColor();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid input. Please try again.");
                    Console.ResetColor();
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // Method to register a new athlete based on what sport they choose
        static void RegisterAthlete(ManageSports manager)
        {
            Console.WriteLine("\nChoose Sport: [1] Basketball [2] Arnis");
            int sportChoice = UserInput.GetInt("Enter choice: ");

            string dept = UserInput.GetString("Department: ");
            string name = UserInput.GetString("Name      : ");
            string id = UserInput.GetString("ID        : ");

            if (sportChoice == 1)
            {
                int pts = UserInput.GetInt("Points    : ");
                manager.Insert(new Basketball(dept, name, id, pts));
            }
            else if (sportChoice == 2)
            {
                int wins = UserInput.GetInt("Matches Won : ");
                manager.Insert(new Arnis(dept, name, id, wins));
            }
            else
            {
                Console.WriteLine("Invalid sport selection.");
            }
        }
    }
    
}
