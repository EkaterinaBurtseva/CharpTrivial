using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Settings
{
   
    public class BasicReport
    {
        public static ExtentReports extent;
        //public static ExtentTest test;
        public static IWebDriver driver;



        public static void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string testUrl = "reports\\MyOwnReport.html";
            var reportPath = projectPath + testUrl;

            extent = new ExtentReports(reportPath, true);
            extent
            .AddSystemInfo("Host Name", "test")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Kate");
            extent.LoadConfig(projectPath + "extent-config.xml");
        }



        public static void GetResult(ExtentTest test)
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


        public  static void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
