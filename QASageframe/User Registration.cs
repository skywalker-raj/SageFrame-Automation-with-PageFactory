using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
namespace QASageframe
{
    #region
    public class RegisterUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Register { get; set; }
        public RegisterUser(string firstname, string lastname, string username, string email, string password, bool register)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            Email = email;
            Password = password;
            Register = register;
        }
    }
    #endregion
    public static class User_Registration
    {
        public static User_RegistrationPage User_RegistrationPage
        {
            get
            {
                var user_registrationpage = new User_RegistrationPage();
                PageFactory.InitElements(Browser.Driver, user_registrationpage);
                return user_registrationpage;
            }
        }
    }
    public class User_RegistrationPage
    {
        public string Url = "sf/sfUser-Registration.aspx";
        public string Text = "User Registration";
        #region
        [FindsBy(How = How.Id, Using = "ctl14_FirstName")]
        public IWebElement FirstNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_LastName")]
        public IWebElement LastNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_UserName")]
        public IWebElement UserNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_Email")]
        public IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_Password")]
        public IWebElement PasswordTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_ConfirmPassword")]
        public IWebElement ConfirmPasswordTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_FinishButton")]
        public IWebElement RegisterButton { get; set; }
        [FindsBy(How = How.Id, Using = "hypPreview")]
        public IWebElement BackToHomeButton { get; set; }
        #endregion       
        public void RegisterUser(RegisterUser RegisterUser)
        {
            try
            {
                ClearAndFillTextBox FirstNameClearNFill = new ClearAndFillTextBox(FirstNameTextBox, RegisterUser.FirstName);
                Browser.ClearAndFillTextBox(FirstNameClearNFill);
                ClearAndFillTextBox LastNameClearNFill = new ClearAndFillTextBox(LastNameTextBox, RegisterUser.LastName);
                Browser.ClearAndFillTextBox(LastNameClearNFill);
                ClearAndFillTextBox UserNameClearNFill = new ClearAndFillTextBox(UserNameTextBox, RegisterUser.UserName);
                Browser.ClearAndFillTextBox(UserNameClearNFill);
                ClearAndFillTextBox EmailClearNFill = new ClearAndFillTextBox(EmailTextBox, RegisterUser.Email);
                Browser.ClearAndFillTextBox(EmailClearNFill);
                ClearAndFillTextBox PasswordClearNFill = new ClearAndFillTextBox(PasswordTextBox, RegisterUser.Password);
                Browser.ClearAndFillTextBox(PasswordClearNFill);
                ClearAndFillTextBox ConfirmPasswordClearNFill = new ClearAndFillTextBox(ConfirmPasswordTextBox, RegisterUser.Password);
                Browser.ClearAndFillTextBox(ConfirmPasswordClearNFill);
                switch (RegisterUser.Register)
                {
                    case true:
                        {
                            RegisterButton.Click();
                            break;
                        }
                    default:
                        {
                            BackToHomeButton.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
