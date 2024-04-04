using System;

namespace AutomationCore.UserLoginData
{
    public  class UserData
    {
        public string LoginUserName = "testautomation";
        public string LoginPassword = "Welcome123";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string CellPhone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private string dateTime = DateTime.Now.ToString("s");
        public UserData() 
        {
            FirstName = "test";
            LastName = "test";
            EmailId = $"{FirstName}{dateTime}@dispostable.com";
            CellPhone = "1234567890";
            UserName = $"DemoUser{dateTime}";
            Password = "Qwertyuiop!@#$%123";
            ConfirmPassword = "Qwertyuiop!@#$%123";
        }
    }
}
