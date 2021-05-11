using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public class Animals
    {
        // giraf --> elefant --> ræve og ulve --> bunbuns

        public string Name { get => Name; set => Name = value; }

        public Animals(string name)
        {
            //this is a constuctor
            this.Name = name;
        }

        public virtual int Poop(int numberOfPoops)
        {
            return 0;
        }

    }
}
