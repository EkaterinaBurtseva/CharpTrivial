using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Parallelepiped : IThreeDimensionalFigure
    {
        private string name = "Parallelepiped";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double ParallelepipedSide { get; set; }

        public Parallelepiped(double parallelepipedSide)
        {
            this.ParallelepipedSide = parallelepipedSide;
        }

        public double GetArea()
        {
            double a = 6 * Math.Pow(ParallelepipedSide, 2);
            Console.WriteLine("Parallelepiped area is " + a);
            return a;

        }

        public double GetVolume()
        {
            double p = 12 * ParallelepipedSide;
            Console.WriteLine("Parallelepiped perimeter is " + p);
            Console.ReadLine();
            return p;

        }
        public string GetFigureName()
        {       
            
            return Name;
        }
    }
}
