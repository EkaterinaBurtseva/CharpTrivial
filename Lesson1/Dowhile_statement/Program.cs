using System;

namespace Dowhile_statement
{
    class DoWhileTest
    {
        static void Main(string[] args)
        {
           DowhileTest();
        }

        public static void DowhileTest() { 
            int i = 1;
            do
            {
                Console.WriteLine("The value of  i={0}",i);
            i++;
            }
    while(i<=5);
        }
    }
}
