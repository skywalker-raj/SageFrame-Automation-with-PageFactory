using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace QASageframe
{
    #region
    public class AddMT
    {
        public string N { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool Save { get; set; }
        public string Tmtt { get; set; }
        public string Mttext { get; set; }
        public string Token { get; set; }
        public AddMT(string n, string email, string subject, string text, bool save, string tmtt, string mttext, string token)
        {
            N = n;
            Email = email;
            Subject = subject;
            Text = text;
            Save = save;
            Tmtt = tmtt;
            Mttext = mttext;
            Token = token;
        }
    }
    #endregion
    public static class Message_Template
    {
        public static Message_TemplatePage MessageTemplatePage
        {
            get
            {
                var message_templatepage = new Message_TemplatePage();
                PageFactory.InitElements(Browser.Driver, message_templatepage);
                return message_templatepage;
            }
        }
    }
    public class Message_TemplatePage
    {
        public string Url = "Admin/Message-Template.aspx";
        public string Text = "Message Template";
        #region
        [FindsBy(How = How.Id, Using = "ctl19_txtMailFrom")][CacheLookup]
        public IWebElement FromEmail { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtSubject")][CacheLookup]
        public IWebElement Subject { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_chkIsActive")][CacheLookup]
        public IWebElement IsActiveCheck { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblAddMessageTemplateType")][CacheLookup]
        public IWebElement MTT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtMessageTemplateType")][CacheLookup]
        public IWebElement TMTT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnOkMessageTemplateType")][CacheLookup]
        public IWebElement ATMTT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblAddMessageTemplateToken")][CacheLookup]
        public IWebElement AMTT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_txtMessageTemplateToken")][CacheLookup]
        public IWebElement mtt { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnOkMessageTemplateToken")][CacheLookup]
        public IWebElement BMTT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblAddSubjectMessageToken")][CacheLookup]
        public IWebElement ASMT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnAddMessageTokenOk")][CacheLookup]
        public IWebElement AMT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblAddBodyMessageToken")][CacheLookup]
        public IWebElement ABMT { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblCustomizeEditor")][CacheLookup]
        public IWebElement CustomizedEditor { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblDefault")][CacheLookup]
        public IWebElement DefaultEditor { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lstMessageToken")][CacheLookup]
        public IWebElement Token { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_pnlMessageTemplateList")][CacheLookup]
        public IWebElement ID { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlMessageTemplateType")][CacheLookup]
        public IWebElement TemplateType { get; set; }
        //[FindsBy(How = How.Id, Using = "xEditingArea")][CacheLookup]
        //public IWebElement Id { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_pnlMessageTemplate")][CacheLookup]
        public IWebElement id { get; set; }
        #endregion
        public void SelectToken(string token)
        {
            try
            {
                DropDownSelect TokenDropDown = new DropDownSelect(token, Token);
                Browser.SelectDropdown(TokenDropDown);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public void AddMT(AddMT AddMT)
        {
            try
            {
                //IWebElement ID = Browser.Driver.FindElement(By.Id("ctl19_pnlMessageTemplateList"));
                IWebElement sfFW = ID.FindElements(By.TagName("div"))[0];
                IWebElement label = sfFW.FindElement(By.TagName("label"));
                //IWebElement amt = label.FindElement(By.TagName("input"));
                label.Click();
                Browser.Wait();
                DropDownSelect TemplateTypeDropDown = new DropDownSelect(AddMT.N, TemplateType);
                Browser.SelectDropdown(TemplateTypeDropDown);
                Browser.Wait();
                MTT.Click();
                ClearAndFillTextBox TMTTClearNFill = new ClearAndFillTextBox(TMTT, AddMT.Tmtt);
                Browser.ClearAndFillTextBox(TMTTClearNFill);
                ATMTT.Click();
                AMTT.Click();
                ClearAndFillTextBox MTTClearNFill = new ClearAndFillTextBox(mtt, AddMT.Mttext);
                Browser.ClearAndFillTextBox(MTTClearNFill);
                BMTT.Click();
                ASMT.Click();
                SelectToken(AddMT.Token);
                Browser.Wait();
                AMT.Click();
                ABMT.Click();
                SelectToken(AddMT.Token);
                AMT.Click();
                ClearAndFillTextBox FromEmailClearNFill = new ClearAndFillTextBox(FromEmail, AddMT.Email);
                Browser.ClearAndFillTextBox(FromEmailClearNFill);
                ClearAndFillTextBox SubjectClearNFill = new ClearAndFillTextBox(Subject, AddMT.Subject);
                Browser.ClearAndFillTextBox(SubjectClearNFill);
                IWebElement Id = Browser.Driver.FindElement(By.Id("xEditingArea"));
                IWebElement iframe = Id.FindElement(By.TagName("iframe"));
                IWebElement html = iframe.FindElement(By.TagName("html"));
                IWebElement body = html.FindElement(By.TagName("body"));
                ClearAndFillTextBox BodyClearNFill = new ClearAndFillTextBox(body, AddMT.Text);
                Browser.ClearAndFillTextBox(BodyClearNFill);
                IsActiveCheck.Click();
                //IWebElement id = Browser.Driver.FindElement(By.Id("ctl19_pnlMessageTemplate"));
                IWebElement sfBW = id.FindElements(By.TagName("div"))[1];
                IList<IWebElement> label1 = sfBW.FindElements(By.TagName("label"));
                switch (AddMT.Save)
                {
                    case true:
                        {
                            IWebElement input = label1[0].FindElement(By.TagName("input"));
                            input.Click();
                            break;
                        }
                    default:
                        {
                            IWebElement input = label1[1].FindElement(By.TagName("input"));
                            input.Click();
                            break;
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
