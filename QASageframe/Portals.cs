using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
namespace QASageframe
{
    #region
    public class PortalOperations
    {
        public int PortalNo { get; set; }
        public int OperationNo { get; set; }
        public PortalOperations(int portalno, int operationno)
        {
            PortalNo = portalno;
            OperationNo = operationno;
        }
    }
    public class AddNewPortal
    {
        public string PortalName { get; set; }
        public string ParentPortal { get; set; }
        public string PortalUrl { get; set; }
        public bool SavePortal { get; set; }
        public AddNewPortal(string portalname, string parentportal, string portalurl, bool saveportal)
        {
            PortalName = portalname;
            ParentPortal = parentportal;
            PortalUrl = portalurl;
            SavePortal = saveportal;
        }
    }
    public class PortalSettings
    {
        public bool View { get; set; }
        public bool Edit { get; set; }
        public string PortalName { get; set; }
        public bool SavePortal { get; set; }
        public bool EditPortal { get; set; }
        public bool EditModuleManagement { get; set; }
        public bool SelectAll { get; set; }
        public bool[] ModuleList { get; set; }
        public int[] ModuleNo { get; set; }
        public bool SaveChanges { get; set; }
        public int EditPortalno { get; set; }
        public bool Delete { get; set; }
        public bool ConfirmDelete { get; set; }
        public PortalSettings(bool view, bool edit, string portalname, bool saveportal, bool editportal, bool editmodulemanagement, bool selectAll, bool[] modulelist, int[] moduleno, bool savechanges, int editportalno, bool delete, bool confirmdelete)
        {
            View = view;
            Edit = edit;
            PortalName = portalname;
            SavePortal = saveportal;
            EditPortal = editportal;
            EditModuleManagement = editmodulemanagement;
            SelectAll = selectAll;
            ModuleList = modulelist;
            ModuleNo = moduleno;
            SaveChanges = savechanges;
            EditPortalno = editportalno;
            Delete = delete;
            ConfirmDelete = confirmdelete;
        }
    }
    #endregion
    public static class Portals
    {
        public static PortalPage PortalPage
        {
            get
            {
                var portalpage = new PortalPage();
                PageFactory.InitElements(Browser.Driver, portalpage);
                return portalpage;
            }
        }
    }
    public class PortalPage
    {
        public string Url = "Admin/Portals.aspx";
        public string Text = "Portals";
        public string PortalCreated = "Portal has been saved successfully.";
        public string PortalSettingsSaved = "Selected changes have been saved successfully.";
        #region
        [FindsBy(How = How.Id, Using = "ctl19_pnlPortalList")]
        public IWebElement PortalListDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalAddEdit_txtPortalName")]
        public IWebElement PortalNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalAddEdit_ddlAvailablePortal")]
        public IWebElement ParentPortalDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalAddEdit_txtUrl")]
        public IWebElement PortalUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalAddEdit")]
        public IWebElement PortalPanelDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvPortal")]
        public IWebElement PortalsDiv { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalModulesManagement_tblPortalModulesManagement")]
        public IWebElement ModuleManagementDiv { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManagePortal_TabPanelPortalAddEdit")]
        public IWebElement PortalAddEditSpan { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainerManagePortal_TabPanelPortalModulesManagement")]
        public IWebElement PortalModuleManagementSpan { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalModulesManagement_gdvPortalModulesLists_ctl01_chkBoxIsActiveHeader")]
        public IWebElement SelectAllModulesCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainerManagePortal_TabPanelPortalModulesManagement_gdvPortalModulesLists")]
        public IWebElement PortalModuleTable { get; set; }
        #endregion      
        public void AddNewPortal(AddNewPortal AddNewPortal)
        {
            try
            {
                IWebElement ButtonWrapperDiv = PortalListDiv.FindElements(By.TagName("div"))[0];
                IWebElement AddPortalBtn = ButtonWrapperDiv.FindElement(By.TagName("label"));
                AddPortalBtn.Click();
                if (AddNewPortal.ParentPortal != "--Select--")
                {
                    DropDownSelect DropDownParentPortal = new DropDownSelect(AddNewPortal.ParentPortal, ParentPortalDropdown);
                    Browser.SelectDropdown(DropDownParentPortal);
                }
                ClearAndFillTextBox PortalNameClearNFill = new ClearAndFillTextBox(PortalNameTextBox, AddNewPortal.PortalName);
                Browser.ClearAndFillTextBox(PortalNameClearNFill);
                if (AddNewPortal.ParentPortal == "--Select--")
                {
                    ClearAndFillTextBox PortalUrlClearNFill = new ClearAndFillTextBox(PortalUrlTextBox, AddNewPortal.PortalUrl);
                    Browser.ClearAndFillTextBox(PortalUrlClearNFill);
                }
                IList<IWebElement> PortalButtonwrapperDiv = PortalPanelDiv.FindElements(By.TagName("div"));
                IList<IWebElement> Button = PortalButtonwrapperDiv[3].FindElements(By.TagName("label"));
                switch (AddNewPortal.SavePortal)
                {
                    case true:
                        {
                            Button[0].Click();
                            IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                            IsAt isat = new IsAt(PortalCreated, Message.Text);
                            Assert.IsTrue(Browser.IsAt(isat));
                            break;
                        }
                    default:
                        {
                            Button[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }      
        public IWebElement PortalOperations(PortalOperations PortalOperations)
        {
            //3:view, 4:edit, 5:delete
            try
            {
                IWebElement Tbody = PortalsDiv.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[PortalOperations.PortalNo].FindElements(By.TagName("td"));
                IWebElement PortalLink = Td[PortalOperations.OperationNo].FindElement(By.TagName("a"));
                return PortalLink;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public IList<IWebElement> GetButton()
        {
            try
            {
                IList<IWebElement> ButtonwrapperDiv = ModuleManagementDiv.FindElements(By.TagName("div"));
                IList<IWebElement> Button = ButtonwrapperDiv[2].FindElements(By.TagName("label"));
                return Button;
            }
            catch (Exception ex)
            {
                return null;
              //  throw ex;
            }
        }      
        public void PortalSettings(PortalSettings PortalSettings)
        {
            try
            {
                if (PortalSettings.View == true)
                {
                    PortalOperations PortalOperationI = new PortalOperations(PortalSettings.EditPortalno, 3);
                    IWebElement ViewLink = PortalOperations(PortalOperationI);
                    ViewLink.Click();
                }
                else if (PortalSettings.Edit)
                {
                    PortalOperations PortalOperationI = new PortalOperations(PortalSettings.EditPortalno, 4);
Begin:              IWebElement EditLink = PortalOperations(PortalOperationI);
                    EditLink.Click();
                    if (PortalSettings.EditPortal)
                    {
                        Browser.Wait();
                        PortalAddEditSpan.Click();
                        ClearAndFillTextBox PortalNameClearNFill = new ClearAndFillTextBox(PortalNameTextBox, PortalSettings.PortalName);
                        Browser.ClearAndFillTextBox(PortalNameClearNFill);
                        IWebElement PortalButtonwrapperDiv = PortalPanelDiv.FindElements(By.TagName("div"))[3];
                        IList<IWebElement> Button = PortalButtonwrapperDiv.FindElements(By.TagName("label"));
                        switch (PortalSettings.SavePortal)
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
                        PortalSettings.EditPortal = false;
                        goto Begin;
                    }
                    if (PortalSettings.EditModuleManagement)
                    {
                        Browser.Wait();
                        PortalModuleManagementSpan.Click();
                        if (PortalSettings.SelectAll)
                        {
                            ChkBox ModulesSelectChkBox = new ChkBox(PortalSettings.SelectAll, SelectAllModulesCheckBox);
                            Browser.CheckBox(ModulesSelectChkBox);
                        }
                        else
                        {
                            int i, j = 1;
                            for (i = 0; i < PortalSettings.ModuleList.Length; i++)
                            {
                            Display: IWebElement ModuleCheckBox = Browser.Driver.FindElement(By.Id("ctl19_TabContainerManagePortal_TabPanelPortalModulesManagement_gdvPortalModulesLists_ctl" + PortalSettings.ModuleNo[i].ToString() + "_chkBoxIsActiveItem"));
                                if (ModuleCheckBox.Enabled)
                                {
                                    ChkBox ModuleChkBox = new ChkBox(PortalSettings.ModuleList[i], ModuleCheckBox);
                                    Browser.CheckBox(ModuleChkBox);
                                }
                                if (j < 3)
                                {
                                    IWebElement Tbody = PortalModuleTable.FindElement(By.TagName("tbody"));
                                    IWebElement Tr = Tbody.FindElements(By.TagName("tr"))[21];
                                    IWebElement colspan = Tr.FindElement(By.TagName("td"));
                                    IWebElement table = colspan.FindElement(By.TagName("table"));
                                    IWebElement tbody = table.FindElement(By.TagName("tbody"));
                                    IWebElement tr = tbody.FindElement(By.TagName("tr"));
                                    IList<IWebElement> td = tr.FindElements(By.TagName("td"));
                                    IWebElement Pagination = td[j].FindElement(By.TagName("a"));
                                    Pagination.Click();
                                    j++;
                                    goto Display;
                                }
                            }
                            PortalSettings.EditModuleManagement = false;
                        }

                        if (PortalSettings.SaveChanges)
                        {
                            IList<IWebElement> Button = GetButton();
                            Button[0].Click();
                            Browser.SwitchToAlert(PortalSettings.SaveChanges);
                            IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                            IsAt isat = new IsAt(PortalSettingsSaved, Message.Text);
                            Assert.IsTrue(Browser.IsAt(isat));
                        }
                        IList<IWebElement> Button1 = GetButton();
                        Button1[1].Click();
                    }
                }
                if (PortalSettings.Delete == true)
                {
                    PortalOperations PortalOperationI = new PortalOperations(PortalSettings.EditPortalno, 5);
                    IWebElement DeleteLink = PortalOperations(PortalOperationI);
                    DeleteLink.Click();
                    IWebElement Body = Browser.Driver.FindElement(By.TagName("body"));
                    IList<IWebElement> Div = Body.FindElements(By.TagName("div"));
                    IList<IWebElement> Button = Div[55].FindElements(By.TagName("button"));
                    switch (PortalSettings.ConfirmDelete)
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
               // throw ex;
            }           
        }
    }
}
