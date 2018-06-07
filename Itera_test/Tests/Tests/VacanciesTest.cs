﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Page;
using Properties;
using RelevantCodes.ExtentReports;
using static Properties.ExtentR;

namespace Tests
{
    [TestFixture]
    public class VacanciesTest : BaseTest
    {
        private string title = ".NET";


        [Test]
        public void VacanciesStartTest()
        {
            var homePage = new HomeP();
            homePage.OpenStartPage(baseURL);
            test.Log(LogStatus.Info, "Open vacancies page");
            homePage.GoToVacanciesPage();
            var vacanciesPage = new VacanciesP();
            Check.True(vacanciesPage.IsVacanciesPageDisplayed(), false, "test");
            //where insert pass 
            test.Log(LogStatus.Pass, "Vacancies page is opened");
            Check.True(vacanciesPage.IsVacanciesDisplayed(), false, "test2");
            test.Log(LogStatus.Pass, "List of vacancies is displayed");
            Check.True(vacanciesPage.IsNetVacanciesDisplayed(), false, "test3");
            test.Log(LogStatus.Pass, "Net vacanices are displayed in list(at least one)");
            var titles = vacanciesPage.PrintTitles();
            test.Log(LogStatus.Info, "Print list of titles: " + titles + " ");
            var numbers = vacanciesPage.NumberOfVacancies();
            test.Log(LogStatus.Info, "Number of vacancies: " + numbers);

        }
    }
}

