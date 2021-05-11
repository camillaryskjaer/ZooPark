using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Species
{
    // ignore this it was before i figured i needed threads, go look at giraf
    public class Bunny : Animals
    {
        //kaniner : 10 min og så der ryddet op

        //have to have a basic constructor string name, and calls base constructor
        public Bunny(string name) : base(name)
        {
            //don't need to do this.name here becasue we are calling the base constructor or parent class we are inheriting from
            //need to 
        }

        //parameters below have to have a type, with int  below
       

        public string Message(string name)
        {
            this.Name = name;
            return Message("cage needs cleaning");
        }
        public string Message()
        {
            return this.Name;
        }

    }
}
