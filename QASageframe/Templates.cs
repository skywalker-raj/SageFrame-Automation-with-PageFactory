using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Windows.Forms;
namespace QASageframe
{
    #region
    public class GetSpan
    {
        public int FileNo { get; set; }
        public int N { get; set; }
        public GetSpan(int fileno, int n)
        {
            FileNo = fileno;
            N = n;
        }
    }
    public class Expand
    {
        public IList<IWebElement> ListTemplate { get; set; }
        public int Templateno { get; set; }
        public int Directoryno { get; set; }
        public Expand(IList<IWebElement> listTemplate, int templateno, int directoryno)
        {
            ListTemplate = listTemplate;
            Templateno = templateno;
            Directoryno = directoryno;
        }
    }
    public class Preset
    {
        public int Templateno { get; set; }
        public bool PresetI { get; set; }
        public bool PresetCustomize { get; set; }
        public int LayoutNo { get; set; }
        public string PresetType { get; set; }
        public int[] Pages { get; set; }
        public int WidthNo { get; set; }
        public bool ConfirmPresetSave { get; set; }
        public Preset(int templateno, bool preseti, bool presetcustomize, int layoutno, string presettype, int[] pages, int widthno, bool confirmpresetsave)
        {
            Templateno = templateno;
            PresetI = preseti;
            PresetCustomize = presetcustomize;
            LayoutNo = layoutno;
            PresetType = presettype;
            Pages = pages;
            WidthNo = widthno;
            ConfirmPresetSave = confirmpresetsave;
        }
    }
    public class Layout
    {
        public int Templateno { get; set; }
        public bool LayoutEdit { get; set; }
        public bool LayoutManager { get; set; }
        public bool LayoutPreset { get; set; }
        public bool Pages { get; set; }
        public string LayoutI { get; set; }
        public bool CreateLayout { get; set; }
        public string CloneLayout { get; set; }
        public string NewLayoutName { get; set; }
        public string Placeholder { get; set; }
        public bool LayoutDelete { get; set; }
        public bool ConfirmDelete { get; set; }
        public bool Layoutedit { get; set; }
        public string[] Split { get; set; }
        public string[] SplitLink { get; set; }
        public bool ConfirmSave { get; set; }
        public Layout(int templateno, bool layoutEdit, bool layoutmanager, bool layoutpreset, bool pages, string layouti, bool createlayout, string clonelayout, string newlayoutname, string placeholder, bool layoutdelete, bool confirmdelete, bool layoutedit, string[] split, string[] splitlink, bool confirmsave)
        {
            Templateno = templateno;
            LayoutEdit = layoutEdit;
            LayoutManager = layoutmanager;
            LayoutPreset = layoutpreset;
            Pages = pages;
            LayoutI = layouti;
            CreateLayout = createlayout;
            CloneLayout = clonelayout;
            NewLayoutName = newlayoutname;
            Placeholder = placeholder;
            LayoutDelete = layoutdelete;
            ConfirmDelete = confirmdelete;
            Layoutedit = layoutedit;
        }
    }
    public class TemplateFileEditor
    {
        public int ListNo { get; set; }
        public int TemplateNo { get; set; }
        public bool TemplateFile { get; set; }
        public int EditTemplateNo { get; set; }
        public int DirectoryNo { get; set; }
        public string FilePath { get; set; }
        public bool AddFile { get; set; }
        public bool DeleteFile { get; set; }
        public bool AddFolder { get; set; }
        public bool DeleteFolder { get; set; }
        public bool Copy { get; set; }
        public bool Move { get; set; }
        public bool Refresh { get; set; }
        public int FileNo { get; set; }
        public string FolderName { get; set; }
        public int DeleteTemplateNo { get; set; }
        public int DelDirectoryNo { get; set; }
        public bool ConfirmDel { get; set; }
        public int CTTemplateNo { get; set; }
        public int CTDirectoryNo { get; set; }
        public int CopyFileNo { get; set; }
        public int MoveFileNo { get; set; }
        public int MTemplateNo { get; set; }
        public int MDirectoryNo { get; set; }
        public bool EditFile { get; set; }
        public int EditFileNo { get; set; }
        public string EditFileName { get; set; }
        public bool DelFile { get; set; }
        public int DelFileNo { get; set; }
        public int EditTemplateno { get; set; }
        public int EditDirectoryNo { get; set; }
        public int DelTemplateNo { get; set; }
        public int DeleteDirectoryNo { get; set; }
        public bool SearchFile { get; set; }
        public string SearchText { get; set; }
        public bool UpdateFile { get; set; }
        public int UpdateTemplateNo { get; set; }
        public int UpdateDirectoryNo { get; set; }
        public string FileContent { get; set; }
        public TemplateFileEditor(int listno, int templateno, bool templatefile, int editTemplateno, int directoryno, string filepath, bool addfile, bool deletefile, bool addfolder, bool deletefolder, bool copy, bool move, bool refresh, int fileno, string foldername, int deletetemplateno, int deldirectoryno, bool confirmdel, int cttemplateno, int CTdirectoryno, int copyfileno, int movefileno, int mtemplateno, int mdirectoryno, bool editfile, int editfileno, string editfilename, bool delfile, int delfileno, int edittemplateno, int editdirectoryno, int deltemplateno, int deletedirectoryno, bool searchfile, string searchtext, bool updateFile, int updateTemplateno, int updatedirectoryno, string filecontent)
        {
            ListNo = listno;
            TemplateNo = templateno;
            TemplateFile = templatefile;
            EditTemplateNo = editTemplateno;
            DirectoryNo = directoryno;
            FilePath = filepath;
            AddFile = addfile;
            DeleteFile = deletefile;
            AddFolder = addfolder;
            DeleteFolder = deletefolder;
            Copy = copy;
            Move = move;
            Refresh = refresh;
            FileNo = fileno;
            FolderName = foldername;
            DeleteTemplateNo = deletetemplateno;
            DelDirectoryNo = deldirectoryno;
            ConfirmDel = confirmdel;
            CTTemplateNo = cttemplateno;
            CTDirectoryNo = CTdirectoryno;
            CopyFileNo = copyfileno;
            MoveFileNo = movefileno;
            MTemplateNo = mtemplateno;
            MDirectoryNo = mdirectoryno;
            EditFile = editfile;
            EditFileNo = editfileno;
            EditFileName = editfilename;
            DelFile = delfile;
            DelFileNo = delfileno;
            EditTemplateno = edittemplateno;
            EditDirectoryNo = editdirectoryno;
            DelTemplateNo = deltemplateno;
            DeleteDirectoryNo = deletedirectoryno;
            SearchFile = searchfile;
            UpdateFile = updateFile;
            UpdateTemplateNo = updateTemplateno;
            UpdateDirectoryNo = updatedirectoryno;
            FileContent = filecontent;
        }
    }
    #endregion
    public static class Templates
    {
        public static TemplatePage TemplatePage
        {
            get
            {
                var templatepage = new TemplatePage();
                PageFactory.InitElements(Browser.Driver, templatepage);
                return templatepage;
            }
        }
    }
    public class TemplatePage
    {
        public string Url = "Admin/Templates.aspx";
        public string Text = "Templates";
        public string TemplateSave = "Template has been activated successfully.";
        public string FileAdded = "File successfully uploaded.";
        public string FileDeleted = "File Deleted Successfully.";
        public string FolderDeleted = "Folder deleted successfully.";
        #region
        [FindsBy(How = How.Id, Using = "lnkActivate#Default")][CacheLookup]
        public IWebElement DefaultLayoutActivate { get; set; }
        [FindsBy(How = How.Id, Using = "lnkActivate#Boxed-Layout")][CacheLookup]
        public IWebElement BoxedLayoutActivate { get; set; }
        [FindsBy(How = How.Id, Using = "lnkActivate#Left-Layout")][CacheLookup]
        public IWebElement LeftLayoutActivate { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_fupUploadTemp")][CacheLookup]
        public IWebElement BrowseTemplate { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_btnUpload")][CacheLookup]
        public IWebElement UploadTemplate { get; set; }
        [FindsBy(How = How.Id, Using = "btnCreateTemplate")][CacheLookup]
        public IWebElement CreateTemplate { get; set; }
        [FindsBy(How = How.Id, Using = "txtNewTemplate")][CacheLookup]
        public IWebElement NewTemplateText { get; set; }
        [FindsBy(How = How.Id, Using = "btnSaveTemplate")][CacheLookup]
        public IWebElement SaveNewTemplate { get; set; }
        [FindsBy(How = How.Id, Using = "templateList")][CacheLookup]
        public IWebElement TemplateId { get; set; }
        [FindsBy(How = How.Id, Using = "divFileTree")][CacheLookup]
        public IWebElement TemplateFileTree { get; set; }
        [FindsBy(How = How.Id, Using = "divControls")][CacheLookup]
        public IWebElement DivControls { get; set; }
        [FindsBy(How = How.Id, Using = "divSearch")][CacheLookup]
        public IWebElement DivSearch { get; set; }
        [FindsBy(How = How.TagName, Using = "body")][CacheLookup]
        public IWebElement body { get; set; }
        [FindsBy(How = How.Id, Using = "uploadFilePopUp")][CacheLookup]
        public IWebElement FileUploadDiv { get; set; }
        [FindsBy(How = How.Id, Using = "fileUpload")][CacheLookup]
        public IWebElement FileUpload { get; set; }
        [FindsBy(How = How.Id, Using = "fileList")]
        public IWebElement FileList { get; set; }
        [FindsBy(How = How.Id, Using = "txtFolderName")][CacheLookup]
        public IWebElement FolderNameText { get; set; }
        [FindsBy(How = How.Id, Using = "btnCreateFolder")][CacheLookup]
        public IWebElement CreateFolder { get; set; }
        [FindsBy(How = How.Id, Using = "btnConfirmYes")][CacheLookup]
        public IWebElement DeleteFolderConfirm { get; set; }
        [FindsBy(How = How.Id, Using = "btnConfirmNo")][CacheLookup]
        public IWebElement DeleteFolderCancel { get; set; }
        [FindsBy(How = How.Id, Using = "btnCopy")][CacheLookup]
        public IWebElement CopyFile { get; set; }
        [FindsBy(How = How.Id, Using = "txtEditFileName")][CacheLookup]
        public IWebElement EditFileNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnUpdateFile")][CacheLookup]
        public IWebElement UpdateFileBtn { get; set; }
        [FindsBy(How = How.Id, Using = "txtSearch")][CacheLookup]
        public IWebElement SearchTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "imbSearch")][CacheLookup]
        public IWebElement SearchBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ddlPageSize")][CacheLookup]
        public IWebElement ListPage { get; set; }
        [FindsBy(How = How.Id, Using = "downloadFile")][CacheLookup]
        public IWebElement DownloadFile { get; set; }
        [FindsBy(How = How.Id, Using = "divEditFile")][CacheLookup]
        public IWebElement EditFileDiv { get; set; }
        [FindsBy(How = How.Id, Using = "lblSaveDocument")][CacheLookup]
        public IWebElement SaveDocument { get; set; }
        [FindsBy(How = How.Id, Using = "popup_ok")][CacheLookup]
        public IWebElement Ok { get; set; }
        //LayoutManager
        [FindsBy(How = How.Id, Using = "ddlLayoutList")][CacheLookup]
        public IWebElement LayoutDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "imgAddLayout")][CacheLookup]
        public IWebElement AddLayout { get; set; }
        [FindsBy(How = How.Id, Using = "imgEditLayout_Visual")][CacheLookup]
        public IWebElement EditLayout { get; set; }
        [FindsBy(How = How.Id, Using = "btnDeleteLayout")][CacheLookup]
        public IWebElement DeleteLayout { get; set; }
        [FindsBy(How = How.Id, Using = "ddlClonebleLayouts")][CacheLookup]
        public IWebElement CloneLayoutDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "txtNewLayoutName")][CacheLookup]
        public IWebElement LayoutNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "btnCreateLayout")][CacheLookup]
        public IWebElement CreateLayout { get; set; }
        [FindsBy(How = How.Id, Using = "Div2")][CacheLookup]
        public IWebElement LayoutDiv { get; set; }
        [FindsBy(How = How.Id, Using = "popup_cancel")][CacheLookup]
        public IWebElement Cancel { get; set; }
        [FindsBy(How = How.Id, Using = "lblSaveLayoutChange")][CacheLookup]
        public IWebElement SaveLayout { get; set; }
        [FindsBy(How = How.Id, Using = "lblCancelEditMode")][CacheLookup]
        public IWebElement CancelLayout { get; set; }
        //Preset
        [FindsBy(How = How.Id, Using = "activeLayoutList")][CacheLookup]
        public IWebElement DropdownID { get; set; }
        [FindsBy(How = How.Id, Using = "spnSavePagePreset")][CacheLookup]
        public IWebElement ApplyPreset { get; set; }
        [FindsBy(How = How.Id, Using = "activeWidthList")][CacheLookup]
        public IWebElement WidthID { get; set; }
        [FindsBy(How = How.Id, Using = "btnSavePreset")][CacheLookup]
        public IWebElement SavePreset { get; set; }
        [FindsBy(How = How.Id, Using = "lblCancelEditMode")][CacheLookup]
        public IWebElement CancelEditMode { get; set; }
        #endregion
        public void CreateNewTemplate(string TemplateName)
        {
            try
            {
                CreateTemplate.Click();
                ClearAndFillTextBox NewTemplateNameClearNFill = new ClearAndFillTextBox(NewTemplateText, TemplateName);
                Browser.ClearAndFillTextBox(NewTemplateNameClearNFill);
                SaveNewTemplate.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void Expand(Expand Expand)
        {
            try
            {
                IWebElement jQueryFileTree = Expand.ListTemplate[Expand.Templateno].FindElement(By.TagName("ul"));
                IList<IWebElement> listDirectory = jQueryFileTree.FindElements(By.TagName("li"));
                IWebElement DirectoryLink = listDirectory[Expand.Directoryno].FindElement(By.TagName("a"));
                string listDirectorytext = listDirectory[Expand.Directoryno].GetAttribute("class");
                if (listDirectorytext == "directory collapsed")
                {
                    DirectoryLink.Click();
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
        public IList<IWebElement> ExpandTemplate(int Templateno)
        {
            try
            {
                IWebElement ulistTemplate = TemplateFileTree.FindElement(By.TagName("ul"));
                IList<IWebElement> listTemplate = ulistTemplate.FindElements(By.TagName("li"));
                IWebElement TemplateFileLink = listTemplate[Templateno].FindElement(By.TagName("a"));
                string listTemplateText = listTemplate[Templateno].GetAttribute("class");
                if (listTemplateText == "directory collapsed")
                {
                    TemplateFileLink.Click();
                }
                return listTemplate;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }         
        }
        public IWebElement GetSpan(GetSpan GetSpan)
        {
            try
            {
                IWebElement tbody = FileList.FindElement(By.TagName("tbody"));
                IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> td = tr[GetSpan.FileNo].FindElements(By.TagName("td"));
                IWebElement span = td[GetSpan.N].FindElement(By.TagName("span"));
                return span;
            }
            catch (Exception ex)
            {
                return null;
                // throw ex;
            }            
        }
        public void TemplateFileEditor(TemplateFileEditor TemplateFileEditor)
        {
            try
            {
                IList<IWebElement> TemplateDiv = TemplateId.FindElements(By.TagName("div"));
                IWebElement Link = TemplateDiv[TemplateFileEditor.TemplateNo].FindElement(By.TagName("a"));
                Browser.MouseMovement(Link);
                IList<IWebElement> ButtonWrapper = TemplateDiv[TemplateFileEditor.TemplateNo].FindElements(By.TagName("div"));
                string buttonwrappertext = ButtonWrapper[1].GetAttribute("class");
                IWebElement ul = ButtonWrapper[1].FindElement(By.TagName("ul"));
                IWebElement EditFiles = ul.FindElement(By.ClassName("sfEditfiles"));
                string liText = EditFiles.GetAttribute("class");
                if (TemplateFileEditor.TemplateFile)
                {
                    IWebElement EditFilesLink = EditFiles.FindElement(By.Id("lnkEditFiles"));
                    EditFilesLink.Click();
                    Browser.Wait();
                    DropDownSelect ListPageDropDown = new DropDownSelect(TemplateFileEditor.ListNo.ToString(), ListPage);
                    Browser.SelectDropdown(ListPageDropDown);
                    IList<IWebElement> listTemplate = ExpandTemplate(TemplateFileEditor.EditTemplateNo);
                    Expand ExpandI = new Expand(listTemplate, TemplateFileEditor.EditTemplateNo, TemplateFileEditor.DirectoryNo);
                    Expand(ExpandI);
                    IWebElement ulControls = DivControls.FindElement(By.TagName("ul"));
                    IList<IWebElement> Controls = ulControls.FindElements(By.TagName("li"));
                    //IWebElement DeleteFile = ulControls.FindElements(By.LinkText("Delete File"));
                    //IWebElement AddFolder = ulControls.FindElements(By.LinkText("Add Folder"));
                    //IWebElement DeleteFolder = ulControls.FindElements(By.LinkText("Delete Folder"));
                    //IWebElement Copy = ulControls.FindElements(By.LinkText("Copy"));
                    //IWebElement Move = ulControls.FindElements(By.LinkText("Move"));
                    //IWebElement Refresh = ulControls.FindElements(By.LinkText("Refresh"));
                    if (TemplateFileEditor.DeleteFile)
                    {
                        GetSpan GetSpanI = new GetSpan(TemplateFileEditor.FileNo, 0);
                        IWebElement span = GetSpan(GetSpanI);
                        IWebElement check = span.FindElement(By.TagName("input"));
                        ChkBox DeleteFileChk = new ChkBox(TemplateFileEditor.DeleteFile, check);
                        Browser.CheckBox(DeleteFileChk);
                        Controls[1].Click();
                        switch (TemplateFileEditor.ConfirmDel)
                        {
                            case true:
                                {
                                    DeleteFolderConfirm.Click();
                                    IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                                    IsAt isat = new IsAt(FileDeleted, Message.Text);
                                    Assert.IsTrue(Browser.IsAt(isat));
                                    break;
                                }
                            default:
                                {
                                    DeleteFolderCancel.Click();
                                    break;
                                }
                        }
                    }
                    if (TemplateFileEditor.SearchFile)
                    {
                        ClearAndFillTextBox SearchClearNFill = new ClearAndFillTextBox(SearchTextBox, TemplateFileEditor.SearchText);
                        Browser.ClearAndFillTextBox(SearchClearNFill);
                        SearchBtn.Click();
                    }
                    if (TemplateFileEditor.AddFolder)
                    {
                        Controls[2].Click();
                        ClearAndFillTextBox FolderNameClearNFill = new ClearAndFillTextBox(FolderNameText, TemplateFileEditor.FolderName);
                        Browser.ClearAndFillTextBox(FolderNameClearNFill);
                        CreateFolder.Click();
                    }
                    if (TemplateFileEditor.DeleteFolder)
                    {
                        IList<IWebElement> listTemplate0 = ExpandTemplate(TemplateFileEditor.DeleteTemplateNo);
                        IWebElement DelTemplateFileLink = listTemplate0[TemplateFileEditor.DeleteTemplateNo].FindElement(By.TagName("a"));
                        string DellistTemplateText = listTemplate0[TemplateFileEditor.DeleteTemplateNo].GetAttribute("class");
                        if (DellistTemplateText == "directory collapsed")
                        {
                            DelTemplateFileLink.Click();
                        }
                        Expand ExpandII = new Expand(listTemplate0, TemplateFileEditor.DeleteTemplateNo, TemplateFileEditor.DelDirectoryNo);
                        Expand(ExpandII);
                        Controls[3].Click();
                        switch (TemplateFileEditor.ConfirmDel)
                        {
                            case true:
                                {
                                    DeleteFolderConfirm.Click();
                                    IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                                    IsAt isat = new IsAt(FolderDeleted, Message.Text);
                                    Assert.IsTrue(Browser.IsAt(isat));
                                    break;
                                }
                            default:
                                {
                                    DeleteFolderCancel.Click();
                                    break;
                                }
                        }
                    }
                    if (TemplateFileEditor.Copy)
                    {
                        GetSpan GetSpanI = new GetSpan(TemplateFileEditor.CopyFileNo, 0);
                        IWebElement span = GetSpan(GetSpanI);
                        IWebElement check = span.FindElement(By.TagName("input"));
                        ChkBox CopyChk = new ChkBox(TemplateFileEditor.Copy, check);
                        Browser.CheckBox(CopyChk);
                        Controls[4].Click();
                        IList<IWebElement> listTemplate1 = ExpandTemplate(TemplateFileEditor.CTTemplateNo);
                        IWebElement CTTemplateFileLink = listTemplate1[TemplateFileEditor.CTTemplateNo].FindElement(By.TagName("a"));
                        string CTlistTemplateText = listTemplate1[TemplateFileEditor.CTTemplateNo].GetAttribute("class");
                        if (CTlistTemplateText == "directory collapsed")
                        {
                            CTTemplateFileLink.Click();
                        }
                        Expand ExpandIII = new Expand(listTemplate1, TemplateFileEditor.CTTemplateNo, TemplateFileEditor.CTDirectoryNo);
                        Expand(ExpandIII);
                        CopyFile.Click();
                    }
                    if (TemplateFileEditor.Move)
                    {
                        GetSpan GetSpanI = new GetSpan(TemplateFileEditor.MoveFileNo, 0);
                        IWebElement span = GetSpan(GetSpanI);
                        IWebElement check = span.FindElement(By.TagName("input"));
                        if (!check.Selected)
                        {
                            check.Click();
                        }
                        Controls[5].Click();
                        IList<IWebElement> listTemplate3 = ExpandTemplate(TemplateFileEditor.MTemplateNo);
                        IWebElement MTemplateFileLink = listTemplate3[TemplateFileEditor.MTemplateNo].FindElement(By.TagName("a"));
                        string MlistTemplateText = listTemplate3[TemplateFileEditor.MTemplateNo].GetAttribute("class");
                        if (MlistTemplateText == "directory collapsed")
                        {
                            MTemplateFileLink.Click();
                        }
                        Expand ExpandIV = new Expand(listTemplate3, TemplateFileEditor.MTemplateNo, TemplateFileEditor.MDirectoryNo);
                        Expand(ExpandIV);
                        CopyFile.Click();
                    }
                    if (TemplateFileEditor.AddFile)
                    {
                        Controls[0].Click();
                        FileUpload.SendKeys(TemplateFileEditor.FilePath);
                        //FileUpload.Click();
                        //SendKeys.SendWait(filepath);
                        //SendKeys.SendWait(@"{Enter}");
                    }
                    if (TemplateFileEditor.Refresh)
                    {
                        Controls[6].Click();
                    }
                    if (TemplateFileEditor.EditFile)
                    {
                        IList<IWebElement> listTemplate2 = ExpandTemplate(TemplateFileEditor.EditTemplateno);
                        IWebElement editTemplateFileLink = listTemplate2[TemplateFileEditor.EditTemplateno].FindElement(By.TagName("a"));
                        string editlistTemplateText = listTemplate2[TemplateFileEditor.EditTemplateno].GetAttribute("class");
                        if (editlistTemplateText == "directory collapsed")
                        {
                            editTemplateFileLink.Click();
                        }
                        Expand ExpandV = new Expand(listTemplate2, TemplateFileEditor.EditTemplateno, TemplateFileEditor.EditDirectoryNo);
                        Expand(ExpandV);
                        GetSpan GetSpanI = new GetSpan(TemplateFileEditor.EditFileNo, 4);
                        IWebElement span = GetSpan(GetSpanI);
                        IWebElement edit = span.FindElement(By.TagName("a"));
                        edit.Click();
                        EditFileNameTextBox.Click();
                        ClearAndFillTextBox EditFileNameClearNFill = new ClearAndFillTextBox(EditFileNameTextBox, TemplateFileEditor.EditFileName);
                        Browser.ClearAndFillTextBox(EditFileNameClearNFill);
                        UpdateFileBtn.Click();
                    }
                    if (TemplateFileEditor.DelFile)
                    {
                        IList<IWebElement> listTemplate4 = ExpandTemplate(TemplateFileEditor.DelTemplateNo);
                        IWebElement delTemplateFileLink = listTemplate4[TemplateFileEditor.DelTemplateNo].FindElement(By.TagName("a"));
                        string dellistTemplateText = listTemplate4[TemplateFileEditor.DelTemplateNo].GetAttribute("class");
                        if (dellistTemplateText == "directory collapsed")
                        {
                            delTemplateFileLink.Click();
                        }
                        Expand ExpandVI = new Expand(listTemplate4, TemplateFileEditor.DelTemplateNo, TemplateFileEditor.DeleteDirectoryNo);
                        Expand(ExpandVI);
                        IWebElement tbody = FileList.FindElement(By.TagName("tbody"));
                        IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                        IList<IWebElement> td = tr[TemplateFileEditor.FileNo].FindElements(By.TagName("td"));
                        IWebElement del = td[5].FindElement(By.TagName("a"));
                        del.Click();
                        switch (TemplateFileEditor.ConfirmDel)
                        {
                            case true:
                                {
                                    DeleteFolderConfirm.Click();
                                    break;
                                }
                            default:
                                {
                                    DeleteFolderCancel.Click();
                                    break;
                                }
                        }
                    }
                    if (TemplateFileEditor.UpdateFile)
                    {
                        IList<IWebElement> listTemplate5 = ExpandTemplate(TemplateFileEditor.UpdateTemplateNo);
                        IWebElement updateTemplateFileLink = listTemplate5[TemplateFileEditor.UpdateTemplateNo].FindElement(By.TagName("a"));
                        string updatelistTemplateText = listTemplate5[TemplateFileEditor.UpdateTemplateNo].GetAttribute("class");
                        if (updatelistTemplateText == "directory collapsed")
                        {
                            updateTemplateFileLink.Click();
                        }
                        Expand ExpandVII = new Expand(listTemplate5, TemplateFileEditor.UpdateTemplateNo, TemplateFileEditor.UpdateDirectoryNo);
                        Expand(ExpandVII);
                        IWebElement tbody = FileList.FindElement(By.TagName("tbody"));
                        IList<IWebElement> tr = tbody.FindElements(By.TagName("tr"));
                        IList<IWebElement> td = tr[TemplateFileEditor.DelFileNo].FindElements(By.TagName("td"));
                        IWebElement a = td[1].FindElement(By.TagName("a"));
                        IWebElement update = a.FindElement(By.TagName("span"));
                        update.Click();
                        IWebElement DivCodeMirror = EditFileDiv.FindElements(By.TagName("div"))[0];
                        IWebElement DivCodeMirrorScroll = DivCodeMirror.FindElements(By.TagName("div"))[1];
                        IWebElement DivRelative = DivCodeMirrorScroll.FindElement(By.TagName("div"));
                        IWebElement DivRelativeII = DivRelative.FindElements(By.TagName("div"))[1];
                        IWebElement DivCodeMirrorLines = DivRelativeII.FindElements(By.TagName("div"))[2];
                        IWebElement DivRelativeIII = DivCodeMirrorLines.FindElement(By.TagName("div"));
                        IWebElement DivEdit = DivRelativeIII.FindElement(By.TagName("div"));
                        //IWebElement pre = DivEdit.FindElements(By.TagName("pre"));                   
                        DivEdit.Click();
                        //pre[2].SendKeys(FileContent);
                        //DivEdit.Clear();
                        //DivEdit.SendKeys(FileContent);
                        SaveDocument.Click();
                        Ok.Click();
                        IWebElement DivEditMode = Browser.Driver.FindElement(By.Id("divEditMode"));
                        IWebElement Close = DivEditMode.FindElements(By.TagName("a"))[0];
                        IWebElement closespan = Close.FindElement(By.TagName("span"));
                        closespan.Click();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }         
        }
        public void Layout(Layout Layout)
        {
            try
            {
                IList<IWebElement> TemplateDiv = TemplateId.FindElements(By.TagName("div"));
                IWebElement Link = TemplateDiv[Layout.Templateno].FindElement(By.TagName("a"));
                IList<IWebElement> ButtonWrapper = TemplateDiv[Layout.Templateno].FindElements(By.TagName("div"));
                string buttonwrappertext = ButtonWrapper[1].GetAttribute("class");
                IWebElement ul = ButtonWrapper[1].FindElement(By.TagName("ul"));
                IWebElement TemplateCustomize = ul.FindElement(By.ClassName("sfTemplateCustomize"));
                string liText = TemplateCustomize.GetAttribute("class");
                if (Layout.LayoutEdit)
                {
                    Browser.MouseMovement(Link);
                    Browser.MouseMovement(TemplateCustomize);
                    IWebElement ulCustomize = TemplateCustomize.FindElement(By.TagName("ul"));
                    IList<IWebElement> li = ulCustomize.FindElements(By.TagName("li"));
                    if (Layout.LayoutManager)
                    {
                        li[2].Click();
                        if (Layout.CreateLayout)
                        {
                            AddLayout.Click();
                            SelectElement CloneLayoutSelect = new SelectElement(CloneLayoutDropdown);
                            CloneLayoutSelect.SelectByText(Layout.CloneLayout);
                            ClearAndFillTextBox LayoutNameClearNFill = new ClearAndFillTextBox(LayoutNameTextBox, Layout.NewLayoutName);
                            Browser.ClearAndFillTextBox(LayoutNameClearNFill);
                            //IWebElement DivCodeMirror = LayoutDiv.FindElements(By.TagName("div"))[1];
                            //string divcode = DivCodeMirror.GetAttribute("class");
                            //IWebElement DivCodeMirrorScroll = DivCodeMirror.FindElements(By.TagName("div"))[1];
                            //string divcodemirror = DivCodeMirrorScroll.GetAttribute("class");
                            //IWebElement DivRelative = DivCodeMirrorScroll.FindElement(By.TagName("div"));
                            //string divrelative = DivRelative.GetAttribute("style");
                            //IWebElement DivRelativeII = DivRelative.FindElements(By.TagName("div"))[1];
                            //string divrel = DivRelativeII.GetAttribute("style");
                            //IWebElement DivCodeMirrorLines = DivRelativeII.FindElements(By.TagName("div"))[2];
                            //string codemirrorlines = DivCodeMirrorLines.GetAttribute("class");
                            //IWebElement DivRelativeIII = DivCodeMirrorLines.FindElement(By.TagName("div"));
                            //string divrelativeii = DivRelativeIII.GetAttribute("style");
                            //IWebElement DivEdit = DivRelativeIII.FindElement(By.TagName("div"));
                            //string divedit = DivEdit.GetAttribute("style");
                            //DivEdit.Click();
                            //DivEdit.SendKeys(Placeholder);
                            CreateLayout.Click();
                        }
                        DropDownSelect DropDownLayout = new DropDownSelect(Layout.LayoutI, LayoutDropdown);
                        Browser.SelectDropdown(DropDownLayout);
                        if (Layout.Layoutedit)
                        {
                            int i;
                            for (i = 0; i < Layout.Split.Length; i++)
                            {
                                switch (Layout.Split[i])
                                {
                                    case "sfNavigation":
                                    case "sfLogo":
                                    case "sfLoginstatus":
                                        {
                                            IWebElement splitplaceholder = Browser.Driver.FindElement(By.Id(Layout.Split[i]));
                                            splitplaceholder.Click();
                                            IWebElement splitdiv = Browser.Driver.FindElement(By.Id("sfHeaders"));
                                            IWebElement divSplit = splitdiv.FindElement(By.TagName("div"));
                                            Browser.MouseMovement(divSplit);
                                            IWebElement splitID = Browser.Driver.FindElement(By.Id(Layout.SplitLink[0]));
                                            splitID.Click();
                                            break;
                                        }
                                    case "sfBanner":
                                        {
                                            IWebElement splitplaceholderDiv = Browser.Driver.FindElements(By.Id(Layout.Split[i]))[1];
                                            IWebElement splitplaceholder = splitplaceholderDiv.FindElement(By.TagName("div"));
                                            splitplaceholder.Click();
                                            //IWebElement splitdiv = Browser.Driver.FindElement(By.Id("sfBanner"));
                                            //IWebElement divSplit = splitdiv.FindElement(By.TagName("div"));
                                            Browser.MouseMovement(splitplaceholder);
                                            IWebElement splitID = Browser.Driver.FindElement(By.Id(Layout.SplitLink[1]));
                                            splitID.Click();
                                            break;
                                        }
                                    case "sfGetstarted":
                                        {
                                            IWebElement splitplaceholderDiv = Browser.Driver.FindElement(By.Id(Layout.Split[i]));
                                            IWebElement splitplaceholder = splitplaceholderDiv.FindElement(By.TagName("div"));
                                            splitplaceholder.Click();
                                            //IWebElement splitdiv = Browser.Driver.FindElement(By.Id("sfGetstarted"));
                                            //IWebElement divSplit = splitdiv.FindElement(By.TagName("div"));
                                            Browser.MouseMovement(splitplaceholder);
                                            IWebElement splitID = Browser.Driver.FindElement(By.Id(Layout.SplitLink[3]));
                                            splitID.Click();
                                            break;
                                        }
                                    case "sfContact":
                                    case "sfMap":
                                    case "sfWhyuse":
                                    case "sfMiddlemaincurrent":
                                        {
                                            IWebElement splitplaceholderDiv = Browser.Driver.FindElement(By.Id(Layout.Split[i]));
                                            IWebElement splitplaceholder = splitplaceholderDiv.FindElement(By.TagName("div"));
                                            splitplaceholder.Click();
                                            //IWebElement splitdiv = Browser.Driver.FindElement(By.Id(split[i]));
                                            //IWebElement divSplit = splitdiv.FindElement(By.TagName("div"));
                                            Browser.MouseMovement(splitplaceholder);
                                            IWebElement splitID = Browser.Driver.FindElement(By.Id(Layout.SplitLink[4]));
                                            splitID.Click();
                                            break;
                                        }
                                    //case "sfNavigation":
                                    //    {
                                    //        IWebElement splitplaceholderDiv = Browser.Driver.FindElements(By.Id(split[i]))[1];
                                    //        IWebElement splitplaceholder = splitplaceholderDiv.FindElement(By.TagName("div"));
                                    //        splitplaceholder.Click();
                                    //        //IWebElement splitdiv = Browser.Driver.FindElement(By.Id("sfNavigation"));
                                    //        //IWebElement divSplit = splitdiv.FindElement(By.TagName("div"));
                                    //        Browser.MouseMovement(splitplaceholder);
                                    //        IWebElement splitID = Browser.Driver.FindElement(By.Id(SplitLink[2]));
                                    //        splitID.Click();
                                    //        break;
                                    //    }
                                }
                            }
                            switch (Layout.ConfirmSave)
                            {
                                case true:
                                    {
                                        SaveLayout.Click();
                                        break;
                                    }
                                default:
                                    {
                                        CancelLayout.Click();
                                        break;
                                    }
                            }
                        }
                        if (Layout.LayoutDelete)
                        {
                            DeleteLayout.Click();
                            switch (Layout.ConfirmDelete)
                            {
                                case true:
                                    {
                                        Ok.Click();
                                        break;
                                    }
                                default:
                                    {
                                        Cancel.Click();
                                        break;
                                    }
                            }
                        }
                    }
                    if (Layout.LayoutPreset)
                    {
                        li[1].Click();
                    }
                    if (Layout.Pages)
                    {
                        IWebElement PageLink = li[0].FindElement(By.TagName("a"));
                        PageLink.Click();
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }        
        public void Preset(Preset Preset)
        {
            //IWebElement PresetLink = Browser.Driver.FindElement(By.Id("lnkPresets"));
            //PresetLink.Click();
            try
            {
                IList<IWebElement> TemplateDiv = TemplateId.FindElements(By.TagName("div"));
                IWebElement Link = TemplateDiv[Preset.Templateno].FindElement(By.TagName("a"));
                IList<IWebElement> ButtonWrapper = TemplateDiv[Preset.Templateno].FindElements(By.TagName("div"));
                string buttonwrappertext = ButtonWrapper[1].GetAttribute("class");
                IWebElement ul = ButtonWrapper[1].FindElement(By.TagName("ul"));
                IWebElement TemplateCustomize = ul.FindElement(By.ClassName("sfTemplateCustomize"));
                string liText = TemplateCustomize.GetAttribute("class");
                if (Preset.PresetI)
                {
                    Browser.MouseMovement(Link);
                    Browser.MouseMovement(TemplateCustomize);
                    IWebElement ulCustomize = TemplateCustomize.FindElement(By.TagName("ul"));
                    IList<IWebElement> li = ulCustomize.FindElements(By.TagName("li"));
                    if (Preset.PresetCustomize)
                    {
                        li[1].Click();
                        IWebElement ulDropdown = DropdownID.FindElement(By.TagName("ul"));
                        IWebElement liDropdown = ulDropdown.FindElements(By.TagName("li"))[Preset.LayoutNo];
                        IWebElement SelectDropdown = liDropdown.FindElement(By.TagName("select"));
                        SelectElement LayoutPreset = new SelectElement(SelectDropdown);
                        LayoutPreset.SelectByText(Preset.PresetType);
                        if (Preset.PresetType == "Custom")
                        {
                            IWebElement span = liDropdown.FindElement(By.TagName("span"));
                            IWebElement addpagespreset = span.FindElement(By.TagName("i"));
                            addpagespreset.Click();
                            int i;
                            for (i = 0; i < Preset.Pages.Length; i++)
                            {
                                //IWebElement PageTree = PageList.FindElement(By.Id("pageTree"));
                                IWebElement Page = Browser.Driver.FindElement(By.Id(Convert.ToString(Preset.Pages[0])));
                                IWebElement spanPage = Page.FindElement(By.TagName("span"));
                                spanPage.Click();
                            }
                            ApplyPreset.Click();
                        }
                        IWebElement ulWidth = WidthID.FindElement(By.TagName("ul"));
                        IWebElement liWidthSelect = ulWidth.FindElements(By.TagName("li"))[Preset.WidthNo];
                        string liWidthtext = liWidthSelect.GetAttribute("class");
                        if (liWidthtext != "sfCurve sfActive")
                        {
                            liWidthSelect.Click();
                        }
                        switch (Preset.ConfirmPresetSave)
                        {
                            case true:
                                {
                                    SavePreset.Click();
                                    break;
                                }
                            default:
                                {
                                    CancelEditMode.Click();
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }      
        public void SelectTemplate(int n)
        {
            Browser.Wait();
            try
            {
                IList<IWebElement> TemplateHolderDiv = TemplateId.FindElements(By.ClassName("sfTemplateholder"));
                IWebElement TemplateHumb = TemplateHolderDiv[n].FindElement(By.TagName("a"));
                Browser.MouseMovement(TemplateHumb);
                IWebElement ButtonWrapperDiv = TemplateHolderDiv[n].FindElements(By.TagName("div"))[1];
                IWebElement TemplateSetting = ButtonWrapperDiv.FindElement(By.TagName("ul"));
                IWebElement TemplateActivate = TemplateSetting.FindElement(By.ClassName("activate"));
                TemplateActivate.Click();
                Browser.Wait();
                IWebElement Message = Browser.Driver.FindElement(By.Id("spnMessage"));
                IsAt isat = new IsAt(Templates.TemplatePage.TemplateSave, Message.Text);
                Assert.IsTrue(Browser.IsAt(isat));
            }
            catch (Exception ex)
            {
               // throw ex;
            }
           
        }
    }        
}

