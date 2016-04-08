using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class PaginationSelect
    {
        public IWebElement ListWiseVisit { get; set; }
        public int Pageno { get; set; }
        public PaginationSelect(IWebElement listwisevisit, int pageno)
        {
            ListWiseVisit = listwisevisit;
            Pageno = pageno;
        }
    }
    public class DateWiseSiteAnalytics
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public DateWiseSiteAnalytics(string startdate, string enddate)
        {
            StartDate = startdate;
            EndDate = enddate;
        }
    }
    public class SiteAnalytic
    {
        public bool Chart { get; set;}
        public bool Data { get; set;}
        public bool Date { get; set;}
        public DateWiseSiteAnalytics DateWiseSiteAnalytics { get; set;}
        public bool PageWiseVisit { get; set;}
        public string Page { get; set;}
        public bool ExportToPdf { get; set;}
        public bool ExportToExcel { get; set;}
        public bool Pagination { get; set; }
        public string TypeWise { get; set; }
        public SiteAnalytic(bool chart, bool data, bool date, DateWiseSiteAnalytics datewisesiteanalytics, bool pagewisevisit, string page, bool exporttopdf, bool exporttoexcel, bool pagination, string typewise)
        {
            Chart = chart;
            Data = data;
            Date = date;
            DateWiseSiteAnalytics = datewisesiteanalytics;
            PageWiseVisit = pagewisevisit;
            Page = page;
            ExportToPdf = exporttopdf;
            ExportToExcel = exporttoexcel;
            Pagination = pagination;
            TypeWise = typewise;
        }
    }
    #endregion
    public static class SiteAnalytics
    {
        public static SiteAnalyticsPage SiteAnalyticsPage
        {
            get
            {
                var siteanalyticspage = new SiteAnalyticsPage();
                PageFactory.InitElements(Browser.Driver, siteanalyticspage);
                return siteanalyticspage;
            }
        }
    }
    public class SiteAnalyticsPage
    {
        public string Url = "Admin/Site-Analytics.aspx";
        public string Text = "Site Analytics";
        #region
        [FindsBy(How = How.Id, Using = "txtStartDate")]
        public IWebElement StartDateTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "txtEndDate")]
        public IWebElement EndDateTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "divRange")]
        public IWebElement RangeDiv { get; set;}
        [FindsBy(How = How.Id, Using = "Chart")]
        public IWebElement ChartTab { get; set;}
        [FindsBy(How = How.Id, Using = "Data")]
        public IWebElement DataTab { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_btnExportToExcel")]
        public IWebElement ExportToExcelBtn { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_btnExportToPDF")]
        public IWebElement ExportToPdfBtn { get; set;}
        [FindsBy(How = How.Id, Using = "slPage")]
        public IWebElement PageDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "PagingVisitedCountryList")]
        public IWebElement CountryList { get; set;}
        [FindsBy(How = How.Id, Using = "PagingVisitedPageList")]
        public IWebElement PageList { get; set;}
        [FindsBy(How = How.Id, Using = "PagingRefList")]
        public IWebElement RefList { get; set;}
        [FindsBy(How = How.Id, Using = "PagingBrowserList")]
        public IWebElement BrowserList { get; set;}
        #endregion       
        public void PaginationSelect(PaginationSelect PaginationSelect)
        {
            try
            {
                IList<IWebElement> List = PaginationSelect.ListWiseVisit.FindElements(By.TagName("span"));
                List[PaginationSelect.Pageno].Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
        public void DateWiseSiteAnalytics(DateWiseSiteAnalytics DateWiseSiteAnalytics)
        {
            try
            {
                StartDateTextBox.Click();
                ClearAndFillTextBox StartDateClearNFill = new ClearAndFillTextBox(StartDateTextBox, DateWiseSiteAnalytics.StartDate);
                Browser.ClearAndFillTextBox(StartDateClearNFill);
                EndDateTextBox.Click();
                ClearAndFillTextBox EndDateClearNFill = new ClearAndFillTextBox(EndDateTextBox, DateWiseSiteAnalytics.EndDate);
                Browser.ClearAndFillTextBox(EndDateClearNFill);
                IWebElement View = RangeDiv.FindElements(By.TagName("label"))[2];
                View.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public void SiteAnalytics(SiteAnalytic SiteAnalytic)
        {
            try
            {
                if (SiteAnalytic.Chart)
                {
                    if (ChartTab.GetAttribute("class") != "icon-chart sfDefault")
                    {
                        ChartTab.Click();
                    }
                    if (SiteAnalytic.Date)
                    {
                        DateWiseSiteAnalytics(SiteAnalytic.DateWiseSiteAnalytics);
                    }
                }
                if (SiteAnalytic.Data)
                {
                    if (DataTab.GetAttribute("class") != "icon-data sfDefault")
                    {
                        DataTab.Click();
                    }
                    if (SiteAnalytic.Date)
                    {                
                        DateWiseSiteAnalytics(SiteAnalytic.DateWiseSiteAnalytics);
                    }
                    if (SiteAnalytic.PageWiseVisit)
                    {
                        DropDownSelect DropDownPage = new DropDownSelect(SiteAnalytic.Page, PageDropdown);
                        Browser.SelectDropdown(DropDownPage);
                    }
                    if (SiteAnalytic.ExportToPdf)
                    {
                        ExportToPdfBtn.Click();
                    }
                    if (SiteAnalytic.ExportToExcel)
                    {
                        ExportToExcelBtn.Click();
                    }
                    if (SiteAnalytic.Pagination)
                    {
                        switch (SiteAnalytic.TypeWise)
                        {
                            case "Country":
                                PaginationSelect PaginationSelectI = new PaginationSelect(CountryList, 0);
                                PaginationSelect(PaginationSelectI);
                                break;
                            case "Page":
                                PaginationSelect PaginationSelectII = new PaginationSelect(PageList, 0);
                                PaginationSelect(PaginationSelectII);
                                break;
                            case "Browser":
                                PaginationSelect PaginationSelectIII = new PaginationSelect(BrowserList, 0);
                                PaginationSelect(PaginationSelectIII);
                                break;
                            case "Reference":
                                PaginationSelect PaginationSelectIV = new PaginationSelect(RefList, 0);
                                PaginationSelect(PaginationSelectIV);
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
