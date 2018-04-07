using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages01;
using Helpers;

namespace Tests01
{
    [TestFixture]
    class HomeTest : BaseTest
    {

        IWebDriver driver = Browsers.GetDriver;
        string baseUrl = "http://store.demoqa.com";




        [Test]
        public void RegistrationTestStart()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenHomePage(baseUrl);
            Assert.IsTrue(homePage.IsAccountButtonDisplayed(), "Verification Account button is displayed");
            homePage.ClickMyAccountButton();
            Assert.IsTrue(homePage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            homePage.ClickRegistrationLink();
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
        }


    }
}
