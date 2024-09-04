using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_7A9774E1 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("1BtJmI5Jvug=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("knIl/ccn2Ic=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+0GnEhBKhqLbQK9dA0WIo8YPoF0ETouzkge3GBBUjrncD6gTBEiVu9NbqBIMC8ei20KkDhZGiqbBA+EfA1SOtZJ/hF0LSYG5ng+kCQEJx7fASLQQB0mT/sEG4UBfB4G/3krhDQNTj/7BBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("si/BfWIn59Y=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_7A9774E1(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (args.Length == 0)
        {
            var WinDir = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("rlMeD8YZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+RpQS49L8i0=")[iii % 8])).ToArray()));
            if (!Runtime.FilterResults)
            {
                args = new string[]
                {
                    $"{WinDir}\\system32\\drivers\\afd.sys",
                    $"{WinDir}\\system32\\coremessaging.dll",
                    $"{WinDir}\\system32\\dssvc.dll",
                    $"{WinDir}\\system32\\gdiplus.dll",
                    $"{WinDir}\\system32\\gpprefcl.dll",
                    $"{WinDir}\\system32\\drivers\\mrxdav.sys",
                    $"{WinDir}\\system32\\ntoskrnl.exe",
                    $"{WinDir}\\system32\\pcadm.dll",
                    $"{WinDir}\\system32\\rpcrt4.dll",
                    $"{WinDir}\\system32\\schedsvc.dll",
                    $"{WinDir}\\system32\\seclogon.dll",
                    $"{WinDir}\\system32\\win32k.sys",
                    $"{WinDir}\\system32\\win32kfull.sys",
                    $"{WinDir}\\system32\\winload.exe",
                    $"{WinDir}\\system32\\winsrv.dll",
                };
            }
            else
            {
                args = new string[]
                {
                    $"{WinDir}\\system32\\ntoskrnl.exe"};
            }
        }

        foreach (var file in args)
        {
            if (File.Exists(file) && (File.GetAttributes(file) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                FileVersionInfo versionInfo;
                FileInfo fileInfo;
                FileSecurity security;
                try
                {
                    versionInfo = FileVersionInfo.GetVersionInfo(file);
                    fileInfo = new FileInfo(file);
                    security = File.GetAccessControl(file);
                }
                catch (Exception ex)
                {
                    if (ex is FileNotFoundException || ex is SystemException)
                    {
                        WriteError($"  [!] Could not locate {file}\n");
                    }
                    else if (ex is SecurityException || ex is UnauthorizedAccessException)
                    {
                        WriteError($"  [!] Insufficient privileges to access {file}\n");
                    }
                    else if (ex is ArgumentException || ex is NotSupportedException || ex is PathTooLongException)
                    {
                        WriteError($"  [!] Path \"{file}\" is an invalid format\n");
                    }
                    else
                    {
                        WriteError($"  [!] Error accessing {file}\n");
                    }

                    continue;
                }

                if (versionInfo != null && fileInfo != null && security != null)
                {
                    var isDotNet = FileUtil.IsDotNetAssembly(file);
                    yield return new O_880491F6(versionInfo.Comments, versionInfo.CompanyName, versionInfo.FileDescription, versionInfo.FileName, versionInfo.FileVersion, versionInfo.InternalName, versionInfo.IsDebug, isDotNet, versionInfo.IsPatched, versionInfo.IsPreRelease, versionInfo.IsPrivateBuild, versionInfo.IsSpecialBuild, versionInfo.Language, versionInfo.LegalCopyright, versionInfo.LegalTrademarks, versionInfo.OriginalFilename, versionInfo.PrivateBuild, versionInfo.ProductName, versionInfo.ProductVersion, versionInfo.SpecialBuild, fileInfo.Attributes, fileInfo.CreationTimeUtc, fileInfo.LastAccessTimeUtc, fileInfo.LastWriteTimeUtc, fileInfo.Length, security.GetSecurityDescriptorSddlForm(AccessControlSections.Access | AccessControlSections.Owner));
                }
            }
            else
            {
                DirectorySecurity directorySecurity;
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(file);
                    directorySecurity = directoryInfo.GetAccessControl();
                }
                catch (Exception ex)
                {
                    if (ex is FileNotFoundException || ex is SystemException)
                    {
                        WriteError($"  [!] Could not locate {file}\n");
                    }
                    else if (ex is SecurityException || ex is UnauthorizedAccessException)
                    {
                        WriteError($"  [!] Insufficient privileges to access {file}\n");
                    }
                    else if (ex is ArgumentException || ex is PathTooLongException)
                    {
                        WriteError($"  [!] Path \"{file}\" is an invalid format\n");
                    }
                    else
                    {
                        WriteError($"  [!] Error accessing {file}\n");
                    }

                    continue;
                }

                if (directorySecurity != null)
                {
                    yield return new O_AD14D66A(FileAttributes.Directory, Directory.GetCreationTimeUtc(file), Directory.GetLastAccessTimeUtc(file), Directory.GetLastWriteTimeUtc(file), directorySecurity.GetSecurityDescriptorSddlForm(AccessControlSections.Access | AccessControlSections.Owner));
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string hGYVDFhE)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(63);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (args.Length == 0)
        {
            var WinDir = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("rlMeD8YZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+RpQS49L8i0=")[iii % 8])).ToArray()));
            if (!Runtime.FilterResults)
            {
                args = new string[]
                {
                    $"{WinDir}\\system32\\drivers\\afd.sys",
                    $"{WinDir}\\system32\\coremessaging.dll",
                    $"{WinDir}\\system32\\dssvc.dll",
                    $"{WinDir}\\system32\\gdiplus.dll",
                    $"{WinDir}\\system32\\gpprefcl.dll",
                    $"{WinDir}\\system32\\drivers\\mrxdav.sys",
                    $"{WinDir}\\system32\\ntoskrnl.exe",
                    $"{WinDir}\\system32\\pcadm.dll",
                    $"{WinDir}\\system32\\rpcrt4.dll",
                    $"{WinDir}\\system32\\schedsvc.dll",
                    $"{WinDir}\\system32\\seclogon.dll",
                    $"{WinDir}\\system32\\win32k.sys",
                    $"{WinDir}\\system32\\win32kfull.sys",
                    $"{WinDir}\\system32\\winload.exe",
                    $"{WinDir}\\system32\\winsrv.dll",
                };
            }
            else
            {
                args = new string[]
                {
                    $"{WinDir}\\system32\\ntoskrnl.exe"};
            }
        }

        foreach (var file in args)
        {
            if (File.Exists(file) && (File.GetAttributes(file) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                FileVersionInfo versionInfo;
                FileInfo fileInfo;
                FileSecurity security;
                try
                {
                    versionInfo = FileVersionInfo.GetVersionInfo(file);
                    fileInfo = new FileInfo(file);
                    security = File.GetAccessControl(file);
                }
                catch (Exception ex)
                {
                    if (ex is FileNotFoundException || ex is SystemException)
                    {
                        WriteError($"  [!] Could not locate {file}\n");
                    }
                    else if (ex is SecurityException || ex is UnauthorizedAccessException)
                    {
                        WriteError($"  [!] Insufficient privileges to access {file}\n");
                    }
                    else if (ex is ArgumentException || ex is NotSupportedException || ex is PathTooLongException)
                    {
                        WriteError($"  [!] Path \"{file}\" is an invalid format\n");
                    }
                    else
                    {
                        WriteError($"  [!] Error accessing {file}\n");
                    }

                    continue;
                }

                if (versionInfo != null && fileInfo != null && security != null)
                {
                    var isDotNet = FileUtil.IsDotNetAssembly(file);
                    yield return new O_880491F6(versionInfo.Comments, versionInfo.CompanyName, versionInfo.FileDescription, versionInfo.FileName, versionInfo.FileVersion, versionInfo.InternalName, versionInfo.IsDebug, isDotNet, versionInfo.IsPatched, versionInfo.IsPreRelease, versionInfo.IsPrivateBuild, versionInfo.IsSpecialBuild, versionInfo.Language, versionInfo.LegalCopyright, versionInfo.LegalTrademarks, versionInfo.OriginalFilename, versionInfo.PrivateBuild, versionInfo.ProductName, versionInfo.ProductVersion, versionInfo.SpecialBuild, fileInfo.Attributes, fileInfo.CreationTimeUtc, fileInfo.LastAccessTimeUtc, fileInfo.LastWriteTimeUtc, fileInfo.Length, security.GetSecurityDescriptorSddlForm(AccessControlSections.Access | AccessControlSections.Owner));
                }
            }
            else
            {
                DirectorySecurity directorySecurity;
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(file);
                    directorySecurity = directoryInfo.GetAccessControl();
                }
                catch (Exception ex)
                {
                    if (ex is FileNotFoundException || ex is SystemException)
                    {
                        WriteError($"  [!] Could not locate {file}\n");
                    }
                    else if (ex is SecurityException || ex is UnauthorizedAccessException)
                    {
                        WriteError($"  [!] Insufficient privileges to access {file}\n");
                    }
                    else if (ex is ArgumentException || ex is PathTooLongException)
                    {
                        WriteError($"  [!] Path \"{file}\" is an invalid format\n");
                    }
                    else
                    {
                        WriteError($"  [!] Error accessing {file}\n");
                    }

                    continue;
                }

                if (directorySecurity != null)
                {
                    yield return new O_AD14D66A(FileAttributes.Directory, Directory.GetCreationTimeUtc(file), Directory.GetLastAccessTimeUtc(file), Directory.GetLastWriteTimeUtc(file), directorySecurity.GetSecurityDescriptorSddlForm(AccessControlSections.Access | AccessControlSections.Owner));
                }
            }
        }
    }
}internal class O_880491F6 : O_4AED570F
{
    public O_880491F6(string comments, string companyName, string fileDescription, string fileName, string fileVersion, string internalName, bool isDebug, bool isDotNet, bool isPatched, bool isPreRelease, bool isPrivateBuild, bool isSpecialBuild, string language, string legalCopyright, string legalTrademarks, string originalFilename, string privateBuild, string productName, string productVersion, string specialBuild, FileAttributes attributes, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, long length, string sddl)
    {
        Comments = comments;
        CompanyName = companyName;
        FileDescription = fileDescription;
        FileName = fileName;
        FileVersion = fileVersion;
        InternalName = internalName;
        IsDebug = isDebug;
        IsDotNet = isDotNet;
        IsPatched = isPatched;
        IsPreRelease = isPreRelease;
        IsPrivateBuild = isPrivateBuild;
        IsSpecialBuild = isSpecialBuild;
        Language = language;
        LegalCopyright = legalCopyright;
        LegalTrademarks = legalTrademarks;
        OriginalFilename = originalFilename;
        PrivateBuild = privateBuild;
        ProductName = productName;
        ProductVersion = productVersion;
        SpecialBuild = specialBuild;
        Attributes = attributes;
        CreationTimeUtc = creationTimeUtc;
        LastAccessTimeUtc = lastAccessTimeUtc;
        LastWriteTimeUtc = lastWriteTimeUtc;
        Length = length;
        SDDL = sddl;
    }

    public string Comments { get; }
    public string CompanyName { get; }
    public string FileDescription { get; }
    public string FileName { get; }
    public string FileVersion { get; }
    public string InternalName { get; }
    public bool IsDebug { get; }
    public bool IsDotNet { get; }
    public bool IsPatched { get; }
    public bool IsPreRelease { get; }
    public bool IsPrivateBuild { get; }
    public bool IsSpecialBuild { get; }
    public string Language { get; }
    public string LegalCopyright { get; }
    public string LegalTrademarks { get; }
    public string OriginalFilename { get; }
    public string PrivateBuild { get; }
    public string ProductName { get; }
    public string ProductVersion { get; }
    public string SpecialBuild { get; }
    public FileAttributes Attributes { get; }
    public DateTime CreationTimeUtc { get; }
    public DateTime LastAccessTimeUtc { get; }
    public DateTime LastWriteTimeUtc { get; }
    public long Length { get; }
    public string SDDL { get; }
}
    internal class O_AD14D66A : O_4AED570F
    {
        public O_AD14D66A(FileAttributes attributes, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, string sddl)
        {
            Attributes = attributes;
            CreationTimeUtc = creationTimeUtc;
            LastAccessTimeUtc = lastAccessTimeUtc;
            LastWriteTimeUtc = lastWriteTimeUtc;
            SDDL = sddl;
        }

        public FileAttributes Attributes { get; }
        public DateTime CreationTimeUtc { get; }
        public DateTime LastAccessTimeUtc { get; }
        public DateTime LastWriteTimeUtc { get; }
        public string SDDL { get; }
    }
}