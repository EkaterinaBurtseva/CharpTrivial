using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Rectangle : FlatFigures.Quadrilatel
    {
        private string name = "Rectangle";


        public Rectangle(double SideA, double SideB) : base(SideA, SideB, SideA, SideB)
        {

        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
           

        public override string GetFigureName()
        {
           return Name;
        }
        public override int GetVerticesCount()
        {
            return VerticesCount;
        }

        public override double GetArea()
        {
            double a = SideA * SideB;
            return a;

        }
        public override double GetPerimeter()
        {
            double p = 2 * (SideA + SideB);
            return p;

        }

    }
}
