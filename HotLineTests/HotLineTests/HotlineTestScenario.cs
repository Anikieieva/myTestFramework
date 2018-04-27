using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HotLineTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HotLineTests
{
    [TestFixture]
    public class HotlineTestScenario
    {

        public static IWebDriver WebDriver;

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void OneTimeSetUp()
        {
            var testBootstrapper = new TestBootstrapper();
            WebDriver = testBootstrapper.InitializeDriver();
        }

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            
        }

        [Test]
        public void ShouldOpenHotlineFromGoogleSearch()
        {
            //Precondition
            GoToTheHotlinePageFromGoogleSearch();
            //Assertion 
            WebDriver.Title.Contains("Hotlian");
            var logoContainer = WebDriver.FindElement(By.ClassName("header-logo"));
            var img = logoContainer.FindElement(By.TagName("img"));
            var srcLogoAttribute = img.GetAttribute("src");
            Assert.Equals(@"https://hotline.ua/public/i/logo-v2.svg", srcLogoAttribute);
        }

        [Test]
        public void ShouldChangeLanguageInHotlinePage()
        {
            //Precondition
            GoToTheHotlinePageFromGoogleSearch();
            var hotlineHomePage = new HotlineHomePage(WebDriver);
            var changeToLanguage = hotlineHomePage.ChangeLanguage();
            //Assertion
            if (changeToLanguage == "uk")
            {
                Assert.True(WebDriver.Title.Contains("України"));
            }
            else
            {
                Assert.True(WebDriver.Title.Contains("Украины"));
            }

        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            // ТУТ КОД
        }

        [OneTimeTearDown] //вызывается после завершения всех тестов
        public void OneTimeTearDown()
        {
            WebDriver.Quit();
        }

        private void GoToTheHotlinePageFromGoogleSearch()
        {
            var googlePage = new GooglePage(WebDriver);
            googlePage.Navigate();
            googlePage.MakeSearchRequest("hotline");
            googlePage.GoToTheFirstSearchLink();
        }
    }
}
