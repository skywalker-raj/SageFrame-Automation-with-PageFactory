using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QASageframe
{
    public static class ExcelImports
    {
        public static string[] ExcelImport()
        {
            try
            {
                Excel.Application xlap = new Microsoft.Office.Interop.Excel.Application();
                if (xlap == null)
                {
                    MessageBox.Show("Excel not installed properly.");
                    return null;
                }
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range range;
                string str;
                string[] Save = new string[1000];
                int rCnt = 0;
                int cCnt = 0;
                int i = 0;
                xlWorkBook = xlap.Workbooks.Open(@"C:\Users\RajKumar-PC\Downloads\MyReport_FormBuilder_8_11_2015_14_8_49.xls", 0, true, 2, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, ",", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;
                for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
                {
                    for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                    {
                        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                        Save[i] = str;
                        i++;
                    }
                }
                xlWorkBook.Close(true, null, null);
                xlap.Quit();
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlap);
                return Save;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }            
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 
    }
}
