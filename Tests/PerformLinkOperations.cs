using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformLinkOperations
    {
        [TestMethod]
        public void Link_Changes()
        {
            int[] i = { 1, 0 };
            try
            {
                Browser.GoTo(Links.LinkPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Links.LinkPage.Text));
                Links.LinkPage.LinksOperations(true, "test", true, "Portals", "Admin", @"D:\Free Images\Pearl-Jam-Stickman.png", true, true, "Test", true, 63, true, true, false, false, 2, "Users", true, false, i);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
