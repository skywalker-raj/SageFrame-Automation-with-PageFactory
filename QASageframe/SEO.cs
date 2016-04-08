using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class AddGoogleJs
    {
        public string GoogleJS { get; set; }
        public bool IsActive { get; set; }
        public bool Update { get; set; }
        public bool Refresh { get; set; }
        public AddGoogleJs(string googlejs, bool isactive, bool update, bool refresh)
        {
            GoogleJS = googlejs;
            IsActive = isactive;
            Update = update;
            Refresh = refresh;
        }
    }
    public class GenerateSiteMap
    {
        public double Priority { get; set; }
        public string Frequency { get; set; }
        public bool Google { get; set; }
        public bool Yahoo { get; set; }
        public bool Bing { get; set; } 
        public bool Ask { get; set; }
        public GenerateSiteMap(double priority, string frequency, bool google, bool yahoo, bool bing, bool ask)
        {
            Priority = priority;
            Frequency = frequency;
            Google = google;
            Yahoo = yahoo;
            Bing = bing;
            Ask = ask;
        }
    }
    public class GenerateRobots
    {
        public bool Google { get; set; }
        public bool Yahoo { get; set; }
        public bool Bing { get; set; }
        public bool Msn { get; set; }
        public int[] Pages { get; set; }
        public GenerateRobots(bool google, bool yahoo, bool bing, bool msn, int[] pages)
        {
            Google = google;
            Yahoo = yahoo;
            Bing = bing;
            Msn = msn;
            Pages = pages;
        }
    }
    #endregion
    public static class SEO
    {
        public static SEOpage SEOpage
        {
            get
            {
                var seopage = new SEOpage();
                PageFactory.InitElements(Browser.Driver, seopage);
                return seopage;
            }
        }
    }
    public class SEOpage
    {
        public string Url = "Admin/SEO.aspx";
        public string Text = "SEO";
        #region
        //SEOTabs
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer1_tpGoogleAnalytics")][CacheLookup]
        public IWebElement GoogleAnalyticsTab {get; set;}
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer1_tpSitemap")][CacheLookup]
        public IWebElement SiteMapTab {get; set;}
        [FindsBy(How = How.Id, Using = "__tab_ctl19_TabContainer1_tpRobots")][CacheLookup]
        public IWebElement RobotsTab {get; set;}
        //GoogleAnalytics
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpGoogleAnalytics_txtvalue")][CacheLookup]
        public IWebElement SEOtextbox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpGoogleAnalytics_chkIsActive")][CacheLookup]
        public IWebElement IsActiveCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpGoogleAnalytics")][CacheLookup]
        public IWebElement GoogleAnalyticsDiv { get; set; }
        //Sitemap
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_ddlPriorityValues")][CacheLookup]
        public IWebElement PriorityDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_ddlChangeFrequency")][CacheLookup]
        public IWebElement ChangeFrequencyDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "divSitemap")][CacheLookup]
        public IWebElement SitemapDiv { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_0")][CacheLookup]
        public IWebElement GoogleCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_1")][CacheLookup]
        public IWebElement YahooCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_2")][CacheLookup]
        public IWebElement BingCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpSitemap_chkSubmitSitemap_3")][CacheLookup]
        public IWebElement AskCheckBox { get; set; }
        //Robots
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpRobots_chkChoice_0")][CacheLookup]
        public IWebElement GoogleRobotCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpRobots_chkChoice_1")][CacheLookup]
        public IWebElement YahooRobotCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpRobots_chkChoice_2")][CacheLookup]
        public IWebElement BingRobotCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpRobots_chkChoice_3")][CacheLookup]
        public IWebElement MsnRobotCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "divRobots")][CacheLookup]
        public IWebElement DivRobots { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_TabContainer1_tpRobots_gdvRobots")][CacheLookup]
        public IWebElement PagesTable { get; set; }
        #endregion
        public void AddGoogleJs(AddGoogleJs AddGoogleJs)
        {
            try
            {
                GoogleAnalyticsTab.Click();
                ClearAndFillTextBox SEOClearNFill = new ClearAndFillTextBox(SEOtextbox, AddGoogleJs.GoogleJS);
                Browser.ClearAndFillTextBox(SEOClearNFill);
                ChkBox ActiveChkBox = new ChkBox(AddGoogleJs.IsActive, IsActiveCheckBox);
                Browser.CheckBox(ActiveChkBox);
                IWebElement ButtonWrapper = GoogleAnalyticsDiv.FindElements(By.TagName("div"))[1];
                IList<IWebElement> label = ButtonWrapper.FindElements(By.TagName("label"));
                if (AddGoogleJs.Update)
                {
                    //update.Click();
                    label[0].Click();
                }
                if (AddGoogleJs.Refresh)
                {
                    //refresh.Click();
                    label[1].Click();
                }  
            }
            catch (Exception ex)
            {
                //throw ex;
            }         
        }
        public void GenerateSiteMap(GenerateSiteMap GenerateSiteMap)
        {
            try
            {
                SiteMapTab.Click();
                DropDownSelect DropDownPriority = new DropDownSelect(GenerateSiteMap.Priority.ToString(), PriorityDropdown);
                Browser.SelectDropdown(DropDownPriority);
                DropDownSelect FrequencyDropDown = new DropDownSelect(GenerateSiteMap.Frequency, ChangeFrequencyDropdown);
                Browser.SelectDropdown(FrequencyDropDown);
                ChkBox GoogleChkBox = new ChkBox(GenerateSiteMap.Google, GoogleCheckBox);
                Browser.CheckBox(GoogleChkBox);
                ChkBox YahooChkBox = new ChkBox(GenerateSiteMap.Yahoo, YahooCheckBox);
                Browser.CheckBox(YahooChkBox);
                ChkBox BingChkBox = new ChkBox(GenerateSiteMap.Bing, BingCheckBox);
                Browser.CheckBox(BingChkBox);
                ChkBox AskChkBox = new ChkBox(GenerateSiteMap.Ask, AskCheckBox);
                Browser.CheckBox(AskChkBox);
                IWebElement table = SitemapDiv.FindElement(By.TagName("table"));
                IWebElement tbody = table.FindElement(By.TagName("tbody"));
                IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                IWebElement tdGS = tr[2].FindElements(By.TagName("td"))[1];
                IWebElement SitemapGenerate = tdGS.FindElement(By.TagName("label"));
                IList<IWebElement> tdSubmit = tr[4].FindElements(By.TagName("td"));
                IWebElement Submit = tdSubmit[1].FindElement(By.TagName("label"));
                Submit.Click();
                SitemapGenerate.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public void GenerateRobots(GenerateRobots GenerateRobots)
        {
            try
            {
                RobotsTab.Click();
                ChkBox GoogleRobotChkBox = new ChkBox(GenerateRobots.Google, GoogleRobotCheckBox);
                ChkBox YahooRobotChkBox = new ChkBox(GenerateRobots.Yahoo, YahooRobotCheckBox);
                ChkBox BingRobotChkBox = new ChkBox(GenerateRobots.Bing, BingRobotCheckBox);
                ChkBox MsnRobotChkBox = new ChkBox(GenerateRobots.Msn, MsnRobotCheckBox);
                Browser.CheckBox(GoogleRobotChkBox);
                Browser.CheckBox(YahooRobotChkBox);
                Browser.CheckBox(BingRobotChkBox);
                Browser.CheckBox(MsnRobotChkBox);
                IWebElement tablebody = PagesTable.FindElement(By.TagName("tbody"));
                IList<IWebElement> tr = tablebody.FindElements(By.TagName("tr"));
                int i;
                for (i = 0; i < GenerateRobots.Pages.Length; i++)
                {
                    IWebElement td = tr[GenerateRobots.Pages[i]].FindElement(By.TagName("td"));
                    IWebElement input = td.FindElement(By.TagName("input"));
                    if (!input.Selected)
                    {
                        input.Click();
                    }
                }
                IWebElement table = DivRobots.FindElement(By.TagName("table"));
                IWebElement tbody = table.FindElement(By.TagName("tbody"));
                IWebElement trRobots = tbody.FindElements(By.TagName("tr"))[0];
                IList<IWebElement> tdRobots = trRobots.FindElements(By.TagName("td"));
                IWebElement GenerateRobotsLink = tdRobots[5].FindElement(By.TagName("label"));
                GenerateRobotsLink.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
    }
}
