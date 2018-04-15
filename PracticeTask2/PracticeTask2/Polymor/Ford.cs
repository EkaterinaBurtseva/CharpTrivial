using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2
{
    class Car2 : Car
    {
        string color2 = "blue";

        public Car2(int type):base (type){
}

        public override void PrintColor()
        {
            Console.WriteLine(color2);

        }

        public override void Drive()
        {
            speed = 100;
        }
     
        
        
    }
}
