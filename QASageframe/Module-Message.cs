using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class ModuleMessage
    {
        public string Module { get; set; }
        public string DisplayMode { get; set; }
        public string Culture { get; set; }
        public string MessagePosition { get; set; }
        public string MessageType { get; set; }
        public bool Hide { get; set; }
        public string Message { get; set; }
        public bool Source { get; set; }
        public ModuleMessage(string module, string displaymode, string culture, string messageposition, string messagetype, bool hide, string message, bool source)
        {
            Module = module;
            DisplayMode = displaymode;
            Culture = culture;
            MessagePosition = messageposition;
            MessageType = messagetype;
            Hide = hide;
            Message = message;
            Source = source;
        }
    }
    #endregion
    public static class Module_Message
    {
        public static Module_MessagePage Module_MessagePage
        {
            get
            {
                var module_messagepage = new Module_MessagePage();
                PageFactory.InitElements(Browser.Driver, module_messagepage);
                return module_messagepage;
            }
        }       
    }
    public  class Module_MessagePage
    {
        public string Url = "Admin/Module-Message.aspx";
        public string Text = "Module Message";
        #region
        [FindsBy(How = How.Id, Using = "ddlModuleSelect")][CacheLookup]
        public IWebElement ModuleDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ddlPersist")][CacheLookup]
        public IWebElement DisplayModeDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ddlCulture")][CacheLookup]
        public IWebElement CultureDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ddlMessagePosition")][CacheLookup]
        public IWebElement MessagePositionDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ddlMessageType")][CacheLookup]
        public IWebElement MessageTypeDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "chkIsActive")][CacheLookup]
        public IWebElement IsActiveCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "cke_top_txtModuleMessage")][CacheLookup]
        public IWebElement ModuleMessageTopBar { get; set;}
        [FindsBy(How = How.Id, Using = "cke_contents_txtModuleMessage")][CacheLookup]
        public IWebElement ModuleMessageTd { get; set; }
        [FindsBy(How = How.Id, Using = "cke_32")][CacheLookup]
        public IWebElement HideTopBar { get; set;}
        [FindsBy(How = How.Id, Using = "iframe")][CacheLookup]
        public IWebElement CKFrame { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveMessage")][CacheLookup]
        public IWebElement SaveMessageBtn { get; set; }
        #endregion      
        public void Edit_ModuleMessage(ModuleMessage ModuleMessage)
        {
            try
            {
                DropDownSelect DropDownModule = new DropDownSelect(ModuleMessage.Module, ModuleDropdown);
                DropDownSelect DropDownDisplayMode = new DropDownSelect(ModuleMessage.DisplayMode, DisplayModeDropdown);
                DropDownSelect DropDownCulture = new DropDownSelect(ModuleMessage.Culture, CultureDropdown);
                DropDownSelect DropDownMessagePosition = new DropDownSelect(ModuleMessage.MessagePosition, MessagePositionDropdown);
                DropDownSelect DropDownMessageType = new DropDownSelect(ModuleMessage.MessageType, MessageTypeDropdown);
                Browser.SelectDropdown(DropDownModule);
                Browser.SelectDropdown(DropDownDisplayMode);
                Browser.SelectDropdown(DropDownCulture);
                Browser.SelectDropdown(DropDownMessagePosition);
                Browser.SelectDropdown(DropDownMessageType);
                IWebElement TopDiv = ModuleMessageTopBar.FindElement(By.TagName("div"));
                IList<IWebElement> Span = TopDiv.FindElements(By.TagName("span"));
                IList<IWebElement> ToolbarSpanLink = Span[1].FindElements(By.TagName("span"));
                IWebElement SpanLink = ToolbarSpanLink[1].FindElement(By.TagName("span"));
                IWebElement SourceLink = SpanLink.FindElement(By.TagName("a"));
                switch (ModuleMessage.Source)
                {
                    case true:
                        {
                            if (SourceLink.GetAttribute("class") == "cke_off cke_button_source")
                            {
                                SourceLink.Click();
                            }
                            IWebElement ModuleMessageTextArea = ModuleMessageTd.FindElement(By.TagName("textarea"));
                            ClearAndFillTextBox ModuleMessageClearNFill = new ClearAndFillTextBox(ModuleMessageTextArea, ModuleMessage.Message);
                            Browser.ClearAndFillTextBox(ModuleMessageClearNFill);
                            break;
                        }
                    default:
                        {
                            if (SourceLink.GetAttribute("class") == "cke_button_source cke_on")
                            {
                                SourceLink.Click();
                            }
                            if (ModuleMessage.Hide)
                            {
                                HideTopBar.Click();
                            }
                            ClearAndFillTextBox CKFrameClearNFill = new ClearAndFillTextBox(CKFrame, ModuleMessage.Message);
                            Browser.ClearAndFillTextBox(CKFrameClearNFill);
                            break;
                        }
                }
                SaveMessageBtn.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
    }
}
