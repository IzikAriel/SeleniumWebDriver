using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebDriver.Setting;

namespace SeleniumWebDriver.ComponentHelper
{
    public class GenericHelper
    {

        public static bool IsElementPresent(By locator)
        {
            try
            {
                bool res = ObjectRepository.Driver.FindElements(locator).Count == 1;
                return res;
            }
            catch(Exception)
            {
                return false;
            }

        }

        public static IWebElement GetElement(By locator)
        {

            if (IsElementPresent(locator) == true)
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else throw new NoSuchElementException("Element Not Found: " + locator.ToString());

        }




    }
}
