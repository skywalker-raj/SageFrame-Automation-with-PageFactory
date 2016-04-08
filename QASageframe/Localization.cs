using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using OpenQA.Selenium;
using System;
namespace QASageframe
{
    #region
    public class Button
    {
        public int n { get; set; }
        public int m { get; set; }
        public Button(int N, int M)
        {
            n = N;
            m = M;
        }
    }
    public class GetTimeZone
    {
        public Button Button { get; set; }
        public IWebElement Table { get; set; }
        public GetTimeZone(Button button, IWebElement table)
        {
            Button = button;
            Table = table;
        }
    }
    public class SaveConfirm
    {
        public bool Save { get; set; }
        public int N { get; set; }
        public SaveConfirm(bool save, int n)
        {
            Save = save;
            N = n;
        }
    }
    public class EditResources
    {
        public IWebElement DivI { get; set; }
        public int ResourceNo { get; set; }
        public int N { get; set; }
        public EditResources(IWebElement divI, int resourceno, int n)
        {
            DivI = divI;
            ResourceNo = resourceno;
            N = n;
        }
    }
    public class XMLClientResources
    {
        public IList<IWebElement> Divs { get; set; }
        public int J { get; set; }
        public int N { get; set; }
        public XMLClientResources(IList<IWebElement> divs, int j, int n)
        {
            Divs = divs;
            J = j;
            N = n;
        }
    }
    public class AdminModules
    {
        public IWebElement Divs { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        public int K { get; set; }
        public AdminModules(IWebElement divs, int i, int j, int k)
        {
            Divs = divs;
            I = i;
            J = j;
            K = k;
        }
    }
    public class PortalModules
    {
        public IWebElement Divs { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        public int L { get; set; }
        public int K { get; set; }
        public int ResourceNo { get; set; }
        public PortalModules(IWebElement divs, int i, int j, int l, int k, int resourceno)
        {
            Divs = divs;
            I = i;
            J = j;
            L = l;
            K = k;
            ResourceNo = resourceno;
        }
    }
    public class SetLocalizeMenu
    {
        public int N { get; set; }
        public string LocalValues { get; set; }
        public string LocalCaption { get; set; }
        public SetLocalizeMenu(int n, string localvalues, string localcaption)
        {
            N = n;
            LocalValues = localvalues;
            LocalCaption = localcaption;
        }
    }
    public class LocalizeMenu
    {
        public string AvailableLocales { get; set; }
        public SetLocalizeMenu[] SetLocalizeMenu { get; set; }
        public bool Save { get; set; }
        public LocalizeMenu(string availablelocales, SetLocalizeMenu[] setlocalizemenu, bool save)
        {
            AvailableLocales = availablelocales;
            SetLocalizeMenu = setlocalizemenu;
            Save = save;
        }
    }
    public class AddLanguage
    {
        public string Language { get; set; }
        public string LanguageType { get; set; }
        public bool Save { get; set; }
        public AddLanguage(string language, string languagetype, bool save)
        {
            Language = language;
            LanguageType = languagetype;
            Save = save;
        }
    }
    public class FillKeyValues
    {
        public string Edit { get; set; }
        public string[] KeyValue { get; set; }
        public string ResourceFile { get; set; }
        public bool Back { get; set; }
        public FillKeyValues(string edit, string[] keyvalue, string resourcefile, bool back)
        {
            Edit = edit;
            KeyValue = keyvalue;
            ResourceFile = resourcefile;
            Back = back;
        }
    }
    public class EditLanguage
    {
        public bool Edit { get; set; }
        public string LanguageList { get; set; }
        public int N { get; set; }
        public bool Enable { get; set; }
        public bool DelConfirm { get; set; }
        public bool AdminResources { get; set; }
        public bool RootResources { get; set; }
        public bool AdminModule { get; set; }
        public bool Modules { get; set; }
        public bool XMLClient { get; set; }
        public FillKeyValues FillKeyValues { get; set; }
        public bool Delete { get; set; }
        public EditLanguage(bool edit, string languagelist, int n, bool enable, bool delconfirm, bool adminresources, bool rootresources, bool adminmodule, bool modules, bool xmlclient, FillKeyValues fillkeyvalues, bool delete)
        {
            Edit = edit;
            LanguageList = languagelist;
            N = n;
            Enable = enable;
            DelConfirm = delconfirm;
            AdminResources = adminresources;
            RootResources = rootresources;
            AdminModule = adminmodule;
            Modules = modules;
            XMLClient = xmlclient;
            FillKeyValues = fillkeyvalues;
            Delete = delete;
        }
    }
    public class LocalizeModuleTitle
    {
        public string LocalesModuleTitle { get; set; }
        public int[] N { get; set; }
        public string[] ModuleLocalTitle { get; set; }
        public bool Save { get; set; }
        public LocalizeModuleTitle(string localesmoduletitle, int[] n, string[] modulelocaltitle, bool save)
        {
            LocalesModuleTitle = localesmoduletitle;
            N = n;
            ModuleLocalTitle = modulelocaltitle;
            Save = save;
        }
    }
    public class TimeZoneEditor
    {
        public string LanguageTimeZoneEditor { get; set; }
        public int[] N { get; set; }
        public string[] TimeZone { get; set; }
        public bool Save { get; set; }
        public TimeZoneEditor(string languagetimezoneeditor, int[] n, string[] timezone, bool save)
        {
            LanguageTimeZoneEditor = languagetimezoneeditor;
            N = n;
            TimeZone = timezone;
            Save = save;
        }
    }
    public class CreateLanguagePack
    {
        public string Language { get; set; }
        public string ResourcePackType { get; set; }
        public string ResourcePackName { get; set; }
        public bool Create { get; set; }
        public CreateLanguagePack(string language, string resourcepacktype, string resourcepackname, bool create)
        {
            Language = language;
            ResourcePackType = resourcepacktype;
            ResourcePackName = resourcepackname;
            Create = create;
        }
    }
    public class InstallLanguagePack
    {
        public string FilePath { get; set; }
        public bool[] Next { get; set; }
        public bool AcceptLicense { get; set; }
        public bool OverWrite { get; set; }
        public bool Finish { get; set; }
        public InstallLanguagePack(string filepath, bool[] next, bool acceptlicense, bool overwrite, bool finish)
        {
            FilePath = filepath;
            Next = next;
            AcceptLicense = acceptlicense;
            OverWrite = overwrite;
            Finish = finish;
        }
    }
    #endregion
    public static class Localization
    {
        public static LocalizationPage LocalizationPage
        {
            get
            {
                var localizationpage = new LocalizationPage();
                PageFactory.InitElements(Browser.Driver, localizationpage);
                return localizationpage;
            }
        }
    }
    public class LocalizationPage
    {
        public string Url = "Admin/Localization.aspx";
        public string Text = "Localization";
        #region
        [FindsBy(How = How.TagName, Using = "body")]
        public IWebElement Body { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_langEditFirstDiv")]
        public IWebElement EditLangDiv { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ddlPageSize")]
        public IWebElement PageSizeDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_gdvLangList")]
        public IWebElement LanguageListGrid { get; set;}
        //Add Language
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_LanguagePackSetup_ddlLanguage")]
        public IWebElement LanguageSetupDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_LanguagePackSetup_rbLanguageType_0")]
        public IWebElement EnglishLanguageType { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_LanguagePackSetup_rbLanguageType_1")]
        public IWebElement NativeLanguageType { get; set;}
        [FindsBy(How = How.Id, Using = "divBottompanel")]
        public IWebElement BottompanelDiv { get; set;}
        //Langugae Installer
        [FindsBy(How = How.Id, Using = "ctl19_LanguagePackInstaller1_wzrdInstallLanguagePack")]
        public IWebElement InstallLanguagePackDiv{ get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_LanguagePackInstaller1_wzrdInstallLanguagePack_fluLanguagePack")]
        public IWebElement LanguagePackUploader{ get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_LanguagePackInstaller1_wzrdInstallLanguagePack_chkAcceptLicense")]
        public IWebElement AcceptLicenseCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_LanguagePackInstaller1_wzrdInstallLanguagePack_chkOverWrite")]
        public IWebElement OverwriteExistingCheckBox { get; set;}
        //Language Pack Creator
        [FindsBy(How = How.Id, Using = "ctl19_CreateLanguagePack1_ddlResourceLocale")]
        public IWebElement ResourceLocaleDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_CreateLanguagePack1_rbResourcePackType_0")]
        public IWebElement CoreResourcePackType { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_CreateLanguagePack1_rbResourcePackType_1")]
        public IWebElement ModuleResourcePackType { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_CreateLanguagePack1_rbResourcePackType_2")]
        public IWebElement FullResourcePackType { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_CreateLanguagePack1_txtResourcePackName")]
        public IWebElement ResourcePackNameTextBox { get; set;}        
        //TimeZone Editor
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_TimeZoneEditor_ddlAvailableLocales")]
        public IWebElement AvailableLocalesDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_TimeZoneEditor_gdvTimeZoneEditor")]
        public IWebElement TimeZoneEditorGrid { get; set;}
        //Localize Time
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_MenuEditor_ddlAvailableLocales")]
        public IWebElement MenuAvailableLocalesDropdown{ get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_MenuEditor_gdvLocalPage")]
        public IWebElement LocalPageEditorGrid { get; set;}
        //Localize Module Title
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_ModuleTitleEditor_ddlAvailableLocales")]
        public IWebElement AvailableLocalesModuleTitle { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctrl_ModuleTitleEditor_gdvLocalModuleTitle")]
        public IWebElement LocalModuleTitleDiv { get; set;}
        //Edit Language
        [FindsBy(How = How.Id, Using = "ctl19_controlButtons")]
        public IWebElement ButtonDiv { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_languageContent")]
        public IWebElement LanguageContentDiv { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_tvList")]
        public IWebElement ListDiv { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_gdvResxKeyValue")]
        public IWebElement KeyValueTable { get; set;}
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement { get; set;}
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement { get; set;}      
        #endregion
        public void DeleteConfirm(bool Confirm)
        {
            try
            {
                IList<IWebElement> Divs = Body.FindElements(By.TagName("div"));
                IList<IWebElement> Button = Divs[58].FindElements(By.TagName("button"));
                switch (Confirm)
                {
                    case true:
                        {
                            Button[0].Click();
                            break;
                        }
                    default:
                        {
                            Button[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }          
        }
        public void DeleteSave(bool Save)
        {
            //n:0 for delete n:1 for save
            try
            {
                IWebElement Divs = LanguageContentDiv.FindElements(By.TagName("div"))[1];
                IList<IWebElement> Button = Divs.FindElements(By.TagName("label"));
                switch (Save)
                {
                    case true:
                        {
                            Button[0].Click();
                            break;
                        }
                    default:
                        {
                            Button[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public IList<IWebElement> SelectLanguageRowList(int n)
        {
            try
            {
                IWebElement Tbody = LanguageListGrid.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[n].FindElements(By.TagName("td"));
                return Td;
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }
        }
        public IWebElement GetButton(int n)
        {
            //n = 0:AddLanguage, n = 1:InstallLanguagePack, n = 2:CreateLanguagePack, n = 3:TimeZoneEditor, n = 4:LocalizeTime, n = 5:LocalizeModuleTitle 
            try
            {
                IWebElement Div = EditLangDiv.FindElement(By.TagName("div"));
                IList<IWebElement> Button = Div.FindElements(By.TagName("label"));
                return Button[n];
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }
        }
        public IWebElement SaveButton(Button Button)
        {
            //n = 0:Save, n = 1:Cancel(Normally Except in few cases)
            //m = 7:Add/Install LanguagePack
            //m = 5:Create
            //m = 8:TimeZoneEditor/LocalizeMenu/LocalizeModuleTitle
            try
            {
                IList<IWebElement> Divs = BottompanelDiv.FindElements(By.TagName("div"));
                IList<IWebElement> ButtonI = Divs[Button.n].FindElements(By.TagName("label"));
                //string Text = Button[n].GetAttribute("class");
                return ButtonI[Button.m];
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public IWebElement NextButton(Button Button)
        {
            //m = 0:Previous, m = 1:Next(Except in the first NextButton)
            //n = 1 for all except overwrite case n = 3
            try
            {
                IList<IWebElement> Divs = InstallLanguagePackDiv.FindElements(By.TagName("div"));
                IList<IWebElement> ButtonI = Divs[Button.n].FindElements(By.TagName("label"));
                return ButtonI[Button.m];
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }     
        public IWebElement GetTimeZoneTextBox(GetTimeZone GetTimeZone)
        {
            // for TimeZone: m = 0, IWebElement = TimeZoneEditorGrid
            // for LocalizeModuleTitle m = 2, IWebElement = LocalModuleTitleDiv
            try
            {
                IWebElement Tbody = GetTimeZone.Table.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[GetTimeZone.Button.n].FindElements(By.TagName("td"));
                IWebElement TimeZoneTextBox = Td[GetTimeZone.Button.m].FindElement(By.TagName("input"));
                return TimeZoneTextBox;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public void SetLocalizeMenu(SetLocalizeMenu SetLocalizeMenu)
        {
            try
            {
                IWebElement Tbody = LocalPageEditorGrid.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[SetLocalizeMenu.N].FindElements(By.TagName("td"));
                IWebElement LocalValuesTextBox = Td[2].FindElement(By.TagName("input"));
                IWebElement LocalCaptionTextBox = Td[3].FindElement(By.TagName("input"));
                ClearAndFillTextBox LocalValuesClearNFill = new ClearAndFillTextBox(LocalValuesTextBox, SetLocalizeMenu.LocalValues);
                Browser.ClearAndFillTextBox(LocalValuesClearNFill);
                ClearAndFillTextBox LocalCaptionClearNFill = new ClearAndFillTextBox(LocalCaptionTextBox, SetLocalizeMenu.LocalCaption);
                Browser.ClearAndFillTextBox(LocalCaptionClearNFill);
            }
            catch (Exception ex)
            {                
                //throw ex;
            }
        }
        public void AddLanguage(AddLanguage AddLanguage)
        {
            try
            {
                IWebElement Button = GetButton(0);
                Button.Click();
                DropDownSelect LanguageDropDown = new DropDownSelect(AddLanguage.Language, LanguageSetupDropdown);
                Browser.SelectDropdown(LanguageDropDown);
                switch (AddLanguage.LanguageType)
                {
                    case "English":
                        EnglishLanguageType.Click();
                        break;
                    case "Native":
                        NativeLanguageType.Click();
                        break;
                }
                SaveConfirm SaveConfirmI = new SaveConfirm(AddLanguage.Save, 7);
                SaveConfirm(SaveConfirmI);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
        public void InstallLanguagePack(InstallLanguagePack InstallLanguagePack)
        {
            try
            {
                IWebElement Button = GetButton(1);
                Button.Click();
Start:          LanguagePackUploader.SendKeys(InstallLanguagePack.FilePath);
                switch (InstallLanguagePack.Next[0])
                {
                    case true:
                        {
                            Button ButtonI = new Button(1, 0);
                            IWebElement NextBtn = NextButton(ButtonI);
                            NextBtn.Click();
Mid:                        switch (InstallLanguagePack.Next[1])
                            {
                                case true:
                                    {
                                        Button ButtonII = new Button(1, 1);
                                        IWebElement NextBtn1 = NextButton(ButtonII);
                                        NextBtn1.Click();
Intermediate:                           switch (InstallLanguagePack.Next[2])
                                        {
                                            case true:
                                                {
                                                    IWebElement NextBtn2 = NextButton(ButtonII);
                                                    NextBtn2.Click();
                                                    ChkBox AcceptLicenseChkBox = new ChkBox(InstallLanguagePack.AcceptLicense, AcceptLicenseCheckBox);
AcceptLicense:                                      Browser.CheckBox(AcceptLicenseChkBox);
                                                    switch (InstallLanguagePack.Next[3])
                                                    {
                                                        case true:
                                                            {
                                                                IWebElement NextBtn3 = NextButton(ButtonII);
                                                                NextBtn3.Click();
                                                                if (OverwriteExistingCheckBox.Displayed)
                                                                {
                                                                    ChkBox OverwriteChkBox = new ChkBox(InstallLanguagePack.OverWrite, OverwriteExistingCheckBox);
                                                                    Browser.CheckBox(OverwriteChkBox);
                                                                }
                                                                switch (InstallLanguagePack.Next[4])
                                                                {
                                                                    case true:
                                                                        {
                                                                            Button ButtonIII = new Button(3, 1);
                                                                            IWebElement NextBtn4 = NextButton(ButtonIII);
                                                                            NextBtn4.Click();
                                                                            switch (InstallLanguagePack.Finish)
                                                                            {
                                                                                case true:
                                                                                    {
                                                                                        IWebElement FinishBtn = NextButton(ButtonI);
                                                                                        FinishBtn.Click();
                                                                                        break;
                                                                                    }
                                                                                default:
                                                                                    {
                                                                                        Button ButtonIV = new Button(7, 0);
                                                                                        IWebElement CancelBtn = SaveButton(ButtonIV);
                                                                                        CancelBtn.Click();
                                                                                        break;
                                                                                    }
                                                                            }
                                                                            break;
                                                                        }
                                                                    case false:
                                                                        {
                                                                            Button ButtonV = new Button(3, 0);
                                                                            IWebElement PreviousBtn4 = NextButton(ButtonV);
                                                                            PreviousBtn4.Click();
                                                                            InstallLanguagePack.Next[4] = true;
                                                                            goto AcceptLicense;
                                                                        }
                                                                    default:
                                                                        {
                                                                            Button ButtonIV = new Button(7, 0);
                                                                            IWebElement CancelBtn = SaveButton(ButtonIV);
                                                                            CancelBtn.Click();
                                                                            break;
                                                                        }
                                                                }
                                                                break;
                                                            }
                                                        case false:
                                                            {
                                                                IWebElement PreviousBtn3 = NextButton(ButtonI);
                                                                PreviousBtn3.Click();
                                                                InstallLanguagePack.Next[3] = true;
                                                                goto Intermediate;
                                                            }
                                                        default:
                                                            {
                                                                Button ButtonIV = new Button(7, 0);
                                                                IWebElement CancelBtn = SaveButton(ButtonIV);
                                                                CancelBtn.Click();
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            case false:
                                                {
                                                    IWebElement PreviousBtn2 = NextButton(ButtonI);
                                                    PreviousBtn2.Click();
                                                    InstallLanguagePack.Next[2] = true;
                                                    goto Mid;
                                                }
                                            default:
                                                {
                                                    Button ButtonIV = new Button(7, 0);
                                                    IWebElement CancelBtn = SaveButton(ButtonIV);
                                                    break;
                                                    //CancelBtn.Click();
                                                }
                                        }
                                        break;
                                    }
                                case false:
                                    {
                                        IWebElement PreviousBtn1 = NextButton(ButtonI);
                                        PreviousBtn1.Click();
                                        InstallLanguagePack.Next[1] = true;
                                        goto Start;
                                    }
                                default:
                                    {
                                        Button ButtonIV = new Button(7, 0);
                                        IWebElement CancelBtn = SaveButton(ButtonIV);
                                        CancelBtn.Click();
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            Button ButtonIV = new Button(7, 0);
                            IWebElement CancelBtn = SaveButton(ButtonIV);
                            CancelBtn.Click();
                            break;
                        }
                }
                //if(Next[0])
                //{
                //    IWebElement NextBtn = NextButton(1, 0);
                //    NextBtn.Click();
                //Mid:     if (Next[1])
                //         {
                //             IWebElement NextBtn1 = NextButton(1, 1);
                //             NextBtn1.Click();

                //Intermediate:if (Next[2])
                //             {
                //                 IWebElement NextBtn2 = NextButton(1, 1);
                //                 NextBtn2.Click();
                //AcceptLicense:   Browser.CheckBox(AcceptLicense, AcceptLicenseCheckBox);
                //if (Next[3])
                //{
                //    IWebElement NextBtn3 = NextButton(1, 1);
                //    NextBtn3.Click();
                //    if (OverwriteExistingCheckBox.Displayed)
                //    {
                //        Browser.CheckBox(Overwrite, OverwriteExistingCheckBox);
                //    }
                //    //if (Next[4])
                //{
                //    IWebElement NextBtn4 = NextButton(3, 1);
                //    NextBtn4.Click();
                //    //if (Finish)
                //    //{
                //    //    IWebElement FinishBtn = NextButton(1, 0);
                //    //    FinishBtn.Click();
                //    //}
                //    //else
                //    //{
                //    //    IWebElement CancelBtn = SaveButton(7, 0);
                //    //    CancelBtn.Click();
                //    //}
                //}
                //else if (!Next[4])
                //{
                //    IWebElement PreviousBtn4 = NextButton(3, 0);
                //    PreviousBtn4.Click();
                //    Next[4] = true;
                //    goto AcceptLicense;
                //}
                //else
                //{
                //    IWebElement CancelBtn = SaveButton(7, 0);
                //    CancelBtn.Click();
                //}           
                //}
                //else if (!Next[3])
                //{
                //    IWebElement PreviousBtn3 = NextButton(1, 0);
                //    PreviousBtn3.Click();
                //    Next[3] = true;
                //    goto Intermediate;
                //}
                //else
                //{
                //    IWebElement CancelBtn = SaveButton(7, 0);
                //    CancelBtn.Click();
                //}                         
                //}
                //else if (!Next[2])
                //{
                //    IWebElement PreviousBtn2 = NextButton(1, 0);
                //    PreviousBtn2.Click();
                //    Next[2] = true;
                //    goto Mid;
                //}
                //else
                //{
                //    IWebElement CancelBtn = SaveButton(7, 0);
                //    CancelBtn.Click();
                //}                         
                //}       
                //else if (!Next[1])
                //{
                //    IWebElement PreviousBtn1 = NextButton(1, 0);
                //    PreviousBtn1.Click();
                //    Next[1] = true;
                //    goto Start;
                //}
                //else
                //{
                //    IWebElement CancelBtn = SaveButton(0, 7);
                //    CancelBtn.Click();                              
                //}                                                      
                //}
                //else
                //{
                //    IWebElement CancelBtn = SaveButton(7, 0);
                //    CancelBtn.Click();
                //}
                Button ButtonVI = new Button(7, 0);
                IWebElement FinalCancelBtn = SaveButton(ButtonVI);
                FinalCancelBtn.Click();
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }    
        public void CreateLanguagePack(CreateLanguagePack CreateLanguagePack)
        {
            try
            {
                IWebElement Button = GetButton(2);
                Button.Click();
                DropDownSelect LocalResourceDropDown = new DropDownSelect(CreateLanguagePack.Language, ResourceLocaleDropdown);
                Browser.SelectDropdown(LocalResourceDropDown);
                Browser.Wait();
                switch (CreateLanguagePack.ResourcePackType)
                {
                    case "Core":
                        CoreResourcePackType.Click();
                        break;
                    case "Module":
                        ModuleResourcePackType.Click();
                        break;
                    case "Full":
                        FullResourcePackType.Click();
                        break;
                }
                ClearAndFillTextBox ResourcePackNameClearNFill = new ClearAndFillTextBox(ResourcePackNameTextBox, CreateLanguagePack.ResourcePackName);
                //SaveConfirm SaveConfirmI = new SaveConfirm(Create, 5);
                //SaveConfirm(SaveConfirmI);
                switch (CreateLanguagePack.Create)
                {
                    case true:
                        {
                            Button ButtonI = new Button(5, 0);
                            IWebElement SaveBtn = SaveButton(ButtonI);
                            SaveBtn.Click();
                            break;
                        }
                    default:
                        {
                            Button ButtonI = new Button(5, 1);
                            IWebElement CancelBtn = SaveButton(ButtonI);
                            CancelBtn.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }        
        public void TimeZoneEditor(TimeZoneEditor TimeZoneEditor)
        {
            try
            {
                IWebElement Button = GetButton(3);
                Button.Click();
                DropDownSelect AvailableLocalDropDown = new DropDownSelect(TimeZoneEditor.LanguageTimeZoneEditor, AvailableLocalesDropdown);
                Browser.SelectDropdown(AvailableLocalDropDown);
                int i;
                for (i = 0; i < TimeZoneEditor.N.Length; i++)
                {
                    Button ButtonI = new Button(TimeZoneEditor.N[i], 0);
                    GetTimeZone GetTimeZone = new GetTimeZone(ButtonI, TimeZoneEditorGrid);
                    IWebElement TimeZoneTxtBox = GetTimeZoneTextBox(GetTimeZone);
                    ClearAndFillTextBox TimeZoneClearNFill = new ClearAndFillTextBox(TimeZoneTxtBox, TimeZoneEditor.TimeZone[i]);
                    Browser.ClearAndFillTextBox(TimeZoneClearNFill);
                }
                SaveConfirm SaveConfirmI = new SaveConfirm(TimeZoneEditor.Save, 8);
                SaveConfirm(SaveConfirmI);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }        
        public void SaveConfirm(SaveConfirm SaveConfirm)
        {
            try
            {
                if (SaveConfirm.Save)
                {
                    Button Button = new Button(SaveConfirm.N, 0);
                    IWebElement SaveBtn = SaveButton(Button);
                    SaveBtn.Click();
                }
                Button ButtonI = new Button(SaveConfirm.N, 1);
                IWebElement CancelBtn = SaveButton(ButtonI);
                CancelBtn.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void LocalizeMenu(LocalizeMenu LocalizeMenu)
        {
            try
            {
                IWebElement Button = GetButton(4);
                Button.Click();
                DropDownSelect MenuAvailableLocalesDropDown = new DropDownSelect(LocalizeMenu.AvailableLocales, MenuAvailableLocalesDropdown);
                Browser.SelectDropdown(MenuAvailableLocalesDropDown);
                int i;
                for (i = 0; i < LocalizeMenu.SetLocalizeMenu.Length; i++)
                {
                    SetLocalizeMenu(LocalizeMenu.SetLocalizeMenu[i]);
                }
                SaveConfirm SaveConfirmI = new SaveConfirm(LocalizeMenu.Save, 8);
                SaveConfirm(SaveConfirmI);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void LocalizeModuleTitle(LocalizeModuleTitle LocalizeModuleTitle)
        {
            try
            {
                IWebElement Button = GetButton(5);
                Button.Click();
                DropDownSelect AvailableLocalesModuleTitleDropDown = new DropDownSelect(LocalizeModuleTitle.LocalesModuleTitle, AvailableLocalesModuleTitle);
                Browser.SelectDropdown(AvailableLocalesModuleTitleDropDown);
                int i;
                for (i = 0; i < LocalizeModuleTitle.N.Length; i++)
                {
                    Button ButtonI = new Button(LocalizeModuleTitle.N[i], 2);
                    GetTimeZone GetTimeZone = new GetTimeZone(ButtonI, LocalModuleTitleDiv);
                    IWebElement ModuleLocalTitleTextBox = GetTimeZoneTextBox(GetTimeZone);
                    ClearAndFillTextBox ModuleLocalTitleClearNFill = new ClearAndFillTextBox(ModuleLocalTitleTextBox, LocalizeModuleTitle.ModuleLocalTitle[i]);
                    Browser.ClearAndFillTextBox(ModuleLocalTitleClearNFill);
                }
                SaveConfirm SaveConfirmI = new SaveConfirm(LocalizeModuleTitle.Save, 8);
                SaveConfirm(SaveConfirmI);
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
        public void EditLanguage(EditLanguage EditLanguage)
        {
            try
            {
                DropDownSelect DropDownPageSize = new DropDownSelect(EditLanguage.LanguageList, PageSizeDropdown);
                Browser.SelectDropdown(DropDownPageSize);
                IList<IWebElement> LanguageRow = SelectLanguageRowList(EditLanguage.N);
                IWebElement EnabledCheckBox = LanguageRow[2].FindElement(By.TagName("input"));
                IWebElement EditLanguageBtn = LanguageRow[3].FindElement(By.TagName("a"));
                IWebElement DeleteLanguage = LanguageRow[4].FindElement(By.TagName("a"));
                ChkBox EnableChkBox = new ChkBox(EditLanguage.Enable, EnabledCheckBox);
                Browser.CheckBox(EnableChkBox);
                if (EditLanguage.Edit)
                {
                    EditLanguageBtn.Click();
                    Browser.Wait();
                    IList<IWebElement> Divs = ListDiv.FindElements(By.TagName("div"));
                    IList<IWebElement> Tables = ListDiv.FindElements(By.TagName("table"));
                    //For AdminDefault[0] and Root[5] Local Resources
                    if (EditLanguage.AdminResources)
                    {
                        AdminRoot(Divs[0]);
                    }
                    else if (EditLanguage.RootResources)
                    {
                        AdminRoot(Divs[5]);
                    }
                    else if (EditLanguage.AdminModule)
                    {
                        AdminModules AdminModulesI = new AdminModules(Divs[10], 26, 104, 1);
                        AdminModules(AdminModulesI);
                    }
                    else if (EditLanguage.Modules)
                    {
                        PortalModules PortalModulesI = new PortalModules(Divs[10], 47, 162, 0, 2, 0);
                        PortalModules(PortalModulesI);
                    }
                    else if (EditLanguage.XMLClient)
                    {
                        XMLClientResources XMLClientResourcesI = new XMLClientResources(Divs, 187, 0);
                        XMLClientResources(XMLClientResourcesI);
                        //FillKeyValues("simple", Keyvalue, ResourceFile, Back);
                        FillKeyValues(EditLanguage.FillKeyValues);
                    }
                }
                else if (EditLanguage.Delete)
                {
                    DeleteLanguage.Click();
                    DeleteConfirm(EditLanguage.DelConfirm);
                }           
            }
            catch (Exception ex)
            {
                //throw ex;
            }            
        }      
        public void FillKeyValues(FillKeyValues FillKeyValues)
        {
            try
            {
                int i;
                IWebElement Tbody = KeyValueTable.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                for (i = 1; i < Tr.Count; i++)
                {
                    IList<IWebElement> Td = Tr[i].FindElements(By.TagName("td"));
                    switch (FillKeyValues.Edit)
                    {
                        case "simple":
                            {
                                IWebElement TextArea = Td[1].FindElement(By.TagName("textarea"));
                                ClearAndFillTextBox TextAreaClearNFill = new ClearAndFillTextBox(TextArea, FillKeyValues.KeyValue[i - 1]);
                                Browser.ClearAndFillTextBox(TextAreaClearNFill);
                                break;
                            }
                        default:
                            {
                                IWebElement CKEditor = Td[2].FindElement(By.TagName("label"));
                                CKEditor.Click();
                                break;
                            }
                    }
                }
                IList<IWebElement> Divs = LanguageContentDiv.FindElements(By.TagName("div"));
                IList<IWebElement> Label = Divs[1].FindElements(By.TagName("label"));
                IWebElement BackBtn = ButtonDiv.FindElement(By.TagName("label"));
                switch (FillKeyValues.ResourceFile)
                {
                    case "Save":
                        {
                            Label[1].Click();
                            break;
                        }
                    case "Delete":
                        {
                            Label[0].Click();
                            break;
                        }
                }
                if (FillKeyValues.Back)
                {
                    BackBtn.Click();
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }          
        }     
        public void PortalModules(PortalModules PortalModules)
        {
            // i:31 , j:120 (BreadCrumb)|| i:34, j:128 (ContactUs)|| i:40, j:143 (Language Switcher)|| i:43, j:151 (Password Recovery)|| i:47, j:162 (User Registration)
            try
            {
                IList<IWebElement> Div = PortalModules.Divs.FindElements(By.TagName("div"));
                IList<IWebElement> Tables = PortalModules.Divs.FindElements(By.TagName("table"));
                IList<IWebElement> ExpandTable = ExpandTables(Tables[PortalModules.I]);
                IWebElement ExpandModuleFolder = ExpandTable[1].FindElement(By.TagName("a"));
                ExpandModuleFolder.Click();
                IList<IWebElement> TableI = Div[PortalModules.J].FindElements(By.TagName("table"));
                IList<IWebElement> DivI = Div[PortalModules.J].FindElements(By.TagName("div"));
                //string Text = Div[120].GetAttribute("style");
                switch (PortalModules.I)
                {
                    case 34:
                        {
                            //(k,l): (2, 0) || (8, 2)
                            IList<IWebElement> ExpandTableI = ExpandTables(TableI[PortalModules.L]);
                            IWebElement ExpandResource = ExpandTableI[2].FindElement(By.TagName("a"));
                            ExpandResource.Click();
                            EditResources EditResourcesI = new EditResources(DivI[PortalModules.K], PortalModules.ResourceNo, 4);
                            EditResources(EditResourcesI);
                            break;
                        }
                    default:
                        {
                            IList<IWebElement> ExpandTableI = ExpandTables(TableI[0]);
                            IWebElement ExpandResource = ExpandTableI[2].FindElement(By.TagName("a"));
                            ExpandResource.Click();
                            EditResources EditResourcesI = new EditResources(DivI[2], PortalModules.ResourceNo, 4);
                            EditResources(EditResourcesI);
                            break;
                            ////IList<IWebElement> DivII = DivI[2].FindElements(By.TagName("div"));          
                        }
                }       
            }
            catch (Exception ex)
            {
               // throw ex;
            }            
        }      
        public void EditResources(EditResources EditResources)
        {
            try
            {
                IList<IWebElement> TableII = EditResources.DivI.FindElements(By.TagName("table"));
                IList<IWebElement> ResourcesEditList = ExpandTables(TableII[EditResources.ResourceNo]);
                IWebElement ResourcesEdit = ResourcesEditList[EditResources.N].FindElement(By.TagName("a"));
                ResourcesEdit.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void AdminModules(AdminModules AdminModules)
        {
            //For AdminModules
            //j : 2,i : 0(Adsense), j : 13,i : 3(CSS Management), j : 24,i : 6(EventViewer), j : 35,i : 9(Extensions), j : 67,i : 16(Login Control), j : 82,i : 20(MessageManagement), j : 93,i : 23(TaskToDo), j : 104,i : 26(UserManagement)            
            try
            {
                EditResources EditResourcesI = new EditResources(AdminModules.Divs, 0, 1);
                EditResources(EditResourcesI);
                IList<IWebElement> DivII = AdminModules.Divs.FindElements(By.TagName("div"));
                EditResources EditResourcesII = new EditResources(DivII[1], AdminModules.I, 2);
                EditResources(EditResourcesII);
                IList<IWebElement> DivIII = DivII[1].FindElements(By.TagName("div"));
                EditResources EditResourcesIII = new EditResources(DivIII[AdminModules.J], 0, 5);
                EditResources(EditResourcesIII);
                //EditResources(DivII[1], 0, 5);
                IList<IWebElement> DivIV = DivIII[AdminModules.J].FindElements(By.TagName("div"));
                EditResources EditResourcesIV = new EditResources(DivIV[3], 0, 5);
                EditResources(EditResourcesIV);
                if (AdminModules.I == 9)
                {
                    EditResources EditResourcesV = new EditResources(DivIII[44], AdminModules.K, 6);
                    EditResources(EditResourcesV);
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public IList<IWebElement> ExpandTables( IWebElement Table)
        {
            try
            {
                IWebElement Tbody = Table.FindElement(By.TagName("tbody"));
                IWebElement Tr = Tbody.FindElement(By.TagName("tr"));
                IList<IWebElement> Td = Tr.FindElements(By.TagName("td"));
                //IWebElement ExpandLink = Td[i].FindElement(By.TagName("a"));
                return Td;
            }
            catch (Exception ex)
            {
                return null;
                //throw ex;
            }
        }
        public void AdminRoot(IWebElement Div)
        {
            try
            {
                EditResources EditResourcesI = new EditResources(Div, 0, 1);
                EditResources(EditResourcesI);
                IList<IWebElement> DivI = Div.FindElements(By.TagName("div"));
                EditResources EditResourcesII = new EditResources(DivI[1], 0, 3);
                EditResources(EditResourcesII);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void XMLClientResources(XMLClientResources XMLClientResources)
        {
            //j: 183(For XML)|| j: 187(For Client)    
            try
            {
                EditResources EditResourcesI = new EditResources(XMLClientResources.Divs[XMLClientResources.J], XMLClientResources.N, 2);
                EditResources(EditResourcesI);
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }      
    }
}
