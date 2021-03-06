﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
namespace SageframeTest
{
    [TestClass]
    public class SageFrameWorkFlowTest
    {
        [TestMethod]
        public void TestSageframe()
        {
            //Login
            string Username = "superuser";
            string Password = "superuser";
            //Template
            int n = 0;
            //Template FileEditor
            int Listno = 10;
            int Templateno = 0;
            bool Templatefile = true;
            int EditTemplateno = 1;
            int directoryno = 2;
            string filepath = @"D:\Templating\Fair_Trade_Certified_mark.png";
            //@"E:\Sagever3.6license6-9-2015\SageFrame\css\dd.css";
            bool addfile = true;
            bool deletefile = true;
            bool addfolder = true;
            bool deletefolder = false;
            bool copy = true;
            bool move = false;
            bool refresh = false;
            int fileno = 1;
            string foldername = "test";
            int DeleteTemplateno = 1;
            int deldirectoryno = 1;
            bool confirmdel = false;
            int CTTemplateno = 1;
            int CTdirectoryno = 1;
            int copyfileno = 1;
            int movefileno = 1;
            int MTemplateno = 1;
            int Mdirectoryno = 1;
            bool editfile = true;
            int editfileno = 1;
            string editfilename = "test";
            bool delfile = true;
            int delfileno = 1;
            int editTemplateno = 1;
            int editdirectoryno = 1;
            int delTemplateno = 1;
            int deletedirectoryno = 1;
            bool searchfile = true;
            string searchtext = "shadow";
            bool updateFile = true;
            int updateTemplateno = 0;
            int updatedirectoryno = 0;
            string FileContent = "head{}";
            //Role
            string RoleName = "testrole";
            //PageRole
            int[] roleno = { 1, 2, 3 };
            string PageType = "Portal";
            int[] pagen = { 1, 3, 4, 5 };
            bool[] AnonymousCheckView = { true, true, true, true };
            bool[] AnonymousCheckEdit = { false, false, false, false };
            bool[] AdminCheckView = { true, true, true, true };
            bool[] AdminCheckEdit = { true, true, true, true };
            bool[] RegisteredUserCheckView = { true, true, true, true };
            bool[] RegisteredUserCheckEdit = { true, false, false, true };
            bool[] SavePermission = { true, true, true, true };
            //DashboardRole
            string[] RoleOperation = { "Add", "Remove" };
            bool SaveRole = true;
            string[] SelectRole = { "Registered User", "Site Admin" };
            string[] UnSelectRole = { "Registered User" };
            //User
            string username = "testname";
            string Email = "illusionineyes@gmail.com";
            string Fname = "raj";
            string Lname = "thapa";
            string password = "testpassword";
            string SQuestion = "What is your Hometown?";
            string SAnswer = "Butwal";
            //User Edit            
            string rolechange = "select";
            bool UserInformationChange = true;
            bool RoleChange = true;
            string UserRole = "Site Admin";
            int no = 2 ; 
            string sex = "Male";
            string resphone = "014456789";
            string mobile = "9819445633";
            string others = "This is a test";
            string FN = "test";
            string LN = "test";
            DateTime BDate = new DateTime(2000, 12, 11); 
            string Location = "Gyaneshwor";
            string FullName = "test test";
            string[] NewEmail = { "rthapa@braindigit.com", "anks@gmail.com", "abc@abc.com" };
            bool PasswordChange = true;
            string newpassword = "test";
            bool UserProfileChange = true;
            string ImgPath =  @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg";
            string aboutme = "This is a test!:-D";
            bool Active = true;
            //Page
            //string PageType = "Portal";
            string PageName = "Name";
            string PageTitle = "Title";
            string Description = "Description";
            string KeyWords = "KeyWords";
            string Caption = "Caption";
            string Parent = "Home";
            int RefreshInterval = 10;
            bool DashboardCheck = true;
            bool MenuCheck = true;
            string MenuName = "Main Menu";
            bool[] AnonymousPermission = { true, false };
            bool[] SiteAdminPermission = { true, true };
            bool[] RegisteredUserPermission = { true, true };
            string FilePath = @"D:\Templating\Fair_Trade_Certified_mark.png";
            bool PageSave = true;
            string Layout = "oneColumnLayout";
            bool SaveLayout = true;
            string Mode = "PC";
            bool Publish = true;
            string ModuleID = "68";
            string Section = "Banner";
            string ModuleTitle = "TestModule";
            bool Header = true;
            string HeaderText = "TestHeader";
            string ModuleSuffixClass = "TestSuffixClass";
            bool IsActive = true;
            string ShowInPages = "Customize";
            string[] CustomPages = { "1", "52"};
            string Preferences = "Custom";
            bool DonotShow = false;
            bool Save = true;
            int i = 4;
            bool ParentReq = true;
            //Menu
            string menutype = "Pages";
            bool preservepageorder = false;
            bool selectallpages = false;
            int[] pageno = { 1, 53, 73 };
            bool[] parentpage = { false, false, false };
            string[] parent = {"Home", "Contact", "Home" };
            bool confirmaddtomenu = true;
            string linktitle = "testlinktitle";
            string externallink = "testexternallink";
            string caption = "testcaption";
            string iconpath = @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg"; 
            bool linkactive = true;
            bool linkvisible = true;
            string externallinkparent = "Home";
            bool ParentExternalLink = true;
            string htmlcontenttitle = "testhtmlcontentitle"; 
            string captionhtmlcontent = "testcaptionhtmlcontent";   
            bool htmlcontentvisible = true;
            bool parenthtmlcontent = true;
            string htmlcontentparent = "Home";
            //Module
            string ModulePath = @"E:\Module to test\New folder\AudioPlayer.zip";
            bool[] Next = { true, true, true, true };
            bool AcceptLicense = true;
            bool Install = true;
            //Settings
            //Basic Settings
            string PortalTitle = "www.sageframe.com";
            string PortalDescription = "www.sageframe.com";
            string SettingsKeyWords = "www.sageframe.com";
            string GoogleAdSenseID = "pub-1427651338796450";
            bool ShowProfileLink = true;
            bool EnableCDN = false;
            bool EnableSessionTracker = true;
            bool EnableOptimizationCSS = false; 
            bool EnableOptimizationJs = false;
            bool EnableDashboardLiveFeeds = true;
            bool openidenable = true;
            string FbConsumerKey = "276571315797718";
            string FbSecretKey = "35a35c105f883b3a35953d88e33a3047";
            string LIConsumerKey = "mhziyr2sgko6";
            string LISecretKey = "4p0SoFgdkEuhf277";
            bool SaveBasicSettings = true;
            //Advanced Settings
            string UserRegistration = "None";
            string LoginPage = "Login";
            string PortalDefaultPage = "Home";
            string UserProfilePage = "User Profile";
            string UserRegistrationPage = "User Registration";
            string UserActivationPage = "User Activation";
            string UserForgotPasswordPage = "Forgot Password";
            string PageNotAccessiblePage = "Page Not Accessible";
            string PageNotFoundPage = "Page Not Found";
            string PasswordRecoveryPage = "Password Recovery";
            string MessageSetting = "Default";
            string MessageType = "Success";
            string DefaultLanguage = "English(United States)";
            string LanguageType = "English";
            string PortalTimeZone = "(UTC -12:00) International Dateline West";
            string SiteAdminEmailAddress = "admin@sageframe.com";
            string LogoTemplate = "C-Panel";
            string CopyRight = "Copyright 2015 SageFrame.com. All Rights Reserved®"; 
            bool SaveAdvancedSettings = true;
            //SuperUser Settings
            string SiteTitle = "SageFrame";
            string SiteUrl = "http://www.sageframe.com";
            string SiteEmail = "info@sageframe.com";
            bool CopyrightEnable = true;
            bool CustomError = true;
            string SMTPServerAndPort = "smtp.gmail.com:587";
            bool SMTPBasic = true;
            bool EnableSSL = false;
            string SMTPUserName = "rthapa@braindigit.com";
            string SMTPPassword = "soundgravity123";
            string FileExtensions = "swf#jpg#jpeg#jpe#gif#bmp#png#doc#docx#xls#xlsx#ppt#pptx#pdf#txt#xml#xsl#css#zip#template";
            string HelpUrl = "http://www.sageframe.com";
            string PageExtension = ".aspx";
            string UserAgent = "PC";
            bool EnableScheduler = false;
            string ServerCookieExpirationTime = "100";
            bool SaveSuperUserSettings = true;
            bool TestSMTP = true;
            //Portals
            //Add New Portal
            string PortalName = "test";
            string ParentPortal = "--Select--";
            string PortalUrl = Browser.baseURL + "Admin/Portals/test"; 
            bool SavePortal = true;
            //PortalSettings
            bool view = false; 
            bool edit = true;            
            bool EditPortal = true;
            bool EditModuleManagement = true;
            bool selectAll = false;
            bool[] ModuleList = { true, true };
            int[] ModuleNo = { 19, 20 };
            bool SaveChanges = true;
            int EditPortalno = 2;
            bool delete = true;
            bool ConfirmDelete = true;
            //Links
            bool addsidebaritem = true;
            string SidebarName = "test";
            bool LinkParent = true;
            string ParentLink = "Portals";
            string Page = "Admin";
            string LinkFilePath = @"D:\Free Images\Pearl-Jam-Stickman.png";
            bool IsActiveLink = true; 
            bool addsidebartab = true;
            string TabName = "test";
            bool confirmtabadd = true;
            int linkno = 68;
            bool ExpandSideTab = true; 
            bool DeleteSideTab = false;
            bool EditSideTab = true;
            bool ConfirmDel = false;
            int link = 2;
            string editlinktext = "Users";
            bool editlink = true;
            bool dellink = false; 
            int[] l = { 1, 0 };
            //ModuleMaker
            string ModuleName = "Test";
            string ModuleDescription = "TestDescription";
            string ModuleTableName = "TestTable";
            bool IncludeCss = false;
            bool IncludeJs = true;
            bool IncludeWebservice = true;
            bool EditInclude = true;
            bool SettingInclude = false;
            string ModuleType = "Portal";
            int TotalColumn = 3;
            bool autoincrement = true;
            string[] ColumnName = { "TestID", "Name", "Number" };
            string[] DataType = { "int", "varchar(50)", "bigint" };
            bool[] AllowNull = { true, true };
            int m = 5;
            bool DownloadClassZip = false; 
            bool Back = true;
            //SQL
            bool archivesession = false;
            bool backupdatabase = false;
            bool cleanupscript = false;
            bool UploadFile = true;
            string SQLFilePath = @"C:\Users\RajKumar-PC\Documents\SQL Server Management Studio\test.sql";
            string SqlScript = "";
            bool runasscript = true;
            //System Event StartUp
            string ControlUrl = "Modules/UserRegistration/ctl_UserActivation.ascx";
            string EventLocation = "Top";
            bool IsAdmin = true;
            bool IsControlUrl = true;
            bool IsActiveEvent = true;
            bool confirm = true;
            int EventNo = 1;
            bool EditEvent = true;
            bool DeleteEvent = true;
            bool ConfirmDelEvent = true;
            //Site Analaytics
            string StartDate = "2010/01/01";
            string EndDate = "07/26/2015";
            bool Chart = true;
            bool Data = true;
            bool Date = true;
            bool PageWiseVisit = true;
            string PageAnalytics = "Default";
            bool ExportToPdf = true;
            bool ExportToExcel = true;
            bool Pagination = true;
            string TypeWise = "Page";
            //CDN
            string[] Js = { "testjs1", "testjs2" };
            string[] Css = { "testcss1", "testcss2" };
            string[] NewJs = { "jstest1", "jstest2" };
            string[] NewCss = { "csstest1", "csstest2" };
            bool addjs = true;
            bool addcss = true;
            bool Changelinks = true;
            int CDNLinkno = 2;
            bool sort = true;
            bool CDNDelete = true;
            bool CDNEdit = true;
            bool jsedit = true;
            bool cssedit = true;
            bool up = true;
            bool CDNConfirmDelete = false;
            //Scheduler
            DateTime SchedulerEndDate = new DateTime(2015, 08, 18);
            string AssemblyName = "[QASageFrame.Admin, QASageframe]";
            string TaskName = "test";
            bool Closepopup = true;
            bool EnabledTask = true;
            int Hour = 10; 
            int minute = 20;
            string RepeatMode = "Daily";
            string RetryUnit = "Min";
            int RetryFreq = 10;
            string Event = "APPLICATION_START";
            bool CatchUp = true;
            string SchedulerFilePath = @"C:\Users\RajKumar-PC\Documents\Visual Studio 2013\Projects\QASageframe\QASageframe\bin\Release\nunit.framework.dll";
            int RepeatHours = 1;
            int RepeatMins = 10;
            int RepeatDays = 1;
            string RepeatModeDate = "07/15/2015";
            bool Update = true;
            int taskno = 0;
            bool SchedulerEdit = true;
            bool SchedulerDelete = true;
            bool Schedulerconfirmdelete = false;
            string FileName = "nunit.framework.dll";
            //Event Log
            bool SendEmail = false;
            string LogType = "Mail Error";
            string RecordsPerPage = "10";
            bool ClearLog = true;
            bool DeleteSelectedLogs = true;
            bool ExportLogs = true;
            bool SelectAll = true;
            int[] DeleteLogs = {1, 2};
            bool DeleteIndividual = true;
            string EventLogEmail = "illusionineyes@gmail.com";
            string Subject = "Test";
            string Message = "This is a Test :-D";
            //Cache Maintenance
            int[] CacheClear = { 1, 2 };
            int[] CacheSave = { 1, 2 };
            bool ClearAll = true;
            bool SaveAll = true;
            //SEO
            int[] PageNo = { 1, 2 };
            bool Google = true;
            bool Yahoo = true;
            bool Bing = true;
            bool Msn = true;
            double Priority = 2.0;
            string Frequency = "Always";
            bool Ask = true;
            string GoogleJs = "GoogleJS";
            bool GoogleJsIsActive = true;
            bool GoogleUpdate = true;
            bool Refresh = true;
            //Message Template
            string type = "Activation - Successful Email";
            string email = "anks@gmail.com";
            string subject = "test12";
            string text = "this is a test";
            bool save = true;
            string tmtt = "test123";
            string mttext = "test";
            string token = "test";
            Browser.GoTo(Browser.baseURL + Templates.TemplatePage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
            Admin.AdminPage.LogIn(Username, Password);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Templates.TemplatePage.Text));
            Templates.TemplatePage.SelectTemplate(n);
            Templates.TemplatePage.TemplateFileEditor(Listno, Templateno, Templatefile, EditTemplateno, directoryno, filepath, addfile, deletefile, addfolder, deletefolder, copy, move, refresh, fileno, foldername, DeleteTemplateno, deldirectoryno, confirmdel, CTTemplateno, CTdirectoryno, copyfileno, movefileno, MTemplateno, Mdirectoryno, editfile, editfileno, editfilename, delfile, delfileno, editTemplateno, editdirectoryno, delTemplateno, deletedirectoryno, searchfile, searchtext, updateFile, updateTemplateno, updatedirectoryno, FileContent);
            Browser.GoTo(Browser.baseURL + Role.RolePage.Url);
            Role.RolePage.AddRole(RoleName);
            Role.RolePage.PageRoleSettings(roleno, PageType, pagen, AnonymousCheckView, AnonymousCheckEdit, AdminCheckView, AdminCheckEdit, RegisteredUserCheckView, RegisteredUserCheckEdit, SavePermission);
            Role.RolePage.DashboardRoleSettings(RoleOperation, SaveRole, SelectRole, UnSelectRole);
            Browser.GoTo(Browser.baseURL + User.UserPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
            User.UserPage.AddUser(username, Email, Fname, Lname, password, SQuestion, SAnswer, RoleName);
            User.UserPage.EditUser(rolechange, UserInformationChange, RoleChange, UserRole, no, sex, resphone, mobile, others, FN, LN, BDate, Location, FullName, NewEmail, PasswordChange, newpassword, UserProfileChange, ImgPath, aboutme, Active);
            Browser.GoTo(Browser.baseURL + Pages.PagesClass.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Pages.PagesClass.Text));
            Pages.PagesClass.CreatePage(PageType, PageName, PageTitle, Description, KeyWords, Caption, ParentReq, Parent, RefreshInterval, DashboardCheck, MenuCheck, MenuName, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, PageSave, FilePath);
            Pages.PagesClass.Page(i, Layout, SaveLayout, Mode, Publish, ModuleID, Section, ModuleTitle, Header, HeaderText, ModuleSuffixClass, IsActive, ShowInPages, CustomPages, Preferences, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, DonotShow, Save);
            Browser.GoTo(Browser.baseURL + Menu.MenuPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Menu.MenuPage.Text));
            Menu.MenuPage.MenuType(menutype, preservepageorder, selectallpages, pageno, parentpage, parent, confirmaddtomenu, linktitle, externallink, caption, iconpath, linkactive, linkvisible, externallinkparent, ParentExternalLink, htmlcontenttitle, captionhtmlcontent, htmlcontentvisible, parenthtmlcontent, htmlcontentparent);
            Browser.GoTo(Browser.baseURL + Module.ModulePage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Module.ModulePage.Text));
            Module.ModulePage.Install_Module(ModulePath, Next, AcceptLicense, Install);
            Browser.GoTo(Browser.baseURL + Settings.SettingPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
            Admin.AdminPage.LogIn(Username, Password);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Settings.SettingPage.Text));
            Settings.SettingPage.ChangeBasicSettings(PortalTitle, PortalDescription, SettingsKeyWords, GoogleAdSenseID, ShowProfileLink, EnableCDN, EnableSessionTracker, EnableOptimizationCSS, EnableOptimizationJs, EnableDashboardLiveFeeds, openidenable, FbConsumerKey, FbSecretKey, LIConsumerKey, LISecretKey, SaveBasicSettings);
            Settings.SettingPage.ChangeAdvancedSettings(UserRegistration, LoginPage, PortalDefaultPage, UserProfilePage, UserRegistrationPage, UserActivationPage, UserForgotPasswordPage, PageNotAccessiblePage, PageNotFoundPage, PasswordRecoveryPage, MessageSetting, MessageType, DefaultLanguage, LanguageType, PortalTimeZone, SiteAdminEmailAddress, LogoTemplate, CopyRight, SaveAdvancedSettings);
            Settings.SettingPage.ChangeSuperUserSettings(SiteTitle, SiteUrl, SiteEmail, CopyrightEnable, CustomError, SMTPServerAndPort, SMTPBasic, EnableSSL, SMTPUserName, SMTPPassword, FileExtensions, HelpUrl, PageExtension, UserAgent, EnableScheduler, ServerCookieExpirationTime, SaveSuperUserSettings, TestSMTP);
            Browser.GoTo(Browser.baseURL + Portals.PortalPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Portals.PortalPage.Text));
            Portals.PortalPage.AddNewPoratl(PortalName, ParentPortal, PortalUrl, SavePortal);
            Portals.PortalPage.PortalSettings(view, edit, PortalName, SavePortal, EditPortal, EditModuleManagement, selectAll, ModuleList, ModuleNo, SaveChanges, EditPortalno, delete, ConfirmDelete);
            Browser.GoTo(Browser.baseURL + Links.LinkPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Links.LinkPage.Text));
            Links.LinkPage.LinksOperations(addsidebaritem, SidebarName, LinkParent, ParentLink, Page, LinkFilePath, IsActiveLink, addsidebartab, TabName, confirmtabadd, linkno, ExpandSideTab, DeleteSideTab, EditSideTab, ConfirmDel, link, editlinktext, editlink, dellink, l);
            Browser.GoTo(Browser.baseURL + Module_Maker.Module_MakerPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Module_Maker.Module_MakerPage.Text));
            Module_Maker.Module_MakerPage.CreateModule(ModuleName, ModuleDescription, ModuleTableName, IncludeCss, IncludeJs, IncludeWebservice, EditInclude, SettingInclude, ModuleType, TotalColumn, autoincrement, ColumnName, DataType, AllowNull, m, DownloadClassZip, Back);            
            Browser.GoTo(Browser.baseURL + SQL.SQLPage.Url);
            Admin.AdminPage.LogIn(Username, Password);
            Assert.IsTrue(Browser.IsAt(Browser.Title, SQL.SQLPage.Text));
            SQL.SQLPage.SQLPageFunctions(archivesession, backupdatabase, cleanupscript, UploadFile, SQLFilePath, SqlScript, runasscript);
            Browser.GoTo(Browser.baseURL + System_Event_StartUp.System_Event_StartUpPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, System_Event_StartUp.System_Event_StartUpPage.Text));
            System_Event_StartUp.System_Event_StartUpPage.Add_Event_StartUp(ControlUrl, EventLocation, IsAdmin, IsControlUrl, IsActiveEvent, confirm);
            System_Event_StartUp.System_Event_StartUpPage.EventListManagement(EventNo, EditEvent, DeleteEvent, ControlUrl, EventLocation, IsAdmin, IsControlUrl, IsActiveEvent, confirm, ConfirmDelEvent);            
            Browser.GoTo(Browser.baseURL + SiteAnalytics.SiteAnalyticsPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, SiteAnalytics.SiteAnalyticsPage.Text));
            SiteAnalytics.SiteAnalyticsPage.SiteAnalytics(Chart, Data, Date, StartDate, EndDate, PageWiseVisit, PageAnalytics, ExportToPdf, ExportToExcel, Pagination, TypeWise);
            Browser.GoTo(Browser.baseURL + CDN.CDNPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, CDN.CDNPage.Text));
            CDN.CDNPage.CDNChanges(addjs, Js, addcss, Css, Changelinks, CDNLinkno, sort, CDNDelete, CDNEdit, jsedit, cssedit, NewJs, NewCss, up, CDNConfirmDelete);
            Browser.GoTo(Browser.baseURL + Event_Log.EventLogPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Event_Log.EventLogPage.Text));
            Event_Log.EventLogPage.EventLogOperations(SendEmail, LogType, RecordsPerPage, ClearLog, DeleteSelectedLogs, ExportLogs, SelectAll, DeleteLogs, DeleteIndividual, EventLogEmail, Subject, Message);
            Browser.GoTo(Browser.baseURL + CacheMaintenance.CacheMaintenancePage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, CacheMaintenance.CacheMaintenancePage.Text));
            CacheMaintenance.CacheMaintenancePage.CacheSettings(CacheClear, ClearAll, SaveAll, CacheSave);
            Browser.GoTo(Browser.baseURL + SEO.SEOpage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, SEO.SEOpage.Text));
            SEO.SEOpage.GenerateRobots(Google, Yahoo, Bing, Msn, PageNo);
            SEO.SEOpage.GenerateSiteMap(Priority, Frequency, Google, Yahoo, Bing, Ask);
            SEO.SEOpage.AddGoogleJs(GoogleJs, GoogleJsIsActive, GoogleUpdate, Refresh);
            Browser.GoTo(Browser.baseURL + Message_Template.MessageTemplatePage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Message_Template.MessageTemplatePage.Text));
            Message_Template.MessageTemplatePage.AddMT(type, email, subject, text, save, tmtt, mttext, token);
            Browser.GoTo(Browser.baseURL + Scheduler.SchedulerPage.Url);
            Assert.IsTrue(Browser.IsAt(Browser.Title, Scheduler.SchedulerPage.Text));
            Scheduler.SchedulerPage.AddNewTask(TaskName, Closepopup, AssemblyName, EnabledTask, Hour, minute, RepeatMode, RetryUnit, RetryFreq, Event, CatchUp, SchedulerFilePath, SchedulerEndDate,  RepeatHours, RepeatMins, RepeatDays, RepeatModeDate, Update, FileName);
            Scheduler.SchedulerPage.EditDelete(taskno, SchedulerEdit, SchedulerDelete, Schedulerconfirmdelete); 
            Browser.Teardown();
        }
    }
}
