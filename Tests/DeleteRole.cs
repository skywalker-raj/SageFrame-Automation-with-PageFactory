using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class DeleteRole
    {
        [TestMethod]
        public void Can_DeleteRole()
        {
            try
            {
                Browser.GoTo(Role.RolePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Role.RolePage.Title));
                Role.RolePage.DelRole(1, true);
                //Assert.IsTrue(Role.RolePage.RoleDeleted());
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
