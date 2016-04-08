using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class EditDeleteLink
    {
        public int N { get; set; }
        public int EventNo { get; set; }
        public EditDeleteLink(int n, int eventno)
        {
            N = n;
            EventNo = eventno;
        }
    }
    public class AddEventStartUp
    {
        public string ControlUrl { get; set; }
        public string EventLocation { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsControlUrl { get; set; }
        public bool IsActive { get; set; }
        public bool Confirm { get; set; }
        public AddEventStartUp(string controlurl, string eventlocation, bool isadmin, bool iscontrolurl, bool isactive, bool confirm)
        {
            ControlUrl = controlurl;
            EventLocation = eventlocation;
            IsAdmin = isadmin;
            IsControlUrl = iscontrolurl;
            IsActive = isactive;
            Confirm = confirm;
        }
    }
    public class EventListManagement
    {
        public int EventNo { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public AddEventStartUp AddEventStartUp { get; set; }
        public bool ConfirmDel { get; set; }
        public EventListManagement(int eventno, bool edit, bool delete, AddEventStartUp addeventstartup, bool confirmdel)
        {
            EventNo = eventno;
            Edit = edit;
            Delete = delete;
            AddEventStartUp = addeventstartup;
            ConfirmDel = confirmdel;
        }
    }
    #endregion
    public static class System_Event_StartUp
    {
        public static System_Event_StartUpPage System_Event_StartUpPage
        {
            get
            {
                var system_event_startuppage = new System_Event_StartUpPage();
                PageFactory.InitElements(Browser.Driver, system_event_startuppage);
                return system_event_startuppage;
            }
        }
    }
    public class System_Event_StartUpPage
    {
        public string Url = "Admin/System-Event-StartUp.aspx";
        public string Text = "System Event StartUp";
        #region
        [FindsBy(How = How.Id, Using = "ctl19_lblAddNew")][CacheLookup]
        public IWebElement AddNewEvent { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlControlUrl")]
        public IWebElement ControlUrlDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlEventLocation")]
        public IWebElement EventLocationDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkIsAdmin")]
        public IWebElement IsAdminCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkIsControlUrl")][CacheLookup]
        public IWebElement IsControlUrlCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkIsActive")][CacheLookup]
        public IWebElement IsActiveCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblSave")][CacheLookup]
        public IWebElement SaveBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblCancel")][CacheLookup]
        public IWebElement CancelBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_grdList")]
        public IWebElement GridList { get; set; }
        [FindsBy(How = How.TagName, Using = "body")][CacheLookup]
        public IWebElement Body { get; set; }
        #endregion
        public IWebElement EditDeleteLink(EditDeleteLink EditDeleteLink)
        {
            //0 or 8 for edit::9 for delete
            try
            {
                IWebElement Tbody = GridList.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[EditDeleteLink.EventNo].FindElements(By.TagName("td"));
                IWebElement Link = Td[EditDeleteLink.N].FindElement(By.TagName("input"));
                return Link;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        public void Add_Event_StartUp(AddEventStartUp AddEventStartUp)
        {
            try
            {
                if (AddNewEvent.Displayed)
                {
                    AddNewEvent.Click();
                }
                DropDownSelect ControlDropDown = new DropDownSelect(AddEventStartUp.ControlUrl, ControlUrlDropDown);
                Browser.SelectDropdown(ControlDropDown);
                DropDownSelect EventDropDown = new DropDownSelect(AddEventStartUp.EventLocation, EventLocationDropdown);
                Browser.SelectDropdown(EventDropDown);
                ChkBox AdminChkBox = new ChkBox(AddEventStartUp.IsAdmin, IsAdminCheckBox);
                Browser.CheckBox(AdminChkBox);
                ChkBox ControlChkBox = new ChkBox(AddEventStartUp.IsControlUrl, IsControlUrlCheckBox);
                Browser.CheckBox(ControlChkBox);
                ChkBox ActiveChkBox = new ChkBox(AddEventStartUp.IsActive, IsActiveCheckBox);
                Browser.CheckBox(ActiveChkBox);
                switch (AddEventStartUp.Confirm)
                {
                    case true:
                        {
                            SaveBtn.Click();
                            break;
                        }
                    default:
                        {
                            CancelBtn.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        public void EventListManagement(EventListManagement EventListManagement)
        {
            try
            {
                if (EventListManagement.Edit)
                {
                    EditDeleteLink EditDeleteLinkI = new EditDeleteLink(8, EventListManagement.EventNo);
                    IWebElement EditLink = EditDeleteLink(EditDeleteLinkI);
                    EditLink.Click();
                    Add_Event_StartUp(EventListManagement.AddEventStartUp);
                }
                if (EventListManagement.Delete)
                {
                    EditDeleteLink EditDeleteLinkI = new EditDeleteLink(9, EventListManagement.EventNo);
                    IWebElement DeleteLink = EditDeleteLink(EditDeleteLinkI);
                    DeleteLink.Click();
                    IList<IWebElement> Buttondiv = Body.FindElements(By.TagName("div"));
                    IList<IWebElement> Button = Buttondiv[56].FindElements(By.TagName("button"));
                    switch (EventListManagement.ConfirmDel)
                    {
                        case true:
                        {
                            Button[0].Click();
                            break;
                        }
                        default:
                        {
                            Button[1].Click();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
    }
}
