using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act8
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
            Console.WriteLine($"Name: {Name} |ID: {ID} |Department: {Department}");
        }
    }
      // DERIVED CLASS: BASKETBALL
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
            Console.WriteLine($"Sports: [Basketball] | Name: {Name} |ID: {ID} |Department: {Department} | Points: {Points}");
        }
    }
     // DERIVED CLASS: ARNIS
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
}

