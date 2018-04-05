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
    public class RegistrationPage : BasePage
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

        string usernameWrong = "***";
        string emailWrong = "1111";
        string usernameValid = "test";
        string emailValid = "merrychristmas946@gmail.com";
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsRegistrationFormDisplyed()
        {
            Boolean isDisplayed = RegisterForm.Displayed;
            return isDisplayed;

        }


        public bool IsRegisterBtnDisplyed()
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

        public bool IsErrorDisplayed()
        {
            Boolean isDisplayed = ErrorMessage.Displayed;
            return isDisplayed;
        }

        public bool IsSuccessDisplayed()
        {
            Boolean isDisplayed = SuccessMessage.Displayed;
            return isDisplayed;
        }
    }
}

