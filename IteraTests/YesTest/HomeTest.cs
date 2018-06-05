﻿using System;
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
using static Settings.BasicReport;


namespace Tests
{

    [TestFixture]
    class HomeTest : BaseTest
    {
        private string homeTitle = "SpecialisFts in creating digital business - Itera";
        private string uaLocationLink = "https://itera.no/ua/";

      

        [Test]
        public void HomePageTestStart()
        {
            Assert.AreEqual(homeTitle, driver.Title);
            test.Log(LogStatus.Pass, "Title is correct");
        }

        [Test]
        public void OpenVacanciesPage()
        {
            
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
            test.Log(LogStatus.Info, "Click location selector");
            homePage.ClickLocationSelector();
            test.Log(LogStatus.Info, "Click Ukraine location");
            homePage.SelectUALOcation();
            Assert.AreEqual(uaLocationLink, driver.Url);
            test.Log(LogStatus.Pass, "Location changed to Ukraine");
        }
    }

}

