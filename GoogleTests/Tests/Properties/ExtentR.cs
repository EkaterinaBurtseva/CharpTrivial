using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace Properties
{
    public class ExtentR
    {
        public string testUrl = "reports\\GoogleTestsReport.html";
        public static ExtentReports extent;
        public static ExtentTest test;
        protected IWebDriver driver;

        public void StartTest()
        {
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
