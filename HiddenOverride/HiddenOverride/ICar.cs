using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenOverride
{
    interface ICar
    {

        int Speed { get; set; }
        void Drive();
        void OpenDoor();
        string Name { get; set; }

        int GetMaxSpeed();

        void CarryBaggage();
    }
}
