using NUnit.Framework;
using AutomationCore.TestBases;

namespace AutomationTestCases.Demo
{
    public class VerifyToAddANewMember : TestBase
    {
        [Test]
        public void AddANewMember()
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

            /* Act:
             * Click on Add Team Member button
             * Fill up the user form
             */
            MembersDashboard.SelectAddUserButton();
            MembersDashboard.FillUserForm(new AutomationCore.UserLoginData.UserData());
            MembersDashboard.SelectValueInAssignRoleDropDown(2);

            // Act: Click on Save and Continue button
            MembersDashboard.SelectSaveAndContinueBtn();

            // Assert: User redirect to Team memeber page
            Asserts.Equals(Browser.PageUrl(), teamMemberPageUrl, "User is not redirected to Team member page");
        }
    }
}