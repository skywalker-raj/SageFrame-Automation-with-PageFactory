using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class ModuleMaker
    {
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleTableName { get; set; }
        public bool IncludeCss { get; set; }
        public bool IncludeJs { get; set; }
        public bool IncludeWebservice { get; set; }
        public bool EditInclude { get; set; }
        public bool SettingInclude { get; set; }
        public string ModuleType { get; set; }
        public int TotalColumn { get; set; }
        public bool AutoIncrement { get; set; }
        public string[] ColumnName { get; set; }
        public string[] DataType { get; set; }
        public bool[] AllowNull { get; set; }
        public int N { get; set; }
        public bool DownloadClassZip { get; set; }
        public bool Back { get; set; }
        public ModuleMaker(string modulename, string moduledescription, string moduletablename, bool includecss, bool includejs, bool includewebservice, bool editinclude, bool settinginclude, string moduletype, int totalcolumn, bool autoincrement, string[] columnname, string[] datatype, bool[] allownull, int n, bool downloadclasszip, bool back)
        {
            ModuleName = modulename;
            ModuleDescription = moduledescription;
            ModuleTableName = moduletablename;
            IncludeCss = includecss;
            IncludeJs = includejs;
            IncludeWebservice = includewebservice;
            EditInclude = editinclude;
            SettingInclude = settinginclude;
            ModuleType = moduletype;
            TotalColumn = totalcolumn;
            AutoIncrement = autoincrement;
            ColumnName = columnname;
            DataType = datatype;
            AllowNull = allownull;
            N = n;
            DownloadClassZip = downloadclasszip;
            Back = back;
        }
    }
    #endregion
    public static class Module_Maker
    {
        public static Module_MakerPage Module_MakerPage
        {
            get
            {
                var module_makerPage = new Module_MakerPage();
                PageFactory.InitElements(Browser.Driver, module_makerPage);
                return module_makerPage;
            }
        }
    }
    public class Module_MakerPage
    {
        public string Url = "Admin/Module-Maker.aspx";
        public string Text = "ModuleMaker";
        #region
        [FindsBy(How = How.Id, Using = "ctl19_txtModuleName")][CacheLookup]
        public IWebElement ModuleNameLink { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_txtModuleDescription")][CacheLookup]
        public IWebElement ModuleDescriptionLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtTablename")][CacheLookup]
        public IWebElement ModuleTableNameLink { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkCss")][CacheLookup]
        public IWebElement CssInclude { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkJS")][CacheLookup]
        public IWebElement JsInclude { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkWebService")][CacheLookup]
        public IWebElement WebServiceInclude { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkEdit")][CacheLookup]
        public IWebElement IncludeEdit { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkSetting")][CacheLookup]
        public IWebElement IncludeSetting { get; set; }
        [FindsBy(How = How.Id, Using = "rdbPortal")][CacheLookup]
        //public IWebElement PortalPage { get; set; }
        //[FindsBy(How = How.Id, Using = "rdbSetting")][CacheLookup]
        public IWebElement AdminPage { get; set; }
        [FindsBy(How = How.Id, Using = "AddRow")][CacheLookup]
        public IWebElement AddRowLink { get; set; }
        [FindsBy(How = How.Id, Using = "autoincrement")][CacheLookup]
        public IWebElement AutoIncrementLink { get; set; }
        //[FindsBy(How = How.Id, Using = "btnCreateSQL")]
        //public IWebElement CreateSQLLink { get; set; }
        //[FindsBy(How = How.Id, Using = "btnCreateNewModuleHelp")]
        //public IWebElement CreateNewModule { get; set; }
        [FindsBy(How = How.Id, Using = "btnCreateZipHelp")]
        public IWebElement CreateZip { get; set; }
        [FindsBy(How = How.Id, Using = "btnBack")]
        public IWebElement BackToModuleMaker { get; set; }
        [FindsBy(How = How.Id, Using = "divProperties")]
        public IWebElement ID { get; set; }
        [FindsBy(How = How.Id, Using = "divModuleCreator")]
        public IWebElement ModuleCreatorDiv { get; set; }
        #endregion       
        public void ModuleMaker(ModuleMaker ModuleMaker)
        {
            try
            {
            Start: ClearAndFillTextBox ModuleNameClearNFill = new ClearAndFillTextBox(ModuleNameLink, ModuleMaker.ModuleName);
                Browser.ClearAndFillTextBox(ModuleNameClearNFill);
                ClearAndFillTextBox ModuleDescriptionClearNFill = new ClearAndFillTextBox(ModuleDescriptionLink, ModuleMaker.ModuleDescription);
                Browser.ClearAndFillTextBox(ModuleDescriptionClearNFill);
                ClearAndFillTextBox ModuleTableClearNFill = new ClearAndFillTextBox(ModuleTableNameLink, ModuleMaker.ModuleTableName);
                Browser.ClearAndFillTextBox(ModuleTableClearNFill);
                if (ModuleMaker.IncludeCss)
                {
                    if (!CssInclude.Selected)
                    {
                        CssInclude.Click();
                    }
                }
                if (ModuleMaker.IncludeJs)
                {
                    if (!JsInclude.Selected)
                    {
                        JsInclude.Click();
                    }
                    if (ModuleMaker.IncludeWebservice)
                    {
                        if (!WebServiceInclude.Selected)
                        {
                            WebServiceInclude.Click();
                        }
                    }
                }
                if (ModuleMaker.EditInclude)
                {
                    if (!IncludeEdit.Selected)
                    {
                        IncludeEdit.Click();
                    }
                }
                if (ModuleMaker.SettingInclude)
                {
                    if (!IncludeSetting.Selected)
                    {
                        IncludeSetting.Click();
                    }
                }
                IWebElement FormWrapperDiv = ModuleCreatorDiv.FindElement(By.TagName("div"));
                if (ModuleMaker.ModuleType == "Admin")
                {
                    //IWebElement FormWrapperDiv = ModuleCreatorDiv.FindElement(By.TagName("div"));
                    IWebElement Table = FormWrapperDiv.FindElement(By.TagName("table"));
                    IWebElement Tbody = Table.FindElement(By.TagName("tbody"));
                    IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                    IWebElement Td = Tr[4].FindElements(By.TagName("td"))[1];
                    IWebElement RadioDiv = Td.FindElement(By.TagName("div"));
                    IList<IWebElement> Label = RadioDiv.FindElements(By.TagName("label"));
                    Label[1].Click();
                    //AdminPage.Click();
                }
                int i = 0;
                int j = 0;
                for (i = 0; i < ModuleMaker.TotalColumn; i++)
                {
                    IWebElement Body = ID.FindElement(By.TagName("tbody"));
                    IList<IWebElement> Row = Body.FindElements(By.TagName("tr"));
                    IList<IWebElement> Column = Row[i].FindElements(By.TagName("td"));
                    IWebElement columnname = Column[1].FindElement(By.TagName("input"));
                    ClearAndFillTextBox ColumnNameClearNFill = new ClearAndFillTextBox(columnname, ModuleMaker.ColumnName[i]);
                    Browser.ClearAndFillTextBox(ColumnNameClearNFill);
                    IWebElement datatype = Column[2].FindElement(By.TagName("input"));
                    ClearAndFillTextBox DataTypeClearNFill = new ClearAndFillTextBox(datatype, ModuleMaker.DataType[j]);
                    //IWebElement span = Column[2].FindElements(By.TagName("span"))[1];
                    //span.Click();
                    //IWebElement div = Column[2].FindElement(By.TagName("div"));
                    //IWebElement ul = div.FindElement(By.TagName("ul"));
                    //IWebElement li = ul.FindElements(By.TagName("li"));
                    //IWebElement datatype = li[n].FindElement(By.TagName("a"));
                    //datatype.Click();
                    switch (i)
                    {
                        case 0:
                            {
                                if (ModuleMaker.AutoIncrement)
                                {
                                    AutoIncrementLink.Click();
                                }
                                break;
                            }
                        // i > 0
                        default:
                            {
                                IWebElement allownull = Column[3].FindElement(By.TagName("input"));
                                if (ModuleMaker.AllowNull[i - 1])
                                {
                                    allownull.Click();
                                }
                                break;
                            }
                    }
                    j++;
                    if (Row.Count < ModuleMaker.TotalColumn)
                    {
                        AddRowLink.Click();
                    }
                }
                Browser.ScrollDown(true);
                Browser.Wait();
                IWebElement CreateSQLLink = FormWrapperDiv.FindElement(By.ClassName("icon-navigate"));
                CreateSQLLink.Click();
                if (ModuleMaker.Back)
                {
                    BackToModuleMaker.Click();
                    ModuleMaker.Back = false;
                    //ModuleMaker ModuleMakerI = new ModuleMaker(ModuleName, ModuleDescription, ModuleTableName, IncludeCss, IncludeJs, IncludeWebservice, EditInclude, SettingInclude, ModuleType, TotalColumn, autoincrement, ColumnName, DataType, AllowNull, N, DownloadClassZip, Back);
                    //ModuleMaker(ModuleMakerI);
                    goto Start;
                }
                if (ModuleMaker.DownloadClassZip)
                {
                    CreateZip.Click();
                }
                IWebElement CreateNewModule = Browser.Driver.FindElement(By.Id("btnCreateNewModuleHelp"));
                CreateNewModule.Click();
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
    }
}
