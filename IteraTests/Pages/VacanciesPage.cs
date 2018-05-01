using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class VacanciesPage
    {

        [FindsBy(How = How.CssSelector, Using = "section.margin--header")]
        private IWebElement VacanciesHeader;

        public bool IsVacanciesPageDisplayed()
        {
            return VacanciesHeader.Displayed;
        }
    }
}
