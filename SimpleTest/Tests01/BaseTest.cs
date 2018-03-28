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
         

       [Test]
        public void FirstTest()
        {
            BasePage basePage = new BasePage(driver);
            basePage.OpenBasePage();
            Assert.IsTrue(basePage.IsAccountButtonDisplayed(),"Verification Account button is displayed");
            basePage.ClickMyAccountButton();          
            Assert.IsTrue(basePage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            basePage.ClickRegistrationLink();            
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
          
        }

       [Test]
        public void RegistrationWrongTest()
        {
            RegistrationPage registrationPage = new RegistrationPage(driver);
            FirstTest();
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormWrong();
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsErrorDisplayed(),"Error message should be displayed");

        }

        [Test]
        public void RegistrationCorrectTest()
        {
            FirstTest();
            RegistrationPage registrationPage = new RegistrationPage(driver);
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormCorrect();
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsSuccessDisplayed(), "Success message should be displayed");

        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
         }
    }
}
