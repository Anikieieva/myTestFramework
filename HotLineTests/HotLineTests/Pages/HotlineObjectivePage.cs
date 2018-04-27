using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HotLineTests.Pages
{
    public class HotlineObjectivePage
    {
        private readonly IWebDriver _webDriver;

        public HotlineObjectivePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void FilteByCanonSystem()
        {
            var findElement =  _webDriver.FindElement(By.CssSelector("div[data-filter-group='gr-14555'] input[data-eventlabel='Canon[14556]']"));
            findElement.FindElement(By.ClassName("check")).Click();
           
            Thread.Sleep(2000);
        }

        public void FilteByToCost(int costLimit)
        {
            _webDriver.FindElement(By.CssSelector("input[data-eventlabel~='Canon']"));
        }
    }
}