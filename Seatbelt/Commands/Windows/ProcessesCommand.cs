using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Util;
using System.ComponentModel;
using System.Runtime.InteropServices;
using O_F41F88FA.Interop;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_F148224A
    {
        public O_F148224A(string moduleName, string moduleFileName, string moduleFileDescription, string moduleOriginalFilename, string moduleCompanyName)
        {
            ModuleName = moduleName;
            ModuleFileName = moduleFileName;
            ModuleFileDescription = moduleFileDescription;
            ModuleOriginalFilename = moduleOriginalFilename;
            ModuleCompanyName = moduleCompanyName;
        }

        public string ModuleName { get; set; }
        public string ModuleFileName { get; set; }
        public string ModuleFileDescription { get; set; }
        public string ModuleOriginalFilename { get; set; }
        public string ModuleCompanyName { get; set; }
    }
internal class O_3B68F2AE : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("mSTQhN1UYv66").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yVa/57gnEZs=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("4pnEo45uFJjAnsWugnMA3cPM3aSTaFPe2YDP7Y5uFdeQj8Wgl2EdwZCCy6CCc1PM2I3e7YNvHZ/EzMmiiXQS0d7MjYCOYwHXw4PMucAsU5qdit+hiyJT3d6Zx6iVYQfdw8zLoYsgA8rfj8++lGUA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sOyqzecAc7g=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_3B68F2AE(Runtime runtime) : base(runtime)
    {
    }

    private int? GetProcessProtectionInfo(int ProcessId)
    {
        int pplValueString;
        IntPtr ProcessHandle = Kernel32.OpenProcess(Interop.Kernel32.ProcessAccess.QueryLimitedInformation, false, ProcessId);
        if (ProcessHandle == null)
        {
            WriteError($" [!] Could not get a handle to ProcessId " + ProcessId);
        }

        PsProtection ppl = new PsProtection();
        int returnlength;
        int status = Ntdll.NtQueryInformationProcess(ProcessHandle, PROCESSINFOCLASS.ProcessProtectionInformation, ref ppl, Marshal.SizeOf(ppl), out returnlength);
        if (status != 0)
        {
            WriteError($" [!] Could not get Process Protection Info for ProcessId " + ProcessId);
            var handleResult = Kernel32.CloseHandle(ProcessHandle);
            return null;
        }
        else
        {
            pplValueString = ((byte)ppl.Type | (byte)ppl.Audit | (int)ppl.Signer << 4);
            return pplValueString;
        }
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var enumerateModules = args.Length == 1 && args[0].ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("6++0H40FDA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hoDQauFgfy8=")[iii % 8])).ToArray()));
        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("bNMmVDWJZG1B22p2P4QwSUbfOFcjhXZwD+w4VzOPY3dKz2oQJoNxJHjxAxFa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7xKOFDqEAQ=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("m2b5aOs3Wu62brVF4jgO16pm9mH9J0v0+CHjbe90ecqRIJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2AmVBI5ULoc=")[iii % 8])).ToArray()));
        var wmiQueryString = Encoding.UTF8.GetString(Convert.FromBase64String("QL0rdiwMzrdhlwRWHCungz/YN1IdPYCTQ4oIUAorna531Ed2Fz2NkmeZBV8KCI+Te9RHcAA1g4Z9nCtaAT3OoUG3KhM4MYDUIac3QQA7i5Rg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E/hnM29Y7uc=")[iii % 8])).ToArray());
        using var searcher = new ManagementObjectSearcher(wmiQueryString);
        using var results = searcher.Get();
        var query =
            from p in Process.GetProcesses()join mo in results.Cast<ManagementObject>()on p.Id equals (int)(uint)mo[Encoding.UTF8.GetString(Convert.FromBase64String("BOOHowIPeqAw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VJHowGd8Cek=")[iii % 8])).ToArray())]
            select new
            {
                Process = p,
                ParentProcessId = (UInt32)mo[Encoding.UTF8.GetString(Convert.FromBase64String("0akKLzCywNDuqx05LY/0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gch4Sl7GkKI=")[iii % 8])).ToArray())],
                Path = (string)mo[Encoding.UTF8.GetString(Convert.FromBase64String("wcB55mBHxs7o3UzkYVs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hLgchRUzp6w=")[iii % 8])).ToArray())],
                CommandLine = (string)mo[Encoding.UTF8.GetString(Convert.FromBase64String("VPAOgJLdOuR+8QY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F59j7fOzXqg=")[iii % 8])).ToArray())],
            };
        foreach (var proc in query)
        {
            var isDotNet = false;
            string? companyName = null;
            string? description = null;
            string? version = null;
            int? ProtectionLevelinfo = null;
            if (!SecurityUtil.IsHighIntegrity() || proc.Process.Id == 0)
            {
                ProtectionLevelinfo = null;
            }
            else
            {
                ProtectionLevelinfo = GetProcessProtectionInfo(proc.Process.Id);
            }

            if (proc.Path != null)
            {
                isDotNet = FileUtil.IsDotNetAssembly(proc.Path);
                try
                {
                    var myFileVersionInfo = FileVersionInfo.GetVersionInfo(proc.Path);
                    companyName = myFileVersionInfo.CompanyName;
                    description = myFileVersionInfo.FileDescription;
                    version = myFileVersionInfo.FileVersion;
                }
                catch
                {
                }
            }

            if (Runtime.FilterResults)
            {
                if (companyName == null || string.IsNullOrEmpty(companyName.Trim()) || (companyName != null && Regex.IsMatch(companyName, Encoding.UTF8.GetString(Convert.FromBase64String("o8htXEOQ3Pab8SoV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/YUEPzH/r5k=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase)))
                {
                    continue;
                }
            }

            var processModules = new List<O_F148224A>();
            if (enumerateModules)
            {
                try
                {
                    var modules = proc.Process.Modules;
                    foreach (ProcessModule module in modules)
                    {
                        var ProcessModule = new O_F148224A(module.ModuleName, module.FileVersionInfo.FileName, module.FileVersionInfo.FileDescription, module.FileVersionInfo.OriginalFilename, module.FileVersionInfo.CompanyName);
                        processModules.Add(ProcessModule);
                    }
                }
                catch
                {
                }
            }

            yield return new O_5129D851(proc.Process.ProcessName, proc.Process.Id, (int)proc.ParentProcessId, companyName, description, version, proc.Path, proc.CommandLine, isDotNet, processModules, ProtectionLevelinfo);
        }
    }

    private int? GetProcessProtectionInfo(int ProcessId, string einOHAOP)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
                    instance.IsLeapYear(57, 65);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        int pplValueString;
        IntPtr ProcessHandle = Kernel32.OpenProcess(Interop.Kernel32.ProcessAccess.QueryLimitedInformation, false, ProcessId);
        if (ProcessHandle == null)
        {
            WriteError($" [!] Could not get a handle to ProcessId " + ProcessId);
        }

        PsProtection ppl = new PsProtection();
        int returnlength;
        int status = Ntdll.NtQueryInformationProcess(ProcessHandle, PROCESSINFOCLASS.ProcessProtectionInformation, ref ppl, Marshal.SizeOf(ppl), out returnlength);
        if (status != 0)
        {
            WriteError($" [!] Could not get Process Protection Info for ProcessId " + ProcessId);
            var handleResult = Kernel32.CloseHandle(ProcessHandle);
            return null;
        }
        else
        {
            pplValueString = ((byte)ppl.Type | (byte)ppl.Audit | (int)ppl.Signer << 4);
            return pplValueString;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string zNxeecQC)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
                    instance.IsLeapYear(93, 34);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var enumerateModules = args.Length == 1 && args[0].ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("6++0H40FDA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hoDQauFgfy8=")[iii % 8])).ToArray()));
        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("bNMmVDWJZG1B22p2P4QwSUbfOFcjhXZwD+w4VzOPY3dKz2oQJoNxJHjxAxFa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7xKOFDqEAQ=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("m2b5aOs3Wu62brVF4jgO16pm9mH9J0v0+CHjbe90ecqRIJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2AmVBI5ULoc=")[iii % 8])).ToArray()));
        var wmiQueryString = Encoding.UTF8.GetString(Convert.FromBase64String("QL0rdiwMzrdhlwRWHCungz/YN1IdPYCTQ4oIUAorna531Ed2Fz2NkmeZBV8KCI+Te9RHcAA1g4Z9nCtaAT3OoUG3KhM4MYDUIac3QQA7i5Rg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E/hnM29Y7uc=")[iii % 8])).ToArray());
        using var searcher = new ManagementObjectSearcher(wmiQueryString);
        using var results = searcher.Get();
        var query =
            from p in Process.GetProcesses()join mo in results.Cast<ManagementObject>()on p.Id equals (int)(uint)mo[Encoding.UTF8.GetString(Convert.FromBase64String("BOOHowIPeqAw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VJHowGd8Cek=")[iii % 8])).ToArray())]
            select new
            {
                Process = p,
                ParentProcessId = (UInt32)mo[Encoding.UTF8.GetString(Convert.FromBase64String("0akKLzCywNDuqx05LY/0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gch4Sl7GkKI=")[iii % 8])).ToArray())],
                Path = (string)mo[Encoding.UTF8.GetString(Convert.FromBase64String("wcB55mBHxs7o3UzkYVs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hLgchRUzp6w=")[iii % 8])).ToArray())],
                CommandLine = (string)mo[Encoding.UTF8.GetString(Convert.FromBase64String("VPAOgJLdOuR+8QY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F59j7fOzXqg=")[iii % 8])).ToArray())],
            };
        foreach (var proc in query)
        {
            var isDotNet = false;
            string? companyName = null;
            string? description = null;
            string? version = null;
            int? ProtectionLevelinfo = null;
            if (!SecurityUtil.IsHighIntegrity() || proc.Process.Id == 0)
            {
                ProtectionLevelinfo = null;
            }
            else
            {
                ProtectionLevelinfo = GetProcessProtectionInfo(proc.Process.Id);
            }

            if (proc.Path != null)
            {
                isDotNet = FileUtil.IsDotNetAssembly(proc.Path);
                try
                {
                    var myFileVersionInfo = FileVersionInfo.GetVersionInfo(proc.Path);
                    companyName = myFileVersionInfo.CompanyName;
                    description = myFileVersionInfo.FileDescription;
                    version = myFileVersionInfo.FileVersion;
                }
                catch
                {
                }
            }

            if (Runtime.FilterResults)
            {
                if (companyName == null || string.IsNullOrEmpty(companyName.Trim()) || (companyName != null && Regex.IsMatch(companyName, Encoding.UTF8.GetString(Convert.FromBase64String("o8htXEOQ3Pab8SoV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/YUEPzH/r5k=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase)))
                {
                    continue;
                }
            }

            var processModules = new List<O_F148224A>();
            if (enumerateModules)
            {
                try
                {
                    var modules = proc.Process.Modules;
                    foreach (ProcessModule module in modules)
                    {
                        var ProcessModule = new O_F148224A(module.ModuleName, module.FileVersionInfo.FileName, module.FileVersionInfo.FileDescription, module.FileVersionInfo.OriginalFilename, module.FileVersionInfo.CompanyName);
                        processModules.Add(ProcessModule);
                    }
                }
                catch
                {
                }
            }

            yield return new O_5129D851(proc.Process.ProcessName, proc.Process.Id, (int)proc.ParentProcessId, companyName, description, version, proc.Path, proc.CommandLine, isDotNet, processModules, ProtectionLevelinfo);
        }
    }
}internal class O_5129D851 : O_4AED570F
{
    public O_5129D851(string processName, int processId, int parentProcessId, string? companyName, string? description, string? version, string? path, string commandLine, bool? isDotNet, List<O_F148224A> modules, int? ProtectionLevelinfo)
    {
        ProcessName = processName;
        ProcessId = processId;
        ParentProcessId = parentProcessId;
        CompanyName = companyName;
        Description = description;
        Version = version;
        Path = path;
        CommandLine = commandLine;
        IsDotNet = isDotNet;
        Modules = modules;
        ProcessProtectionLevelinfo = ProtectionLevelinfo;
    }

    public string ProcessName { get; set; }
    public string? CompanyName { get; set; }
    public string? Description { get; set; }
    public string? Version { get; set; }
    public int ProcessId { get; set; }
    public int ParentProcessId { get; set; }
    public string? Path { get; set; }
    public string CommandLine { get; set; }
    public bool? IsDotNet { get; set; }
    public List<O_F148224A> Modules { get; set; }
    public int? ProcessProtectionLevelinfo { get; set; }
}
    [CommandOutputType(typeof(O_5129D851))]
    internal class O_3839AA47 : TextFormatterBase
    {
        public O_3839AA47(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_5129D851)result;
            string? ProtectionLevelString;
            if (dto.ProcessProtectionLevelinfo == null)
            {
                ProtectionLevelString = null;
            }
            else
            {
                string pplValue = ((int)dto.ProcessProtectionLevelinfo).ToString(Encoding.UTF8.GetString(Convert.FromBase64String("OA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YD9j1fZWKkA=")[iii % 8])).ToArray()));
                ProtectionValueName protectionLevel = (ProtectionValueName)Enum.Parse(typeof(ProtectionValueName), pplValue, true);
                string protectionValueName = protectionLevel.ToString();
                string pplValueHex = Encoding.UTF8.GetString(Convert.FromBase64String("5ULT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zXKrYy3Rx94=")[iii % 8])).ToArray()) + pplValue + Encoding.UTF8.GetString(Convert.FromBase64String("TQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZNuqFL7ff4o=")[iii % 8])).ToArray());
                ProtectionLevelString = protectionValueName + pplValueHex;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b5d4xz4CI+9v1miQIks=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T+xI6xM2E5I=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gbj7VX6Mf6+wp/E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0cqUNhv/DOE=")[iii % 8])).ToArray()), dto.ProcessName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mjLXR3r5uIqac8cQZrA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uknna1fNiPc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("maqmTUD/Kk2t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ydjJLiWMWQQ=")[iii % 8])).ToArray()), dto.ProcessId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("bLOa1anSV/Ns8oqCtZs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TMiq+YTmZ44=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("42h03i/DvE/camPIMv6I").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("swkGu0G37D0=")[iii % 8])).ToArray()), dto.ParentProcessId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Iq0LwQD/ho8i7BuWHLY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AtY77S3LtvI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("u5nikjnMk9eZm+o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+PaP4lii6pk=")[iii % 8])).ToArray()), dto.CompanyName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z0EErtu3njPPABT5x/4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7zo0gvaDrk4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("jPbmmBpc2bah/Ps=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yJOV+2g1qcI=")[iii % 8])).ToArray()), dto.Description);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b6Vhgk6E3JFv5HHVUs0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T95RrmOw7Ow=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Vod4G5CjPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AOIKaPnMUZ4=")[iii % 8])).ToArray()), dto.Version);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Z1vp7a8O4CBnGvm6s0c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RyDZwYI60F0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("kNcdBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wLZpb11STas=")[iii % 8])).ToArray()), dto.Path);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GkISRRSSg80aAwISCNs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OjkiaTmms7A=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("cR8KgxjQhmlbHgI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MnBn7nm+4iU=")[iii % 8])).ToArray()), dto.CommandLine);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XQntt38Y9RRdSP3gY1E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fXLdm1IsxWk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("w5hoPAULryA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iussU3FFylQ=")[iii % 8])).ToArray()), dto.IsDotNet);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("u2JR7C1hOxC7I0G7MSg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mxlhwABVC20=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rPQemoLcwlmO6QWchNvYZpLPH5+I3dxoiO8elw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/IZx+eevsQk=")[iii % 8])).ToArray()), ProtectionLevelString);
            if (dto.Modules.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("n5UaFsimcLGf1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v+4qOuWSQMw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DV6oM/XYGQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QDHMRpm9asI=")[iii % 8])).ToArray()));
                foreach (var module in dto.Modules)
                {
                    if (!filterResults || String.IsNullOrEmpty(module.ModuleCompanyName) || !Regex.IsMatch(module.ModuleCompanyName, Encoding.UTF8.GetString(Convert.FromBase64String("galN0FyrGby5kAqZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3+Qksy7EatM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("86abfXOnLWPp/dBgOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("092rUUeXUEM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/Auhew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("smrMHv8Wzho=")[iii % 8])).ToArray()), module.ModuleName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("o70+XeKGD3K55nVAqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g8YOcda2clI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bkeWaTqgih9MRZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LSj7GVvO81E=")[iii % 8])).ToArray()), module.ModuleCompanyName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9+A4GPOvkv3tu3MFug==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("15sINMef790=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("RoJhqg/QwAo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AOsNz0GxrW8=")[iii % 8])).ToArray()), module.ModuleFileName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ipdjFwZKs0mQzCgKTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("quxTOzJ6zmk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("L/kF2NUVMtQm4gDa8ho+3Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YItsv7x7U7g=")[iii % 8])).ToArray()), module.ModuleOriginalFilename);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YPiclZlVPxR6o9eI0G8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QIOsua1lQjQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("7Zwz2rvsjGnZnC/LluaR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q/Vfv/+J/wo=")[iii % 8])).ToArray()), module.ModuleFileDescription);
                    }
                }
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string sIqyIXub)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(93, 34);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_5129D851)result;
            string? ProtectionLevelString;
            if (dto.ProcessProtectionLevelinfo == null)
            {
                ProtectionLevelString = null;
            }
            else
            {
                string pplValue = ((int)dto.ProcessProtectionLevelinfo).ToString(Encoding.UTF8.GetString(Convert.FromBase64String("OA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YD9j1fZWKkA=")[iii % 8])).ToArray()));
                ProtectionValueName protectionLevel = (ProtectionValueName)Enum.Parse(typeof(ProtectionValueName), pplValue, true);
                string protectionValueName = protectionLevel.ToString();
                string pplValueHex = Encoding.UTF8.GetString(Convert.FromBase64String("5ULT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zXKrYy3Rx94=")[iii % 8])).ToArray()) + pplValue + Encoding.UTF8.GetString(Convert.FromBase64String("TQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZNuqFL7ff4o=")[iii % 8])).ToArray());
                ProtectionLevelString = protectionValueName + pplValueHex;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b5d4xz4CI+9v1miQIks=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T+xI6xM2E5I=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gbj7VX6Mf6+wp/E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0cqUNhv/DOE=")[iii % 8])).ToArray()), dto.ProcessName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mjLXR3r5uIqac8cQZrA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uknna1fNiPc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("maqmTUD/Kk2t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ydjJLiWMWQQ=")[iii % 8])).ToArray()), dto.ProcessId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("bLOa1anSV/Ns8oqCtZs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TMiq+YTmZ44=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("42h03i/DvE/camPIMv6I").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("swkGu0G37D0=")[iii % 8])).ToArray()), dto.ParentProcessId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Iq0LwQD/ho8i7BuWHLY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AtY77S3LtvI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("u5nikjnMk9eZm+o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+PaP4lii6pk=")[iii % 8])).ToArray()), dto.CompanyName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z0EErtu3njPPABT5x/4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7zo0gvaDrk4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("jPbmmBpc2bah/Ps=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yJOV+2g1qcI=")[iii % 8])).ToArray()), dto.Description);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b6Vhgk6E3JFv5HHVUs0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T95RrmOw7Ow=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Vod4G5CjPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AOIKaPnMUZ4=")[iii % 8])).ToArray()), dto.Version);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Z1vp7a8O4CBnGvm6s0c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RyDZwYI60F0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("kNcdBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wLZpb11STas=")[iii % 8])).ToArray()), dto.Path);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GkISRRSSg80aAwISCNs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OjkiaTmms7A=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("cR8KgxjQhmlbHgI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MnBn7nm+4iU=")[iii % 8])).ToArray()), dto.CommandLine);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XQntt38Y9RRdSP3gY1E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fXLdm1IsxWk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("w5hoPAULryA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iussU3FFylQ=")[iii % 8])).ToArray()), dto.IsDotNet);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("u2JR7C1hOxC7I0G7MSg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mxlhwABVC20=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rPQemoLcwlmO6QWchNvYZpLPH5+I3dxoiO8elw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/IZx+eevsQk=")[iii % 8])).ToArray()), ProtectionLevelString);
            if (dto.Modules.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("n5UaFsimcLGf1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v+4qOuWSQMw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DV6oM/XYGQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QDHMRpm9asI=")[iii % 8])).ToArray()));
                foreach (var module in dto.Modules)
                {
                    if (!filterResults || String.IsNullOrEmpty(module.ModuleCompanyName) || !Regex.IsMatch(module.ModuleCompanyName, Encoding.UTF8.GetString(Convert.FromBase64String("galN0FyrGby5kAqZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3+Qksy7EatM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("86abfXOnLWPp/dBgOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("092rUUeXUEM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/Auhew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("smrMHv8Wzho=")[iii % 8])).ToArray()), module.ModuleName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("o70+XeKGD3K55nVAqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g8YOcda2clI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bkeWaTqgih9MRZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LSj7GVvO81E=")[iii % 8])).ToArray()), module.ModuleCompanyName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9+A4GPOvkv3tu3MFug==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("15sINMef790=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("RoJhqg/QwAo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AOsNz0GxrW8=")[iii % 8])).ToArray()), module.ModuleFileName);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ipdjFwZKs0mQzCgKTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("quxTOzJ6zmk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("L/kF2NUVMtQm4gDa8ho+3Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YItsv7x7U7g=")[iii % 8])).ToArray()), module.ModuleOriginalFilename);
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YPiclZlVPxR6o9eI0G8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QIOsua1lQjQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("7Zwz2rvsjGnZnC/LluaR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q/Vfv/+J/wo=")[iii % 8])).ToArray()), module.ModuleFileDescription);
                    }
                }
            }

            WriteLine();
        }
    }
}