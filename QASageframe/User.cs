using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
namespace QASageframe
{
    #region
    public class DelUser
    {
        public int N { get; set; }
        public bool ConfirmDel { get; set; }
        public DelUser(int n, bool confirmdel)
        {
            N = n;
            ConfirmDel = confirmdel;
        }
    }
    public class ExportImportUser
    {
        public string Path { get; set; }
        public bool Save { get; set; }
        public ExportImportUser(string path, bool save)
        {
            Path = path;
            Save = save;
        }
    }
    public class SearchUser
    {
        public string UserRole { get; set; }
        public string Rpp { get; set; }
        public string Search { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string FilterMode { get; set; }
        public SearchUser(string userrole, string rpp, string search, DateTime datefrom, DateTime dateto, string filtermode)
        {
            UserRole = userrole;
            Rpp = rpp;
            Search = search;
            DateFrom = datefrom;
            DateTo = dateto;
            FilterMode = filtermode;
        }
    }
    public class EditUser
    {
        public string rolechange { get; set; }
        public bool UserInformationChange { get; set; }
        public bool RoleChange { get; set; }
        public string UserRole { get; set; }
        public int N { get; set; }
        public string Sex { get; set; }
        public string ResPhone { get; set; }
        public string Mobile { get; set; }
        public string Others { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public DateTime BDate { get; set; }
        public string Location { get; set; }
        public string FullName { get; set; }
        public string[] Email { get; set; }
        public bool PasswordChange { get; set; }
        public string NewPassword { get; set; }
        public bool UserProfileChange { get; set; }
        public string ImgPath { get; set; }
        public string AboutMe { get; set; }
        public bool Active { get; set; }
        public EditUser(string roleChange, bool userinformationchange, bool Rolechange, string userrole, int n, string sex, string resphone, string mobile, string others, string fn, string ln, DateTime bdate, string location, string fullname, string[] email, bool passwordchange, string newpassword, bool userprofilechange, string imgpath, string aboutme, bool active)
        {
            rolechange = roleChange;
            UserInformationChange = userinformationchange;
            RoleChange = Rolechange;
            UserRole = userrole;
            N = n;
            Sex = sex;
            ResPhone = resphone;
            Mobile = mobile;
            Others = others;
            FN = fn;
            LN = ln;
            BDate = bdate;
            Location = location;
            FullName = fullname;
            Email = email;
            PasswordChange = passwordchange;
            NewPassword = newpassword;
            UserProfileChange = userprofilechange;
            ImgPath = imgpath;
            AboutMe = aboutme;
            Active = active;
        }
    }
    public class AddUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public string SQuestion { get; set; }
        public string SAnswer { get; set; }
        public string UserRole { get; set; }
        public AddUser(string username, string email, string fname, string lname, string password, string squestion, string sanswer, string userrole)
        {
            UserName = username;
            Email = email;
            FName = fname;
            LName = lname;
            Password = password;
            SQuestion = squestion;
            SAnswer = sanswer;
            UserRole = userrole;
        }
    }
    #endregion
    public static class User
    {
        public static UserPage UserPage
        {
            get
            {
                var userpage = new UserPage();
                PageFactory.InitElements(Browser.Driver, userpage);
                return userpage;
            }
        }
    }
    public class UserPage
    {
        public string Url = "Admin/Users.aspx";
        public string Text = "Users";
        public string UserSuccessMessage = "User has been created successfully.";
        public string UserDeleteMessage = "Selected users have been deleted successfully.";
        public string UserSettingMessage = "Setting has been saved successfully.";
        public string PasswordChange = "User password has been changed successfully.";
        public string UserInfo = "User information has been saved successfully.";
        #region
        //User
        [FindsBy(How = How.Id, Using = "ctl19_txtUserName")][CacheLookup]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtEmail")][CacheLookup]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtFirstName")][CacheLookup]
        public IWebElement FirstName { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtLastName")][CacheLookup]
        public IWebElement LastName { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtPassword")][CacheLookup]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtRetypePassword")][CacheLookup]
        public IWebElement RePassword { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtSecurityQuestion")][CacheLookup]
        public IWebElement SecurityQuestion { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtSecurityAnswer")][CacheLookup]
        public IWebElement SecurityAnswer { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imbCreateUser")][CacheLookup]
        public IWebElement CreateUser { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imbBackinfo")][CacheLookup]
        public IWebElement Cancel { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_fuUserImport")][CacheLookup]
        public IWebElement ImportCSV { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_imgBtnSaveChanges")]
        //public IWebElement UpdateButton { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_imgBtnSettings")]
        //public IWebElement UserSetting { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_chkEnableDupEmail")]
        //public IWebElement DuplicateEmail { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_chkEnableCaptcha")]
        //public IWebElement CaptchaEnable { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_btnSaveSetting")]
        //public IWebElement SaveUserSettings { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_btnCancel")]
        //public IWebElement CancelUserSettings { get; set; }
        //[FindsBy(How = How.Id, Using = "lblImport")]
        //public IWebElement Import { get; set; }
        //[FindsBy(How = How.Id, Using = "lblCancel")]
        //public IWebElement Cancel { get; set; }   
        [FindsBy(How = How.Id, Using = "ctl19_txtSearchText")][CacheLookup]
        public IWebElement SearchText { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtFrom")][CacheLookup]
        public IWebElement DateFromLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtTo")][CacheLookup]
        public IWebElement DateToLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imgSearch")][CacheLookup]
        public IWebElement SearchLink { get; set; }
        //Edit User
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserInfo_txtManageFirstName")][CacheLookup]
        public IWebElement FNEdit { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserInfo_txtManageLastName")][CacheLookup]
        public IWebElement LNEdit { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserInfo_txtManageEmail")][CacheLookup]
        public IWebElement EmailEdit { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserInfo_imgUserInfoSave")][CacheLookup]
        public IWebElement Update { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserPassword_txtNewPassword")][CacheLookup]
        public IWebElement NewPassword { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserPassword_txtRetypeNewPassword")][CacheLookup]
        public IWebElement ReNewPassword { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserPassword_btnManagePasswordSave")][CacheLookup]
        public IWebElement SavePassword { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_btnEdit")][CacheLookup]
        public IWebElement EditProfile { get; set; }
        //UserProfile
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_fuImage")][CacheLookup]
        public IWebElement ProfileImage { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtFName")][CacheLookup]
        public IWebElement ProfileFN { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtLName")][CacheLookup]
        public IWebElement ProfileLN { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtFullName")][CacheLookup]
        public IWebElement ProfileFullN { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtBirthDate")][CacheLookup]
        public IWebElement ProfileBirthDate { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtLocation")][CacheLookup]
        public IWebElement ProfileLocation { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtAboutYou")][CacheLookup]
        public IWebElement AboutYou { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtResPhone")][CacheLookup]
        public IWebElement ResPhone { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtMobile")][CacheLookup]
        public IWebElement Mobile { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_txtOthers")][CacheLookup]
        public IWebElement Others { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_btnSave")][CacheLookup]
        //public IWebElement SaveProfileEdit { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserInfo_chkIsActive")][CacheLookup]
        public IWebElement IsActive { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_pnlUserList")][CacheLookup]
        public IWebElement Id { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lstAvailableRoles")][CacheLookup]
        public IWebElement UserRoles { get; set; }
        //DelUser
        [FindsBy(How = How.Id, Using = "ctl19_gdvUser")][CacheLookup]
        public IWebElement ID { get; set; }
        [FindsBy(How = How.Id, Using = "ui-dialog-buttonset")][CacheLookup]
        public IWebElement Class { get; set; }
        //UserSetting
        [FindsBy(How = How.Id, Using = "ctl19_pnlSettings")][CacheLookup]
        public IWebElement ID1 { get; set; }
        //ExportImportUser
        [FindsBy(How = How.Id, Using = "ctl19_pnlUserImport")][CacheLookup]
        public IWebElement ID2 { get; set; }
        //Search User
        [FindsBy(How = How.Id, Using = "ctl19_ddlSearchRole")][CacheLookup]
        public IWebElement UserRole { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlRecordsPerPage")][CacheLookup]
        public IWebElement Records { get; set; }
        //DateSelect
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-year")]
        public IWebElement YearSelect { get; set; }
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-month")]
        public IWebElement MonthSelect { get; set; }
        //EditUser
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_header")][CacheLookup]
        public IWebElement Id1 { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserRoles_tblUserRolesSettings")][CacheLookup]
        public IWebElement tableId { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_rdbGender")][CacheLookup]
        public IWebElement table { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManageUser_tabUserProfile_tblEditProfile")][CacheLookup]
        public IWebElement table1 { get; set; }
        //FilterMode
        [FindsBy(How = How.Id, Using = "ctl19_rbFilterMode")][CacheLookup]
        public IWebElement ID3 { get; set; }
        //UserTabs
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManageUser_tabUserRoles")]
        public IWebElement UserRolesLink { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManageUser_tabUserInfo")]
        public IWebElement UserInformationLink { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManageUser_tabUserPassword")]
        public IWebElement UserPasswordLink { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManageUser_tabUserProfile")]
        public IWebElement UserProfileLink { get; set; }
        #endregion
        public IList<IWebElement> ReturnButton()
        {
            try
            {
                IList<IWebElement> sfBWP = Id.FindElements(By.TagName("div"));
                IList<IWebElement> Button = sfBWP[0].FindElements(By.TagName("a"));
                return Button;
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }          
        }
        public void AddUser(AddUser AddUser)
        {
            Browser.Wait();
            try
            {
                IList<IWebElement> Button = ReturnButton();
                Button[0].Click();
                Browser.Wait();
                ClearAndFillTextBox UserNameClearNFill = new ClearAndFillTextBox(UserName, AddUser.UserName);
                Browser.ClearAndFillTextBox(UserNameClearNFill);
                ClearAndFillTextBox EmailClearNFill = new ClearAndFillTextBox(Email, AddUser.Email);
                Browser.ClearAndFillTextBox(EmailClearNFill);
                ClearAndFillTextBox FirstNameClearNFill = new ClearAndFillTextBox(FirstName, AddUser.FName);
                Browser.ClearAndFillTextBox(FirstNameClearNFill);
                ClearAndFillTextBox LastNameClearNFill = new ClearAndFillTextBox(LastName, AddUser.LName);
                Browser.ClearAndFillTextBox(LastNameClearNFill);
                ClearAndFillTextBox PasswordClearNFill = new ClearAndFillTextBox(Password, AddUser.Password);
                Browser.ClearAndFillTextBox(PasswordClearNFill);
                ClearAndFillTextBox RePasswordClearNFill = new ClearAndFillTextBox(RePassword, AddUser.Password);
                Browser.ClearAndFillTextBox(RePasswordClearNFill);
                ClearAndFillTextBox SecurityQuestionClearNFill = new ClearAndFillTextBox(SecurityQuestion, AddUser.SQuestion);
                Browser.ClearAndFillTextBox(SecurityQuestionClearNFill);
                ClearAndFillTextBox SecurityAnswerClearNFill = new ClearAndFillTextBox(SecurityAnswer, AddUser.SAnswer);
                Browser.ClearAndFillTextBox(SecurityAnswerClearNFill);
                DropDownSelect UserRoleDropdown = new DropDownSelect(AddUser.UserRole, UserRoles);
                Browser.SelectDropdown(UserRoleDropdown);
                CreateUser.Click();
                IWebElement UpdateMessage = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                IsAt isat = new IsAt(UserSuccessMessage, UpdateMessage.Text);
                Assert.IsTrue(Browser.IsAt(isat)); 
            }
            catch (Exception ex)
            {
                //throw ex;
            }                               
        }              
        public void DelUser(DelUser DelUser)
        {
            Browser.Wait(); 
            try
            {
                IWebElement tbody = ID.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElements(By.TagName("tr"))[DelUser.N];
                IWebElement td = tr.FindElements(By.TagName("td"))[0];
                IWebElement select = td.FindElement(By.TagName("input"));
                select.Click();
                IList<IWebElement> Button = ReturnButton();
                Button[1].Click();
                IList<IWebElement> button = Class.FindElements(By.TagName("button"));
                switch (DelUser.ConfirmDel)
                {
                    case true:
                        {
                            button[0].Click();
                            break;
                        }
                    default:
                        {
                            button[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
        public void UpdateUser()
        {
            try
            {
                IList<IWebElement> UpdateButton = ReturnButton();
                UpdateButton[2].Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }       
        public void UserSetting(bool decide)
        {
            try
            {
                IList<IWebElement> UserSetting = ReturnButton();
                UserSetting[3].Click();
                IWebElement FormWrapper = ID1.FindElements(By.TagName("div"))[0];
                IWebElement table = FormWrapper.FindElement(By.TagName("table"));
                IWebElement tbody = table.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElement(By.TagName("tr"));
                IWebElement td = tr.FindElements(By.TagName("td"))[0];
                IWebElement table1 = td.FindElement(By.TagName("table"));
                IWebElement tbody1 = table1.FindElement(By.TagName("tbody"));
                IWebElement tr1 = tbody1.FindElements(By.TagName("tr"))[1];
                IWebElement td1 = tr1.FindElements(By.TagName("td"))[1];
                IWebElement input = td1.FindElement(By.TagName("input"));
                input.Click();
                IWebElement tr2 = tbody1.FindElements(By.TagName("tr"))[3];
                IWebElement td2 = tr2.FindElements(By.TagName("td"))[1];
                IWebElement input1 = td2.FindElement(By.TagName("input"));
                input1.Click();
                IWebElement ButtonWrapper = ID1.FindElements(By.TagName("div"))[1];
                IWebElement label = ButtonWrapper.FindElement(By.TagName("label"));
                IWebElement Save = label.FindElement(By.TagName("input"));
                IWebElement Cancel = ButtonWrapper.FindElement(By.TagName("a"));
                switch (decide)
                {
                    case true:
                        {
                            Save.Click();
                            break;
                        }
                    default:
                        {
                            Cancel.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }            
        public void ExportImportUser(ExportImportUser ExportImportUser)
        {
            try
            {
                IList<IWebElement> UserSetting = ReturnButton();
                UserSetting[3].Click();
                UserSetting[4].Click();
                Browser.Wait();
                ImportCSV.SendKeys(ExportImportUser.Path);
                IWebElement sfFormWrapper = ID2.FindElement(By.TagName("div"));
                IWebElement table = sfFormWrapper.FindElement(By.TagName("div"));
                IWebElement tbody = table.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElements(By.TagName("tr"))[11];
                IWebElement td = tr.FindElement(By.TagName("td"));
                IList<IWebElement> label = td.FindElements(By.TagName("label"));
                switch (ExportImportUser.Save)
                {
                    case true:
                        {
                            label[0].Click();
                            //Import.Click();
                            break;
                        }
                    default:
                        {
                            //Cancel.Click();
                            label[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }            
        public void Search_User(SearchUser SearchUser)
        {
            Browser.Wait();
            try
            {
                DropDownSelect UserRoleDropdown = new DropDownSelect(SearchUser.UserRole, UserRole);
                DropDownSelect RecordsDropDown = new DropDownSelect(SearchUser.Rpp, Records);
                Browser.SelectDropdown(UserRoleDropdown);
                Browser.Wait();
                Browser.SelectDropdown(RecordsDropDown);
                Browser.Wait();
                switch (SearchUser.FilterMode)
                {
                    case "approved":
                        {
                            FilterMode(1);
                            break;
                        }
                    case "unapproved":
                        {
                            FilterMode(2);
                            break;
                        }
                }
                Browser.Wait();
                ClearAndFillTextBox SearchClearNFill = new ClearAndFillTextBox(SearchText, SearchUser.Search);
                Browser.ClearAndFillTextBox(SearchClearNFill);
                string DateFromYear = SearchUser.DateFrom.Year.ToString();
                string DateFromMonth = (SearchUser.DateFrom.Month - 1).ToString();
                string DateFromDay = SearchUser.DateFrom.Day.ToString();
                string DateToYear = SearchUser.DateTo.Year.ToString();
                string DateToMonth = (SearchUser.DateTo.Month - 1).ToString();
                string DateToDay = SearchUser.DateTo.Day.ToString();
                DateFromLink.Click();
                DropDownSelect DateFromYearSelectDropDown = new DropDownSelect(DateFromYear, YearSelect);
                DropDownSelect DateFromMonthSelectDropDown = new DropDownSelect(DateFromMonth, MonthSelect);
                SelectDate DateFromSelect = new SelectDate(DateFromYearSelectDropDown, DateFromMonthSelectDropDown, DateFromDay);
                Browser.DateSelect(DateFromSelect);
                DateToLink.Click();
                DropDownSelect DateToYearSelectDropDown = new DropDownSelect(DateToYear, YearSelect);
                DropDownSelect DateToMonthSelectDropDown = new DropDownSelect(DateToMonth, MonthSelect);
                SelectDate DateToSelect = new SelectDate(DateToYearSelectDropDown, DateToMonthSelectDropDown, DateToDay);
                Browser.DateSelect(DateToSelect);
                SearchLink.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
        public void FilterMode(int filterno)
        {
            try
            {
                IWebElement tbody = ID3.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElement(By.TagName("tr"));
                IList<IWebElement> td = tr.FindElements(By.TagName("td"));
                IWebElement filter = td[filterno].FindElement(By.TagName("input"));
                filter.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        //public IWebElement GetChangeButton(int n)
        //{
        //    IWebElement span = Id1.FindElements(By.TagName("span"))[n];
        //    IWebElement OuterTab = span.FindElement(By.TagName("span"));
        //    IWebElement InnerTab = OuterTab.FindElement(By.TagName("span"));
        //    IWebElement Tab = InnerTab.FindElement(By.TagName("span"));
        //    IWebElement PC = Tab.FindElement(By.TagName("span"));
        //    return PC;
        //}
        public IWebElement Switch(int n)
        {
            // n:0 for select all :: n:1 for select :: n:2 for unselect :: n:3 for unselect all
            try
            {
                IWebElement tbody2 = tableId.FindElement(By.TagName("tbody"));
                IList<IWebElement> tabletr = tbody2.FindElements(By.TagName("tr"));
                IList<IWebElement> tabletd = tabletr[1].FindElements(By.TagName("td"));
                IList<IWebElement> label = tabletd[1].FindElements(By.TagName("label"));
                return label[n]; 
            }
            catch (Exception ex)
            {
                return null;
              //  throw ex;
            }
        }
        //public string GetMonth(int Month)
        //{
        //    string MonthName;
        //    switch (Month)
        //    {
        //        case 1:
        //            {
        //                MonthName = "Jan";
        //                break;
        //            }
        //        case 2:
        //            {
        //                MonthName = "Feb";
        //                break;
        //            }
        //        case 3:
        //            {
        //                MonthName = "Mar";
        //                break;
        //            }
        //        case 4:
        //            {
        //                MonthName = "Apr";
        //                break;
        //            }
        //        case 5:
        //            {
        //                MonthName = "May";
        //                break;
        //            }
        //        case 6:
        //            {
        //                MonthName = "Jun";
        //                break;
        //            }
        //        case 7:
        //            {
        //                MonthName = "Jul";
        //                break;
        //            }
        //        case 8:
        //            {
        //                MonthName = "Aug";
        //                break;
        //            }
        //        case 9:
        //            {
        //                MonthName = "Sep";
        //                break;
        //            }
        //        case 10:
        //            {
        //                MonthName = "Oct";
        //                break;
        //            }
        //        case 11:
        //            {
        //                MonthName = "Nov";
        //                break;
        //            }
        //        case 12:
        //            {
        //                MonthName = "Dec";
        //                break;
        //            }
        //    }
        //    return MonthName;
        //}      
        public void EditUser(EditUser EditUser)
        {
            try
            {
                IWebElement tbody = ID.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElements(By.TagName("tr"))[EditUser.N + 1];
                IWebElement td = tr.FindElements(By.TagName("td"))[7];
                IWebElement Edit = td.FindElement(By.TagName("a"));
                Edit.Click();
                Browser.Wait();
                if (EditUser.UserInformationChange)
                {
                    UserInformationLink.Click();
                    ClearAndFillTextBox FNEditClearNFill = new ClearAndFillTextBox(FNEdit, EditUser.FN);
                    Browser.ClearAndFillTextBox(FNEditClearNFill);
                    ClearAndFillTextBox LNEditClearNFill = new ClearAndFillTextBox(LNEdit, EditUser.LN);
                    Browser.ClearAndFillTextBox(LNEditClearNFill);
                    ClearAndFillTextBox EmailClearNFill = new ClearAndFillTextBox(EmailEdit, EditUser.Email[0]);
                    Browser.ClearAndFillTextBox(EmailClearNFill);
                    ChkBox ActiveChkBox = new ChkBox(EditUser.Active, IsActive);
                    Browser.CheckBox(ActiveChkBox);
                    //IsActive.Click();
                    Update.Click();
                }
                Browser.Wait();
                if (EditUser.RoleChange)
                {
                    UserRolesLink.Click();
                    switch (EditUser.rolechange)
                    {
                        case "select":
                            IWebElement Selectrole = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserRoles_lstUnselectedRoles"));
                            DropDownSelect SelectRoleDropDown = new DropDownSelect(EditUser.UserRole, Selectrole);
                            Browser.SelectDropdown(SelectRoleDropDown);
                            IWebElement SwitchSelect = Switch(1);
                            SwitchSelect.Click();
                            break;
                        case "unselect":
                            IWebElement unselectrole = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserRoles_lstSelectedRoles"));
                            DropDownSelect UnselectRoleDropDown = new DropDownSelect(EditUser.UserRole, unselectrole);
                            Browser.SelectDropdown(UnselectRoleDropDown);
                            IWebElement SwitchUnselect = Switch(2);
                            SwitchUnselect.Click();
                            break;
                        default:
                            switch (EditUser.rolechange)
                            {
                                case "select all":
                                    {
                                        IWebElement SelectAll = Switch(0);
                                        SelectAll.Click();
                                        break;
                                    }
                                case "unselect all":
                                    {
                                        IWebElement UnselectAll = Switch(3);
                                        UnselectAll.Click();
                                        break;
                                    }
                            }
                            break;
                    }
                    //IList<IWebElement> tabletd1 = tabletr[2].FindElements(By.TagName("td"));
                    //IWebElement BW = tabletd1[1].FindElement(By.TagName("div"));
                    //IWebElement UpdateRole = BW.FindElement(By.TagName("a"));
                    IWebElement UpdateRole = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserRoles_imgManageRoleSave"));
                    UpdateRole.Click();
                }
                if (EditUser.PasswordChange)
                {
                    UserPasswordLink.Click();
                    ClearAndFillTextBox NewPasswordClearNFill = new ClearAndFillTextBox(NewPassword, EditUser.NewPassword);
                    Browser.ClearAndFillTextBox(NewPasswordClearNFill);
                    ClearAndFillTextBox ReNewPasswordClearNFill = new ClearAndFillTextBox(ReNewPassword, EditUser.NewPassword);
                    Browser.ClearAndFillTextBox(ReNewPasswordClearNFill);
                    SavePassword.Click();
                }
                if (EditUser.UserProfileChange)
                {
                    UserProfileLink.Click();
                    EditProfile.Click();
                    Browser.Wait();
                    ProfileImage.SendKeys(EditUser.ImgPath);
                    ClearAndFillTextBox ProfileFNClearNFill = new ClearAndFillTextBox(ProfileFN, EditUser.FN);
                    Browser.ClearAndFillTextBox(ProfileFNClearNFill);
                    ClearAndFillTextBox ProfileLNClearNFill = new ClearAndFillTextBox(ProfileLN, EditUser.LN);
                    Browser.ClearAndFillTextBox(ProfileLNClearNFill);
                    ClearAndFillTextBox ProfileFullNameClearNFill = new ClearAndFillTextBox(ProfileFullN, EditUser.FullName);
                    Browser.ClearAndFillTextBox(ProfileFullNameClearNFill);
                    ProfileBirthDate.Click();
                    string Year = EditUser.BDate.Year.ToString();
                    string Month = (EditUser.BDate.Month - 1).ToString();
                    //string MonthName = GetMonth(Month);
                    string Day = EditUser.BDate.Day.ToString();
                    DropDownSelect YearDropDown = new DropDownSelect(Year, YearSelect);
                    DropDownSelect MonthDropDown = new DropDownSelect(Month, MonthSelect);
                    SelectDate DateSelect = new SelectDate(YearDropDown, MonthDropDown, Day);
                    Browser.DateSelect(DateSelect);
                    //ProfileBirthDate.SendKeys(Convert.ToString(BDate));
                    //IWebElement body = table.FindElement(By.TagName("tbody"));
                    //IWebElement tr1 = body.FindElement(By.TagName("tr"));
                    //IList<IWebElement> td1 = tr1.FindElements(By.TagName("td"));
                    switch (EditUser.Sex)
                    {
                        case "male":
                            {
                                IWebElement male = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserProfile_rdbGender_0"));
                                male.Click();
                                break;
                            }
                        case "female":
                            {
                                IWebElement female = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserProfile_rdbGender_1"));
                                female.Click();
                                break;
                            }
                    }
                    ClearAndFillTextBox ProfileLocationClearNFill = new ClearAndFillTextBox(ProfileLocation, EditUser.Location);
                    Browser.ClearAndFillTextBox(ProfileLocationClearNFill);
                    ClearAndFillTextBox AboutYouClearNFill = new ClearAndFillTextBox(AboutYou, EditUser.AboutMe);
                    Browser.ClearAndFillTextBox(AboutYouClearNFill);
                    for (int i = 0; i < 3; i++)
                    {
                        IWebElement EmailLink = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManageUser_tabUserProfile_txtEmail" + (i + 1).ToString()));
                        ClearAndFillTextBox EmailLinkClearNFill = new ClearAndFillTextBox(EmailLink, EditUser.Email[i]);
                        Browser.ClearAndFillTextBox(EmailLinkClearNFill);
                    }
                    ClearAndFillTextBox ResPhoneClearNFill = new ClearAndFillTextBox(ResPhone, EditUser.ResPhone);
                    Browser.ClearAndFillTextBox(ResPhoneClearNFill);
                    ClearAndFillTextBox MobileClearNFill = new ClearAndFillTextBox(Mobile, EditUser.Mobile);
                    Browser.ClearAndFillTextBox(MobileClearNFill);
                    ClearAndFillTextBox OthersClearNFill = new ClearAndFillTextBox(Others, EditUser.Others);
                    Browser.ClearAndFillTextBox(OthersClearNFill);                   
                    IWebElement tbody1 = table1.FindElement(By.TagName("tbody"));
                    IList<IWebElement> tr2 = tbody1.FindElements(By.TagName("tr"));
                    IWebElement td2 = tr2[18].FindElements(By.TagName("td"))[1];
                    IWebElement rowdiv = td2.FindElement(By.TagName("div"));
                    IWebElement SaveProfileEdit = rowdiv.FindElement(By.TagName("label"));
                    SaveProfileEdit.Click();
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }                             
        }
    }
}
