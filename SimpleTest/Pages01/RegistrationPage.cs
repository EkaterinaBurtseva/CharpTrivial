using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages01
{
    class RegistrationPage 
    {
        [FindsBy(How = How.CssSelector, Using = "p.message")]
        private IWebElement RegisterTitle;

        [FindsBy(How = How.Id, Using = "registerform")]
        private IWebElement RegisterForm;

        [FindsBy(How = How.Id, Using = "user_login")]
        private IWebElement Username;

        [FindsBy(How = How.LinkText, Using = "user_email")]
        private IWebElement Email;

        [FindsBy(How = How.LinkText, Using = "wp-submit")]
        private IWebElement RegisterBtn;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement SuccessMessage;

        [FindsBy(How = How.Id, Using = "login_error")]
        private IWebElement ErrorMessage;
        
        String usernameWrong = "***";
        String emailWrong = "1111";
        String usernameValid = "test";
        String emailValid = "merrychristmas946@gmail.com";

        public bool isRegistrationPageOpened(IWebElement RegisterTitle)
        {
            return RegisterTitle.Displayed;
        }

        public bool isRegistrationFormDisplyed(IWebElement RegisterForm)
        {
            return RegisterForm.Displayed;
        }

        public bool isUsernameFieldDisplayed(IWebElement Username)
        {
            return Username.Displayed;
        }

        public bool isEmailFieldDisplayed(IWebElement Email)
        {
            return Email.Displayed;
        }

        public bool isRegisterBtnDisplyed(IWebElement RegisterBtn)
        {
            return RegisterBtn.Displayed;
        }

       public void fillFormCorrect()
        {
            Username.SendKeys(usernameValid);
            Email.SendKeys(emailValid);
        }

        public void fillFormWrong()
        {
            Username.SendKeys(usernameWrong);
            Email.SendKeys(emailWrong);
        }

        public void clickRegisterBtn()
        {
            RegisterBtn.Click();
        }

        public bool isErrorDisplayed(IWebElement ErrorMessage)
        {
              return ErrorMessage.Displayed;
         }

        public bool isSuccessDisplayed(IWebElement SuccessMessage )
        {
            return SuccessMessage.Displayed;
        }
    }
    }

