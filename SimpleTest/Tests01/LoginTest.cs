using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pages01;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Tests01
{
    class LoginTest
    {
        [Test]
        public void LoginTest()
        {
            StartTest();
            LoginPageB loginPage = new LoginPageB(driver);
            Assert.IsTrue(loginPage.IsLoginFormDisplayed(), "Verification that Login form is displayed");
            Assert.IsTrue(loginPage.IsLoginButtonisplayed(), "Verification that Login form is displayed");
            loginPage.FillLoginForm();
            loginPage.ClickLoginButton();
            Assert.AreEqual("/products-page/your-account/", new Uri(driver.Url).PathAndQuery, "Verification that user is logged");
            //is it ok to use such type of wait here?
            Thread.Sleep(5000);
        }
    }
}
