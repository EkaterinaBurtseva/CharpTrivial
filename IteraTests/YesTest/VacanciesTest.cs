using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Pages;
using RelevantCodes.ExtentReports;


namespace Tests
{
    [TestFixture]
    public class VacanciesTest : BaseTest
    {

        private string title = ".NET";

       
        [Test]
        public void VacanciesStartTest()
        {
            var homePage = new HomePage();
            test = extent.StartTest("Vacancies start test");
            homePage.OpenStartPage(baseURL);
            test.Log(LogStatus.Info, "Open vacancies page");
            homePage.GoToVacanciesPage();
            var vacanciesPage = new VacanciesPage();
            Assert.IsTrue(vacanciesPage.IsVacanciesPageDisplayed());
            test.Log(LogStatus.Pass, "Vacancies page is opened");
            Assert.IsTrue(vacanciesPage.IsVacanciesDisplayed());
            test.Log(LogStatus.Pass, "List of vacancies is displayed");
            Assert.IsTrue(vacanciesPage.IsNetVacanciesDisplayed());
            test.Log(LogStatus.Pass, "Net vacanices are displayed in list(at least one)");
            var titles = vacanciesPage.PrintTitles();
            test.Log(LogStatus.Info, "Print list of titles: " + titles + " ");
            var numbers = vacanciesPage.NumberOfVacancies();
            test.Log(LogStatus.Info, "Number of vacancies: " + numbers);

        }
    }
}
