using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class GenerateRobots
    {
        [TestMethod]
        public void Can_Generate_Robots()
        {
            int[] Pages = { 1, 2 };
            try
            {
                Browser.GoTo(SEO.SEOpage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, SEO.SEOpage.Text));
                SEO.SEOpage.GenerateRobots(true, true, true, true, Pages);
                SEO.SEOpage.GenerateSiteMap(0.2, "Always", true, true, true, true);
                SEO.SEOpage.AddGoogleJs("GoogleJS", true, true, false);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
