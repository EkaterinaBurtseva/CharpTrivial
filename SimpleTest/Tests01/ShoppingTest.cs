using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages01;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests01
{
    class ShoppingTest
    {
        private IWebDriver driver;


        [FindsBy(How = How.Id, Using = "menu-item-33")]
        public IWebElement ProductCategory;

        [SetUp]
       public void SetUp()
        {
           driver = new ChromeDriver();
           
        }

       
        public void startTest()
        {
            BasePage basePage = new BasePage(driver);
            basePage.OpenBasePage();
            basePage.ClickMyAccountButton();
        }

        [Test]
        public void loginPageB()
        {
            startTest();
            LoginPageB loginPage = new LoginPageB(driver);
            
            loginPage.fillLoginForm();
            loginPage.clickLoginButton();
        }
        [Test]
        public void buyIpadTest()
        {
            loginPageB();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            ShoppingPage shopPage = new ShoppingPage(driver);
            Actions action = new Actions(driver);
            action.MoveToElement(ProductCategory).Perform();
            shopPage.SelectIpadProduct();
            shopPage.clcikAddtoCart();
            shopPage.clickContinueBtn();
            shopPage.fillFormWithData();
            shopPage.clickPurchase();
        }



    }
}
