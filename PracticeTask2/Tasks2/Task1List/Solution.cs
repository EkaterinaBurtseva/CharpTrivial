using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace PracticeTask2.Task1List
{
    public class Solution : WebElement
    {

        public string ListOfElements(List<WebElement> elements, string requiredClassName)
        {
            string error = "Error";
            string res;
            if (requiredClassName.Equals(ClassName))
            {
                res = ClassName + ", " + Xpath + " ," + Name + ", " + Text;
                Console.WriteLine(res);
                return res;
            }
            Console.WriteLine(error);
            return error;
        }
    }
}




