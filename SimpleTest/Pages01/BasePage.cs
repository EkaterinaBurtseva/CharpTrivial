using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Pages01
{
    public abstract class BasePage

    {
        private IWebDriver driver;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
