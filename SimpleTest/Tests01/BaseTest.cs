using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages01;
using NUnit.Compatibility;



namespace Tests01
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]


  abstract  public  class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
       private  IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            this.driver = new TWebDriver();
        }

        [Test]
        public void FirstTest()
        {
            HomePage homePage = new Pages01.HomePage(driver);
            homePage.OpenBasePage();
            Assert.IsTrue(homePage.IsAccountButtonDisplayed(),"Verification Account button is displayed");
            homePage.ClickMyAccountButton();          
            Assert.IsTrue(homePage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            homePage.ClickRegistrationLink();            
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
          
        }                

        [TearDown]
        public void EndTest()
        {
            driver.Close();
         }
    }
}
