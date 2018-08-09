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
                        
            Console.WriteLine("To find perimeter and area for Circle enter radius");
            var radius = double.Parse(Console.ReadLine());
            IFlatFigure circle = new Circle(radius);
            PrintName(circle);
            PrintPerimeter(circle);
            PrintArea(circle);                        
            Console.WriteLine("---------------------------------------------------");

            
            Console.WriteLine("To find perimeter and area for Rectangle enter side A and side B");
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            IFlatFigure rectangle = new Rectangle(sideA, sideB);
            PrintName(rectangle);
            PrintPerimeter(rectangle);
            PrintArea(rectangle);                  
            Console.WriteLine("---------------------------------------------------");

                     
            Console.WriteLine("To find perimeter for Triangle enter next values: ");            
            Console.WriteLine("Enter side A ");
            var sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B ");
            var sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C ");
            var sideThree = double.Parse(Console.ReadLine());
            IFlatFigure triangle = new Triangle(sideOne, sideTwo, sideThree);
            PrintName(triangle);
            PrintPerimeter(triangle);
            Console.WriteLine("To find area for triangle enter next values: ");           
            Console.WriteLine("Enter height to side A ");
            var heightA = double.Parse(Console.ReadLine());
            IFlatFigure triangleArea = new Triangle(sideA, heightA);
            PrintArea(triangleArea); ;
            Console.WriteLine("---------------------------------------------------");

                                   
            Console.WriteLine("Finding area and perimeter for Square");          
            IFlatFigure square = new Square(sideA);
            PrintName(square);
            PrintPerimeter(square);
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();            
            Console.WriteLine("To find volume and perimeter for Parellelepiped next values: ");
            Console.WriteLine("Enter side A ");
            var sideOneA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B ");
            var sideTwoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C ");
            var sideThreeC = double.Parse(Console.ReadLine());
            IThreeDimensionalFigure parellelepiped = new Parallelepiped(sideOneA, sideTwoB, sideThreeC);
            PrintName(parellelepiped);
            PrintVolume(parellelepiped);
            PrintArea(parellelepiped);      
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();            
            Console.WriteLine("Finding area and perimeter for Cube");
            IThreeDimensionalFigure cube = new Cube(sideOneA);
            PrintName(cube);
            PrintVolume(cube);
            PrintArea(cube);
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();            
            Console.WriteLine("To find volume and perimeter for Cone next values: ");
            Console.WriteLine("Enter cone height ");
            var coneHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cone radius base ");
            var coneRadiusBase = double.Parse(Console.ReadLine());
            IThreeDimensionalFigure cone = new Cone(coneRadiusBase, coneHeight);
            PrintName(cone);
            PrintVolume(cone);
            PrintArea(cone);
            Console.ReadLine();
          
        }

        public static void PrintName(IFigureBase figure)
        {
            Console.WriteLine(figure.Name);
        }
        public static void PrintPerimeter(IFlatFigure figure)
        {
            Console.WriteLine("Perimeter is " + figure.GetPerimeter());
        }

        public static void PrintArea(IFlatFigure figure)
        {
            Console.WriteLine("Area is " + figure.GetArea());
        }

        public static void PrintVolume(IThreeDimensionalFigure figure)
        {
            Console.WriteLine("Volume is " + figure.GetVolume());
        }

        public static void PrintArea(IThreeDimensionalFigure figure)
        {
            Console.WriteLine("Area is  " + figure.GetArea());
        }
    }
}
