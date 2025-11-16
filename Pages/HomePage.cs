using OpenQA.Selenium;

namespace CSharpSeleniumDemo.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private const string Url = "https://academybugs.com/";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void ClickFindBugs() {
            var FindBugsLink = driver.FindElement(By.LinkText("Find Bugs"));
            FindBugsLink.Click();
        }

        public int GetNumberOfBugLinks() {
            var BugLinks = driver.FindElements(By.CssSelector("#example-tile-div"));  
            return BugLinks.Count;
        }
    }
}
