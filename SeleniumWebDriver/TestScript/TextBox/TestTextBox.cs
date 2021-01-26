using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System.Collections;

namespace SeleniumWebDriver.TestScript.TextBox
{   
    [TestClass]
    public class TestTextBox
    {

        [TestMethod]

        public void LoggingTextBox()
        {   
            string url = ObjectRepository.Config.GetWebsite();
            NavigationHelper.NavigateToUrl(url);
            LinkHelper.ClickLink(By.LinkText("File a Bug"));

            By userTextBox = By.Id("Bugzilla_login");
            string user = ObjectRepository.Config.GetUserName();
            TextBoxHelper.TypeinTextBox(userTextBox, user);

            By passwordTextBox = By.Id("Bugzilla_password");
            string password = ObjectRepository.Config.GetPassword();
            TextBoxHelper.TypeinTextBox(passwordTextBox, password);

            ArrayList locators = new ArrayList { userTextBox, passwordTextBox };
            TextBoxHelper.ClearTextBox(locators);

           
        }
    }
}
