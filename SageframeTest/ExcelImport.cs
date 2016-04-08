//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestFixture]
    public class ExcelImport
    {
        [Test]
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
