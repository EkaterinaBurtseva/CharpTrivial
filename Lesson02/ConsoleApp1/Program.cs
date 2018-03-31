using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Rectangle rect = new Rectangle
             { Length = 10.0, Width = 20.0 };
             Console.WriteLine("Shape Name: {0}, Area: {1}", Rectangle.ShapeName, rect.GetArea());
             */
            /*
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            Point p2 = p1;
            p2.X = 100;
            Console.WriteLine("p1.X = { 0}", p1.X);
            Rectangle rect1 = new Rectangle
            { Length = 10.0, Width = 20.0 };
            Rectangle rect2 = rect1;
            rect2.Length = 100.0;
            Console.WriteLine("rect1.Length = {0}",rect1.Length);
        }
        static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", r.Length);
        }
        */
            // Rectangle rect = new Rectangle(10, 20);
            //  Console.WriteLine("Width ={ 0}, Length ={ 1}, Area = { 2}",rect.Width, rect.Length, rect.GetArea());
            //}
//{
             //   List<Polygon> polygons = new List<Polygon>();
             //   polygons.Add(new Polygon());
             //   polygons.Add(new Rectangle());
             //   polygons.Add(new Triangle());
              //  foreach (Polygon p in polygons)
               // {
                    //p.Draw();
               // }
           // }
            {
                Rectangle rect1 = new Rectangle
                { Length = 10, Width = 20 };
                Rectangle rect2 = new Rectangle
                { Length = 100, Width = 200 };
                Console.WriteLine(rect1.CompareTo(rect2));
            }
        }
    }
}
    
    