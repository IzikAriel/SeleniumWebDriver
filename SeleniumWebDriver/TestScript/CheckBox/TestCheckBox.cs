using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.TestScript.CheckBox
{   
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void CheckBox()
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

            By checkBoxLocator = By.Id("Bugzilla_restrictlogin");
            CheckBoxHelper.CheckedCheckBox(checkBoxLocator);
            bool response = CheckBoxHelper.IsCheckBoxChecked(checkBoxLocator);


            ArrayList locators = new ArrayList { userTextBox, passwordTextBox };
            TextBoxHelper.ClearTextBox(locators);

            if (response == true)
                Console.WriteLine("The checkBox is checked");

        }

    }
}
