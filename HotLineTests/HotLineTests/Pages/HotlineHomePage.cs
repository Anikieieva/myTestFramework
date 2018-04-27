using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        public void GoToTheObjectiveCategoryPage()
        {
            
            var tvCategory = _webDriver.FindElement(By.CssSelector("li[data-eventaction='ТВ, Аудіо, Відео, Фото']"));
            var objectiveAndCamerasCategory = _webDriver.FindElement(By.ClassName("fotoapparaty-obektivy"));
            var action = new Actions(_webDriver);
            action
                 .MoveToElement(tvCategory)
                 .MoveToElement(objectiveAndCamerasCategory).Click()
                 .Build().Perform();
            _webDriver.Navigate().GoToUrl(@"https://hotline.ua/av/obektivy/");
            Thread.Sleep(3000);
            /*action.MoveToElement(_webDriver.FindElement(By.ClassName("obektivy"))).Click().Perform();*/
        }
    }
}