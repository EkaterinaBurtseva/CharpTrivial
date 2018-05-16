using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Page;
using Properties;
using RelevantCodes.ExtentReports;
using static Properties.ExtentR;


namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL = "https://google.com";
       


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
            ExtentR.StartTest();

            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
        }

        [TearDown]
        public void GetResulta()
        {
            ExtentR.GetResult();
        }


        [OneTimeTearDown]
        public void EndTest()
        {

            Browsers.Close();
            ExtentR.EndTest();


        }

    }
}

