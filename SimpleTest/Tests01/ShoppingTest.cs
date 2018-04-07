using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Pages01;
using System;
using System.Threading;
using Helpers;

namespace Tests01
{
    [TestFixture]
    class ShoppingTest : BaseTest
    {
        IWebDriver driver = Browsers.GetDriver;
        [Test]
        public void BuyIpadTest()
        {

            //  Browsers browsers;
            string defaultText = "test";
            string email = "burcevakate@gmail.com";

            ShoppingPage shopPage = new ShoppingPage(driver);

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.Id("menu-item-33"))).Build().Perform();
            shopPage.SelectIpadProduct();
            shopPage.ClickAddtoCart();
            Assert.IsTrue(shopPage.IsCartDisplayed(), "Cart button should be visible");
            shopPage.ClickGoToCart();
            Assert.AreEqual("/products-page/checkout/", new Uri(driver.Url).PathAndQuery, "Verification that user redirected to Step2");
            Assert.IsTrue(shopPage.IsElementDisplayedCart(), "Verification that element in cart");
            shopPage.ClickContinueButton();
            shopPage.FillFormWithData(email, defaultText);
            shopPage.ClickPurchase();
            Assert.IsTrue(shopPage.IsFinalPageDisplayed(), "Success");
        }
        [TearDown]
        public override void EndTest()
        {
            // LoginPageB();
            ShoppingPage shopPage = new ShoppingPage(driver);
            shopPage.ClickGoToCart();
            shopPage.Remove();
            Browsers.Close();
        }


    }
}
