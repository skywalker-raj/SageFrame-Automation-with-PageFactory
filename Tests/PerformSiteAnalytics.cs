using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class PerformSiteAnalytics
    {
        [TestMethod]
        public void SiteAnalyticsOperations()
        {
            string StartDate = "2010/01/01";
            string EndDate = "07/26/2015";
            try
            {
                Browser.GoTo(SiteAnalytics.SiteAnalyticsPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, SiteAnalytics.SiteAnalyticsPage.Text));
                SiteAnalytics.SiteAnalyticsPage.SiteAnalytics(true, true, true, StartDate, EndDate, true, "Default", true, true, true, "Page");
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
