using OpenQA.Selenium;

namespace HotLineTests.Pages
{
    public class HotlineHomePage
    {
        private readonly IWebDriver _webDriver;

        public HotlineHomePage(IWebDriver _webDriver)
        {
            this._webDriver = _webDriver;
        }
        public string ChangeLanguage()
        {
            var languageBox = _webDriver.FindElement(By.ClassName("language-box"));
            var noneActiveLanguage = languageBox.FindElement(By.CssSelector("span.js-change-language:not(.active)"));
            var changeLanguage = noneActiveLanguage.GetAttribute("data-language");
            noneActiveLanguage.Click();
            return changeLanguage;
        }
    }
}