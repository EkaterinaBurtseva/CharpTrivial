using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.Foo();
            cl.Foo("test2");
            Console.ReadLine();
        }
    }
}
