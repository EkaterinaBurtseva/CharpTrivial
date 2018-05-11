using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * As input receive an List of objects of class WebElement
 * (which contains string XPath, string Text, string ClassName, string Name) and another parameter string requiredClassName.
 * Return one string with all Text values of controls where ClassName = requiredClassName separated by ','
 */
namespace PracticeTask2.Task1List
{
    public class WebElement
    {
        public string Xpath = "xp";
        public string Text = "tx";
        public string ClassName = "cn";
        public string Name = "nm";
    }
}
