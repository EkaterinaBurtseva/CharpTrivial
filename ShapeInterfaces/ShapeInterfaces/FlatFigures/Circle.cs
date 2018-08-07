using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Circle: IFlatFigure
    {
        const double Pi = 3.14;
        private string name ="Circle";

        public double Radius { get;}
                    
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public Circle(string name)
        {
            this.Name = name;
        }

        public double GetPerimeter()
        {
            double p = 2 *Pi * Radius;
            Console.WriteLine("Circle perimeter is " + p);
            return p;
                        
        }
        public double GetArea()
        {
            double a = Pi * Math.Pow(Radius,2);
            Console.WriteLine("Circle area is " + a);
            return a;
            
        }

        public string GetFigureName()
        {
            string s = "Figure name is " + this.Name;
            Console.WriteLine(s);
            return s;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
