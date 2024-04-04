using NUnit.Framework;
using AutomationCore.TestBases;
using AutomationPageObject.Pages.LoginPage;
using AutomationPageObject.Pages.ReportOverview;
using AutomationPageObject.Pages.TeamMemberDashboard;

namespace AutomationTestCases.TestScenario
{
    internal class VerifyViewLinkFunctionality : TestBase
    {
        [Test]
        public void ViewLinkFunctionality()
        {
            // Arrange: Navigate to Base Url: https://rta-edu-stg-web-03.azurewebsites.net/login
            IntializeFramework();

            // Act: Add the Username & Password
            Login.SignIn("testautomation", "Welcome123");
            //Asserts.True(Login.IsloggedInSucess(), "Account is not logged in");

            /* Act: 
             * Click on Setup from Header
             * Select Manage Team Memebers from Account Setup
            */
            ReportOverview.NaviagteToTeamMemberDashboard();

            // Assert: Verify view link is visible om page
            Asserts.True(MembersDashboard.IsEditLinkVisible, "View Link is not visible on page");

            // Act: Click on Edit Link
            MembersDashboard.SelectViewLink(3);

            // Assert: Verify you are seeing the Edit page
            Asserts.Contains("view", Browser.PageUrl());
        }
    }
}