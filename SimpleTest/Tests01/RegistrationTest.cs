using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pages01;

namespace Tests01
{
    class RegistrationTest : BaseTest
    {
        string usernameWrong = "***";
        string emailWrong = "1111";
        string usernameValid = "test";
        string emailValid = "merrychristmas946@gmail.com";

        [Test]
        public void RegistrationWrongTest()
        {
            RegistrationPage registrationPage = new RegistrationPage();
            FirstTest();
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormWrong(usernameWrong, emailWrong);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsErrorDisplayed(), "Error message should be displayed");
        }

        [Test]
        public void RegistrationCorrectTest()
        {
            FirstTest();
            RegistrationPage registrationPage = new RegistrationPage();
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormCorrect(usernameValid, emailValid);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsSuccessDisplayed(), "Success message should be displayed");

        }
    }
}
