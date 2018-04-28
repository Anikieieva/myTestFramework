using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HotLineTests
{
    public class TestBootstrapper
    {
        public IWebDriver myDriver;

        public static string igWorkDir = @"path_to_webdriver_exe";

        public IWebDriver InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            IWebDriver myDriver = new ChromeDriver(igWorkDir, options);
            myDriver.Manage().Window.Maximize();
            return myDriver;
        }

        /*public WebDriverWait Waiter
        {
            get { };
            set { };
        }*/
    }
}
