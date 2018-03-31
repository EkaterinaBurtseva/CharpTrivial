using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw02._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter x: ");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter z: ");
            z = Int32.Parse(Console.ReadLine());

            Loc l = new Loc(x, y, z);
            Console.WriteLine("location =x:{0},y:{1},z: {2}", l.x, l.y, l.z);
        }
    }
}
