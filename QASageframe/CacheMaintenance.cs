using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class BoxCheck
    {
        public int n;
        public IWebElement CacheTable;
        public BoxCheck(int N, IWebElement cachetable)
        {
            n = N;
            CacheTable = cachetable;
        }
    }
    public class CacheSettings
    {
        public int[] Clear;
        public bool ClearAll;
        public bool SaveAll;
        public int[] Save;
        public CacheSettings(int[] clear, bool clearall, bool saveall, int[] save)
        {
            Clear = clear;
            ClearAll = clearall;
            SaveAll = saveall;
            Save = save;
        }
    }
    #endregion
    public static class CacheMaintenance
    {
        public static CacheMaintenancePage CacheMaintenancePage
        {
            get
            {
                var cachemaintenancepage = new CacheMaintenancePage();
                PageFactory.InitElements(Browser.Driver, cachemaintenancepage);
                return cachemaintenancepage;
            }
        }
    }
    public class CacheMaintenancePage
    {
        public string Url = "Admin/Cache-Maintenance.aspx";
        public string Text = "Cache Maintenance";
        #region
        [FindsBy(How = How.Id, Using = "chkCheckAllHeavyCache")][CacheLookup]
        public IWebElement HeavyCacheSelectAllCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "chkCheckAll")][CacheLookup]
        public IWebElement CacheSelectAllCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnSave")][CacheLookup]
        public IWebElement ClearCache { get; set; }
        [FindsBy(How = How.Id, Using = "btnEnableCache")][CacheLookup]
        public IWebElement SaveCache { get; set; }
        [FindsBy(How = How.Id, Using = "tblCache")][CacheLookup]
        public IWebElement ClearCacheTable { get; set; }
        [FindsBy(How = How.Id, Using = "tblHeavyCache")][CacheLookup]
        public IWebElement SaveCacheTable { get; set; }
        #endregion
        public IWebElement Check(BoxCheck ChkBox)
        {
            try
            {
                IWebElement CacheTbody = ChkBox.CacheTable.FindElement(By.TagName("tbody"));
                IWebElement Cachetr = CacheTbody.FindElements(By.TagName("tr"))[ChkBox.n];
                IWebElement Cachetd = Cachetr.FindElements(By.TagName("td"))[1];
                IWebElement CheckBox = Cachetd.FindElement(By.TagName("input"));
                return CheckBox;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public void CacheSettings(CacheSettings Cache)
        {
            try
            {
                int i, j;
                switch (Cache.ClearAll)
                {
                    case true:
                        {
                            if (!CacheSelectAllCheckBox.Selected)
                            {
                                CacheSelectAllCheckBox.Click();
                            }
                            break;
                        }
                    default:
                        {
                            if (CacheSelectAllCheckBox.Selected)
                            {
                                CacheSelectAllCheckBox.Click();
                            }
                            for (i = 0; i < Cache.Clear.Length - 1; i++)
                            {
                                //IWebElement ClearCacheTbody = ClearCacheTable.FindElement(By.TagName("tbody"));
                                //IWebElement ClearCachetr = ClearCacheTbody.FindElements(By.TagName("tr"))[Clear[i]];
                                //IWebElement ClearCachetd = ClearCachetr.FindElements(By.TagName("td"))[1];
                                BoxCheck Chk = new BoxCheck(Cache.Clear[i] + 1, ClearCacheTable);
                                IWebElement ClearCacheCheckBox = Check(Chk);
                                ClearCacheCheckBox.Click();
                            }
                            break;
                        }
                }
                ClearCache.Click();
                switch (Cache.SaveAll)
                {
                    case true:
                        {
                            if (!HeavyCacheSelectAllCheckBox.Selected)
                            {
                                HeavyCacheSelectAllCheckBox.Click();
                            }
                            break;
                        }
                    default:
                        {
                            if (!HeavyCacheSelectAllCheckBox.Selected)
                            {
                                HeavyCacheSelectAllCheckBox.Click();
                            }
                            for (j = 0; j < Cache.Save.Length; j++)
                            {
                                //IWebElement SaveCacheTbody = SaveCacheTable.FindElement(By.TagName("tbody"));
                                //IWebElement SaveCachetr = SaveCacheTbody.FindElements(By.TagName("tr"))[Save[j]];
                                //IWebElement SaveCachetd = SaveCachetr.FindElements(By.TagName("td"))[1];
                                BoxCheck ChkSave = new BoxCheck(Cache.Save[j] + 1, SaveCacheTable);
                                IWebElement SaveCacheCheckBox = Check(ChkSave);
                                SaveCacheCheckBox.Click();
                            }
                            break;
                        }
                }
                SaveCache.Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
    }
}
