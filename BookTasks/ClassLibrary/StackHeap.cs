using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class StackHeap
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            state1.country = new Country();
            Console.ReadLine();
        }
        static void Calculate(int t)
        {
            object x = 6;
            int y = 7;
            int z = y + t;
        }

        struct State
        {
            public int x;
            public int y;
            public Country country;

        }
        class Country
        {
            public int x;
            public int y;
        }
    }
}
