using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
namespace QASageframe
{
    public class CDNChanges
    {
        public bool AddJs { get; set; } 
        public string[] Js { get; set; }
        public bool AddCss { get; set; }
        public string[] Css { get; set; }
        public bool ChangeLinks { get; set; }
        public int LinkNo { get; set; }
        public bool Sort { get; set; }
        public bool Delete { get; set; }
        public bool Edit { get; set; }
        public bool JsEdit { get; set; }
        public bool CssEdit { get; set; }
        public string[] NewJs { get; set; }
        public string[] NewCss { get; set; }
        public bool Up { get; set; }
        public bool ConfirmDelete { get; set; }
        public CDNChanges(bool addjs, string[] js, bool addcss, string[] css, bool changelinks, int linkno, bool sort, bool delete, bool edit, bool jsedit, bool cssedit, string[] newjs, string[] newcss, bool up, bool confirmdelete)
        {
            AddJs = addjs;
            Js = js;
            AddCss = addcss;
            Css = css;
            ChangeLinks = changelinks;
            LinkNo = linkno;
            Sort = sort;
            Delete = delete;
            Edit = edit;
            JsEdit = jsedit;
            CssEdit = cssedit;
            NewJs = newjs;
            NewCss = newcss;
            Up = up;
            ConfirmDelete = confirmdelete;
        }
    }
    public static class CDN
    {
        public static CDNPage CDNPage
        {
            get
            {
                var cdnpage = new CDNPage();
                PageFactory.InitElements(Browser.Driver, cdnpage);
                return cdnpage;
            }
        }
    }
    public class CDNPage
    {
        public string Url = "Admin/CDN.aspx";
        public string Text = "CDN";
        #region
        [FindsBy(How = How.Id, Using = "spnAddJS")][CacheLookup]
        public IWebElement AddJsBtn { get; set;}
        [FindsBy(How = How.Id, Using = "spnAddCSS")][CacheLookup]
        public IWebElement AddCssBtn { get; set;}
        [FindsBy(How = How.Id, Using = "spnEdit")][CacheLookup]
        public IWebElement EditBtn { get; set;}
        [FindsBy(How = How.Id, Using = "spnSave")][CacheLookup]
        public IWebElement SaveBtn { get; set;}
        [FindsBy(How = How.Id, Using = "ulUrlList")][CacheLookup]
        public IWebElement ListId { get; set;}
        #endregion
        public void CDNChanges(CDNChanges CDNChanges)
        {
            try
            {
                if (CDNChanges.AddJs == true)
                {
                    int i = 0;
                    foreach (string JS in CDNChanges.Js)
                    {
                        AddJsBtn.Click();
                        IWebElement AddJsTextBox = Browser.Driver.FindElement(By.Id("jsURL_" + (i + 1).ToString()));
                        ClearAndFillTextBox AddJsClearNFill = new ClearAndFillTextBox(AddJsTextBox, JS);
                        Browser.ClearAndFillTextBox(AddJsClearNFill);
                        i++;
                    }
                }
                if (CDNChanges.AddCss == true)
                {
                    int j = 0;
                    foreach (string css in CDNChanges.Css)
                    {
                        AddCssBtn.Click();
                        IWebElement AddCssTextBox = Browser.Driver.FindElement(By.Id("cssURL_" + (j + 1).ToString()));
                        ClearAndFillTextBox AddCssClearNFill = new ClearAndFillTextBox(AddCssTextBox, css);
                        Browser.ClearAndFillTextBox(AddCssClearNFill);
                        j++;
                    }
                }
                SaveBtn.Click();
                if (CDNChanges.ChangeLinks == true)
                {
                    IList<IWebElement> Links = ListId.FindElements(By.TagName("li"));
                    IWebElement Linkdiv = Links[CDNChanges.LinkNo].FindElement(By.TagName("div"));
                    IWebElement Blockdiv = Linkdiv.FindElement(By.TagName("div"));
                    IList<IWebElement> span = Blockdiv.FindElements(By.TagName("span"));
                    if (CDNChanges.Sort == true)
                    {
                        IList<IWebElement> sortlink = span[1].FindElements(By.TagName("i"));
                        switch (CDNChanges.LinkNo)
                        {
                            case 0:
                                {
                                    sortlink[0].Click();
                                    break;
                                }
                            default:
                                {
                                    switch (CDNChanges.Up)
                                    {
                                        case true:
                                            {
                                                sortlink[0].Click();
                                                break;
                                            }
                                        default:
                                            {
                                                sortlink[1].Click();
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                    }
                    if (CDNChanges.Delete == true)
                    {
                        IWebElement DeleteLink = Browser.Driver.FindElement(By.XPath(".//*[@id='ulUrlList']/li[" + CDNChanges.LinkNo.ToString() + "]/div/div/span[3]"));
                        DeleteLink.Click();
                        IWebElement DeleteConfirm = Browser.Driver.FindElement(By.ClassName("ui-dialog-buttonset"));
                        IList<IWebElement> Confirmation = DeleteConfirm.FindElements(By.TagName("button"));
                        switch (CDNChanges.ConfirmDelete)
                        {
                            case true:
                                {
                                    Confirmation[0].Click();
                                    break;
                                }
                            default:
                                {
                                    Confirmation[1].Click();
                                    break;
                                }
                        }
                        //span[2].Click();
                    }
                }
                if (CDNChanges.Edit == true)
                {
                    EditBtn.Click();
                    if (CDNChanges.JsEdit == true)
                    {
                        int k = 0;
                        foreach (string newjs in CDNChanges.NewJs)
                        {
                            IWebElement JsTextBox = Browser.Driver.FindElement(By.Id("jsURL_" + (k + 2).ToString()));
                            bool DisplayJSTBox = JsTextBox.Displayed;
                            switch (DisplayJSTBox)
                            {
                                case false:
                                    {
                                        AddJsBtn.Click();
                                        k--;
                                        break;
                                    }
                                default:
                                    {
                                        ClearAndFillTextBox JsClearNFill = new ClearAndFillTextBox(JsTextBox, newjs);
                                        Browser.ClearAndFillTextBox(JsClearNFill);
                                        break;
                                    }
                            }
                            k++;
                        }
                    }
                    if (CDNChanges.CssEdit == true)
                    {
                        int l = 0;
                        foreach (string newcss in CDNChanges.NewCss)
                        {
                            IList<IWebElement> CssTextBox = Browser.Driver.FindElements(By.Id("cssURL_" + (CDNChanges.NewJs.Length + CDNChanges.Js.Length + l).ToString()));
                            switch (CssTextBox.Count)
                            {
                                case 0:
                                    {
                                        AddCssBtn.Click();
                                        IWebElement CssTxtBox = Browser.Driver.FindElement(By.Id( ));
                                        ClearAndFillTextBox CssClearNFill = new ClearAndFillTextBox(CssTxtBox, newcss);
                                        Browser.ClearAndFillTextBox(CssClearNFill);
                                        break;
                                    }
                                default:
                                    {
                                        CssTextBox[0].Clear();
                                        CssTextBox[0].SendKeys(newcss);
                                        break;
                                    }
                            }
                            l++;
                        }
                    }
                    SaveBtn.Click();
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
    }
}
