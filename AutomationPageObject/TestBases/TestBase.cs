using System;
using AutomationCore.Asserts;
using AutomationCore.Browsers;
using AutomationCore.WebLocators;
using AutomationPageObject.Pages.LoginPage;
using AutomationPageObject.Pages.ReportOverview;
using AutomationPageObject.Pages.TeamMemberDashboard;

namespace AutomationCore.TestBases
{
    public class TestBase : IDisposable
    {
        public Browser Browser { get; set; }
        public Locate Locate { get; set; }
        public Login Login { get; set; }
        public ReportOverview ReportOverview { get; set; }
        public MembersDashboard MembersDashboard { get; set; }
        public Assert Asserts { get; set; }

        public TestBase() 
        {
            Browser = new Browser();
            Locate = new Locate(Browser);
            Login = new Login(Browser);
            ReportOverview = new ReportOverview(Browser);
            MembersDashboard = new MembersDashboard(Browser);
            Asserts = new Assert();
        }

        public void IntializeFramework()
        {
            Browser.Driver.Navigate().GoToUrl("https://rta-edu-stg-web-03.azurewebsites.net/login");
            Browser.Driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            Browser.Driver.Quit();
        }
    }
}
