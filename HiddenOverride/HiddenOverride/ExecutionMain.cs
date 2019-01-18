using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenOverride
{
    class ExecutionMain
    {
        static void Main(string[] args)
        {
            Suzuki suzuki = new Suzuki();
            SuzukiSX4 sx4 = suzuki as SuzukiSX4;

            if(sx4 is Suzuki)
            {
               
            }
        }
    }
}
