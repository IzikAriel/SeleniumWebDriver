using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebDriver.ComponentHelper;
using OpenQA.Selenium;
using SeleniumWebDriver.Setting;
using System.Collections;

namespace SeleniumWebDriver.TestScript.Button
{
   
    [TestClass]
    public class TestButton
    {
       [TestMethod]
       public void ButtonClick()
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
            string text = ButtonHelper.GetButtonText(loggingButton);
            Console.WriteLine("The Text Button is: {0}", text);
            ButtonHelper.ClickButton(loggingButton);
        }
    }
}
