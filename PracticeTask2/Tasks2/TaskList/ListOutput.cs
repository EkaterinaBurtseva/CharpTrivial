using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

/*
 * As input receive an List of objects of class WebElement
 * (which contains string XPath, string Text, string ClassName, string Name) and another parameter string requiredClassName.
 * Return one string with all Text values of controls where ClassName = requiredClassName separated by ','
 */


namespace PracticeTask2.Task1List
{
    public class Solution
    {
        public List<WebElement> generateData()
        {
            return new List<WebElement>
        }

        public string ListOfElementsForeach()
        {
            Console.Write("Enter xpath: ");
            string Xpath = Console.ReadLine();

            Console.Write("Enter text: ");
            string Text = Console.ReadLine();
            Console.Write("Enter Classname: ");
            string ClassName = Console.ReadLine();
            Console.Write("Enter name: ");
            string Name = Console.ReadLine();

            List<string> list = new List<string>()
            {
                Name,
                Xpath,
                Text,
                ClassName
            };

            Console.Write("Enter requiredClassName: ");
            string requiredClassName = Console.ReadLine();
            var finalResult = " ";
            foreach (string i in list)
            {
                if (requiredClassName.Equals(ClassName))
                {
                    var res = ClassName + ", " + Xpath + " ," + Name + ", " + Text;
                    finalResult = res;
                }
                else
                {
                    finalResult = "Required classname isn't equal to className";
                }

            }
            Console.WriteLine(finalResult);
            return finalResult;

        }


        public string ListOfElementsLinq()
        {
            Console.Write("Enter xpath: ");
            string Xpath = Console.ReadLine();

            Console.Write("Enter text: ");
            string Text = Console.ReadLine();
            Console.Write("Enter Classname: ");
            string ClassName = Console.ReadLine();
            Console.Write("Enter name: ");
            string Name = Console.ReadLine();

            List<string> list = new List<string>()
            {
                Name,
                Xpath,
                Text,
                ClassName
            };

            Console.Write("Enter requiredClassName: ");
            string requiredClassName = Console.ReadLine();

            var result = from i in list
                         where requiredClassName.Equals(ClassName)
                         select i;
            var finaresult = "Error";
            foreach (string i2 in result)
            {
                finaresult = i2 + ",";
                Console.Write(finaresult);
            }
            Console.WriteLine(finaresult);
            return finaresult;
        }
    }
}





