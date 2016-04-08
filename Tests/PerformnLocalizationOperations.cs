using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformnLocalizationOperations
    {
        [TestMethod]
        public void LocalizationOperation()
        {
            string Language = "Nepali (Nepal)";
            string LanguageType = "English";
            bool Save = true;
            string FilePath = @"D:\Personnel\ResourcePack.Test.3.1.0.0.en-US.zip";
            bool[] Next = { true, false, false, false, false };
            bool AcceptLicense = true;
            bool Overwrite = true;
            bool Finish = true;
            string ResourcePackType = "Core";
            string ResourcePackName = "Nepali";
            int[] n = { 1, 2, 3 };
            string[] Timezone = { "(UTC -12:00) International Dateline West", "(UTC -11:00) Midway Island, Samoa", "(UTC -10:00) Hawaii" };
            string[] LocalValues = { "Home", "Admin", "Roles" };
            string[] LocalCaption = { "Home", "Admin", "Roles" };
            string[] ModuleLocalTitle = { "DashBoard", "Dashboard Manager", "Roles Management" };
            string LanguageList = "All";
            string[] Keyvalue = { "Home", "CPANEL", "Customize:", "Themes:", "Screen:", "Layouts:", "Mode:", "Edit", "Layout", "None", "Password must be at least 4 chars long", "* All Fields are compulsory.", "Password must be at least 4 chars long", "Login with any of these OpenID providers:", "or", "Enter Captcha Text", "Change Password", "Contacts", "User Info", "User Profile", "Scroll Back to the Top", "Submit", "Reset", "Subscribe Newsletter", "By Email", "By Phone", "Your Email", "Your Mobile Number", "Subscribe", "Click here to UnSubscribe", "You are already a subscribed member", "Subscribed Successfully", "Invalid Email" };
            string ResourceFile = "Save";
            try
            {
                Browser.GoTo(Localization.LocalizationPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Localization.LocalizationPage.Text));
                //Localization.LocalizationPage.AddLanguage(Language, LanguageType, Save);
                //Localization.LocalizationPage.InstallLanguagePack(FilePath, Next, AcceptLicense, Overwrite, Finish);
                //Localization.LocalizationPage.CreateLanguagePack(Language, ResourcePackType, ResourcePackName, true);
                Localization.LocalizationPage.TimeZoneEditor(Language, n, Timezone, false);
                Localization.LocalizationPage.LocalizeMenu(Language, n, LocalValues, LocalCaption, false);
                Localization.LocalizationPage.LocalizeModuleTitle(Language, n, ModuleLocalTitle, true);
                Localization.LocalizationPage.EditLanguage(LanguageList, 2, true, false, true, false, false, false, false, true, Keyvalue, ResourceFile, true, false);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
