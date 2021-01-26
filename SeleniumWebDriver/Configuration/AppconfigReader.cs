using SeleniumWebDriver.interfaces;
using SeleniumWebDriver.Setting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Configuration
{
    class AppConfigReader : IConfig
    {
        public BrowsersType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowsersType)Enum.Parse(typeof(BrowsersType), browser);

        }
        public string GetPassword()
        {
            string password = ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
            return password;
        }

        public string GetUserName()
        {
            string user = ConfigurationManager.AppSettings.Get(AppConfigKeys.User);
            return user;
        }

        public string GetWebsite()
        {
            string website = ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
            return website;
        }
    }
}
