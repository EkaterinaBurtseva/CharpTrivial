using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class Account
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1000, 6);
            Account acc2 = new Account(900, 5);
            Account.MinSum = 200;
            Account.GetSum(1000, 10, 5);
            //Console.WriteLine(acc1.GetSum(1000, 10, 5));
            // Console.WriteLine(acc2.GetSum(1000, 10, 5));

            User user = new User();
            User.Display();
            Console.ReadKey();
        }

        class User
        {
            private static int counter = 0;
            public User()
            {
                counter++;
            }

            static User()
            {
                Console.WriteLine("first user is created");
            }

            public static void Display()
            {
                Console.WriteLine($"{counter}"); 
            }

        }
        private static decimal minSum = 100;
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Invalid sum");
            Sum = sum; Rate = rate;
        }

        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
}
