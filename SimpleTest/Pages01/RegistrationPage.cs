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

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement SuccessMessage;
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement ErrorMessage;



        public bool isRegistrationPageOpened()
        {

        }
        public bool isRegistrationFormDisplyed()
        {

        }
        public bool isUsernameFieldDisplayed()
        {

        }
        public bool isEmailFieldDisplayed()
        {

        }
        public bool isRegisterBtnDisplyed()
        {

        }
       public void fillFormCorrect()
        {

        }
        public void fillFormWrong()
        {

        }
        public void clickRegisterLink()
        {

        }
        public void isRegistrationSuccess()
        {

        }
    }
}
