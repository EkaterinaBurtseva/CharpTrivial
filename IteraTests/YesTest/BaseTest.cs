using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using System.Collections.Specialized;
using Settings;
using NUnit.Framework;
using System.Security.Policy;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL = "https://itera.no";


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
        }


        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

    }
}