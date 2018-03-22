using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependencies;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    class RegistrationPage
    {
        public IWebDriver driver;
       
      
        static void Main(string[] args)
        {
           

        }
        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement Registrationform;
        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement RegisterLink;
        public static void clickMyAccountButton()
        {           
        }

        public static void clickRegistrationLink()
        {

        }
            


    }
    }

