using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInterfaces
{
    interface IFigureBase
    {
        string Name
        {
            get;
            set;
        }
        int VerticesCount
        {
            get;
            set;
        }
        string GetFigureName();
        int GetVerticesCount();
      
    }
}
