using OpenQA.Selenium;
using CSharpSeleniumDemo.Drivers;

namespace CSharpSeleniumDemo.Utils
{
    public class TestBase
    {
        protected IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverFactory.Create();
        }

        [TearDown]
        public void Teardown()
        {
            // Dispose the WebDriver instance so NUnit analyzer recognizes it as properly cleaned up.
            driver?.Dispose();
            driver = null;
        }
    }
}
