using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeInterfaces
{
    class Cube:IThreeDimensionalFigure, Parallelepiped
    {
        public double CubeSide { get; }
                
        public Cube(double Side)
        {
            this.CubeSide = CubeSide;
        }

        public double GetArea()
        {
            double a = 6 *Math.Pow(CubeSide, 2);
            Console.WriteLine("Cube area is " + a);
            return a;

        }

        public double GetVolume()
        {
            double p = 12 * CubeSide;
            Console.WriteLine("Cube perimeter is " + p);
            Console.ReadLine();
            return p;

        }
        public string GetFigureName()
        {
            return "";
        }
    }
}
