using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class DeleteUser
    {
        [TestMethod]
        public void Can_DeleteUser()
        {
            try
            {
                Browser.GoTo(User.UserPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
                //Admin.AdminPage.Users();
                User.UserPage.DelUser(2, false);
                //Assert.IsTrue(User.UserPage.UserDeleted());
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
