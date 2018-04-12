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
    class RegistrationTest : BaseTest
    {
        string usernameWrong = "***";
        string emailWrong = "1111";
        string usernameValid = "test";
        string emailValid = "merrychristmas946@gmail.com";


        IWebDriver driver = Browsers.GetDriver;


        [Test]
        public void RegistrationPageTest()
        {

            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.OpenAccountPage();
            Assert.IsTrue(registrationPage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            registrationPage.ClickRegistrationLink();
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
        }

        [Test]
        public void RegistrationWrongTest()
        {

            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.OpenRegistrationPage();
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
            registrationPage.OpenRegistrationPage();
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormCorrect(usernameValid, emailValid);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsSuccessDisplayed(), "Success message should be displayed");

        }
    }
}
