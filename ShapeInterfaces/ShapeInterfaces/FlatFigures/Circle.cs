using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Circle: IFlatFigure
    {
        const double pi = 3.14;
        private string name ="Circle";

        public double Radius { get;}
                    
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle(string name)
        {
            this.Name = name;
        }

        public Circle()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int VerticesCount { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

        public double GetPerimeter()
        {
            double p = 2 *pi * Radius;
            Console.WriteLine("Circle perimeter is " + p);
            return p;
                        
        }
        public double GetArea()
        {
            double a = pi * Math.Pow(Radius,2);
            Console.WriteLine("Circle area is " + a);
            return a;
            
        }

        public string GetFigureName()
        {                        
            return Name;
        }

        public int GetVerticesCount()
        {
            throw new NotSupportedException();
        }
    }
}
