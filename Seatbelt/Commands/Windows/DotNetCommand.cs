using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_8C8ED18A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("iYB6rLRn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ze8O4tETvZo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("CZlKO9g2vIAohE0c0izv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TfY+db1CnPY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_8C8ED18A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    private IEnumerable<string> GetCLRVersions()
    {
        var versions = new List<string>();
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("7kA48syMNBTuWjj/2owwCNRjf9LNlx8hwHY8+d+MMQzu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("shdRnKjjQ2c=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (System.IO.File.Exists($"{dir}\\System.dll"))
            {
                versions.Add(System.IO.Path.GetFileName(dir.TrimEnd(System.IO.Path.DirectorySeparatorChar)).TrimStart('v'));
            }
        }

        return versions;
    }

    public string GetOSVersion()
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("R9W/ntFSuYNDiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NbrQ6o0x0O4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("wLSLNRS5nNn2g7QZOIOcycG+ilAAhNK8oa6IADKf3fv6n6AjLp7I6v4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k/HHcFftvI8=")[iii % 8])).ToArray()));
        try
        {
            foreach (var os in wmiData.Get())
            {
                return os[Encoding.UTF8.GetString(Convert.FromBase64String("Kc+IdZqSCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f6r6BvP9Zko=")[iii % 8])).ToArray())].ToString();
            }
        }
        catch
        {
        }

        return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FUy1MxZ8n5g=")[iii % 8])).ToArray());
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var installedDotNetVersions = new List<string>();
        var installedCLRVersions = new List<string>();
        installedCLRVersions.AddRange(GetCLRVersions());
#nullable disable
        var dotNet35Version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ktJgGEU5bwSd0E8vYBdOLqfpegJXLB0Hs/xLKWUXTyrhzkM4ZwhhD4XNejohVgg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wZ0mTBJ4PUE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("V0J+mOSCOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AScM643tVE8=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(dotNet35Version))
        {
            installedDotNetVersions.Add(dotNet35Version);
        }

        var dotNet4Version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("4yok6qXaGN3sKAvdgPQ599YRPvC3z2rewgQP24X0OPOQNgfKh+sW1vQ1PsjGxwzt3Ak=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sGVivvKbSpg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("tryPwcLBaw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4Nn9squuBeQ=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(dotNet4Version))
        {
            installedDotNetVersions.Add(dotNet4Version);
        }

        int osVersionMajor = int.Parse(GetOSVersion().Split('.')[0]);
#nullable restore
        yield return new O_E5426632(installedCLRVersions.ToArray(), installedDotNetVersions.ToArray(), osVersionMajor >= 10);
    }

    private IEnumerable<string> GetCLRVersions(string LVZNCTQm)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.GetMonthsInYear(22, 41);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var versions = new List<string>();
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("7kA48syMNBTuWjj/2owwCNRjf9LNlx8hwHY8+d+MMQzu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("shdRnKjjQ2c=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (System.IO.File.Exists($"{dir}\\System.dll"))
            {
                versions.Add(System.IO.Path.GetFileName(dir.TrimEnd(System.IO.Path.DirectorySeparatorChar)).TrimStart('v'));
            }
        }

        return versions;
    }

    public string GetOSVersion(string VQPaEvlK)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.GetMonthsInYear(22, 41);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("R9W/ntFSuYNDiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NbrQ6o0x0O4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("wLSLNRS5nNn2g7QZOIOcycG+ilAAhNK8oa6IADKf3fv6n6AjLp7I6v4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k/HHcFftvI8=")[iii % 8])).ToArray()));
        try
        {
            foreach (var os in wmiData.Get())
            {
                return os[Encoding.UTF8.GetString(Convert.FromBase64String("Kc+IdZqSCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f6r6BvP9Zko=")[iii % 8])).ToArray())].ToString();
            }
        }
        catch
        {
        }

        return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FUy1MxZ8n5g=")[iii % 8])).ToArray());
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string zqxyezXw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.GetMonthsInYear(22, 41);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var installedDotNetVersions = new List<string>();
        var installedCLRVersions = new List<string>();
        installedCLRVersions.AddRange(GetCLRVersions());
