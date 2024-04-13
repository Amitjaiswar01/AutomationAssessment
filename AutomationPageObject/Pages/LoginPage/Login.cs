using OpenQA.Selenium;
using AutomationCore.Browsers;
using System.Threading;
using AutomationCore.UserLoginData;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPageObject.Pages.LoginPage
{
    public class Login
    {
        private string _usernameId = "UserName";
        private string _passwordId = "Password";
        private string _loginBtnId = "loginBtn";
        private string _adminDashboardClass = "admin-dashboard";

        public Browser Browser { get; set; }
        public Login(Browser browser)
        {
            Browser = browser;
        }

        private IWebElement LoginField => Browser.Locate.ElementById(_usernameId);
        private IWebElement PasswordField => Browser.Locate.ElementById(_passwordId);
        private IWebElement SignInButton => Browser.Locate.ElementById(_loginBtnId);
        private IWebElement AdminDashboardClass => Browser.Locate.ElementByClassName(_adminDashboardClass);

        public void SignIn(string userName, string passcode)
        {
            LoginField.SendKeys(userName);
            PasswordField.SendKeys(passcode);

            SignInButton.Click();
            Browser.Wait.ElementIsVisible(By.ClassName(_adminDashboardClass));
        }

        public bool IsloggedInSucess()
        {
            return Browser.Locate.ElementsByClassName(_adminDashboardClass).Count > 0;
        }
    }
}
