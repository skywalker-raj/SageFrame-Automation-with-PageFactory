using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformCDNChanges
    {
        [TestMethod]
        public void Can_PerformChanges()
        {
            string[] Js = { "testjs1", "testjs2" };
            string[] Css = { "testcss1", "testcss2" };
            string[] NewJs = { "jstest1", "jstest2" };
            string[] NewCss = { "csstest1", "csstest2" };
            try
            {
                Browser.GoTo(CDN.CDNPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, CDN.CDNPage.Text));
                CDN.CDNPage.CDNChanges(true, Js, true, Css, true, 5, true, true, true, true, true, NewJs, NewCss, true, true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
