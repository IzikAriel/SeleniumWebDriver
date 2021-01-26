using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SeleniumWebDriver.ComponentHelper
{
    public class TextBoxHelper
    {
        private static IWebElement Element;
        public static void TypeinTextBox(By locator, string text)
        {
            Element = GenericHelper.GetElement(locator);
            Element.Clear();
            Element.SendKeys(text);


        }
        public static void ClearTextBox(ArrayList locators)
        {
            foreach (By loc in locators)
            {
                Element = GenericHelper.GetElement(loc);
                Element.Clear();
            }
        }


    }
}
