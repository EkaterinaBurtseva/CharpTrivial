using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages01
{
    
    public class BasePage
    {
        // private IWebDriver driver;
        private IWebDriver driver;
        String BaseUrl = "http://store.demoqa.com";
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private  IWebElement MyAccountButton;
        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement RegisterLink;

        public void openBasePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }
        public  void clickMyAccountButton()
        {
            MyAccountButton.Click();
           
        }

        public  void clickRegistrationLink()
        {
            RegisterLink.Click();
           
        }

    }
}
