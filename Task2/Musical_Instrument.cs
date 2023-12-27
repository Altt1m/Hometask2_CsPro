using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task2
{
    internal class Musical_Instrument
    {
        private string Name { get; set; }
        private string Description { get; set; }

        public Musical_Instrument(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");

        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("I don't know how this instrument sounds :(");
        }

        public virtual void History()
        {
            Console.WriteLine("https://wikipedia.com");
        }

    }
}
