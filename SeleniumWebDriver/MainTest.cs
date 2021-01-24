using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Configuration;
using SeleniumWebDriver.interfaces;

namespace SeleniumWebDriver
{

    [TestClass]
    public class MainTest
    {
        
        [TestMethod]
        public void OpenWebDriver()
        {
            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser:{0}", config.GetBrowser());
            Console.WriteLine("User:{0}", config.GetUser());
            Console.WriteLine("Password:{0}", config.GetPassword());

        }



    }
}
