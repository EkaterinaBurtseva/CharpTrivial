using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Cone : IThreeDimensionalFigure
    {
        private string name = "Cone";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       

        public double GetArea()
        {
            double a =4.56;            
            return a;

        }

        public double GetVolume()
        {
            double p = 4.56;
            //Console.WriteLine("Parallelepiped perimeter is " + p);
           // Console.ReadLine();
            return p;

        }
        public string GetFigureName()
        {
            string s = "Figure name is " + this.Name;
            Console.WriteLine(s);
            return s;
        }
    }
}
