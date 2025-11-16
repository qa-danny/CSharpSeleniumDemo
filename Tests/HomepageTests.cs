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
        public void NavigateToFindBugsPage() {
            homepage.ClickFindBugs();

            // Assert that after click, the Find Bugs page is loaded
            // Based on site behavior: path should contain "/find-bugs/"
            Assert.That(driver!.Url, Does.Contain("/find-bugs"), "Should navigate to the Find Bugs page.");

            // Optionally assert a key element on the Find Bugs page
            // E.g., check for a known heading or element
            var heading = driver.FindElement(By.CssSelector("h1"));
            Assert.That(heading.Text, Does.Contain("Find Bugs"), "Heading should say Find Bugs");
        }
    }
}
