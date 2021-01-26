using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebDriver.Setting;


namespace SeleniumWebDriver.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement Element;

        public static void ClickLink(By locator)
        {   
            Element = GenericHelper.GetElement(locator);
            Element.Click();
        }

    }
}
