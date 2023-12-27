using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask2.Task3
{
    internal struct MyStruct
    {
        private int decimalNum;

        public MyStruct(int num)
        {
            decimalNum = num;
        }

        public string ToBinary()
        {
            return Convert.ToString(decimalNum, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(decimalNum, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(decimalNum, 16);
        }
    }
}
