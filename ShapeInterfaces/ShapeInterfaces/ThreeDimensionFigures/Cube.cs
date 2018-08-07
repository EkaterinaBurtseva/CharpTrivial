using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeInterfaces
{
   public  class Cube: Parallelepiped, IThreeDimensionalFigure
    {
        private string name ="Cube";

        public Cube(double parallelepipedSide) : base(parallelepipedSide)
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }                     
        

        public double GetArea()
        {
            double a = 6 *Math.Pow(ParallelepipedSide, 2);
            Console.WriteLine("Cube area is " + a);
            return a;

        }

        public double GetVolume()
        {
            double p = 12 * ParallelepipedSide;
            Console.WriteLine("Cube perimeter is " + p);
            Console.ReadLine();
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
