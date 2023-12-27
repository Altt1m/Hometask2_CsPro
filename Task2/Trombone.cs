using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task2
{
    internal class Trombone : Musical_Instrument
    {
        public Trombone(string name, string description) : base(name, description) { }

        public virtual void Sound()
        {
            Console.WriteLine("Sounds like trombone :)");
        }

        public virtual void History()
        {
            Console.WriteLine("https://en.wikipedia.org/wiki/Trombone");
        }
    }
}
