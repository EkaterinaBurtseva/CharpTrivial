using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace Pages01
{

<<<<<<< HEAD
   abstract public class BasePage
=======
    public class BasePage
>>>>>>> 6720739f051318205e0b2f05d1030bfe884b0cfc
    {
        private IWebDriver driver;

        public String BaseUrl = "http://store.demoqa.com";

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       

<<<<<<< HEAD
=======
        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private IWebElement MyAccountButton;

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement RegisterLink;

        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement Logo;


        public void OpenBasePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
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



>>>>>>> 6720739f051318205e0b2f05d1030bfe884b0cfc
    }
}
