using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ComponentHelper
{
   

    public class DropDownHelper
    {
        private static IWebElement Element;

        public static void SelectElementByIndex(By locator, int index)
        {   
           
            Element = GenericHelper.GetElement(locator);
            SelectElement select = new SelectElement(Element);
            if (index < select.Options.Count)
            {
                select.SelectByIndex(index);
            }
            else
            {
                string ex = "There is a problem with a SelectElementByIndex function, index bigger than a count of the List";
                Console.WriteLine(ex);
                throw new Exception(ex);
            }
        }

        public static void SelectElementByValue(By locator, string visbleElement)
        {
            Element = GenericHelper.GetElement(locator);
            SelectElement select = new SelectElement(Element);
            IList<string> allOptions = GetAllElements(locator);
            
            if (allOptions.Contains(visbleElement))
            {
                select.SelectByValue(visbleElement);
            }
            else
            {
                string ex = "There is a problem with a SelectElementByValue function, value not Found";
                Console.WriteLine(ex);
                throw new Exception(ex);
            }
          
        }

        private static IList<string> GetAllElements(By locator)
        {
            Element = GenericHelper.GetElement(locator);
            SelectElement select = new SelectElement(Element);
            return select.Options.Select((x) => x.Text).ToList();
        }

        public static void PrintAllElements(By locator)
        {
            IList<string> texts = GetAllElements(locator);
            foreach(string text in texts)
            {
                Console.WriteLine(text);
            }
        }


    }
}
