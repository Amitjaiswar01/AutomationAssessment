using NUnit.Framework;
using AutomationCore.TestBases;
using AutomationPageObject.Pages.LoginPage;
using AutomationPageObject.Pages.ReportOverview;
using AutomationPageObject.Pages.TeamMemberDashboard;
using System.Threading;

namespace AutomationTestCases.TestScenario
{
    internal class VerifyEditLinkFunctionality : TestBase
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
            var teamMemberPageUrl = "https://rta-edu-stg-web-03.azurewebsites.net/core/setup/team-members";

            // Assert: Verify view link is visible om page
            Asserts.True(MembersDashboard.IsEditLinkVisible, "View Link is not visible on page");

            // Act: Click on Edit Link
            MembersDashboard.SelectEditLink(1);

            // Assert: Verify you are seeing the Edit page
            Asserts.Contains("edit", Browser.PageUrl());

            /* Act: 
             * Click on Delete Button on the page
             * Click on Delete button on the modal
            */
            MembersDashboard.SelectDeleteBtn();
            Thread.Sleep(5000);

            // Assert: User redirect to Team memeber page
            Asserts.Equals(Browser.PageUrl(), teamMemberPageUrl, "User is not redirected to Team member page");
        }
    }
}