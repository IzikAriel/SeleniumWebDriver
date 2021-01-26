using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement Element;

        public static void ClickOnRadioButton(By locator)
        {
            Element = GenericHelper.GetElement(locator);    
            Element.Click();
        }


        public static bool IsRadioButtonSelected(By locator)
        {
            Element = GenericHelper.GetElement(locator);
            string flag = Element.GetAttribute("checked");

            if (flag == null)
            {
                return false;
            }
            else
            {
                return (flag.Equals("checked") || flag.Equals("true"));
            }

        }

    }
}

