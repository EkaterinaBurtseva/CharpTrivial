using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Circle: IFigure
    {
        const double Pi = 3.14;
        public double Radius { get; set; }

        public Circle()
        {

        }
      
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public void FindPerimeter()
        {
            double p = 2 *Pi * Radius;
            Console.WriteLine("Circle perimeter is " + p);
            
        }
        public void FindArea()
        {
            double a = Pi * Math.Pow(Radius,2);
            Console.WriteLine("Circle area is " + a);
            
        }
    }
}
