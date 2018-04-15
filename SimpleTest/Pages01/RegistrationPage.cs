﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;


namespace Pages01
{
    public class RegistrationPage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "p.message.register")]
        private IWebElement RegisterTitle;

        [FindsBy(How = How.LinkText, Using = "Register")]
        public IWebElement RegisterLink;

        [FindsBy(How = How.Id, Using = "registerform")]
        private IWebElement RegisterForm;

        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "wp-submit")]
        private IWebElement RegisterBtn;

        [FindsBy(How = How.CssSelector, Using = "p.message")]
        private IWebElement SuccessMessage;

        [FindsBy(How = How.Id, Using = "login_error")]
        private IWebElement ErrorMessage;


        public bool IsRegistrationLinkDisplayed()
        {
            Boolean isDisplayed = RegisterLink.Displayed;
            return isDisplayed;

        }

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRegistrationLink()
        {
            RegisterLink.Click();
            driver.FindElement(By.CssSelector("p.message.register"), 5);
        }

        public bool IsRegistrationFormDisplyed()
        {
            Boolean isDisplayed = RegisterForm.Displayed;
            return isDisplayed;

        }


        public bool IsRegisterBtnDisplyed()
        {
            return RegisterBtn.Displayed;
        }

        public bool FillFormCorrect(string usernameValid, string emailValid)
        {
            Username.SendKeys(usernameValid);
            Email.SendKeys(emailValid);
            return true;
        }

        public void FillFormWrong(string usernameWrong, string emailWrong)
        {
            Username.SendKeys(usernameWrong);
            Email.SendKeys(emailWrong);

        }

        public void ClickRegisterBtn()
        {
            RegisterBtn.Click();
        }

        public bool IsErrorDisplayed()
        {
            Boolean isDisplayed = ErrorMessage.Displayed;
            return isDisplayed;
        }

        public bool IsSuccessDisplayed()
        {
            driver.FindElement(By.Id("login"), 3);
            Boolean isDisplayed = SuccessMessage.Displayed;
            return isDisplayed;
        }


        public void OpenRegistrationPage(string registrPageUrl)
        {
            driver = Browsers.GetDriver;
            driver.Navigate().GoToUrl(registrPageUrl);
        }
        public string GetTextOfSuccessMessage()
        {
            string actualMessage = SuccessMessage.Text;
            return actualMessage;
        }
    }

}


