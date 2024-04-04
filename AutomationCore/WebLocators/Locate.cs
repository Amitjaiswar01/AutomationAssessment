using AutomationCore.Browsers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationCore.WebLocators
{
    public class Locate
    {
        public Browser Browser { get; set; }

        public Locate(Browser browser)
        {
            Browser = browser;
        }

        public IWebElement ElementByClassName(string ClassName)
        {
            return Browser.Driver.FindElement(By.ClassName(ClassName));
        }

        public IWebElement ElementById(string Id)
        {
            return Browser.Driver.FindElement(By.Id(Id));
        }

        public IWebElement ElementByXpath(string Xpath)
        {
            return Browser.Driver.FindElement(By.XPath(Xpath));
        }

        public IWebElement ElementBySelector(string Selector)
        {
            return Browser.Driver.FindElement(By.CssSelector(Selector));
        }

        public IWebElement ElementByTagName(string Tagname)
        {
            return Browser.Driver.FindElement(By.TagName(Tagname));
        }

        public IWebElement ElementByLinkText(string LinkText)
        {
            return Browser.Driver.FindElement(By.LinkText(LinkText));
        }

        public ReadOnlyCollection<IWebElement> ElementsByClassName(string className)
        {
            return Browser.Driver.FindElements(By.ClassName(className));
        }

        public ReadOnlyCollection<IWebElement> ElementsByTagName(string Tagname)
        {
            return Browser.Driver.FindElements(By.TagName(Tagname));
        }

        public ReadOnlyCollection<IWebElement> ElementsByXpath(string xpath)
        {
            return Browser.Driver.FindElements(By.XPath(xpath));
        }
    }
}
