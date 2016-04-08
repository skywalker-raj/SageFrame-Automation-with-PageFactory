using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
namespace QASageframe
{
    #region
    public class EventLogOperations
    {
        public bool SendEmail { get; set; }
        public string LogType { get; set; }
        public string RecordsPerPage { get; set; }
        public bool ClearLog { get; set; }
        public bool DeleteSelectedLogs { get; set; }
        public bool ExportLogs { get; set; }
        public bool SelectAll { get; set; }
        public int[] DeleteLogs { get; set; }
        public bool DeleteIndividual { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public EventLogOperations(bool sendemail, string logtype, string recordsperpage, bool clearlog, bool deleteselectedlogs, bool exportlogs, bool selectall, int[] deletelogs, bool deleteindividual, string email, string subject, string message)
        {
            SendEmail = sendemail;
            LogType = logtype;
            RecordsPerPage = recordsperpage;
            ClearLog = clearlog;
            DeleteSelectedLogs = deleteselectedlogs;
            ExportLogs = exportlogs;
            SelectAll = selectall;
            DeleteLogs = deletelogs;
            DeleteIndividual = deleteindividual;
            Email = email;
            Subject = subject;
            Message = message;
        }
    }
    #endregion
    public static class Event_Log
    {
        public static EventLogPage EventLogPage
        {
            get
            {
                var eventlogpage = new EventLogPage();
                PageFactory.InitElements(Browser.Driver, eventlogpage);
                return eventlogpage;
            }
        }
    }
    public class EventLogPage
    {
        public string Url = "Admin/Event-Log.aspx";
        public string Text = "Event Log";
        #region
        //Send Exception Form
        [FindsBy(How = How.Id, Using = "ctl19_txtEmailAdd")][CacheLookup]
        public IWebElement EmailAddressTxtBox {get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_txtSubject1")][CacheLookup]
        public IWebElement SubjectTxtBox {get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_txtMessage1")][CacheLookup]
        public IWebElement MessageTxtBox {get; set;}
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl19_tblSendExceptionsInfo']/tbody/tr[4]/td[2]/div/label")][CacheLookup]
        public IWebElement SendBtn {get; set;}
        //BottomPanel
        [FindsBy(How = How.Id, Using = "divBottompanel")][CacheLookup]
        public IWebElement BottomPanelDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvLog_ctl01_chkBoxHeader")][CacheLookup]
        public IWebElement SelectAllCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvLog")][CacheLookup]
        public IWebElement GridLog { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlLogType")][CacheLookup]
        public IWebElement LogTypeDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlRecordsPerPage")][CacheLookup]
        public IWebElement RecordsPerPageDropDown { get; set; }
        #endregion      
        public void EventLogOperations(EventLogOperations EventLogOperations)
        {
            try
            {
                if (EventLogOperations.SendEmail == true)
                {
                    ClearAndFillTextBox EmailAddressClearNFill = new ClearAndFillTextBox(EmailAddressTxtBox, EventLogOperations.Email);
                    Browser.ClearAndFillTextBox(EmailAddressClearNFill);
                    ClearAndFillTextBox SubjectClearNFill = new ClearAndFillTextBox(SubjectTxtBox, EventLogOperations.Subject);
                    Browser.ClearAndFillTextBox(SubjectClearNFill);
                    ClearAndFillTextBox MessageClearNFill = new ClearAndFillTextBox(MessageTxtBox, EventLogOperations.Message);
                    Browser.ClearAndFillTextBox(MessageClearNFill);
                    SendBtn.Click();
                }
                DropDownSelect DropDownLogType = new DropDownSelect(EventLogOperations.LogType, LogTypeDropDown);
                DropDownSelect DropDownRecordsPerPage = new DropDownSelect(EventLogOperations.RecordsPerPage, RecordsPerPageDropDown);
                Browser.SelectDropdown(DropDownLogType);
                Browser.SelectDropdown(DropDownRecordsPerPage);
                IWebElement BottomPanel = BottomPanelDiv.FindElement(By.TagName("div"));
                IWebElement ModuleContentDiv = BottomPanelDiv.FindElement(By.TagName("div"));
                IWebElement ButtonWrapper = ModuleContentDiv.FindElements(By.TagName("div"))[0];
                IWebElement GridWrapper = ModuleContentDiv.FindElements(By.TagName("div"))[2];
                IList<IWebElement> label = ButtonWrapper.FindElements(By.TagName("label"));
                if (EventLogOperations.ClearLog == true)
                {
                    label[0].Click();
                }
                else if (EventLogOperations.DeleteSelectedLogs == true)
                {
                    switch (EventLogOperations.SelectAll)
                    {
                        case true:
                            {
                                if (!SelectAllCheckBox.Selected)
                                {
                                    SelectAllCheckBox.Click();
                                }
                                break;
                            }
                        case false:
                            {
                                if (SelectAllCheckBox.Selected)
                                {
                                    SelectAllCheckBox.Click();
                                }
                                IWebElement tbody = GridLog.FindElement(By.TagName("tbody"));
                                int i;
                                for (i = 0; i < EventLogOperations.DeleteLogs.Length; i++)
                                {
                                    IWebElement LogCheckBox = Browser.Driver.FindElement(By.Id("ctl19_gdvLog_ctl0" + (EventLogOperations.DeleteLogs[i] + 1).ToString() + "_chkSendEmail"));
                                    LogCheckBox.Click();
                                }
                                break;
                            }
                    }
                    label[1].Click();
                }
                else if (EventLogOperations.DeleteIndividual == true)
                {
                    int j;
                    for (j = 0; j < EventLogOperations.DeleteLogs.Length; j++)
                    {
                        IWebElement DeleteLink = Browser.Driver.FindElement(By.Id("ctl19_gdvLog_ctl0" + (EventLogOperations.DeleteLogs[j] + 1).ToString() + "_imbDelete"));
                        DeleteLink.Click();
                    }
                }
                if (EventLogOperations.ExportLogs == true)
                {
                    label[2].Click();
                }           
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
    }
}
