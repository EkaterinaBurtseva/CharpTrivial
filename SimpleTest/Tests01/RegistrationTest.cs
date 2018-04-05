using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pages01;

namespace Tests01
{
    class RegistrationTest:BaseTest<>
    {
        [SetUp]
        [Test]
        public void RegistrationTestStart()
        {
            Assert.IsTrue(homePage.IsAccountButtonDisplayed(), "Verification Account button is displayed");
            homePage.ClickMyAccountButton();
            Assert.IsTrue(homePage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            homePage.ClickRegistrationLink();
            Assert.AreEqual("/wp-login.php?action=register", new Uri(driver.Url).PathAndQuery);
        }
    }
}
