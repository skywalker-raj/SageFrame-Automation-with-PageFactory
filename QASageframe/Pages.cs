using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
namespace QASageframe
{
    #region
    public class SetPermission
    {
        public IWebElement AnonymousUserRole { get; set; }
        public IWebElement SiteAdminRole { get; set; }
        public IWebElement RegisteredUserRole { get; set; }
        public bool[] AnonymousPermission { get; set; }
        public bool[] SiteAdminPermission { get; set; }
        public bool[] RegisteredUserPermission { get; set; }
        public SetPermission(IWebElement anonymoususerrole, IWebElement siteadminrole, IWebElement registereduserrole, bool[] anonymouspermission, bool[] siteadminpermission, bool[] registereduserpermission)
        {
            AnonymousUserRole = anonymoususerrole;
            SiteAdminRole = siteadminrole;
            RegisteredUserRole = registereduserrole;
            AnonymousPermission = anonymouspermission;
            SiteAdminPermission = siteadminpermission;
            RegisteredUserPermission = registereduserpermission;
        }
    }
    public class Pagination
    {
        public string Id { get; set; }
        public int PageNo { get; set; }
        public Pagination(string id, int pageno)
        {
            Id = id;
            PageNo = pageno;
        }
    }
    public class SelectLayout
    {
        public string Layout { get; set; }
        public bool Save { get; set; }
        public SelectLayout(string layout, bool save)
        {
            Layout = layout;
            Save = save;
        }
    }
    public class FillPage
    {
        public string PageType { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string Caption { get; set; }
        public bool ParentReq { get; set; }
        public string Parent { get; set; }
        public int RefreshInterval { get; set; }
        public bool DashboardCheck { get; set; }
        public bool MenuCheck { get; set; }
        public string MenuName { get; set; }
        public bool[] AnonymousPermission { get; set; }
        public bool[] SiteAdminPermission { get; set; }
        public bool[] RegisteredUserPermission { get; set; }
        public bool PageSave { get; set; }
        public string FilePath { get; set; }
        public FillPage(string pagetype, string pagename, string pagetitle, string description, string keywords, string caption, bool parentreq, string parent, int refreshinterval, bool dashboardcheck, bool menucheck, string menuname, bool[] anonymouspermission, bool[] siteadminpermission, bool[] registereduserpermission, bool pagesave, string filepath)
        {
            PageType = pagetype;
            PageName = pagename;
            PageTitle = pagetitle;
            Description = description;
            KeyWords = keywords;
            Caption = caption;
            ParentReq = parentreq;
            Parent = parent;
            RefreshInterval = refreshinterval;
            DashboardCheck = dashboardcheck;
            MenuCheck = menucheck;
            MenuName = menuname;
            AnonymousPermission = anonymouspermission;
            SiteAdminPermission = siteadminpermission;
            RegisteredUserPermission = registereduserpermission;
            PageSave = pagesave;
            FilePath = filepath;
        }
    }
    public class PageManagement
    {
        public string Operation { get; set; }
        public int N { get; set; }
        public FillPage FillPage { get; set; }
        public bool DeleteConfirm { get; set; }
        public PageManagement(string operation, int n, FillPage fillpage, bool deleteconfirm)
        {
            Operation = operation;
            N = n;
            FillPage = fillpage;
            DeleteConfirm = deleteconfirm;
        }
    }
    public class ModuleDetails
    {
        public string ModuleTitle { get; set; }
        public bool Header { get; set; }
        public string HeaderText { get; set; }
        public string ModuleSuffixClass { get; set; }
        public bool IsActive { get; set; }
        public string ShowInPages { get; set; }
        public string[] CustomPages { get; set; }
        public string Preferences { get; set; }
        public bool[] AnonymousPermission { get; set; }
        public bool[] SiteAdminPermission { get; set; }
        public bool[] RegisteredUserPermission { get; set; }
        public bool DonotShow { get; set; }
        public bool Save { get; set; }
        public ModuleDetails(string moduletitle, bool header, string headertext, string modulesuffixclass, bool isactive, string showinpages, string[] custompages, string preferences, bool[] anonymouspermission, bool[] siteadminpermission, bool[] registereduserpermission, bool donotshow, bool save)
        {
            ModuleTitle = moduletitle;
            Header = header;
            HeaderText = headertext;
            ModuleSuffixClass = modulesuffixclass;
            IsActive = isactive;
            ShowInPages = showinpages;
            CustomPages = custompages;
            Preferences = preferences;
            AnonymousPermission = anonymouspermission;
            SiteAdminPermission = siteadminpermission;
            RegisteredUserPermission = registereduserpermission;
            DonotShow = donotshow;
            Save = save;
        }
    }
    public class Page
    {
        public int N { get; set; }
        public string Layout { get; set; }
        public bool SaveLayout { get; set; }
        public string Mode { get; set; }
        public bool Publish { get; set; }
        public string ModuleID { get; set; }
        public string Section { get; set; }
        public ModuleDetails ModuleDetails { get; set; }
        public Page(int n, string layout, bool savelayout, string mode, bool publish, string moduleid, string section, ModuleDetails moduledetails)
        {
            N = n;
            Layout = layout;
            SaveLayout = savelayout;
            Mode = mode;
            Publish = publish;
            ModuleID = moduleid;
            Section = section;
            ModuleDetails = moduledetails;
        }
    }
    #endregion
    public static class Pages
    {
        public static PagesClass PagesClass
        {
            get
            {
                var pagesclass = new PagesClass();
                PageFactory.InitElements(Browser.Driver, pagesclass);
                return pagesclass;
            }
        }
    }
    public class PagesClass
    {
        public string Url = "Admin/Pages.aspx";
        public string Text = "Pages";
        public string PageCreated = "Page has been created successfully.";
        public string ModuleAdded = "User module has been added successfully.";
        #region
        [FindsBy(How = How.Id, Using = "btnAddpage")]
        public IWebElement CreatePageBtn { get; set;}
        [FindsBy(How = How.Id, Using = "portalPages")]
        public IWebElement PortalPageTab { get; set;}
        [FindsBy(How = How.Id, Using = "adminPages")]
        public IWebElement AdminPageTab { get; set;}
        [FindsBy(How = How.Id, Using = "txtSearch")]
        public IWebElement PagesSearchBox { get; set;}
        [FindsBy(How = How.Id, Using = "btnSavelayout")]
        public IWebElement SaveLayout { get; set; }
        [FindsBy(How = How.Id, Using = "btnLayoutCancel")]
        public IWebElement CancelLayout { get; set; }
        [FindsBy(How = How.Id, Using = "txtSearchModules")]
        public IWebElement ModulesSearchBox { get; set;}
        [FindsBy(How = How.Id, Using = "btnPreview")]
        public IWebElement PreviewBtn { get; set;}
        [FindsBy(How = How.Id, Using = "btnpublish")]
        public IWebElement PublishBtn { get; set;}
        [FindsBy(How = How.Id, Using = "ddlLayouts")]
        public IWebElement LayoutDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "imgMobileSwitch")]
        public IWebElement MobileSwitch { get; set;}
        [FindsBy(How = How.Id, Using = "imgPCSwitch")]
        public IWebElement PCSwitch { get; set;}
        [FindsBy(How = How.Id, Using = "Pagination")]
        public IWebElement PaginationDiv { get; set;}
        [FindsBy(How = How.Id, Using = "categoryTree")]
        public IWebElement PagesList { get; set;}
        //ModuleList
        [FindsBy(How = How.Id, Using = "imgSort")]
        public IWebElement SortBtn { get; set;}
        [FindsBy(How = How.Id, Using = "divFloat")]
        public IWebElement FloatDiv { get; set;}
        [FindsBy(How = How.Id, Using = "chkPortalModules")]
        public IWebElement IncludePortalModulesCheckBox { get; set;}
        //Module
        [FindsBy(How = How.Id, Using = "txtModuleTitle")]
        public IWebElement ModuleTitleTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkShowHeader")]
        public IWebElement HeaderCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtHeaderTxt")]
        public IWebElement HeaderTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtModuleSuffix")]
        public IWebElement ModuleSuffixTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkIsActive")]
        public IWebElement IsActiveCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "rbAllPages")]
        public IWebElement AllPagesCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "rbCustomPages")]
        public IWebElement CustomPagesCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkInheritPermissions")]
        public IWebElement InheritPermissionCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkDonotshow")]
        public IWebElement DonotShowCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "pageTree_popup")]
        public IWebElement PageTree { get; set; }
        [FindsBy(How = How.Id, Using = "ui-id-2")]
        public IWebElement ModuleBasicsTab { get; set;}
        [FindsBy(How = How.Id, Using = "ui-id-3")]
        public IWebElement ModulePermissionsTab { get; set;}
         [FindsBy(How = How.Id, Using = "spnBtnSave")]
        public IWebElement SaveBtn { get; set;}
        [FindsBy(How = How.Id, Using = "spnBtnCancel")]
        public IWebElement CancelBtn { get; set;}
        //CreatePage
        [FindsBy(How = How.Id, Using = "txtPageName")]
        public IWebElement PageNameTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtCaption")]
        public IWebElement CaptionTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "cboParentPage")]
        public IWebElement ParentPageDropDown { get; set;}
        [FindsBy(How = How.Id, Using = "txtRefreshInterval")]
        public IWebElement RefreshIntervalTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtTitle")]
        public IWebElement PageTitleTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtDescription")]
        public IWebElement DescriptionTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtKeyWords")]
        public IWebElement KeyWordsTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkMenu")]
        public IWebElement ShowInMenuCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "chkShowInDashboard")]
        public IWebElement ShowInDashboardCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "selMenulist")]
        public IWebElement MenuListSelect { get; set;}
        [FindsBy(How = How.Id, Using = "btnSubmit")]
        public IWebElement SavePageBtn { get; set;}        
        [FindsBy(How = How.Id, Using = "imbPageCancel")]
        public IWebElement CancelPageBtn { get; set;}
        [FindsBy(How = How.Id, Using = "flIcon")]
        public IWebElement FileUploader { get; set;}
        [FindsBy(How = How.Id, Using = "body")]
        public IWebElement Body { get; set;}
        [FindsBy(How = How.Id, Using = "divPageDetails")]
        public IWebElement PageDetailsDiv { get; set; }
        #endregion
        public void ClosePagesDetailsDiv()
        {
            try
            {
                IList<IWebElement> span = PageDetailsDiv.FindElements(By.TagName("span"));
                span[0].Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void SearchPage(string Page)
        {
            try
            {
                PagesSearchBox.Click();
                ClearAndFillTextBox PagesSearchClearNFill = new ClearAndFillTextBox(PagesSearchBox, Page);
                Browser.ClearAndFillTextBox(PagesSearchClearNFill);
                //IList<IWebElement> Searchspan = ContainerDiv.FindElements(By.TagName("span"));
                //Searchspan[0].Click(); 
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }      
        public void SetPermission(SetPermission SetPermission)
        {
            //1 for View and 2 for Edit
            try
            {
                IList<IWebElement> AnonymousCheckList = SetPermission.AnonymousUserRole.FindElements(By.TagName("td"));
                IList<IWebElement> SiteAdminCheckList = SetPermission.SiteAdminRole.FindElements(By.TagName("td"));
                IList<IWebElement> RegisteredUserCheckList = SetPermission.RegisteredUserRole.FindElements(By.TagName("td"));
                int i;
                for (i = 0; i < 2; i++)
                {
                    IWebElement AnonymousCheckBox = AnonymousCheckList[i + 1].FindElement(By.TagName("input"));
                    IWebElement SiteAdminCheckBox = SiteAdminCheckList[i + 1].FindElement(By.TagName("input"));
                    IWebElement RegisteredUserCheckBox = RegisteredUserCheckList[i + 1].FindElement(By.TagName("input"));
                    ChkBox AnonymousChkBox = new ChkBox(SetPermission.AnonymousPermission[i], AnonymousCheckBox);
                    ChkBox SiteAdminChkBox = new ChkBox(SetPermission.SiteAdminPermission[i], SiteAdminCheckBox);
                    ChkBox RegisteredUserChkBox = new ChkBox(SetPermission.RegisteredUserPermission[i], RegisteredUserCheckBox);
                    Browser.CheckBox(AnonymousChkBox);
                    Browser.CheckBox(SiteAdminChkBox);
                    Browser.CheckBox(RegisteredUserChkBox);
                }        
            }
            catch (Exception ex)
            {
               // throw ex;
            }               
        }
        public void Delete(bool DeleteConfirm)
        {
            try
            {
                IList<IWebElement> Divs = Body.FindElements(By.TagName("div"));
                IList<IWebElement> Button = Divs[157].FindElements(By.TagName("button"));
                switch (DeleteConfirm)
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
        public void FillPage(FillPage FillPage)
        {
            try
            {
                IWebElement AnonymousUserRole = Browser.Driver.FindElement(By.Id("a87e850f-14c8-4c89-86f4-4598ff27da72"));
                IWebElement SiteAdminRole = Browser.Driver.FindElement(By.Id("910f0c31-e1dd-42d2-988b-545fe8621544"));
                IWebElement RegisteredUserRole = Browser.Driver.FindElement(By.Id("8281caa9-7ace-4db1-8b6d-e2c7c2d0d60a"));
                Browser.Wait();
                ClearAndFillTextBox PageNameClearNFill = new ClearAndFillTextBox(PageNameTextBox, FillPage.PageName);
                Browser.ClearAndFillTextBox(PageNameClearNFill);
                ClearAndFillTextBox PageTitleClearNFill = new ClearAndFillTextBox(PageTitleTextBox, FillPage.PageTitle);
                Browser.ClearAndFillTextBox(PageTitleClearNFill);
                ClearAndFillTextBox DescriptionClearNFill = new ClearAndFillTextBox(DescriptionTextBox, FillPage.Description);
                Browser.ClearAndFillTextBox(DescriptionClearNFill);
                ClearAndFillTextBox KeyWordsClearNFill = new ClearAndFillTextBox(KeyWordsTextBox, FillPage.KeyWords);
                Browser.ClearAndFillTextBox(KeyWordsClearNFill);
                ClearAndFillTextBox CaptionClearNFill = new ClearAndFillTextBox(CaptionTextBox, FillPage.Caption);
                Browser.ClearAndFillTextBox(CaptionClearNFill);
                if (FillPage.ParentReq)
                {
                    DropDownSelect ParentDropDown = new DropDownSelect(FillPage.Parent, ParentPageDropDown);
                    Browser.SelectDropdown(ParentDropDown);
                }
                ClearAndFillTextBox RefreshIntervalClearNFill = new ClearAndFillTextBox(RefreshIntervalTextBox, FillPage.RefreshInterval.ToString());
                FileUploader.SendKeys(FillPage.FilePath);
                //FileUploader.Click();
                //SendKeys.SendWait(FilePath);
                //SendKeys.SendWait(@"{Enter}");
                switch (FillPage.PageType)
                {
                    case "Admin":
                        {
                            ChkBox DashboardChkBox = new ChkBox(FillPage.DashboardCheck, ShowInDashboardCheckBox);
                            Browser.CheckBox(DashboardChkBox);
                            break;
                        }
                    case "Portal":
                        {
                            ChkBox MenuChkBox = new ChkBox(FillPage.MenuCheck, ShowInMenuCheckBox);
                            Browser.CheckBox(MenuChkBox);
                            if (FillPage.MenuCheck)
                            {
                                DropDownSelect MenuNameDropDown = new DropDownSelect(FillPage.MenuName, MenuListSelect);
                                Browser.SelectDropdown(MenuNameDropDown);
                            }
                            break;
                        }
                }
                SetPermission SetPermissionI = new SetPermission(AnonymousUserRole, SiteAdminRole, RegisteredUserRole, FillPage.AnonymousPermission, FillPage.SiteAdminPermission, FillPage.RegisteredUserPermission);
                SetPermission(SetPermissionI);
                switch (FillPage.PageSave)
                {
                    case true:
                        {
                            SavePageBtn.Click();
                            break;
                        }
                    default:
                        {
                            CancelPageBtn.Click();
                            break;
                        }
                }       
            }
            catch (Exception ex)
            {
              //  throw ex;
            }            
        }
        public void PageGroup(string PageType)
        {
            try
            {
                switch (PageType)
                {
                    case "Admin":
                        {
                            AdminPageTab.Click();
                            break;
                        }
                    default:
                        {
                            PortalPageTab.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
        public void CreatePage(FillPage FillPageI)
        {
            try
            {
                PageGroup(FillPageI.PageType);
                CreatePageBtn.Click();
                FillPage(FillPageI);
                ClosePagesDetailsDiv();
                IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                IsAt isat = new IsAt(PageCreated, Message.Text);
                Assert.IsTrue(Browser.IsAt(isat));      
            }
            catch (Exception ex)
            {
               // throw ex;
            }      
        }
        public IList<IWebElement> GetPage()
        {
            try
            {
                IList<IWebElement> Pages = PagesList.FindElements(By.TagName("li"));
                //Assert.That(Pages, Has.Property(Pages.Count.ToString()).EqualTo(Pages.Count.ToString()));
                return Pages;
            }
            catch (Exception ex)
            {
                return null;
              //  throw ex;
            }
        }        
        public void PageManagement(PageManagement PageManagement)
        {
            try
            {
                IList<IWebElement> Pages = GetPage();
                IList<IWebElement> Span = Pages[PageManagement.N].FindElements(By.TagName("span"));               
                Browser.MouseRightClick(Span[1]);
                IWebElement List = Browser.Driver.FindElement(By.Id("jqContextMenu"));
                IWebElement ul = List.FindElement(By.TagName("ul"));
                IList<IWebElement> Operations = ul.FindElements(By.TagName("li"));
                switch (PageManagement.Operation)
                {
                    case "AddNewPage":
                        {
                            Operations[0].Click();
                            FillPage(PageManagement.FillPage);
                            break;
                        }
                    case "Edit":
                        {
                            Operations[1].Click();
                            FillPage(PageManagement.FillPage);
                            break;
                        }
                    case "DeletePage":
                        {
                            Operations[2].Click();
                            Delete(PageManagement.DeleteConfirm);
                            break;
                        }
                    case "SetAsStartPage":
                        {
                            Operations[3].Click();
                            break;
                        }
                }
                ClosePagesDetailsDiv();
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }      
        public void Pagination(Pagination Pagination)
        {
            try
            {
                IWebElement PaginationTable = Browser.Driver.FindElement(By.Id(Pagination.Id));
                IWebElement PaginationDiv = PaginationTable.FindElement(By.TagName("div"));
                IList<IWebElement> PaginationLink = PaginationDiv.FindElements(By.LinkText(Pagination.PageNo.ToString()));
                if (PaginationLink.Count != 0)
                {
                    PaginationLink[0].Click();
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void SortModules()
        {
            try
            {
                SortBtn.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public IWebElement Module(string ModuleID)
        {
            try
            {
                int i = 1;
                IWebElement Div = Browser.Driver.FindElement(By.ClassName("pagination"));
                IList<IWebElement> PageList = Div.FindElements(By.TagName("a"));
Start:          IList<IWebElement> ModuleDiv = FloatDiv.FindElements(By.TagName("div"));
                IWebElement ModuleList = ModuleDiv[1].FindElement(By.TagName("ul"));
                //IWebElement List = ModuleList.FindElement(By.TagName("li"));
                IList<IWebElement> ModuleLink = ModuleList.FindElements(By.Id(ModuleID));
                switch (ModuleLink.Count())
                {
                    case 0:
                        {
                            i++;
                            if (i <= PageList.Count())
                            {
                                Pagination PaginationI = new Pagination("Pagination", i);
                                Pagination(PaginationI);
                                goto Start;
                            }
                            break;
                        }
                    default:
                        {
                            goto End;
                        }
                }
End:            return ModuleLink[0];   
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }                       
        }
        public IWebElement SearchModule(string ModuleName)
        {
            try
            {
                ModulesSearchBox.Click();
                ClearAndFillTextBox ModulesSearchClearNFill = new ClearAndFillTextBox(ModulesSearchBox, ModuleName);
                Browser.ClearAndFillTextBox(ModulesSearchClearNFill);
                IWebElement ModuleLink = Module(ModuleName);
                return ModuleLink;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public void SwitchMode(string Mode)
        {
            try
            {
                switch (Mode)
                {
                    case "PC":
                        {
                            PCSwitch.Click();
                            break;
                        }
                    case "Mobile":
                        {
                            MobileSwitch.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void PublishPage(bool Publish)
        {
            try
            {
                string Text = PublishBtn.GetAttribute("value");
                switch (Publish)
                {
                    case true:
                        {
                            if (Text == "Unpublish")
                            {
                                PublishBtn.Click();
                            }
                            break;
                        }
                    case false:
                        {
                            if (Text == "Publish")
                            {
                                PublishBtn.Click();
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void PreviewPage()
        {
            try
            {
                PreviewBtn.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void SelectLayout(SelectLayout SelectLayout)
        {
            try
            {
                DropDownSelect DropDownLayout = new DropDownSelect(SelectLayout.Layout, LayoutDropdown);
                Browser.SelectDropdown(DropDownLayout);
                if (SaveLayout.Displayed)
                {
                    switch (SelectLayout.Save)
                    {
                        case true:
                            {
                                SaveLayout.Click();
                                break;
                            }
                        default:
                            {
                                CancelLayout.Click();
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
        public IWebElement GetPlaceHolder(string Section)
        {
            try
            {
                IWebElement SectionDiv = Browser.Driver.FindElement(By.Id("sf" + Section));
                IWebElement PlaceHolder = SectionDiv.FindElement(By.ClassName("sfblocks"));
                return PlaceHolder;
            }
            catch (Exception ex)
            {
                return null;
              //  throw ex;
            }
        }
        public void Page(Page Page)
        {
            try
            {
                IList<IWebElement> PageI = GetPage();
                PageI[Page.N].Click();
                Browser.Wait();
                //SelectLayout(Layout, SaveLayout); 
                //SwitchMode(Mode);
                //PublishPage(Publish);            
                IWebElement ModuleLink = Module(Page.ModuleID);
                IWebElement Placeholder = GetPlaceHolder(Page.Section);
                DragNDrop ModuleDrop = new DragNDrop(ModuleLink, Placeholder);
                Browser.DragAndDrop(ModuleDrop);
                ModuleDetails(Page.ModuleDetails);
                Browser.Wait();
                IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                //Message.GetCssValue("font-size"); 
                IsAt isat = new IsAt(ModuleAdded, Message.Text);
                Assert.IsTrue(Browser.IsAt(isat));
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
        public void ModuleDetails(ModuleDetails ModuleDetails)
        {
            try
            {
                IWebElement PermissionDiv = Browser.Driver.FindElement(By.Id("dvPermissions"));
                IWebElement DivPermissions = PermissionDiv.FindElement(By.ClassName("divPermissions"));
                IWebElement UserTable = DivPermissions.FindElement(By.TagName("table"));
                IWebElement Tbody = UserTable.FindElement(By.TagName("tbody"));
                IWebElement AnonymousUserRole = Tbody.FindElement(By.Id("a87e850f-14c8-4c89-86f4-4598ff27da72"));
                IWebElement SiteAdminRole = Tbody.FindElement(By.Id("910f0c31-e1dd-42d2-988b-545fe8621544"));
                IWebElement RegisteredUserRole = Tbody.FindElement(By.Id("8281caa9-7ace-4db1-8b6d-e2c7c2d0d60a"));
                ClearAndFillTextBox ModuleTitleClearNFill = new ClearAndFillTextBox(ModuleTitleTextBox, ModuleDetails.ModuleTitle);
                Browser.ClearAndFillTextBox(ModuleTitleClearNFill);
                ChkBox HeaderChkBox = new ChkBox(ModuleDetails.Header, HeaderCheckBox);
                Browser.CheckBox(HeaderChkBox);
                if (ModuleDetails.Header)
                {
                    ClearAndFillTextBox HeaderClearNFill = new ClearAndFillTextBox(HeaderTextBox, ModuleDetails.HeaderText);
                    Browser.ClearAndFillTextBox(HeaderClearNFill);
                }
                ClearAndFillTextBox ModuleSuffixClearNFill = new ClearAndFillTextBox(ModuleSuffixTextBox, ModuleDetails.ModuleSuffixClass);
                Browser.ClearAndFillTextBox(ModuleSuffixClearNFill);
                ChkBox ActiveChkBox = new ChkBox(ModuleDetails.IsActive, IsActiveCheckBox);
                Browser.CheckBox(ActiveChkBox);
                switch (ModuleDetails.ShowInPages)
                {
                    case "All":
                        {
                            ChkBox AllpagesChkBox = new ChkBox(true, AllPagesCheckBox);
                            Browser.CheckBox(AllpagesChkBox);
                            break;
                        }
                    case "Customize":
                        {
                            ChkBox CustomPagesChkBox = new ChkBox(true, CustomPagesCheckBox);
                            Browser.CheckBox(CustomPagesChkBox);
                            IWebElement Div = Browser.Driver.FindElement(By.ClassName("pagination"));
                            IList<IWebElement> PageList = Div.FindElements(By.TagName("a"));
                            int i, j = 1;
                            for (i = 0; i < ModuleDetails.CustomPages.Count(); i++)
                            {
                            Select: IList<IWebElement> Pages = PageTree.FindElements(By.Id(ModuleDetails.CustomPages[i]));
                                switch (Pages.Count())
                                {
                                    case 0:
                                        {
                                            if (j <= PageList.Count())
                                            {
                                                j++;
                                                Pagination PaginationI = new Pagination("Pagination", j);
                                                Pagination(PaginationI);
                                                goto Select;
                                            }
                                            break;
                                        }
                                    default:
                                        {
                                            Pages[0].Click();
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                }
                switch (ModuleDetails.Preferences)
                {
                    case "Inherit":
                        {
                            ChkBox InheritPermissionChkBox = new ChkBox(true, InheritPermissionCheckBox);
                            Browser.CheckBox(InheritPermissionChkBox);
                            break;
                        }
                    default:
                        {
                            ModulePermissionsTab.Click();
                            SetPermission SetPermissionI = new SetPermission(AnonymousUserRole, SiteAdminRole, RegisteredUserRole, ModuleDetails.AnonymousPermission, ModuleDetails.SiteAdminPermission, ModuleDetails.RegisteredUserPermission);
                            SetPermission(SetPermissionI);
                            ModuleBasicsTab.Click();
                            break;
                        }
                }
                ChkBox DonotShowChkBox = new ChkBox(ModuleDetails.DonotShow, DonotShowCheckBox);
                Browser.CheckBox(DonotShowChkBox);
                switch (ModuleDetails.Save)
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
               // throw ex;
            }            
        }
    }
}
