using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Triangle :IFlatFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double HeightA { get;}
         
             
        public Triangle(double sideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        public Triangle(double SideA, double HeightA)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.HeightA = HeightA;
        }
        public double GetArea()
        {
            double a = 0.5*SideA*HeightA;
            Console.WriteLine("Triangle area is " + a);
            return a;
           
        }

        public double GetPerimeter()
        {
            double p = SideA + SideB + SideC;
            Console.WriteLine("Triangle perimeter is " + p);
            return p;
          
        }

        public string GetFigureName()
        {
            return "";
        }
    }
}
