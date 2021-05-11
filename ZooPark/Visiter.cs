using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooPark
{
    public class Visiter
    {

        // 3200 gæster
        // mood happy and unhappy

        // Are they happy or currently unhappy (implement for each cage later on)

        // if the cages are not cleaned in time they will be very unhappy but if it is cleaned in time they they will stay happy
        // if implemented by cage we can have guests happy one place and unhappy another but thats just future thoughts


        //fields
        private string name;
        private bool isHappy;
        private bool isUnHappy;
        private bool thinkDelay;

        public Visiter(string name, bool isHappy, bool isUnHappy, bool thinkDelay)
        {
            Name = "Visitor";
            IsHappy = isHappy;
            IsUnHappy = isUnHappy;
            ThinkDelay = thinkDelay;

        }

        public string Name { get => name; set => name = value; }
        public bool IsHappy { get => isHappy; set => isHappy = value; }
        public bool IsUnHappy { get => isUnHappy; set => isUnHappy = value; }

        public bool ThinkDelay { get => thinkDelay; set => thinkDelay = value; }

    }

    public void Think(Visiter)
    {
        Thread.Sleep(Visiter.thinkDelay);

        if (??? = true) // ?? needs to be the method for the opening hours, so the visiters can be happy and unhappy only in working hours
        {
            Console.WriteLine($"{Name}, I am satisfied");
        }
        else
        {
            Console.WriteLine($"{Name}, I am unhappy");
        }

    }
}
