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
using RelevantCodes.ExtentReports;
using static YesTests.BasicReport;

namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL = "https://itera.no";
        public static ExtentReports extent;
        public static ExtentTest test;
        public string testUrl = "reports\\MyOwnReport.html";


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;

            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            var reportPath = projectPath + testUrl;

            extent = new ExtentReports(reportPath, true);
            extent
                .AddSystemInfo("Host Name", "test")
                .AddSystemInfo("Environment", "QA")
                .AddSystemInfo("User Name", "Kate");
            extent.LoadConfig(projectPath + "extent-config.xml");
        }

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
                test.Log(LogStatus.Fail, "Snapshot below: " + test.AddScreenCapture(screenShotPath));
            }


        }


        [OneTimeTearDown]
        public void EndTest()
        {

            Browsers.Close();
            extent.EndTest(test);
            extent.Flush();

        }

    }
}