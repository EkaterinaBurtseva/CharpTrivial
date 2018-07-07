using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task1_methods
{
    public class Main1
    {
        static void Main(string[] args)
        {
            Features features = new Features();
            features.ReadValueByXpath();
            Console.ReadLine();
        }

    }
}

