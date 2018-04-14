using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Pages01;
using System;
using System.Threading;
using Helpers;
using Tests01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;


namespace Tests01
{
    [TestFixture]
   public class ShoppingTest : BaseTest
    {
        
        string defaultText = "test";
        string purchaseUrl = "/products-page/checkout/";


        [Test]
        public void BuyIpadTest()
        {            
            LoginPageB loginPage = new LoginPageB(driver);
            loginPage.OpenLoginPage(loginPageUrl);
            loginPage.FillLoginForm(email, password);
            loginPage.ClickLoginButton();

            ShoppingPage shopPage = new ShoppingPage(driver);
            shopPage.HoverProductCategory();          
            shopPage.SelectIpadProduct();
            string ActualTitle = shopPage.GetTitleOfProduct();
            string ActualPrice = shopPage.GetPriceOfProduct();
            shopPage.ClickAddtoCart();
            Assert.IsTrue(shopPage.IsCartDisplayed(), "Cart button should be visible");
            shopPage.ClickGoToCart();
            Assert.AreEqual(purchaseUrl, new Uri(driver.Url).PathAndQuery, "Verification that user redirected to Step2");
            Assert.IsTrue(shopPage.IsElementDisplayedCart(), "Verification that element in cart");
            string ActualTitleStep2 = shopPage.GetTitleProductStep2();
            Assert.AreEqual(ActualTitle, ActualTitleStep2);
            string ActualPriceStep2 = shopPage.GetPriceProductStep2();
            Assert.AreEqual(ActualPrice, ActualPriceStep2);
            shopPage.ClickContinueButton();
            shopPage.FillFormWithData(email, defaultText);
            shopPage.ClickPurchase();
            Assert.IsTrue(shopPage.IsFinalPageDisplayed(), "Success");
        }
        // [TearDown]
        //  public override void EndTest()
        // {
        // LoginPageB();
        // ShoppingPage shopPage = new ShoppingPage(driver);
        //  shopPage.ClickGoToCart();
        //  shopPage.Remove();
        // Browsers.Close();
        //  }


    }
}
