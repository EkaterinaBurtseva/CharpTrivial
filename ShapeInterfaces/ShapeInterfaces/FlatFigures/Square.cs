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

        public Square(double SideA) : base(SideA, SideA)
        {
            Name = nameSquare;
        }
        
        public override string Name
        {
            get { return nameSquare; }
            set { nameSquare = value; }
        }
        public override double GetArea()
        {
            double a = Math.Pow(SideA, 2);            
            return a;

        }

        public override double GetPerimeter()
        {
            double p = 4 *SideA;           
            return p;

        }

        public new string GetFigureName()
        {                     
            return Name;
        }              

    }
}
