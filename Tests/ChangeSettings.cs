using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class ChangeSettings
    {
        [TestMethod]
        public void Can_ChangeBasicSettins()
        {
            try
            {
                Browser.GoTo(Settings.SettingPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Settings.SettingPage.Text));
                //Settings.SettingPage.ChangeBasicSettings("www.sageframe.com", "www.sageframe.com", "www.sageframe.com", "pub-1427651338796450", true, false, true, false, false, true, true, "276571315797718", "35a35c105f883b3a35953d88e33a3047", "mhziyr2sgko6", "4p0SoFgdkEuhf277", true);
                //Settings.SettingPage.ChangeAdvancedSettings("None", "Login", "Home", "User Profile", "User Registration", "User Activation", "Forgot Password", "Page Not Accessible", "Page Not Found", "Password Recovery", "Default", "Success", "English(United States)", "English", "(UTC -12:00) International Dateline West", "admin@sageframe.com", "C-Panel", "Copyright 2015 SageFrame.com. All Rights Reserved®", true);
                Settings.SettingPage.ChangeSuperUserSettings("SageFrame", "http://www.sageframe.com", "info@sageframe.com", true, true, "192.168.3.7:25", true, false, "testsmtp", "testsmtp", "swf#jpg#jpeg#jpe#gif#bmp#png#doc#docx#xls#xlsx#ppt#pptx#pdf#txt#xml#xsl#css#zip#template", "http://www.sageframe.com", ".aspx", "PC", true, "100", true, true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
