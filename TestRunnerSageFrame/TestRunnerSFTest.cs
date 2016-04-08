using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SageframeTest;
using QASageframe;
namespace TestRunnerSageFrame
{
    public class TestRunnerSFTest
    {       
        static void Main(string[] args)
        {
            //string[] Username = { "superuser", "admin" };
            //string[] Password = { "superuser", "admin" };
            Login[] logincreds = {
                    new Login ("superuser", "superuser"), 
                    new Login ( "admin", "admin" )
                        };
            SageFrameTest SFTest = new SageFrameTest();
            foreach(Login login in logincreds)
            {
                SFTest.LoginOperation();
            }
        }
    }
}
