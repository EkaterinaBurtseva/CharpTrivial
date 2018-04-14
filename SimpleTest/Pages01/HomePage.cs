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
        public IWebElement MyAccountButton;

        [FindsBy(How = How.ClassName, Using = "caroufredsel_wrapper")]
        public IWebElement HomepageLogo;

        [FindsBy(How = How.Id, Using = "post-31")]
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
        public void OpenStartPage(string url)
        {
            Browsers.Goto(url);
        }
    }
}
