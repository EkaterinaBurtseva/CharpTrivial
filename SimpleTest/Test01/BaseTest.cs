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
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Pages;
using Simple.Selenium.Pages;

namespace Dependencies

{
    [TestFixture]
    public class BaseTest 
        {
        private IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        
        [Test]
        public void FirstTest() {
            BasePage basePage = new Pages.BasePage(driver);
     
          
           
        }

       
       
    }
}
