using System.Threading;
using OpenQA.Selenium;
using AutomationCore.Browsers;
using AutomationCore.UserLoginData;
using System.Collections.ObjectModel;
using OpenQA.Selenium.DevTools.V121.Memory;

namespace AutomationPageObject.Pages.TeamMemberDashboard
{
    public class MembersDashboard
    {
        private string _rtaIconClass = "rta-icon";
        private string _firstNameId = "firstName";
        private string _lastNameId = "lastName";
        private string _emailId = "email";
        private string _cellPhoneId = "cellPhone";
        private string _usernameId = "username";
        private string _passwordId = "password";
        private string _confirmPasswordId = "confirmPassword";
        private string _btnIconLeftClass = "btn-icon-left";
        private string _btnSuccessClass = "btn-success";
        private string _memberRoleSelectionId = "memberRoleSelection";
        private string _viewLinkXpath = "//div[contains(text(),'View')]";
        private string _editLinkXpath = "//div[contains(text(),'Edit')]";
        private string _deleteXpath = "//button[contains(text(),'Delete')]";
        private string _deleteModalClass = "modal-body";
        private string _modalDeleteBtnClass = "btn-danger";

        public Browser Browser { get; set; }
        public MembersDashboard(Browser browser)
        {
            Browser = browser;
        }

        private IWebElement AddMemberBtn => Browser.Locate.ElementByClassName(_rtaIconClass);
        private IWebElement FirstName => Browser.Locate.ElementById(_firstNameId);
        private IWebElement LastName => Browser.Locate.ElementById(_lastNameId);
        private IWebElement EmailId => Browser.Locate.ElementById(_emailId);
        private IWebElement PhoneNumber => Browser.Locate.ElementById(_cellPhoneId);
        private IWebElement Username => Browser.Locate.ElementById(_usernameId);
        private IWebElement Password => Browser.Locate.ElementById(_passwordId);
        private IWebElement ConfirmPassword => Browser.Locate.ElementById(_confirmPasswordId);
        private IWebElement SaveAndContinue => Browser.Locate.ElementByClassName(_btnIconLeftClass);
        private IWebElement SuccessBtn => Browser.Locate.ElementByClassName(_btnSuccessClass);
        private IWebElement DeleteBtn => Browser.Locate.ElementByXpath(_deleteXpath);
        private IWebElement DeleteModal => Browser.Locate.ElementByClassName(_deleteModalClass);
        private IWebElement DeleteBtnOnMoodal => Browser.Locate.ElementByClassName(_modalDeleteBtnClass);
        private IWebElement AssignRoleDropdownMenu => Browser.Locate.ElementById(_memberRoleSelectionId);
        private ReadOnlyCollection<IWebElement> ListOfViewLink => Browser.Locate.ElementsByXpath(_viewLinkXpath);
        private ReadOnlyCollection<IWebElement> ListOfEditLink => Browser.Locate.ElementsByXpath(_editLinkXpath);


        public bool IsViewLinkVisible => ListOfViewLink.Count > 0;
        public bool IsEditLinkVisible => ListOfEditLink.Count > 0;

        public void SelectAddUserButton()
        {
            Thread.Sleep(7000);
            AddMemberBtn.Click();
        }

        public void FillUserForm(UserData data)
        {
            Thread.Sleep(8000);

            FirstName.Clear();
            FirstName.SendKeys(data.FirstName);

            LastName.Clear();
            LastName.SendKeys(data.LastName);

            EmailId.Clear();
            EmailId.SendKeys(data.EmailId);

            PhoneNumber.Clear();
            PhoneNumber.SendKeys(data.CellPhone);

            Username.Clear();
            Username.SendKeys(data.UserName);

            Password.Clear();
            Password.SendKeys(data.Password);

            ConfirmPassword.Clear();
            ConfirmPassword.SendKeys(data.ConfirmPassword);
        }

        public void SelectSaveAndContinueBtn()
        {
            SaveAndContinue.Click();
            Thread.Sleep(5000);
        }
        
        public void SelectAssignStudentBtn()
        {
            SuccessBtn.Click();
            Thread.Sleep(5000);
        }

        public void SelectValueInAssignRoleDropDown(int index)
        {
            Browser.SelectByDropdownByIndex(AssignRoleDropdownMenu, index);
        }
        
        public void SelectViewLink(int index)
        {
            Thread.Sleep(2000);
            ListOfViewLink[index].Click();
        }
        
        public void SelectEditLink(int index)
        {
            Thread.Sleep(2000);
            ListOfEditLink[index].Click();
        }
        
        public void SelectDeleteBtn()
        {
            Thread.Sleep(6000);
            DeleteBtn.Click();
        }
        
        public void SelectDeleteBtnOnModal()
        {
            Thread.Sleep(5000);

            if (DeleteModal.Displayed)
            {
                DeleteBtnOnMoodal.Click();
            }
        }
    }
}
