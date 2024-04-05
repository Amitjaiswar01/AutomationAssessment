using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationCore.Drivers;
using AutomationCore.WebLocators;
using AutomationCore.Enums;

namespace AutomationCore.Browsers
{
    public class Browser
    {
        public IWebDriver Driver { get; set; }
        public IWebElement Element { get; set; }
        public SelectElement Select { get; set; }
        public Locate Locate {  get; set; }

        public Browser() 
        {
            Driver = new Driver().GetWebDriverInstance(DriverEnums.chrome.ToString());
            Locate = new Locate(this);
        }

        public void SelectByDropdownByIndex(IWebElement Element, int index) 
        {
            Select = new SelectElement(Element);
            Select.SelectByIndex(index);
        }
        
        public void SelectByDropdownByText(IWebElement Element, string value) 
        {
            Select = new SelectElement(Element);
            Select.SelectByText(value);
        }

        public string PageUrl()
        {
            return Driver.Url;
        }
    }
}
