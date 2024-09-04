using Microsoft.Win32;
using O_F41F88FA.Util;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    enum GPOLink
    {
        NO_LINK_INFORMATION = 0,
        LOCAL_MACHINE = 1,
        SITE = 2,
        DOMAIN = 3,
        ORGANIZATIONAL_UNIT = 4
    }

    enum GPOOptions
    {
        ALL_SECTIONS_ENABLED = 0,
        USER_SECTION_DISABLED = 1,
        COMPUTER_SECTION_DISABLE = 2,
        ALL_SECTIONS_DISABLED = 3
    }
internal class O_4EA0026F : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("QVV8ynRuB1B+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DTofqxgpVx8=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("PBHpF16qKx0fC/pWYuUABhMHqgVX/hgGHhn5VlP6HAMZG+5WRuVMGxgbqhtT6QQGHhulGl3pDQNQC/kTQPk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cH6KdjKKbG8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_4EA0026F(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var basePath = Encoding.UTF8.GetString(Convert.FromBase64String("9MaVUe/RY+77xLpmyv9CxMH9j1LR/lXE0PqPRs3iQ87J/YVgyuNYxMnVlHfX5UGL9+a/bNvpbe/G/bJWzP9DzvvEsmbQ+V/O+7k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p4nTBbiQMas=")[iii % 8])).ToArray());
        var machineIDs = RegistryUtil.GetSubkeyNames(RegistryHive.LocalMachine, basePath) ?? new string[]
        {
        };
        foreach (var ID in machineIDs)
        {
            var settings = RegistryUtil.GetValues(RegistryHive.LocalMachine, $"{basePath}\\{ID}");
            yield return new O_772C1DD3(settings[Encoding.UTF8.GetString(Convert.FromBase64String("yJHrEX55Sg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j8GkXx8ULw0=")[iii % 8])).ToArray())], Encoding.UTF8.GetString(Convert.FromBase64String("xwpRhfnrSg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qmsy7ZCFL4w=")[iii % 8])).ToArray()), settings[Encoding.UTF8.GetString(Convert.FromBase64String("JPJJJHYQIq0B9l8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YJs6VBpxW+M=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("/+JGHg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s4sodSsMqIU=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("jc4+c1WJ+xKq0zo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y6dSFgbwiEI=")[iii % 8])).ToArray())], (GPOOptions)settings[Encoding.UTF8.GetString(Convert.FromBase64String("EdaSapS2fQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XqbmA/vYDso=")[iii % 8])).ToArray())], (GPOLink)settings[Encoding.UTF8.GetString(Convert.FromBase64String("ZzxFr8PFXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IGwK46qrNjg=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("14gziyd8wO/8gw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kvBH7kkPqYA=")[iii % 8])).ToArray())]);
        }

        var userGpOs = new Dictionary<string, Dictionary<string, object>>();
        var sids = Registry.Users.GetSubKeyNames();
        foreach (var sid in sids)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("r/d0O+o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/NpFFt8ufwQ=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mILsF9t13xk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x8GAdqgGumo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var extensions = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Group Policy\\History");
            if ((extensions == null) || (extensions.Length == 0))
            {
                continue;
            }

            foreach (var extension in extensions)
            {
                var path = $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Group Policy\\History\\{extension}";
                var UserIDs = RegistryUtil.GetSubkeyNames(RegistryHive.Users, path) ?? new string[]
                {
                };
                foreach (var ID in UserIDs)
                {
                    var settings = RegistryUtil.GetValues(RegistryHive.Users, $"{path}\\{ID}");
                    if (userGpOs.ContainsKey($"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("uUz20/ULwA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/hy5nZRmpVE=")[iii % 8])).ToArray())]}"))
                    {
                        continue;
                    }

                    userGpOs.Add($"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("T3QgsJlN6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CCRv/vggjeQ=")[iii % 8])).ToArray())]}", settings);
                }
            }
        }

        foreach (var UserGPO in userGpOs)
        {
            yield return new O_772C1DD3(UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("TEI+5A6+OQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CxJxqm/TXF8=")[iii % 8])).ToArray())], Encoding.UTF8.GetString(Convert.FromBase64String("o/zz0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1o+WoBT2BHk=")[iii % 8])).ToArray()), UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("Ev902XYevfk3+2I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VpYHqRp/xLc=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("ZReeMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KX7wWezHBcc=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("uHdcBpiDUkCfalg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/h4wY8v6IRA=")[iii % 8])).ToArray())], (GPOOptions)UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("arHZReVCLA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JcGtLIosX88=")[iii % 8])).ToArray())], (GPOLink)UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("P9gcfdjmJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eIhTMbGIT28=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("RMqONAbKULVvwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AbL6UWi5Odo=")[iii % 8])).ToArray())]);
        }
    }

