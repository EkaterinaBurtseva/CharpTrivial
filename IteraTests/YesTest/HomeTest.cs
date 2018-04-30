﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages;
using Settings;

namespace Tests01
{
    [TestFixture]
    class HomeTest : BaseTest
    {
        
        [Test]
        public void HomePageTestStart()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(baseURL);


        }


    }
}