using System;
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

        [FindsBy(How = How.ClassName, Using = "caroufredsel_wrapper")]
        private IWebElement HomepageLogo;

        [FindsBy(How = How.Id, Using = "post-31")]
        private IWebElement AccountLogo;

        public HomePage() : base()
        {

        }
        public bool IsHomePageOpened()
        {
            var isDiplayed = HomepageLogo.Displayed;
            return isDiplayed;
        }
        public void ClickMyAccountButton()
        {
            MyAccountButton.Click();

        }

        public bool IsAccountButtonDisplayed()
        {
            var isDisplayed = MyAccountButton.Displayed;
            return isDisplayed;

        }

        public bool IsAccountPageDisplayed()
        {
            var isDisplayed = AccountLogo.Displayed;
            return isDisplayed;
        }
        public void OpenStartPage(string url)
        {
            Browsers.Goto(url);
        }
    }
}
