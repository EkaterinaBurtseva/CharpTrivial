using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenOverride
{
    class SuzukiSX4:Suzuki
    {

        public sealed override void Drive()
        {

        }

        public override int GetMaxPassangerNumber()
        {
            return 4;
        }

    }
}
