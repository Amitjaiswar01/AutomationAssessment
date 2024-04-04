using NUnit.Framework;
using AutomationCore.Browsers;
using AutomationCore.TestBases;
using AutomationPageObject.Pages.LoginPage;
using AutomationPageObject.Pages.ReportOverview;
using AutomationPageObject.Pages.TeamMemberDashboard;

namespace AutomationTestCases.TestScenario
{
    public class VerifyUserSuccessfullyRedirectToAssignStudent : TestBase
    {
        [Test]
        public void SuccessfullyRedirectToAssignStudent()
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
            var assignMemberPageUrl = "https://rta-edu-stg-web-03.azurewebsites.net/core/setup/team-members/assign-students/";

            /* Act:
             * Click on Add Team Member button
             * Fill up the user form
             */
            MembersDashboard.SelectAddUserButton();
            MembersDashboard.FillUserForm(new AutomationCore.UserLoginData.UserData());
            MembersDashboard.SelectValueInAssignRoleDropDown(2);

            // Act: Click on Save and Continue button
            MembersDashboard.SelectAssignStudentBtn();

            // Assert: User redirect to Team memeber page
            Asserts.Equals("assign-students/", assignMemberPageUrl, "User is not redirected to Team member page");
        }
    }
}