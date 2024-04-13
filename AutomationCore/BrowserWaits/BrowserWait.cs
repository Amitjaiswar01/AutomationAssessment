using AutomationCore.Browsers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.BrowserWaits
{
    public class BrowserWait
    {
        public WebDriverWait Wait {  get; set; }
        public Browser Browsers { get; set; }
        public BrowserWait(Browser browser) 
        {
            Browsers = browser;
            Wait = new WebDriverWait(Browsers.Driver, TimeSpan.FromSeconds(60));
        }

        public IWebElement ElementIsVisible(By by)
        {
            return Wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
