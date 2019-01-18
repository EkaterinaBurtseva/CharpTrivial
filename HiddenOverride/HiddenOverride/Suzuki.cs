using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenOverride
{
    class Suzuki : ICar
    {
        public string name = "Suzuki";

        public int Speed { get; set ; }
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void CarryBaggage()
        {
          
        }

        public virtual void Drive()
        {
           
        }

        public virtual int GetMaxPassangerNumber()
        {
            return 2;
        }

        public int GetMaxSpeed()
        {
            return 0;
        }

        public void OpenDoor()
        {
            
        }
    }
}
