using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Species
{

    // ignore this it was before i figured i needed threads, go look at giraf
    public class FoxAndWolf : Animals
    {
        //ræv og ulv gennemsnit 4 om dagen, 20x2 i indhegningen, lort tager 2 min at ryde

        //have to have a basic constructor string name, and calls base constructor
        public FoxAndWolf(string name) : base(name)
        {
            //don't need to do this.name here becasue we are calling the base constructor or parent class we are inheriting from
            //need to 
        }

        //parameters below have to have a type, with int  below
        public override int Poop(int numberOfPoops)
        {
            int animalpoop = base.Poop(4); //use of base calls the parent class as well
            return numberOfPoops = 4;
        }

        public int poop()
        {
            return 4;
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

