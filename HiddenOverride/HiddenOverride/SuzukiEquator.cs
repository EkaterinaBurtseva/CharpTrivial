using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenOverride
{
    class SuzukiEquator:Suzuki
    {
        public string nameNew = "SuzukiEquator";
        public override string Name
        {
            get { return nameNew; }
            set { nameNew = value; }
        }
        public new int GetMaxPassangerNumber()
        {
            return 0;

        }
    }
}