#nullable disable
        var dotNet35Version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ktJgGEU5bwSd0E8vYBdOLqfpegJXLB0Hs/xLKWUXTyrhzkM4ZwhhD4XNejohVgg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wZ0mTBJ4PUE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("V0J+mOSCOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AScM643tVE8=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(dotNet35Version))
        {
            installedDotNetVersions.Add(dotNet35Version);
        }

        var dotNet4Version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("4yok6qXaGN3sKAvdgPQ599YRPvC3z2rewgQP24X0OPOQNgfKh+sW1vQ1PsjGxwzt3Ak=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sGVivvKbSpg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("tryPwcLBaw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4Nn9squuBeQ=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(dotNet4Version))
        {
            installedDotNetVersions.Add(dotNet4Version);
        }

        int osVersionMajor = int.Parse(GetOSVersion().Split('.')[0]);
#nullable restore
        yield return new O_E5426632(installedCLRVersions.ToArray(), installedDotNetVersions.ToArray(), osVersionMajor >= 10);
    }
}class O_E5426632 : O_4AED570F
{
    public O_E5426632(string[] installedCLRVersions, string[] installedDotNetVersions, bool osSupportsAmsi)
    {
        InstalledCLRVersions = installedCLRVersions;
        InstalledDotNetVersions = installedDotNetVersions;
        OsSupportsAmsi = osSupportsAmsi;
    }

    public string[] InstalledCLRVersions { get; }
    public string[] InstalledDotNetVersions { get; }
    public bool OsSupportsAmsi { get; }
}
    [CommandOutputType(typeof(O_E5426632))]
    internal class O_57A41A0A : TextFormatterBase
    {
        public O_57A41A0A(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_E5426632)result;
            var lowestVersion = dto.InstalledDotNetVersions.Min(v => (new Version(v)));
            var highestVersion = dto.InstalledDotNetVersions.Max(v => (new Version(v)));
            bool dotNetSupportsAMSI = ((highestVersion.Major >= 4) && (highestVersion.Minor >= 8));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("iqHtYe3sB3TG5MAv3dQ0OPzk1nz39whr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qoGkD56YZhg=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledCLRVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uqAgXEbv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("moAAfGbPJ4o=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UeXz8Y873qk3qbbcwWbkjQ/lhd2TO8OnNbY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W8XTuOFIqsg=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledDotNetVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UFchzRId").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cHcB7TI9OwE=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gYE0FFExkEXGwHgiXjecSNjCdTsfDJcc7tNyNFwg2UDK7EccFg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i6EUVT9F+Wg=")[iii % 8])).ToArray()));
            WriteLine($"      OS supports AMSI           : {dto.OsSupportsAmsi}");
            WriteLine($"     .NET version support AMSI   : {dotNetSupportsAMSI}");
            if ((highestVersion.Major == 4) && (highestVersion.Minor >= 8))
            {
                WriteLine($"        [!] The highest .NET version is enrolled in AMSI!");
            }

            if (dto.OsSupportsAmsi && dotNetSupportsAMSI && (((lowestVersion.Major == 3)) || ((lowestVersion.Major == 4) && (lowestVersion.Minor < 8))))
            {
                WriteLine($"        [*] You can invoke .NET version {lowestVersion.Major}.{lowestVersion.Minor} to bypass AMSI.");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string hhUxpjCc)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                        instance.GetMonthsInYear(22, 41);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_E5426632)result;
            var lowestVersion = dto.InstalledDotNetVersions.Min(v => (new Version(v)));
            var highestVersion = dto.InstalledDotNetVersions.Max(v => (new Version(v)));
            bool dotNetSupportsAMSI = ((highestVersion.Major >= 4) && (highestVersion.Minor >= 8));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("iqHtYe3sB3TG5MAv3dQ0OPzk1nz39whr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qoGkD56YZhg=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledCLRVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uqAgXEbv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("moAAfGbPJ4o=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UeXz8Y873qk3qbbcwWbkjQ/lhd2TO8OnNbY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W8XTuOFIqsg=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledDotNetVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UFchzRId").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cHcB7TI9OwE=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gYE0FFExkEXGwHgiXjecSNjCdTsfDJcc7tNyNFwg2UDK7EccFg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i6EUVT9F+Wg=")[iii % 8])).ToArray()));
            WriteLine($"      OS supports AMSI           : {dto.OsSupportsAmsi}");
            WriteLine($"     .NET version support AMSI   : {dotNetSupportsAMSI}");
            if ((highestVersion.Major == 4) && (highestVersion.Minor >= 8))
            {
                WriteLine($"        [!] The highest .NET version is enrolled in AMSI!");
            }

            if (dto.OsSupportsAmsi && dotNetSupportsAMSI && (((lowestVersion.Major == 3)) || ((lowestVersion.Major == 4) && (lowestVersion.Minor < 8))))
            {
                WriteLine($"        [*] You can invoke .NET version {lowestVersion.Major}.{lowestVersion.Minor} to bypass AMSI.");
            }
        }
    }
}