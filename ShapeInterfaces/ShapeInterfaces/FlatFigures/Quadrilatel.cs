using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces.FlatFigures
{
    public class Quadrilatel : IFlatFigure
    {
        private string name = "Quadrilatel";
        private int count = 4;
        public double SideA { get; set; }
        public double SideB { get; }

        public Quadrilatel(string name)
        {
            this.Name = name;
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Quadrilatel(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }
        public Quadrilatel(double sideA)
        {
            this.SideA = sideA;            
        }
        public Quadrilatel()
        {
            
        }

        public int VerticesCount
        {
            get { return count; }
            set { count = value; }
        }

       
        public virtual double GetArea()
        {
            double a = SideA * SideB;
            Console.WriteLine(Name + "  area is " + a);
            return a;

        }

        public virtual double GetPerimeter()
        {
            double p = 2 * (SideA + SideB);
            Console.WriteLine( Name +" perimeter is " + p);
            return p;

        }

        public virtual string GetFigureName()
        {
            return Name;
        }

        public virtual int GetVerticesCount()
        {       
            return VerticesCount;
        }
              
    }
}
