using OpenQA.Selenium;

namespace CSharpSeleniumDemo.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private const string Url = "https://academybugs.com/";

        public HomePage(IWebDriver driver) {
            this.driver = driver;
        }

        public void NavigateToHomePage() {
            driver.Navigate().GoToUrl(Url);
        }

        public string GetPageTitle() {
            return driver.Title;
        }

        public void ClickFindBugs() {
            // First, close any popups:
            CheckAndClosePopUp();
            var FindBugsLink = driver.FindElement(By.CssSelector("#menu-item-561"));
            FindBugsLink.Click();
        }

        public string GetHeadingText() {
            var heading = driver.FindElement(By.CssSelector("h3"));
            return heading.Text;
        }

        public int GetNumberOfTiles() {
            var tiles = driver.FindElements(By.CssSelector(".example-tile-div"));
            return tiles.Count;
        }

        private void CheckAndClosePopUp() {
            var tutorialPopUp = driver.FindElements(By.CssSelector(".TourTip.TourTipTransitOpacity"));
            if (tutorialPopUp.Count > 0) {
                var closeButton = tutorialPopUp[0].FindElement(By.CssSelector(".pum-close.popmake-close"));
                closeButton.Click();
            }
            return;
        }
    }
}
