using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Square:IFigure
    {
        public double Side { get; set; }
        
        public Square()
        {

        }

        public Square(double Side)
        {
            this.Side = Side;
        }
       
        public void FindArea()
        {
            double a = Math.Pow(Side, 2);
            Console.WriteLine("Square area is " + a);

        }

        public void FindPerimeter()
        {
            double p = 4 * Side;
            Console.WriteLine("Square perimeter is " + p);

        }
    }
}
