using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Class1:Interface1,Interface2
    {
        public void Foo()
        {
            Console.WriteLine("test");
        }

        public void Foo(string abc)
        {
            Console.WriteLine(abc);
        }
    }
}
