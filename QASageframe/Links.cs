using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
namespace QASageframe
{
    #region
    public class AddSideBarItem
    {
        public string SidebarName { get; set; }
        public bool Parent { get; set; }
        public string ParentLink { get; set; }
        public string Page { get; set; }
        public string FilePath { get; set; }
        public bool IsActive { get; set; }
        public AddSideBarItem(string sidebarName, bool parent, string parentlink, string page, string filepath, bool isactive)
        {
            SidebarName = sidebarName;
            Parent = parent;
            ParentLink = parentlink;
            Page = page;
            FilePath = filepath;
            IsActive = isactive;
        }
    }
    public class ExpandTab
    {
        public bool ExpandSideTab { get; set; }
        public int[] Link { get; set; }
        public string EditLinkText { get; set; }
        public bool EditLink { get; set; }
        public AddSideBarItem AddSideBarItem { get; set; }
        public bool DelLink { get; set; }
        public bool ConfirmDel { get; set; }
        public ExpandTab(bool expandsidetab, int[] link, string editlinktext, bool editlink, AddSideBarItem addsidebaritem, bool dellink, bool confirmdel)
        {
            ExpandSideTab = expandsidetab;
            Link = link;
            EditLinkText = editlinktext;
            EditLink = editlink;
            AddSideBarItem = addsidebaritem;
            DelLink = dellink;
            ConfirmDel = confirmdel;
        }
    }
    public class LinksOperations
    {
        public bool AddSideBarItem { get; set; }
        public bool AddSideBarTab { get; set; }
        public string TabName { get; set; }
        public bool ConfirmTabAdd { get; set; }
        public int LinkNo { get; set; }
        public bool DeleteSideTab { get; set; }
        public bool EditSideTab { get; set; }
        public int Link { get; set; }
        public ExpandTab ExpandTab { get; set; }
        public LinksOperations(bool addsidebaritem, bool addsidebartab, string tabname, bool confirmtabadd, int linkno, bool deletesidetab, bool editsidetab, int link, ExpandTab expandtab)
        {
            AddSideBarItem = addsidebaritem;
            AddSideBarTab = addsidebartab;
            TabName = tabname;
            ConfirmTabAdd = confirmtabadd;
            LinkNo = linkno;
            DeleteSideTab = deletesidetab;
            EditSideTab = editsidetab;
            Link = link;
            ExpandTab = expandtab;
        }
    }
    #endregion
    public static class Links
    {
        public static LinkPage LinkPage
        {
            get
            {
                var linkpage = new LinkPage();
                PageFactory.InitElements(Browser.Driver, linkpage);
                return linkpage;
            }
        }
    }
    public class LinkPage
    {
        public string Url = "Admin/Links.aspx";
        public string Text = "Links";
        #region
        //Links
        [FindsBy(How = How.Id, Using = "lbaAddSidebarTab")][CacheLookup]
        public IWebElement AddSideBarTabBtn { get; set; }
        [FindsBy(How = How.Id, Using = "txtSidebarName")][CacheLookup]
        public IWebElement SidebarNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ddlParentLinks")][CacheLookup]
        public IWebElement ParentLinkDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "ddlPagesSidebar")][CacheLookup]
        public IWebElement PagesSidebarDropDown { get; set; }
        [FindsBy(How = How.Id, Using = "chkIsActiveSidebar")][CacheLookup]
        public IWebElement ActiveSideBarCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "fupIconSidebar")][CacheLookup]
        public IWebElement FileUploadIcon { get; set; }
        [FindsBy(How = How.Id, Using = "btnAddSidebar")][CacheLookup]
        public IWebElement AddSideBarBtn { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveSidebarOrder")][CacheLookup]
        public IWebElement SaveSideBarBtn { get; set; }
        //SideBarTab
        [FindsBy(How = How.Id, Using = "txtTabName")][CacheLookup]
        public IWebElement TabNameTxtBox { get; set; }
        [FindsBy(How = How.Id, Using = "fupTabIcon")][CacheLookup]
        public IWebElement FileUploadTabIcon { get; set; }
        [FindsBy(How = How.Id, Using = "lblSaveTab")][CacheLookup]
        public IWebElement SaveSideTab { get; set; }
        [FindsBy(How = How.Id, Using = "lblCancelTab")][CacheLookup]
        public IWebElement CancelSideTab { get; set; }
        //
        [FindsBy(How = How.TagName, Using = "body")][CacheLookup]
        public IWebElement Body { get; set; }
        #endregion      
        public void AddSideBarItem(AddSideBarItem AddSideBarItem)
        {
            try
            {
                ClearAndFillTextBox SideBarNameClearNFill = new ClearAndFillTextBox(SidebarNameTextBox, AddSideBarItem.SidebarName);
                Browser.ClearAndFillTextBox(SideBarNameClearNFill);
                if (AddSideBarItem.Parent == true)
                {
                    DropDownSelect DropDownParentLink = new DropDownSelect(AddSideBarItem.ParentLink, ParentLinkDropDown);
                    Browser.SelectDropdown(DropDownParentLink);
                }
                DropDownSelect PagesDropDown = new DropDownSelect(AddSideBarItem.Page, PagesSidebarDropDown);
                Browser.SelectDropdown(PagesDropDown);
                FileUploadIcon.SendKeys(AddSideBarItem.FilePath);
                ChkBox ActiveChkBox = new ChkBox(AddSideBarItem.IsActive, ActiveSideBarCheckBox);
                Browser.CheckBox(ActiveChkBox);
                AddSideBarBtn.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }      
        public void ExpandTab(ExpandTab ExpandTab)
        {
            try
            {
                WaitForElement waitsidebarItem = new WaitForElement(By.ClassName("sfSidebarItems"), 10);
                IWebElement SidebarItemDiv = Browser.WaitForElement(waitsidebarItem);
                //Browser.Driver.FindElement(By.ClassName("sfSidebarItems"));
                IWebElement UIDiv = SidebarItemDiv.FindElement(By.TagName("ul"));
                IWebElement SideTabLi = UIDiv.FindElement(By.TagName("li"));
                //IWebElement SideTabLi = Browser.WaitForElement(By.Id("li_102"), 10);
                // Browser.Driver.FindElement(By.Id("li_60"));
                IWebElement HolderDiv = SideTabLi.FindElement(By.TagName("div"));
                IList<IWebElement> OperationLinks = HolderDiv.FindElements(By.TagName("i"));
                int i = 0;
Expand:         if (OperationLinks.Count == 3)
                {
                    if (ExpandTab.ExpandSideTab)
                    {
                        if (OperationLinks[0].GetAttribute("class") == "expand icon-arrow-slim-s")
                        {
                            OperationLinks[0].Click();
                        }
                        IWebElement ul = SideTabLi.FindElement(By.TagName("ul"));
                        IList<IWebElement> li = ul.FindElements(By.TagName("li"));
                        IList<IWebElement> Tablink = li[ExpandTab.Link[i]].FindElements(By.TagName("div"));
                        switch (Tablink.Count)
                        {
                            case 0:
                                {
                                    int test = ExpandTab.Link[i];
                                    string textid = li[ExpandTab.Link[i]].GetAttribute("id");
                                    IList<IWebElement> span = li[ExpandTab.Link[i]].FindElements(By.TagName("span"));
                                    IList<IWebElement> Operations = li[ExpandTab.Link[i]].FindElements(By.TagName("i"));
                                    if (span[0].Text == ExpandTab.EditLinkText)
                                    {
                                        ExpandTab.ExpandSideTab = false;
                                        if (ExpandTab.EditLink)
                                        {
                                            Browser.MouseMovement(li[ExpandTab.Link[i]]);
                                            Operations[1].Click();
                                            AddSideBarItem(ExpandTab.AddSideBarItem);
                                        }
                                        if (ExpandTab.DelLink)
                                        {
                                            Browser.MouseMovement(li[ExpandTab.Link[i]]);
                                            Operations[0].Click();
                                            Delete(ExpandTab.ConfirmDel);
                                        }
                                    }
                                    break;
                                }
                            default:
                                {
                                    IList<IWebElement> TabOperations = Tablink[0].FindElements(By.TagName("i"));
                                    OperationLinks = TabOperations;
                                    SideTabLi = li[ExpandTab.Link[i]];
                                    i++;
                                    goto Expand;
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }                                                                  
        }
        public void Delete(bool ConfirmDel)
        {
            try
            {
                IList<IWebElement> Divs = Body.FindElements(By.TagName("div"));
                string text = Divs[70].GetAttribute("class");
                IList<IWebElement> Button = Divs[70].FindElements(By.TagName("button"));
                switch (ConfirmDel)
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
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public IList<IWebElement> GetOperationLinks(IWebElement SideTabLi)
        {
            try
            {
                IList<IWebElement> HolderDiv = SideTabLi.FindElements(By.TagName("div"));
                IList<IWebElement> OperationLinks;
                switch (HolderDiv.Count)
                {
                    case 0:
                        {
                            OperationLinks = SideTabLi.FindElements(By.TagName("i"));
                            break;

                        }
                    default:
                        {
                            OperationLinks = HolderDiv[0].FindElements(By.TagName("i"));
                            break;
                        }
                }
                return OperationLinks; 
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }          
        }       
        public void LinksOperations(LinksOperations LinksOperations)
        {
            try
            {
                AddSideBarItem AddSideBarItemI = new AddSideBarItem("test", false, "test123", "Pages", @"D:\Free Images\Pearl-Jam-Stickman.png", true);
                ExpandTab ExpandTabI = new ExpandTab(true, LinksOperations.ExpandTab.Link, "Pages", true, AddSideBarItemI, false, false);
                ExpandTab(ExpandTabI);
                WaitForElement SideTabWait = new WaitForElement(By.Id("li_" + LinksOperations.LinkNo.ToString()), 10);
                IWebElement SideTabLi = Browser.WaitForElement(SideTabWait);
                IList<IWebElement> OperationLinks = GetOperationLinks(SideTabLi);
                if (OperationLinks.Count == 3)
                {
                    if (LinksOperations.DeleteSideTab)
                    {
                        Browser.MouseMovement(SideTabLi);
                        OperationLinks[1].Click();
                        Delete(LinksOperations.ExpandTab.ConfirmDel);
                    }
                    if (LinksOperations.EditSideTab)
                    {
                        Browser.MouseMovement(SideTabLi);
                        OperationLinks[2].Click();
                        //AddSideBarItem(SidebarName, Parent, ParentLink, Page, FilePath, IsActive);
                        AddSideBarItem(LinksOperations.ExpandTab.AddSideBarItem);
                    }
                }
                if (LinksOperations.AddSideBarItem)
                {
                    //AddSideBarItem(SidebarName, Parent, ParentLink, Page, FilePath, IsActive);
                    AddSideBarItem(LinksOperations.ExpandTab.AddSideBarItem);
                }
                if (LinksOperations.AddSideBarTab)
                {
                    AddSideBarTabBtn.Click();
                    ClearAndFillTextBox TabNameClearNFill = new ClearAndFillTextBox(TabNameTxtBox, LinksOperations.TabName);
                    Browser.ClearAndFillTextBox(TabNameClearNFill);
                    FileUploadTabIcon.SendKeys(LinksOperations.ExpandTab.AddSideBarItem.FilePath);
                    if (LinksOperations.ConfirmTabAdd)
                    {
                        SaveSideTab.Click();
                    }
                    CancelSideTab.Click();
                }
                SaveSideBarBtn.Click();          
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }
    }
}