internal class O_772C1DD3 : O_4AED570F
{
    public O_772C1DD3(object gpoName, object gpoType, object displayName, object link, object fileSysPath, GPOOptions options, GPOLink gpoLink, object extensions)
    {
        GPOName = gpoName;
        GPOType = gpoType;
        DisplayName = displayName;
        Link = link;
        FileSysPath = fileSysPath;
        Options = options;
        GPOLink = gpoLink;
        Extensions = extensions;
    }

    public object GPOName { get; }
    public object GPOType { get; }
    public object DisplayName { get; }
    public object Link { get; set; }
    public object FileSysPath { get; }
    public GPOOptions Options { get; }
    public GPOLink GPOLink { get; }
    public object Extensions { get; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string gidAwnXf)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.AddMonths(new System.DateTime(), 63);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var basePath = Encoding.UTF8.GetString(Convert.FromBase64String("9MaVUe/RY+77xLpmyv9CxMH9j1LR/lXE0PqPRs3iQ87J/YVgyuNYxMnVlHfX5UGL9+a/bNvpbe/G/bJWzP9DzvvEsmbQ+V/O+7k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p4nTBbiQMas=")[iii % 8])).ToArray());
        var machineIDs = RegistryUtil.GetSubkeyNames(RegistryHive.LocalMachine, basePath) ?? new string[]
        {
        };
        foreach (var ID in machineIDs)
        {
            var settings = RegistryUtil.GetValues(RegistryHive.LocalMachine, $"{basePath}\\{ID}");
            yield return new O_772C1DD3(settings[Encoding.UTF8.GetString(Convert.FromBase64String("yJHrEX55Sg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j8GkXx8ULw0=")[iii % 8])).ToArray())], Encoding.UTF8.GetString(Convert.FromBase64String("xwpRhfnrSg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qmsy7ZCFL4w=")[iii % 8])).ToArray()), settings[Encoding.UTF8.GetString(Convert.FromBase64String("JPJJJHYQIq0B9l8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YJs6VBpxW+M=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("/+JGHg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s4sodSsMqIU=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("jc4+c1WJ+xKq0zo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y6dSFgbwiEI=")[iii % 8])).ToArray())], (GPOOptions)settings[Encoding.UTF8.GetString(Convert.FromBase64String("EdaSapS2fQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XqbmA/vYDso=")[iii % 8])).ToArray())], (GPOLink)settings[Encoding.UTF8.GetString(Convert.FromBase64String("ZzxFr8PFXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IGwK46qrNjg=")[iii % 8])).ToArray())], settings[Encoding.UTF8.GetString(Convert.FromBase64String("14gziyd8wO/8gw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kvBH7kkPqYA=")[iii % 8])).ToArray())]);
        }

        var userGpOs = new Dictionary<string, Dictionary<string, object>>();
        var sids = Registry.Users.GetSubKeyNames();
        foreach (var sid in sids)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("r/d0O+o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/NpFFt8ufwQ=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mILsF9t13xk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x8GAdqgGumo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var extensions = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Group Policy\\History");
            if ((extensions == null) || (extensions.Length == 0))
            {
                continue;
            }

            foreach (var extension in extensions)
            {
                var path = $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Group Policy\\History\\{extension}";
                var UserIDs = RegistryUtil.GetSubkeyNames(RegistryHive.Users, path) ?? new string[]
                {
                };
                foreach (var ID in UserIDs)
                {
                    var settings = RegistryUtil.GetValues(RegistryHive.Users, $"{path}\\{ID}");
                    if (userGpOs.ContainsKey($"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("uUz20/ULwA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/hy5nZRmpVE=")[iii % 8])).ToArray())]}"))
                    {
                        continue;
                    }

                    userGpOs.Add($"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("T3QgsJlN6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CCRv/vggjeQ=")[iii % 8])).ToArray())]}", settings);
                }
            }
        }

        foreach (var UserGPO in userGpOs)
        {
            yield return new O_772C1DD3(UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("TEI+5A6+OQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CxJxqm/TXF8=")[iii % 8])).ToArray())], Encoding.UTF8.GetString(Convert.FromBase64String("o/zz0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1o+WoBT2BHk=")[iii % 8])).ToArray()), UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("Ev902XYevfk3+2I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VpYHqRp/xLc=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("ZReeMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KX7wWezHBcc=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("uHdcBpiDUkCfalg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/h4wY8v6IRA=")[iii % 8])).ToArray())], (GPOOptions)UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("arHZReVCLA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JcGtLIosX88=")[iii % 8])).ToArray())], (GPOLink)UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("P9gcfdjmJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eIhTMbGIT28=")[iii % 8])).ToArray())], UserGPO.Value[Encoding.UTF8.GetString(Convert.FromBase64String("RMqONAbKULVvwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AbL6UWi5Odo=")[iii % 8])).ToArray())]);
        }
    }
}}