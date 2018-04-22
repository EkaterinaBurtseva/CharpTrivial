using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pages;
using Settings;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Settings;

namespace Tests
{
    [TestFixture]
    class HomeTest:BaseTest
    {
        [Test]
        public void HomePageFirstTest()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(baseURL);

        }


    }
}
