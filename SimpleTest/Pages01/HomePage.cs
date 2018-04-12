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
        //TODO: add elements for account page and homepage to check if the page opened

        // driver = Browsers.GetDriver;

        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private IWebElement MyAccountButton;

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement HomepageLogo;

        [FindsBy(How = How.Id, Using = "logo")]
        private IWebElement Logo;

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement AccountLogo;

        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        public bool IsHomePageOpened()
        {
            Boolean isDiplayed = HomepageLogo.Displayed;
            return isDiplayed;
        }
        public void ClickMyAccountButton()
        {
            MyAccountButton.Click();

        }

        public bool IsAccountButtonDisplayed()
        {
            Boolean isDisplayed = MyAccountButton.Displayed;
            return isDisplayed;

        }

        public bool IsAccountPageDisplayed()
        {
            Boolean isDisplayed = AccountLogo.Displayed;
            return isDisplayed;
        }
    }
}
