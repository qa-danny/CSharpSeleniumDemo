using CSharpSeleniumDemo.Utils;
using CSharpSeleniumDemo.Pages;
using OpenQA.Selenium;

namespace CSharpSeleniumDemo.Tests
{
    public class HomePageTests : TestBase {
        [Ignore("Don't run this test for now")]
        [Test]
        public void HomePageLoadsSuccessfully()
        {
            var home = new HomePage(driver!);
            home.GoTo();

            // Assert that the page URL is correct
            Assert.That(driver!.Url, Is.EqualTo("https://academybugs.com/"));

            // Assert that the logo or brand text is visible (or whatever you want to verify)
            // string logo = home.GetLogoText();
            // Assert.That(logo, Is.Not.Empty, "Logo text should be present on the home page.");
        }

        [Test]
        public void NavigateToFindBugsPage()
        {
            var home = new HomePage(driver!);
            home.GoTo();

            home.ClickFindBugs();

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
