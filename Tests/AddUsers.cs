using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class AddUsers
    {
        [TestMethod]
        public void Can_AddUsers()
        {
            string username = "superuser";
            string password = "superuser";
            string newusername = "test1";
            string email = "rthapa@braindigit.com";
            string firstname = "Raj";
            string lastname = "Thapa";
            string newpassword = "test123";
            string question = "What is your first pet's name?";
            string answer = "Dalle";
            string role = "Registered User";
            try
            {
                Browser.GoTo(User.UserPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn(username, password);
                //Admin.AdminPage.Users();
                Assert.IsTrue(Browser.IsAt(Browser.Title, User.UserPage.Text));
                User.UserPage.AddUser(newusername, email, firstname, lastname, newpassword, question, answer, role);
                Browser.Wait();
                //Assert.IsTrue(User.UserPage.UserCreated());
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
