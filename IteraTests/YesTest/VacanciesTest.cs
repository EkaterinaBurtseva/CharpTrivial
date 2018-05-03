using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Pages;

namespace YesTest
{
    [TestFixture]
    class VacanciesTest
    {

        private string title = ".NET";
        [Test]
        public void VacanciesStartTest()
        {
            var vacanciesPage = new VacanciesPage();
            vacanciesPage.IsVacanciesPageDisplayed();
        }
    }
}
