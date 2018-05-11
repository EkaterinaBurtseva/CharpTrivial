using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2
{
  abstract class Car
    {
        string color ="red";
        public int speed;
        public int type;
        public virtual void PrintColor()
        {
            Console.WriteLine(color);
        }

        public virtual void Drive()
        {
            speed = 50;

        }
        public Car(int type)
        {
            this.type = type;
        }

        public void Info()
        {
            
        }
       
    }
}
