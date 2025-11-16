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
            var FindBugsLink = driver.FindElement(By.LinkText("Find Bugs"));
            FindBugsLink.Click();
        }

        public string GetHeadingText() {
            var heading = driver.FindElement(By.CssSelector("h3"));
            return heading.Text;
        }

        public int GetNumberOfTiles(){
            var tiles = driver.FindElements(By.CssSelector(".card"));
            return tiles.Count;
        }
    }
}

/**
using OpenQA.Selenium;

namespace SeleniumDemo.Pages
{
    public class Homepage
    {
        private readonly IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://academybugs.com");
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public string GetHeadingText()
        {
            var heading = driver.FindElement(By.CssSelector("h3"));
            return heading.Text;
        }

        public int GetNumberOfTiles()
        {
            var tiles = driver.FindElements(By.CssSelector(".card"));
            return tiles.Count;
        }
    }
}
*/