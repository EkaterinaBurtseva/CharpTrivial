using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Square:Rectangle, IFlatFigure
    {
        private string name ="Square";

        public Square(double side) : base(side)
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double GetArea()
        {
            double a = Math.Pow(Side, 2);
            Console.WriteLine("Square area is " + a);
            return a;

        }

        public double GetPerimeter()
        {
            double p = 4 *Side;
            Console.WriteLine("Square perimeter is " + p);
            return p;

        }

        public string GetFigureName()
        {
            string s = "Figure name is " + this.Name;
            Console.WriteLine(s);
            return s;
        }

        

    }
}
