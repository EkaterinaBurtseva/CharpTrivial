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
        [FindsBy(How = How.Id, Using = "registerform")]
        private IWebElement Registrationform;
        [FindsBy(How = How.Id, Using = "user_login")]
        private IWebElement UsernameField;
        [FindsBy(How = How.Id, Using = "user_login")]
        private IWebElement EmailField;

        public static void isRegistrationFormDisplayed()
        {

        }
        

        public static void clickRegistrationLink()
        {

        }
            


    }
    }

