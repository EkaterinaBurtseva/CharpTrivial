using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace PracticeTask2.Task1List
{
    class Solution:WebElement
    {
        public string ListOfElements(List<WebElement>elements, string requiredClassName)
        {
            string res = "error";
            if(requiredClassName.Equals(ClassName))
            {
                res = ClassName + ", " + Xpath + " ," + Name + ", " + "Text";
                return res;
            }
            return res;
            Console.WriteLine(res);
        }
    }
}
