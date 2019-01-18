using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeInterfaces
{
   public  class Cube: Parallelepiped
    {
        private string name ="Cube";

        public Cube(double parallelepipedSideA) : base(parallelepipedSideA,parallelepipedSideA, parallelepipedSideA)
        {
        }
      
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }                     
        

        public override double GetArea()
        {
            double a = 6 *Math.Pow(ParallelepipedSideA, 2);           
            return a;

        }

        public override double GetVolume()
        {
            double v =Math.Pow(ParallelepipedSideA,3);            
            return v;

        }
        public override string GetFigureName()
        {               
            return Name;
        }

       
    }
}
