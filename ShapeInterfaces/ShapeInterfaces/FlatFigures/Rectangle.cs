using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    public class Rectangle : FlatFigures.Quadrilatel
    {
        private string name = "Rectangle";
        

        public Rectangle(double SideA, double SideB) : base(SideA, SideB)
        {
           
        }
        public Rectangle(string Name) : base(Name)           
        {
           Name = name;
        }

        public Rectangle() : base()
        {

        }

        public Rectangle(double sideA)
        {
            this.SideA = sideA;
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
           

        public override string GetFigureName()
        {
           return Name;
        }
        public override int GetVerticesCount()
        {
            return VerticesCount;
        }

    }
}
