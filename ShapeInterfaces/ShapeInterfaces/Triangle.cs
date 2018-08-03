using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Triangle :IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double HeightA { get; set; }
        public Triangle()
        {

        }

        public Triangle(double SideA, double SideB, double SideC)
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
        public void FindArea()
        {
            double a = 0.5*SideA*HeightA;
            Console.WriteLine("Triangle area is " + a);
           
        }

        public void FindPerimeter()
        {
            double p = SideA + SideB + SideC;
            Console.WriteLine("Triangle perimeter is " + p);
          
        }
    }
}
