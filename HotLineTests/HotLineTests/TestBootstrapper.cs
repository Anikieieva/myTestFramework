using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HotLineTests
{
    public class TestBootstrapper
    {
        public static string igWorkDir = @"C:\Users\Оксана\Documents\Visual Studio 2017\Projects\HotLineTests\HotLineTests\HotLineTests";

        public IWebDriver InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            IWebDriver myDriver = new ChromeDriver(igWorkDir, options);
            myDriver.Manage().Window.Maximize();
            return myDriver;
        }
    }
}
