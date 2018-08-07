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

        public double SideA { get; }
        public double SideB { get; }

        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public Rectangle(double sideA)
        {
            this.SideA = sideA;
           
        }

        public Rectangle(string name)
        {
            this.Name = name;
        }

        public Rectangle()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double GetArea()
        {
            double a = SideA * SideB;
            Console.WriteLine("Square area is " + a);
            return a;

        }

        public double GetPerimeter()
        {
            double p = 2*(SideA + SideB);
            Console.WriteLine("Square perimeter is " + p);
            return p;

        }

        public string GetFigureName()
        {
           return Name;
        }

    }
}
