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
            IFlatFigure circle = new Circle();
            Console.WriteLine("To find perimeter and area for " + circle.GetFigureName() + " enter radius");
            var radius = double.Parse(Console.ReadLine());
            IFlatFigure circleCalc = new Circle(radius);
            circleCalc.GetPerimeter();
            circleCalc.GetArea();            
            Console.WriteLine("---------------------------------------------------");

            IFlatFigure rectangle = new Rectangle();
            Console.WriteLine("To find perimeter and area for  " + rectangle.GetFigureName() + " enter side A and side B");
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            IFlatFigure rectangleCalc = new Rectangle(sideA, sideB);            
            rectangleCalc.GetPerimeter();
            rectangleCalc.GetArea();            
            Console.WriteLine("---------------------------------------------------");

            IFlatFigure triangle = new Triangle();            
            Console.WriteLine("To find perimeter for " + triangle.GetFigureName() + " enter next values: ");            
            Console.WriteLine("Enter side A ");
            var sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B ");
            var sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C ");
            var sideThree = double.Parse(Console.ReadLine());
            IFlatFigure triangleCalc = new Triangle(sideOne, sideTwo, sideThree);
            triangleCalc.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine("To find area for triangle enter next values: ");           
            Console.WriteLine("Enter height to side A ");
            var heightA = double.Parse(Console.ReadLine());
            IFlatFigure triangleArea = new Triangle(sideA, heightA);
            triangleArea.GetArea();
            Console.WriteLine("---------------------------------------------------");


            IFlatFigure square = new Square();                     
            Console.WriteLine("Finding area and perimeter for " + square.GetFigureName());          
            IFlatFigure squareCalc = new Square(sideA);
            squareCalc.GetArea();
            squareCalc.GetPerimeter();
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();
            IThreeDimensionalFigure parellelepiped = new Parallelepiped();
            Console.WriteLine("To find volume and perimeter for " + parellelepiped.GetFigureName() + "  next values: ");
            Console.WriteLine("Enter side A ");
            var sideOneA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B ");
            var sideTwoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C ");
            var sideThreeC = double.Parse(Console.ReadLine());
            IThreeDimensionalFigure parellelepipedCalc = new Parallelepiped(sideOneA, sideTwoB, sideThreeC);
            parellelepipedCalc.GetArea();
            parellelepipedCalc.GetVolume();
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();
            IThreeDimensionalFigure cube = new Cube();
            Console.WriteLine("Finding area and perimeter for " + cube.GetFigureName());
            IThreeDimensionalFigure cubeCalc = new Cube(sideOneA);
            cubeCalc.GetArea();
            cubeCalc.GetVolume();
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();
            IThreeDimensionalFigure cone = new Cone();
            Console.WriteLine("To find volume and perimeter for " + cone.GetFigureName() + "  next values: ");
            Console.WriteLine("Enter cone height ");
            var coneHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cone radius base ");
            var coneRadiusBase = double.Parse(Console.ReadLine());
            IThreeDimensionalFigure coneCalc = new Cone(coneRadiusBase, coneHeight);
            coneCalc.GetArea();
            coneCalc.GetVolume();
        }
    }
}
