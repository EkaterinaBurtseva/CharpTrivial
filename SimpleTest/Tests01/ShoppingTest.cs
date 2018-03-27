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
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            ShoppingPage shopPage = new ShoppingPage(driver);
            shopPage.SelectIpadProduct();
            shopPage.clcikAddtoCart();
            shopPage.clickContinueBtn();
            shopPage.fillFormWithData();
            shopPage.clickPurchase();
        }



    }
}
