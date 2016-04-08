using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;
namespace QASageframe
{
    #region
    public class AddMenu
    {
        public string MenuName { get; set; }
        public bool CreateMenu { get; set; }
        public AddMenu(string menuname, bool createmenu)
        {
            MenuName = menuname;
            CreateMenu = createmenu;
        }
    }
    public class MenuChanges
    {
        public int MenuId { get; set; }
        public bool EditMenu { get; set; }
        public bool DelMenu { get; set; }
        public string NewMenuName { get; set; }
        public bool UpdateMenu { get; set; }
        public bool ConfirmDel { get; set; }
        public MenuChanges(int menuid, bool editmenu, bool delmenu, string newmenuname, bool updatemenu, bool confirmdel)
        {
            MenuId = menuid;
            EditMenu = editmenu;
            DelMenu = delmenu;
            NewMenuName = newmenuname;
            UpdateMenu = updatemenu;
            ConfirmDel = confirmdel;
        }
    }
    public class MenuType
    {
        public string MenuTypeI { get; set; }
        public bool PreservePageOrder { get; set; }
        public bool SelectAllPages { get; set; }
        public int[] PageNo { get; set; }
        public bool[] ParentPage { get; set; }
        public string[] Parent { get; set; }
        public bool ConfirmAddToMenu { get; set; }
        public string LinkTitle { get; set; }
        public string ExternalLink { get; set; }
        public string Caption { get; set; }
        public string IconPath { get; set; }
        public bool LinkActive { get; set; }
        public bool LinkVisible { get; set; }
        public string ExternalLinkParent { get; set; }
        public bool ParentExternalLink { get; set; }
        public string HtmlContentTitle { get; set; }
        public string CaptionHtmlContent { get; set; }
        public bool HtmlContentVisible { get; set; }
        public bool ParentHtmlContent { get; set; }
        public string HtmlContentParent { get; set; }
        public MenuType(string menutypei, bool preservepageorder, bool selectallpages, int[] pageno, bool[] parentpage, string[] parent, bool confirmaddtomenu, string linktitle, string externallink, string caption, string iconpath, bool linkactive, bool linkvisible, string externallinkparent, bool parentexternallink, string htmlcontenttitle, string captionhtmlcontent, bool htmlcontentvisible, bool parenthtmlcontent, string htmlcontentparent)
        {
            MenuTypeI = menutypei;
            PreservePageOrder = preservepageorder;
            SelectAllPages = selectallpages;
            PageNo = pageno;
            ParentPage = parentpage;
            Parent = Parent;
            ConfirmAddToMenu = confirmaddtomenu;
            LinkTitle = linktitle;
            ExternalLink = externallink;
            Caption = caption;
            IconPath = iconpath;
            LinkActive = linkactive;
            LinkVisible = linkvisible;
            ExternalLinkParent = externallinkparent;
            ParentExternalLink = parentexternallink;
            HtmlContentTitle = htmlcontenttitle;
            CaptionHtmlContent = captionhtmlcontent;
            HtmlContentVisible = htmlcontentvisible;
            ParentHtmlContent = parenthtmlcontent;
            HtmlContentParent = htmlcontentparent;
        }
    }
    public class MenuManage
    {
        public int PageNo { get; set; }
        public string SubText { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        public bool ParentPage { get; set; }
        public string Parent { get; set; }
        public bool ConfirmUpdate { get; set; }
        public bool ChangeSettings { get; set; }
        public int MenuNo { get; set; }
        public int MenuStyle { get; set; }
        public bool ShowImage { get; set; }
        public bool ShowText { get; set; }
        public bool ShowCaption { get; set; }
        public MenuManage(int pageno, string subtext, bool isactive, bool isvisible, bool parentpage, string parent, bool confirmupdate, bool changesettings, int menuno, int menustyle, bool showimage, bool showtext, bool showcaption)
        {
            PageNo = pageno;
            SubText = subtext;
            IsActive = isactive;
            IsVisible = isvisible;
            ParentPage = parentpage;
            Parent = parent;
            ConfirmUpdate = confirmupdate;
            ChangeSettings = ChangeSettings;
            MenuNo = menuno;
            MenuStyle = menustyle;
            ShowImage = showimage;
            ShowText = showtext;
            ShowCaption = showcaption;
        }
    }
    #endregion
    public static class Menu
    {
        public static MenuPage MenuPage
        {
            get
            {
                var menupage = new MenuPage();
                PageFactory.InitElements(Browser.Driver, menupage);
                return menupage;
            }
        }
    }    
    public class MenuPage
    {
        public string Url = "Admin/Menu.aspx";
        public string Text = "Menu";
        public string MenuAdded = "Menu item added successfully";
        #region
        //Add Menu
        [FindsBy(How = How.Id, Using = "btnAddpage")][CacheLookup]
        public IWebElement btnAddMenu { get; set; }
        [FindsBy(How = How.Id, Using = "txtMenuName")][CacheLookup]
        public IWebElement txtBoxMenuName { get; set; }
        [FindsBy(How = How.Id, Using = "imgAdd")][CacheLookup]
        public IWebElement btnCreateNewMenu { get; set; }
        [FindsBy(How = How.Id, Using = "dvView")]
        public IWebElement divId { get; set; }
        //Menu Change
        [FindsBy(How = How.Id, Using = "menuList")][CacheLookup]
        public IWebElement ListMenu { get; set; }
        [FindsBy(How = How.Id, Using = "imgUpdate")][CacheLookup]
        public IWebElement btnUpdateMenu;
        //Menu Type
        [FindsBy(How = How.Id, Using = "rdbPages")][CacheLookup]
        public IWebElement Pages { get; set; }
        [FindsBy(How = How.Id, Using = "rdbExternalLink")][CacheLookup]
        public IWebElement ExternalLink { get; set; }
        [FindsBy(How = How.Id, Using = "rdbHtmlContent")][CacheLookup]
        public IWebElement HtmlContent { get; set; }
        [FindsBy(How = How.Id, Using = "selMenuItem")][CacheLookup]
        public IWebElement selectMenu { get; set; }
        [FindsBy(How = How.Id, Using = "chkSelectAllPages")][CacheLookup]
        public IWebElement SelectAllPage { get; set; }
        [FindsBy(How = How.Id, Using = "chkPageOrder")][CacheLookup]
        public IWebElement PageOrder { get; set; }
        [FindsBy(How = How.Id, Using = "imgAddmenuItem")][CacheLookup]
        public IWebElement AddMenuItem { get; set; }
        [FindsBy(How = How.Id, Using = "imgAddmenuCancel")][CacheLookup]
        public IWebElement AddMenuCancel { get; set; }
        [FindsBy(How = How.Id, Using = "pagesTree")][CacheLookup]
        public IWebElement PageTree { get; set; }
        [FindsBy(How = How.Id, Using = "txtLinkTitle")][CacheLookup]
        public IWebElement txtLinkTitle { get; set; }
        [FindsBy(How = How.Id, Using = "txtExternalLink")][CacheLookup]
        public IWebElement txtExternalLink { get; set; }
        [FindsBy(How = How.Id, Using = "txtCaptionExtLink")][CacheLookup]
        public IWebElement txtCaptionExtLink { get; set; }
        [FindsBy(How = How.Id, Using = "chkLinkActive")][CacheLookup]
        public IWebElement LinkActive { get; set; }
        [FindsBy(How = How.Id, Using = "chkLinkVisible")][CacheLookup]
        public IWebElement LinkVisible { get; set; }
        [FindsBy(How = How.Id, Using = "txtTitleHtmlContent")][CacheLookup]
        public IWebElement HtmlContentTitle { get; set; }
        [FindsBy(How = How.Id, Using = "txtCaptionHtmlContent")][CacheLookup]
        public IWebElement CaptionHtmlContent { get; set; }
        [FindsBy(How = How.Id, Using = "chkVisibleHtmlContent")][CacheLookup]
        public IWebElement HtmlContentVisible { get; set; }
        [FindsBy(How = How.Id, Using = "cke_contents_txtHtmlContent")][CacheLookup]
        public IWebElement HtmlContentIframe { get; set; }
        [FindsBy(How = How.TagName, Using = "body")]
        public IWebElement framebody;
        [FindsBy(How = How.Id, Using = "cke_7")][CacheLookup]
        public IWebElement Source { get; set; }
        [FindsBy(How = How.Id, Using = "cke_contents_txtHtmlContent")][CacheLookup]
        public IWebElement SourceTextArea { get; set; }
        //Menu Manage
        [FindsBy(How = How.Id, Using = "pageTree")][CacheLookup]
        public IWebElement ulTree { get; set; }
        [FindsBy(How = How.Id, Using = "txtSubText")][CacheLookup]
        public IWebElement SubText { get; set; }
        [FindsBy(How = How.Id, Using = "chkIsActivePage")][CacheLookup]
        public IWebElement ActivePage { get; set; }
        [FindsBy(How = How.Id, Using = "chkIsVisiblePage")][CacheLookup]
        public IWebElement VisiblePage { get; set; }
        [FindsBy(How = How.Id, Using = "MenuMgrSetting")][CacheLookup]
        public IWebElement MenuSetting { get; set; }
        [FindsBy(How = How.Id, Using = "tblTopClientMenu")][CacheLookup]
        public IWebElement Menu { get; set; }
        [FindsBy(How = How.Id, Using = "chkShowImage")][CacheLookup]
        public IWebElement ShowImage;
        [FindsBy(How = How.Id, Using = "chkShowText")][CacheLookup]
        public IWebElement ShowText;
        [FindsBy(How = How.Id, Using = "chkCaption")][CacheLookup]
        public IWebElement ShowCaption;
        [FindsBy(How = How.Id, Using = "btnSave")][CacheLookup]
        public IWebElement SaveButton; 
        #endregion       
        public void AddMenu(AddMenu AddMenu)
        {
            try
            {
                btnAddMenu.Click();
                ClearAndFillTextBox MenuNameClearNFill = new ClearAndFillTextBox(txtBoxMenuName, AddMenu.MenuName);
                Browser.ClearAndFillTextBox(MenuNameClearNFill);
                switch (AddMenu.CreateMenu)
                {
                    case true:
                        {
                            btnCreateNewMenu.Click();
                            break;
                        }
                    default:
                        {
                            IList<IWebElement> Leftdiv = divId.FindElements(By.TagName("div"));
                            IList<IWebElement> DivFlying = Leftdiv[1].FindElements(By.TagName("div"));
                            IWebElement FlyingClose = DivFlying[1].FindElement(By.TagName("i"));
                            FlyingClose.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }       
        public void MenuChanges(MenuChanges MenuChanges)
        {
            try
            {
                IWebElement ul = ListMenu.FindElement(By.TagName("ul"));
                IList<IWebElement> li = ul.FindElements(By.TagName("li"));
                IList<IWebElement> span = li[MenuChanges.MenuId].FindElements(By.TagName("span"));
                span[0].Click();
                IList<IWebElement> menusettings = span[1].FindElements(By.TagName("i"));
                if (MenuChanges.EditMenu)
                {
                    menusettings[0].Click();
                    ClearAndFillTextBox MenuNameClearNFill = new ClearAndFillTextBox(txtBoxMenuName, MenuChanges.NewMenuName);
                    Browser.ClearAndFillTextBox(MenuNameClearNFill);
                    switch (MenuChanges.UpdateMenu)
                    {
                        case true:
                            {
                                btnUpdateMenu.Click();
                                break;
                            }
                        default:
                            {
                                IList<IWebElement> Leftdiv = divId.FindElements(By.TagName("div"));
                                IList<IWebElement> DivFlying = Leftdiv[1].FindElements(By.TagName("div"));
                                IWebElement FlyingClose = DivFlying[1].FindElement(By.TagName("i"));
                                FlyingClose.Click();
                                break;
                            }
                    }
                }
                if (MenuChanges.DelMenu)
                {
                    menusettings[1].Click();
                    IWebElement body = Browser.Driver.FindElement(By.TagName("body"));
                    IList<IWebElement> widgetdiv = body.FindElements(By.TagName("div"));
                    IList<IWebElement> buttondiv = widgetdiv[5].FindElements(By.TagName("div"));
                    IWebElement dialogdiv = buttondiv[9].FindElement(By.TagName("div"));
                    IList<IWebElement> button = dialogdiv.FindElements(By.TagName("button"));
                    if (MenuChanges.ConfirmDel)
                    {
                        button[0].Click();
                    }
                    else
                    {
                        button[1].Click();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }            
        public void MenuType(MenuType MenuType)
        {
            try
            {
                IWebElement Centerdiv = divId.FindElements(By.TagName("div"))[0];
                IWebElement CenterWrapper = Centerdiv.FindElement(By.TagName("div"));
                IWebElement sfCenter = CenterWrapper.FindElement(By.TagName("div"));
                IWebElement QuickLink = sfCenter.FindElements(By.TagName("div"))[0];
                IWebElement RadioButton = QuickLink.FindElements(By.TagName("div"))[0];
                IList<IWebElement> label = RadioButton.FindElements(By.TagName("label"));
                int n = MenuType.PageNo.Count();
                switch (MenuType.MenuTypeI)
                {
                    case "Pages":
                        {
                            string Ptext = label[0].GetAttribute("class");
                            if (Ptext != "sfActive")
                            {
                                label[0].Click();
                            }
                            if (MenuType.PreservePageOrder)
                            {
                                if (!PageOrder.Selected)
                                {
                                    PageOrder.Click();
                                }
                            }
                            switch (MenuType.SelectAllPages)
                            {
                                case true:
                                    {
                                        if (!SelectAllPage.Selected)
                                        {
                                            SelectAllPage.Click();
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        IList<IWebElement> li = PageTree.FindElements(By.TagName("li"));
                                        IWebElement ul = li[1].FindElement(By.TagName("ul"));
                                        for (int i = 0; i < n; i++)
                                        {
                                            int j = MenuType.PageNo[i];
                                            IList<IWebElement> lipage = ul.FindElements(By.TagName("li"));
                                            IWebElement input = lipage[i].FindElement(By.TagName("input"));
                                            if (!input.Selected)
                                            {
                                                input.Click();
                                            }
                                            if (MenuType.ParentPage[i])
                                            {
                                                SelectElement SelectParentPage = new SelectElement(selectMenu);
                                                SelectParentPage.SelectByText(MenuType.Parent[i]);
                                            }
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case "External Link":
                        {
                            //ExternalLink.Click();
                            string ELtext = label[1].GetAttribute("class");
                            if (ELtext != "sfActive")
                            {
                                label[1].Click();
                            }
                            //IWebElement inputMenu = label[1].FindElement(By.TagName("input"));
                            ClearAndFillTextBox LinkTitleClearNFill = new ClearAndFillTextBox(txtLinkTitle, MenuType.LinkTitle);
                            Browser.ClearAndFillTextBox(LinkTitleClearNFill);
                            ClearAndFillTextBox ExternalLinkClearNFill = new ClearAndFillTextBox(txtExternalLink, MenuType.ExternalLink);
                            Browser.ClearAndFillTextBox(ExternalLinkClearNFill);
                            ClearAndFillTextBox CaptionExtLinkClearNFill = new ClearAndFillTextBox(txtCaptionExtLink, MenuType.Caption);
                            Browser.ClearAndFillTextBox(CaptionExtLinkClearNFill);
                            //IWebElement div = body.FindElements(By.TagName("div"));
                            //IWebElement icon = div[7].FindElement(By.TagName("input"));
                            //icon.SendKeys(iconpath);
                            if (MenuType.LinkActive)
                            {
                                if (!LinkActive.Selected)
                                {
                                    LinkActive.Click();
                                }
                            }
                            if (MenuType.LinkVisible)
                            {
                                if (!LinkVisible.Selected)
                                {
                                    LinkVisible.Click();
                                }
                            }
                            //SelectElement SelectParentExternalLink = new SelectElement(selectMenu);
                            if (MenuType.ParentExternalLink)
                            {
                                DropDownSelect MenuDropDown = new DropDownSelect(MenuType.ExternalLinkParent, selectMenu);
                                Browser.SelectDropdown(MenuDropDown);
                                //SelectParentExternalLink.SelectByText(externallinkparent);
                            }
                            break;
                        }
                    case "HTML Content":
                        {
                            //HtmlContent.Click();
                            string HCtext = label[1].GetAttribute("class");
                            if (HCtext != "sfActive")
                            {
                                label[2].Click();
                            }
                            //IWebElement inputMenu = label[2].FindElement(By.TagName("input"));
                            ClearAndFillTextBox HtmlContentTitleClearNFill = new ClearAndFillTextBox(HtmlContentTitle, MenuType.HtmlContentTitle);
                            Browser.ClearAndFillTextBox(HtmlContentTitleClearNFill);
                            ClearAndFillTextBox CaptionHtmlContentClearNFill = new ClearAndFillTextBox(CaptionHtmlContent, MenuType.CaptionHtmlContent);
                            Browser.ClearAndFillTextBox(CaptionHtmlContentClearNFill);
                            if (MenuType.HtmlContentVisible)
                            {
                                if (!HtmlContentVisible.Selected)
                                {
                                    HtmlContentVisible.Click();
                                }
                            }
                            IList<IWebElement> SourceLink = Source.FindElements(By.TagName("span"));
                            IList<IWebElement> span = SourceLink[1].FindElements(By.TagName("span"));
                            IWebElement LinkSource = span[0].FindElement(By.TagName("a"));
                            string Check = LinkSource.GetAttribute("class");
                            if (Check == "cke_off cke_button_source")
                            {
                                LinkSource.Click();
                            }
                            //IWebElement iframe = HtmlContentIframe.FindElement(By.TagName("iframe"));
                            //Browser.SwitchFrames(iframe);
                            //IWebElement body = Browser.Driver.FindElement(By.TagName("body"));
                            //body.Click();
                            //body.SendKeys("test");
                            IWebElement textarea = SourceTextArea.FindElement(By.TagName("textarea"));
                            textarea.SendKeys("<h1>test</h1>");
                            Browser.SwitchToMainWindow();
                            SelectElement SelectParentHtmlContent = new SelectElement(selectMenu);
                            if (MenuType.ParentHtmlContent)
                            {
                                SelectParentHtmlContent.SelectByText(MenuType.HtmlContentParent);
                            }
                            break;
                        }
                }
                switch (MenuType.ConfirmAddToMenu)
                {
                    case true:
                        {
                            AddMenuItem.Click();
                            IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                            IsAt isat = new IsAt(MenuAdded, Message.Text);
                            Assert.IsTrue(Browser.IsAt(isat));
                            break;
                        }
                    default:
                        {
                            AddMenuCancel.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }        
        public void MenuManage(MenuManage MenuManage)
        {
            try
            {
                int[] page = { 1, 53, 62 };
                bool[] ppage = { false, false, false };
                string[] pageparent = { "", "", "" };
                IWebElement Rightdiv = divId.FindElement(By.ClassName("sfRightdiv"));
                IWebElement RightdivContainer = Rightdiv.FindElement(By.ClassName("sfRightDivContainer"));
                IWebElement RadioTab = RightdivContainer.FindElements(By.TagName("div"))[0];
                IList<IWebElement> Label = RadioTab.FindElements(By.TagName("label"));
                string LabelClass = Label[0].GetAttribute("class");
                if (LabelClass != "sfActive")
                {
                    Label[0].Click();
                    //IWebElement MenuView = Label[0].FindElement(By.TagName("input"));
                    //MenuView.Click();
                }
                IList<IWebElement> MenuList = ulTree.FindElements(By.TagName("li"));
                IList<IWebElement> pagespan = MenuList[MenuManage.PageNo].FindElements(By.TagName("span"));
                pagespan[1].Click();
                WaitForElement UserNameWait = new WaitForElement(By.ClassName("sfActive"), 5);
                IWebElement UserNameLink = Browser.WaitForElement(UserNameWait);
                string text = UserNameLink.Text;
                switch (text)
                {
                    case "Pages":
                        {
                            ClearAndFillTextBox SubTextClearNFill = new ClearAndFillTextBox(SubText, MenuManage.SubText);
                            Browser.ClearAndFillTextBox(SubTextClearNFill);
                            if (MenuManage.IsActive)
                            {
                                if (!ActivePage.Selected)
                                {
                                    ActivePage.Click();
                                }
                            }
                            if (MenuManage.IsVisible)
                            {
                                if (!VisiblePage.Selected)
                                {
                                    VisiblePage.Click();
                                }
                            }
                            break;
                        }
                    case "HTML Content":
                        {
                            MenuType MenuTypeI = new MenuType("HTML Content", false, false, page, ppage, pageparent, true, "test", "test", "test", @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg", true, true, "Home", true, "test", "test", true, false, "Home");
                            MenuType(MenuTypeI);
                            break;
                        }
                    case "External Link":
                        {
                            MenuType MenuTypeII = new MenuType("External Link", false, false, page, ppage, pageparent, true, "test", "test", "test", @"C:\Users\Admin-PC\Downloads\Items\jasmine.jpg", true, true, "Home", true, "test", "test", true, false, "Home");
                            MenuType(MenuTypeII);
                            break;
                        }
                }
                SelectElement EditParentPage = new SelectElement(selectMenu);
                if (MenuManage.ParentPage)
                {
                    EditParentPage.SelectByText(MenuManage.Parent);
                }
                switch (MenuManage.ConfirmUpdate)
                {
                    case true:
                        {
                            AddMenuItem.Click();
                            break;
                        }
                    default:
                        {
                            AddMenuCancel.Click();
                            break;
                        }
                }
                if (MenuManage.ChangeSettings)
                {
                    string LabelClass1 = Label[1].GetAttribute("class");
                    if (LabelClass1 != "sfActive")
                    {
                        Label[1].Click();
                        //IWebElement menusetting = Label[1].FindElement(By.TagName("input"));
                        //menusetting.Click();
                    }
                    IList<IWebElement> div = MenuSetting.FindElements(By.TagName("div"));
                    IList<IWebElement> label = div[0].FindElements(By.TagName("label"));
                    label[MenuManage.MenuNo].Click();
                    //IWebElement MenuType = label.FindElement(By.TagName("input"));
                    //MenuType.Click();
                    if (MenuManage.MenuNo == 0)
                    {
                        IList<IWebElement> label1 = div[1].FindElements(By.TagName("label"));
                        //IWebElement menu = label1[menustyle].FindElement(By.TagName("input"));
                        string menutext = label1[MenuManage.MenuStyle].GetAttribute("class");
                        if (menutext != "sfActive")
                        {
                            label1[MenuManage.MenuStyle].Click();
                        }
                    }
                    if (MenuManage.ShowImage)
                    {
                        if (!ShowImage.Selected)
                        {
                            ShowImage.Click();
                        }
                    }
                    if (MenuManage.ShowText)
                    {
                        if (!ShowText.Selected)
                        {
                            ShowText.Click();
                        }
                    }
                    if (MenuManage.ShowCaption)
                    {
                        if (!ShowCaption.Selected)
                        {
                            ShowCaption.Click();
                        }
                    }
                }
                SaveButton.Click();         
            }
            catch (Exception ex)
            {
              //  throw ex;
            }           
        }
    }
}
