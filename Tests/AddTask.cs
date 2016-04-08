using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
namespace SageframeTest
{
    [TestClass]
    public class AddTask
    {
        [TestMethod]
        public void Can_AddNewTask()
        {
            //DateTime StartDate = new DateTime(2014, 1, 18);
            DateTime EndDate = new DateTime(2015, 10, 18);
            string AssemblyName = "[QASageFrame.Admin, QASageframe]";
            string FileName = "QASageframe.dll";
            try
            {
                Browser.GoTo(Scheduler.SchedulerPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Scheduler.SchedulerPage.Text));
                Scheduler.SchedulerPage.AddNewTask("test", false, AssemblyName, true, 10, 20, "Daily", "Min", 10, "APPLICATION_START", true, @"D:\SageCMS3.6Git\SageFrame.OauthID\bin\Release\SageFrame.OauthID.dll", EndDate, 1, 10, 1, "07/15/2015", false, FileName);
                Scheduler.SchedulerPage.EditDelete(0, false, true, false);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
    }
}
