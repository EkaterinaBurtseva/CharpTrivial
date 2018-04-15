using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
/*
 * As input receive an List of objects of class WebElement (which contains
 * string XPath, string Text, string ClassName, string Name) and another parameter 
 * string requiredClassName. Return one string with all Text values of controls where 
 * ClassName = requiredClassName separated by ','
 */
namespace PracticeTask2
{
    class New
    {
        private IWebDriver driver;

        public string Test(List<IWebElement> iList, string requiredClassName)
        {
            List<IWebElement> elements = new List<IWebElement>();
            List<string> eleL = new List<string>();
            foreach (IWebElement element in elements)
            {
                eleL.Add(element.ToString());
            }
            eleL.Add("Xpath");
            eleL.Add("Text");
            eleL.Add("ClassName");

            if (requiredClassName == ) { }
            return eleL.ToString();
        }




    }
}
