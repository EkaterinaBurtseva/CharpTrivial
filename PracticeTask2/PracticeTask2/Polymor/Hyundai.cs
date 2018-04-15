using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2.Polymor
{
    class Hyundai:Car
    {
        public Hyundai(int type) : base(type)
        {
        }

        public override void PrintColor()
        {
            Console.WriteLine("Black");
        }
    }
}
