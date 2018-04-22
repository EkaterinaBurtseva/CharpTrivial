using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Settings;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL= "https://www.itera.no/";
      

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