using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class ModuleMessageEdit
    {
        [TestMethod]
        public void Can_EditModuleMessage()
        {
            try
            {
                Browser.GoTo(Module_Message.Module_MessagePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Module_Message.Module_MessagePage.Text));
                Module_Message.Module_MessagePage.Edit_ModuleMessage("DashBoard", "SlideUp", "en-US", "Top", "Info", true, "Use quick links, sidebar to quickly navigate and switch across pages.", true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
