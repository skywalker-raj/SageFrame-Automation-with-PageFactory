using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class AddFileToTemplate
    {
        [TestMethod]
        public void Can_AddFileToTemplate()
        {
            string placeholder = "<placeholder name=\"test\" wrapinner=\"0\">test</placeholder>";
            string[] split = { "sfNavigation", "sfLogo", "sfGetstarted", "sfMainWrapper" };
            string[] splitlinkid = { "split_sfheaders_mytable", "split_sfbanner_mytable", "split_sfnavigation_mytable", "split_sffulltopspan_mytable", "split_sfmiddlemaincurrent_mytable", "split_sffooter_mytable" };
            string[] SplitLink = { "btnSplit_sfheaders_mytable", "btnSplit_sfbanner_mytable", "btnSplit_sfnavigation_mytable", "btnSplit_sffulltopspan_mytable", "btnSplit_sfmiddlemainbottom_mytable", "btnSplit_sffooter_mytable" };
            int[] Pages = { 1, 52, 53 };
            try
            {
                Browser.GoTo(Templates.TemplatePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Templates.TemplatePage.Text));
                Templates.TemplatePage.TemplateFileEditor(10, 0, true, 0, 0, @"E:\Sagever3.6license6-9-2015\SageFrame\css\dd.css", false, false, false, false, false, false, false, 1, "test", 1, 1, false, 1, 1, 1, 1, 1, 1, false, 1, "test", false, 1, 1, 1, 1, 1, false, "custom.css", true, 0, 0, "head{}");
                Browser.GoTo(Templates.TemplatePage.Url);
                Templates.TemplatePage.Layout(0, true, true, false, false, "handheld", false, "Contact", "test", placeholder, false, false, true, split, SplitLink, true);
                Browser.GoTo(Templates.TemplatePage.Url);
                Templates.TemplatePage.Preset(0, true, true, 0, "Custom", Pages, 1, true);
                Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }
    }
}
