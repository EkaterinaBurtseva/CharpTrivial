using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    class Basepage : Dependencies.BaseTest
    {
        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private IWebElement MyAccountButton;
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement RegisterLink;
        public static void isAccountButtonDisplayed()
        {

        }
        public static void isRegisterLinkDisplayed()
        {

        }
        public static void clickMyAccountButton()
        {
            MyAccountButton.Click();
        }

        public static void clickRegistrationLink()
        {

        }
    }
}
