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
            int countTwo = 0;

            if (number % 2 == 0 && number % 3 != 0)
            {
                number = number - 2;
                countTwo++;
            }
            if (number % 3 == 0 && number != 0)
            {
                number = number - 3;
                countThree++;

            }
            if (number % 2 != 0 && number % 3 != 0)
            {
                number = number - 2;
                countTwo++;
               
                
            }

            Console.WriteLine($"{ enteredValue} is 2 * {countTwo} and 3 * {countThree}");
            Console.ReadLine();

        }
    }
}
