using System;
using System.Text;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using System.Collections.Specialized;
using Helpers;
using NUnit.Framework;

namespace Tests01
{
    [TestFixture]
    public abstract class BaseTest
    {
        
        IWebDriver driver;
        [Test]


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
        }
       

        [OneTimeTearDown]
        public virtual void EndTest()
        {
            Browsers.Close();
        }

    }
}
