using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle:Polygon
    {

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double GetArea()
        {
            return Width * Length;
        }

       
        /*
        public static string ShapeName
        {
            get { return "Rectangle"; }
        }
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return this.Length * this.Width;
        }
        
    }
    struct Point
    {
        public double X, Y;
    }
    */
    }

   