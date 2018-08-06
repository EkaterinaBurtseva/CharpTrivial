using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Square:IFlatFigure, Rectangle
    {
        public double Side { get; }        
       
        public Square(double Side)
        {
            this.Side = Side;
        }
       
        public double GetArea()
        {
            double a = Math.Pow(Side, 2);
            Console.WriteLine("Square area is " + a);
            return a;

        }

        public double GetPerimeter()
        {
            double p = 4 * Side;
            Console.WriteLine("Square perimeter is " + p);
            return p;

        }

        public string GetFigureName()
        {
            return "";
        }


    }
}
