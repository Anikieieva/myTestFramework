using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HotLineTests
{
    [TestFixture]
    public class HotlineHomepageTest
    {

        public static IWebDriver myDriver;

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
        public void OneTimeSetUp()
        {
            var testBootstrapper = new TestBootstrapper();
            myDriver = testBootstrapper.InitializeDriver();
        }

        [OneTimeTearDown] //вызывается после завершения всех тестов
        public void OneTimeTearDown()
        {
            myDriver.Quit();
        }

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            // ТУТ КОД
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            // ТУТ КОД
        }

        [Test]
        public void MyFirstLookAtTheSelenium()
        {
            myDriver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement elementWhatWeFinding = myDriver.FindElement(By.Name("btnK"));
            IWebElement elementInputElement = myDriver.FindElement(By.Name("q"));

            elementInputElement.SendKeys("lalalalala");
            Thread.Sleep(1000);

            elementWhatWeFinding.Click();

            Thread.Sleep(5000);
        }

        [Test]
        public void my_new_subtest_case()
        {

        }
    }
}
