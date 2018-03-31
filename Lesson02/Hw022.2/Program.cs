using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw022._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISampleEvents se = new SampleTask();
            se.SampleEvent += new SampleDelegate(TestHandler);
            se.Invoke();
        }
        static private void TestHandler()
        {
            Console.WriteLine("TestHandler is called");
        }
    }
}
