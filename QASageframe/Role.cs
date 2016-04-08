using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using System;
namespace QASageframe
{
    #region
    public class DelRole
    {
        public int N { get; set; }
        public bool ConfirmDelete { get; set; }
        public DelRole(int n, bool confirmdelete)
        {
            N = n;
            ConfirmDelete = confirmdelete;
        }
    }
    public class CheckBoxSelect
    {
        public int PageNo { get; set; }
        public bool[] CheckView { get; set; }
        public bool[] CheckEdit { get; set; }
        public int J { get; set; }
        public CheckBoxSelect(int pageno, bool[] checkview, bool[] checkedit, int j)
        {
            PageNo = pageno;
            CheckView = checkview;
            CheckEdit = checkedit;
            J = j;
        }
    }
    public class DashboardRoleSettings
    {
        public string[] RoleOperation { get; set; }
        public bool Save { get; set; }
        public string[] SelectRole { get; set; }
        public string[] UnSelectRole { get; set; }
        public DashboardRoleSettings(string[] roleoperation, bool save, string[] selectrole, string[] unselectrole)
        {
            RoleOperation = roleoperation;
            Save = save;
            SelectRole = selectrole;
            UnSelectRole = unselectrole;
        }
    }
    public class PageRoleSettings
    {
        public int[] N { get; set; }
        public string PageType { get; set; }
        public int[] PageNo { get; set; }
        public bool[] AnonymousCheckView { get; set; }
        public bool[] AnonymousCheckEdit { get; set; }
        public bool[] AdminCheckView { get; set; }
        public bool[] AdminCheckEdit { get; set; }
        public bool[] RegisteredUserCheckView { get; set; }
        public bool[] RegisteredUserCheckEdit { get; set; }
        public bool[] Save { get; set; }
        public PageRoleSettings(int[] n, string pagetype, int[] pageno, bool[] anonymouscheckview, bool[] anonymouscheckedit, bool[] admincheckview, bool[] admincheckedit, bool[] registeredusercheckview, bool[] registeredusercheckedit, bool[] save)
        {
            N = n;
            PageType = pagetype;
            PageNo = pageno;
            AnonymousCheckView = anonymouscheckview;
            AnonymousCheckEdit = anonymouscheckedit;
            AdminCheckView = admincheckview;
            AdminCheckEdit = admincheckedit;
            RegisteredUserCheckView = registeredusercheckview;
            RegisteredUserCheckEdit = registeredusercheckedit;
            Save = save;
        }
    }
    #endregion
    public static class Role
    {
        public static RolePage RolePage
        {
            get
            {
                var rolepage = new RolePage();
                PageFactory.InitElements(Browser.Driver, rolepage);
                return rolepage;
            }
        }
    }
    public class RolePage
    {
        public string Url = "Admin/Roles.aspx";
        public string Title = "Roles";
        public string RoleSuccessMessage = "Role has been saved successfully.";
        public string RoleDeleteMessage = "Role has been deleted successfully.";
        public string PageRolePermissionSaveMessage = "Permission has been updated sucessfully.";
        public string DashboardRoleRemoveMessage = "Super User cannot be switched to UnApproved User.";
        public string DashboardRoleAddMessage = "Anonymous User cannot be switched to Approved User.";
        public string DashboardRoleSaveMessage = "Dashboard Roles updated successfully.";
        #region
        [FindsBy(How = How.Id, Using = "ctl19_imbAddNewRole")][CacheLookup]
        public IWebElement AddRoleLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtRole")][CacheLookup]
        public IWebElement RoleNameLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imgAdd")][CacheLookup]
        public IWebElement SaveRoleLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imgCancel")][CacheLookup]
        public IWebElement CancelRoleLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_pnlRole")][CacheLookup]
        public IWebElement Id { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvRoles")][CacheLookup]
        public IWebElement Id1 { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imbPageRoleSettings")][CacheLookup]
        public IWebElement PageRoleSettingsBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_imbDashboardRoleSettings")][CacheLookup]
        public IWebElement DashboardRoleSettingsBtn { get; set; }
        [FindsBy(How = How.Id, Using = "portalPages")][CacheLookup]
        public IWebElement PortalPagesBtn { get; set; }
        [FindsBy(How = How.Id, Using = "adminPages")][CacheLookup]
        public IWebElement AdminPagesBtn { get; set; }
        [FindsBy(How = How.Id, Using = "btnSubmit")][CacheLookup]
        public IWebElement SavePermissionBtn { get; set; }
        [FindsBy(How = How.Id, Using = "imbPageCancel")][CacheLookup]
        public IWebElement CancelPermissionBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lstUnselectedRoles")][CacheLookup]
        public IWebElement UnselectedRolesList { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lstSelectedRoles")][CacheLookup]
        public IWebElement SelectedRolesList { get; set; }        
        [FindsBy(How = How.Id, Using = "ctl19_btnAddAllRole")][CacheLookup]
        public IWebElement AddallRoleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnAddRole")][CacheLookup]
        public IWebElement AddRoleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnRemoveRole")][CacheLookup]
        public IWebElement RemoveRoleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnRemoveAllRole")][CacheLookup]
        public IWebElement RemoveAllRoleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "lblManageRoleSave")][CacheLookup]
        public IWebElement SaveRoleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "lblManageRoleCancel")][CacheLookup]
        public IWebElement CancelRoleBtn { get; set; }
        #endregion
        public void AddRole(string RoleName)
        {
            try
            {
                AddRoleLink.Click();
                Browser.Wait();
                ClearAndFillTextBox RoleNameClearNFill = new ClearAndFillTextBox(RoleNameLink, RoleName);
                Browser.ClearAndFillTextBox(RoleNameClearNFill);
                IList<IWebElement> sfButtonWrapper = Id.FindElements(By.TagName("div"));
                IList<IWebElement> Button = sfButtonWrapper[1].FindElements(By.TagName("a"));
                Button[0].Click();
                //SaveRoleLink.Click();     
                IWebElement UserSuccess = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                IsAt isat = new IsAt(RoleSuccessMessage, UserSuccess.Text);
                Assert.IsTrue(Browser.IsAt(isat));
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }
        public void DelRole(DelRole DelRole)
        {
            try
            {
                IWebElement tbody = Id1.FindElement(By.TagName("tbody"));
                IWebElement tr = tbody.FindElements(By.TagName("tr"))[DelRole.N + 4];
                IWebElement td = tr.FindElements(By.TagName("td"))[1];
                IWebElement Delete = td.FindElement(By.TagName("a"));
                Delete.Click();
                IWebElement Class = Browser.Driver.FindElement(By.ClassName("ui-dialog-buttonset"));
                IList<IWebElement> button = Class.FindElements(By.TagName("button"));
                switch (DelRole.ConfirmDelete)
                {
                    case true:
                        {
                            button[0].Click();
                            IWebElement UserSuccess = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                            IsAt isat = new IsAt(RoleDeleteMessage, UserSuccess.Text);
                            Assert.IsTrue(Browser.IsAt(isat));
                            break;
                        }
                    default:
                        {
                            button[1].Click();
                            break;
                        }
                }            
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }
        public IList<IWebElement> GetPageColumn(int pageno)
        {
            try
            {
                IWebElement PermissionTable = Browser.Driver.FindElement(By.Id("tblPermission"));
                IWebElement Tbody = PermissionTable.FindElement(By.TagName("tbody"));
                IList<IWebElement> PageRow = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> PageColumn = PageRow[pageno].FindElements(By.TagName("td"));
                return PageColumn;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }           
        }
        public void CheckBoxSelect(CheckBoxSelect CheckBoxSelect)
        {
            try
            {
                IList<IWebElement> PageColumn = GetPageColumn(CheckBoxSelect.PageNo);
                IWebElement ViewCheckBox = PageColumn[1].FindElement(By.TagName("input"));
                IWebElement EditCheckBox = PageColumn[2].FindElement(By.TagName("input"));
                ChkBox ViewCheck = new ChkBox(CheckBoxSelect.CheckView[CheckBoxSelect.J], ViewCheckBox);
                ChkBox EditCheck = new ChkBox(CheckBoxSelect.CheckEdit[CheckBoxSelect.J], EditCheckBox);
                Browser.CheckBox(ViewCheck);
                Browser.CheckBox(EditCheck);
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
        public void PageRoleSettings(PageRoleSettings PageRoleSettings)
        {
            try
            {
                PageRoleSettingsBtn.Click();
                Browser.Wait();
                IWebElement RoleTreeDiv = Browser.Driver.FindElement(By.Id("roleTree"));
                IList<IWebElement> RoleList = RoleTreeDiv.FindElements(By.TagName("li"));
                switch (PageRoleSettings.PageType)
                {
                    case "Admin":
                        {
                            AdminPagesBtn.Click();
                            break;
                        }
                    default:
                        {
                            PortalPagesBtn.Click();
                            break;
                        }
                }
                int i;
                for (i = 0; i < PageRoleSettings.N.Length; i++)
                {
                    RoleList[PageRoleSettings.N[i]].Click();
                    int j;
                    for (j = 0; j < PageRoleSettings.PageNo.Length; j++)
                    {
                        switch (PageRoleSettings.N[i])
                        {
                            case 1:
                                {
                                    CheckBoxSelect CheckBoxSelectI = new CheckBoxSelect(PageRoleSettings.PageNo[j], PageRoleSettings.AnonymousCheckView, PageRoleSettings.AnonymousCheckEdit, j);
                                    CheckBoxSelect(CheckBoxSelectI);
                                    break;
                                }
                            case 2:
                                {
                                    CheckBoxSelect CheckBoxSelectI = new CheckBoxSelect(PageRoleSettings.PageNo[j], PageRoleSettings.AdminCheckView, PageRoleSettings.AdminCheckEdit, j);
                                    CheckBoxSelect(CheckBoxSelectI);
                                    break;
                                }
                            case 3:
                                {
                                    CheckBoxSelect CheckBoxSelectI = new CheckBoxSelect(PageRoleSettings.PageNo[j], PageRoleSettings.RegisteredUserCheckView, PageRoleSettings.RegisteredUserCheckEdit, j);
                                    CheckBoxSelect(CheckBoxSelectI);
                                    break;
                                }
                        }
                    }
                    if (PageRoleSettings.Save[i])
                    {
                        SavePermissionBtn.Click();
                        IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                        IsAt isat = new IsAt(PageRolePermissionSaveMessage, Message.Text);
                        Assert.IsTrue(Browser.IsAt(isat));
                    }
                }
                CancelPermissionBtn.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }
        public void DashboardRoleSettings(DashboardRoleSettings DashboardRoleSettings)
        {
            try
            {
                DashboardRoleSettingsBtn.Click();
                int j;
                for (j = 0; j < DashboardRoleSettings.RoleOperation.Length; j++)
                {
                    switch (DashboardRoleSettings.RoleOperation[j])
                    {
                        case "AddAll":
                            {
                                AddallRoleBtn.Click();
                                IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                                IsAt isat = new IsAt(DashboardRoleAddMessage, Message.Text);
                                Assert.IsTrue(Browser.IsAt(isat));
                                break;
                            }
                        case "Add":
                            {
                                int i;
                                for (i = 0; i < DashboardRoleSettings.SelectRole.Length; i++)
                                {
                                    DropDownSelect UnselectedRolesDropDown = new DropDownSelect(DashboardRoleSettings.SelectRole[i], UnselectedRolesList);
                                    Browser.SelectDropdown(UnselectedRolesDropDown);
                                }
                                AddRoleBtn.Click();
                                break;
                            }
                        case "Remove":
                            {
                                int i;
                                for (i = 0; i < DashboardRoleSettings.UnSelectRole.Length; i++)
                                {
                                    DropDownSelect SelectRolesDropDown = new DropDownSelect(DashboardRoleSettings.UnSelectRole[i], SelectedRolesList);
                                    Browser.SelectDropdown(SelectRolesDropDown);
                                }
                                RemoveRoleBtn.Click();
                                break;
                            }
                        case "RemoveAll":
                            {
                                RemoveAllRoleBtn.Click();
                                IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                                IsAt isat = new IsAt(DashboardRoleRemoveMessage, Message.Text);
                                Assert.IsTrue(Browser.IsAt(isat));
                                break;
                            }
                    }
                }
                if (DashboardRoleSettings.Save)
                {
                    SaveRoleBtn.Click();
                    IWebElement UpdateMessage = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                    IsAt isat = new IsAt(DashboardRoleSaveMessage, UpdateMessage.Text);
                    Assert.IsTrue(Browser.IsAt(isat));
                }
                CancelRoleBtn.Click(); 
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }
    }
}
