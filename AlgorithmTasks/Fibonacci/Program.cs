using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
                
            }
            Console.ReadLine();
            Fibonacci_recursive(0, 1, 1, 15);
        }
        public static int Fibonacci(int n) {
            int a = 0;
            int b = 1;
            for(int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        public static void Fibonacci_recursive(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0}", a);
                Fibonacci_recursive(b, a + b, counter + 1, len);
            }
        }
}
}
