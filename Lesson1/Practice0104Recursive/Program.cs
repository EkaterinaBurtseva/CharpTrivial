/*You are developing a library of utility functions for your application. You need to write a
method that takes an integer and counts the number of significant digits in it. You need to
create a recursive program to solve this problem. How would you write such a program?
*/
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
           int result= CountDigits(10230);
            Console.WriteLine(result);
        }
        public static int CountDigits(int number)
        {
            
            if (number < 10)
            {
                return 1;
            }
            else
            {
                return 1 + CountDigits(number / 10);
            }
        }
    }
}
