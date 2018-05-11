using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    [TestFixture]
    public class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
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


        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
