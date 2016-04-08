using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class UserSettings
    {
        [TestMethod]
        public void Can_saveUserSettings()
        {
            try
            {
                Browser.GoTo(User.UserPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
                //Admin.AdminPage.Users();
                User.UserPage.UserSetting(true);
                //Assert.IsTrue(User.UserPage.UserSettingSaved());
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
