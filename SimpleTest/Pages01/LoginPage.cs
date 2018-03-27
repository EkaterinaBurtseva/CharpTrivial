﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages01
{
    public class LoginPageB : BasePage
    {
        public LoginPageB(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "h1.entry-title")]
        private IWebElement LoginPageTitle;

        [FindsBy(How = How.Id, Using = "log")]
        private IWebElement UserNameLogin;

        [FindsBy(How = How.Id, Using = "pwd")]
        private IWebElement PasswordLogin;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement LoginBtn;

        [FindsBy(How = How.Id, Using = "login_wrapper")]
        private IWebElement LoginForm;

       public String email = "burcevakate@gmail.com";
        String password = "O1gFNagT@)3&(*KY";

        public bool isLoginPageOpened(IWebElement LoginPageTitle)
        {
            return LoginPageTitle.Displayed;
        }

        public bool isLoginFormDisplayed(IWebElement LoginForm)
        {
            return LoginForm.Displayed;
        }

        public void fillLoginForm()
        {
            UserNameLogin.SendKeys(email);
            PasswordLogin.SendKeys(password);
        }

        public void clickLoginButton()
        {
            LoginBtn.Click();
        }

    }
}
