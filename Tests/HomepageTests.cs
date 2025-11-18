using CSharpSeleniumDemo.Utils;
using CSharpSeleniumDemo.Pages;
using OpenQA.Selenium;

namespace CSharpSeleniumDemo.Tests {
    public class HomePageTests : TestBase {
        private HomePage homepage;

        [SetUp]
        public void TestSetup() {
            homepage = new HomePage(driver!);
            homepage.NavigateToHomePage();
        }

        [Test]
        public void HomePageLoadsSuccessfully() {
            string title = homepage.GetPageTitle();

            Assert.That(title, Does.Contain("AcademyBugs.com"), "Page title should contain specific text.");
        }

        [Test]
        public void VerifyNumberOfTiles() {
            int tileCount = homepage.GetNumberOfTiles();

            Assert.That(tileCount, Is.EqualTo(6), "There should be exactly 6 tiles on the homepage.");
        }

        [Test]
        public void NavigateToFindBugsPage() {
            homepage.ClickFindBugs();

            Assert.That(driver!.Url, Does.EndWith("/find-bugs/"), "Expect URL to end with '/find-bugs/'.");

        }
    }
}
