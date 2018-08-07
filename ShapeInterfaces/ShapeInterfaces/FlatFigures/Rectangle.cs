using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Rectangle : IFlatFigure
    {
        private string name = "Rectangle";

        public double Side { get; }
        public double SideB { get; }

        public Rectangle(double side, double sideB)
        {
            this.Side = side;
            this.SideB = sideB;
        }

        public Rectangle(double side)
        {
            this.Side = side;
           
        }

        public Rectangle(string name)
        {
            this.Name = name;
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
            double p = 4 * Side;
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
