using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8_dastru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AthleteLinkedList list = new AthleteLinkedList();
            bool exit = false;

            while (!exit)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n--- SPORTS REGISTRATION SYSTEM ---");
                    Console.WriteLine("[1] Register Athlete");
                    Console.WriteLine("[2] Remove Athlete");
                    Console.WriteLine("[3] Display Athletes");
                    Console.WriteLine("[4] Exit");
                    Console.ResetColor();

                    Console.Write("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        RegisterAthlete(list);
                    }
                    else if (choice == 2)
                    {
                        string id = InputHelper.GetString("Enter Athlete ID to remove: ");
                        list.Remove(id);
                    }
                    else if (choice == 3)
                    {
                        list.Display();
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Exiting program...");
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please choose 1–4.");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid input. Please try again.");
                    Console.ResetColor();
                }
            }
        }

        static void RegisterAthlete(AthleteLinkedList list)
        {
            try
            {
                Console.WriteLine("\nChoose Sport: [1] Basketball [2] Arnis");
                int sportChoice = int.Parse(Console.ReadLine());

                string dept = InputHelper.GetString("Department: ");
                string name = InputHelper.GetString("Name: ");
                string id = InputHelper.GetString("ID: ");

                if (sportChoice == 1)
                {
                    int pts = InputHelper.GetInt("Points: ");
                    list.Insert(new Basketball(dept, name, id, pts));
                }
                else if (sportChoice == 2)
                {
                    int wins = InputHelper.GetInt("Matches Won: ");
                    list.Insert(new Arnis(dept, name, id, wins));
                }
                else
                {
                    Console.WriteLine("Invalid sport selection.");
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error while registering athlete.");
                Console.ResetColor();
            }
        }
    }
}
    

