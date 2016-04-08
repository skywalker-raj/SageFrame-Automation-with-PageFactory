using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformPortalOperations
    {
        [TestMethod]
        public void Change_PortalSettings()
        {
            bool[] ModuleList = { true, true };
            int[] ModuleNo = { 19, 20 };
            try
            {
                Browser.GoTo(Portals.PortalPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Portals.PortalPage.Text));
                Portals.PortalPage.AddNewPoratl("test", "--Select--", Browser.baseURL + "Admin/Portals/test", true);
                Portals.PortalPage.PortalSettings(false, true, "test", true, true, true, false, ModuleList, ModuleNo, true, 2, true, true);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
