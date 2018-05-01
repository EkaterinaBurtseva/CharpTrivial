using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Settings;

namespace Pages
{
    public class HomePage : BasePage
    {
        public HomePage() : base()
        {

        }


        [FindsBy(How = How.ClassName, Using = "header__pageTitle")]
        private IWebElement HomeLogo;


        [FindsBy(How = How.ClassName, Using = "burger js-burger")]
        private IWebElement MenuButton;

        [FindsBy(How = How.CssSelector, Using = "ul.nav--large  li:nth-last-of-type(6) a")]
        private IWebElement YouAtIteraLink;

        [FindsBy(How = How.Id, Using = "mCSB_1_container")]
        private IWebElement GamburgerMenu;

        [FindsBy(How = How.Id, Using = "mCSB_5_container")]
        private IWebElement GamburgerMenu2;

        [FindsBy(How = How.Id, Using = "#mCSB_5_container li:nth-last-of-type(1)")]
        private IWebElement VacanciesLink;



        public void OpenStartPage(string baseURL)
        {
            Browsers.Goto(baseURL);
        }

        public bool IsHomePageOpened()
        {
            return HomeLogo.Displayed;

        }

        public void ClickMenuButton()
        {
            MenuButton.Click();
        }

        public bool IsGamburgerMenuOpened()
        {
            return GamburgerMenu.Displayed;
        }

        public void ClickYouAtIteraLink()
        {
            YouAtIteraLink.Click();
        }

        public bool IsGamburgerMenu2Opened()
        {
            return GamburgerMenu2.Displayed;
        }

        public void ClickVacanciesLink()
        {
            VacanciesLink.Click();
        }



    }
}
