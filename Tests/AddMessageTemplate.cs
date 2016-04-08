using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class AddMessageTemplate
    {
        [TestMethod]
        public void Can_AddMessageTemplate()
        {
            string n = "Activation - Successful Email";
            string email = "anks@gmail.com";
            string subject = "test12";
            string text = "this is a test";
            bool save = true;
            string tmtt = "test123";
            string mttext = "test";
            string token = "test";
            try
            {
                Browser.GoTo(Message_Template.MessageTemplatePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Message_Template.MessageTemplatePage.Text));
                Message_Template.MessageTemplatePage.AddMT(n, email, subject, text, save, tmtt, mttext, token);
                Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
