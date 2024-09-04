using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_3193AA58 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("QHjrfjb58fV8ew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EBecG0SqmZA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("2PWmUlNQ9RDk9vFBRHHuHOf0ohdAbflV+/+yQlNq6Qyo6bRDVWrzEvs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iJrRNyEDnXU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_3193AA58(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public string GetOSVersion()
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("HlvLOriCsUEaBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bDSkTuTh2Cw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sEfqcGD/tmqGcNVcTMW2erFN6xV0wvgP0V3pRUbZ90iKbMFmWtjiWY4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4wKmNSOrljw=")[iii % 8])).ToArray()));
        try
        {
            foreach (var os in wmiData.Get())
            {
                return os[Encoding.UTF8.GetString(Convert.FromBase64String("sm2ZwlYPCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5AjrsT9gZyY=")[iii % 8])).ToArray())].ToString();
            }
        }
        catch
        {
        }

        return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w8hCFxw6O3Y=")[iii % 8])).ToArray());
    }

    private IEnumerable<string> GetWindowsPowerShellVersions()
    {
        var versions = new List<string>();
        var PowerShellVersion2 = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("DQ2Dl53IsowCD6yguOaTpjg2mZOl/oW7DSqgr6bV0ZUOLbKmuNqIrDIugK2t4I6s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XkLFw8qJ4Mk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YOLu8okwzA1c4c/yiRDNB14=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MI2Zl/tjpGg=")[iii % 8])).ToArray()));
        if (PowerShellVersion2 != null)
        {
            versions.Add(PowerShellVersion2);
        }

        var PowerShellVersion4Plus = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("P3/2fTNv1HQwfdlKFkH1XgpE7HkLWeNDP1jVRQhytW08X8dMFn3uVABc9UcDR+hU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bDCwKWQuhjE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("wQMJlByujWj9ACiUHI6MYv8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kWx+8W795Q0=")[iii % 8])).ToArray()));
        if (PowerShellVersion4Plus != null)
        {
            versions.Add(PowerShellVersion4Plus);
        }

        return versions;
    }

    private IEnumerable<string> GetPowerShellCoreVersions()
    {
        var versions = new List<string>();
        var keys = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("WlfZCf2QslxVVfY+2L6Tdm9sww3FpoVrWnD6McaSj2tsRNYz2aWBdWV9+wvPo5NwZnbsAQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRifXarR4Bk=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        foreach (var key in keys)
        {
            var version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ZtLhiyW/9BFp0M68AJHVO1Pp+48dicMmZvXCsx69ySZQwe6xAYrHOFn4w4kXjNU9WvPUgw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NZ2n33L+plQ=")[iii % 8])).ToArray()) + key, Encoding.UTF8.GetString(Convert.FromBase64String("Du9Yb1aI+zkL70d9UZP8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XYo1Djj8klo=")[iii % 8])).ToArray()));
            if (version != null)
            {
                versions.Add(version);
            }
        }

        return versions;
    }

    private IEnumerable<string> GetCLRVersions()
    {
        var versions = new List<string>();
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("8ZHDR2nFHZfxi8NKf8UZi8uyhGdo3jai36fHTHrFGI/x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rcaqKQ2qauQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (System.IO.File.Exists($"{dir}\\System.dll"))
            {
                versions.Add(System.IO.Path.GetFileName(dir.TrimEnd(System.IO.Path.DirectorySeparatorChar)).TrimStart('v'));
            }
        }

        return versions;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var installedVersions = new List<string>();
        var installedCLRVersions = new List<string>();
        installedVersions.AddRange(GetWindowsPowerShellVersions());
        installedVersions.AddRange(GetPowerShellCoreVersions());
        installedCLRVersions.AddRange(GetCLRVersions());
        var transcriptionLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("2cPlHNhtJOjW3Mwk5k8fyPnQ7iHsXhne5erXFNhFGMnl+9AU30MByPjfyy3jQCr5+O3NO+xeH93+5cwm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ioyjSI8sdq0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("t4oXVS40Ze6TigVUMDhB6JuKEQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8uR2N0JRMZw=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("Jw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FkErNbXDyZc=")[iii % 8])).ToArray());
        var transcriptionInvocationLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("PlbmlqlFKBExSc+ul2cTMR5F7auddhUnAn/UnqltFDACbtOermsNMR9KyKeSaCYAH3jOsZ12EyQZcM+s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bRmgwv4EelQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SwJ4tqqfUWZ4A3q1spN3ZkYJeLCjiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DmwZ1Mb6GAg=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q5FHDbT5jB4=")[iii % 8])).ToArray());
        var transcriptionDirectory = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("/HxNsH186zXzY2SIQ17QFdxvRo1JT9YDwFV/uH1U1xTARHi4elLOFd1gY4FGUeUk3VJll0lP0ADbWmSK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rzML5Co9uXA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("2VWlZmDsIIXkRbJieuod").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("liDRFhWYZOw=")[iii % 8])).ToArray()));
        var moduleLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("9YPzGV/hoxb6nNohYcOYNtWQ+CRr0p4gyarBEV/JnzfJu8YRWM+GNtSf3ShkzK0eyajAIW3snjTBpdsq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("psy1TQig8VM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("A+dZhtc3UtMi/FSB9z142y/nXw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rok45LtSH7w=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bqfEbs3/Jh0=")[iii % 8])).ToArray());
        var moduleNames = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("lLkiOEq992WbpgsAdJ/MRbSqKQV+jspTqJAQMEqVy0SogRcwTZPSRbWlDAlxkPltqJIRAHiwykegnwoLQbHKRLKaASJ8kcBT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x/ZkbB38pSA=")[iii % 8])).ToArray()))?.Keys.ToArray();
        var scriptBlockLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("T9xlOS0/6KBAw0wBEx3TgG/PbgQZDNWWc/VXMS0X1IFz5FAxKhHNgG7ASwgWEua2f+FKHQ481op/+G8CHRnTi3s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HJMjbXp+uuU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("fjw3rcx8AU5JOya74nU9TlAeOajHcDxK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O1JWz6AZUi0=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("LQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HFjfGxicXDc=")[iii % 8])).ToArray());
        var scriptBlockInvocationLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xZUnnKc7RAPKig6kmRl/I+WGLKGTCHk1+bwVlKcTeCL5rRKUoBVhI+SJCa2cFkoV9agIuIQ4ein1sS2nlx1/KPE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ltphyPB6FkY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("L6CeOODufSAYp48uzudBIAGHkSzj6E83A6GRFuPsSSoEqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("as7/WoyLLkM=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ebjWssKC9WU=")[iii % 8])).ToArray());
        int osVersionMajor = int.Parse(GetOSVersion().Split('.')[0]);
        var osSupportsAmsi = osVersionMajor >= 10;
        yield return new O_83287682(installedCLRVersions.ToArray(), installedVersions.ToArray(), transcriptionLogging, transcriptionInvocationLogging, transcriptionDirectory, moduleLogging, moduleNames, scriptBlockLogging, scriptBlockInvocationLogging, osSupportsAmsi);
    }

    public string GetOSVersion(string dQaIzRfB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(55, 31);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("HlvLOriCsUEaBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bDSkTuTh2Cw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sEfqcGD/tmqGcNVcTMW2erFN6xV0wvgP0V3pRUbZ90iKbMFmWtjiWY4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4wKmNSOrljw=")[iii % 8])).ToArray()));
        try
        {
            foreach (var os in wmiData.Get())
            {
                return os[Encoding.UTF8.GetString(Convert.FromBase64String("sm2ZwlYPCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5AjrsT9gZyY=")[iii % 8])).ToArray())].ToString();
            }
        }
        catch
        {
        }

        return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w8hCFxw6O3Y=")[iii % 8])).ToArray());
    }

    private IEnumerable<string> GetWindowsPowerShellVersions(string wPWVswpD)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(55, 31);
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
        var PowerShellVersion2 = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("DQ2Dl53IsowCD6yguOaTpjg2mZOl/oW7DSqgr6bV0ZUOLbKmuNqIrDIugK2t4I6s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XkLFw8qJ4Mk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YOLu8okwzA1c4c/yiRDNB14=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MI2Zl/tjpGg=")[iii % 8])).ToArray()));
        if (PowerShellVersion2 != null)
        {
            versions.Add(PowerShellVersion2);
        }

        var PowerShellVersion4Plus = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("P3/2fTNv1HQwfdlKFkH1XgpE7HkLWeNDP1jVRQhytW08X8dMFn3uVABc9UcDR+hU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bDCwKWQuhjE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("wQMJlByujWj9ACiUHI6MYv8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kWx+8W795Q0=")[iii % 8])).ToArray()));
        if (PowerShellVersion4Plus != null)
        {
            versions.Add(PowerShellVersion4Plus);
        }

        return versions;
    }

    private IEnumerable<string> GetPowerShellCoreVersions(string qtldqoFP)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(55, 31);
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
        var keys = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("WlfZCf2QslxVVfY+2L6Tdm9sww3FpoVrWnD6McaSj2tsRNYz2aWBdWV9+wvPo5NwZnbsAQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRifXarR4Bk=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        foreach (var key in keys)
        {
            var version = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ZtLhiyW/9BFp0M68AJHVO1Pp+48dicMmZvXCsx69ySZQwe6xAYrHOFn4w4kXjNU9WvPUgw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NZ2n33L+plQ=")[iii % 8])).ToArray()) + key, Encoding.UTF8.GetString(Convert.FromBase64String("Du9Yb1aI+zkL70d9UZP8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XYo1Djj8klo=")[iii % 8])).ToArray()));
            if (version != null)
            {
                versions.Add(version);
            }
        }

        return versions;
    }

    private IEnumerable<string> GetCLRVersions(string rSQfVoZc)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(55, 31);
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
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("8ZHDR2nFHZfxi8NKf8UZi8uyhGdo3jai36fHTHrFGI/x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rcaqKQ2qauQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (System.IO.File.Exists($"{dir}\\System.dll"))
            {
                versions.Add(System.IO.Path.GetFileName(dir.TrimEnd(System.IO.Path.DirectorySeparatorChar)).TrimStart('v'));
            }
        }

        return versions;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string oUYjrRro)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(55, 31);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var installedVersions = new List<string>();
        var installedCLRVersions = new List<string>();
        installedVersions.AddRange(GetWindowsPowerShellVersions());
        installedVersions.AddRange(GetPowerShellCoreVersions());
        installedCLRVersions.AddRange(GetCLRVersions());
        var transcriptionLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("2cPlHNhtJOjW3Mwk5k8fyPnQ7iHsXhne5erXFNhFGMnl+9AU30MByPjfyy3jQCr5+O3NO+xeH93+5cwm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ioyjSI8sdq0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("t4oXVS40Ze6TigVUMDhB6JuKEQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8uR2N0JRMZw=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("Jw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FkErNbXDyZc=")[iii % 8])).ToArray());
        var transcriptionInvocationLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("PlbmlqlFKBExSc+ul2cTMR5F7auddhUnAn/UnqltFDACbtOermsNMR9KyKeSaCYAH3jOsZ12EyQZcM+s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bRmgwv4EelQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SwJ4tqqfUWZ4A3q1spN3ZkYJeLCjiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DmwZ1Mb6GAg=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q5FHDbT5jB4=")[iii % 8])).ToArray());
        var transcriptionDirectory = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("/HxNsH186zXzY2SIQ17QFdxvRo1JT9YDwFV/uH1U1xTARHi4elLOFd1gY4FGUeUk3VJll0lP0ADbWmSK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rzML5Co9uXA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("2VWlZmDsIIXkRbJieuod").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("liDRFhWYZOw=")[iii % 8])).ToArray()));
        var moduleLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("9YPzGV/hoxb6nNohYcOYNtWQ+CRr0p4gyarBEV/JnzfJu8YRWM+GNtSf3ShkzK0eyajAIW3snjTBpdsq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("psy1TQig8VM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("A+dZhtc3UtMi/FSB9z142y/nXw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rok45LtSH7w=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bqfEbs3/Jh0=")[iii % 8])).ToArray());
        var moduleNames = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("lLkiOEq992WbpgsAdJ/MRbSqKQV+jspTqJAQMEqVy0SogRcwTZPSRbWlDAlxkPltqJIRAHiwykegnwoLQbHKRLKaASJ8kcBT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x/ZkbB38pSA=")[iii % 8])).ToArray()))?.Keys.ToArray();
        var scriptBlockLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("T9xlOS0/6KBAw0wBEx3TgG/PbgQZDNWWc/VXMS0X1IFz5FAxKhHNgG7ASwgWEua2f+FKHQ481op/+G8CHRnTi3s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HJMjbXp+uuU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("fjw3rcx8AU5JOya74nU9TlAeOajHcDxK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O1JWz6AZUi0=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("LQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HFjfGxicXDc=")[iii % 8])).ToArray());
        var scriptBlockInvocationLogging = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xZUnnKc7RAPKig6kmRl/I+WGLKGTCHk1+bwVlKcTeCL5rRKUoBVhI+SJCa2cFkoV9agIuIQ4ein1sS2nlx1/KPE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ltphyPB6FkY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("L6CeOODufSAYp48uzudBIAGHkSzj6E83A6GRFuPsSSoEqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("as7/WoyLLkM=")[iii % 8])).ToArray())) == Encoding.UTF8.GetString(Convert.FromBase64String("SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ebjWssKC9WU=")[iii % 8])).ToArray());
        int osVersionMajor = int.Parse(GetOSVersion().Split('.')[0]);
        var osSupportsAmsi = osVersionMajor >= 10;
        yield return new O_83287682(installedCLRVersions.ToArray(), installedVersions.ToArray(), transcriptionLogging, transcriptionInvocationLogging, transcriptionDirectory, moduleLogging, moduleNames, scriptBlockLogging, scriptBlockInvocationLogging, osSupportsAmsi);
    }
}class O_83287682 : O_4AED570F
{
    public O_83287682(string[] installedCLRVersions, string[] installedVersions, bool transcriptionLogging, bool transcriptionInvocationLogging, string? transcriptionDirectory, bool moduleLogging, string[]? moduleNames, bool scriptBlockLogging, bool scriptBlockInvocationLogging, bool osSupportsAmsi)
    {
        InstalledCLRVersions = installedCLRVersions;
        InstalledVersions = installedVersions;
        TranscriptionLogging = transcriptionLogging;
        TranscriptionInvocationLogging = transcriptionInvocationLogging;
        TranscriptionDirectory = transcriptionDirectory;
        ModuleLogging = moduleLogging;
        ModuleNames = moduleNames;
        ScriptBlockLogging = scriptBlockLogging;
        ScriptBlockInvocationLogging = scriptBlockInvocationLogging;
        OsSupportsAmsi = osSupportsAmsi;
    }

    public string[] InstalledCLRVersions { get; }
    public string[] InstalledVersions { get; }
    public bool? TranscriptionLogging { get; }
    public bool? TranscriptionInvocationLogging { get; }
    public string? TranscriptionDirectory { get; }
    public bool ModuleLogging { get; }
    public string[]? ModuleNames { get; }
    public bool ScriptBlockLogging { get; }
    public bool? ScriptBlockInvocationLogging { get; }
    public bool OsSupportsAmsi { get; }
}
    [CommandOutputType(typeof(O_83287682))]
    internal class O_4E430AC8 : TextFormatterBase
    {
        public O_4E430AC8(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_83287682)result;
            var lowestVersion = dto.InstalledVersions.Min(v => GetVersionFromString(v));
            var highestVersion = dto.InstalledVersions.Max(v => GetVersionFromString(v));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("v+Bb2fbzf/jZrB70uMNHy5WWHuLr6WT3xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tcB7kJiAC5k=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledCLRVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("7AIyvXPr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zCISnVPL1Qs=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WWsfR6PBBBg/J1pq7eIfDjY5bGao3hxZBS5NfaTdHgo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U0s/Ds2ycHk=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Ih54q1Uy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Aj5Yi3USrrU=")[iii % 8])).ToArray()) + v);
                if ((v == Encoding.UTF8.GetString(Convert.FromBase64String("uZBJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i755U8Mgxrk=")[iii % 8])).ToArray())) && !dto.InstalledCLRVersions.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("/PBPGxuqM3L5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zt5/NS6aBEA=")[iii % 8])).ToArray())))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Y7Yl2an99aqj6WXEOKlhZjBlpd0qefYxJ7PhXGnuJDR2pDSZsSbpNHHi5co6KPWmMCLwyfru5OVjtWXFuigk4P9kNIq6/eAw4DIlzHoudGFjprSZua1mpSOjNhm9aKY3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8a74t0aH1/Y=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8RSKWt7VchiYRsN+2N1zBdt4xWnL3XIM22fPetjdcgyI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+zSqDqy0HGs=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6Z5xOsk6D5Wo3D1/jTpq2+mecTrJOmrb6YRx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yb5RGukaSvs=")[iii % 8])).ToArray()) + dto.TranscriptionLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JVMHs3G9kmVzHETyJfS0ZSU/SPQ29LVsJUkH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BXMnk1Gd2ws=")[iii % 8])).ToArray()) + dto.TranscriptionInvocationLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("T/ffqUaAtJ8I97vgFMWbhAClhqlGgNjQT+3f").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b9f/iWag+PA=")[iii % 8])).ToArray()) + dto.TranscriptionDirectory);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("tHtM9s4+IMXbeyDUxj08x9l7P97VLjzH2Sg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vltsu6FaVak=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pHxjdkUOLyflPi8zAQ5KaaR8Y3ZFDkpppHx5dg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hFxDVmUuakk=")[iii % 8])).ToArray()) + dto.ModuleLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yO1PUnMnTCqPqgoWc0pvIZ2hClIdZm0gm+1V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6M1vclMHAEU=")[iii % 8])).ToArray()));
            if (dto.ModuleNames != null)
            {
                foreach (var m in dto.ModuleNames)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AeONxMWm+YQB4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IcOt5OWG2aQ=")[iii % 8])).ToArray()) + m);
                }
            }

            if (dto.ModuleLogging)
            {
                if (lowestVersion.Major < 3)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TveodRUGkMM19tV1bEnFww225nVRSZCCTofnIlBU44sLu+R1Q0PCkAe45nVRSceNCaXpMVAGxIxOtfElVFXDwxq/7XVZSdeEB7nvew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bteIVTUmsOM=")[iii % 8])).ToArray()));
                }

                if (highestVersion.Major < 3)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9HC+BNzUGN+PccMEsZtcirg1vkiTk1+Wuje+TY/UW5C6NvdDiYZdm/pw0kubk1GRs3DpTZCYGJG7JL5Ln5dNjfhw9kuLkU6apny+RpmXWYqnNb5NiNRKmqUl91aZhxivhyatCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1FCeJPz0OP8=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("aBkp/2IUqY4WGUvAbgWr3i5WbstoCKfeMVx92GgIp40=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YjkJrAFmwP4=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("DdFWnk4eyPNMkxrbCh6tvQ3RVp5OHq29DctW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LfF2vm4+jZ0=")[iii % 8])).ToArray()) + dto.ScriptBlockLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ACjhFx3YrKhWZ6JWSZGKqABErlBakYuhADLh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IAjBNz345cY=")[iii % 8])).ToArray()) + dto.ScriptBlockInvocationLogging);
            if (dto.ScriptBlockLogging)
            {
                if (highestVersion.Major < 5)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("nJl0ZgUkb0HnmAlmdmc9CMzNdCRJaywKnNU7IUJtIQac0CdmRmshB9XeITRAYGFB8NYzIUxqKEHL0DgqBWogFZzWNyVQdmNB1NYjI1NhPU2c2zElRHE8BJzQIGZXYT4U1csxNQVUHBeJlw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vLlURiUET2E=")[iii % 8])).ToArray()));
                }

                if (lowestVersion.Major < 5)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Qm7UHCLMa2I5b6kcW4M+YgEvmhxmg2sjQh6bS2eeGCoHIpgcdIk5MQshmhxmgzwsBTyVWGfMPy1CLI1MY584YhYmkRxugywlCyCTEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yk70PALsS0I=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GwnNHhCibRFcSIEoH6RhHEJKjDFen2pIdFuLPh2zJBRQZL4WVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ESntX37WBDw=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("W3QDLJrzwf5bB1Z8yrz82Qh0YkHpmrSN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e1QjDLrTjq0=")[iii % 8])).ToArray()) + dto.OsSupportsAmsi);
            if (dto.OsSupportsAmsi && lowestVersion.Major < 3)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("631wepHHmd2QfA166IjM3ag8PnrViJmc6w0/LdSV6pWuMTx6x4LLjqIyPnrViM6TrC8xPtTHzZLrPykq0JTK3YoQAxOf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y11QWrHnuf0=")[iii % 8])).ToArray()));
            }
        }

        private Version GetVersionFromString(string v)
        {
            var versionStr = v.Split('-')[0];
            return new Version(versionStr);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string UFfcPjEM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Random instance = new System.Random();
                        instance.Next(55, 31);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_83287682)result;
            var lowestVersion = dto.InstalledVersions.Min(v => GetVersionFromString(v));
            var highestVersion = dto.InstalledVersions.Max(v => GetVersionFromString(v));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("v+Bb2fbzf/jZrB70uMNHy5WWHuLr6WT3xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tcB7kJiAC5k=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledCLRVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("7AIyvXPr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zCISnVPL1Qs=")[iii % 8])).ToArray()) + v);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WWsfR6PBBBg/J1pq7eIfDjY5bGao3hxZBS5NfaTdHgo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U0s/Ds2ycHk=")[iii % 8])).ToArray()));
            foreach (var v in dto.InstalledVersions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Ih54q1Uy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Aj5Yi3USrrU=")[iii % 8])).ToArray()) + v);
                if ((v == Encoding.UTF8.GetString(Convert.FromBase64String("uZBJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i755U8Mgxrk=")[iii % 8])).ToArray())) && !dto.InstalledCLRVersions.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("/PBPGxuqM3L5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zt5/NS6aBEA=")[iii % 8])).ToArray())))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Y7Yl2an99aqj6WXEOKlhZjBlpd0qefYxJ7PhXGnuJDR2pDSZsSbpNHHi5co6KPWmMCLwyfru5OVjtWXFuigk4P9kNIq6/eAw4DIlzHoudGFjprSZua1mpSOjNhm9aKY3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8a74t0aH1/Y=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8RSKWt7VchiYRsN+2N1zBdt4xWnL3XIM22fPetjdcgyI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+zSqDqy0HGs=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6Z5xOsk6D5Wo3D1/jTpq2+mecTrJOmrb6YRx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yb5RGukaSvs=")[iii % 8])).ToArray()) + dto.TranscriptionLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JVMHs3G9kmVzHETyJfS0ZSU/SPQ29LVsJUkH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BXMnk1Gd2ws=")[iii % 8])).ToArray()) + dto.TranscriptionInvocationLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("T/ffqUaAtJ8I97vgFMWbhAClhqlGgNjQT+3f").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b9f/iWag+PA=")[iii % 8])).ToArray()) + dto.TranscriptionDirectory);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("tHtM9s4+IMXbeyDUxj08x9l7P97VLjzH2Sg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vltsu6FaVak=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pHxjdkUOLyflPi8zAQ5KaaR8Y3ZFDkpppHx5dg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hFxDVmUuakk=")[iii % 8])).ToArray()) + dto.ModuleLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yO1PUnMnTCqPqgoWc0pvIZ2hClIdZm0gm+1V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6M1vclMHAEU=")[iii % 8])).ToArray()));
            if (dto.ModuleNames != null)
            {
                foreach (var m in dto.ModuleNames)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AeONxMWm+YQB4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IcOt5OWG2aQ=")[iii % 8])).ToArray()) + m);
                }
            }

            if (dto.ModuleLogging)
            {
                if (lowestVersion.Major < 3)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TveodRUGkMM19tV1bEnFww225nVRSZCCTofnIlBU44sLu+R1Q0PCkAe45nVRSceNCaXpMVAGxIxOtfElVFXDwxq/7XVZSdeEB7nvew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bteIVTUmsOM=")[iii % 8])).ToArray()));
                }

                if (highestVersion.Major < 3)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9HC+BNzUGN+PccMEsZtcirg1vkiTk1+Wuje+TY/UW5C6NvdDiYZdm/pw0kubk1GRs3DpTZCYGJG7JL5Ln5dNjfhw9kuLkU6apny+RpmXWYqnNb5NiNRKmqUl91aZhxivhyatCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1FCeJPz0OP8=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("aBkp/2IUqY4WGUvAbgWr3i5WbstoCKfeMVx92GgIp40=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YjkJrAFmwP4=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("DdFWnk4eyPNMkxrbCh6tvQ3RVp5OHq29DctW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LfF2vm4+jZ0=")[iii % 8])).ToArray()) + dto.ScriptBlockLogging);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ACjhFx3YrKhWZ6JWSZGKqABErlBakYuhADLh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IAjBNz345cY=")[iii % 8])).ToArray()) + dto.ScriptBlockInvocationLogging);
            if (dto.ScriptBlockLogging)
            {
                if (highestVersion.Major < 5)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("nJl0ZgUkb0HnmAlmdmc9CMzNdCRJaywKnNU7IUJtIQac0CdmRmshB9XeITRAYGFB8NYzIUxqKEHL0DgqBWogFZzWNyVQdmNB1NYjI1NhPU2c2zElRHE8BJzQIGZXYT4U1csxNQVUHBeJlw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vLlURiUET2E=")[iii % 8])).ToArray()));
                }

                if (lowestVersion.Major < 5)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Qm7UHCLMa2I5b6kcW4M+YgEvmhxmg2sjQh6bS2eeGCoHIpgcdIk5MQshmhxmgzwsBTyVWGfMPy1CLI1MY584YhYmkRxugywlCyCTEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yk70PALsS0I=")[iii % 8])).ToArray()));
                }
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GwnNHhCibRFcSIEoH6RhHEJKjDFen2pIdFuLPh2zJBRQZL4WVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ESntX37WBDw=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("W3QDLJrzwf5bB1Z8yrz82Qh0YkHpmrSN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e1QjDLrTjq0=")[iii % 8])).ToArray()) + dto.OsSupportsAmsi);
            if (dto.OsSupportsAmsi && lowestVersion.Major < 3)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("631wepHHmd2QfA166IjM3ag8PnrViJmc6w0/LdSV6pWuMTx6x4LLjqIyPnrViM6TrC8xPtTHzZLrPykq0JTK3YoQAxOf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y11QWrHnuf0=")[iii % 8])).ToArray()));
            }
        }

        private Version GetVersionFromString(string v, string QHTNuIMo)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Random instance = new System.Random();
                        instance.Next(55, 31);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var versionStr = v.Split('-')[0];
            return new Version(versionStr);
        }
    }
}