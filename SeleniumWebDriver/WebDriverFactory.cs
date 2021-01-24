using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumWebDriver
{
    static public class WebDriverFactory
    {
        public static IWebDriver GetInstanceOfDriverByName(string driverName)
        {
            switch (driverName)
            {
                case "Chrome":
                    return new ChromeDriver();
                case "FireFox":
                    return new FirefoxDriver();
                case "InternetExplorer":
                    return new InternetExplorerDriver();
                default:
                    return null;
            }
        }



    }
}
