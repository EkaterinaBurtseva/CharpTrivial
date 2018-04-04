using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Pages01;
using System;
using System.Threading;

namespace Tests01
{
    //[TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    // [TestFixture(typeof(EdgeDriver))]
    class ShoppingTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            this.driver = new TWebDriver();

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
            Assert.IsTrue(loginPage.IsLoginFormDisplayed(), "Verification that Login form is displayed");
            Assert.IsTrue(loginPage.IsLoginButtonisplayed(), "Verification that Login form is displayed");
            loginPage.FillLoginForm();
            loginPage.ClickLoginButton();
            Assert.AreEqual("/products-page/your-account/", new Uri(driver.Url).PathAndQuery, "Verification that user is logged");
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
