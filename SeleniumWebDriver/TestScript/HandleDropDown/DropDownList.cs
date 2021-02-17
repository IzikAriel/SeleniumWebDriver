using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.TestScript.HandleDropDown
{   
    [TestClass]
    public class DropDownList
    {
        [TestMethod]
        public void DropDown()
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

            By loggingButton = By.Id("log_in");
            ButtonHelper.ClickButton(loggingButton);

            By listLoactor = By.Id("bug_severity");
            DropDownHelper.SelectElementByIndex(listLoactor, 2);
            DropDownHelper.SelectElementByValue(listLoactor, "blocker");
            DropDownHelper.PrintAllElements(listLoactor);

            GenericHelper.ScreenShot();
        }
    }
}
