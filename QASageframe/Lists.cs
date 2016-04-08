using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class List
    {
        public string TextEntry { get; set; }
        public string ValueEntry { get; set; }
        public bool AddConfirm { get; set; }
        public List(string textentry, string valueentry, bool addconfirm)
        {
            TextEntry = textentry;
            ValueEntry = valueentry;
            AddConfirm = addconfirm;
        }
    }
    public class AddList
    {
        public string NewListName { get; set; }
        public bool Parent { get; set; }
        public string ParentList { get; set; }
        public string ParentEntry { get; set; }
        public bool NewListActive { get; set; }
        public List List { get; set; }
        public AddList(string newlistname, bool parent, string parentlist, string parententry, bool newlistactive, List list)
        {
            NewListName = newlistname;
            Parent = parent;
            ParentList = parentlist;
            ParentEntry = parententry;
            NewListActive = newlistactive;
            List = list;
        }
    }
    public class AddListItem
    {
        public List List { get; set; }
        public string CurrencyCode { get; set; }
        public string DisplayLocale { get; set; }
        public bool ListItemActive { get; set; }
        public AddListItem(List list, string currencycode, string displaylocale, bool listitemactive)
        {
            List = list;
            CurrencyCode = currencycode;
            DisplayLocale = displaylocale;
            ListItemActive = listitemactive;
        }
    }
    public class ListManagement
    {
        public int PageSize { get; set; }
        public bool DeleteList { get; set; }
        public bool ListEdit { get; set; }
        public int EditListNo { get; set; }
        public bool ChildList { get; set; }
        public int ParentListNo { get; set; }
        public int ChildListDivNo { get; set; }
        public int ChildListNo { get; set; }
        public bool Confirm { get; set; }
        public bool Edit { get; set; }
        public int ListNo { get; set; }
        public bool AddListItemI { get; set; }
        public AddList AddList { get; set; }
        public AddListItem AddListItem { get; set; }
        public ListManagement(int pagesize, bool deletelist, bool listedit, int editlistno, bool childlist, int parentlistno, int childlistdivno, int childlistno, bool confirm, bool edit, int listno, bool addlistitemI, AddList addlist, AddListItem addlistitem)
        {
            PageSize = pagesize;
            DeleteList = deletelist;
            ListEdit = listedit;
            EditListNo = editlistno;
            ChildList = childlist;
            ParentListNo = parentlistno;
            ChildListDivNo = childlistdivno;
            ChildListNo = childlistno;
            Confirm = confirm;
            Edit = edit;
            ListNo = listno;
            AddList = addlist;
            AddListItem = addlistitem;
            AddListItemI = addlistitemI;
        }
    }
    #endregion
    public static class Lists
    {
        public static ListsPage ListsPage
        {
            get
            {
                var listspage = new ListsPage();
                PageFactory.InitElements(Browser.Driver, listspage);
                return listspage;
            }
        }
    }
    public class ListsPage
    {
        public string Url = "Admin/Lists.aspx";
        public string Text = "Lists";
        #region
        //Lists
        [FindsBy(How = How.Id, Using = "ctl19_txtListName")][CacheLookup]
        public IWebElement ListNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlParentList")][CacheLookup]
        public IWebElement ParentListDropDown { get; set; }
        [FindsBy(How = How.ClassName, Using = "sfPagination")][CacheLookup]
        public IWebElement PaginationDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_tvListn0Nodes")][CacheLookup]
        public IWebElement ListNodesDiv { get; set; }        
        //Dropdown
        [FindsBy(How = How.Id, Using = "ctl19_ddlGridPageSize")][CacheLookup]
        public IWebElement GridPageSizeDropdown { get; set; }
        //Country
        [FindsBy(How = How.Id, Using = "ctl19_txtEntryText")]
        public IWebElement TextEntryTxtBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtEntryValue")]
        public IWebElement ValueEntryTxtBox { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_txtCurrencyCode")]
        //public IWebElement CurrencyCodeTxtBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtDisplayLocale")]
        public IWebElement DisplayLocaleTxtBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkActive")]
        public IWebElement ActiveCheckBox { get; set; }      
        //Add
        [FindsBy(How = How.Id, Using = "ctl19_pnlListAll")][CacheLookup]
        public IWebElement ListDiv { get; set; }       
        [FindsBy(How = How.Id, Using = "ctl19_pnlAddList")]
        public IWebElement AddListDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvSubList")][CacheLookup]
        public IWebElement ListGrid { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblListName")][CacheLookup]
        public IWebElement ListName { get; set; }
        #endregion
        public void Add(bool addconfirm)
        {
            try
            {
                IWebElement AddListButtonWrapperDiv = AddListDiv.FindElement(By.TagName("div"));
                IList<IWebElement> AddListLabel = AddListButtonWrapperDiv.FindElements(By.TagName("label"));
                switch (addconfirm)
                {
                    case true:
                        {
                            AddListLabel[0].Click();
                            break;
                        }
                    default:
                        {
                            AddListLabel[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }     
        public void AddList(AddList AddList)
        {
            try
            {
                WaitForElement BottomPanel = new WaitForElement(By.Id("divBottompanel"), 20);
                IWebElement BottomPanelDiv = Browser.WaitForElement(BottomPanel);
                IWebElement Div = BottomPanelDiv.FindElement(By.TagName("div"));
                IWebElement ModuleContentDiv = Div.FindElement(By.TagName("div"));
                IWebElement DivI = ModuleContentDiv.FindElement(By.TagName("div"));
                IWebElement ListManagerDiv = DivI.FindElement(By.TagName("div"));
                IWebElement Treeviewholder = ListManagerDiv.FindElements(By.TagName("div"))[0];
                IList<IWebElement> ButtonWrapperDiv = Treeviewholder.FindElements(By.TagName("div"));
                IWebElement AddNewList = ButtonWrapperDiv[0].FindElement(By.TagName("label"));
                AddNewList.Click();
                ClearAndFillTextBox ListNameClearNFill = new ClearAndFillTextBox(ListNameTextBox, AddList.NewListName);
                Browser.ClearAndFillTextBox(ListNameClearNFill);
                if (AddList.Parent)
                {
                    DropDownSelect ListParentDropDown = new DropDownSelect(AddList.ParentList, ParentListDropDown);
                    Browser.SelectDropdown(ListParentDropDown);
                    WaitForElement ParentEntryWait = new WaitForElement(By.Id("ctl19_ddlParentEntry"), 30);
                    IWebElement ParentEntryDropDown = Browser.WaitForElement(ParentEntryWait);
                    DropDownSelect EntryParentDropDown = new DropDownSelect(AddList.ParentEntry, ParentEntryDropDown);
                    Browser.SelectDropdown(EntryParentDropDown);
                }
                ClearAndFillTextBox TextEntryClearNFill = new ClearAndFillTextBox(TextEntryTxtBox, AddList.List.TextEntry);
                Browser.ClearAndFillTextBox(TextEntryClearNFill);
                ClearAndFillTextBox ValueEntryClearNFill = new ClearAndFillTextBox(ValueEntryTxtBox, AddList.List.ValueEntry);
                Browser.ClearAndFillTextBox(ValueEntryClearNFill);
                ChkBox NewListChkBox = new ChkBox(AddList.NewListActive, ActiveCheckBox);
                Browser.CheckBox(NewListChkBox);
                Add(AddList.List.AddConfirm);
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }       
        public void AddListItem(AddListItem AddListItem)
        {
            try
            {
                ClearAndFillTextBox TextEntryClearNFill = new ClearAndFillTextBox(TextEntryTxtBox, AddListItem.List.TextEntry);
                Browser.ClearAndFillTextBox(TextEntryClearNFill);
                ClearAndFillTextBox ValueEntryClearNFill = new ClearAndFillTextBox(TextEntryTxtBox, AddListItem.List.ValueEntry);
                Browser.ClearAndFillTextBox(ValueEntryClearNFill);
                IList<IWebElement> CurrencyCodeTxtBox = Browser.Driver.FindElements(By.Id("ctl19_txtCurrencyCode"));
                if (CurrencyCodeTxtBox.Count > 0)
                {
                    ClearAndFillTextBox CurrencyCodeClearNFill = new ClearAndFillTextBox(CurrencyCodeTxtBox[0], AddListItem.CurrencyCode);
                    Browser.ClearAndFillTextBox(CurrencyCodeClearNFill);
                    ClearAndFillTextBox DisplayLocaleClearNFill = new ClearAndFillTextBox(DisplayLocaleTxtBox, AddListItem.DisplayLocale);
                    Browser.ClearAndFillTextBox(DisplayLocaleClearNFill);
                }
                ChkBox ListChkBox = new ChkBox(AddListItem.ListItemActive, ActiveCheckBox);
                Browser.CheckBox(ListChkBox);
                Add(AddListItem.List.AddConfirm);
            }
            catch (Exception ex)
            {
                //throw ex;
            }           
        }      
        public void ListManagement(ListManagement ListManagement)
        {
            try
            {
                DropDownSelect PageSizeDropDown = new DropDownSelect(ListManagement.PageSize.ToString(), GridPageSizeDropdown);
                Browser.SelectDropdown(PageSizeDropDown);
                //List List = new List(TextEntry, ValueEntry, AddConfirm);
                //AddList AddListI = new AddList(NewListName, Parent, ParentList, ParentEntry, NewListActive, List);
                AddList(ListManagement.AddList);
                IWebElement ListButtonWrapperDiv = ListDiv.FindElement(By.TagName("div"));
                IList<IWebElement> ListLabel = ListButtonWrapperDiv.FindElements(By.TagName("label"));
                if (ListManagement.AddListItemI)
                {
                    ListLabel[0].Click();
                    //AddListItem AddListItemII = new AddListItem(List, CurrencyCode, DisplayLocale, ListItemActive);
                    AddListItem(ListManagement.AddListItem);
                }
                if (ListManagement.DeleteList)
                {
                    ListLabel[1].Click();
                    Browser.SwitchToAlert(ListManagement.Confirm);
                    Browser.SwitchToMainWindow();
                    //Process myProcess = new Process();
                    //try
                    //{
                    //    myProcess.StartInfo.UseShellExecute = false;
                    //    string FilePath = @"C:\Users\RajKumar-PC\Documents\Visual Studio 2013\Projects\QASageframe\AutoIt\Test.exe";
                    //    myProcess.StartInfo.FileName = FilePath;
                    //    myProcess.StartInfo.CreateNoWindow = true;
                    //    myProcess.Start();
                    //    //This code assumes the process you are starting will terminate itself.
                    //    //Given that is is started without a window so you cannot terminate it
                    //    //on the desktop, it must terminate itself or you can do it programmatically
                    //    //from this application using the Kill method.
                    //}
                    //catch (Exception e)
                    //{
                    //    Console.WriteLine(e.Message);
                    //}               
                }
                if (ListManagement.ListEdit)
                {
                    //IWebElement EditList = Browser.Driver.FindElement(By.Id("ctl19_tvListt" + EditListNo.ToString()));
                    //Windows component Halt the process
                    WaitForElement TVListWait = new WaitForElement(By.Id("ctl19_tvList"), 40);
                    IWebElement TVListDiv = Browser.WaitForElement(TVListWait);
                    IList<IWebElement> ListTable = TVListDiv.FindElements(By.TagName("table"));
                    IWebElement Tbody = ListTable[ListManagement.EditListNo].FindElement(By.TagName("tbody"));
                    IWebElement Tr = Tbody.FindElement(By.TagName("tr"));
                    IList<IWebElement> Td = Tr.FindElements(By.TagName("td"));
                    switch (ListManagement.ChildList)
                    {
                        case true:
                            {
                                IList<IWebElement> ParentExpand = Td[0].FindElements(By.TagName("a"));
                                if (ParentExpand.Count > 0)
                                {
                                    ParentExpand[0].Click();
                                }
                                IWebElement ChildListDiv = Browser.Driver.FindElement(By.Id("ctl19_tvListn" + ListManagement.ChildListDivNo.ToString() + "Nodes"));
                                IList<IWebElement> ChildListTable = ChildListDiv.FindElements(By.TagName("table"));
                                IWebElement ChildListTbody = ChildListTable[ListManagement.ChildListNo].FindElement(By.TagName("tbody"));
                                IWebElement ChildListTr = ChildListTbody.FindElement(By.TagName("tr"));
                                IWebElement ChildListTd = ChildListTr.FindElements(By.TagName("td"))[2];
                                IWebElement ChildListLink = ChildListTd.FindElement(By.TagName("a"));
                                ChildListLink.Click();
                                break;
                            }
                        default:
                            {
                                IWebElement ListLink = Td[1].FindElement(By.TagName("a"));
                                ListLink.Click();
                                break;
                            }
                    }
                    IWebElement tbody = ListGrid.FindElement(By.TagName("tbody"));
                    IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                    IList<IWebElement> td = tr[ListManagement.ListNo].FindElements(By.TagName("td"));
                    if (ListManagement.Edit)
                    {
                        IWebElement Listedit = td[3].FindElement(By.TagName("a"));
                        Listedit.Click();
                       // AddListItem AddListItemII = new AddListItem(List,CurrencyCode, DisplayLocale, ListItemActive);
                        AddListItem(ListManagement.AddListItem);
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }   
        }
    }
}
