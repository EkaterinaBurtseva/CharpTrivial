using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Api;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages
{
    public class VacanciesPage
    {

        [FindsBy(How = How.CssSelector, Using = "section.margin--header")]
        private IWebElement VacanciesHeader;

        [FindsBy(How = How.ClassName, Using = "row bg--white")]
        private IWebElement VacanciesBlock;

        [FindsBy(How = How.ClassName, Using = "block__text__bottom")]
        private IWebElement VacanciesItems;

        [FindsBy(How = How.ClassName, Using = "block__text__bottom")]
        private List<IWebElement> VacanciesTitles;

        public bool IsVacanciesPageDisplayed()
        {
            return VacanciesHeader.Displayed;
        }

        public void NumberOfNetVacancies()
        {
            var count = 0;
            if(VacanciesTitles.Contains(""))
            return count;

        }
    }
}
