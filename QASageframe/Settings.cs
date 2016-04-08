using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
namespace QASageframe
{
    #region
    public class DivExpansion
    {
        public IWebElement SettingDiv { get; set; }
        public int N { get; set; }
        public DivExpansion(IWebElement settingdiv, int n)
        {
            SettingDiv = settingdiv;
            N = n;
        }
    }
    public class ChangeBasicSettings
    {
        public string PortalTitle { get; set; }
        public string PortalDescription { get; set; }
        public string KeyWords { get; set; }
        public string GoogleAdSenseID { get; set; }
        public bool ShowProfileLink { get; set; }
        public bool EnableCDN { get; set; }
        public bool EnableSessionTracker { get; set; }
        public bool EnableOptimizationCSS { get; set; }
        public bool EnableOptimizationJs { get; set; }
        public bool EnableDashboardLiveFeeds { get; set; }
        public bool OpenIdEnable { get; set; }
        public string FbConsumerKey { get; set; }
        public string FbSecretKey { get; set; }
        public string LIConsumerKey { get; set; }
        public string LISecretKey { get; set; }
        public bool SaveBasicSettings { get; set; }
        public ChangeBasicSettings(string portaltitle, string portaldescription, string keywords, string googleadsenseid, bool showprofilelink, bool enablecdn, bool enablesessiontracker, bool enableoptimizationcss, bool enableoptimizationjs, bool enabledashboardlivefeeds, bool openidenable, string fbconsumerkey, string fbsecretkey, string liconsumerkey, string lisecretkey, bool savebasicsettings)
        {
            PortalTitle = portaltitle;
            PortalDescription = portaldescription;
            KeyWords = keywords;
            GoogleAdSenseID = googleadsenseid;
            ShowProfileLink = showprofilelink;
            EnableCDN = enablecdn;
            EnableSessionTracker = enablesessiontracker;
            EnableOptimizationCSS = enableoptimizationcss;
            EnableOptimizationJs = enableoptimizationjs;
            EnableDashboardLiveFeeds = enabledashboardlivefeeds;
            OpenIdEnable = openidenable;
            FbConsumerKey = fbconsumerkey;
            FbSecretKey = fbsecretkey;
            LIConsumerKey = liconsumerkey;
            LISecretKey = lisecretkey;
            SaveBasicSettings = savebasicsettings;
        }
    }
    public class ChangeAdvancedSettings
    {
        public string UserRegistration { get; set; }
        public string LoginPage { get; set; }
        public string PortalDefaultPage { get; set; }
        public string UserProfilePage { get; set; }
        public string UserRegistrationPage { get; set; }
        public string UserActivationPage { get; set; }
        public string UserForgotPasswordPage { get; set; }
        public string PageNotAccessiblePage { get; set; }
        public string PageNotFoundPage { get; set; }
        public string PasswordRecoveryPage { get; set; }
        public string MessageSetting { get; set; }
        public string MessageType { get; set; }
        public string DefaultLanguage { get; set; }
        public string LanguageType { get; set; }
        public string PortalTimeZone { get; set; }
        public string SiteAdminEmailAddress { get; set; }
        public string LogoTemplate { get; set; }
        public string CopyRight { get; set; }
        public bool SaveAdvancedSettings { get; set; }
        public ChangeAdvancedSettings(string userregistration, string loginpage, string portaldefaultpage, string userprofilepage, string userregistrationpage, string useractivationpage, string userforgotpasswordpage, string pagenotaccessiblepage, string pagenotfoundpage, string passwordrecoverypage, string messagesetting, string messagetype, string defaultlanguage, string languagetype, string portaltimezone, string siteadminemailaddress, string logotemplate, string copyright, bool saveadvancedsettings)
        {
            UserRegistration = userregistration;
            LoginPage = loginpage;
            PortalDefaultPage = portaldefaultpage;
            UserProfilePage = userprofilepage;
            UserRegistrationPage = userregistrationpage;
            UserActivationPage = useractivationpage;
            UserForgotPasswordPage = userforgotpasswordpage;
            PageNotAccessiblePage = pagenotaccessiblepage;
            PageNotFoundPage = pagenotfoundpage;
            PasswordRecoveryPage = passwordrecoverypage;
            MessageSetting = messagesetting;
            MessageType = messagetype;
            DefaultLanguage = defaultlanguage;
            LanguageType = languagetype;
            PortalTimeZone = portaltimezone;
            SiteAdminEmailAddress = siteadminemailaddress;
            LogoTemplate = logotemplate;
            CopyRight = copyright;
            SaveAdvancedSettings = saveadvancedsettings;
        }
    }
    public class ChangeSuperUserSettings
    {
        public string SiteTitle { get; set; }
        public string SiteUrl { get; set; }
        public string SiteEmail { get; set; }
        public bool CopyrightEnable { get; set; }
        public bool CustomError { get; set; }
        public string SMTPServerAndPort { get; set; }
        public bool SMTPBasic { get; set; }
        public bool EnableSSL { get; set; }
        public string SMTPUserName { get; set; }
        public string SMTPPassword { get; set; }
        public string FileExtensions { get; set; }
        public string HelpUrl { get; set; }
        public string PageExtension { get; set; }
        public string UserAgent { get; set; }
        public bool EnableScheduler { get; set; }
        public string ServerCookieExpirationTime { get; set; }
        public bool SaveSuperUserSettings { get; set; }
        public bool TestSMTP { get; set; }
        public ChangeSuperUserSettings(string sitetitle, string siteurl, string siteemail, bool copyrightenable, bool customerror, string smtpserverandport, bool smtpbasic, bool enablessl, string smtpusername, string smtppassword, string fileextensions, string helpurl, string pageextension, string useragent, bool enablescheduler, string servercookieexpirationtime, bool savesuperusersettings, bool testsmtp)
        {
            SiteTitle = sitetitle;
            SiteUrl = siteurl;
            SiteEmail = siteemail;
            CopyrightEnable = copyrightenable;
            CustomError = customerror;
            SMTPServerAndPort = smtpserverandport;
            SMTPBasic = smtpbasic;
            EnableSSL = enablessl;
            SMTPUserName = smtpusername;
            SMTPPassword = smtppassword;
            FileExtensions = fileextensions;
            HelpUrl = helpurl;
            PageExtension = pageextension;
            UserAgent = useragent;
            EnableScheduler = enablescheduler;
            ServerCookieExpirationTime = servercookieexpirationtime;
            SaveSuperUserSettings = savesuperusersettings;
            TestSMTP = testsmtp;
        }
    }
    #endregion
    public static class Settings
    {
        public static SettingPage SettingPage
        {
            get
            {
                var settingpage = new SettingPage();
                PageFactory.InitElements(Browser.Driver, settingpage);
                return settingpage;
            }
        }
    }
    public class SettingPage
    {
        public string Url = "Admin/Settings.aspx";
        public string Text = "Setting";
        public string SaveSettings = "Portal setting has been saved successfully.";
        #region
        //Portal Settings
        [FindsBy(How = How.Id, Using = "ctl19_imbSave")][CacheLookup]
        public IWebElement SaveButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imbRefresh")][CacheLookup]
        public IWebElement RefreshButton { get; set; }
        //Basic Settings
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer_tabBasicSetting")][CacheLookup]
        public IWebElement BasicSettingTab { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting")][CacheLookup]
        public IWebElement BasicSettingDiv { get; set; }
        //Site Details
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtPortalTitle")][CacheLookup]
        public IWebElement PortalTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtDescription")][CacheLookup]
        public IWebElement PortalDescriptionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtKeyWords")][CacheLookup]
        public IWebElement KeyWordsTextBox { get; set; }
        //Site Marketing
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtPortalGoogleAdSenseID")][CacheLookup]
        public IWebElement GoogleAdSenseIDTextBox { get; set; }
        //Appearance
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_rblPortalShowProfileLink_0")][CacheLookup]
        public IWebElement ProfileLinkNoRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_rblPortalShowProfileLink_1")][CacheLookup]
        public IWebElement ProfileLinkYesRadioButton { get; set; }
        //Optimization
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkEnableCDN")][CacheLookup]
        public IWebElement EnableCDNCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkSessionTracker")][CacheLookup]
        public IWebElement EnableSessionTrackerCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkOptCss")][CacheLookup]
        public IWebElement EnableOptimizeCSSCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkOptJs")][CacheLookup]
        public IWebElement EnableOptimizeJSCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_btnRefreshCache")][CacheLookup]
        public IWebElement RefreshCacheButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkLiveFeeds")][CacheLookup]
        public IWebElement DashBoardLiveFeedsCheckBox { get; set; }
        //OpenID Service Provider
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_chkOpenID")][CacheLookup]
        public IWebElement OpenIDEnableCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtFacebookConsumerKey")][CacheLookup]
        public IWebElement FacebookConsumerKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtFaceBookSecretKey")][CacheLookup]
        public IWebElement FacebookSecretKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtLinkedInConsumerKey")][CacheLookup]
        public IWebElement LinkedInConsumerKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabBasicSetting_txtLinkedInSecretKey")][CacheLookup]
        public IWebElement LinkedInSecretKey { get; set; }
        //Advanced Settings
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer_tabAdvanceSetting")][CacheLookup]
        public IWebElement AdvanceSettingTab { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting")][CacheLookup]
        public IWebElement AdvancedSettingDiv { get; set; }
        //Security Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_0")][CacheLookup]
        public IWebElement NoneRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_1")][CacheLookup]
        public IWebElement PrivateRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_2")][CacheLookup]
        public IWebElement PublicRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rblUserRegistration_0")][CacheLookup]
        public IWebElement VerifiedRadioButton { get; set; }
        //Page Management
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlLoginPage")][CacheLookup]
        public IWebElement LoginPageDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalDefaultPage")][CacheLookup]
        public IWebElement PortalDefaultPageDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalUserProfilePage")][CacheLookup]
        public IWebElement UserProfilePageDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlUserRegistrationPage")][CacheLookup]
        public IWebElement UserRegistrationPageDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalUserActivation")][CacheLookup]
        public IWebElement PortalUserActivationDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalForgotPassword")][CacheLookup]
        public IWebElement PortalForgotPasswordDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPageNotAccessible")][CacheLookup]
        public IWebElement PortalPageNotAccessibleDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPageNotFound")][CacheLookup]
        public IWebElement PortalPageNotFoundDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalPasswordRecovery")][CacheLookup]
        public IWebElement PortalPasswordRecoveryDropDown { get; set; }
        //Message Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rdbDefault")][CacheLookup]
        public IWebElement AdvanceSetting_rdbDefaultRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rdbCustom")][CacheLookup]
        public IWebElement AdvanceSetting_rdbCustomRadioButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfDefaultSuccess")][CacheLookup]
        public IWebElement SuccessMessageLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfDefaultError")][CacheLookup]
        public IWebElement ErrorMessageLink { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfDefaultAlert")][CacheLookup]
        public IWebElement AlertMessageLink { get; set; }
        //Other Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlDefaultLanguage")][CacheLookup]
        public IWebElement DefaultLanguageDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rbLanguageType_0")][CacheLookup]
        public IWebElement EnglishLanguageRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_rbLanguageType_1")][CacheLookup]
        public IWebElement NaiveLanguageRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_ddlPortalTimeZone")][CacheLookup]
        public IWebElement PortalTimeZoneDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_txtSiteAdminEmailAddress")][CacheLookup]
        public IWebElement SiteAdminEmailAddressTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_txtLogoTemplate")][CacheLookup]
        public IWebElement LogoTemplateTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_tabAdvanceSetting_txtCopyright")][CacheLookup]
        public IWebElement CopyRightTextBox { get; set; }
        //SuperUser Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_imbRestart")][CacheLookup]
        public IWebElement RestartApplication { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer_TabPanel1")][CacheLookup]
        public IWebElement SuperUserSettingsTab { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1")][CacheLookup]
        public IWebElement SuperUserSettingsDiv { get; set; }
        //SuperUser Details
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtHostTitle")][CacheLookup]
        public IWebElement SiteTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtHostUrl")][CacheLookup]
        public IWebElement SiteUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtHostEmail")][CacheLookup]
        public IWebElement SiteEmailTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_chkCopyright")][CacheLookup]
        public IWebElement CopyrightCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_chkUseCustomErrorMessages")][CacheLookup]
        public IWebElement CustomErrorMessagesCheckBox { get; set; }
        //SMTP Server Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtSMTPServerAndPort")][CacheLookup]
        public IWebElement SMTPServerAndPortTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_lnkTestSMTP")][CacheLookup]
        public IWebElement TestSMTPButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_rblSMTPAuthentication_0")][CacheLookup]
        public IWebElement SMTPAuthenticationAnoymousRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_rblSMTPAuthentication_1")][CacheLookup]
        public IWebElement SMTPAuthenticationBasicRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_chkSMTPEnableSSL")][CacheLookup]
        public IWebElement SMTPEnableSSLCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtSMTPUserName")][CacheLookup]
        public IWebElement SMTPUserNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtSMTPPassword")][CacheLookup]
        public IWebElement SMTPPasswordTextBox { get; set; }
        //Other Settings
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtFileExtensions")][CacheLookup]
        public IWebElement FileExtensionsHelpUrl { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtHelpUrl")][CacheLookup]
        public IWebElement HelpUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtPageExtension")][CacheLookup]
        public IWebElement PageExtensionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtScheduler")][CacheLookup]
        public IWebElement EnableSchedulerCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_chkDashboardHelp")][CacheLookup]
        public IWebElement DashboardHelpCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_txtServerCookieExpiration")][CacheLookup]
        public IWebElement ServerCookieExpirationTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_rdBtnPC")][CacheLookup]
        public IWebElement PCRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_rdBtnMobile")][CacheLookup]
        public IWebElement MobileRadioButton { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer_TabPanel1_rdBtnDefault")][CacheLookup]
        public IWebElement DefaultRadioButton { get; set; }
        #endregion       
        public void DivExpansion(DivExpansion DivExpansion)
        {
            try
            {
                int i;
                for (i = 0; i < DivExpansion.N; i++)
                {
                    IList<IWebElement> DivCollaspeWrapper = DivExpansion.SettingDiv.FindElements(By.ClassName("sfCollapsewrapper"));
                    IWebElement DivAccordian = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[0];
                    IWebElement DivAccordianholder = DivAccordian.FindElement(By.TagName("div"));
                    string DivAccordianholdertext = DivAccordianholder.GetAttribute("class");
                    IWebElement DivAccordianheader = DivAccordianholder.FindElement(By.TagName("div"));
                    if (DivAccordianholdertext == "sfAccordianholder")
                    {
                        DivAccordianheader.Click();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }
        public void SaveSettingsConfirm()
        {
            try
            {
                IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                IsAt isat = new IsAt(SaveSettings, Message.Text);
                Assert.IsTrue(Browser.IsAt(isat));
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
        public void ChangeBasicSettings(ChangeBasicSettings ChangeBasicSettings)
        {
            try
            {
                BasicSettingTab.Click();
                DivExpansion DivExpansionI = new DivExpansion(BasicSettingDiv, 5);
                DivExpansion(DivExpansionI);
                ClearAndFillTextBox PortalTitleClearNFill = new ClearAndFillTextBox(PortalTitleTextBox, ChangeBasicSettings.PortalTitle);
                Browser.ClearAndFillTextBox(PortalTitleClearNFill);
                ClearAndFillTextBox PortalDescriptionClearNFill = new ClearAndFillTextBox(PortalDescriptionTextBox, ChangeBasicSettings.PortalDescription);
                Browser.ClearAndFillTextBox(PortalDescriptionClearNFill);
                ClearAndFillTextBox KeyWordsClearNFill = new ClearAndFillTextBox(KeyWordsTextBox, ChangeBasicSettings.KeyWords);
                Browser.ClearAndFillTextBox(KeyWordsClearNFill);
                ClearAndFillTextBox GoogleAdSenseIDClearNFill = new ClearAndFillTextBox(GoogleAdSenseIDTextBox, ChangeBasicSettings.GoogleAdSenseID);
                Browser.ClearAndFillTextBox(GoogleAdSenseIDClearNFill);
                switch (ChangeBasicSettings.ShowProfileLink)
                {
                    case true:
                        {
                            ProfileLinkYesRadioButton.Click();
                            break;
                        }
                    default:
                        {
                            ProfileLinkNoRadioButton.Click();
                            break;
                        }
                }
                ChkBox EnableCDNChkBox = new ChkBox(ChangeBasicSettings.EnableCDN, EnableCDNCheckBox);
                ChkBox EnableSessionTrackerChkBox = new ChkBox(ChangeBasicSettings.EnableSessionTracker, EnableSessionTrackerCheckBox);
                ChkBox EnableOptimizationCssChkBox = new ChkBox(ChangeBasicSettings.EnableOptimizationCSS, EnableOptimizeCSSCheckBox);
                ChkBox EnableOptimizationJsChkBox = new ChkBox(ChangeBasicSettings.EnableOptimizationJs, EnableOptimizeJSCheckBox);
                ChkBox EnableDashboarLiveFeedsChkBox = new ChkBox(ChangeBasicSettings.EnableDashboardLiveFeeds, DashBoardLiveFeedsCheckBox);
                Browser.CheckBox(EnableCDNChkBox);
                Browser.CheckBox(EnableSessionTrackerChkBox);
                Browser.CheckBox(EnableOptimizationCssChkBox);
                Browser.CheckBox(EnableOptimizationJsChkBox);
                Browser.CheckBox(EnableDashboarLiveFeedsChkBox);
                switch (ChangeBasicSettings.OpenIdEnable)
                {
                    case true:
                        {
                            if (!OpenIDEnableCheckBox.Selected)
                            {
                                OpenIDEnableCheckBox.Click();
                            }
                            ClearAndFillTextBox FacebookConsumerKeyClearNFill = new ClearAndFillTextBox(FacebookConsumerKeyTextBox, ChangeBasicSettings.FbConsumerKey);
                            Browser.ClearAndFillTextBox(FacebookConsumerKeyClearNFill);
                            ClearAndFillTextBox FacebookSecretKeyClearNFill = new ClearAndFillTextBox(FacebookSecretKeyTextBox, ChangeBasicSettings.FbSecretKey);
                            Browser.ClearAndFillTextBox(FacebookSecretKeyClearNFill);
                            ClearAndFillTextBox LinkedInConsumerKeyClearNFill = new ClearAndFillTextBox(LinkedInConsumerKeyTextBox, ChangeBasicSettings.LIConsumerKey);
                            Browser.ClearAndFillTextBox(LinkedInConsumerKeyClearNFill);
                            ClearAndFillTextBox LinkedInSecretKeyClearNFill = new ClearAndFillTextBox(LinkedInSecretKey, ChangeBasicSettings.LISecretKey);
                            Browser.ClearAndFillTextBox(LinkedInSecretKeyClearNFill);
                            break;
                        }
                    default:
                        {
                            if (OpenIDEnableCheckBox.Selected)
                            {
                                OpenIDEnableCheckBox.Click();
                            }
                            break;
                        }
                }
                switch (ChangeBasicSettings.SaveBasicSettings)
                {
                    case true:
                        {
                            SaveButton.Click();
                            SaveSettingsConfirm();
                            break;
                        }
                    default:
                        {
                            RefreshButton.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
        public void ChangeAdvancedSettings(ChangeAdvancedSettings ChangeAdvancedSettings)
        {
            try
            {
                AdvanceSettingTab.Click();
                Browser.Wait();
                DivExpansion DivExpansionI = new DivExpansion(AdvancedSettingDiv, 4);
                DivExpansion(DivExpansionI);
                switch (ChangeAdvancedSettings.UserRegistration)
                {
                    case "None":
                        {
                            NoneRadioButton.Click();
                            break;
                        }
                    case "Private":
                        {
                            PrivateRadioButton.Click();
                            break;
                        }
                    case "Public":
                        {
                            PublicRadioButton.Click();
                            break;
                        }
                    case "Verified":
                        {
                            VerifiedRadioButton.Click();
                            break;
                        }
                }

                DropDownSelect LoginDropDown = new DropDownSelect(ChangeAdvancedSettings.LoginPage, LoginPageDropDown);
                DropDownSelect PortalDefaultDropDown = new DropDownSelect(ChangeAdvancedSettings.PortalDefaultPage, PortalDefaultPageDropDown);
                DropDownSelect UserProfileDropDown = new DropDownSelect(ChangeAdvancedSettings.UserProfilePage, UserProfilePageDropDown);
                DropDownSelect UserRegistrationDropDown = new DropDownSelect(ChangeAdvancedSettings.UserRegistrationPage, UserRegistrationPageDropDown);
                DropDownSelect UserActivationDropDown = new DropDownSelect(ChangeAdvancedSettings.UserActivationPage, PortalUserActivationDropDown);
                DropDownSelect ForgotPasswordDropDown = new DropDownSelect(ChangeAdvancedSettings.UserForgotPasswordPage, PortalForgotPasswordDropDown);
                DropDownSelect PageNotAccessibleDropDown = new DropDownSelect(ChangeAdvancedSettings.PageNotAccessiblePage, PortalPageNotAccessibleDropDown);
                DropDownSelect PageNotFoundDropDown = new DropDownSelect(ChangeAdvancedSettings.PageNotFoundPage, PortalPageNotFoundDropDown);
                DropDownSelect PasswordRecoveryDropDown = new DropDownSelect(ChangeAdvancedSettings.PasswordRecoveryPage, PortalPasswordRecoveryDropDown);
                Browser.SelectDropdown(LoginDropDown);
                Browser.SelectDropdown(PortalDefaultDropDown);
                Browser.SelectDropdown(UserProfileDropDown);
                Browser.SelectDropdown(UserRegistrationDropDown);
                Browser.SelectDropdown(UserActivationDropDown);
                Browser.SelectDropdown(ForgotPasswordDropDown);
                Browser.SelectDropdown(PageNotAccessibleDropDown);
                Browser.SelectDropdown(PageNotFoundDropDown);
                Browser.SelectDropdown(PasswordRecoveryDropDown);
                switch (ChangeAdvancedSettings.MessageSetting)
                {
                    case "Default":
                        {
                            AdvanceSetting_rdbDefaultRadioButton.Click();
                            break;
                        }
                    case "Custom":
                        {
                            AdvanceSetting_rdbCustomRadioButton.Click();
                            break;
                        }
                }
                switch (ChangeAdvancedSettings.MessageType)
                {
                    case "Success":
                        {
                            SuccessMessageLink.Click();
                            break;
                        }
                    case "Error":
                        {
                            ErrorMessageLink.Click();
                            break;
                        }
                    case "Alert":
                        {
                            AlertMessageLink.Click();
                            break;
                        }
                }
                DropDownSelect DropDownDefaultLanguage = new DropDownSelect(ChangeAdvancedSettings.DefaultLanguage, DefaultLanguageDropDown);
                Browser.SelectDropdown(DropDownDefaultLanguage);
                switch (ChangeAdvancedSettings.LanguageType)
                {
                    case "English":
                        {
                            EnglishLanguageRadioButton.Click();
                            break;
                        }
                    case "Naive":
                        {
                            NaiveLanguageRadioButton.Click();
                            break;
                        }
                }
                DropDownSelect DropDownPoratlTimeZone = new DropDownSelect(ChangeAdvancedSettings.PortalTimeZone.ToString(), PortalTimeZoneDropDown);
                Browser.SelectDropdown(DropDownPoratlTimeZone);
                ClearAndFillTextBox SiteAdminEmailAddressClearNFill = new ClearAndFillTextBox(SiteAdminEmailAddressTextBox, ChangeAdvancedSettings.SiteAdminEmailAddress);
                Browser.ClearAndFillTextBox(SiteAdminEmailAddressClearNFill);
                ClearAndFillTextBox LogoTemplateClearNFill = new ClearAndFillTextBox(LogoTemplateTextBox, ChangeAdvancedSettings.LogoTemplate);
                Browser.ClearAndFillTextBox(LogoTemplateClearNFill);
                ClearAndFillTextBox CopyRightClearNFill = new ClearAndFillTextBox(CopyRightTextBox, ChangeAdvancedSettings.CopyRight);
                Browser.ClearAndFillTextBox(CopyRightClearNFill);
                switch (ChangeAdvancedSettings.SaveAdvancedSettings)
                {
                    case true:
                        {
                            SaveButton.Click();
                            SaveSettingsConfirm();
                            break;
                        }
                    default:
                        {
                            RefreshButton.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void ExpandingDiv()
        {
            try
            {
                int i;
                for (i = 1; i < 4; i++)
                {
                    IList<IWebElement> DivCollaspeWrapper = SuperUserSettingsDiv.FindElements(By.ClassName("sfCollapsewrapper"));
                    switch (i)
                    {
                        case 0:
                            {
                                IWebElement AccordianDiv = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[1];
                                IWebElement Accordianholder = AccordianDiv.FindElement(By.TagName("div"));
                                string Accordianholdertext = Accordianholder.GetAttribute("class");
                                IWebElement Accordianheader = Accordianholder.FindElement(By.TagName("div"));
                                if (Accordianholdertext == "sfAccordianholder")
                                {
                                    Accordianheader.Click();
                                }
                                break;
                            }
                        default:
                            {
                                IWebElement DivAccordian = DivCollaspeWrapper[i].FindElements(By.TagName("div"))[0];
                                IWebElement DivAccordianholder = DivAccordian.FindElement(By.TagName("div"));
                                string DivAccordianholdertext = DivAccordianholder.GetAttribute("class");
                                IWebElement DivAccordianheader = DivAccordianholder.FindElement(By.TagName("div"));
                                if (DivAccordianholdertext == "sfAccordianholder")
                                {
                                    DivAccordianheader.Click();
                                }
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void ChangeSuperUserSettings(ChangeSuperUserSettings ChangeSuperUserSettings)
        {
            try
            {
                SuperUserSettingsTab.Click();
                Browser.Wait();
                ExpandingDiv();
                ClearAndFillTextBox SiteTitleClearNFill = new ClearAndFillTextBox(SiteTitleTextBox, ChangeSuperUserSettings.SiteTitle);
                Browser.ClearAndFillTextBox(SiteTitleClearNFill);
                ClearAndFillTextBox SiteUrlClearNFill = new ClearAndFillTextBox(SiteUrlTextBox, ChangeSuperUserSettings.SiteUrl);
                Browser.ClearAndFillTextBox(SiteUrlClearNFill);
                ClearAndFillTextBox SiteEmailClearNFill = new ClearAndFillTextBox(SiteEmailTextBox, ChangeSuperUserSettings.SiteEmail);
                Browser.ClearAndFillTextBox(SiteEmailClearNFill);
                ChkBox CopyrightChkBox = new ChkBox(ChangeSuperUserSettings.CopyrightEnable, CopyrightCheckBox);
                ChkBox CustomErrorChkBox = new ChkBox(ChangeSuperUserSettings.CustomError, CustomErrorMessagesCheckBox);
                Browser.CheckBox(CopyrightChkBox);
                Browser.CheckBox(CustomErrorChkBox);
                ClearAndFillTextBox SMTPServerAndPortClearNFill = new ClearAndFillTextBox(SMTPServerAndPortTextBox, ChangeSuperUserSettings.SMTPServerAndPort);
                Browser.ClearAndFillTextBox(SMTPServerAndPortClearNFill);
                switch (ChangeSuperUserSettings.SMTPBasic)
                {
                    case true:
                        {
                            SMTPAuthenticationBasicRadioButton.Click();
                            Browser.Wait();
                            ExpandingDiv();
                            ClearAndFillTextBox SMTPUserNameClearNFill = new ClearAndFillTextBox(SMTPUserNameTextBox, ChangeSuperUserSettings.SMTPUserName);
                            Browser.ClearAndFillTextBox(SMTPUserNameClearNFill);
                            ClearAndFillTextBox SMTPPasswordClearNFill = new ClearAndFillTextBox(SMTPPasswordTextBox, ChangeSuperUserSettings.SMTPPassword);
                            Browser.ClearAndFillTextBox(SMTPPasswordClearNFill);
                            break;
                        }
                    default:
                        {
                            SMTPAuthenticationAnoymousRadioButton.Click();
                            break;
                        }
                }
                ChkBox EnableSSLChkBox = new ChkBox(ChangeSuperUserSettings.EnableSSL, SMTPEnableSSLCheckBox);
                Browser.CheckBox(EnableSSLChkBox);
                ClearAndFillTextBox FileExtensionsHelpUrlClearNFill = new ClearAndFillTextBox(FileExtensionsHelpUrl, ChangeSuperUserSettings.FileExtensions);
                Browser.ClearAndFillTextBox(FileExtensionsHelpUrlClearNFill);
                ClearAndFillTextBox HelpUrlClearNFill = new ClearAndFillTextBox(HelpUrlTextBox, ChangeSuperUserSettings.HelpUrl);
                Browser.ClearAndFillTextBox(HelpUrlClearNFill);
                ClearAndFillTextBox PageExtensionClearNFill = new ClearAndFillTextBox(PageExtensionTextBox, ChangeSuperUserSettings.PageExtension);
                Browser.ClearAndFillTextBox(PageExtensionClearNFill);
                ChkBox EnableSchedulerChkBox = new ChkBox(ChangeSuperUserSettings.EnableScheduler, EnableSchedulerCheckBox);
                Browser.CheckBox(EnableSchedulerChkBox);
                switch (ChangeSuperUserSettings.UserAgent)
                {
                    case "PC":
                        {
                            PCRadioButton.Click();
                            break;
                        }
                    case "Mobile":
                        {
                            MobileRadioButton.Click();
                            break;
                        }
                    case "Default":
                        {
                            DefaultRadioButton.Click();
                            break;
                        }
                }
                ClearAndFillTextBox ServerCookieExpirationClearNFill = new ClearAndFillTextBox(ServerCookieExpirationTextBox, ChangeSuperUserSettings.ServerCookieExpirationTime);
                Browser.ClearAndFillTextBox(ServerCookieExpirationClearNFill);
                if (ChangeSuperUserSettings.TestSMTP)
                {
                    TestSMTPButton.Click();
                }
                switch (ChangeSuperUserSettings.SaveSuperUserSettings)
                {
                    case true:
                        {
                            SaveButton.Click();
                            SaveSettingsConfirm();
                            break;
                        }
                    default:
                        {
                            RefreshButton.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
    }
}

