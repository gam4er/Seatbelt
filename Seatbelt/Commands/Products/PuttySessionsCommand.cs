using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_B2CD92E7 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("bz3cHpWBWKtMIccEnw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P0ioauzSPdg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ea4LPO+JeFJeuwR56MZGQUOoCCvq3UFIRO9VMOXdTVVPvAkw5c4IQUOqET34gAhGRKtdCtjhCE9FvAl54MxRVA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ks99WYupKCc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_B2CD92E7(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("wBhYzTw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kzVp4Al4ijk=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yteaFaTD2t8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lZT2dNewv6w=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var subKeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\Sessions\\");
            if (subKeys == null)
                continue;
            var Sessions = new List<Dictionary<string, string>>();
            foreach (var sessionName in subKeys)
            {
                var Settings = new Dictionary<string, string>
                {
                    [Encoding.UTF8.GetString(Convert.FromBase64String("+HnCDryLczPKcdQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qxyxfdXkHX0=")[iii % 8])).ToArray())] = sessionName
                };
                string[] keys =
                {
                    Encoding.UTF8.GetString(Convert.FromBase64String("K38WGjRH9Kc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YxBlbnommcI=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("wx9gkWgIAVY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lmwF4yZpbDM=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("3pQaD1RTz633pxEPWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("juF4Yz0whMg=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("tyf5ZxonyBWGOu96Mi/J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("50iLE1xIumI=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("yMapHkS8x8/kx5QYQK3ayOw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i6nHcCHfs6Y=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("OopfQc8OatM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e+06L7tIHbc=")[iii % 8])).ToArray())
                };
                foreach (var key in keys)
                {
#nullable disable
                    var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\Sessions\\{sessionName}", key);
                    if (!string.IsNullOrEmpty(result))
                    {
                        Settings[key] = result;
                    }
#nullable enable
                }

                Sessions.Add(Settings);
            }

            if (Sessions.Count != 0)
            {
                yield return new O_3C8B5AC7(sid, Sessions);
            }
        }
    }

internal class O_3C8B5AC7 : O_4AED570F
{
    public O_3C8B5AC7(string sid, List<Dictionary<string, string>> sessions)
    {
        Sid = sid;
        Sessions = sessions;
    }

    public string Sid { get; }
    public List<Dictionary<string, string>> Sessions { get; }
}    [CommandOutputType(typeof(O_3C8B5AC7))]
    internal class O_CD50B2D2 : TextFormatterBase
    {
        public O_CD50B2D2(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_3C8B5AC7)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("q1IgKaN6UII=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i3JbGd5aaog=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var session in dto.Sessions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EpU4H38tHmYfhyhCf2wOMQPI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MrUYP19WLko=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("LaApDlne0+kfqD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fsVafTCxvac=")[iii % 8])).ToArray()), session[Encoding.UTF8.GetString(Convert.FromBase64String("La7G3uCNxY4fptA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fsu1rYniq8A=")[iii % 8])).ToArray())]);
                foreach (var key in session.Keys)
                {
                    if (!key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("454AqoS99U7RlhY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sPtz2e3SmwA=")[iii % 8])).ToArray())))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KB3Bru7UFLolD9Hz7pUE7TlA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CD3hjs6vJJY=")[iii % 8])).ToArray()), key, session[key]);
                    }
                }

                WriteLine();
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string PXmBcPhW)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                        instance.ToFourDigitYear(16);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_3C8B5AC7)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("q1IgKaN6UII=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i3JbGd5aaog=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var session in dto.Sessions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EpU4H38tHmYfhyhCf2wOMQPI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MrUYP19WLko=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("LaApDlne0+kfqD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fsVafTCxvac=")[iii % 8])).ToArray()), session[Encoding.UTF8.GetString(Convert.FromBase64String("La7G3uCNxY4fptA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fsu1rYniq8A=")[iii % 8])).ToArray())]);
                foreach (var key in session.Keys)
                {
                    if (!key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("454AqoS99U7RlhY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sPtz2e3SmwA=")[iii % 8])).ToArray())))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KB3Bru7UFLolD9Hz7pUE7TlA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CD3hjs6vJJY=")[iii % 8])).ToArray()), key, session[key]);
                    }
                }

                WriteLine();
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string IsewVyTu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                    instance.ToFourDigitYear(16);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("wBhYzTw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kzVp4Al4ijk=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yteaFaTD2t8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lZT2dNewv6w=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var subKeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\Sessions\\");
            if (subKeys == null)
                continue;
            var Sessions = new List<Dictionary<string, string>>();
            foreach (var sessionName in subKeys)
            {
                var Settings = new Dictionary<string, string>
                {
                    [Encoding.UTF8.GetString(Convert.FromBase64String("+HnCDryLczPKcdQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qxyxfdXkHX0=")[iii % 8])).ToArray())] = sessionName
                };
                string[] keys =
                {
                    Encoding.UTF8.GetString(Convert.FromBase64String("K38WGjRH9Kc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YxBlbnommcI=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("wx9gkWgIAVY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lmwF4yZpbDM=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("3pQaD1RTz633pxEPWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("juF4Yz0whMg=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("tyf5ZxonyBWGOu96Mi/J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("50iLE1xIumI=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("yMapHkS8x8/kx5QYQK3ayOw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i6nHcCHfs6Y=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("OopfQc8OatM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e+06L7tIHbc=")[iii % 8])).ToArray())
                };
                foreach (var key in keys)
                {
#nullable disable
                    var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\Sessions\\{sessionName}", key);
                    if (!string.IsNullOrEmpty(result))
                    {
                        Settings[key] = result;
                    }
#nullable enable
                }

                Sessions.Add(Settings);
            }

            if (Sessions.Count != 0)
            {
                yield return new O_3C8B5AC7(sid, Sessions);
            }
        }
    }
}}