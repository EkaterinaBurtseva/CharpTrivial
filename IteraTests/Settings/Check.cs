﻿using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
   public static class Check
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        private static IWebDriver driver;

        public static void Equals(string expectedResult, string actualResult, bool fail, string message)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            try
            {
                Assert.AreEqual(expectedResult, actualResult);
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
