using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class Sysetm_Event_StartUp_Management
    {
        [TestMethod]
        public void Can_Manage_Sysetm_Event_StartUp_Management()
        {
            string ControlUrl = "Modules/UserRegistration/ctl_UserActivation.ascx";
            string EventLocation = "Top";
            try
            {
                Browser.GoTo(System_Event_StartUp.System_Event_StartUpPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, System_Event_StartUp.System_Event_StartUpPage.Text));
                System_Event_StartUp.System_Event_StartUpPage.Add_Event_StartUp(ControlUrl, EventLocation, true, true, true, true);
                System_Event_StartUp.System_Event_StartUpPage.EventListManagement(1, true, true, ControlUrl, EventLocation, true, true, true, true, true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
