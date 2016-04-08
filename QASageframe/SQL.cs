using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class SQLPageFunction
    {
        public bool ArchiveSession { get; set; }
        public bool BackupDataBase { get; set; }
        public bool CleanUpScript { get; set; }
        public bool UploadFile { get; set; }
        public string FilePath { get; set; }
        public string SqlScript { get; set; }
        public bool RunAsScript { get; set; }
        public SQLPageFunction(bool archivesession, bool backupdatabase, bool cleanupscript, bool uploadfile, string filepath, string sqlscript, bool runasscript)
        {
            ArchiveSession = archivesession;
            BackupDataBase = backupdatabase;
            CleanUpScript = cleanupscript;
            UploadFile = uploadfile;
            FilePath = filepath;
            SqlScript = sqlscript;
            RunAsScript = runasscript;
        }
    }
    #endregion
    public static class SQL
    {
        public static SQLPage SQLPage
        {
            get
            {
                var sqlpage = new SQLPage();
                PageFactory.InitElements(Browser.Driver, sqlpage);
                return sqlpage;
            }
        }
    }
    public class SQLPage
    {
        public string Url = "Admin/SQL.aspx";
        public string Text = "SQL";
        #region
        //SQLPage
        [FindsBy(How = How.Id, Using = "ctl19_fluSqlScript")][CacheLookup]
        public IWebElement FileUpload { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtSqlQuery")][CacheLookup]
        public IWebElement SQLQueryTextArea { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkRunAsScript")][CacheLookup]
        public IWebElement RunAsScriptCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "divBottompanel")]
        public IWebElement BottomPanelDiv { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_btnDatabasebackup")][CacheLookup]
        //public IWebElement DatabaseBackupBtnImg {get; set;}
        //[FindsBy(How = How.Id, Using = "ctl19_btnSageFrameCleanup")][CacheLookup]
        //public IWebElement CleanUpBtnImg {get; set;}
        //[FindsBy(How = How.Id, Using = "ctl19_imbUploadSqlScript")][CacheLookup]
        //public IWebElement UploadSqlScriptBtnImg {get; set;}
        //[FindsBy(How = How.XPath, Using = ".//*[@id='divBottompanel']/div/div/div[2]/table/tbody/tr[3]/td/div/label")]
        //[CacheLookup]
        //public IWebElement ExecuteSqlBtn { get; set; }
        #endregion       
        public void SQLPageFunctions(SQLPageFunction SQLPageFunction)
        {
            try
            {
                IWebElement BottomDiv = BottomPanelDiv.FindElement(By.TagName("div"));
                IWebElement ModuleContentDiv = BottomDiv.FindElement(By.TagName("div"));
                IList<IWebElement> WrapperDiv = ModuleContentDiv.FindElements(By.TagName("div"));
                IWebElement LocaleWrapper = WrapperDiv[0];
                IWebElement ButtonWrapper = WrapperDiv[1];
                //Buttons
                IList<IWebElement> LocaleButton = LocaleWrapper.FindElements(By.TagName("label"));
                IWebElement Table = ButtonWrapper.FindElement(By.TagName("table"));
                IWebElement Tbody = Table.FindElement(By.TagName("tbody"));
                IList<IWebElement> tr = Tbody.FindElements(By.TagName("tr"));
                IWebElement Uploadtr = tr[0];
                IWebElement Executetr = tr[2];
                if (SQLPageFunction.ArchiveSession)
                {
                    LocaleButton[0].Click();
                }
                if (SQLPageFunction.BackupDataBase)
                {
                    LocaleButton[1].Click();
                }
                if (SQLPageFunction.CleanUpScript)
                {
                    LocaleButton[2].Click();
                }
                switch (SQLPageFunction.RunAsScript)
                {
                    case true:
                        {
                            if (!RunAsScriptCheckBox.Selected)
                            {
                                RunAsScriptCheckBox.Click();
                            }
                            break;
                        }
                    default:
                        {
                            if (RunAsScriptCheckBox.Selected)
                            {
                                RunAsScriptCheckBox.Click();
                            }
                            break;
                        }
                }
                switch (SQLPageFunction.UploadFile)
                {
                    case true:
                        {
                            FileUpload.SendKeys(SQLPageFunction.FilePath);
                            //Upload
                            IWebElement Uploadtd = Uploadtr.FindElements(By.TagName("td"))[0];
                            IWebElement UploadButtonWrapper = Uploadtd.FindElement(By.TagName("div"));
                            IWebElement UploadSqlScriptBtn = UploadButtonWrapper.FindElement(By.TagName("label"));
                            UploadSqlScriptBtn.Click();
                            break;
                        }
                    default:
                        {
                            ClearAndFillTextBox SQLQueryClearNFill = new ClearAndFillTextBox(SQLQueryTextArea, SQLPageFunction.SqlScript);
                            Browser.ClearAndFillTextBox(SQLQueryClearNFill);
                            break;
                        }
                }
                //Execute
                //IWebElement Executetd = Executetr.FindElement(By.TagName("td"));
                //IWebElement ExecuteButtonWrapper = Executetd.FindElement(By.TagName("div"));
                //IWebElement ExecuteSqlBtn = ExecuteButtonWrapper.FindElement(By.TagName("label"));
                IWebElement ExecuteSqlBtn = Browser.Driver.FindElement(By.XPath(".//*[@id='divBottompanel']/div/div/div[2]/table/tbody/tr[3]/td/div/label"));
                ExecuteSqlBtn.Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
