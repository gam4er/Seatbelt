#nullable disable
using System;
using System.Collections.Generic;
using O_F41F88FA.Util;
using Microsoft.Win32;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    enum NetworkCategory
    {
        PUBLIC = 0,
        HOME = 1,
        WORK = 2
    }

    enum NetworkType
    {
        WIRED = 6,
        VPN = 23,
        WIRELESS = 25,
        MOBILE_BROADBAND = 243
    }
internal class O_CCA7CE9B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("FGWCaefrTl4ob5B35PxW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WgD2HoiZJQ4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("zmgCxpK28bj3ZBjVkrPpuOlzA8SUrefr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQFsov3Bgpg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_CCA7CE9B(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("7ka7NgzEiPHUCLk7DM3N5s8G+hkV0tyl2U36NQ6ByeHWQbQ9E9Xa5M9HqHo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uyjaVGChqIU=")[iii % 8])).ToArray()));
            yield break;
        }

        var profileGUIDs = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YMT1HZ5nv65vxtoqu0mehFX/7x6gSImERPiTB516rp5B+dYnvXCImUDi3CeVaIifROTBIoVPnp9v28Emr0+BjkDX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M4uzSckm7es=")[iii % 8])).ToArray()));
        foreach (var profileGUID in profileGUIDs)
        {
            var ProfileName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("4vo3g9dVUdnT5T0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sohY5b45NJc=")[iii % 8])).ToArray()));
            var Description = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("A9fIEG++9r8u3dU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R7K7cx3Xhss=")[iii % 8])).ToArray()));
            var NetworkCategory = (NetworkCategory)ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("6l8WrPZE2SI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qT5iyZErq1s=")[iii % 8])).ToArray()));
            var NetworkType = (NetworkType)ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("O7zKBzf0jC4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dd2nYmON/Es=")[iii % 8])).ToArray()));
            var Managed = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("PAuNUg75XA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cWrjM2mcODs=")[iii % 8])).ToArray()));
            var dateCreatedBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("TALGjg5MQDx8BtY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CGOy600+JV0=")[iii % 8])).ToArray()));
            var DateCreated = ConvertBinaryDateTime(dateCreatedBytes);
            var dateLastConnectedBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("u1FrZ6OZlJyLVXs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/zAfAuDr8f0=")[iii % 8])).ToArray()));
            var DateLastConnected = ConvertBinaryDateTime(dateLastConnectedBytes);
            yield return new O_7124901A()
            {
                ProfileName = ProfileName,
                Description = Description,
                NetworkCategory = NetworkCategory,
                NetworkType = NetworkType,
                Managed = Managed,
                DateCreated = DateCreated,
                DateLastConnected = DateLastConnected,
            };
        }
    }

    public DateTime ConvertBinaryDateTime(byte[] bytes)
    {
        if (bytes == null || bytes.Length == 0)
        {
            return new DateTime();
        }

        var year = Convert.ToInt32($"{bytes[1]:X2}{bytes[0]:X2}", 16);
        var month = Convert.ToInt32($"{bytes[3]:X2}{bytes[2]:X2}", 16);
        var weekday = Convert.ToInt32($"{bytes[5]:X2}{bytes[4]:X2}", 16);
        var day = Convert.ToInt32($"{bytes[7]:X2}{bytes[6]:X2}", 16);
        var hour = Convert.ToInt32($"{bytes[9]:X2}{bytes[8]:X2}", 16);
        var min = Convert.ToInt32($"{bytes[11]:X2}{bytes[10]:X2}", 16);
        var sec = Convert.ToInt32($"{bytes[13]:X2}{bytes[12]:X2}", 16);
        return new DateTime(year, month, day, hour, min, sec);
    }

internal class O_7124901A : O_4AED570F
{
    public string ProfileName { get; set; }
    public string Description { get; set; }
    public NetworkCategory NetworkCategory { get; set; }
    public NetworkType NetworkType { get; set; }
    public object Managed { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateLastConnected { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string JYVCHraK)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.DateTimeFormatInfo instance = new System.Globalization.DateTimeFormatInfo();
                    instance.GetShortestDayName(new System.DayOfWeek());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("7ka7NgzEiPHUCLk7DM3N5s8G+hkV0tyl2U36NQ6ByeHWQbQ9E9Xa5M9HqHo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uyjaVGChqIU=")[iii % 8])).ToArray()));
            yield break;
        }

        var profileGUIDs = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YMT1HZ5nv65vxtoqu0mehFX/7x6gSImERPiTB516rp5B+dYnvXCImUDi3CeVaIifROTBIoVPnp9v28Emr0+BjkDX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M4uzSckm7es=")[iii % 8])).ToArray()));
        foreach (var profileGUID in profileGUIDs)
        {
            var ProfileName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("4vo3g9dVUdnT5T0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sohY5b45NJc=")[iii % 8])).ToArray()));
            var Description = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("A9fIEG++9r8u3dU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R7K7cx3Xhss=")[iii % 8])).ToArray()));
            var NetworkCategory = (NetworkCategory)ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("6l8WrPZE2SI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qT5iyZErq1s=")[iii % 8])).ToArray()));
            var NetworkType = (NetworkType)ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("O7zKBzf0jC4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dd2nYmON/Es=")[iii % 8])).ToArray()));
            var Managed = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("PAuNUg75XA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cWrjM2mcODs=")[iii % 8])).ToArray()));
            var dateCreatedBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("TALGjg5MQDx8BtY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CGOy600+JV0=")[iii % 8])).ToArray()));
            var DateCreated = ConvertBinaryDateTime(dateCreatedBytes);
            var dateLastConnectedBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles\\{profileGUID}", Encoding.UTF8.GetString(Convert.FromBase64String("u1FrZ6OZlJyLVXs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/zAfAuDr8f0=")[iii % 8])).ToArray()));
            var DateLastConnected = ConvertBinaryDateTime(dateLastConnectedBytes);
            yield return new O_7124901A()
            {
                ProfileName = ProfileName,
                Description = Description,
                NetworkCategory = NetworkCategory,
                NetworkType = NetworkType,
                Managed = Managed,
                DateCreated = DateCreated,
                DateLastConnected = DateLastConnected,
            };
        }
    }

    public DateTime ConvertBinaryDateTime(byte[] bytes, string QUNJxPvR)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.DateTimeFormatInfo instance = new System.Globalization.DateTimeFormatInfo();
                    instance.GetShortestDayName(new System.DayOfWeek());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (bytes == null || bytes.Length == 0)
        {
            return new DateTime();
        }

        var year = Convert.ToInt32($"{bytes[1]:X2}{bytes[0]:X2}", 16);
        var month = Convert.ToInt32($"{bytes[3]:X2}{bytes[2]:X2}", 16);
        var weekday = Convert.ToInt32($"{bytes[5]:X2}{bytes[4]:X2}", 16);
        var day = Convert.ToInt32($"{bytes[7]:X2}{bytes[6]:X2}", 16);
        var hour = Convert.ToInt32($"{bytes[9]:X2}{bytes[8]:X2}", 16);
        var min = Convert.ToInt32($"{bytes[11]:X2}{bytes[10]:X2}", 16);
        var sec = Convert.ToInt32($"{bytes[13]:X2}{bytes[12]:X2}", 16);
        return new DateTime(year, month, day, hour, min, sec);
    }
}}
#nullable enable
