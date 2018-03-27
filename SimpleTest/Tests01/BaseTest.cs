using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages01;
using NUnit.Compatibility;



namespace Tests01
{
       [TestFixture]
      public  class BaseTest
       {
       private  IWebDriver driver;

        

        [SetUp]
       public void SetUp()
       {
          driver = new ChromeDriver();
            
       }
         

       // [Test]
        public void FirstTest()
        {
            BasePage basePage = new BasePage(driver);
            basePage.OpenBasePage();            
            basePage.ClickMyAccountButton();
           // Assert.assertTrue(basePage.isRegistrationLinkDisplayed);
           // RegistrationPage registrationPage = new RegistrationPage(driver);
            basePage.ClickRegistrationLink();            
                Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
        }

       [Test]
        public void RegistrationWrongTest()
        {
            RegistrationPage registrationPage = new RegistrationPage(driver);
            FirstTest();
            registrationPage.FillFormWrong();
            registrationPage.ClickRegisterBtn();
           Assert.IsTrue(registrationPage.isErrorDisplayed(),"Error message should be displayed");

        }

        [Test]
        public void RegistrationCorrectTest()
        {
            FirstTest();
            RegistrationPage registrationPage = new RegistrationPage(driver);
            registrationPage.FillFormCorrect();
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.isSuccessDisplayed(), "Success message should be displayed");

        }
         [TearDown]
        public void EndTest()
        {
            driver.Close();
         }
    }
}
