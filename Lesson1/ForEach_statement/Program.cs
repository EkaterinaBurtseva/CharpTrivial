using System;

namespace ForEach_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachTest();
        }
        public static void ForEachTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach(int i in numbers)
            {
                Console.WriteLine("The value of i={0}", i);
            }
        }
    }
}
