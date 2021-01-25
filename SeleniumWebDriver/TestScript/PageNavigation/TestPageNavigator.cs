using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.TestScript.PageNavigation
{   
    [TestClass]
    public class TestPageNavigator
    {

        [TestMethod]
        public void OpenPage()
        {
            string url = ObjectRepository.Config.GetWebsite();
            NavigationHelper.NavigateToUrl(url);
        }


    }
}
