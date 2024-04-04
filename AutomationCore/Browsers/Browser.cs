using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationCore.Drivers;
using AutomationCore.WebLocators;

namespace AutomationCore.Browsers
{
    public class Browser
    {
        public IWebDriver Driver { get; set; }
        public IWebElement Element { get; set; }
        public SelectElement Select { get; set; }
        public Locate Locate {  get; set; }
        public WebDriverWait Wait { get; set; }

        public Browser() 
        {
            Driver = new Driver().GetWebDriverInstance();
            Locate = new Locate(this);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
        }

        public bool Waits(IWebElement Element)
        {
             
            return true;//Wait.Until(ExpectedConditions.);
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
