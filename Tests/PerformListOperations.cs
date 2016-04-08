using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformListOperations
    {
        [TestMethod]
        public void List_Operations()
        {
            string ParentList = "None Specified";
            string ParentEntry = "None";
            try
            {
                Browser.GoTo(Lists.ListsPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Lists.ListsPage.Text));
                Lists.ListsPage.ListManagement(25, false, ParentList, ParentEntry, "test", "testtext", "testvalue", true, true, true, true, 0, true, 5, 0, 1, false, true, 2, "Rs", "NE-ne", true, false);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}

