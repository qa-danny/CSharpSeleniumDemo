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
            string heading = homepage.GetHeadingText();
            Assert.That(heading, Is.EqualTo("Examples of Bugs"), "Heading should match expected text."); 
            Assert.That(title, Does.Contain("AcademyBugs.com"), "Page title should contain specific text.");
        }

        [Test]
        public void VerifyNumberOfTilesAndText() {
            int tileCount = homepage.GetNumberOfTiles();
            List<string> tileTexts = homepage.GetTextOfAllTiles();

            Assert.That(tileCount, Is.EqualTo(6), "There should be exactly 6 tiles on the homepage.");
            // Not necessarily the best asssertion here, but sufficient for demo purposes.
            Assert.That(tileTexts.Count, Is.EqualTo(6), "There should be exactly 6 tiles on the homepage.");
            // Verify that specific tile header texts are present
            Assert.That(tileTexts.Any(text => text.Contains("Social share button")), "Tile text should contain 'Social Share Button'.");
            Assert.That(tileTexts.Any(text => text.Contains("Video player")), "Tile text should contain 'Video player'.");
            Assert.That(tileTexts.Any(text => text.Contains("SEARCH BUTTON LEADS TO AN ERROR", StringComparison.OrdinalIgnoreCase)), "Tile text should contain 'Search button leads to an error'.");
        }

        [Test]
        public void NavigateToFindBugsPage() {
            homepage.ClickFindBugs();

            Assert.That(driver!.Url, Does.EndWith("/find-bugs/"), "Expect URL to end with '/find-bugs/'.");

        }
    }
}
