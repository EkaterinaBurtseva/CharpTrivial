using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Parallelepiped : IThreeDimensionalFigure
    {
        private string name = "Parallelepiped";
        private int count =8;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double ParallelepipedSideA { get; set; }
        public double ParallelepipedSideB { get; set; }
        public double ParallelepipedSideC { get; set; }
        public int VerticesCount
        {
            get { return count; }
            set { count = value; }
        }

        public Parallelepiped(double parallelepipedSideA, double parallelepipedSideB, double parallelepipedSideC)
        {
            this.ParallelepipedSideA = parallelepipedSideA;
            this.ParallelepipedSideB = parallelepipedSideB;
            this.ParallelepipedSideC = parallelepipedSideC;
        }
        public Parallelepiped(double parallelepipedSideA)
        {
            this.ParallelepipedSideA = parallelepipedSideA;            
        }

        public Parallelepiped()
        {
          
        }
        
        public virtual double GetArea()
        {
            double a = 2 * (ParallelepipedSideA * ParallelepipedSideB + ParallelepipedSideB * ParallelepipedSideC + ParallelepipedSideC * ParallelepipedSideA);
            Console.WriteLine("Parallelepiped area is " + a);
            return a;

        }

        public virtual double GetVolume()
        {
            double v =  ParallelepipedSideA *ParallelepipedSideB*ParallelepipedSideC;
            Console.WriteLine("Parallelepiped volume is " + v);
            return v;

        }
        public virtual string GetFigureName()
        {  
            return Name;
        }

        public int GetVerticesCount()
        {
            return VerticesCount;
        }
    }
}
