﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Helpers;

namespace Pages01
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private IWebElement MyAccountButton;

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement RegisterLink;

        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement Logo;

        public HomePage(IWebDriver driver) : base(driver)
        {

        }


        public void OpenHomePage(string baseUrl)
        {
            Browsers.Goto(baseUrl);
        }

        public void ClickMyAccountButton()
        {
            MyAccountButton.Click();

        }


        public void ClickRegistrationLink()
        {
            RegisterLink.Click();

        }

        public bool IsRegistrationLinkDisplayed()
        {
            Boolean isDisplayed = RegisterLink.Displayed;
            return isDisplayed;

        }

        public bool IsAccountButtonDisplayed()
        {
            Boolean isDisplayed = MyAccountButton.Displayed;
            return isDisplayed;

        }
    }
}
