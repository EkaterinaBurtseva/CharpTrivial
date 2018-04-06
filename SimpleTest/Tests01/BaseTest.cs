using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages01;
using System;



namespace Tests01
{
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]

    public abstract class BaseTest<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            this.driver = new TWebDriver();

        }

        [Test]
        public void FirstTest()
        {
            HomePage homePage = new HomePage(driver);
            homePage.OpenBasePage();

        }


        [TearDown]
        public virtual void EndTest()
        {
            driver.Close();
        }
    }
}
