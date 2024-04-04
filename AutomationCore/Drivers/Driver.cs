using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationCore.Drivers
{
    public class Driver
    {
        private IWebDriver driver;

        public Driver() { }

        public IWebDriver GetWebDriverInstance()
        {
            driver = new ChromeDriver();
            return driver;
        }
    }
}
