using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using System.Linq;
using System.Windows.Forms;
namespace QASageframe
{
    #region
    public class DragNDrop
    {
        public IWebElement Source { get; set; }
        public IWebElement Target { get; set; }
        public DragNDrop(IWebElement source, IWebElement target)
        {
            Source = source;
            Target = target;
        }
    }
    public class ChkBox
    {
        public bool Check { get; set; }
        public IWebElement CheckBox { get; set; }
        public ChkBox(bool check, IWebElement checkBox)
        {
            Check = check;
            CheckBox = checkBox;
        }
    }
    public class InjectJs
    {
        public string ID { get; set; }
        public string Value { get; set; }
        public string Attribute { get; set; }
        public InjectJs(string id, string value, string attribute)
        {
            ID = id;
            Value = value;
            Attribute = attribute;
        }
    }
    public class DropDownSelect
    {
        public string Select { get; set; }
        public IWebElement AvailableList { get; set; }
        public DropDownSelect(string select, IWebElement availablelist)
        {
            Select = select;
            AvailableList = availablelist;
        }
    }
    public class SelectDate
    {
        public DropDownSelect YearDropDownSelect { get; set; }// = new DropDownSelect(Year)
        public DropDownSelect MonthDropDownSelect { get; set; }
        public string Day { get; set; }
        public SelectDate(DropDownSelect yearDropDownSelect, DropDownSelect monthDropDownSelect, string day)
        {
            YearDropDownSelect = yearDropDownSelect;
            MonthDropDownSelect = monthDropDownSelect;
            Day = day;
        }
    }
    public class ClearAndFillTextBox
    {
        public IWebElement Element { get; set; }
        public string FillText { get; set; }
        public ClearAndFillTextBox(IWebElement element, string fillText)
        {
            Element = element;
            FillText = fillText;
        }
    }
    public class IsAt
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public IsAt(string header, string title)
        {
            Header = header;
            Title = title;
        }
    }
    public class WaitForElement
    {
        public By by { get; set; }
        public int timeoutInSeconds { get; set; }
        public WaitForElement(By By, int TimeoutInSeconds)
        {
            by = By;
            timeoutInSeconds = TimeoutInSeconds;
        }
    }
    public class WaitForWebElement
    {
        public IWait<IWebDriver> wait { get; set; }
        public IWebElement webElement { get; set; }
        public WaitForWebElement(IWait<IWebDriver> Wait, IWebElement WebElement)
        {
            wait = Wait;
            webElement = WebElement;
        }
    }
    public class SaveCancel
    {
        public IWebElement Create { get; set; }
        public IWebElement CancelButton { get; set; }
        public bool Save { get; set; }
        public SaveCancel(IWebElement create, IWebElement cancelbutton, bool save)
        {
            Create = create;
            CancelButton = cancelbutton;
            Save = save;
        }
    }
    #endregion
    public static class Browser
    {
        public static IWebDriver IECapabilities()
        {
            try
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                options.Proxy = proxy;
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.UsePerProcessProxy = true;
                options.EnsureCleanSession = true;
                //var capabilitiesInternet = new OpenQA.Selenium.Remote.DesiredCapabilities();
                //capabilitiesInternet.SetCapability("ignoreProtectedModeSettings", true);
                //capabilitiesInternet.SetCapability("ie.ensureCleanSession", true);
                IWebDriver webDriver = new InternetExplorerDriver(@"C:\Program Files\Selenium\", options);
                return webDriver;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }       
        //public static IWebDriver Desired()
        //{
        //    DesiredCapabilities capability = DesiredCapabilities.Firefox();
        //    capability.SetCapability(CapabilityType.BrowserName, "firefox");
        //    capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
        //    capability.SetCapability(CapabilityType.Version, "15.0");
        //    capability.SetCapability(CapabilityType.PROXY,"8888")
        //    RemoteWebDriver webDriver = new RemoteWebDriver(new Uri("http://172.18.12.225:4444/wd/hub"), capability);
        //    return webDriver;
        //} 
        public static DesiredCapabilities Desired()
        {
            DesiredCapabilities capability = DesiredCapabilities.HtmlUnit();
            capability.IsJavaScriptEnabled = true;
            return capability;
        }
        public static IWebDriver GetWebDriver(string BrowserType) 
        {
            try
            {
                IWebDriver webDriver;
                switch (BrowserType)
                {
                    case "FireFox":
                        {
                            webDriver = new FirefoxDriver(Profile);
                            break;
                        }
                    case "Chrome":
                        {
                            ChromeOptions chromeOptions = new ChromeOptions();                            
                            chromeOptions.Proxy = proxy;
                            webDriver = new ChromeDriver();
                            break;
                        }
                    case "IE":
                        {                          
                            webDriver = IECapabilities();
                            break;
                        }
                    case "HtmlUnit":
                        {
                            webDriver = new RemoteWebDriver(Desired());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("App.config key error.");
                            Console.WriteLine("Defaulting to Firefox");
                            webDriver = new FirefoxDriver();
                            break;
                        }
                }
                return webDriver; 
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }                                 
        }    
        public static FirefoxProfile GetBrowserProfile()
        {
            try
            {
                FirefoxProfile user_pref = new FirefoxProfile();
                //user_pref.SetPreference("setAlwaysLoadNoFocusLib", true);
                //user_pref.SetPreference("browser.tabs.loadInBackground", false);            
                //if (File.Exists(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi"))
                //{
                //    FileStream firebug = new FileStream(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi", FileMode.Open, FileAccess.Write);
                //    File firebug = new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi");
                //user_pref.AddExtension(new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\firebug@software.joehewitt.com.xpi"));
                //    user_pref.SetPreference(“extensions.firebug.currentVersion”, “2.0”);
                //    user_pref.SetPreference(“extensions.firebug.addonBarOpened”, true);
                //    user_pref.SetPreference(“extensions.firebug.console.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.script.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.net.enableSites”, true);
                //    user_pref.SetPreference(“extensions.firebug.previousPlacement”, 1);
                //    user_pref.SetPreference(“extensions.firebug.allPagesActivation”, “on”);
                //    user_pref.SetPreference(“extensions.firebug.onByDefault”, true);
                //    user_pref.SetPreference(“extensions.firebug.defaultPanelName”, “net”);
                //    if (File.Exists(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\yslow@yahoo-inc.com.xpi"))
                //    {
                //        File yslow = new File(@"C:\Users\RajKumar-PC\AppData\Roaming\Mozilla\Firefox\Profiles\slmohwsu.default-1439801120189\extensions\yslow@yahoo-inc.com.xpi");
                //        user_pref.AddExtension((yslow));
                //        user_pref.SetPreference(“extensions.yslow.beaconUrl”, “http://www.showslow.com/beacon/yslow/ “);
                //        user_pref.SetPreference(“extensions.yslow.beaconInfo”,”grade”);
                //        user_pref.SetPreference(“extensions.yslow.optinBeacon”,true);
                //        user_pref.SetPreference(“extensions.yslow.autorun”,true);
                //    }
                //}
                //user_pref.SetProxyPreferences(proxy);
                user_pref.SetPreference("SetEnableNativeEvents", true);//scroll webelements
                user_pref.SetPreference("intl.accept_languages","jp");//Support internationalizatin
                user_pref.SetPreference("browser.helperApps.alwaysAsk.force", false);
                user_pref.SetPreference("browser.download.folderList", 2);
                user_pref.SetPreference("browser.download.dir", @"C:\Users\RajKumar-PC\Downloads\Documents");
                user_pref.SetPreference("browser.download.useDownloadDir", true);
                user_pref.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
                user_pref.SetPreference("browser.download.manager.alertOnEXEOpen", false);
                user_pref.SetPreference("browser.download.manager.closeWhenDone", true);
                user_pref.SetPreference("browser.download.manager.focusWhenStarting", false);
                user_pref.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/xml, text/csv, text/plain, text/log, application/zip, application/zlib, application/x-gzip, application/x-gtar, multipart/x-gzip, application/tgz, application/gnutar, application/x-tar, application/gzip, application/pdf, application/x-msexcel, application/x-compressed, application/x-zip-compressed, multipart/x-zip, application/x-rar-compressed, application/octet-stream");
                user_pref.SetPreference("pdfjs.disabled", true);
                return user_pref;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }           
        } 
        public static FirefoxProfile Profile = GetBrowserProfile();
        public static Proxy proxy = new OpenQA.Selenium.Proxy();
        public static IWebDriver webDriver = GetWebDriver("FireFox"); 
        public static string LoginTitle = "Login";
        public static string baseURL = "http://172.18.12.225:4567/";
        public static void GoTo(string url)
        {
            try
            {
                string rootUrl = Browser.baseURL + url;
                //webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5)); // Set implicit wait timeouts to 5 secs
                //webDriver.Manage().Timeouts().SetScriptTimeout(new TimeSpan(0, 0, 0, 5));   // Set script timeouts to 5 secs
                webDriver.Url = rootUrl;
                ConfigureBrowser();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public static ISearchContext Driver
        {
            get { return webDriver; }
        }
        public static void ConfigureBrowser()
        {
            try
            {
                //webDriver.Manage().Cookies.DeleteAllCookies(); 
                webDriver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                // throw ex;
            }

        }
        public static void Wait()
        {
            try
            {
                webDriver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 10));
            }
            catch (Exception ex)
            {
               // throw ex;
            }

        }        
        public static string Title
        {
            get { return webDriver.Title; }          
        }
        public static string UserSuccess
        {
            get { return Admin.AdminPage.UpdateMessage.Text; }
        }
        public static bool IsAt(IsAt isat)
        {
            try
            {
                return isat.Header == isat.Title;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public static void SwitchToAlert(bool Confirm)
        {
            try
            {
                switch (Confirm)
                {
                    case true:
                    {
                        webDriver.SwitchTo().Alert().Accept();
                        break;
                    }
                    default:
                    {
                        webDriver.SwitchTo().Alert().Dismiss();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
        public static void Refresh(IWebElement Element)
        {
            //Element.SendKeys(Keys.F5);
            webDriver.Navigate().Refresh();
            //webDriver.Navigate().GoToUrl(webDriver.Url);
            //webDriver.Url = webDriver.Url;
            //Element.SendKeys("\uE035"); 
        }
        public static int CheckBrokenImages()
        {
            IList<IWebElement> ImageLinks = webDriver.FindElements(By.TagName("img"));
            List<string> list = new List<string>();
            foreach (IWebElement Links in ImageLinks)
            {
                list.Add(Links.GetAttribute("src"));
            }
            int oklinks = 0;
            int brokenlinks = 0;
            foreach (string item in list)
            {
                HttpWebRequest lxRequest = (HttpWebRequest)WebRequest.Create(item);
                //String lsResponse = string.Empty;
                using (HttpWebResponse lxResponse = (HttpWebResponse)lxRequest.GetResponse())
                {
                    switch (lxResponse.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            {
                                oklinks++;
                                break;
                            }
                        default:
                            {
                                brokenlinks++;
                                break;
                            }
                    }
                }
            }
            return brokenlinks;
        }
        public static IWebElement ClickOnInvisibleElement(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].hidden = false;", element);
            element.Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].hidden = true;", element);
            return element;
        }
        public static void ProcessRun(string FilePath)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.UseShellExecute = false;
                string FilePath = @"C:\Users\RajKumar-PC\Documents\Visual Studio 2013\Projects\QASageframe\AutoIt\Download.exe";
                myProcess.StartInfo.FileName = FilePath;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //public static bool TestWindow()
        //{
        //    string currenthandle = webDriver.CurrentWindowHandle;
        //    IList<string> handles = webDriver.WindowHandles;
        //    handles.Remove(currenthandle);
        //    if (handles.Count > 0)
        //    {
        //        try
        //        {
        //            int i = 0;
        //            foreach (string current in handles)
        //            {
        //                webDriver.SwitchTo().Window(handles[i]);
        //                i++;
        //                return true;
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}      
        public static void MouseMovement(IWebElement Element)
        {     
            try
            {
                Actions Builder = new Actions(webDriver);         
                Builder.MoveToElement(Element).Build().Perform();
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
        public static void MouseRightClick(IWebElement Element)
        {
            try
            {
                Actions Builder = new Actions(webDriver);
                Builder.ContextClick(Element).Build().Perform();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public static void DragAndDrop(DragNDrop DragNDrop)
        {
            try
            {
                Actions Place = new Actions(webDriver);
                Place.DragAndDrop(DragNDrop.Source, DragNDrop.Target).Perform();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void SwitchFrames(IWebElement frame)
        {
            try
            {
                webDriver.SwitchTo().Frame(frame);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public static void SwitchToMainWindow()
        {
            try
            {
                webDriver.SwitchTo().DefaultContent();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public static void ScrollDown(bool down)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                switch (down)
                {
                    case true:
                    {
                        js.ExecuteScript("scroll(0,250);");
                        break;
                    }
                    default:
                    {
                        js.ExecuteScript("scroll(0,0);");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public static void CheckBox(ChkBox CheckBox)
        {
            try
            {
                switch (CheckBox.Check)
                {
                    case true:
                        {
                            if (!CheckBox.CheckBox.Selected)
                            {
                                CheckBox.CheckBox.Click();
                            }
                            break;
                        }
                    default:
                        {
                            if (CheckBox.CheckBox.Selected)
                            {
                                CheckBox.CheckBox.Click();
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void SelectDropdown(DropDownSelect DropDownSelect)
        {
            try
            {
                SelectElement AvailableModuleSelect = new SelectElement(DropDownSelect.AvailableList);
                AvailableModuleSelect.SelectByText(DropDownSelect.Select);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string JSExecutor(string JS)
        {
            try
            {
                return ((IJavaScriptExecutor)webDriver).ExecuteScript(JS).ToString();
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public static IWebElement WaitForElement(WaitForElement waitForElement)
        {
            try
            {
                if (waitForElement.timeoutInSeconds > 0)
                {
                    var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(waitForElement.timeoutInSeconds));
                    return wait.Until(drv => drv.FindElement(waitForElement.by));
                }
                return webDriver.FindElement(waitForElement.by);
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public static void WaitForAnWebElementDisplayed(WaitForWebElement WaitForWebElement)
        {
            try
            {
                WaitForWebElement.wait.Until(x => WaitForWebElement.webElement.Displayed);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void WaitForAnWebElementEnabled(WaitForWebElement WaitForWebElement)
        {
            try
            {
                WaitForWebElement.wait.Until(x => WaitForWebElement.webElement.Enabled);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DateSelect(SelectDate SelectDate)
        {
            try
            {
                SelectDropdown(SelectDate.YearDropDownSelect);
                SelectDropdown(SelectDate.MonthDropDownSelect);
                Driver.FindElement(By.LinkText(SelectDate.Day)).Click();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public static void FileUpload(InjectJs InjectJs)
        {
            try
            {
                String script = "document.getElementById('" + InjectJs.ID + "')." + InjectJs.Attribute + "='" + InjectJs.Value + "';";
                ((IJavaScriptExecutor)webDriver).ExecuteScript(script);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public static void ClearAndFillTextBox(ClearAndFillTextBox ClearNFillTextBox)
        {
            try
            {
                ClearNFillTextBox.Element.Clear();
                ClearNFillTextBox.Element.SendKeys(ClearNFillTextBox.FillText);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void SaveCancel(SaveCancel savecancel)
        {
            try
            {
                switch (savecancel.Save)
                {
                    case true:
                        {
                            switch (savecancel.Create.Enabled)
                            {
                                case true:
                                    {
                                        savecancel.Create.Click();
                                        //Browser.TestResults.Pass++;
                                        break;
                                    }
                                default:
                                    {
                                        MessageBox.Show("Fill valid Details!");
                                        //Browser.SwitchToAlert(true);
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            savecancel.CancelButton.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[0] = ex.ToString();
                //Browser.TestResults.Fail++;
            }
        }
        public static string RandomStringGenerator()
        {
            try
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random random = new Random();
                string result = new string(
                    Enumerable.Repeat(chars, 8)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());
                return result;
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.ToString();
                //Browser.TestResults.Fail++;
            }
        }
        public static void Confirm(bool Confirm)
        {
            try
            {
                switch (Confirm)
                {
                    case true:
                        {
                            IWebElement DeleteConfirm = Browser.Driver.FindElement(By.ClassName("ConfirmYes"));
                            DeleteConfirm.Click();
                            break;
                        }
                    case false:
                        {
                            IWebElement CancelDelete = Browser.Driver.FindElement(By.ClassName("ConfirmNo"));
                            CancelDelete.Click();
                            break;
                        }
                }
                //Browser.TestResults.Pass++;
            }
            catch (Exception ex)
            {
                throw ex;
                //Browser.TestResults.ErrorException[1] = ex.ToString();
                //Browser.TestResults.Fail++;
            }
        }
        //public static void IsLoginPage()
        //{
        //    try
        //    {
        //        if (Browser.IsAt(Browser.Title, Browser.LoginTitle) == false)
        //        {

        //           // throw new IllegalLocatorException("Not the LoginPage");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //       // throw ex;
        //    }          
        //}
        public static void Teardown()
        {
            try
            {
                webDriver.Close();
                webDriver.Quit();
            }
            catch (Exception ex)
            {
                //throw ex;
            }

        }
    }
}
