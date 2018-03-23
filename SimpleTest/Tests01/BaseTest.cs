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
            basePage.openBasePage();
            basePage.clickMyAccountButton();
            basePage.clickRegistrationLink();
        }
      //  [TearDown]
       // public void EndTest()
       // {
       //     driver.Close();
       // }
    }
}
