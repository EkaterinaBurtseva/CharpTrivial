using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask2
{
    class Toyota:Car
    {
        public Toyota(int type) : base(type)
        {
        }

        public void Info()
        {
            var engine_type = "4A-GE";
        }
    }
}
