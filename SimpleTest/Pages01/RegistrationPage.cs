using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pages01
{
    public class RegistrationPage :BasePage
    {
       
        [FindsBy(How = How.CssSelector, Using = "p.message")]
        private IWebElement RegisterTitle;

        [FindsBy(How = How.Id, Using = "registerform")]
        private IWebElement RegisterForm;

        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement Email;

        [FindsBy(How = How.Id, Using = "wp-submit")]
        private IWebElement RegisterBtn;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement SuccessMessage;

        [FindsBy(How = How.Id, Using = "login_error")]
        private IWebElement ErrorMessage;
        
        String usernameWrong = "***";
        String emailWrong = "1111";
        String usernameValid = "test";
        String emailValid = "merrychristmas946@gmail.com";
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public bool isRegistrationPageOpened(IWebElement RegisterTitle)
        {
            return RegisterTitle.Displayed;
        }

        public bool isRegistrationFormDisplyed(IWebElement RegisterForm)
        {
            return RegisterForm.Displayed;
        }

        public bool isUsernameFieldDisplayed(IWebElement Username)
        {
            return Username.Displayed;
        }

        public bool isEmailFieldDisplayed(IWebElement Email)
        {
            return Email.Displayed;
        }

        public bool isRegisterBtnDisplyed(IWebElement RegisterBtn)
        {
            return RegisterBtn.Displayed;
        }

       public void FillFormCorrect()
        {
             Username.SendKeys(usernameValid);      
            Email.SendKeys(emailValid);
        }

        public void FillFormWrong()
        {
            Username.SendKeys(usernameWrong);
            Email.SendKeys(emailWrong);
        }

        public void ClickRegisterBtn()
        {
            RegisterBtn.Click();
        }

        public bool isErrorDisplayed()
        {
            Boolean isEnabled = ErrorMessage.Enabled;
            return isEnabled;
         }

        public bool isSuccessDisplayed()
        {
            Boolean isEnabled = SuccessMessage.Enabled;
            return isEnabled;
        }
    }
    }

