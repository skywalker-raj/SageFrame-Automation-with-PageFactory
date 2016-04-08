using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Windows.Forms;
namespace QASageframe
{
    public static class Admin
    {
        public static AdminPage AdminPage
        {
            get
            {
                var adminpage = new AdminPage();
                PageFactory.InitElements(Browser.Driver, adminpage);
                return adminpage;
            }
        }
    }
    #region
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
    #endregion
    public class AdminPage
    {
        public string Url = "Admin/Admin.aspx";
        public string Title = "Admin";
        //public By startButton = By.CssSelector("#start button");
        #region
        [FindsBy(How = How.Id, Using = "ctl16_lblUdpSageMesageCustom")]
        public IWebElement UpdateMessage { get; set; }

        [FindsBy(How = How.Id, Using = "hypPreview")]
        public IWebElement BackHomeLink { get; set; }
        //Login
        [FindsBy(How = How.Id, Using = "ctl14_Password")][CacheLookup]
        public IWebElement PasswordLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_LoginButton")][CacheLookup]
        public IWebElement LoginLink { get; set; }
        //Forgot Password
        [FindsBy(How = How.Id, Using = "ctl14_hypForgotPassword")][CacheLookup]
        public IWebElement FPWLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_wzdForgotPassword_txtUsername")][CacheLookup]
        public IWebElement FPWUserNameLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_wzdForgotPassword_CaptchaValue")][CacheLookup]
        public IWebElement FPWCaptchaLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_wzdForgotPassword_StartNavigationTemplateContainerID_StartNextButton")][CacheLookup]
        public IWebElement FPWNextLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl14_wzdForgotPassword_StartNavigationTemplateContainerID_CancelButton")][CacheLookup]
        public IWebElement FPWCancelLink { get; set; }
        [FindsBy(How = How.Id, Using = "sfToppane")][CacheLookup]
        public IWebElement TopPane { get; set; }
        [FindsBy(How = How.Id, Using = "sidebar")][CacheLookup]
        public IWebElement sidebar { get; set; }
        //Role
        //[FindsBy(How = How.Id, Using = "ctl19_rptDashBoard_ctl01_hypPageURL")]
        //public IWebElement Role { get; set; }       
        //User
        //[FindsBy(How = How.Id, Using = "ctl19_rptDashBoard_ctl02_hypPageURL")]
        //public IWebElement User { get; set; } 
        #endregion
        public void LogIn(Login Login)
        {
            try
            {
                IsAt isat = new IsAt(Browser.Title, Browser.LoginTitle);
                WaitForElement wait = new WaitForElement(By.Id("ctl14_UserName"), 15);
                Assert.IsTrue(Browser.IsAt(isat));
                IWebElement UserNameLink = Browser.WaitForElement(wait);
                ClearAndFillTextBox UsernameClearNFill = new ClearAndFillTextBox(UserNameLink, Login.Username);
                Browser.ClearAndFillTextBox(UsernameClearNFill);
                ClearAndFillTextBox PasswordClearNFill = new ClearAndFillTextBox(PasswordLink, Login.Password);
                Browser.ClearAndFillTextBox(PasswordClearNFill);
Login:          LoginLink.Click();
                IWebElement ErrorMessage = Browser.Driver.FindElement(By.ClassName("sfError"));
                string ErrorMsg = ErrorMessage.Text;
                switch (ErrorMsg)
                {
                    case "User does not exist!":
                        {
                            MessageBox.Show("Invalid User");
                            break;
                        }
                    case "Username and password combination didn't match!":
                        {
                            MessageBox.Show("Invalid Password");
                            break;
                        }
                }
                Browser.SwitchToAlert(true);
                goto Login;
            }
            catch (Exception ex)
            {               
                throw ex;
            }
        }        
        public void GetLink(int n)
        {
            try
            {
                //sidebar
                IWebElement menu = sidebar.FindElement(By.TagName("ul"));
                IWebElement GrandParentsfLevel0 = menu.FindElement(By.TagName("li"));
                IWebElement acitem = GrandParentsfLevel0.FindElement(By.TagName("ul"));
                IList<IWebElement> parentsfLevel1 = acitem.FindElements(By.TagName("li"));
                IWebElement UserAccounts = parentsfLevel1[0].FindElement(By.TagName("a"));
                UserAccounts.Click();
                IWebElement acitem2 = parentsfLevel1[0].FindElement(By.TagName("ul"));
                IList<IWebElement> childsfLevel2 = acitem.FindElements(By.TagName("li"));
                IWebElement Link = childsfLevel2[n].FindElement(By.TagName("a"));                
                //TopPane
                //IWebElement Div = TopPane.FindElement(By.TagName("div"));
                //IWebElement sfModuleContent = Div.FindElement(By.TagName("div"));
                //IList<IWebElement> Dashboard = sfModuleContent.FindElements(By.TagName("div"));
                //IWebElement List = Dashboard[0].FindElement(By.TagName("ul"));
                //IList<IWebElement> Links = List.FindElements(By.TagName("li"));
                //IWebElement Link = Links[n].FindElement(By.TagName("a"));
                Link.Click();
                Browser.Wait();
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }
        public void Roles()
        {            
            //sidebar
            try
            {
                //2:sidebar and 0:TopPane
                GetLink(2);                
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }
        public void Users()
        {   //sidebar
            try
            {
                //1:sidebar/TopPane
                //IWebElement sidebar = Browser.Driver.FindElement(By.Id("sidebar"));
                GetLink(1);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        public void Logout()
        {
            try
            {
                IWebElement LogoutDDown = Browser.Driver.FindElement(By.ClassName("myProfile"));
                LogoutDDown.Click();
                IWebElement LogoutLink = Browser.Driver.FindElement(By.Id("LoginStatus1_lnkloginStatus"));
                LogoutLink.Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }
    }
}
