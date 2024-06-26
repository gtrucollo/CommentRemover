// ------------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by VSIX Synchronizer
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CommentRemover
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidPackageString = "34f42dd5-2285-4902-bdfa-6d721e867b57";
        public static Guid guidPackage = new Guid(guidPackageString);

        public const string guidXmlUiCmdsString = "fb87333b-16c8-400e-bc8f-f6b890410582";
        public static Guid guidXmlUiCmds = new Guid(guidXmlUiCmdsString);

        public const string guidPackageCmdSetString = "d7952971-879b-431d-b743-70ad7e99e846";
        public static Guid guidPackageCmdSet = new Guid(guidPackageCmdSetString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenu = 0x1000;
        public const int CommentsGroup = 0x1020;
        public const int XmlDocGroup = 0x1030;
        public const int RegionGroup = 0x1040;
        public const int TaskGroup = 0x1050;
        public const int RemoveAllComments = 0x0100;
        public const int RemoveAllSelectedComments = 0x0110;
        public const int RemoveRegions = 0x0200;
        public const int RemoveXmlDocComments = 0x0300;
        public const int RemoveAllExceptXmlDocComments = 0x0400;
        public const int RemoveTaskComments = 0x0500;
        public const int RemoveAllExceptTaskComments = 0x0600;
    }
}