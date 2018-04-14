﻿using System;
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
using Tests01;


namespace Tests01
{
    [TestFixture]
    class RegistrationTest : BaseTest
    {
        string usernameWrong = "***";
        string emailWrong = "1111";
        string usernameValid = "testdd25ds";
        string emailValid = "merrychristmas946@gmail.com";
        string urlRegistration = "/wp-login.php?action=register";


        [Test]
        public void RegistrationPageTest()
        {            
            LoginPageB loginPageB = new LoginPageB(driver);
            loginPageB.OpenLoginPage(loginPageUrl);
            RegistrationPage registrationPage = new RegistrationPage(driver);
            Assert.IsTrue(registrationPage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            registrationPage.ClickRegistrationLink();            
            Assert.AreEqual(urlRegistration, new Uri(driver.Url).PathAndQuery);
        }

        [Test]
        public void RegistrationWrongTest()
        {           
            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.OpenRegistrationPage(registrPageUrl);
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormWrong(usernameWrong, emailWrong);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsErrorDisplayed(), "Error message should be displayed");
        }

        [Test]
        public void RegistrationCorrectTest()
        {            
            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.OpenRegistrationPage(registrPageUrl);
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormCorrect(usernameValid, emailValid);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsSuccessDisplayed(), "Success message should be displayed");
            
        }
    }
}
