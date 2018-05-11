using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Page;
using RelevantCodes.ExtentReports;

namespace Tests
{
    [TestFixture]
    public class HomeTest : BaseTest
    {
        private string title = "Google";
        private string expectedUrl = "https://www.seleniumhq.org/";

        [Test]
        public void HomePageGoogleStart()
        {
            test = extent.StartTest("Home Page Start test");
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
            test.Log(LogStatus.Pass, "Home page is opened");
            Assert.AreEqual(title, driver.Title);
            test.Log(LogStatus.Pass, "Title is correct");

        }

        [Test]
        public void SearchTest()
        {
            test = extent.StartTest("Search for selenium");
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            test.Log(LogStatus.Info, "Searching for selenium");
            homePage.SearchForItem("selenium");
            var firstUrl = homePage.GetFirstUrl();
            Assert.AreEqual(firstUrl, expectedUrl);
            test.Log(LogStatus.Pass, "First url is " + expectedUrl);
            Assert.IsTrue(homePage.IsWikipediaUrlDisplayed());
            test.Log(LogStatus.Pass, "Wikipedia url is displayed on the page");
            Assert.IsTrue(homePage.IsHabrahabrUrlDisplayed());
            test.Log(LogStatus.Pass, "Habrahabr url is displayed on the page");
            Assert.IsTrue(homePage.IsFeaturedSnippetDisplayed());
            test.Log(LogStatus.Pass, "Featured snippet is displayed on the page");

        }
    }
}
