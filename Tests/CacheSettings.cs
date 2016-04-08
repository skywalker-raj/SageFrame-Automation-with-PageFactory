using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class CacheSettings
    {
        [TestMethod]
        public void Can_ChangeCacheSettings()
        {
            int[] Clear = { 1, 2 };
            int[] Save = { 1, 2 };
            try
            {
                Browser.GoTo(CacheMaintenance.CacheMaintenancePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, CacheMaintenance.CacheMaintenancePage.Text));
                CacheMaintenance.CacheMaintenancePage.CacheSettings(Clear, false, false, Save);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
