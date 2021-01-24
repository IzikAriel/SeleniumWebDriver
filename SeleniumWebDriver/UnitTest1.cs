using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            const string Url = "https://google.com/";
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();
            
        }
        public void NewFunc()
        {
            IWebDriver driver = new ChromeDriver();
            const string Url = "https://google.com/";
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();

        }
    }
}
