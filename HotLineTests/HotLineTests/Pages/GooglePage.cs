using System.Threading;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;

namespace HotLineTests.Pages
{
    public class GooglePage
    {
        private readonly IWebDriver _webDriver;

        public GooglePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void Navigate()
        {
            _webDriver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(1000);
        }

        public void MakeSearchRequest(string requestString)
        {
            IWebElement button = _webDriver.FindElement(By.Name("btnK"));
            IWebElement input = _webDriver.FindElement(By.Name("q"));
            input.SendKeys(requestString);
            input.SendKeys(Keys.Enter);
        }

        public void GoToTheFirstSearchLink()
        {
            var firstElement = _webDriver.FindElement(By.Id("vn1s0p1c0"));
            firstElement.Click();
        }
    }
}