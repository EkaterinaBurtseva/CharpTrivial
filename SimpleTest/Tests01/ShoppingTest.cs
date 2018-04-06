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
    class ShoppingTest<TWebDriver> : BaseTest where TWebDriver : IWebDriver, new()


        public void StartTest()
    {
        basePage = new HomePage(driver);
        basePage.OpenBasePage();
        basePage.ClickMyAccountButton();
    }



    [Test]
    public void BuyIpadTest()
    {
        LoginPageB();
        ShoppingPage shopPage = new ShoppingPage(driver);

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
