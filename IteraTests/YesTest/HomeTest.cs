using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages;
using RelevantCodes.ExtentReports;
using Settings;



namespace Tests
{

    [TestFixture]
    class HomeTest : BaseTest
    {

        private string homeTitle = "Specialists in creating digital business - Itera";
        private string uaLocationLink = "https://www.itera.no/ua/";

        public HomeTest()
        {

            testUrl = "reports\\HomeTest.html";
        }



        [Test]
        public void HomePageTestStart()
        {

            test = extent.StartTest("Home Page Start test");
            var homePage = new HomePage();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
            test.Log(LogStatus.Pass, "Home page is opened");
            Assert.AreEqual(homeTitle, driver.Title);
            test.Log(LogStatus.Pass, "Title is correct");
            test.Log(LogStatus.Fail, "Title is wrong");


        }

        [Test]
        public void OpenVacanciesPage()
        {
            test = extent.StartTest("Open Vacancies Page test");
            var homePage = new HomePage();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            test.Log(LogStatus.Info, "Click menu button");
            homePage.ClickMenuButton();
            Assert.IsTrue(homePage.IsGamburgerMenuOpened());
            test.Log(LogStatus.Pass, "Gamburger menu is opened");
            test.Log(LogStatus.Info, "Click Itera Link");
            homePage.ClickYouAtIteraLink();
            Assert.IsTrue(homePage.IsGamburgerMenu2Opened());
            test.Log(LogStatus.Pass, "Gamburger menu is opened");
            test.Log(LogStatus.Info, "Click Vacancies Link");
            homePage.ClickVacanciesLink();
            var vacanciesPage = new VacanciesPage();
            Assert.IsTrue(vacanciesPage.IsVacanciesPageDisplayed());
            test.Log(LogStatus.Pass, "Vacancies page is opened");

        }

        [Test]

        public void ChangeLocation()
        {
            test = extent.StartTest("Change Location test");
            var homePage = new HomePage();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            test.Log(LogStatus.Info, "Click location selector");
            homePage.ClickLocationSelector();
            test.Log(LogStatus.Info, "Click Ukraine location");
            homePage.SelectUALOcation();
            Assert.AreEqual(uaLocationLink, driver.Url);
            test.Log(LogStatus.Pass, "Location changed to Ukraine");
        }
    }

}

