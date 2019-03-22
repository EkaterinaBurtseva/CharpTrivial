using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3And5
{
    public class SumOf3and5Calculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string enteredValue = Console.ReadLine();
            int number = Convert.ToInt32(enteredValue);
            if (number < 7)
            {
                Console.WriteLine("Please enter number above 7");
            }
            int countThree = 0;
            int countFive = 0;

            while (number % 3 != 0 && number != 0)
            {
                number = number - 5;
                countFive++;

            }
            countThree = number / 3;

            Console.WriteLine($"{ enteredValue} is 5 * {countFive} and 3 * {countThree}");
            Console.ReadLine();

        }
    }
}
