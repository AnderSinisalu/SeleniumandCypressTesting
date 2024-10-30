using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTesting
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Test]
        public void TestChessHomepage()
        {
            // Visit the Chess.com homepage
            driver.Navigate().GoToUrl("https://www.chess.com/");

            // Check that the title contains "Chess"
            Assert.IsTrue(driver.Title.Contains("Chess"), "Title does not contain 'Chess'.");

            // Check if the nav-language-name element is visible
            var languageNameElements = wait.Until(drv => drv.FindElements(By.ClassName("nav-language-name")));
            Assert.IsTrue(languageNameElements.Count > 0, "No language name elements found.");

        }


        [Test]
        public void TestWikipediaHomepage()
        {
            // Visit the Wikipedia homepage
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            // Check that the title contains "Wikipedia"
            Assert.IsTrue(driver.Title.Contains("Wikipedia"));

            // Check if the Wikipedia logo is visible
            var logo = wait.Until(drv => drv.FindElement(By.CssSelector(".central-featured-logo")));
            Assert.IsTrue(logo.Displayed);

            // Verify that the search input is visible
            var searchInput = wait.Until(drv => drv.FindElement(By.Id("searchInput")));
            Assert.IsTrue(searchInput.Displayed);

            // Check for the main language content section
            var mainSection = wait.Until(drv => drv.FindElement(By.CssSelector(".central-featured")));
            Assert.IsTrue(mainSection.Displayed);
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
