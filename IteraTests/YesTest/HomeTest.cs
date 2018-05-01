using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages;
using Settings;

namespace Tests01
{
    [TestFixture]
    class HomeTest : BaseTest
    {
        private string homeTitle = "Specialists in creating digital business - Itera";

        [Test]
        public void HomePageTestStart()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
            Assert.AreEqual(homeTitle, driver.Title);

        }

        [Test]
        public void OpenVacanciesPage()
        {
            var homePage = new HomePage();
            homePage.ClickMenuButton();
            Assert.IsTrue(homePage.IsGamburgerMenuOpened());
            homePage.ClickYouAtIteraLink();
            Assert.IsTrue(homePage.IsGamburgerMenu2Opened());
            homePage.ClickVacanciesLink();
            var vacanciesPage = new VacanciesPage();
            Assert.IsTrue(vacanciesPage.IsVacanciesPageDisplayed());

        }


    }
}
