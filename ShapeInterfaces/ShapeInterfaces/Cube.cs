using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Cube:IFigure
    {
        public double CubeSide { get; set; }

        public Cube()
        {

        }

        public Cube(double Side)
        {
            this.CubeSide = CubeSide;
        }

        public void FindArea()
        {
            double a = 6 *Math.Pow(CubeSide, 2);
            Console.WriteLine("Cube area is " + a);

        }

        public void FindPerimeter()
        {
            double p = 12 * CubeSide;
            Console.WriteLine("Cube perimeter is " + p);
            Console.ReadLine();

        }
    }
}
