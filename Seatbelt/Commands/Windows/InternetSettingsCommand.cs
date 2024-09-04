#nullable disable
using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_6A1381E6 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("q3mvqciNTFCxcq+4041OVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4hfbzLrjKSQ=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("m6TDNtjfQjPyudIn3thJIKHq3j3J3VIju6TQc9rDSD+r6tQ8xNdOIKHq1j3OkV0ovK/Ec8neSSG7rcIhy8VOKLw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0sq3U6qxJ0c=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_6A1381E6(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var result = new O_1177CAA2();
        var keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("Xqp8r+Tv2EhRiHO44eHZQmuxRoz64M5CerZGmOb82EhjsUy+4f3DQmOZU7Xn69hDaLE6iPb63kRjomk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DcUa25OOqi0=")[iii % 8])).ToArray());
        var proxySettings = RegistryUtil.GetValues(RegistryHive.CurrentUser, keyPath);
        foreach (var kvp in proxySettings)
        {
            result.GeneralSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("qqwwkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4udzx1msDr0=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), null));
        }

        keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("qkJJUN26UOKlYEZH2LRR6J9Zc3PDtUbojl5zZ9+pUOKXWXlB2KhL6JdxZkrevlDpnFkPd8+vVu6XSlw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+S0vJKrbIoc=")[iii % 8])).ToArray());
        var proxySettings2 = RegistryUtil.GetValues(RegistryHive.LocalMachine, keyPath);
        foreach (var kvp in proxySettings2)
        {
            result.GeneralSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("pIjliw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7MOpxuXdLsY=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), null));
        }

        IDictionary<string, string> zoneMapKeys = new Dictionary<string, string>()
        {
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("eg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("StV9Soyhrw0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("N4M+RIHzlacOn2w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evoeB+6e5dI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Rg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d4eFrOeUZcY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kOoAcAOz7xWo9wJ/CueGIbPrBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3IVjEW+Tpns=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vWZUQRiNc08=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NSdbiA0O23cyPFqeCkvlOA8w").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YVUu+3lrv1c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("KA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G8lO5xN3aVY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("saOrEMIaroTYl7Ab1Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+M3fdbB0y/A=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VtXbIrTEeo4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("QSpPMZH+TKJ2KxwWiuNKpTMVUyuG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E088ReOXL9Y=")[iii % 8])).ToArray())
            }
        };
        keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("DjQKHNoZN20BCwMExBssbS4HIQHOCip7Mj0YNPoRK2wyLB807g03ejg1GD7ICjZhMjUwIcMMIHozPhhI/h0xfDQ1CxvxIipmOBYNGOYdPA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XVtsaK14RQg=")[iii % 8])).ToArray());
        var zoneMapKey = RegistryUtil.GetValues(RegistryHive.LocalMachine, keyPath);
        foreach (var kvp in zoneMapKey.AsEnumerable())
        {
            result.ZoneMaps.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("8kSGwA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ug/KjSDcpqw=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), zoneMapKeys.AsEnumerable().Single(l => l.Key == kvp.Value.ToString()).Value));
        }

        var zoneMapKey2 = RegistryUtil.GetValues(RegistryHive.CurrentUser, keyPath);
        foreach (var kvp in zoneMapKey2.AsQueryable())
        {
            result.ZoneMaps.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("0O1guA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mKYj7SN2FbQ=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), zoneMapKeys.AsEnumerable().Single(l => l.Key == kvp.Value.ToString()).Value));
        }

        IDictionary<uint, string> zoneAuthSettings = new Dictionary<uint, string>()
        {
            {
                0x00000000,
                Encoding.UTF8.GetString(Convert.FromBase64String("W64NoeM/GGp5uhWi934AbH20F+75NxhrOrgMvPw7Anc6rgqr/DANbn/7GKDqfhxiaagOofw6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gtt5zo5ebAM=")[iii % 8])).ToArray())
            },
            {
                0x00010000,
                Encoding.UTF8.GetString(Convert.FromBase64String("Pg6vOrlG/xMBDuAiuletVQAdrTLpU7ERTgyhJLpFsAcK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bnzAV8ky33U=")[iii % 8])).ToArray())
            },
            {
                0x00020000,
                Encoding.UTF8.GetString(Convert.FromBase64String("JG+a+bL96v4GOoL5uPPwtwp0gu//9fC3EXKLtpby6uUEdIvi/+bx+QA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZRrult+cnpc=")[iii % 8])).ToArray())
            },
            {
                0x00030000,
                Encoding.UTF8.GetString(Convert.FromBase64String("AzjXZLcSXvUxdtRlqRBf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qla4Cs5/MYA=")[iii % 8])).ToArray())
            }
        };
        for (int i = 0; i <= 4; i++)
        {
            keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("m6D2eDvbVAWUn/9gJdlPBbuT3WUvyEkTp6nkUBvTSASnuONQD89UEq2h5FopyFUJp6HMRSLOQxKmquQsH99SFKGh938Q4EkOrbzM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yM+QDEy6JmA=")[iii % 8])).ToArray()) + i;
            var authSetting = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, keyPath, Encoding.UTF8.GetString(Convert.FromBase64String("7TQnWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3HUXaNYKqhI=")[iii % 8])).ToArray()));
            if (authSetting != null)
            {
                var zone = zoneMapKeys.AsEnumerable().Single(l => l.Key == i.ToString()).Value;
                var authSettingStr = zoneAuthSettings.AsEnumerable().Single(l => l.Key == authSetting).Value;
                result.ZoneAuthSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("GNXmRQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UJ6qCI1dTa4=")[iii % 8])).ToArray()), keyPath, Encoding.UTF8.GetString(Convert.FromBase64String("myJpoA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qmNZkH2Y4Gc=")[iii % 8])).ToArray()), authSetting.ToString(), $"{zone} : {authSettingStr}"));
            }
        }

        yield return result;
    }

    internal class O_445A92E6
    {
        public O_445A92E6(string hive, string path, string valueName, string value, string? interpretation)
        {
            Hive = hive;
            Path = path;
            ValueName = valueName;
            Value = value;
            Interpretation = interpretation;
        }

        public string Hive { get; }
        public string Path { get; }
        public string ValueName { get; }
        public string Value { get; }
        public string? Interpretation { get; }
    }

