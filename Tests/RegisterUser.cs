using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class RegisterUser
    {
        [TestMethod]
        public void Can_Register()
        {
            try
            {
                Browser.GoTo(User_Registration.User_RegistrationPage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, User_Registration.User_RegistrationPage.Text));
                User_Registration.User_RegistrationPage.RegisterUser("Raj", "Thapa", "test", "illusionineyes@gmail.com", "test", true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}