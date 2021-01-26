using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebDriver.ComponentHelper;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.TestScript.RadioButton
{    

    [TestClass]
    public class HandleRadioButton
    {
        public void TestRadio()
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

            LinkHelper.ClickLink(By.XPath("//div[1]/ul[1]/li[9]/a"));
            LinkHelper.ClickLink(By.XPath("//div[2]/table/tbody/tr/td[1]/dl/dt[1]/a"));

            By RadioButtonLocator = By.Id("ssl_redirect-on");
            IWebElement RadioButtonElement = GenericHelper.GetElement(RadioButtonLocator);



        }

    }
}
