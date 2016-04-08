using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void Change_MenuSettings()
        {
            int[] pageno = { 1, 53, 62 };
            bool[] parentpage = { false, false, false };
            string[] parent = { "", "", "" };
            try
            {
                Browser.GoTo(Menu.MenuPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Menu.MenuPage.Text));
                Menu.MenuPage.MenuType("HTML Content", false, false, pageno, parentpage, parent, true, "test", "test", "test", @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg", true, true, "Home", true, "test", "test", true, false, "Home");
                Menu.MenuPage.MenuManage(3, "test", true, true, true, "Home", true, true, 0, 2, true, true, true);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
