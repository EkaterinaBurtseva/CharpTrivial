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
using static Settings.BasicReport;

namespace Tests
{
    [TestFixture]
    public class VacanciesTest : BaseTest
    {

        private string title = ".NET";

       
        [Test]
        public void VacanciesStartTest()
        {
            
        
            var vacanciesPage=homePage.GoToVacanciesPage();
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
