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
        private int count =1;
        const double pi = 3.14;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double ConeRadiusBase { get; }
        public double ConeHeight { get; }

        public int VerticesCount
        {
            get { return count; }
            set { count = value; }
        }

        public Cone(double coneRadiusBase, double coneHeight)
        {
            this.ConeRadiusBase = coneRadiusBase;
            this.ConeHeight = coneHeight;            
        }

        public Cone()
        {
        }

        public double GetArea()
        {
            double baseCircleArea = pi * Math.Pow(ConeRadiusBase, 2);
            double generationConeLine = Math.Sqrt(Math.Pow(ConeRadiusBase, 2) + Math.Pow(ConeHeight, 2));
            double lateralArea = pi * ConeRadiusBase * generationConeLine;
            double a = baseCircleArea + lateralArea;
            Console.WriteLine("Cone area is " + a);
            return a;

        }

        public double GetVolume()
        {
            double v = ConeHeight / 3 * pi * Math.Pow(ConeRadiusBase, 2);
            Console.WriteLine("Cone volume is " + v);
            Console.ReadLine();
            return v;

        }

        public string GetFigureName()
        {            
            return Name;
        }

        public int GetVerticesCount()
        {
            return VerticesCount;
        }
    }
}
