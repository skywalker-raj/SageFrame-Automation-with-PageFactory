using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class ExcelImport
    {
        [TestMethod]
        public void ImportDataFromExcel()
        {
            string[] testdata = ExcelImports.ExcelImport();
            int i = 0;
            string test;
            try
            {
                foreach (string s in testdata)
                {
                    test = testdata[i];
                    i++;
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
