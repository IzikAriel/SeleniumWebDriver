using SeleniumWebDriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.interfaces
{
    public interface IConfig
    {

        BrowsersType GetBrowser();
        string GetUserName();
        string GetPassword();
        string GetWebsite();
    }
}
