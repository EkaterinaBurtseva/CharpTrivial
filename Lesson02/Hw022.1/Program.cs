using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw022._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter price");
            double price= Double.Parse(Console.ReadLine());
            Product p = new Product(name,price);
            Console.WriteLine(p.ToString());
        }
    }
}
