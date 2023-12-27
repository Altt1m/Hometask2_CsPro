using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task2
{
    internal class Cello : Musical_Instrument
    {
        public Cello(string name, string description) : base(name, description) { }

        public virtual void Sound()
        {
            Console.WriteLine("Sounds like cello :)");
        }

        public virtual void History()
        {
            Console.WriteLine("https://en.wikipedia.org/wiki/Cello");
        }
    }
}
