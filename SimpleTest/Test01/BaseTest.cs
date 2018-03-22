using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Dependencies
    
{
    public class BaseTest
        {

        [ClassInitialize]
        public static void Init()
        {
            IWebDriver driver = new ChromeDriver();
                     
                driver.Navigate().GoToUrl("http://store.demoqa.com");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Url = "http://store.demoqa.com";
               // IWebElement myDynamicElement = driver.FindElement(By.Id("someDynamicElement"));
            
           
        }

        [ClassCleanup]
        public static void Close()
        {
            Driver.Close();
        }

        [TestInitialize]
        public void Open()
        {
            Driver.DriverInstance.Navigate().GoToUrl("http://store.demoqa.com");
                }

        [TestCleanup]
        public void CleanUp()
        {

            Driver.DriverInstance.Manage().Cookies.DeleteAllCookies();
        }
    }
}
