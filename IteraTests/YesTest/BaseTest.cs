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
using NUnit.Framework.Interfaces;
using Pages;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow.BindingSkeletons;
using static Settings.BasicReport;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL = "https://itera.no";
        protected HomePage homePage;
        protected ExtentTest test;
        protected ThreadLocal<ExtentTest> _test;

        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
            BasicReport.StartTest();
            _test = new ThreadLocal<ExtentTest>();
        }
        [SetUp]
        public void Initialize()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name);
            _test.Value = test;
            var homePage = new HomePage();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
            test.Log(LogStatus.Pass, "Home page is opened");

        }

        //[TearDown]
        // public void GetResulta()
        // {
        //     ExtentR.GetResult();
        //}


        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
            BasicReport.EndTest();

        }

    }
}
