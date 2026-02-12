using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8
{
     class ManageSports
    {
        // LINKED LIST TO STORE ATHLETES
        private LinkedList<Sports> athletes = new LinkedList<Sports>();
        public void Insert(Sports athlete)
        {
            athletes.AddLast(athlete);
            Console.WriteLine("Athlete added successfully.\n");
        }
        // METHOD TO REMOVE ATHLETE BY ID
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
        // METHOD TO DISPLAY ALL ATHLETES
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

