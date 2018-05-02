using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Properties
{
    public static class HoverOver
    {
        public static void HoverOvers(this IWebDriver driver, IWebElement elementToHover)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Perform();

        }
    }
}
