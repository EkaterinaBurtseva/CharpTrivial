using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2
{
   class Car
    {
        String color ="red";
        int speed;
       public  int type;
        public virtual void PrintColor()
        {
            Console.WriteLine(color);
        }

       
        public Car(int type)
        {
            this.type = type;
        }
       
    }
}
