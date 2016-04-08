using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using QASageframe;
namespace SageframeTest
{
    //public class Login
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public Login(string username, string password)
    //    {
    //        this.Username = username;
    //        this.Password = password;
    //    }
    //}
    [TestClass]
    public class SageFrameTest
    {
        public static class TestResults
        {
            public static int Pass = 0;
            public static int Fail = 0;
            public static string[] ErrorException;
        }
        //public static TestResults Results
        //{
        //    get
        //    {
        //        TestResults results = new TestResults();
        //        return results;
        //    }
        //}
        //[Timeout(10000)]
        //[Test, TestCase("logincreds")]
        //[Test, TestCase("superuser", "superuser", Result = true)]
        //public void LoginOperation([Values("superuser", "admin")]string Username,[Values("superuser", "admin")]string Password)
        //[Test, TestCaseSource("logincreds")]
        //public void LoginOperation(string Username, string Password)
        //[TestCase("superuser", "superuser")]
        //public void LoginOperation([Values("superuser", "admin")]string Username,[Values("superuser", "admin")]string Password)
        [TestMethod]
        public void LoginOperation()
        {
            Login Login = new Login("superuser", "superuser");
            IsAt isat = new IsAt(Browser.Title, Browser.LoginTitle);
            IsAt adminisat = new IsAt(Browser.Title, Admin.AdminPage.Title);
            try
            {
                Browser.GoTo(Admin.AdminPage.Url);
                Assert.IsTrue(Browser.IsAt(isat));
                Browser.CheckBrokenImages();
                Admin.AdminPage.LogIn(Login);
                Assert.IsTrue(Browser.IsAt(adminisat));
                Admin.AdminPage.Logout();                
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[22] = ex.ToString();
                TestResults.Fail++;
            }
        }
        //[Priority(2)]
        [TestMethod]
        public void TemplateOperation()
        {
            //Template
            int n = 0;
            //Template FileEditor
            int Listno = 10;
            int Templateno = 0;
            bool Templatefile = true;
            int EditTemplateno = 1;
            int directoryno = 2;
            string filepath = @"D:\snips\Templating\Fair_Trade_Certified_mark.png";
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
            //Preset 
            int[] Page = { 1, 52, 53 };
            bool preset = true;
            bool presetcustomize = true;
            int layoutno = 1;
            string presettype = "Custom";
            int widthno = 1;
            bool confirmpresetsave = true;
            //Layout
            string placeholder = "<placeholder name=\"test\" wrapinner=\"0\">test</placeholder>";
            string[] split = { "sfNavigation", "sfLogo", "sfGetstarted", "sfMainWrapper" };
            string[] splitlinkid = { "split_sfheaders_mytable", "split_sfbanner_mytable", "split_sfnavigation_mytable", "split_sffulltopspan_mytable", "split_sfmiddlemaincurrent_mytable", "split_sffooter_mytable" };
            string[] SplitLink = { "btnSplit_sfheaders_mytable", "btnSplit_sfbanner_mytable", "btnSplit_sfnavigation_mytable", "btnSplit_sffulltopspan_mytable", "btnSplit_sfmiddlemainbottom_mytable", "btnSplit_sffooter_mytable" };
            string layout = "handheld";
            bool LayoutEdit = true;
            bool LayoutManager = true;
            bool LayoutPreset = true;
            bool Pages = true;
            bool createlayout = true;
            string CloneLayout = "Contact";
            string NewLayoutName = "testLayout";
            bool LayoutDelete = true;
            bool confirmDelete = false;
            bool layoutedit = true;
            bool confirmSave = false;
            TemplateFileEditor TemplateFileEditor = new TemplateFileEditor(Listno, Templateno, Templatefile, EditTemplateno, directoryno, filepath, addfile, deletefile, addfolder, deletefolder, copy, move, refresh, fileno, foldername, DeleteTemplateno, deldirectoryno, confirmdel, CTTemplateno, CTdirectoryno, copyfileno, movefileno, MTemplateno, Mdirectoryno, editfile, editfileno, editfilename, delfile, delfileno, editTemplateno, editdirectoryno, delTemplateno, deletedirectoryno, searchfile, searchtext, updateFile, updateTemplateno, updatedirectoryno, FileContent);
            Layout Layout = new Layout(Templateno, LayoutEdit, LayoutManager, LayoutPreset, Pages, layout, createlayout, CloneLayout, NewLayoutName, placeholder, LayoutDelete, confirmDelete, layoutedit, split, SplitLink, confirmSave);
            Preset Preset = new Preset(Templateno, preset, presetcustomize, layoutno, presettype, Page, widthno, confirmpresetsave);
            try
            {
                LoginOperation();
                Browser.GoTo(Templates.TemplatePage.Url);
                Templates.TemplatePage.SelectTemplate(n);
                Templates.TemplatePage.TemplateFileEditor(TemplateFileEditor);
                Browser.GoTo(Templates.TemplatePage.Url);
                Templates.TemplatePage.Layout(Layout);
                Browser.GoTo(Templates.TemplatePage.Url);
                Templates.TemplatePage.Preset(Preset);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch(Exception ex)
            {
                TestResults.ErrorException[0] = ex.ToString();
                TestResults.Fail++;
            }
        }
        //[Priority(3)]
        [TestMethod]
        public void RoleOperation()
        {
            //Role
            string RoleName = "testrole";
            //Del Role
            int delrole = 1;
            bool ConfirmDelete = true;
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
            IsAt isat = new IsAt(Browser.Title, Role.RolePage.Title);
            DelRole DelRole = new DelRole(delrole, ConfirmDelete);
            DashboardRoleSettings DashboardRoleSettings = new DashboardRoleSettings(RoleOperation, SaveRole, SelectRole, UnSelectRole);
            PageRoleSettings PageRoleSettings = new PageRoleSettings(roleno, PageType, pagen, AnonymousCheckView, AnonymousCheckEdit, AdminCheckView, AdminCheckEdit, RegisteredUserCheckView, RegisteredUserCheckEdit, SavePermission);
            try
            {
                Browser.GoTo(Role.RolePage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Role.RolePage.AddRole(RoleName);
                Role.RolePage.PageRoleSettings(PageRoleSettings);
                Role.RolePage.DashboardRoleSettings(DashboardRoleSettings);
                Role.RolePage.DelRole(DelRole);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[1] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(4)]
        [TestMethod]
        public void UserOperation()
        {
            //User
            string username = "testname";
            string Email = "illusionineyes@gmail.com";
            string Fname = "raj";
            string Lname = "thapa";
            string password = "testpassword";
            string SQuestion = "What is your Hometown?";
            string SAnswer = "Butwal";
            //User Edit      
            string RoleName = "testrole";
            string rolechange = "select";
            bool UserInformationChange = true;
            bool RoleChange = true;
            string UserRole = "testrole";
            int no = 2;
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
            string ImgPath = @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg";
            string aboutme = "This is a test!:-D";
            bool Active = true;
            int userno = 2;
            bool confirmdel = false;
            bool Setting = true;
            //Search User
            DateTime Datefrom = new DateTime(2014, 12, 11);
            DateTime Dateto = new DateTime(2014, 12, 14);
            string filtermode = "approved";
            string userrole = "Super User";
            string rpp = "25";
            string search = "test";
            IsAt isat = new IsAt(Browser.Title, User.UserPage.Text);
            AddUser AddUser = new AddUser(username, Email, Fname, Lname, password, SQuestion, SAnswer, RoleName);
            EditUser EditUser = new EditUser(rolechange, UserInformationChange, RoleChange, UserRole, no, sex, resphone, mobile, others, FN, LN, BDate, Location, FullName, NewEmail, PasswordChange, newpassword, UserProfileChange, ImgPath, aboutme, Active);
            SearchUser SearchUser = new SearchUser(userrole, rpp, search, Datefrom, Dateto, filtermode);
            DelUser DelUser = new DelUser(userno, confirmdel);
            try
            {
                Browser.GoTo(User.UserPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                User.UserPage.AddUser(AddUser);
                User.UserPage.EditUser(EditUser);
                User.UserPage.Search_User(SearchUser);
                User.UserPage.DelUser(DelUser);
                User.UserPage.UserSetting(Setting);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[2] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(5)]
        [TestMethod]
        public void PageOperation()
        {
            //Page
            string PageType = "Portal";
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
            string FilePath = @"D:\snips\Templating\Fair_Trade_Certified_mark.png";
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
            string[] CustomPages = { "1", "52" };
            string Preferences = "Custom";
            bool DonotShow = false;
            bool Save = true;
            int i = 4;
            bool ParentReq = true;
            string Operation = "Edit";
            int n = 3;
            bool DeleteConfirm = false;
            IsAt isat = new IsAt(Browser.Title, Pages.PagesClass.Text);
            FillPage FillPage = new FillPage(PageType, PageName, PageTitle, Description, KeyWords, Caption, ParentReq, Parent, RefreshInterval, DashboardCheck, MenuCheck, MenuName, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, PageSave, FilePath);
            ModuleDetails ModuleDetails = new ModuleDetails(ModuleTitle, Header, HeaderText, ModuleSuffixClass, IsActive, ShowInPages, CustomPages, Preferences, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, DonotShow, Save);
            Page Page = new Page(i, Layout, SaveLayout, Mode, Publish, ModuleID, Section, ModuleDetails);
            PageManagement PageManagement = new PageManagement(Operation, n, FillPage, DeleteConfirm);
            try
            {
                Browser.GoTo(Pages.PagesClass.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Pages.PagesClass.CreatePage(FillPage);
                Pages.PagesClass.Page(Page);
                Pages.PagesClass.PageManagement(PageManagement);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[3] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(6)]
        [TestMethod]
        public void MenuOperation()
        {
            //Menu
            string menutype = "Pages";
            bool preservepageorder = false;
            bool selectallpages = false;
            int[] pageno = { 1, 53, 73 };
            bool[] parentpage = { false, false, false };
            string[] parent = { "Home", "Contact", "Home" };
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
            string subtext = "test";
            bool isactive = true;
            bool isvisible = true;
            bool confirmUpdate = true;
            bool ChangeSettings = true;
            int menuno = 0;
            int menustyle = 1;
            bool showimage = true;
            bool showtext = true;
            bool showcaption = true;
            MenuType MenuType = new MenuType(menutype, preservepageorder, selectallpages, pageno, parentpage, parent, confirmaddtomenu, linktitle, externallink, caption, iconpath, linkactive, linkvisible, externallinkparent, ParentExternalLink, htmlcontenttitle, captionhtmlcontent, htmlcontentvisible, parenthtmlcontent, htmlcontentparent);
            MenuManage MenuManage = new MenuManage(pageno[0], subtext, isactive, isvisible, parentpage[0], parent[0], confirmUpdate, ChangeSettings, menuno, menustyle, showimage, showtext, showcaption);
            IsAt isat = new IsAt(Browser.Title, Menu.MenuPage.Text);
            try
            {
                Browser.GoTo(Menu.MenuPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Menu.MenuPage.MenuType(MenuType);
                Menu.MenuPage.MenuManage(MenuManage);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[4] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(7)]
        [TestMethod]
        public void ModulesOperation()
        {
            //Module
            string ModulePath = @"E:\Module to test\New folder\AudioPlayer.zip";
            bool[] Next = { true, true, true, true };
            bool AcceptLicense = true;
            bool Install = true;
            //Create Package
            string[] Source = { "Modules/Admin/CacheMaintenance/CacheMaintenance.ascx", "Modules/Admin/CDN/CDNView.ascx" };
            string[] Key = { "test", "test1" };
            string[] Title = { "test", "test1" };
            string[] ControlType = { "View", "Edit" };
            string[] Icon = { "Not Specified", "Not Specified" };
            string[] HelpUrl = { "www.google.com", "www.gmail.com" };
            bool[] Update = { true, true };
            bool[] Previous = { false, false, false, false };
            string[] Modules = { "AudioPlayer", "Breadcrumb" };
            string[] Assembly = { "ContactUs.dll", "ContactUs.pdb" };
            string[] FolderFiles = { "contactus.ascx", "contactus.ascx.cs", "contactusedit.ascx", "contactusedit.ascx.cs" };
            string PackageName = "test";
            string PackageDescription = "test";
            int VersionFirst = 1;
            int VersionSecond = 1;
            int VersionLast = 1;
            string PackageLicense = "test";
            string PackageReleaseNotes = "test";
            string PackageOwner = "test";
            string PackageOrganization = "test";
            string PackageUrl = "www.google.com";
            string PackageEmail = "illusionineyes@gmail.com";
            string FriendlyName = "test";
            string ModuleName = "test";
            string BusinessControllerClass = "test";
            string CompatibleVersion = "test";
            int CacheTime = 1000;
            string ModuleFolder = "ContactUs";
            bool FileUploadInstall = false;
            string InstallFileUpload = @"";
            string InstallScript = "test";
            bool FileUploadUnistall = false;
            string UnistallFileUpload = @"";
            string UnistallScript = "test";
            bool IncludeSource = true;
            bool allfilesselect = true;
            string viewcontrol = "contactus.ascx";
            string ViewKey = "test";
            string ViewTitle = "test";
            string ViewIcon = "";
            string ViewHelpUrl = "www.google.com";
            string EditControl = "contactus.ascx";
            string EditKey = "test";
            string EditTitle = "test";
            string EditIcon = "";
            string EditHelpUrl = "www.google.com";
            string SettingControl = "contactus.ascx";
            string SettingKey = "test";
            string SettingTitle = "test";
            string SettingIcon = "";
            string SettingHelpUrl = "www.google.com";
            bool Submit =  true;
            //Create CompositePackage
            string Description = "Test";
            string License = "TestLicense";
            string ReleaseNotes = "TestReleaseNotes";
            string Owner = "TestOwner";
            string Organization = "TestOrganization";
            string Url = "www.google.com";
            string Email = "TestEmail@gmail.com";
            bool SwitchRight = true;
            bool DownloadConfirm = true;
            //Edit Module
            string editmodule = "test";
            bool edit = true;
            bool Delete = true;
            bool IsActive = true;
            bool Save = true;
            bool EditModuleCotrolSettings = true;
            bool EditModuleDefinitionSettings = true;
            bool EditModuleSettings = true;
            bool EditModuleControls = true;
            bool AddModuleControls = true;
            bool EditModuleControl = true;
            bool DeleteModuleControl = true;
            bool DeleteControl = true;
            string Definition = "test";
            int ModuleCache = 100;
            string Dependencies = "TestDependencies";
            string Permission = "TestPermission";
            bool IsPortable = true;
            bool IsSearchable = true;
            bool IsUpgradable = true;
            bool IsPremiumModule = true;
            string ModulePackageName = "TestPackage";
            string ModuleDescription = "TestDescription"; 
            string ModuleLicense = "TestLicense";
            string ModuleReleaseNotes = "TestReleaseNotes";
            string ModuleOwner = "TestOwner";
            string ModuleOrganization = "TestOrganization";
            string ModuleUrl = "www.google.com";
            string ModuleEmail = "illusionineyes@gmail.com";
            bool UpdateSave = true;
            bool UninstallModule = false;
            IsAt isat = new IsAt(Browser.Title, Module.ModulePage.Text);
            CompositePackage CompositePackage = new CompositePackage(PackageName, FriendlyName, Description, VersionFirst, VersionSecond, VersionLast, License, ReleaseNotes, Owner, Organization, Url, Email, Modules, SwitchRight, DownloadConfirm);
            InstallModule InstallModule = new InstallModule(ModulePath, Next, AcceptLicense, Install);
            ModuleAddEdit[] ModuleAddEdit = {
                                                new ModuleAddEdit(Source[0], Key[0], Title[0], ControlType[0], HelpUrl[0], Update[0]),
                                                new ModuleAddEdit(Source[1], Key[1], Title[1], ControlType[1], HelpUrl[1], Update[1])
                                            };
            EditModule EditModule = new EditModule(editmodule, edit, Delete, IsActive, Save, EditModuleCotrolSettings, EditModuleDefinitionSettings, EditModuleSettings, EditModuleControls, AddModuleControls, EditModuleControl, ModuleAddEdit, Icon, DeleteModuleControl, DeleteControl, Definition, FriendlyName, ModuleCache, ModuleFolder, BusinessControllerClass, Dependencies, Permission, IsPortable, IsSearchable, IsUpgradable, IsPremiumModule, ModulePackageName, ModuleDescription, ModuleLicense, ModuleReleaseNotes, ModuleOwner, ModuleOrganization, ModuleUrl, ModuleEmail, UpdateSave, UninstallModule);
            CreatePackage CreatePackage = new CreatePackage(PackageName, PackageDescription, VersionFirst, VersionSecond, VersionLast, PackageLicense, PackageReleaseNotes, PackageOwner, PackageOrganization, PackageUrl, PackageEmail, FriendlyName, ModuleName, BusinessControllerClass, CompatibleVersion, CacheTime, ModuleFolder, Next, FileUploadInstall, InstallFileUpload, InstallScript, FileUploadUnistall, UnistallFileUpload, UnistallScript, IncludeSource, Previous, FolderFiles, allfilesselect, viewcontrol, ViewKey, ViewTitle, ViewIcon, ViewHelpUrl, EditControl, EditKey, EditTitle, EditIcon, EditHelpUrl, SettingControl, SettingKey, SettingTitle, SettingIcon, SettingHelpUrl, Assembly, Submit);
            try
            {
                Browser.GoTo(Module.ModulePage.Url);
                Assert.IsTrue(Browser.IsAt(isat));
                Module.ModulePage.Create_CompositePackage(CompositePackage);
                Module.ModulePage.Create_Package(CreatePackage);
                Module.ModulePage.Install_Module(InstallModule);
                Module.ModulePage.Edit_Module(EditModule);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[5] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(8)]
        [TestMethod]
        public void SettingsOperation()
        {                                                          
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
            IsAt isat = new IsAt(Browser.Title, Settings.SettingPage.Text);
            ChangeBasicSettings ChangeBasicSettings = new ChangeBasicSettings(PortalTitle, PortalDescription, SettingsKeyWords, GoogleAdSenseID, ShowProfileLink, EnableCDN, EnableSessionTracker, EnableOptimizationCSS, EnableOptimizationJs, EnableDashboardLiveFeeds, openidenable, FbConsumerKey, FbSecretKey, LIConsumerKey, LISecretKey, SaveBasicSettings);
            ChangeAdvancedSettings ChangeAdvancedSettings = new ChangeAdvancedSettings(UserRegistration, LoginPage, PortalDefaultPage, UserProfilePage, UserRegistrationPage, UserActivationPage, UserForgotPasswordPage, PageNotAccessiblePage, PageNotFoundPage, PasswordRecoveryPage, MessageSetting, MessageType, DefaultLanguage, LanguageType, PortalTimeZone, SiteAdminEmailAddress, LogoTemplate, CopyRight, SaveAdvancedSettings);
            ChangeSuperUserSettings ChangeSuperUserSettings = new ChangeSuperUserSettings(SiteTitle, SiteUrl, SiteEmail, CopyrightEnable, CustomError, SMTPServerAndPort, SMTPBasic, EnableSSL, SMTPUserName, SMTPPassword, FileExtensions, HelpUrl, PageExtension, UserAgent, EnableScheduler, ServerCookieExpirationTime, SaveSuperUserSettings, TestSMTP);
            try
            {
                Browser.GoTo(Settings.SettingPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                Settings.SettingPage.ChangeBasicSettings(ChangeBasicSettings);
                Settings.SettingPage.ChangeAdvancedSettings(ChangeAdvancedSettings);
                Settings.SettingPage.ChangeSuperUserSettings(ChangeSuperUserSettings);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[6] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(9)]
        [TestMethod]
        public void PortalOperation()
        {
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
            IsAt isat = new IsAt(Browser.Title, Portals.PortalPage.Text);
            AddNewPortal AddNewPortal = new AddNewPortal(PortalName, ParentPortal, PortalUrl, SavePortal);
            PortalSettings PortalSettings = new PortalSettings(view, edit, PortalName, SavePortal, EditPortal, EditModuleManagement, selectAll, ModuleList, ModuleNo, SaveChanges, EditPortalno, delete, ConfirmDelete);
            try
            {
                Browser.GoTo(Portals.PortalPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Portals.PortalPage.AddNewPortal(AddNewPortal);
                Portals.PortalPage.PortalSettings(PortalSettings);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[7] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(10)]
        [TestMethod]
        public void LinksOperation()
        {
            //Links
            bool addsidebaritem = true;
            string SidebarName = "test";
            bool LinkParent = true;
            string ParentLink = "Portals";
            string Page = "Admin";
            string LinkFilePath = @"D:\snips\Free Images\Pearl-Jam-Stickman.png";
            bool IsActiveLink = true;
            bool addsidebartab = true;
            string TabName = "test";
            bool ConfirmTabAdd = true;
            int linkno = 68;
            bool ExpandSideTab = true;
            bool DeleteSideTab = false;
            bool EditSideTab = true;
            bool ConfirmDel = false;
            int link = 2;
            string EditLinkText = "Users";
            bool EditLink = true;
            bool DelLink = false;
            int[] Link = { 1, 0 };
            AddSideBarItem AddSideBarItem = new AddSideBarItem(SidebarName, LinkParent, ParentLink, Page, LinkFilePath, IsActiveLink);
            ExpandTab ExpandTab = new ExpandTab(ExpandSideTab, Link, EditLinkText, EditLink, AddSideBarItem, DelLink, ConfirmDel);
            LinksOperations LinksOperations = new LinksOperations(addsidebaritem, addsidebartab, TabName, ConfirmTabAdd, linkno, DeleteSideTab, EditSideTab, link, ExpandTab);
            IsAt isat = new IsAt(Browser.Title, Links.LinkPage.Text);
            try
            {
                Browser.GoTo(Links.LinkPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Links.LinkPage.LinksOperations(LinksOperations);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[8] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(11)]
        [TestMethod]
        public void ModuleMakerOperation()
        {
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
            IsAt isat = new IsAt(Browser.Title, Module_Maker.Module_MakerPage.Text);
            ModuleMaker ModuleMaker = new ModuleMaker(ModuleName, ModuleDescription, ModuleTableName, IncludeCss, IncludeJs, IncludeWebservice, EditInclude, SettingInclude, ModuleType, TotalColumn, autoincrement, ColumnName, DataType, AllowNull, m, DownloadClassZip, Back);
            try
            {
                Browser.GoTo(Module_Maker.Module_MakerPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Module_Maker.Module_MakerPage.ModuleMaker(ModuleMaker);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[9] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(12)]
        [TestMethod]
        public void SQLOperation()
        {
            //SQL
            bool archivesession = false;
            bool backupdatabase = false;
            bool cleanupscript = false;
            bool UploadFile = true;
            string SQLFilePath = @"C:\Users\RajKumar-PC\Documents\SQL Server Management Studio\test.sql";
            string SqlScript = "select * from Users";
            bool runasscript = true;
            IsAt isat = new IsAt(Browser.Title, SQL.SQLPage.Text);
            SQLPageFunction SQLPageFunction = new SQLPageFunction(archivesession, backupdatabase, cleanupscript, UploadFile, SQLFilePath, SqlScript, runasscript);
            try
            {
                Browser.GoTo(SQL.SQLPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                SQL.SQLPage.SQLPageFunctions(SQLPageFunction);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[10] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(13)]
        [TestMethod]
        public void SystemEventStartUpOperation()
        {
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
            IsAt isat = new IsAt(Browser.Title, System_Event_StartUp.System_Event_StartUpPage.Text);
            AddEventStartUp AddEventStartUp = new AddEventStartUp(ControlUrl, EventLocation, IsAdmin, IsControlUrl, IsActiveEvent, confirm);
            EventListManagement EventListManagement = new EventListManagement(EventNo, EditEvent, DeleteEvent, AddEventStartUp, ConfirmDelEvent);
            try
            {
                Browser.GoTo(System_Event_StartUp.System_Event_StartUpPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                System_Event_StartUp.System_Event_StartUpPage.Add_Event_StartUp(AddEventStartUp);
                System_Event_StartUp.System_Event_StartUpPage.EventListManagement(EventListManagement);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[11] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(14)]
        [TestMethod]
        public void SiteAnalyticsOperation()
        {
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
            IsAt isat = new IsAt(Browser.Title, SiteAnalytics.SiteAnalyticsPage.Text);
            DateWiseSiteAnalytics DateWiseSiteAnalytics = new DateWiseSiteAnalytics(StartDate, EndDate);
            SiteAnalytic SiteAnalytic = new SiteAnalytic(Chart, Data, Date, DateWiseSiteAnalytics, PageWiseVisit, PageAnalytics, ExportToPdf, ExportToExcel, Pagination, TypeWise);
            try
            {
                Browser.GoTo(SiteAnalytics.SiteAnalyticsPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                SiteAnalytics.SiteAnalyticsPage.SiteAnalytics(SiteAnalytic);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[12] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(15)]
        [TestMethod]
        public void CDNOperation()
        {
            //CDN
            string[] Js = { "testjs1", "testjs2" };
            string[] Css = { "testcss1", "testcss2" };
            string[] NewJs = { "jstest1", "jstest2" };
            string[] NewCss = { "csstest1", "csstest2" };
            bool addjs = true;
            bool addcss = true;
            bool Changelinks = true;
            int CDNLinkno = 5;
            bool sort = true;
            bool CDNDelete = true;
            bool CDNEdit = true;
            bool jsedit = true;
            bool cssedit = true;
            bool up = true;
            bool CDNConfirmDelete = false;
            CDNChanges CDNChanges = new CDNChanges(addjs, Js, addcss, Css, Changelinks, CDNLinkno, sort, CDNDelete, CDNEdit, jsedit, cssedit, NewJs, NewCss, up, CDNConfirmDelete);
            IsAt isat = new IsAt(Browser.Title, CDN.CDNPage.Text);
            try
            {
                Browser.GoTo(CDN.CDNPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                CDN.CDNPage.CDNChanges(CDNChanges);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[13] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(16)]
        [TestMethod]
        public void EventLogOperation()
        {
            //Event Log
            bool SendEmail = false;
            string LogType = "Mail Error";
            string RecordsPerPage = "10";
            bool ClearLog = true;
            bool DeleteSelectedLogs = true;
            bool ExportLogs = true;
            bool SelectAll = true;
            int[] DeleteLogs = { 1, 2 };
            bool DeleteIndividual = true;
            string EventLogEmail = "illusionineyes@gmail.com";
            string Subject = "Test";
            string Message = "This is a Test :-D";
            EventLogOperations EventLogOperations = new EventLogOperations(SendEmail, LogType, RecordsPerPage, ClearLog, DeleteSelectedLogs, ExportLogs, SelectAll, DeleteLogs, DeleteIndividual, EventLogEmail, Subject, Message);
            IsAt isat = new IsAt(Browser.Title, Event_Log.EventLogPage.Text);
            try
            {
                Browser.GoTo(Event_Log.EventLogPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                Event_Log.EventLogPage.EventLogOperations(EventLogOperations);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[14] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(17)]
        [TestMethod]
        public void CacheMaintenanceOperation()
        {
            //Cache Maintenance
            int[] CacheClear = { 1, 2 };
            int[] CacheSave = { 1, 2 };
            bool ClearAll = true;
            bool SaveAll = true;
            CacheSettings CacheData = new CacheSettings(CacheClear, ClearAll, SaveAll, CacheSave);
            IsAt isat = new IsAt(Browser.Title, CacheMaintenance.CacheMaintenancePage.Text);
            try
            {
                Browser.GoTo(CacheMaintenance.CacheMaintenancePage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                CacheMaintenance.CacheMaintenancePage.CacheSettings(CacheData);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[15] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(18)]
        [TestMethod]
        public void SEOOperation()
        {
            //SEO
            int[] PageNo = { 1, 2 };
            bool Google = true;
            bool Yahoo = true;
            bool Bing = true;
            bool Msn = true;
            double Priority = 0.2;
            string Frequency = "Always";
            bool Ask = true;
            string GoogleJs = "GoogleJS";
            bool GoogleJsIsActive = true;
            bool GoogleUpdate = true;
            bool Refresh = true;
            IsAt isat = new IsAt(Browser.Title, SEO.SEOpage.Text);
            AddGoogleJs AddGoogleJS = new AddGoogleJs(GoogleJs, GoogleJsIsActive, GoogleUpdate, Refresh);
            GenerateRobots GenerateRobots = new GenerateRobots(Google, Yahoo, Bing, Msn, PageNo);
            GenerateSiteMap GenerateSiteMap = new GenerateSiteMap(Priority, Frequency, Google, Yahoo, Bing, Ask);
            try
            {
                Browser.GoTo(SEO.SEOpage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                SEO.SEOpage.GenerateRobots(GenerateRobots);
                SEO.SEOpage.GenerateSiteMap(GenerateSiteMap);
                SEO.SEOpage.AddGoogleJs(AddGoogleJS);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[16] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(19)]
        [TestMethod]
        public void MessageTemplateOperation()
        {
            //Message Template
            string type = "Activation - Successful Email";
            string email = "anks@gmail.com";
            string subject = "test12";
            string text = "this is a test";
            bool save = true;
            string tmtt = "test123";
            string mttext = "test";
            string token = "test";
            IsAt isat = new IsAt(Browser.Title, Message_Template.MessageTemplatePage.Text);
            AddMT AddMT = new AddMT(type, email, subject, text, save, tmtt, mttext, token);
            try
            {
                Browser.GoTo(Message_Template.MessageTemplatePage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                Message_Template.MessageTemplatePage.AddMT(AddMT);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[17] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(20)]
        [TestMethod]
        public void SchedulerOperation()
        {
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
            IsAt isat = new IsAt(Browser.Title, Scheduler.SchedulerPage.Text);
            EditDelete EditDelete = new EditDelete(taskno, SchedulerEdit, SchedulerDelete, Schedulerconfirmdelete);
            AddNewTask AddNewTask = new AddNewTask(TaskName, Closepopup, AssemblyName, EnabledTask, Hour, minute, RepeatMode, RetryUnit, RetryFreq, Event, CatchUp, SchedulerFilePath, SchedulerEndDate, RepeatHours, RepeatMins, RepeatDays, RepeatModeDate, Update, FileName);
            try
            {
                Browser.GoTo(Scheduler.SchedulerPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                Scheduler.SchedulerPage.AddNewTask(AddNewTask);
                Scheduler.SchedulerPage.EditDelete(EditDelete);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[18] = ex.ToString();
                TestResults.Fail++;
            }
        }
        //[Priority(21)]
        [TestMethod]
        public void ModuleMessageOperation()
        {
            string Module = "DashBoard";
            string DisplayMode = "SlideUp";
            string Culture = "en-US";
            string MessagePosition = "Top";
            string MessageType = "Info";
            bool hide = true;
            string Message = "Use quick links, sidebar to quickly navigate and switch across pages.";
            bool Source = true;
            IsAt isat = new IsAt(Browser.Title, Module_Message.Module_MessagePage.Text);
            ModuleMessage ModuleMessage = new ModuleMessage(Module, DisplayMode, Culture, MessagePosition, MessageType, hide, Message, Source);
            try
            {
                Browser.GoTo(Module_Message.Module_MessagePage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Module_Message.Module_MessagePage.Edit_ModuleMessage(ModuleMessage);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[19] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(22)]
        [TestMethod]
        public void ListOperation()
        {
            //List Management
            int PageSize = 25;
            bool Parent = true;
            string ParentList = "None Specified";
            string ParentEntry = "None";
            string NewListName = "TestList";
            string TextEntry = "TestText";
            string ValueEntry = "TestValue";
            bool NewListActive = true;
            bool AddConfirm = true;
            bool DeleteList = false;
            bool ListEdit = true;
            int EditListNo = 0;
            bool ChildList = true;
            int ParentListNo = 5;
            int ChildListDivNo = 0;
            int ChildListNo = 1;
            bool Confirm = false;
            bool Edit = true; 
            int Listno = 2;
            string CurrencyCode = "Rs";
            string DisplayLocale = "NE-ne";
            bool ListItemActive = true;
            bool AddListItemI = true;
            List List = new List(TextEntry, ValueEntry, AddConfirm);
            AddList AddList = new AddList(NewListName, Parent, ParentList, ParentEntry, NewListActive, List);
            AddListItem AddListItem = new AddListItem(List, CurrencyCode, DisplayLocale, ListItemActive);
            ListManagement ListManagement = new ListManagement(PageSize, DeleteList, ListEdit, EditListNo, ChildList, ParentListNo, ChildListDivNo, ChildListNo, Confirm, Edit, Listno, AddListItemI, AddList, AddListItem);
            IsAt isat = new IsAt(Browser.Title, Lists.ListsPage.Text);
            try
            {
                Browser.GoTo(Lists.ListsPage.Url);
                LoginOperation(); 
                Assert.IsTrue(Browser.IsAt(isat));
                Lists.ListsPage.ListManagement(ListManagement);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[20] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        //[Priority(23)]
        [TestMethod]
        public void LocalizationOperation()
        {
            //Time Zone Editor
            string LanguageTimeZoneEditor = "Nepali (Nepal)";
            int[] n = { 1, 2, 3 };
            string[] Timezone = { "(UTC -12:00) International Dateline West", "(UTC -11:00) Midway Island, Samoa", "(UTC -10:00) Hawaii" };
            bool SaveTZEditor = true;
            //LocalizeMenu
            string AvailableLocales = "Nepali (Nepal)";
            //int[] n = {};
            string[] LocalValues = { "Home", "Admin", "Roles" };
            string[] LocalCaption = { "Home", "Admin", "Roles" };
            bool SaveMenu = true;
            //Localize Module Title
            string LocalesModuleTitle = "Nepali (Nepal)";
            //int[] n = {};
            string[] ModuleLocalTitle = { "DashBoard", "Dashboard Manager", "Roles Management" };
            bool SaveLMT = true;
            //AddLanguage
            string Language = "Nepali (Nepal)";
            string LanguageType = "English";
            bool SaveL = true;
            //InstallLanguagePack
            string FilePath = @"D:\Personnel\ResourcePack.Test.3.1.0.0.en-US.zip";
            bool[] Next = { true, false, false, false, false };
            bool AcceptLicense = true;
            bool Overwrite = true;
            bool Finish = true;
            //CreateLanguagePack
            string PackLanguage = "Nepali (Nepal)";
            string ResourcePackType = "Core";
            string ResourcePackName = "Nepali";
            bool CreateLP = true;
            //EditLanguage
            string LanguageList = "All";
            string[] Keyvalue = { "Home", "CPANEL", "Customize:", "Themes:", "Screen:", "Layouts:", "Mode:", "Edit", "Layout", "None", "Password must be at least 4 chars long", "* All Fields are compulsory.", "Password must be at least 4 chars long", "Login with any of these OpenID providers:", "or", "Enter Captcha Text", "Change Password", "Contacts", "User Info", "User Profile", "Scroll Back to the Top", "Submit", "Reset", "Subscribe Newsletter", "By Email", "By Phone", "Your Email", "Your Mobile Number", "Subscribe", "Click here to UnSubscribe", "You are already a subscribed member", "Subscribed Successfully", "Invalid Email" };
            string ResourceFile = "Save";
            int no = 2;
            bool Enable = true;
            bool DelConfirm = false;
            bool Edit = true;
            bool AdminResources = true;
            bool RootResources = true;
            bool AdminModule = true;
            bool Modules = true;
            bool XMLClient = true;
            bool Back = true;
            bool Delete = false;
            IsAt isat = new IsAt(Browser.Title, Localization.LocalizationPage.Text);
            AddLanguage AddLanguage = new AddLanguage(Language, LanguageType, SaveL);
            InstallLanguagePack InstallLanguagePack = new InstallLanguagePack(FilePath, Next, AcceptLicense, Overwrite, Finish);
            CreateLanguagePack CreateLanguagePack = new CreateLanguagePack(PackLanguage, ResourcePackType, ResourcePackName, CreateLP);
            TimeZoneEditor TimeZoneEditor = new TimeZoneEditor(LanguageTimeZoneEditor, n, Timezone, SaveTZEditor);
            SetLocalizeMenu[] SetLocalizeMenu = {
                                                    new SetLocalizeMenu(n[0], LocalValues[0], LocalCaption[0]),
                                                    new SetLocalizeMenu(n[1], LocalValues[1], LocalCaption[1]),
                                                    new SetLocalizeMenu(n[2], LocalValues[2], LocalCaption[2])
                                                };
            LocalizeMenu LocalizeMenu = new LocalizeMenu(AvailableLocales, SetLocalizeMenu, SaveMenu);
            LocalizeModuleTitle LocalizeModuleTitle = new LocalizeModuleTitle(LocalesModuleTitle, n, ModuleLocalTitle, SaveLMT);
            FillKeyValues FillKeyValues = new FillKeyValues("simple", Keyvalue, ResourceFile, Back);
            EditLanguage EditLanguage = new EditLanguage(Edit, LanguageList, no, Enable, DelConfirm, AdminResources, RootResources, AdminModule, Modules, XMLClient, FillKeyValues, Delete);
            try
            {
                Browser.GoTo(Localization.LocalizationPage.Url);
                LoginOperation();
                Assert.IsTrue(Browser.IsAt(isat));
                Localization.LocalizationPage.AddLanguage(AddLanguage);
                Localization.LocalizationPage.InstallLanguagePack(InstallLanguagePack);
                Localization.LocalizationPage.CreateLanguagePack(CreateLanguagePack);
                Localization.LocalizationPage.TimeZoneEditor(TimeZoneEditor);
                Localization.LocalizationPage.LocalizeMenu(LocalizeMenu);
                Localization.LocalizationPage.LocalizeModuleTitle(LocalizeModuleTitle);
                Localization.LocalizationPage.EditLanguage(EditLanguage);
                Admin.AdminPage.Logout();
                TestResults.Pass++;
            }
            catch (Exception ex)
            {
                TestResults.ErrorException[21] = ex.ToString();
                TestResults.Fail++;
            }   
        }
        public void TearDown()
        {
            Browser.Teardown();
        }
    }
}
