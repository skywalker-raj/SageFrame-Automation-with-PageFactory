using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class AddRoles
    {
        [TestMethod]
        public void Can_AddRole()
        {
            string username = "superuser";
            string password = "superuser";
            string rolename = "testrole";
            //PageRole
            int[] n = { 1, 2, 3 };
            string PageType = "Portal";
            int[] pageno = { 1, 3, 4, 5 };
            bool[] AnonymousCheckView = { true, true, true, true };
            bool[] AnonymousCheckEdit = { false, false, false, false };
            bool[] AdminCheckView = { true, true, true, true };
            bool[] AdminCheckEdit = { true, true, true, true };
            bool[] RegisteredUserCheckView = { true, true, true, true };
            bool[] RegisteredUserCheckEdit = { true, false, false, true };
            bool[] Save = { true, true, true, true };
            //DashboardRole
            string[] RoleOperation = { "Add", "Remove" };
            bool SaveRole = true;
            string[] SelectRole = { "Registered User", "Site Admin" };
            string[] UnSelectRole = { "Registered User" };
            try
            {
                Browser.GoTo(Role.RolePage.Url);
                //message role page goto succesful
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                //role page navigaed successful
                Admin.AdminPage.LogIn(username, password);
                //role is of superuser 
                Assert.IsTrue(Browser.IsAt(Browser.Title, Role.RolePage.Title));
                //Admin.AdminPage.Roles();
                Role.RolePage.AddRole(rolename);
                //rolled addded succesful
                Role.RolePage.PageRoleSettings(n, PageType, pageno, AnonymousCheckView, AnonymousCheckEdit, AdminCheckView, AdminCheckEdit, RegisteredUserCheckView, RegisteredUserCheckEdit, Save);
                Role.RolePage.DashboardRoleSettings(RoleOperation, SaveRole, SelectRole, UnSelectRole);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
