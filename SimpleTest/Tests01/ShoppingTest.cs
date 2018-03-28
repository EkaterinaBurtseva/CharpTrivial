using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Pages01;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace Tests01
{
    class ShoppingTest
    {
        private IWebDriver driver;


        [SetUp]
       public void SetUp()
        {
           driver = new ChromeDriver();
           
        }

       
        public void StartTest()
        {
            BasePage basePage = new BasePage(driver);
            basePage.OpenBasePage();
            basePage.ClickMyAccountButton();
        }

        [Test]
        public void LoginPageB()
        {
            StartTest();
            LoginPageB loginPage = new LoginPageB(driver);
            Assert.IsTrue(loginPage.IsLoginFormDisplayed(),"Verification that Login form is displayed");
            Assert.IsTrue(loginPage.IsLoginButtonisplayed(), "Verification that Login form is displayed");
            loginPage.FillLoginForm();
            loginPage.ClickLoginButton();         
            Assert.AreEqual("/products-page/your-account/", new Uri(driver.Url).PathAndQuery,"Verification that user is logged");
            //is it ok to use such type of wait here?
            Thread.Sleep(5000);
        }

        [Test]
        public void BuyIpadTest()
        {
            LoginPageB();                     
            ShoppingPage shopPage = new ShoppingPage(driver);
            //is it posibly to use HoverOver inside method?
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.Id("menu-item-33"))).Build().Perform();
            shopPage.SelectIpadProduct();           
            shopPage.ClcikAddtoCart();           
            Assert.IsTrue(shopPage.IsCartDisplayed(), "Cart button should be visible");
            shopPage.ClickGoToCart();
            Assert.AreEqual("/products-page/checkout/", new Uri(driver.Url).PathAndQuery, "Verification that user redirected to Step2");
            Assert.IsTrue(shopPage.IsElementDisplayedCart(), "Verification that element in cart");
            shopPage.ClickContinueButton();
            shopPage.FillFormWithData();
            shopPage.ClickPurchase();
            Assert.IsTrue(shopPage.IsFinalPageDisplayed(), "Success");
        }
        [TearDown]
        public void ClearingTest()
        {
            LoginPageB();
            ShoppingPage shopPage = new ShoppingPage(driver);
            shopPage.ClickGoToCart();
            shopPage.Remove();
        }


    }
}
