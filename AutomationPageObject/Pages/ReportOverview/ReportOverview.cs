using AutomationCore.Browsers;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPageObject.Pages.ReportOverview
{
    public class ReportOverview
    {
        private string _navItemClass = "nav-item";
        private string _manageTeamMmembersSelector = "[aria-label='Manage Team Members']";

        public Browser Browser { get; set; }
        public ReportOverview(Browser browser) 
        {
            Browser = browser;
        }

        private IWebElement SetupHeader(int index) => Browser.Locate.ElementsByClassName(_navItemClass)[index];
        private IWebElement ManageTeamMmembersOption => Browser.Locate.ElementBySelector(_manageTeamMmembersSelector);

        public void NaviagteToTeamMemberDashboard()
        {
            Thread.Sleep(2000);
            SetupHeader(4).Click();
            Thread.Sleep(4000);

            ManageTeamMmembersOption.Click();

            Thread.Sleep(4000);
        }
    }
}
