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
        public double SideС { get; }
        public double SideD { get; }

        public Quadrilatel(string name)
        {
            this.Name = name;
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Quadrilatel(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideС = sideC;
            SideD = sideD;
        }
    

        public int VerticesCount
        {
            get { return count; }
            set { count = value; }
        }

       
        public virtual double GetArea()
        {
            return 0;

        }

        public virtual double GetPerimeter()
        {
            return 0;

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
