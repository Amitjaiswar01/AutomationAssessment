using AutomationCore.TestBases;
using NUnit.Framework;

namespace AutomationTestCases.TestScenario
{
    public class VerifyLoggedInFunctionality : TestBase
    {
        [Test]
        public void LoggedInFunctionality()
        {
            // Arrange: Navigate to Base Url: https://rta-edu-stg-web-03.azurewebsites.net/login
            IntializeFramework();

            // Act: Add the Username & Password
            Login.SignIn("testautomation", "Welcome123");

            // Assert: Verify user successfully logged in
            Asserts.True(Login.IsloggedInSucess(), "Account is not logged in");
        }
    }
}