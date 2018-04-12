using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using System.Collections.Specialized;
using Helpers;
using NUnit.Framework;
using System.Security.Policy;

namespace Tests01
{
    [TestFixture]
    public abstract class BaseTest
    {
        string url;


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
        }

        [Test]
        public void OpenStartPage()
        {
            Browsers.Goto(url);

        }


        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

    }
}
