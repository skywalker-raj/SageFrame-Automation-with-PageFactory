using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Windows.Forms;
namespace QASageframe
{
    #region
    public class EditDelete
    {
        public int TaskNo { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool ConfirmDelete { get; set; }
        public EditDelete(int taskno, bool edit, bool delete, bool confirmdelete)
        {
            TaskNo = taskno;
            Edit = edit;
            Delete = delete;
            ConfirmDelete = confirmdelete;
        }
    }
    public class AddNewTask
    {
        public string TaskName { get; set; }
        public bool Closepopup { get; set; }
        public string AssemblyName { get; set; }
        public bool EnabledTask { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string RepeatMode { get; set; }
        public string RetryUnit { get; set; }
        public int RetryFreq { get; set; }
        public string Event { get; set; }
        public bool CatchUp { get; set; }
        public string FilePath { get; set; }
        public DateTime EndDate { get; set; }
        public int RepeatHours { get; set; }
        public int RepeatMins { get; set; }
        public int RepeatDays { get; set; }
        public string RepeatModeDate { get; set; }
        public bool Update { get; set; }
        public string FileName { get; set; }
        public AddNewTask(string taskname, bool closepopup, string assemblyname, bool enabledtask, int hour, int minute, string repeatmode, string retryunit, int retryfreq, string EvenT, bool catchup, string filepath, DateTime enddate, int repeathours, int repeatmins, int repeatdays, string repeatmodedate, bool update, string filename)
        {
            TaskName = taskname;
            Closepopup = closepopup;
            AssemblyName = assemblyname;
            EnabledTask = enabledtask;
            Hour = hour;
            Minute = minute;
            RepeatMode = repeatmode;
            RetryUnit = retryunit;
            RetryFreq = retryfreq;
            Event = EvenT;
            CatchUp = catchup;
            FilePath = filepath;
            EndDate = enddate;
            RepeatHours = repeathours;
            RepeatMins = repeatmins;
            RepeatDays = repeatdays;
            RepeatModeDate = repeatmodedate;
            Update = update;
            FileName = filename;
        }
    }
    #endregion
    public static class Scheduler
    {
        public static SchedulerPage SchedulerPage
        {
            get
            {
                var schedulerpage = new SchedulerPage();
                PageFactory.InitElements(Browser.Driver, schedulerpage);
                return schedulerpage;
            }
        }
    }
    public class SchedulerPage
    {
        public string Url = "Admin/Scheduler.aspx";
        public string Text = "Scheduler";
        #region
        [FindsBy(How = How.Id, Using = "divShowItemRatingDetails")][CacheLookup]
        public IWebElement AddTaskDiv { get; set; }
        [FindsBy(How = How.Id, Using = "txtTaskName")][CacheLookup]
        public IWebElement TaskNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtAssemblyName")][CacheLookup]
        public IWebElement AssemblyNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "chkIsEnabled")][CacheLookup]
        public IWebElement IsEnabledCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtRetryFreq")][CacheLookup]
        public IWebElement RetryFreqTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ddlRetryUnits")][CacheLookup]
        public IWebElement RetryUnitsDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ddlEventList")][CacheLookup]
        public IWebElement EventListDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "chkIsCatchUpEnabled")][CacheLookup]
        public IWebElement CatchUpEnabledCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnAddTask")][CacheLookup]
        public IWebElement AddTaskButton { get; set; }
        [FindsBy(How = How.Id, Using = "txtHours")][CacheLookup]
        public IWebElement HoursDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "txtMins")][CacheLookup]
        public IWebElement MinuteDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "running_mode")][CacheLookup]
        public IWebElement RepeatModeDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "txtStartDate")][CacheLookup]
        public IWebElement StartDateBox { get; set; }
        [FindsBy(How = How.Id, Using = "txtEndDate")][CacheLookup]
        public IWebElement EndDateBox { get; set; }
        [FindsBy(How = How.Id, Using = "fileUpload")][CacheLookup]
        public IWebElement FileUploadLink { get; set; }
        [FindsBy(How = How.Id, Using = "newScheduleDiv")][CacheLookup]
        public IWebElement SchedulerDiv { get; set; }
        //[FindsBy(How = How.TagName, Using = "BoxAlertBtnOk")][CacheLookup]
        //public IWebElement OkAlert { get; set; }
        [FindsBy(How = How.Id, Using = "gdvSchedularListAll")][CacheLookup]
        public IWebElement SchedulerGridListDiv { get; set; }
        //DateSelect
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-year")][CacheLookup]
        public IWebElement YearSelect { get; set; }
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-month")][CacheLookup]
        public IWebElement MonthSelect { get; set; }
        #endregion        
        public void AddNewTask(AddNewTask AddNewTask)
        {
            try
            {
                IWebElement ButtonWrapper = AddTaskDiv.FindElement(By.TagName("div"));
                IWebElement AddTask = ButtonWrapper.FindElement(By.TagName("label"));
                AddTask.Click();
                IWebElement PopUpDiv = SchedulerDiv.FindElement(By.TagName("div"));
                IWebElement Span = PopUpDiv.FindElement(By.TagName("span"));
                IWebElement PopUpClose = Span.FindElement(By.TagName("input"));
                if (AddNewTask.Closepopup)
                {
                    PopUpClose.Click();
                }
                ClearAndFillTextBox TaskNameClearNFill = new ClearAndFillTextBox(TaskNameTextBox, AddNewTask.TaskName);
                Browser.ClearAndFillTextBox(TaskNameClearNFill);
                ClearAndFillTextBox AssemblyNameClearNFill = new ClearAndFillTextBox(AssemblyNameTextBox, AddNewTask.AssemblyName);
                Browser.ClearAndFillTextBox(AssemblyNameClearNFill);
                ChkBox EnabledChkBox = new ChkBox(AddNewTask.EnabledTask, IsEnabledCheckBox);
                Browser.CheckBox(EnabledChkBox);
                int EndYear = AddNewTask.EndDate.Year;
                int EndMonth = AddNewTask.EndDate.Month;
                int EndDay = AddNewTask.EndDate.Day;
                string EndMonthText;
                string EndDayText;
                EndDateBox.Click();
                EndDateBox.Clear();
                EndMonthText = (EndMonth < 10) ? "0" + EndMonth.ToString() : EndMonth.ToString();
                EndDayText = (EndDay < 10) ? "0" + EndDay.ToString() : EndDay.ToString();
                EndDateBox.SendKeys(EndMonthText);
                EndDateBox.SendKeys(Convert.ToString(EndDayText));
                EndDateBox.SendKeys(Convert.ToString(EndYear));
                DropDownSelect DropdownHours = new DropDownSelect(AddNewTask.Hour.ToString(), HoursDropdown);
                DropDownSelect DropdownMinute = new DropDownSelect(AddNewTask.Minute.ToString(), MinuteDropdown);
                DropDownSelect RepeatDropdown = new DropDownSelect(AddNewTask.RepeatMode, RepeatModeDropdown);
                Browser.SelectDropdown(DropdownHours);
                Browser.SelectDropdown(DropdownMinute);
                Browser.SelectDropdown(RepeatDropdown);
                switch (AddNewTask.RepeatMode)
                {
                    case "Daily":
                        {
                            IWebElement RepeatDaysTextBox = Browser.Driver.FindElement(By.Id("RepeatDays"));
                            ClearAndFillTextBox RepeatDaysClearNFill = new ClearAndFillTextBox(RepeatDaysTextBox, AddNewTask.RepeatDays.ToString());
                            Browser.ClearAndFillTextBox(RepeatDaysClearNFill);
                            break;
                        }
                    case "Hourly":
                        {
                            IWebElement RepeatHoursSelect = Browser.Driver.FindElement(By.Id("txtRepeatHrs"));
                            DropDownSelect RepeatHoursDropDown = new DropDownSelect(AddNewTask.RepeatHours.ToString(), RepeatHoursSelect);
                            Browser.SelectDropdown(RepeatHoursDropDown);
                            IWebElement RepeatMinsSelect = Browser.Driver.FindElement(By.Id("txtRepeatMins"));
                            DropDownSelect RepeatMinsDropDown = new DropDownSelect(AddNewTask.RepeatMins.ToString(), RepeatMinsSelect);
                            Browser.SelectDropdown(RepeatMinsDropDown);
                            break;
                        }
                    case "Calendar":
                        {
                            IWebElement RepeatModeCalendarTextBox = Browser.Driver.FindElement(By.Id("popupDatepicker"));
                            ClearAndFillTextBox RepeatModeCalendarClearNFill = new ClearAndFillTextBox(RepeatModeCalendarTextBox, AddNewTask.RepeatModeDate);
                            Browser.ClearAndFillTextBox(RepeatModeCalendarClearNFill);
                            break;
                        }
                }
                ClearAndFillTextBox RetryFreqClearNFill = new ClearAndFillTextBox(RetryFreqTextBox, AddNewTask.RetryFreq.ToString());
                Browser.ClearAndFillTextBox(RetryFreqClearNFill);
                DropDownSelect RetryDropdown = new DropDownSelect(AddNewTask.RetryUnit, RetryUnitsDropdown);
                DropDownSelect EventDropdown = new DropDownSelect(AddNewTask.Event, EventListDropdown);
                ChkBox CatchUpChkBox = new ChkBox(AddNewTask.CatchUp, CatchUpEnabledCheckBox);
                Browser.SelectDropdown(RetryDropdown);
                Browser.SelectDropdown(EventDropdown);
                Browser.CheckBox(CatchUpChkBox);
                //FileUploadLink.SendKeys(FilePath);
                FileUploadLink.Click();
                SendKeys.SendWait(AddNewTask.FilePath);
                SendKeys.SendWait(@"{Enter}");
                InjectJs FileUploadvalue = new InjectJs("uploadFileName", AddNewTask.FileName, "value");
                InjectJs FileUploadLabel = new InjectJs("lblFile", AddNewTask.FileName, "innerHTML");
                Browser.FileUpload(FileUploadvalue);
                Browser.FileUpload(FileUploadLabel);
                switch (AddNewTask.Update)
                {
                    case true:
                        {
                            IWebElement UpdateBtn = Browser.Driver.FindElement(By.Id("btnUpdateTask"));
                            UpdateBtn.Click();
                            break;
                        }
                    default:
                        {
                            AddTaskButton.Click();
                            break;
                        }
                }
                IWebElement OkAlert = Browser.Driver.FindElement(By.Id("BoxAlertBtnOk"));
                OkAlert.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }
        public void EditDelete(EditDelete EditDelete)
        {
            try
            {
                DateTime EndDate = new DateTime(2015, 08, 18);
                string AssemblyName = "[QASageFrame.Admin, QASageframe]";
                IWebElement tbody = SchedulerGridListDiv.FindElement(By.TagName("tbody"));
                IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> td = tr[EditDelete.TaskNo].FindElements(By.TagName("td"));
                IWebElement ActionDiv = td[29].FindElement(By.TagName("div"));
                string txt = ActionDiv.GetAttribute("class");
                //IWebElement ActionLink = ActionDiv.FindElement(By.TagName("p"));
                IWebElement ActionLink = ActionDiv.FindElement(By.ClassName("Sageshowhide"));
                string text = ActionLink.GetAttribute("class");
                IWebElement EditDeleteLink = ActionLink.FindElement(By.TagName("a"));
                EditDeleteLink.Click();
                if (EditDelete.Edit)
                {
                    IWebElement Edit = Browser.Driver.FindElement(By.Id("edit" + EditDelete.TaskNo.ToString()));
                    Edit.Click();
                }
                if (EditDelete.Delete)
                {
                    IWebElement Delete = Browser.Driver.FindElement(By.Id("delete" + EditDelete.TaskNo.ToString()));
                    Delete.Click();
                    switch (EditDelete.ConfirmDelete)
                    {
                        case true:
                            {
                                IWebElement Confirm = Browser.Driver.FindElement(By.Id("BoxConfirmBtnOk"));
                                Confirm.Click();
                                break;
                            }
                        default:
                            {
                                IWebElement Cancel = Browser.Driver.FindElement(By.Id("BoxConfirmBtnCancel"));
                                Cancel.Click();
                                break;
                            }
                    }
                }
                AddNewTask AddNewTaskI = new AddNewTask("test", false, AssemblyName, true, 10, 20, "Daily", "Min", 10, "APPLICATION_START", true, @"C:\Users\RajKumar-PC\Documents\Visual Studio 2013\Projects\QASageframe\QASageframe\bin\Debug\QASageframe.dll", EndDate, 1, 10, 1, "07/15/2015", true, "nunit.framework.dll");
                AddNewTask(AddNewTaskI);
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }
    }
}
