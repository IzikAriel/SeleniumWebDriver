using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebDriver.Setting;
using OpenQA.Selenium.Support.Extensions;

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

        public static void ScreenShot(string fileName = "ScreenShoot")
        {
           // string dir = "..//ScreenShoots//";
            Screenshot screenshot = ObjectRepository.Driver.TakeScreenshot();
            if (fileName.Equals(fileName))
            {
                fileName = fileName + DateTime.Now.ToString("yyyy--MM-dd--mm--ss") + ".jpeg";
            }
            screenshot.SaveAsFile("ScreenShoots//"+fileName, ScreenshotImageFormat.Jpeg);

        }
    }
}
