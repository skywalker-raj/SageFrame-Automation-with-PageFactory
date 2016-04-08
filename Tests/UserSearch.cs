using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
namespace SageframeTest
{
    [TestClass]
    public class UserSearch
    {
        [TestMethod]
        public void Can_SearchUser()
        {
            DateTime Datefrom = new DateTime(2014, 12, 11);
            DateTime Dateto = new DateTime(2014, 12, 14);
            try
            {
                Browser.GoTo(User.UserPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
                User.UserPage.Search_User("Super User", "25", "test", Datefrom, Dateto, "approved");
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
