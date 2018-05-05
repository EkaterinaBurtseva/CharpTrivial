using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Api;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Settings;


namespace Pages
{
    public class VacanciesPage : BasePage
    {
        public VacanciesPage() : base()
        {

        }

        [FindsBy(How = How.CssSelector, Using = "section.margin--header")]
        private IWebElement VacanciesHeader;

        [FindsBy(How = How.ClassName, Using = "row bg--white")]
        private IWebElement VacanciesBlock;

        [FindsBy(How = How.ClassName, Using = "block__text__bottom")]
        private IWebElement VacanciesItems;

        [FindsBy(How = How.CssSelector, Using = "div.vacancy__title h3")]
        private IList<IWebElement> VacanciesTitles;

        public bool IsVacanciesPageDisplayed()
        {
           return VacanciesHeader.Displayed;
        }

        public bool IsVacanciesDisplayed()
        {
            return VacanciesItems.Displayed;
        }

        public void NumberOfVacancies()
        {
            String[] allText = new String[VacanciesTitles.Count];
            int i = 0;
            int count = 0;

            foreach (IWebElement element in VacanciesTitles)
            {
                allText[i++] = element.Text;
                count++;         

            }
            Console.WriteLine(count);
        }

        public bool IsNetVacanciesDisplayed()
        {
            String[] allText1 = new String[VacanciesTitles.Count];
            int i = 0;
            bool result = false;
            foreach (IWebElement element in VacanciesTitles)
            {
                allText1[i++] = element.Text;
                if (element.Text.Contains("NET"))
                {
                    return result = true;
                }
            }
            return result;
        }

        public void PrintTitles()
        {
            String[] allText = new String[VacanciesTitles.Count];
            int i = 0;
            foreach (IWebElement element in VacanciesTitles)
            {
                allText[i++] = element.Text;

                Console.WriteLine(element.Text);
            }
        }



    }
}

