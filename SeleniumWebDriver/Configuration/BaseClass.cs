using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumWebDriver.CustomException;
using SeleniumWebDriver.interfaces;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Configuration
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetIexplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tx)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowsersType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowsersType.FireFox:
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;
                case BrowsersType.IExplorer:
                    ObjectRepository.Driver = GetIexplorerDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound( "Driver Not Found: " +  ObjectRepository.Config.GetBrowser().ToString() );
            }
        }
    }
}
