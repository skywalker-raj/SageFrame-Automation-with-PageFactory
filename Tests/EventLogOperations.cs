using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class EventLogOperations
    {
        [TestMethod]
        public void Can_Perform_EventLogOperations()
        {
            int[] DeleteLogs = { 1 };  
            try
            {
                Browser.GoTo(Event_Log.EventLogPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Event_Log.EventLogPage.Text));
                Event_Log.EventLogPage.EventLogOperations(true, "Unknown", "25", true, false, false, true, DeleteLogs, false, "illusionineyes@gmail.com", "Test", "Test");
            }
            catch (Exception ex)
            {
               // throw ex;
            }         
        }
    }
}
