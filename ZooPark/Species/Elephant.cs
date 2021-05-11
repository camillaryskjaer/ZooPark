using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Species
{
    // ignore this it was before i figured i needed threads, go look at giraf
    public class Elephant : Animals
    {

        //elefant 15 lorte om dagen (6 elefanter = 90 lorte på en dag) 3,75 i timen, fjern 1 lort = 6 min

        //have to have a basic constructor string name, and calls base constructor
        public Elephant(string name) : base(name)
        {
            //don't need to do this.name here becasue we are calling the base constructor or parent class we are inheriting from
            //need to 
        }

        //parameters below have to have a type, with int  below
        public override int Poop(int numberOfPoops)
        {
            int animalpoop = base.Poop(15); //use of base calls the parent class as well
            return numberOfPoops = 15;
        }

        public int poop()
        {
            return 15;
        }

        public string Message(string name)
        {
            this.Name = name;
            return Message(" have pooped");
        }
        public string Message()
        {
            return this.Name;
        }

    }
}
