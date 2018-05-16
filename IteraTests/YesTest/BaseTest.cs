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
        //protected ExtentReports extent;
        protected ExtentTest test;

        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
            BasicReport.StartReport();
            
        }

        [SetUp]//check if it works
        public void StartTest()
        {
            //extent = new ExtentReports("dsfsdfsd", true);
            test = extent.StartTest("test1"); // get test name
           

            homePage = new HomePage();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
        }

        [TearDown]
        public void GetResultBase()
        {
           BasicReport.GetResult(test);
        }


        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
            BasicReport.EndReport();

        }

    }
}