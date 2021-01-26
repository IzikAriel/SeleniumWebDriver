using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.ComponentHelper
{
    public class WindowsHelper
    {
        public static string GetTitle()
        {
            string title = ObjectRepository.Driver.Title;
            return title;
        }


    }
}
