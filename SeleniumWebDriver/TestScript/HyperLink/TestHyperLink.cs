using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebDriver.ComponentHelper;
using OpenQA.Selenium;
using SeleniumWebDriver.Setting;

namespace SeleniumWebDriver.HyperLink
{   
    [TestClass]
    public class TestHyperLink
    {

    [TestMethod]
    public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
           
        }
    }
}
