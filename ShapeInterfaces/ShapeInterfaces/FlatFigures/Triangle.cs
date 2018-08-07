﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    class Triangle :IFlatFigure
    {
        private string name ="Triangle";

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double HeightA { get;}

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public Triangle(double sideA, double heightA)
        {
            this.SideA = sideA;            
            this.HeightA = heightA;
        }

        public Triangle()
        {
        }

        public double GetArea()
        {
            double a = 0.5*SideA*HeightA;
            Console.WriteLine("Triangle area is " + a);
            return a;
           
        }

        public double GetPerimeter()
        {
            double p = SideA + SideB + SideC;
            Console.WriteLine("Triangle perimeter is " + p);
            return p;
          
        }

        public string GetFigureName()
        {
            return Name;
        }

      
    }
}
