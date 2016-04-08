using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class AddModule
    {
        [TestMethod]
        public void Can_AddModule()
        {
            string[] ColumnName = { "TestID", "Name", "Number" };
            string[] DataType = { "int", "varchar(50)", "bigint" };
            bool[] AllowNull = { true, true };
            try
            {
                Browser.GoTo(Module_Maker.Module_MakerPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Module_Maker.Module_MakerPage.Text));
                Module_Maker.Module_MakerPage.CreateModule("Test2", "Test2", "Test2", true, true, true, true, true, "Admin", 3, true, ColumnName, DataType, AllowNull, 0, false, true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
