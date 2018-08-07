using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Square:Rectangle
    {
        private string nameSquare ="Square";

        public Square(double SideA) : base(SideA)
        {
           Name = nameSquare;
        }
        public Square()
        {
        }
        public Square(string nameSquare)
        {
            this.Name = nameSquare;
        }

        public new string Name
        {
            get { return nameSquare; }
            set { nameSquare = value; }
        }
        public new double GetArea()
        {
            double a = Math.Pow(SideA, 2);
            Console.WriteLine("Square area is " + a);
            return a;

        }

        public new double GetPerimeter()
        {
            double p = 4 *SideA;
            Console.WriteLine("Square perimeter is " + p);
            return p;

        }

        public new string GetFigureName()
        {                     
            return Name;
        }

        

    }
}
