using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{

    [TestClass]
    public class MainTest
    {
        static readonly log4net.ILog log;
        [TestMethod]
        public void OpenWebDriver()
        {
         
            IWebDriver driver = new ChromeDriver();
            const string Url = @"http://localhost:5001/";
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
        }

        [AssemblyInitialize]
        public static void SetLogging()
        {
        log4net.ILog log =
        log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        }
            
    }
}
