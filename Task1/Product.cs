using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task1
{
    internal class Product
    {
        private string _name;
        private Money _price;

        public Product(string name, int integerPart, double fractionalPart)
        {
            _name = name;
            _price.SetIntegerPart(integerPart);
            _price.SetFractionalPart(fractionalPart);
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void ReducePrice(double num)
        {
            if (_price.GetMoney() < num) // Якщо виходить від'ємна вартість
            {
                Console.WriteLine("Too much to reduce.");
                return;
            }

            int integerPart = (int)num; // ціла частина
            double fractionalPart = num - integerPart; // копійки

            if (integerPart == 0 && _price.GetFractionalPart() - fractionalPart < 0) // Якщо виходить від'ємна вартість
            {
                Console.WriteLine("Too much to reduce.");
                return;
            }
            else if (integerPart > 0 && _price.GetFractionalPart() - fractionalPart < 0)
            {
                _price.SetIntegerPart(_price.GetIntegerPart() - 1);
                _price.SetFractionalPart(1000 - fractionalPart);
            }
            else
            {
                _price.SetIntegerPart(_price.GetIntegerPart() - integerPart);
                _price.SetFractionalPart(_price.GetFractionalPart() - fractionalPart);
            }

        }
    }
}
