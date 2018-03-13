using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial(23);
        }
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;//base case
            }
            else
            {
                return n * Factorial(n - 1);//recursive case

            }
        }
    }
}
