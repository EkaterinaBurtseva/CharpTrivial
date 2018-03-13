using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForTest();
        }
        public static void ForTest()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i={0}", i);
            }
        }
    }
}
