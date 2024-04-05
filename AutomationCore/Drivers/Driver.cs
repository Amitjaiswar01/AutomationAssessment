using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace AutomationCore.Drivers
{
    public class Driver
    {
        private IWebDriver driver;

        public Driver() { }

        public IWebDriver GetWebDriverInstance(string browserName)
        {
            driver = null;

            switch (browserName.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    throw new WebDriverException($"Unsupported browser: {browserName}");
            }

            return driver;
        }
    }
}
