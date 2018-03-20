using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice0104Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int CountDigits(int number)
        {
            int digits = 1;
            if (number < 10)
            {
                return 1;
            }
            else
            {
                return 1 + (number / 10);
            }
        }
    }
}
