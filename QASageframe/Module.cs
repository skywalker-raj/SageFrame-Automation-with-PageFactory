using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Windows.Forms;
using System;
namespace QASageframe
{
    #region
    public class ModuleEditDeleteLink
    {
        public int N { get; set; }
        public int EditNo { get; set; }
        public ModuleEditDeleteLink(int n, int editno)
        {
            N = n;
            EditNo = editno;
        }
    }
    public class DownloadModule
    {
        public string Modules { get; set; }
        public bool Cancel { get; set; }
        public DownloadModule(string modules, bool cancel)
        {
            Modules = modules;
            Cancel = cancel;
        }
    }
    public class VersionSelect
    {
        public int VersionFirst { get; set; }
        public int VersionSecond { get; set; }
        public int VersionLast { get; set; }
        public IWebElement VersionFirstDropdown { get; set; }
        public IWebElement VersionSecondDropdown { get; set; }
        public IWebElement VersionLastDropdown { get; set; }
        public VersionSelect(int versionfirst, int versionsecond, int versionlast, IWebElement versionfirstdropdown, IWebElement versionseconddropdown, IWebElement versionlastdropdown)
        {
            VersionFirst = versionfirst;
            VersionSecond = versionsecond;
            VersionLast = versionlast;
            VersionFirstDropdown = versionfirstdropdown;
            VersionSecondDropdown = versionseconddropdown;
            VersionLastDropdown = versionlastdropdown;
        }
    }
    public class InstallModule
    {
        public string ModulePath { get; set; }
        public bool[] Next { get; set; }
        public bool AcceptLicense { get; set; }
        public bool Install { get; set; }
        public InstallModule(string modulepath, bool[] next, bool acceptlicense, bool install)
        {
            ModulePath = modulepath;
            Next = next;
            AcceptLicense = acceptlicense;
            Install = install;
        }
    }
    public class ModuleAddEdit
    {
        public string Source { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
        public string ControlType { get; set; }
        public string HelpUrl { get; set; }
        public bool Update { get; set; }
        public ModuleAddEdit(string source, string key, string title, string controltype, string helpurl, bool update)
        {
            Source = source;
            Key = key;
            Title = title;
            ControlType = controltype;
            HelpUrl = helpurl;
            Update = update;
        }
    }
    public class CompositePackage
    {
        public string PackageName { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public int VersionFirst { get; set; }
        public int VersionSecond { get; set; }
        public int VersionLast { get; set; }
        public string License { get; set; }
        public string ReleaseNotes { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string[] Modules { get; set; }
        public bool SwitchRight { get; set; }
        public bool DownloadConfirm { get; set; }
        public CompositePackage(string packagename, string friendlyname, string description, int versionfirst, int versionsecond, int versionlast, string license, string releasenotes, string owner, string organization, string url, string email, string[] modules, bool switchright, bool downloadconfirm)
        {
            PackageName = packagename;
            FriendlyName = friendlyname;
            Description = description;
            VersionFirst = versionfirst;
            VersionSecond = versionsecond;
            VersionLast = versionlast;
            License = license;
            ReleaseNotes = releasenotes;
            Owner = owner;
            Organization = organization;
            Url = url;
            Email = email;
            Modules = modules;
            SwitchRight = switchright;
            DownloadConfirm = downloadconfirm;
        }
    }
    public class EditModule
    {
        public string EditModuleI { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool IsActive { get; set; }
        public bool Save { get; set; }
        public bool EditModuleControlSettings { get; set; }
        public bool EditModuleDefinitionSettings { get; set; }
        public bool EditModuleSettings { get; set; }
        public bool EditModuleControls { get; set; }
        public bool AddModuleControls { get; set; }
        public bool EditModuleControl { get; set; }
        public ModuleAddEdit[] ModuleAddEdit { get; set; }
        public string[] Icon { get; set; }
        public bool DeleteModuleControl { get; set; }
        public bool DeleteControl { get; set; }
        public string Definition { get; set; }
        public string FriendlyName { get; set; }
        public int ModuleCache { get; set; }
        public string ModuleFolder { get; set; }
        public string BusinessControllerClass { get; set; }
        public string Dependencies { get; set; }
        public string Permission { get; set; }
        public bool IsPortable { get; set; }
        public bool IsSearchable { get; set; }
        public bool IsUpgradable { get; set; }
        public bool IsPremiumModule { get; set; }
        public string ModulePackageName { get; set; }
        public string ModuleDescription { get; set; }
        public string ModuleLicense { get; set; }
        public string ModuleReleaseNotes { get; set; }
        public string ModuleOwner { get; set; }
        public string ModuleOrganization { get; set; }
        public string ModuleUrl { get; set; }
        public string ModuleEmail { get; set; }
        public bool UpdateSave { get; set; }
        public bool UninstallModule { get; set; }
        public EditModule(string editmodulei, bool edit, bool delete, bool isactive, bool save, bool editmodulecontrolsettings, bool editmoduledefinitionsettings, bool editmodulesettings, bool editmodulecontrols, bool addmodulecontrols, bool editmodulecontrol, ModuleAddEdit[] moduleaddedit, string[] icon, bool deletemodulecontrol, bool deletecontrol, string definition, string friendlyname, int modulecache, string modulefolder, string businesscontrollerclass, string dependencies, string permission, bool isportable, bool issearchable, bool isupgradable, bool ispremiummodule, string modulepackagename, string moduledescription, string modulelicense, string modulereleasenotes, string moduleowner, string moduleorganization, string moduleurl, string moduleemail, bool updatesave, bool uninstallmodule)
        {
            EditModuleI = editmodulei;
            Edit = edit;
            Delete = delete;
            IsActive = isactive;
            Save = save;
            EditModuleControlSettings = editmodulecontrolsettings;
            EditModuleDefinitionSettings = editmoduledefinitionsettings;
            EditModuleSettings = editmodulesettings;
            EditModuleControls = editmodulecontrols;
            AddModuleControls = addmodulecontrols;
            EditModuleControl = editmodulecontrol;
            ModuleAddEdit = moduleaddedit;
            Icon = icon;
            DeleteModuleControl = deletemodulecontrol;
            DeleteControl = deletecontrol;
            Definition = definition;
            FriendlyName = friendlyname;
            ModuleCache = modulecache;
            ModuleFolder = modulefolder;
            BusinessControllerClass = businesscontrollerclass;
            Dependencies = dependencies;
            Permission = permission;
            IsPortable = isportable;
            IsSearchable = issearchable;
            IsUpgradable = isupgradable;
            IsPremiumModule = ispremiummodule;
            ModulePackageName = modulepackagename;
            ModuleDescription = moduledescription;
            ModuleLicense = modulelicense;
            ModuleReleaseNotes = modulereleasenotes;
            ModuleOwner = moduleowner;
            ModuleOrganization = moduleorganization;
            ModuleUrl = moduleurl;
            ModuleEmail = moduleemail;
            UpdateSave = updatesave;
            UninstallModule = uninstallmodule;
        }
    }
    public class CreateModule
    {
        public string Control { get; set; }
        public string Owner { get; set; }
        public string ModuleFolder { get; set; }
        public string Source { get; set; }
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public int VersionFirst { get; set; }
        public int VersionSecond { get; set; }
        public int VersionLast { get; set; }
        public string PackageLicense { get; set; }
        public string PackageReleaseNotes { get; set; }
        public string PackageOwner { get; set; }
        public string PackageOrganization { get; set; }
        public string PackageUrl { get; set; }
        public string PackageEmail { get; set; }
        public string ModuleKey { get; set; }
        public string ModuleTitle { get; set; }
        public string ModuleType { get; set; }
        public string Icon { get; set; }
        public string HelpUrl { get; set; }
        public bool Create { get; set; }
        public CreateModule(string control, string owner, string modulefolder, string source, string packagename, string packagedescription, int versionfirst, int versionsecond, int versionlast, string packagelicense, string packagereleasenotes, string packageowner, string packageorganization, string packageurl, string packageemail, string modulekey, string moduletitle, string moduletype, string icon, string helpurl, bool create)
        {
            Control = control;
            Owner = owner;
            ModuleFolder = modulefolder;
            Source = source;
            PackageName = packagename;
            PackageDescription = packagedescription;
            VersionFirst = versionfirst;
            VersionSecond = versionsecond;
            VersionLast = versionlast;
            PackageLicense = packagelicense;
            PackageReleaseNotes = packagereleasenotes;
            PackageOwner = packageowner;
            PackageOrganization = packageorganization;
            PackageUrl = packageurl;
            PackageEmail = packageemail;
            ModuleKey = modulekey;
            ModuleTitle = moduletitle;
            ModuleType = moduletype;
            Icon = icon;
            HelpUrl = helpurl;
            Create = create;
        }
    }
    public class CreatePackage
    {
        public string PackageName { get; set; }
        public string PackageDescription { get; set; }
        public int VersionFirst { get; set; }
        public int VersionSecond { get; set; }
        public int VersionLast { get; set; }
        public string PackageLicense { get; set; }
        public string PackageReleaseNotes { get; set; }
        public string PackageOwner { get; set; }
        public string PackageOrganization { get; set; }
        public string PackageUrl { get; set; }
        public string PackageEmail { get; set; }
        public string FriendlyName { get; set; }
        public string ModuleName { get; set; }
        public string BusinessControllerClass { get; set; }
        public string CompatibleVersion { get; set; }
        public int CacheTime { get; set; }
        public string ModuleFolder { get; set; }
        public bool[] Next { get; set; }
        public bool FileUploadInstall { get; set; }
        public string InstallFileUpload { get; set; }
        public string InstallScript { get; set; }
        public bool FileUploadUnistall { get; set; }
        public string UnistallFileUpload { get; set; }
        public string UnistallScript { get; set; }
        public bool IncludeSource { get; set; }
        public bool[] Previous { get; set; }
        public string[] FolderFiles { get; set; }
        public bool AllFilesSelect { get; set; }
        public string ViewControl { get; set; }
        public string ViewKey { get; set; }
        public string ViewTitle { get; set; }
        public string ViewIcon { get; set; }
        public string ViewHelpUrl { get; set; }
        public string EditControl { get; set; }
        public string EditKey { get; set; }
        public string EditTitle { get; set; }
        public string EditIcon { get; set; }
        public string EditHelpUrl { get; set; }
        public string SettingControl { get; set; }
        public string SettingKey { get; set; }
        public string SettingTitle { get; set; }
        public string SettingIcon { get; set; }
        public string SettingHelpUrl { get; set; }
        public string[] Assembly { get; set; }
        public bool Submit { get; set; }
        public CreatePackage(string packagename, string packagedescription, int versionfirst, int versionsecond, int versionlast, string packagelicense, string packagereleasenotes, string packageowner, string packageorganization, string packageurl, string packageemail, string friendlyname, string modulename, string businesscontrollerclass, string compatibleversion, int cachetime, string modulefolder, bool[] next, bool fileuploadinstall, string installfileupload, string installscript, bool fileuploadunistall, string unistallfileupload, string unistallscript, bool includesource, bool[] previous, string[] folderfiles, bool allfilesselect, string viewcontrol, string viewkey, string viewtitle, string viewicon, string viewhelpurl, string editcontrol, string editkey, string edittitle, string editicon, string edithelpurl, string settingcontrol, string settingkey, string settingtitle, string settingicon, string settinghelpurl, string[] assembly, bool submit)
        {
            PackageName = packagename;
            PackageDescription = packagedescription;
            VersionFirst = versionfirst;
            VersionSecond = versionsecond;
            VersionLast = versionlast;
            PackageLicense = packagelicense;
            PackageReleaseNotes = packagereleasenotes;
            PackageOwner = packageowner;
            PackageOrganization = packageorganization;
            PackageUrl = packageurl;
            PackageEmail = packageemail;
            FriendlyName = friendlyname;
            ModuleName = modulename;
            BusinessControllerClass = businesscontrollerclass;
            CompatibleVersion = compatibleversion;
            CacheTime = cachetime;
            ModuleFolder = modulefolder;
            Next = next;
            FileUploadInstall = fileuploadinstall;
            InstallFileUpload = installfileupload;
            InstallScript = installscript;
            FileUploadUnistall = fileuploadunistall;
            UnistallFileUpload = unistallfileupload;
            UnistallScript = unistallscript;
            IncludeSource = includesource;
            Previous = previous;
            FolderFiles = folderfiles;
            AllFilesSelect = allfilesselect;
            ViewControl = viewcontrol;
            ViewKey = viewkey;
            ViewTitle = viewtitle;
            ViewIcon = viewicon;
            ViewHelpUrl = viewhelpurl;
            EditControl = editcontrol;
            EditKey = editkey;
            EditTitle = edittitle;
            EditIcon = editicon;
            EditHelpUrl = edithelpurl;
            SettingControl = settingcontrol;
            SettingKey = settingkey;
            SettingTitle = settingtitle;
            SettingIcon = settingicon;
            SettingHelpUrl = settinghelpurl;
            Assembly = assembly;
            Submit = submit;
        }
    }
    #endregion
    public static class Module
    {
        public static ModulePage ModulePage
        {
            get
            {
                var modulepage = new ModulePage();
                PageFactory.InitElements(Browser.Driver, modulepage);
                return modulepage;
            }
        }

    }
    public class ModulePage
    {
        public string Url = "Admin/Modules.aspx";
        public string Text = "Modules";
        public string ModuleInstalled = "Module has been installed successfully.";
        #region
        //Modules
        //ctl19_ctl00_TabContainerManageModules_TabPanelModuleControls_gdvControls
        [FindsBy(How = How.TagName, Using = "body")]
        public IWebElement Body { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvExtensions")]        
        public IWebElement GridListModulesTables { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_gdvExtensions_ctl02_lnkName")]
        //public IWebElement EditModuleLink { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_gdvExtensions_ctl02_imbEdit")]
        //public IWebElement EditModuleLink { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_gdvExtensions_ctl02_chkBoxIsActiveItem")]
        //public IWebElement EditModuleIsActiveCheckBox { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_gdvExtensions_ctl02_imbDelete")]
        //public IWebElement DeleteModuleLink { get; set; }       
        [FindsBy(How = How.Id, Using = "ctl19_lblInstallModule")]        
        public IWebElement InstallModuleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblCreateNewModule")]        
        public IWebElement CreateNewModuleBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblCreatePackage")]        
        public IWebElement CreatePackageBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblCreateCompositeModule")]        
        public IWebElement CreateCompositePackageBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblDownloadModules")]        
        public IWebElement DownloadModules { get; set; }
        //ToolBar
        [FindsBy(How = How.Id, Using = "ctl19_txtSearchText")]        
        public IWebElement SearchModuleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblSearch")]        
        public IWebElement SearchBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ddlRecordsPerPage")]        
        public IWebElement RecordsPerPageDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_lblSaveChanges")]       
        public IWebElement SaveBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_gdvExtensions_ctl01_chkBoxIsActiveHeader")]        
        public IWebElement AllIsActiveCheckBox { get; set; }
        //Pagination
        [FindsBy(How = How.ClassName, Using = "sfPagination")]        
        public IWebElement Pagination { get; set; }
        //Download Modules
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtSearch")]       
        public IWebElement DownloadModuleSearchTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_btnExtensionSearch")]        
        public IWebElement DownloadModuleSearchBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_divModuleList")]        
        public IWebElement ModuleListDiv { get; set; }
        //Composite Package
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtPackageName")]        
        public IWebElement PackageNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtfriendlyname")]
        public IWebElement FriendlyNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtDescription")]        
        public IWebElement DescriptionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlFirst")]        
        public IWebElement VersionFirstDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlSecond")]        
        public IWebElement VersionSecondDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlLast")]        
        public IWebElement VersionLastDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtLicense")]        
        public IWebElement LicenseTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtReleaseNotes")]        
        public IWebElement ReleaseNotesTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtOwner")]        
        public IWebElement OwnerTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtOrganization")]        
        public IWebElement OrganizationTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtUrl")]        
        public IWebElement UrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtEmail")]        
        public IWebElement EmailTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_lbAvailableModules")]
        public IWebElement AvailableModulesList { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_lbModulesList")]
        public IWebElement SelectedModulesList { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_Upanel1")]       
        public IWebElement UpanelDiv { get; set; }
        //Create Package
        //Package Details
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtPackageName")]
        public IWebElement PackageDetailsNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtDescription")]
        public IWebElement PackageDetailsDescriptionTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_ddlFirst")]
        public IWebElement PackageDetailsFirstVersionDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_ddlSecond")]
        public IWebElement PackageDetailsSecondVersionDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_ddlLast")]
        public IWebElement PackageDetailsLastVersionDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtLicense")]
        public IWebElement PackageDetailsLicenseTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtReleaseNotes")]
        public IWebElement PackageDetailsReleaseNotesTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtOwner")]
        public IWebElement PackageDetailsOwnerTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtOrganization")]
        public IWebElement PackageDetailsOrganizationTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtUrl")]
        public IWebElement PackageDetailsUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_PackageDetails1_txtEmail")]
        public IWebElement PackageDetailsEmailTextBox { get; set; }
        //Package Details End
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtmodulename")]
        public IWebElement ModuleNameTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtbusinesscontrollerclass")]
        public IWebElement BusinessControllerClassTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtcompatibleversions")]
        public IWebElement CompatibleVersionsTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtCacheTime")]
        public IWebElement CacheTimeTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_btnNext")]
        public IWebElement NextBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_btnCancelled")]        
        public IWebElement CancelBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_btnPrevious")]        
        public IWebElement PreviousBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_fuInstallScript")]
        public IWebElement InstallScriptFileUpload { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_InstallScriptTxt")]
        public IWebElement InstallScriptTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_fuUnistallScript")]
        public IWebElement UnistallScriptFileUpload { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_UnistallScriptTxt")]
        public IWebElement UnistallScriptTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_chkIncludeSource")]
        public IWebElement IncludeSourceCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_lstFolderFiles")]
        public IWebElement FolderFilesDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "chkControls")]
        public IWebElement AllFilesSelectCheckBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlViewControlSrc")]
        public IWebElement ViewControlDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtViewKey")]
        public IWebElement ViewKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtViewTitle")]
        public IWebElement ViewTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlViewIcon")]
        public IWebElement ViewIconDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtViewHelpURL")]
        public IWebElement ViewHelpUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlEditControlSrc")]
        public IWebElement EditControlDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtEditKey")]
        public IWebElement EditKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtEditTitle")]
        public IWebElement EditTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlEditIcon")]
        public IWebElement EditIconDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtEditHelpURL")]
        public IWebElement EditHelpUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlSettingControlSrc")]
        public IWebElement SettingControlDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtSettingKey")]        
        public IWebElement SettingKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtSettingTitle")]
        public IWebElement SettingTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlSettingIcon")]        
        public IWebElement SettingIconDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtSettingHelpURL")]
        public IWebElement SettingHelpUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_lstAssembly")]
        public IWebElement AssemblyList { get; set; }
        //Create New Module
        //Include PackageDetails
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlCreate")]        
        public IWebElement CreateDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlOwner")]        
        public IWebElement OwnerDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlModule")]        
        public IWebElement ModuleDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlFiles")]        
        public IWebElement SourceFileDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbCreate")]        
        public IWebElement CreateBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbBack")]        
        public IWebElement BackBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ModuleControlsDetails1_txtKey")]        
        public IWebElement ModuleControlsDetailsKeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ModuleControlsDetails1_txtTitle")]       
        public IWebElement ModuleControlsDetailsTitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ModuleControlsDetails1_ddlType")]        
        public IWebElement ModulecontrolDetailsTypeDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ModuleControlsDetails1_ddlIcon")]        
        public IWebElement ModuleControlsDetailsIconDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ModuleControlsDetails1_txtHelpURL")]        
        public IWebElement ModuleControlsDetailsHelpUrlTextBox { get; set; }
        //Install Module
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_wizInstall_fileModule")]       
        public IWebElement InstallFileModuleUpload { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_wizInstall")]
        public IWebElement WizInstallTable { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_wizInstall_chkAcceptLicense")]        
        public IWebElement AcceptLicenseCheckBox { get; set; }
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement { get; set; }
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement { get; set; }
        //[FindsBy(How = How.Id, Using = "")]
        //public IWebElement { get; set; }       
        //Edit Module
        [FindsBy(How = How.Id, Using = "__tab_ctl19_ctl00_TabContainerManageModules_TabPanelModuleControls")]
        public IWebElement ModuleControlSettings { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions")]
        public IWebElement ModuleDefinitionSettings { get; set; }
        [FindsBy(How = How.Id, Using = "__tab_ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor")]
        public IWebElement ModuleSettings { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleControls_gdvControls")]
        public IWebElement ModuleControlsGrid { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlSource")]
        public IWebElement SourceDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtKey")]
        public IWebElement KeyTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtTitle")]
        public IWebElement TitleTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlType")]
        public IWebElement TypeDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_ddlIcon")]
        public IWebElement IconDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_txtHelpURL")]
        public IWebElement HelpUrlTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbUpdateModlueControl")]
        public IWebElement UpdateModuleControl { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbCancelModlueControl")]
        public IWebElement CancelModuleControl { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleControls_imbAddControl")]
        public IWebElement AddModuleControl { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions_ddlDefinitions")]
        public IWebElement DefinitionDropdown { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions_txtFriendlyName")]
        public IWebElement ModuleFriendlyName { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions_txtDefaultCacheTime")]
        public IWebElement ModuleCacheTime { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions_imbUpdateDefinition")]
        public IWebElement UpdateDefinitonBtn { get; set; }
        //Module Settings
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_txtFolderName")]
        public IWebElement ModuleFolderTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_txtBusinessControllerClass")]
        public IWebElement BusinessControllerTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_txtDependencies")]
        public IWebElement DependenciesTextBox { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_txtPermissions")]
        public IWebElement PermissionTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_chkIsPortable")]
        public IWebElement IsPortableCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_chkIsSearchable")]
        public IWebElement IsSearchableCheckBox {get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_chkIsUpgradable")]
        public IWebElement IsUpgradableCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_chkIsPremium")]
        public IWebElement IsPremiumCheckBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtPackageName")]
        public IWebElement ModuleEditorPackageNameTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtDescription")]
        public IWebElement ModuleEditorPackageDescriptionTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_ddlFirst")]
        public IWebElement ModuleEditorVersionFirstDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_ddlSecond")]
        public IWebElement ModuleEditorVersionSecondDropdown{ get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_ddlLast")]
        public IWebElement ModuleEditorVersionLastDropdown { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtLicense")]
        public IWebElement ModuleEditorLicenseTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtReleaseNotes")]
        public IWebElement ModuleEditorReleaseNotes { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtOwner")]
        public IWebElement ModuleEditorOwnerTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtOrganization")]
        public IWebElement ModuleEditorOrganizationTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtUrl")]
        public IWebElement ModuleEditorUrlTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_PackageDetails1_txtEmail")]
        public IWebElement ModuleEditorEmailTextBox { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_imbUpdate")]
        public IWebElement ModuleEditorUpdate { get; set;}
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbUninstall")]
        public IWebElement ModuleInstallBtn { get; set; }
        [FindsBy(How = How.Id, Using = "ctl19_ctl00_imbCancel")]
        public IWebElement ModuleCancel { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleControls_tab")]
        //public IWebElement ModuleControlSettingsSpan { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelDefinitions_tab")]
        //public IWebElement ModuleDefinitionSettingsSpan { get; set; }
        //[FindsBy(How = How.Id, Using = "ctl19_ctl00_TabContainerManageModules_TabPanelModuleEditor_tab")]
        //public IWebElement ModuleSettingsSpan { get; set; }
        #endregion   
        public void Confirmation(bool Confirm, int n)
        {
            //n = 55 for save, n = 75 for delete
            try
            {
                IList<IWebElement> Div = Body.FindElements(By.TagName("div"));
                IList<IWebElement> Button = Div[n].FindElements(By.TagName("button"));
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
                //throw ex;
            }
        }
        public IWebElement ModuleLink(int n)
        {
            //0, 6 for edit: 7 for Delete
            try
            {
                IWebElement Tbody = GridListModulesTables.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IList<IWebElement> Td = Tr[1].FindElements(By.TagName("td"));
                IWebElement EditModuleIsActiveCheckBox = Td[5].FindElements(By.TagName("input"))[2];
                switch (n)
                {
                    case 0:
                    case 6:
                    case 7:
                        {
                            return Td[n].FindElement(By.TagName("a"));
                        }
                    default:
                        {
                            return EditModuleIsActiveCheckBox;
                        }
                }
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }            
        }
        public void ModuleAddEdit(ModuleAddEdit ModuleAddEdit)
        {
            try
            {
                Browser.Wait();
                DropDownSelect DropDownSource = new DropDownSelect(ModuleAddEdit.Source, SourceDropdown);
                DropDownSelect DropDownControlType = new DropDownSelect(ModuleAddEdit.ControlType, TypeDropdown);
                Browser.SelectDropdown(DropDownSource);
                Browser.Wait();
                Browser.SelectDropdown(DropDownControlType);
                Browser.Wait();
                //IWebElement IconDropdown = Browser.Driver.FindElement(By.Id("ctl19_ctl00_ddlIcon"));
                //Browser.SelectDropdown(Icon, IconDropdown);
                ClearAndFillTextBox KeyClearNFill = new ClearAndFillTextBox(KeyTextBox, ModuleAddEdit.Key);
                Browser.ClearAndFillTextBox(KeyClearNFill);
                ClearAndFillTextBox TitleClearNFill = new ClearAndFillTextBox(TitleTextBox, ModuleAddEdit.Title);
                Browser.ClearAndFillTextBox(TitleClearNFill);
                ClearAndFillTextBox HelpUrlClearNFill = new ClearAndFillTextBox(HelpUrlTextBox, ModuleAddEdit.HelpUrl);
                Browser.ClearAndFillTextBox(HelpUrlClearNFill);
                switch (ModuleAddEdit.Update)
                {
                    case true:
                        {
                            UpdateModuleControl.Click();
                            break;
                        }
                    default:
                        {
                            CancelModuleControl.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }          
        }       
        public IWebElement ModuleEditDeleteLink(ModuleEditDeleteLink ModuleEditDeleteLink)
        {
            //n=3 for edit and n = 4 for delete
            try
            {
                Browser.Wait();
                IWebElement TableBody = ModuleControlsGrid.FindElement(By.TagName("tbody"));
                IList<IWebElement> GridTr = TableBody.FindElements(By.TagName("tr"));
                IList<IWebElement> GridTd = GridTr[ModuleEditDeleteLink.EditNo].FindElements(By.TagName("td"));
                IWebElement ModuleControlLink = GridTd[ModuleEditDeleteLink.N].FindElement(By.TagName("a"));
                return ModuleControlLink;
            }
            catch (Exception ex)
            {
                return null;
               // throw ex;
            }
        }
        public void Search_Module(string Module)
        {
            try
            {
                ClearAndFillTextBox SearchModuleClearNFill = new ClearAndFillTextBox(SearchModuleTextBox, Module);
                Browser.ClearAndFillTextBox(SearchModuleClearNFill);
                SearchBtn.Click();
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void RecordsPerPageView(int RecordsPerPage)
        {
            try
            {
                DropDownSelect DropDownRecordsPerPage = new DropDownSelect(RecordsPerPage.ToString(), RecordsPerPageDropdown);
                Browser.SelectDropdown(DropDownRecordsPerPage);
            }
            catch (Exception ex)
            {
               // throw ex;
            }
        }
        public void VersionSelect(VersionSelect VersionSelect)
        {
            try
            {
                SelectElement VersionFirstSelect = new SelectElement(VersionFirstDropdown);
                SelectElement VersionSecondSelect = new SelectElement(VersionSecondDropdown);
                SelectElement VersionLastSelect = new SelectElement(VersionLastDropdown);
                string VersionF = VersionSelect.VersionFirst < 10 ? "0" + VersionSelect.VersionFirst.ToString() : VersionSelect.VersionFirst.ToString();
                VersionFirstSelect.SelectByText(VersionF);
                string VersionS = VersionSelect.VersionSecond < 10 ? "0" + VersionSelect.VersionSecond.ToString() : VersionSelect.VersionSecond.ToString();
                VersionSecondSelect.SelectByText(VersionS);
                string VersionL = VersionSelect.VersionLast < 10 ? "0" + VersionSelect.VersionLast.ToString() : VersionSelect.VersionLast.ToString();
                VersionLastSelect.SelectByText(VersionL);
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }              
        public void DownloadModule(DownloadModule DownloadModule)
        {
            try
            {
                DownloadModules.Click();
                ClearAndFillTextBox DownloadModuleSearchClearNFill = new ClearAndFillTextBox(DownloadModuleSearchTextBox, DownloadModule.Modules);
                Browser.ClearAndFillTextBox(DownloadModuleSearchClearNFill);
                DownloadModuleSearchBtn.Click();
                if (DownloadModule.Cancel)
                {
                    IWebElement CancelDiv = ModuleListDiv.FindElements(By.TagName("div"))[2];
                    IWebElement CancelBtn = CancelDiv.FindElement(By.TagName("label"));
                    CancelBtn.Click();
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }
        }
        public void Create_CompositePackage(CompositePackage CompositePackage)
        {
            try
            {
                CreateCompositePackageBtn.Click();
                ClearAndFillTextBox PackageNameClearNFill = new ClearAndFillTextBox(PackageNameTextBox, CompositePackage.PackageName);
                Browser.ClearAndFillTextBox(PackageNameClearNFill);
                ClearAndFillTextBox FriendlyNameClearNFill = new ClearAndFillTextBox(FriendlyNameTextBox, CompositePackage.FriendlyName);
                Browser.ClearAndFillTextBox(FriendlyNameClearNFill);
                ClearAndFillTextBox DescriptionClearNFill = new ClearAndFillTextBox(DescriptionTextBox, CompositePackage.Description);
                Browser.ClearAndFillTextBox(DescriptionClearNFill);
                VersionSelect VersionSelectI = new VersionSelect(CompositePackage.VersionFirst, CompositePackage.VersionSecond, CompositePackage.VersionLast, VersionFirstDropdown, VersionSecondDropdown, VersionLastDropdown);
                VersionSelect(VersionSelectI);
                ClearAndFillTextBox LicenseClearNFill = new ClearAndFillTextBox(LicenseTextBox, CompositePackage.License);
                Browser.ClearAndFillTextBox(LicenseClearNFill);
                ClearAndFillTextBox ReleaseNotesClearNFill = new ClearAndFillTextBox(ReleaseNotesTextBox, CompositePackage.ReleaseNotes);
                Browser.ClearAndFillTextBox(ReleaseNotesClearNFill);
                ClearAndFillTextBox OwnerClearNFill = new ClearAndFillTextBox(OwnerTextBox, CompositePackage.Owner);
                Browser.ClearAndFillTextBox(OwnerClearNFill);
                ClearAndFillTextBox OrganizationClearNFill = new ClearAndFillTextBox(OrganizationTextBox, CompositePackage.Organization);
                Browser.ClearAndFillTextBox(OrganizationClearNFill);
                ClearAndFillTextBox UrlClearNFill = new ClearAndFillTextBox(UrlTextBox, CompositePackage.Url);
                Browser.ClearAndFillTextBox(UrlClearNFill);
                ClearAndFillTextBox EmailClearNFill = new ClearAndFillTextBox(EmailTextBox, CompositePackage.Email);
                Browser.ClearAndFillTextBox(EmailClearNFill);
                int i;
                IWebElement SelectArrowDiv = UpanelDiv.FindElements(By.TagName("div"))[1];
                IList<IWebElement> SelectArrow = SelectArrowDiv.FindElements(By.TagName("label"));
                switch (CompositePackage.SwitchRight)
                {
                    case true:
                        {
                            for (i = 0; i < CompositePackage.Modules.Length; i++)
                            {
                                DropDownSelect AvailableModulesDropDown = new DropDownSelect(CompositePackage.Modules[i], AvailableModulesList);
                                Browser.SelectDropdown(AvailableModulesDropDown);
                            }
                            SelectArrow[0].Click();
                            break;
                        }
                    default:
                        {
                            for (i = 0; i < CompositePackage.Modules.Length; i++)
                            {
                                DropDownSelect SelectedModulesDropDown = new DropDownSelect(CompositePackage.Modules[i], SelectedModulesList);
                                Browser.SelectDropdown(SelectedModulesDropDown);
                            }
                            SelectArrow[1].Click();
                            break;
                        }
                }
                Browser.Wait();
                IList<IWebElement> ListSelectedModules = SelectedModulesList.FindElements(By.TagName("option"));
                if (ListSelectedModules.Count == CompositePackage.Modules.Length)
                {
                    WaitForElement BottompanelWait = new WaitForElement(By.Id("divBottompanel"), 20);
                    IWebElement BottompanelDiv = Browser.WaitForElement(BottompanelWait);
                    IWebElement ClassDiv = BottompanelDiv.FindElement(By.TagName("div"));
                    IWebElement ModuleContentDiv = ClassDiv.FindElement(By.TagName("div"));
                    IWebElement CollapseWrapperDiv = ModuleContentDiv.FindElement(By.TagName("div"));
                    IList<IWebElement> ButtonWrapperDiv = CollapseWrapperDiv.FindElements(By.TagName("div"));
                    IList<IWebElement> Button = ButtonWrapperDiv[6].FindElements(By.TagName("label"));
                    switch (CompositePackage.DownloadConfirm)
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
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }
        public void Create_Package(CreatePackage CreatePackage)
        {
            try
            {
                CreatePackageBtn.Click();
Start:          ClearAndFillTextBox PackageNameClearNFill = new ClearAndFillTextBox(PackageDetailsNameTextBox, CreatePackage.PackageName);
                Browser.ClearAndFillTextBox(PackageNameClearNFill);
                ClearAndFillTextBox PackageDescriptionClearNFill = new ClearAndFillTextBox(PackageDetailsDescriptionTextBox, CreatePackage.PackageDescription);
                Browser.ClearAndFillTextBox(PackageDescriptionClearNFill);
                VersionSelect VersionSelectI = new VersionSelect(CreatePackage.VersionFirst, CreatePackage.VersionSecond, CreatePackage.VersionLast, PackageDetailsFirstVersionDropdown, PackageDetailsSecondVersionDropdown, PackageDetailsLastVersionDropdown);
                VersionSelect(VersionSelectI);
                ClearAndFillTextBox PackageDetailsLicenseClearNFill = new ClearAndFillTextBox(PackageDetailsLicenseTextBox, CreatePackage.PackageLicense);
                Browser.ClearAndFillTextBox(PackageDetailsLicenseClearNFill);
                ClearAndFillTextBox PackageDetailsReleaseNotesClearNFill = new ClearAndFillTextBox(PackageDetailsReleaseNotesTextBox, CreatePackage.PackageReleaseNotes);
                Browser.ClearAndFillTextBox(PackageDetailsReleaseNotesClearNFill);
                ClearAndFillTextBox PackageDetailsOwnerClearNFill = new ClearAndFillTextBox(PackageDetailsOwnerTextBox, CreatePackage.PackageOwner);
                Browser.ClearAndFillTextBox(PackageDetailsOwnerClearNFill);
                ClearAndFillTextBox PackageDetailsOrganizationClearNFill = new ClearAndFillTextBox(PackageDetailsOrganizationTextBox, CreatePackage.PackageOrganization);
                Browser.ClearAndFillTextBox(PackageDetailsOrganizationClearNFill);
                ClearAndFillTextBox PackageDetailsUrlClearNFill = new ClearAndFillTextBox(PackageDetailsUrlTextBox, CreatePackage.PackageUrl);
                Browser.ClearAndFillTextBox(PackageDetailsUrlClearNFill);
                ClearAndFillTextBox PackageDetailsEmailClearNFill = new ClearAndFillTextBox(PackageDetailsEmailTextBox, CreatePackage.PackageEmail);
                Browser.ClearAndFillTextBox(PackageDetailsEmailClearNFill);
                ClearAndFillTextBox FriendlyNameClearNFill = new ClearAndFillTextBox(FriendlyNameTextBox, CreatePackage.FriendlyName);
                Browser.ClearAndFillTextBox(FriendlyNameClearNFill);
                ClearAndFillTextBox ModuleNameClearNFill = new ClearAndFillTextBox(ModuleNameTextBox, CreatePackage.ModuleName);
                Browser.ClearAndFillTextBox(ModuleNameClearNFill);
                ClearAndFillTextBox BusinessControllerClassClearNFill = new ClearAndFillTextBox(BusinessControllerClassTextBox, CreatePackage.BusinessControllerClass);
                Browser.ClearAndFillTextBox(BusinessControllerClassClearNFill);
                ClearAndFillTextBox CompatibleVersionClearNFill = new ClearAndFillTextBox(CompatibleVersionsTextBox, CreatePackage.CompatibleVersion);
                Browser.ClearAndFillTextBox(CompatibleVersionClearNFill);
                ClearAndFillTextBox CacheTimeClearNFill = new ClearAndFillTextBox(CacheTimeTextBox, CreatePackage.CacheTime.ToString());
                Browser.ClearAndFillTextBox(CacheTimeClearNFill);
                DropDownSelect AvailableModulesDropDown = new DropDownSelect(CreatePackage.ModuleFolder, AvailableModulesList);
                Browser.SelectDropdown(AvailableModulesDropDown);
                if (CreatePackage.Next[0])
                {
                    NextBtn.Click();
Mid:                switch (CreatePackage.FileUploadInstall)
                    {
                        case true:
                            {
                                InstallScriptFileUpload.SendKeys(CreatePackage.InstallFileUpload);
                                break;
                            }
                        default:
                            {
                                ClearAndFillTextBox InstallScriptClearNFill = new ClearAndFillTextBox(InstallScriptTextBox, CreatePackage.InstallScript);
                                Browser.ClearAndFillTextBox(InstallScriptClearNFill);
                                break;
                            }
                    }
                switch (CreatePackage.FileUploadUnistall)
                    {
                        case true:
                            {
                                UnistallScriptFileUpload.SendKeys(CreatePackage.UnistallFileUpload);
                                break;
                            }
                        default:
                            {
                                ClearAndFillTextBox UninstallClearNFill = new ClearAndFillTextBox(UnistallScriptTextBox, CreatePackage.UnistallScript);
                                break;
                            }
                    }
                ChkBox IncludeSourceChkBox = new ChkBox(CreatePackage.IncludeSource, IncludeSourceCheckBox);
                    Browser.CheckBox(IncludeSourceChkBox);
                    if (CreatePackage.Previous[0])
                    {
                        PreviousBtn.Click();
                        CreatePackage.Previous[0] = false;
                        goto Start;
                    }
                    else if (CreatePackage.Next[1])
                    {
                        NextBtn.Click();
End:                    switch (CreatePackage.AllFilesSelect)
                        {
                            case true:
                                {
                                    if (!AllFilesSelectCheckBox.Selected)
                                    {
                                        AllFilesSelectCheckBox.Click();
                                    }
                                    break;
                                }
                            default:
                                {
                                    if (AllFilesSelectCheckBox.Selected)
                                    {
                                        AllFilesSelectCheckBox.Click();
                                    }
                                    int j;
                                    for (j = 0; j < CreatePackage.FolderFiles.Length; j++)
                                    {
                                        DropDownSelect DropDownFolderFiles = new DropDownSelect(CreatePackage.FolderFiles[j], FolderFilesDropdown);
                                        Browser.SelectDropdown(DropDownFolderFiles);
                                    }
                                    break;
                                }
                        }
                    if (CreatePackage.Previous[1])
                        {
                            PreviousBtn.Click();
                            CreatePackage.Previous[1] = false;
                            goto Mid;
                        }
                    else if (CreatePackage.Next[2])
                        {
                            NextBtn.Click();
                            DropDownSelect DropDownViewControl = new DropDownSelect(CreatePackage.ViewControl, ViewControlDropdown);
Last:                       Browser.SelectDropdown(DropDownViewControl);
                            ClearAndFillTextBox ViewKeyClearNFill = new ClearAndFillTextBox(ViewKeyTextBox, CreatePackage.ViewKey);
                            Browser.ClearAndFillTextBox(ViewKeyClearNFill);
                            ClearAndFillTextBox ViewTitleClearNFill = new ClearAndFillTextBox(ViewTitleTextBox, CreatePackage.ViewTitle);
                            Browser.ClearAndFillTextBox(ViewTitleClearNFill);
                            //Browser.SelectDropdown(ViewIcon, ViewIconDropdown);
                            ClearAndFillTextBox ViewHelpUrlClearNFill = new ClearAndFillTextBox(ViewHelpUrlTextBox, CreatePackage.ViewHelpUrl);
                            Browser.ClearAndFillTextBox(ViewHelpUrlClearNFill);
                            DropDownSelect DropDownEditControl = new DropDownSelect(CreatePackage.EditControl, EditControlDropdown);
                            Browser.SelectDropdown(DropDownEditControl);
                            ClearAndFillTextBox EditKeyClearNFill = new ClearAndFillTextBox(EditKeyTextBox, CreatePackage.EditKey);
                            Browser.ClearAndFillTextBox(EditKeyClearNFill);
                            ClearAndFillTextBox EditTitleClearNFill = new ClearAndFillTextBox(EditTitleTextBox, CreatePackage.EditTitle);
                            Browser.ClearAndFillTextBox(EditTitleClearNFill);
                            //Browser.SelectDropdown(EditIcon, EditIconDropdown);
                            ClearAndFillTextBox EditHelpUrlClearNFill = new ClearAndFillTextBox(EditHelpUrlTextBox, CreatePackage.EditHelpUrl);
                            Browser.ClearAndFillTextBox(EditHelpUrlClearNFill);
                            DropDownSelect DropDownSettingControl = new DropDownSelect(CreatePackage.SettingControl, SettingControlDropdown);
                            Browser.SelectDropdown(DropDownSettingControl);
                            ClearAndFillTextBox SettingKeyClearNFill = new ClearAndFillTextBox(SettingKeyTextBox, CreatePackage.SettingKey);
                            Browser.ClearAndFillTextBox(SettingKeyClearNFill);
                            ClearAndFillTextBox SettingTitleClearNFill = new ClearAndFillTextBox(SettingTitleTextBox, CreatePackage.SettingTitle);
                            Browser.ClearAndFillTextBox(SettingTitleClearNFill);
                            //Browser.SelectDropdown(SettingIcon, SettingIconDropdown);
                            ClearAndFillTextBox SettingHelpUrlClearNFill = new ClearAndFillTextBox(SettingHelpUrlTextBox, CreatePackage.SettingHelpUrl);
                            Browser.ClearAndFillTextBox(SettingHelpUrlClearNFill);
                            if (CreatePackage.Previous[2])
                            {
                                PreviousBtn.Click();
                                CreatePackage.Previous[2] = false;
                                goto End;
                            }
                            else if (CreatePackage.Next[3])
                            {
                                NextBtn.Click();
                                int i;
                                for (i = 0; i < CreatePackage.Assembly.Length; i++)
                                {
                                    DropDownSelect AssemblyListDropDown = new DropDownSelect(CreatePackage.Assembly[i], AssemblyList);
                                    Browser.SelectDropdown(AssemblyListDropDown);
                                }
                                if (CreatePackage.Previous[3])
                                {
                                    PreviousBtn.Click();
                                    CreatePackage.Previous[3] = false;
                                    goto Last;
                                }
                                else if (CreatePackage.Submit)
                                {
                                    NextBtn.Click();
                                    //Browser.ProcessRun(FilePath);
                                }
                                else
                                {
                                    CancelBtn.Click();
                                }
                            }
                            else
                            {
                                CancelBtn.Click();
                            }
                        }
                        else
                        {
                            CancelBtn.Click();
                        }
                    }
                    else
                    {
                        CancelBtn.Click();
                    }
                }
                else
                {
                    CancelBtn.Click();
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }           
         }
        public IList<IWebElement> GetLabel(int n)
        {
            try
            {
                IWebElement Tbody = WizInstallTable.FindElement(By.TagName("tbody"));
                IList<IWebElement> Tr = Tbody.FindElements(By.TagName("tr"));
                IWebElement Td = Tr[n].FindElement(By.TagName("td"));
                string text = Td.GetAttribute("align");
                IWebElement Div = Td.FindElement(By.TagName("div"));
                IList<IWebElement> Label = Div.FindElements(By.TagName("label"));
                return Label;
            }
            catch (Exception ex)
            {
                return null;
              //  throw ex;
            }
        }
        public void Install_Module(InstallModule InstallModule)
        {
            try
            {
                InstallModuleBtn.Click();
                InstallFileModuleUpload.SendKeys(InstallModule.ModulePath);
                IList<IWebElement> Label = GetLabel(4);
                switch (InstallModule.Next[0])
                {
                    case true:
                        {
                            Label[0].Click();
                            IList<IWebElement> Label1 = GetLabel(3);
                            switch (InstallModule.Next[1])
                            {
                                case true:
                                    {
                                        Label1[0].Click();
                                        IList<IWebElement> Label2 = GetLabel(1);
                                        switch (InstallModule.Next[2])
                                        {
                                            case true:
                                                {
                                                    Label2[0].Click();
                                                    IList<IWebElement> Label3 = GetLabel(4);
                                                    ChkBox AcceptLicenseChkBox = new ChkBox(InstallModule.AcceptLicense, AcceptLicenseCheckBox);
                                                    Browser.CheckBox(AcceptLicenseChkBox);
                                                    switch (InstallModule.Next[3])
                                                    {
                                                        case true:
                                                            {
                                                                Label3[0].Click();
                                                                IWebElement Message = Browser.Driver.FindElement(By.Id("ctl16_lblUdpSageMesageCustom"));
                                                                IsAt isat = new IsAt(ModuleInstalled, Message.Text);
                                                                Assert.IsTrue(Browser.IsAt(isat));
                                                                IList<IWebElement> Label4 = GetLabel(2);
                                                                if (InstallModule.Install)
                                                                {
                                                                    Label4[0].Click();
                                                                }
                                                                break;
                                                            }
                                                        default:
                                                            {
                                                                Label3[1].Click();
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            default:
                                                {
                                                    Label2[1].Click();
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Label1[1].Click();
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            Label[1].Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
            }           
        }
        public void Create_Module(CreateModule CreateModule)
        {
            try
            {
                CreateNewModuleBtn.Click();
                DropDownSelect DropDownCreate = new DropDownSelect(CreateModule.Control, CreateDropdown);
                DropDownSelect DropDownOwner = new DropDownSelect(CreateModule.Owner, OwnerDropdown);
                DropDownSelect DropDownModule = new DropDownSelect(CreateModule.ModuleFolder, ModuleDropdown);
                DropDownSelect DropDownSourceFile = new DropDownSelect(CreateModule.Source, SourceFileDropdown);
                Browser.SelectDropdown(DropDownCreate);
                Browser.SelectDropdown(DropDownOwner);
                Browser.SelectDropdown(DropDownModule);
                Browser.SelectDropdown(DropDownSourceFile);
                ClearAndFillTextBox PackageNameClearNFill = new ClearAndFillTextBox(PackageDetailsNameTextBox, CreateModule.PackageName);
                Browser.ClearAndFillTextBox(PackageNameClearNFill);
                ClearAndFillTextBox PackageDescriptionClearNFill = new ClearAndFillTextBox(PackageDetailsDescriptionTextBox, CreateModule.PackageDescription);
                Browser.ClearAndFillTextBox(PackageDescriptionClearNFill);
                VersionSelect VersionSelectI = new VersionSelect(CreateModule.VersionFirst, CreateModule.VersionSecond, CreateModule.VersionLast, PackageDetailsFirstVersionDropdown, PackageDetailsSecondVersionDropdown, PackageDetailsLastVersionDropdown);
                VersionSelect(VersionSelectI);
                ClearAndFillTextBox PackageDetailsLicenseClearNFill = new ClearAndFillTextBox(PackageDetailsLicenseTextBox, CreateModule.PackageLicense);
                Browser.ClearAndFillTextBox(PackageDetailsLicenseClearNFill);
                ClearAndFillTextBox PackageDetailsReleaseNotesClearNFill = new ClearAndFillTextBox(PackageDetailsReleaseNotesTextBox, CreateModule.PackageReleaseNotes);
                Browser.ClearAndFillTextBox(PackageDetailsReleaseNotesClearNFill);
                ClearAndFillTextBox PackageDetailsOwnerClearNFill = new ClearAndFillTextBox(PackageDetailsOwnerTextBox, CreateModule.PackageOwner);
                Browser.ClearAndFillTextBox(PackageDetailsOwnerClearNFill);
                ClearAndFillTextBox PackageDetailsOrganizationClearNFill = new ClearAndFillTextBox(PackageDetailsOrganizationTextBox, CreateModule.PackageOrganization);
                Browser.ClearAndFillTextBox(PackageDetailsOrganizationClearNFill);
                ClearAndFillTextBox PackageDetailsUrlClearNFill = new ClearAndFillTextBox(PackageDetailsUrlTextBox, CreateModule.PackageUrl);
                Browser.ClearAndFillTextBox(PackageDetailsUrlClearNFill);
                ClearAndFillTextBox PackageDetailsEmailClearNFill = new ClearAndFillTextBox(PackageDetailsEmailTextBox, CreateModule.PackageEmail);
                Browser.ClearAndFillTextBox(PackageDetailsEmailClearNFill);
                ClearAndFillTextBox ModuleControlKeyClearNFill = new ClearAndFillTextBox(ModuleControlsDetailsKeyTextBox, CreateModule.ModuleKey);
                Browser.ClearAndFillTextBox(ModuleControlKeyClearNFill);
                ClearAndFillTextBox ModuleControlsTitleClearNFill = new ClearAndFillTextBox(ModuleControlsDetailsTitleTextBox, CreateModule.ModuleTitle);
                Browser.ClearAndFillTextBox(ModuleControlsTitleClearNFill);
                DropDownSelect ModuleDetailsTypeDropDown = new DropDownSelect(CreateModule.ModuleType, ModulecontrolDetailsTypeDropdown);
                DropDownSelect ModuleDetailsIconDropDown = new DropDownSelect(CreateModule.Icon, ModuleControlsDetailsIconDropdown);
                Browser.SelectDropdown(ModuleDetailsTypeDropDown);
                Browser.SelectDropdown(ModuleDetailsIconDropDown);
                ClearAndFillTextBox ModuleControlsHelpUrlClearNFill = new ClearAndFillTextBox(ModuleControlsDetailsHelpUrlTextBox, CreateModule.HelpUrl);
                switch (CreateModule.Create)
                {
                    case true:
                        {
                            CreateBtn.Click();
                            break;
                        }
                    default:
                        {
                            BackBtn.Click();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }       
        public void Edit_Module(EditModule EditModule)
        {
            try
            {
                Search_Module(EditModule.EditModuleI);
                IWebElement EditModuleIsActiveCheckBox = ModuleLink(1);
                ChkBox EditModuleChkBox = new ChkBox(EditModule.IsActive, EditModuleIsActiveCheckBox);
                Browser.CheckBox(EditModuleChkBox);
                SaveBtn.Click();
                Confirmation(EditModule.Save, 55);
                if (EditModule.Edit)
                {
                    IWebElement EditModuleLink = ModuleLink(0);
                    EditModuleLink.Click();
                    //Session Expires so below code required
                    //Browser.Wait();
                    //Admin.AdminPage.LogIn("superuser", "superuser");
                    //Search_Module(EditModule);
                    //IWebElement EditModuleLink1 = ModuleLink(0);
                    //EditModuleLink1.Click();
                    if (EditModule.EditModuleControlSettings)
                    {
                        Browser.Wait();
                        ModuleControlSettings.Click();
                        if (EditModule.EditModuleControls)
                        {
                            ModuleEditDeleteLink ModuleEditDeleteLinkI = new ModuleEditDeleteLink(3, 1);
                            IWebElement EditModuleControlLink = ModuleEditDeleteLink(ModuleEditDeleteLinkI);
                            EditModuleControlLink.Click();                           
                            ModuleAddEdit(EditModule.ModuleAddEdit[0]);
                        }
                        if (EditModule.DeleteModuleControl)
                        {
                            ModuleEditDeleteLink ModuleEditDeleteLinkI = new ModuleEditDeleteLink(4, 1);
                            IWebElement DeleteModuleControlLink = ModuleEditDeleteLink(ModuleEditDeleteLinkI);
                            DeleteModuleControlLink.Click();
                            Confirmation(EditModule.DeleteControl, 75);
                        }
                        if (EditModule.AddModuleControls)
                        {
                            AddModuleControl.Click();
                            ModuleAddEdit(EditModule.ModuleAddEdit[1]);
                        }
                    }
                    if (EditModule.EditModuleDefinitionSettings)
                    {
                        ModuleDefinitionSettings.Click();
                        DropDownSelect DropDownDefinition = new DropDownSelect(EditModule.Definition, DefinitionDropdown);
                        Browser.SelectDropdown(DropDownDefinition);
                        ClearAndFillTextBox ModuleFriendlyNameClearNFill = new ClearAndFillTextBox(ModuleFriendlyName, EditModule.FriendlyName);
                        Browser.ClearAndFillTextBox(ModuleFriendlyNameClearNFill);
                        ClearAndFillTextBox ModuleCacheTimeClearNFill = new ClearAndFillTextBox(ModuleCacheTime, EditModule.ModuleCache.ToString());
                        Browser.ClearAndFillTextBox(ModuleCacheTimeClearNFill);
                        UpdateDefinitonBtn.Click();
                    }
                    if (EditModule.EditModuleSettings)
                    {
                        ModuleSettings.Click();
                        //ModuleFolderTextBox.Clear();
                        //ModuleFolderTextBox.SendKeys(ModuleFolder);
                        ClearAndFillTextBox BusinessControllerClearNFill = new ClearAndFillTextBox(BusinessControllerTextBox, EditModule.BusinessControllerClass);
                        Browser.ClearAndFillTextBox(BusinessControllerClearNFill);
                        ClearAndFillTextBox DependenciesClearNFill = new ClearAndFillTextBox(DependenciesTextBox, EditModule.Dependencies);
                        Browser.ClearAndFillTextBox(DependenciesClearNFill);
                        ClearAndFillTextBox PermissionClearNFill = new ClearAndFillTextBox(PermissionTextBox, EditModule.Permission);
                        Browser.ClearAndFillTextBox(PermissionClearNFill);
                        if (IsPortableCheckBox.Enabled)
                        {
                            ChkBox IsPortableChkBox = new ChkBox(EditModule.IsPortable, IsPortableCheckBox);
                            Browser.CheckBox(IsPortableChkBox);
                        }
                        if (IsSearchableCheckBox.Enabled)
                        {
                            ChkBox IsSearchableChkBox = new ChkBox(EditModule.IsSearchable, IsSearchableCheckBox);
                            Browser.CheckBox(IsSearchableChkBox);
                        }
                        if (IsUpgradableCheckBox.Enabled)
                        {
                            ChkBox IsUpgradableChkBox = new ChkBox(EditModule.IsUpgradable, IsUpgradableCheckBox);
                            Browser.CheckBox(IsUpgradableChkBox);
                        }
                        if (IsPremiumCheckBox.Enabled)
                        {
                            ChkBox IsPremiumChkBox = new ChkBox(EditModule.IsPremiumModule, IsPremiumCheckBox);
                            Browser.CheckBox(IsPremiumChkBox);
                        }
                        ClearAndFillTextBox ModuleEditorPackageNameClearNFill = new ClearAndFillTextBox(ModuleEditorPackageNameTextBox, EditModule.ModulePackageName);
                        Browser.ClearAndFillTextBox(ModuleEditorPackageNameClearNFill);
                        ClearAndFillTextBox ModuleEditorPackageDescriptionClearNFill = new ClearAndFillTextBox(ModuleEditorPackageDescriptionTextBox, EditModule.ModuleDescription);
                        Browser.ClearAndFillTextBox(ModuleEditorPackageDescriptionClearNFill);
                        VersionSelect VersionSelectI = new VersionSelect(1, 2, 3, ModuleEditorVersionFirstDropdown, ModuleEditorVersionSecondDropdown, ModuleEditorVersionLastDropdown);
                        VersionSelect(VersionSelectI);
                        ClearAndFillTextBox ModuleEditorLicenseClearNFill = new ClearAndFillTextBox(ModuleEditorLicenseTextBox, EditModule.ModuleLicense);
                        Browser.ClearAndFillTextBox(ModuleEditorLicenseClearNFill);
                        ClearAndFillTextBox ModuleEditorReleaseNotesClearNFill = new ClearAndFillTextBox(ModuleEditorReleaseNotes, EditModule.ModuleReleaseNotes);
                        Browser.ClearAndFillTextBox(ModuleEditorReleaseNotesClearNFill);
                        ClearAndFillTextBox ModuleEditorOwnerClearNFill = new ClearAndFillTextBox(ModuleEditorOwnerTextBox, EditModule.ModuleOwner);
                        Browser.ClearAndFillTextBox(ModuleEditorOwnerClearNFill);
                        ClearAndFillTextBox ModuleEditorOrganizationClearNFill = new ClearAndFillTextBox(ModuleEditorOrganizationTextBox, EditModule.ModuleOrganization);
                        Browser.ClearAndFillTextBox(ModuleEditorOrganizationClearNFill);
                        ClearAndFillTextBox ModuleEditorUrlClearNFill = new ClearAndFillTextBox(ModuleEditorUrlTextBox, EditModule.ModuleUrl);
                        Browser.ClearAndFillTextBox(ModuleEditorUrlClearNFill);
                        ClearAndFillTextBox ModuleEditorEmailClearNFill = new ClearAndFillTextBox(ModuleEditorEmailTextBox, EditModule.ModuleEmail);
                        Browser.ClearAndFillTextBox(ModuleEditorEmailClearNFill);
                        switch (EditModule.UpdateSave)
                        {
                            case true:
                                {
                                    ModuleEditorUpdate.Click();
                                    break;
                                }
                            default:
                                {
                                    switch (EditModule.UninstallModule)
                                    {
                                        case true:
                                            {
                                                ModuleInstallBtn.Click();
                                                //Browser.ProcessRun(FilePath);
                                                break;
                                            }
                                        default:
                                            {
                                                ModuleCancel.Click();
                                                break;
                                            }
                                    }
                                    break;
                                }
                        }
                    }
                }
                IWebElement DeleteModuleLink = ModuleLink(7);
                DeleteModuleLink.Click();
                Confirmation(EditModule.Delete, 55);
            }
            catch (Exception ex)
            {
               // throw ex;
            }           
        }       
    }
}