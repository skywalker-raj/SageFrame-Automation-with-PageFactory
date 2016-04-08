using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PageOperations
    {
        [TestMethod]
        public void Perform_PageOperations()
        {
            string PageType = "Portal";
            string PageName = "Name";
            string PageTitle = "Title";
            string Description = "Description";
            string KeyWords = "KeyWords";
            string Caption = "Caption";
            string Parent = "Home";
            int RefreshInterval = 10;
            bool DashboardCheck = true;
            bool MenuCheck = true;
            string MenuName = "Main Menu";
            bool[] AnonymousPermission = { true, false };
            bool[] SiteAdminPermission = { true, true };
            bool[] RegisteredUserPermission = { true, true };
            bool PageSave = true;
            string Operation = "Edit";
            int n = 3;
            string FilePath = "D:\\snips\\Templating\\Fair_Trade_Certified_mark.png";
            string Page = "Home";
            int PageNo = 2;
            string Layout = "oneColumnLayout";
            bool SaveLayout = true;
            string Mode = "PC";
            bool Publish = true;
            string ModuleID = "68";
            string Section = "Banner";
            string ModuleTitle = "TestModule";
            bool Header = true;
            string HeaderText = "TestHeader";
            string ModuleSuffixClass = "TestSuffixClass";
            bool IsActive = true;
            string ShowInPages = "Customize";
            string[] CustomPages = { "1", "52", "78" };
            string Preferences = "Custom";
            bool DonotShow = false;
            bool Save = true;
            bool ParentReq = false;
            try
            {
                Browser.GoTo(Pages.PagesClass.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Pages.PagesClass.Text));
                Pages.PagesClass.CreatePage(PageType, PageName, PageTitle, Description, KeyWords, Caption, ParentReq, Parent, RefreshInterval, DashboardCheck, MenuCheck, MenuName, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, PageSave, FilePath);
                //Pages.PagesClass.PageManagement(Operation, n, PageType, PageName, PageTitle, Description, KeyWords, Caption, ParentReq, Parent, RefreshInterval, DashboardCheck, MenuCheck, MenuName, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, PageSave, FilePath, false);
                //Pages.PagesClass.SearchPage(Page); 
                //Pages.PagesClass.ModulePagination(PageNo);
                //Pages.PagesClass.Page(n, Layout, SaveLayout, Mode, Publish, ModuleID, Section, ModuleTitle, Header, HeaderText, ModuleSuffixClass, IsActive, ShowInPages, CustomPages, Preferences, AnonymousPermission, SiteAdminPermission, RegisteredUserPermission, DonotShow, Save);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
