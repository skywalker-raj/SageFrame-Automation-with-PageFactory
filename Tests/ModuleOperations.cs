﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using QASageframe;
using System;
namespace SageframeTest
{
    [TestClass]
    public class ModuleOperations
    {
        [TestMethod]
        public void Can_Module_Operations()
        {
            string[] Source = { "Modules/Admin/CacheMaintenance/CacheMaintenance.ascx", "Modules/Admin/CDN/CDNView.ascx" };
            string[] Key = { "test", "test1" };
            string[] Title = { "test", "test1" };
            string[] ControlType = { "View", "Edit" };
            string[] Icon = { "Not Specified", "Not Specified" };
            string[] HelpUrl = { "www.google.com", "www.gmail.com" };
            bool[] Update = { true, true };
            bool[] Next = { true, true, true, true };
            bool[] Previous = { false, false, false, false };
            string[] Modules = { "AudioPlayer", "Breadcrumb" };
            string[] Assembly = { "ContactUs.dll", "ContactUs.pdb" };
            string[] FolderFiles = { "contactus.ascx", "contactus.ascx.cs", "contactusedit.ascx", "contactusedit.ascx.cs" };
            //Create Package
            string PackageName = "test";
            string PackageDescription = "test";
            int VersionFirst = 1;
            int VersionSecond = 1;
            int VersionLast = 1;
            string PackageLicense = "test";
            string PackageReleaseNotes = "test";
            string PackageOwner = "test";
            string PackageOrganization = "test";
            string PackageUrl = "www.google.com";
            string PackageEmail = "illusionineyes@gmail.com";
            string FriendlyName = "test";
            string ModuleName = "test";
            string BusinessControllerClass = "test";
            string CompatibleVersion = "test";
            int CacheTime = 1000;
            string ModuleFolder = "ContactUs";
            bool FileUploadInstall = false;
            string InstallFileUpload = @"";
            string InstallScript = "test";
            bool FileUploadUnistall = false;
            string UnistallFileUpload = @"";
            string UnistallScript = "test";
            bool IncludeSource = true;
            bool allfilesselect = true;
            string viewcontrol = "contactus.ascx";
            string ViewKey = "test";
            string ViewTitle = "test";
            string ViewIcon = "";
            string ViewHelpUrl = "www.google.com";
            string EditControl = "contactus.ascx";
            string EditKey = "test";
            string EditTitle = "test";
            string EditIcon = "";
            string EditHelpUrl = "www.google.com";
            string SettingControl = "contactus.ascx";
            string SettingKey = "test";
            string SettingTitle = "test";
            string SettingIcon = "";
            string SettingHelpUrl = "www.google.com";
            bool Submit = true;
            try
            {
                Browser.GoTo(Module.ModulePage.Url);
                Assert.IsTrue(Browser.IsAt(Browser.Title, Browser.LoginTitle));
                Admin.AdminPage.LogIn("superuser", "superuser");
                Assert.IsTrue(Browser.IsAt(Browser.Title, Module.ModulePage.Text));
                //Module.ModulePage.Create_CompositePackage("test", "test", "test", 1, 2, 3, "test", "test", "test", "test", "www.google.com", "illusionineyes@gmail.com", Modules, true, true);
                //Module.ModulePage.Create_Package(PackageName, PackageDescription, VersionFirst, VersionSecond, VersionLast, PackageLicense, PackageReleaseNotes, PackageOwner, PackageOrganization, PackageUrl, PackageEmail, FriendlyName, ModuleName, BusinessControllerClass, CompatibleVersion, CacheTime, ModuleFolder, Next, FileUploadInstall, InstallFileUpload, InstallScript, FileUploadUnistall, UnistallFileUpload, UnistallScript, IncludeSource, Previous, FolderFiles, allfilesselect, viewcontrol, ViewKey, ViewTitle, ViewIcon, ViewHelpUrl, EditControl, EditKey, EditTitle, EditIcon, EditHelpUrl, SettingControl, SettingKey, SettingTitle, SettingIcon, SettingHelpUrl, Assembly, Submit);
                Module.ModulePage.Install_Module(@"E:\Module to test\New folder\AudioPlayer.zip", Next, true, true);
                //Module.ModulePage.Edit_Module("test", true, false, true, true, true, true, true, true, true, true, Source, Key, Title, ControlType, Icon, HelpUrl, Update, true, false, "test", "test", 100, "Admin/CDN", "test", "test", "test", true, true, true, true, "test", "test", "test", "test", "test", "test", "www.google.com", "illusionineyes@gmail.com", true, true);
                //Browser.Teardown();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}