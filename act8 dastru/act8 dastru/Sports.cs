using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8_dastru
{
     class Sports
    {
       
        
            public string Department { get; set; }
            public string Name { get; set; }
            public string ID { get; set; }

            public Sports(string dept, string name, string id)
            {
                Department = dept;
                Name = name;
                ID = id;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"{Name} | {ID} | {Department}");
            }
        }

        // ==============================
        // DERIVED CLASS: BASKETBALL
        // ==============================
        class Basketball : Sports
        {
            public int Points { get; set; }

            public Basketball(string dept, string name, string id, int points)
                : base(dept, name, id)
            {
                Points = points;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"[Basketball] {Name} | {ID} | {Department} | Points: {Points}");
            }
        }

        // ==============================
        // DERIVED CLASS: ARNIS
        // ==============================
        class Arnis : Sports
        {
            public int MatchesWon { get; set; }

            public Arnis(string dept, string name, string id, int matchesWon)
                : base(dept, name, id)
            {
                MatchesWon = matchesWon;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"[Arnis] {Name} | {ID} | {Department} | Matches Won: {MatchesWon}");
            }
        }

        // ==============================
        // STATIC USER INPUT CLASS
        // ==============================
        static class InputHelper
        {
            public static int GetInt(string message)
            {
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

        // ==============================
        // LINKED LIST OPERATIONS CLASS
        // ==============================
        class AthleteLinkedList
        {
            private LinkedList<Sports> athletes = new LinkedList<Sports>();

            public void Insert(Sports athlete)
            {
                athletes.AddLast(athlete);
                Console.WriteLine("Athlete added successfully.\n");
            }

            public void Remove(string id)
            {
                var node = athletes.First;

                while (node != null)
                {
                    if (node.Value.ID == id)
                    {
                        athletes.Remove(node);
                        Console.WriteLine("Athlete removed successfully.\n");
                        return;
                    }
                    node = node.Next;
                }

                Console.WriteLine("Athlete not found.\n");
            }

            public void Display()
            {
                if (athletes.Count == 0)
                {
                    Console.WriteLine("No athletes registered.\n");
                    return;
                }

                Console.WriteLine("\n--- REGISTERED ATHLETES ---");
                foreach (Sports athlete in athletes)
                {
                    athlete.DisplayInfo();
                }
                Console.WriteLine();
            }
        }
    
}