internal class O_1177CAA2 : O_4AED570F
{
    public List<O_445A92E6> GeneralSettings { get; set; } = new List<O_445A92E6>();
    public List<O_445A92E6> ZoneMaps { get; set; } = new List<O_445A92E6>();
    public List<O_445A92E6> ZoneAuthSettings { get; set; } = new List<O_445A92E6>();
}    [CommandOutputType(typeof(O_1177CAA2))]
    internal class O_E99D9E3E : TextFormatterBase
    {
        public O_E99D9E3E(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_1177CAA2)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mMUyG2wJ5v6MxSgKdwbtrQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36Bcfh5oit4=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Sh9iHa+vM5FKRCgB4b9ukVAfYh+vhQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aj8ZLdKPE7E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("oLD/4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6NmJh53BpmE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hY68").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zuvFMi29pNg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("h6rOjwo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0cui+m8ViJQ=")[iii % 8])).ToArray()));
            foreach (var i in dto.GeneralSettings)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WvoDNSUNmtdaoUkpax3H10D6Azcl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("etp4BVgtuvc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("R1sY1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DxBbgW7G7sU=")[iii % 8])).ToArray()), i.ValueName, i.Value);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gA4Wm3Snw+OqASu5Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iltE1weHoZo=")[iii % 8])).ToArray()));
            if (dto.ZoneMaps.Count == 0)
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("NGwAs3HpmPhnbC2zP9qj02E+K7g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FExO3FG8yrQ=")[iii % 8])).ToArray()));
            foreach (var i in dto.ZoneMaps)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("t7rdHmFyVK67t5UeYXIVv+yo2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l5qmLhxSL58=")[iii % 8])).ToArray()), i.Hive, i.ValueName, i.Interpretation);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("u3mVz3STsB7FS9rydMeFAt9EiQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sSP6oRGz8Ws=")[iii % 8])).ToArray()));
            foreach (var i in dto.ZoneAuthSettings)
            {
                WriteLine($"  {i.Interpretation}");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string shQxPjPQ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxByteCount(78);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_1177CAA2)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mMUyG2wJ5v6MxSgKdwbtrQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36Bcfh5oit4=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Sh9iHa+vM5FKRCgB4b9ukVAfYh+vhQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aj8ZLdKPE7E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("oLD/4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6NmJh53BpmE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hY68").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zuvFMi29pNg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("h6rOjwo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0cui+m8ViJQ=")[iii % 8])).ToArray()));
            foreach (var i in dto.GeneralSettings)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WvoDNSUNmtdaoUkpax3H10D6Azcl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("etp4BVgtuvc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("R1sY1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DxBbgW7G7sU=")[iii % 8])).ToArray()), i.ValueName, i.Value);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gA4Wm3Snw+OqASu5Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iltE1weHoZo=")[iii % 8])).ToArray()));
            if (dto.ZoneMaps.Count == 0)
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("NGwAs3HpmPhnbC2zP9qj02E+K7g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FExO3FG8yrQ=")[iii % 8])).ToArray()));
            foreach (var i in dto.ZoneMaps)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("t7rdHmFyVK67t5UeYXIVv+yo2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l5qmLhxSL58=")[iii % 8])).ToArray()), i.Hive, i.ValueName, i.Interpretation);
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("u3mVz3STsB7FS9rydMeFAt9EiQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sSP6oRGz8Ws=")[iii % 8])).ToArray()));
            foreach (var i in dto.ZoneAuthSettings)
            {
                WriteLine($"  {i.Interpretation}");
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string pSMzuxQH)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxByteCount(78);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var result = new O_1177CAA2();
        var keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("Xqp8r+Tv2EhRiHO44eHZQmuxRoz64M5CerZGmOb82EhjsUy+4f3DQmOZU7Xn69hDaLE6iPb63kRjomk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DcUa25OOqi0=")[iii % 8])).ToArray());
        var proxySettings = RegistryUtil.GetValues(RegistryHive.CurrentUser, keyPath);
        foreach (var kvp in proxySettings)
        {
            result.GeneralSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("qqwwkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4udzx1msDr0=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), null));
        }

        keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("qkJJUN26UOKlYEZH2LRR6J9Zc3PDtUbojl5zZ9+pUOKXWXlB2KhL6JdxZkrevlDpnFkPd8+vVu6XSlw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+S0vJKrbIoc=")[iii % 8])).ToArray());
        var proxySettings2 = RegistryUtil.GetValues(RegistryHive.LocalMachine, keyPath);
        foreach (var kvp in proxySettings2)
        {
            result.GeneralSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("pIjliw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7MOpxuXdLsY=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), null));
        }

        IDictionary<string, string> zoneMapKeys = new Dictionary<string, string>()
        {
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("eg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("StV9Soyhrw0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("N4M+RIHzlacOn2w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evoeB+6e5dI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Rg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d4eFrOeUZcY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kOoAcAOz7xWo9wJ/CueGIbPrBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3IVjEW+Tpns=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vWZUQRiNc08=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NSdbiA0O23cyPFqeCkvlOA8w").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YVUu+3lrv1c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("KA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G8lO5xN3aVY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("saOrEMIaroTYl7Ab1Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+M3fdbB0y/A=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VtXbIrTEeo4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("QSpPMZH+TKJ2KxwWiuNKpTMVUyuG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E088ReOXL9Y=")[iii % 8])).ToArray())
            }
        };
        keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("DjQKHNoZN20BCwMExBssbS4HIQHOCip7Mj0YNPoRK2wyLB807g03ejg1GD7ICjZhMjUwIcMMIHozPhhI/h0xfDQ1CxvxIipmOBYNGOYdPA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XVtsaK14RQg=")[iii % 8])).ToArray());
        var zoneMapKey = RegistryUtil.GetValues(RegistryHive.LocalMachine, keyPath);
        foreach (var kvp in zoneMapKey.AsEnumerable())
        {
            result.ZoneMaps.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("8kSGwA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ug/KjSDcpqw=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), zoneMapKeys.AsEnumerable().Single(l => l.Key == kvp.Value.ToString()).Value));
        }

        var zoneMapKey2 = RegistryUtil.GetValues(RegistryHive.CurrentUser, keyPath);
        foreach (var kvp in zoneMapKey2.AsQueryable())
        {
            result.ZoneMaps.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("0O1guA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mKYj7SN2FbQ=")[iii % 8])).ToArray()), keyPath, kvp.Key, kvp.Value.ToString(), zoneMapKeys.AsEnumerable().Single(l => l.Key == kvp.Value.ToString()).Value));
        }

        IDictionary<uint, string> zoneAuthSettings = new Dictionary<uint, string>()
        {
            {
                0x00000000,
                Encoding.UTF8.GetString(Convert.FromBase64String("W64NoeM/GGp5uhWi934AbH20F+75NxhrOrgMvPw7Anc6rgqr/DANbn/7GKDqfhxiaagOofw6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gtt5zo5ebAM=")[iii % 8])).ToArray())
            },
            {
                0x00010000,
                Encoding.UTF8.GetString(Convert.FromBase64String("Pg6vOrlG/xMBDuAiuletVQAdrTLpU7ERTgyhJLpFsAcK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bnzAV8ky33U=")[iii % 8])).ToArray())
            },
            {
                0x00020000,
                Encoding.UTF8.GetString(Convert.FromBase64String("JG+a+bL96v4GOoL5uPPwtwp0gu//9fC3EXKLtpby6uUEdIvi/+bx+QA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZRrult+cnpc=")[iii % 8])).ToArray())
            },
            {
                0x00030000,
                Encoding.UTF8.GetString(Convert.FromBase64String("AzjXZLcSXvUxdtRlqRBf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qla4Cs5/MYA=")[iii % 8])).ToArray())
            }
        };
        for (int i = 0; i <= 4; i++)
        {
            keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("m6D2eDvbVAWUn/9gJdlPBbuT3WUvyEkTp6nkUBvTSASnuONQD89UEq2h5FopyFUJp6HMRSLOQxKmquQsH99SFKGh938Q4EkOrbzM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yM+QDEy6JmA=")[iii % 8])).ToArray()) + i;
            var authSetting = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, keyPath, Encoding.UTF8.GetString(Convert.FromBase64String("7TQnWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3HUXaNYKqhI=")[iii % 8])).ToArray()));
            if (authSetting != null)
            {
                var zone = zoneMapKeys.AsEnumerable().Single(l => l.Key == i.ToString()).Value;
                var authSettingStr = zoneAuthSettings.AsEnumerable().Single(l => l.Key == authSetting).Value;
                result.ZoneAuthSettings.Add(new O_445A92E6(Encoding.UTF8.GetString(Convert.FromBase64String("GNXmRQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UJ6qCI1dTa4=")[iii % 8])).ToArray()), keyPath, Encoding.UTF8.GetString(Convert.FromBase64String("myJpoA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qmNZkH2Y4Gc=")[iii % 8])).ToArray()), authSetting.ToString(), $"{zone} : {authSettingStr}"));
            }
        }

        yield return result;
    }
}}
#nullable enable
