using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Calculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To find perimeter and area for circle enter radius");
            var Radius = double.Parse(Console.ReadLine());
            IFlatFigure circle = new Circle(Radius);
            //circle.GetPerimeter();
            //circle.GetArea();
            circle.GetFigureName();

            Console.WriteLine();
            Console.WriteLine("To find perimeter for triangle enter next values: ");
            Console.WriteLine();
            Console.WriteLine("Enter side A ");
            var SideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B ");
            var SideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C ");
            var SideC = double.Parse(Console.ReadLine());
            IFlatFigure triangle = new Triangle(SideA, SideB, SideC);
            triangle.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine("To find area for triangle enter next values: ");
            Console.WriteLine();
            Console.WriteLine("Enter height to side A ");
            var HeightA = double.Parse(Console.ReadLine());
            IFlatFigure triangleA = new Triangle(SideA, HeightA);
            triangleA.GetArea();

            Console.WriteLine();
            Console.WriteLine("To find area and perimeter for square enter its side ");
            var Side = double.Parse(Console.ReadLine());
            IFlatFigure square = new Square(Side);
            square.GetArea();
            square.GetPerimeter();

            Console.WriteLine();
            Console.WriteLine("To find area and perimeter for cube enter its side ");
            var CubeSide = double.Parse(Console.ReadLine());
            IThreeDimensionalFigure cube = new Cube(CubeSide);
            cube.GetArea();
            
        }
    }
}
