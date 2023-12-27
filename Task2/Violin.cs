using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task2
{
    internal class Violin : Musical_Instrument
    {
        public Violin(string name, string description) : base(name, description) { }
        
        public virtual void Sound()
        {
            Console.WriteLine("Sounds like violin :)");
        }

        public virtual void History()
        {
            Console.WriteLine("https://en.wikipedia.org/wiki/Violin");
        }
    }
}
