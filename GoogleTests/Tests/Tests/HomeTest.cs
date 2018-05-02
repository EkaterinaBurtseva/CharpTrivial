using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pages;

namespace Tests
{
    [TestFixture]
    public class HomeTest:BaseTest
    {

        [Test]
        public void HomePageGoogleStart()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(baseURL);

        }
    }
}
