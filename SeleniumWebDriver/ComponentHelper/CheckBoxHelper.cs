using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement Element;

        public static void CheckedCheckBox(By locator)
        {
            Element = GenericHelper.GetElement(locator);
            if(Element.GetAttribute("checked").Equals("false") )
                Element.Click();
        }
        public static bool IsCheckBoxChecked(By locator)
        {
            Element = GenericHelper.GetElement(locator);
            string flag = Element.GetAttribute("checked");

            if (flag == null)
                return false;

            else return (flag.Equals("checked") || flag.Equals("true"));
            
                
        }

    }
}
