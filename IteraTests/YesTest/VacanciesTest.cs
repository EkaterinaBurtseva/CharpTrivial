using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Pages;


namespace Tests
{
    [TestFixture]
    public class VacanciesTest : BaseTest
    {

        private string title = ".NET";
        public VacanciesTest()
        {

            testUrl = "reports\\VacanciesTest.html";
        }
        [Test]
        public void VacanciesStartTest()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(baseURL);
            homePage.GoToVacanciesPage();
            var vacanciesPage = new VacanciesPage();
            Assert.IsTrue(vacanciesPage.IsVacanciesPageDisplayed());
            Assert.IsTrue(vacanciesPage.IsVacanciesDisplayed());
            Assert.IsTrue(vacanciesPage.IsNetVacanciesDisplayed());
            vacanciesPage.PrintTitles();
            vacanciesPage.NumberOfVacancies();
        }
    }
}
