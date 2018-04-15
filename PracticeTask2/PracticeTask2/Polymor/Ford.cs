using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2
{
    class Ford : Car
    {
        string color2 = "blue";

        public Ford(int type):base (type){
        }

        public Ford(int type, int speed)
        {
            this.type = type;
            this.speed = speed;
        }
        public override void PrintColor()
        {
            Console.WriteLine(color2);

        }
     
        
        
    }
}
