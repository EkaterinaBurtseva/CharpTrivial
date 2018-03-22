using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicetask0102
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculteDiscount(100);
        }
        public static int CalculteDiscount(int q)
        {
            int discount = 0;
            if (q < 10 )
            {
                discount = 5;
                Console.WriteLine("Discount is " + discount);
            }
            else if (q < 50 )
            {
                discount = 10;
                Console.WriteLine("Discount is " + discount);
            }
            else if (q < 100)
            {
                discount = 15;
                Console.WriteLine("Discount is " + discount);
            }
            else
            {
                discount = 20;
                Console.WriteLine(discount);
            }
            return discount;


        }
    }
}

