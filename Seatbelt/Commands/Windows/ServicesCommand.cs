using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using O_F41F88FA.Util;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_830D0A12 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("6NbWVXQJsn0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u7OkIx1q1w4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("hMcNyBy0sL/31RbKHfezpbvHX9cbsbrstM0SzhS5rOy5wxLbBvehpLbWX9oaufK498EQ0AG2vKL3hTLXFqW6v7jEC5lZ9/fhsdcT0lf3sbm60gyeFLu57KfQEN0QpKappA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("16J/vnXX1cw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_830D0A12(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("Ehj6kHDWwI4zBPvWSZ/wmS4B/dNYzIPUKh71kGry6tVW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XHeUsD2/o/w=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("ckw5fuikyD1aQzAtm+nMIlIAAhPy6LA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MyBVXrvBuks=")[iii % 8])).ToArray()));
        var wmiData = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("3Vq9Its3J/jZBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rzXSVodUTpU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zeUHtk77+Ka+5hm8QI+v5fCTeax+yqr698Mu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nqBL8w2v2Iw=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        foreach (ManagementObject result in data)
        {
            string? serviceName = (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("EXpmKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XxsLT7EO+ho=")[iii % 8])).ToArray())];
            if (args.Length > 0 && !args.Contains(serviceName))
                continue;
            string? companyName = null;
            string? description = null;
            string? version = null;
            string? binaryPathSddl = null;
            bool? isDotNet = null;
            string? serviceCommand = GetServiceCommand(result);
            string? binaryPath = serviceCommand == null ? null : GetServiceBinaryPath(serviceCommand);
            string? serviceDll = serviceName == null ? null : GetServiceDll(serviceName);
            if (binaryPath != null && binaryPath.ToLower().EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("ee/D6+w2dmkL+c3t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JZy1iIRZBR0=")[iii % 8])).ToArray())) && serviceDll != null)
            {
                binaryPath = serviceDll;
            }

            if (!string.IsNullOrEmpty(binaryPath) && File.Exists(binaryPath))
            {
                try
                {
                    var myFileVersionInfo = FileVersionInfo.GetVersionInfo(binaryPath);
                    companyName = myFileVersionInfo.CompanyName;
                    description = myFileVersionInfo.FileDescription;
                    version = myFileVersionInfo.FileVersion;
                }
                catch
                {
                }

                if (Runtime.FilterResults && args.Length == 0)
                {
                    if (companyName != null && Regex.IsMatch(companyName, Encoding.UTF8.GetString(Convert.FromBase64String("2gOnvkKxaNbiOuD3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hE7O3TDeG7k=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }

                isDotNet = binaryPath == null ? null : (bool? )FileUtil.IsDotNetAssembly(binaryPath);
                try
                {
                    binaryPathSddl = File.GetAccessControl(binaryPath).GetSecurityDescriptorSddlForm(AccessControlSections.Owner | AccessControlSections.Access);
                }
                catch (UnauthorizedAccessException)
                {
                    WriteWarning($"Could not get the SDDL of service binary '{binaryPath}': Access denied");
                }
            }

            var serviceSddl = serviceName == null ? null : TryGetServiceSddl(serviceName);
            yield return new O_4DE83E42(serviceName, (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("KOlI3RVVd40N7V4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bIA7rXk0DsM=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("nAiNouFVvjqxApA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2G3+wZM8zk4=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("zw3Zs6oiInH5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nHm4wd5sQxw=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("8sYWj3g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("obJ3+x03bY0=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("P/0SKpWBq/AJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bIlzWOHMxJQ=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("53wTKQIvZqrNaQQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBlhX2tMA/4=")[iii % 8])).ToArray())], serviceCommand, binaryPath, binaryPathSddl, serviceDll, serviceSddl, companyName, description, version, isDotNet);
        }
    }

    private string? TryGetServiceSddl(string serviceName)
    {
        try
        {
            var info = SecurityUtil.GetSecurityInfos(serviceName, Interop.Advapi32.SE_OBJECT_TYPE.SE_SERVICE);
            return info.SDDL;
        }
        catch
        {
            return null;
        }
    }

    private string? GetServiceDll(string serviceName)
    {
        string? path = null;
        try
        {
            path = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}\\Parameters", Encoding.UTF8.GetString(Convert.FromBase64String("XOLxyuXAcAxj6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D4eDvIyjFUg=")[iii % 8])).ToArray()));
        }
        catch
        {
        }

        if (path != null)
            return path;
        try
        {
            path = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}", Encoding.UTF8.GetString(Convert.FromBase64String("C8/AMbKDRHI0xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WKqyR9vgITY=")[iii % 8])).ToArray()));
        }
        catch
        {
        }

        return path;
    }

    private string? GetServiceCommandFromRegistry(string serviceName)
    {
        try
        {
            return RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}", Encoding.UTF8.GetString(Convert.FromBase64String("cE3x82ovXShR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OSCQlA9/PFw=")[iii % 8])).ToArray()));
        }
        catch
        {
            return null;
        }
    }

    private string GetServiceBinaryPath(string command)
    {
        var path = Regex.Match(command, Encoding.UTF8.GetString(Convert.FromBase64String("ry59cT0WWY2LLxAHSWMTn9kuBD5tKET83xZGN2kRFtOIAQNySRoS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8XIqWxVNOKA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase);
        return path.Groups[1].ToString();
    }

    private string? GetServiceCommand(ManagementObject result)
    {
        string? serviceCommand;
        if (result[Encoding.UTF8.GetString(Convert.FromBase64String("qYYmMRz4Hbo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+edSWVKZcN8=")[iii % 8])).ToArray())] != null)
        {
            serviceCommand = ((string)result[Encoding.UTF8.GetString(Convert.FromBase64String("kHfM/h3nz2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wBa4llOGogw=")[iii % 8])).ToArray())]).Trim();
            if (serviceCommand == string.Empty)
            {
                serviceCommand = GetServiceCommandFromRegistry((string)result[Encoding.UTF8.GetString(Convert.FromBase64String("ohr9kA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7HuQ9VAhTMk=")[iii % 8])).ToArray())]);
            }
        }
        else
        {
            serviceCommand = GetServiceCommandFromRegistry((string)result[Encoding.UTF8.GetString(Convert.FromBase64String("0UTw8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nyWdllJor5w=")[iii % 8])).ToArray())]);
        }

        return serviceCommand;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string WGyzpQSe)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("Ehj6kHDWwI4zBPvWSZ/wmS4B/dNYzIPUKh71kGry6tVW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XHeUsD2/o/w=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("ckw5fuikyD1aQzAtm+nMIlIAAhPy6LA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MyBVXrvBuks=")[iii % 8])).ToArray()));
        var wmiData = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("3Vq9Its3J/jZBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rzXSVodUTpU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zeUHtk77+Ka+5hm8QI+v5fCTeax+yqr698Mu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nqBL8w2v2Iw=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        foreach (ManagementObject result in data)
        {
            string? serviceName = (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("EXpmKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XxsLT7EO+ho=")[iii % 8])).ToArray())];
            if (args.Length > 0 && !args.Contains(serviceName))
                continue;
            string? companyName = null;
            string? description = null;
            string? version = null;
            string? binaryPathSddl = null;
            bool? isDotNet = null;
            string? serviceCommand = GetServiceCommand(result);
            string? binaryPath = serviceCommand == null ? null : GetServiceBinaryPath(serviceCommand);
            string? serviceDll = serviceName == null ? null : GetServiceDll(serviceName);
            if (binaryPath != null && binaryPath.ToLower().EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("ee/D6+w2dmkL+c3t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JZy1iIRZBR0=")[iii % 8])).ToArray())) && serviceDll != null)
            {
                binaryPath = serviceDll;
            }

            if (!string.IsNullOrEmpty(binaryPath) && File.Exists(binaryPath))
            {
                try
                {
                    var myFileVersionInfo = FileVersionInfo.GetVersionInfo(binaryPath);
                    companyName = myFileVersionInfo.CompanyName;
                    description = myFileVersionInfo.FileDescription;
                    version = myFileVersionInfo.FileVersion;
                }
                catch
                {
                }

                if (Runtime.FilterResults && args.Length == 0)
                {
                    if (companyName != null && Regex.IsMatch(companyName, Encoding.UTF8.GetString(Convert.FromBase64String("2gOnvkKxaNbiOuD3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hE7O3TDeG7k=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase))
                    {
                        continue;
                    }
                }

                isDotNet = binaryPath == null ? null : (bool? )FileUtil.IsDotNetAssembly(binaryPath);
                try
                {
                    binaryPathSddl = File.GetAccessControl(binaryPath).GetSecurityDescriptorSddlForm(AccessControlSections.Owner | AccessControlSections.Access);
                }
                catch (UnauthorizedAccessException)
                {
                    WriteWarning($"Could not get the SDDL of service binary '{binaryPath}': Access denied");
                }
            }

            var serviceSddl = serviceName == null ? null : TryGetServiceSddl(serviceName);
            yield return new O_4DE83E42(serviceName, (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("KOlI3RVVd40N7V4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bIA7rXk0DsM=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("nAiNouFVvjqxApA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2G3+wZM8zk4=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("zw3Zs6oiInH5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nHm4wd5sQxw=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("8sYWj3g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("obJ3+x03bY0=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("P/0SKpWBq/AJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bIlzWOHMxJQ=")[iii % 8])).ToArray())], (string)result[Encoding.UTF8.GetString(Convert.FromBase64String("53wTKQIvZqrNaQQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBlhX2tMA/4=")[iii % 8])).ToArray())], serviceCommand, binaryPath, binaryPathSddl, serviceDll, serviceSddl, companyName, description, version, isDotNet);
        }
    }

    private string? TryGetServiceSddl(string serviceName, string OjitqBlY)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        try
        {
            var info = SecurityUtil.GetSecurityInfos(serviceName, Interop.Advapi32.SE_OBJECT_TYPE.SE_SERVICE);
            return info.SDDL;
        }
        catch
        {
            return null;
        }
    }

    private string? GetServiceDll(string serviceName, string IqYeAixf)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string? path = null;
        try
        {
            path = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}\\Parameters", Encoding.UTF8.GetString(Convert.FromBase64String("XOLxyuXAcAxj6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D4eDvIyjFUg=")[iii % 8])).ToArray()));
        }
        catch
        {
        }

        if (path != null)
            return path;
        try
        {
            path = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}", Encoding.UTF8.GetString(Convert.FromBase64String("C8/AMbKDRHI0xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WKqyR9vgITY=")[iii % 8])).ToArray()));
        }
        catch
        {
        }

        return path;
    }

    private string? GetServiceCommandFromRegistry(string serviceName, string hMOnvShN)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        try
        {
            return RegistryUtil.GetStringValue(RegistryHive.LocalMachine, $"SYSTEM\\CurrentControlSet\\Services\\{serviceName}", Encoding.UTF8.GetString(Convert.FromBase64String("cE3x82ovXShR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OSCQlA9/PFw=")[iii % 8])).ToArray()));
        }
        catch
        {
            return null;
        }
    }

    private string GetServiceBinaryPath(string command, string TOuOYiWF)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var path = Regex.Match(command, Encoding.UTF8.GetString(Convert.FromBase64String("ry59cT0WWY2LLxAHSWMTn9kuBD5tKET83xZGN2kRFtOIAQNySRoS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8XIqWxVNOKA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase);
        return path.Groups[1].ToString();
    }

    private string? GetServiceCommand(ManagementObject result, string IkZrYtbW)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string? serviceCommand;
        if (result[Encoding.UTF8.GetString(Convert.FromBase64String("qYYmMRz4Hbo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+edSWVKZcN8=")[iii % 8])).ToArray())] != null)
        {
            serviceCommand = ((string)result [Encoding.UTF8.GetString(Convert.FromBase64String("kHfM/h3nz2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wBa4llOGogw=") [iii % 8])).ToArray())]).Trim();
            if (serviceCommand == string.Empty)
            {
                serviceCommand = GetServiceCommandFromRegistry((string)result[Encoding.UTF8.GetString(Convert.FromBase64String("ohr9kA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7HuQ9VAhTMk=")[iii % 8])).ToArray())]);
            }
        }
        else
        {
            serviceCommand = GetServiceCommandFromRegistry((string)result[Encoding.UTF8.GetString(Convert.FromBase64String("0UTw8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nyWdllJor5w=")[iii % 8])).ToArray())]);
        }

        return serviceCommand;
    }
}internal class O_4DE83E42 : O_4AED570F
{
    public O_4DE83E42(string? name, string? displayName, string? description, string? user, string? state, string? startMode, string? type, string? serviceCommand, string? binaryPath, string? binaryPathSddl, string? serviceDll, string? serviceSddl, string? companyName, string? fileDescription, string? version, bool? isDotNet)
    {
        Name = name;
        DisplayName = displayName;
        Description = description;
        User = user;
        State = state;
        StartMode = startMode;
        Type = type;
        ServiceCommand = serviceCommand;
        BinaryPath = binaryPath;
        BinaryPathSDDL = binaryPathSddl;
        ServiceDll = serviceDll;
        ServiceSDDL = serviceSddl;
        CompanyName = companyName;
        FileDescription = fileDescription;
        Version = version;
        IsDotNet = isDotNet;
    }

    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? User { get; set; }
    public string? State { get; set; }
    public string? StartMode { get; set; }
    public string? Type { get; set; }
    public string? ServiceCommand { get; set; }
    public string? BinaryPath { get; set; }
    public string? BinaryPathSDDL { get; set; }
    public string? ServiceDll { get; set; }
    public string? ServiceSDDL { get; set; }
    public string? CompanyName { get; set; }
    public string? FileDescription { get; set; }
    public string? Version { get; set; }
    public bool? IsDotNet { get; set; }
}}