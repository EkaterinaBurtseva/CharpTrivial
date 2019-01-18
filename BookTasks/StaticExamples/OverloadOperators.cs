using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    class OverloadOperators
    {

        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };
            bool result = c1 > c2;
            Console.WriteLine(result);
            Counter c3 = c2 + c1;
            Console.WriteLine(c3.Value);

            int x = c2 + 20;
            Console.ReadKey();
        }

        class Counter
        {
            public int Value { get; set; }
            public static Counter operator +(Counter c1, Counter c2)
            {
                return new Counter { Value = c1.Value + c2.Value };
            }
            public static Counter operator ++(Counter c1)
            {
                //c1.Value = c1.Value + 1;
                //return c1;
                return new Counter { Value = c1.Value + 1};
            }


            public static int operator +(Counter c2, int x)
            {
                return c2.Value + x;
            }

            public static bool operator >(Counter c1, Counter c2)
            {
                if (c1.Value > c2.Value)
                    return true;
                else
                    return false;              
            }

            public static bool operator <(Counter c1, Counter c2)
            {
                if (c1.Value < c2.Value)
                    return true;
                else
                    return false;
            }
        }
    }
}
