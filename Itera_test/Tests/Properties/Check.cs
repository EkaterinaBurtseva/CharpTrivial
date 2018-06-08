using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using static Properties.ExtentR;

namespace Properties
{
    public static class Check
    {
       // public static ExtentReports extent;
       // public static ExtentTest test;
        private static IWebDriver driver;

        public static void Equals(string expectedResult, string actualResult, bool fail = false, string message = "")
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            //var errorMessage = TestContext.CurrentContext.Result.Message;

            try
            {
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
               // string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                
               // test.Log(LogStatus.Fail, "Snapshot below: " + test.AddScreenCapture(screenShotPath));

                if (fail)
                {
                    test.Log(LogStatus.Fatal, stackTrace + message);
                    Assert.Fail(message);
                }
                else
                    test.Log(LogStatus.Fail, stackTrace + message);
            }

        }

        public static void isTrue(bool expectedResult, bool fail, string message)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            try
            {
                Assert.IsTrue(expectedResult);
            }
            catch (Exception ex)
            {
                string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
                test.Log(LogStatus.Fail, "Snapshot below: " + test.AddScreenCapture(screenShotPath));

                if (fail)
                {
                    Assert.Fail(message);
                }
            }

        }
    }
}
