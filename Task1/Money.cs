using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task1
{
    internal class Money
    {
        private int _integerPart { get; set; } // ціла частина
        private double _fractionalPart { get; set; } // капєйкі

        public Money(int integerPart, int fractionalPart)
        {
            _integerPart = integerPart;
            _fractionalPart = fractionalPart;
        }

        public void ShowMoney()
        {
            Console.WriteLine($"Money: {_integerPart}.{_fractionalPart} UAH.");
        }

        public double GetMoney()
        {
            return _integerPart + _fractionalPart;
        }

        public void SetIntegerPart(int integerPart)
        {
            _integerPart = integerPart;
        }

        public int GetIntegerPart()
        {
            return _integerPart;
        }

        public void SetFractionalPart(double fractionalPart)
        {
            _fractionalPart = fractionalPart;
        }

        public double GetFractionalPart()
        {
            return _fractionalPart;
        }

    }
}
