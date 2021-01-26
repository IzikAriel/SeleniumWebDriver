using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ComponentHelper
{
    public class ButtonHelper
    {

        private static bool IsButtonEnabled(By locator)
        {
            IWebElement element = GenericHelper.GetElement(locator);
            return element.Enabled;
        }


        public static void ClickButton(By locator)
        {
            if( IsButtonEnabled(locator))
            {
                IWebElement element = GenericHelper.GetElement(locator);
                element.Click();
            }
            else
            {
                Console.WriteLine("A logging Button is disenabled");

            }

        }

        public static string GetButtonText(By locator)
        {
            
            IWebElement element = GenericHelper.GetElement(locator);
            string text = element.GetAttribute("value");
            if (text == null)
            {
                return String.Empty;
            } 
            else
            {
                return text;
            }
               
        }


    }


}
