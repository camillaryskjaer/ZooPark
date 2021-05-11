using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooPark.Species
{
    public class Giraf : Animals
    {

        /* giraf : 6 lorte om dagen (12 giraffer = 72 om dagen) (højste priotet for opsamling grundet lille indhejning)
        tager 4 min at fjerne lorten */


        //have to have a basic constructor string name, and calls base constructor
        //don't need to do this.name here becasue we are calling the base constructor or parent class we are inheriting from
        public Giraf(string name) : base(name)
        {
            Name = "Giraf";
        }

        // lets make that giraf poop shall we(we will start with just 1 giraf)
        public void PoopGiraf(int numberOfPoops, Object obj, ref List<Elephant> elephants)
        {
            DateTime startTime = DateTime.Now;

            Thread girafThread = new Thread(() =>
            {
                int animalpoop = base.Poop(0);
                while (numberOfPoops < 6)
                {
                    Thread.Sleep(1000); // lorte i timen skal beregnes og implementeres here for dets tid imellem lorte

                        numberOfPoops++;
                }
            });
        }
    }
}
