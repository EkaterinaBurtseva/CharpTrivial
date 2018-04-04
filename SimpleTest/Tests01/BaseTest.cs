using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
<<<<<<< HEAD
=======
using OpenQA.Selenium.IE;
>>>>>>> 6720739f051318205e0b2f05d1030bfe884b0cfc
using Pages01;
using System;



namespace Tests01
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
<<<<<<< HEAD


  abstract  public  class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
=======
    [TestFixture(typeof(InternetExplorerDriver))]
    public class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
>>>>>>> 6720739f051318205e0b2f05d1030bfe884b0cfc
    {
        private IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            this.driver = new TWebDriver();
        }

        [Test]
        public void FirstTest()
        {
<<<<<<< HEAD
            HomePage homePage = new Pages01.HomePage(driver);
            homePage.OpenBasePage();
            Assert.IsTrue(homePage.IsAccountButtonDisplayed(),"Verification Account button is displayed");
            homePage.ClickMyAccountButton();          
            Assert.IsTrue(homePage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            homePage.ClickRegistrationLink();            
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
          
        }                
=======
            BasePage basePage = new BasePage(driver);
            basePage.OpenBasePage();
            Assert.IsTrue(basePage.IsAccountButtonDisplayed(), "Verification Account button is displayed");
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
            Assert.IsTrue(registrationPage.IsErrorDisplayed(), "Error message should be displayed");

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
>>>>>>> 6720739f051318205e0b2f05d1030bfe884b0cfc

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
