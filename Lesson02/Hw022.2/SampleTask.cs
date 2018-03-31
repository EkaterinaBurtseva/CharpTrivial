using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw022._2 { 

    public delegate void SampleDelegate();
   public interface ISampleEvents
   {
    event SampleDelegate SampleEvent;
    void Invoke();
   }

   public  class SampleTask:ISampleEvents
    {

        public event SampleDelegate SampleEvent; // declare event

        public void Invoke()
        {
            if (SampleEvent != null) // check if handlers attached
                SampleEvent(); // raise event (i.e. invoke event delegate)
        }
    }
}

