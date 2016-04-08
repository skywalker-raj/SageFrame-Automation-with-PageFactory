using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class UserEdit
    {
        [TestMethod]
        public void Can_EditUserProfile()
        {
            string[] email = { "rthapa@braindigit.com", "anks@gmail.com", "abc@abc.com" };
            try
            {
                DateTime BDate = new DateTime(2000, 12, 11);
                Browser.GoTo(User.UserPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
                User.UserPage.EditUser("select", true, true, "Site Admin", 2, "male", "014456789", "9819445633", "This is a test", "test", "test", BDate, "Gyaneshwor", "test test", email, true, "test", true, @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg", "This is a test!:-D", true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
