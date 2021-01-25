using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.TestScript.WebElement
{   
    [TestClass]
    public class WebElementTest
    {

        [TestMethod]
        public void CheckInuputsNumber()
        {

            string url = ObjectRepository.Config.GetWebsite();
            NavigationHelper.NavigateToUrl(url);
            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
            Console.WriteLine("The size of the Input Elements is: {0}", elements.Count);
          
        }


    }
}
