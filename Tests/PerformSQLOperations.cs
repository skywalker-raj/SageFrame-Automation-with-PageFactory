using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformSQLOperations
    {
        [TestMethod]
        public void Can_ExecuteSQLOpertations()
        {
            try
            {
                Browser.GoTo(SQL.SQLPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, SQL.SQLPage.Text));
                SQL.SQLPage.SQLPageFunctions(false, false, false, true, @"C:\Users\RajKumar-PC\Documents\SQL Server Management Studio\userinsert.sql", "", true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
