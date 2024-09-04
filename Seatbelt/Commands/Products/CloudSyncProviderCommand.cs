#nullable disable
using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_DD3D4417
    {
        public Dictionary<string, Dictionary<string, string>> mpList = new Dictionary<string, Dictionary<string, string>>();
        public Dictionary<string, Dictionary<string, string>> oneDriveList = new Dictionary<string, Dictionary<string, string>>();
        public Dictionary<string, List<string>> AcctoMPMapping = new Dictionary<string, List<string>>();
        public List<string> usedScopeIDs = new List<string>();
    }

    internal class O_0E201B79 : O_2183A68D
    {
        public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("GPu51vW9BSY4x6TM54cYLSnk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W5fWo5HufEg=")[iii % 8])).ToArray());
        public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("y0vb4Ciw3PnjQMKyLruS0OxB3qMu/4GpvwfSri+v3fbkU8TgY6vX8etJw7Nrvtz7qlPSoSas2+vvVJ7gPLfb/OIH1rIu/8Hm5ETfsiSx2+zvQ5eiMv/98e9jxak9upw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iie3wEvfsp8=")[iii % 8])).ToArray());
        public override CommandGroup[] Group => new[]
        {
            CommandGroup.User
        };
        public override bool SupportRemote => true;

        public Runtime ThisRunTime;
        public O_0E201B79(Runtime runtime) : base(runtime)
        {
            ThisRunTime = runtime;
        }

        public override IEnumerable<O_4AED570F?> Execute(string[] args)
        {
            var SIDs = ThisRunTime.GetUserSIDs();
            foreach (var sid in SIDs)
            {
                if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("8YtVOrY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oqZkF4NJn6w=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("j+z9CJVv6f4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0K+RaeYcjI0=")[iii % 8])).ToArray())))
                    continue;
                O_DD3D4417 o = new O_DD3D4417();
                var subKeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\SyncEngines\\Providers\\OneDrive");
                if (subKeys == null)
                    continue;
                foreach (string rname in subKeys)
                {
                    Dictionary<string, string> provider = new Dictionary<string, string>();
                    foreach (string x in new List<string>
                    {
                        Encoding.UTF8.GetString(Convert.FromBase64String("G1T7VNa7WsouTfw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vz2ZJrfJI54=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("1NM25zniSnH+2yD3IORDfQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mLJFk3SNLhg=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("gaZZer0Wlb6ivQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zMksFMlG+tc=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("FMpaLTF5GAcx2VUG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qbg2Y1AUfXQ=")[iii % 8])).ToArray())
                    }

                    )
                    {
                        var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\SyncEngines\\Providers\\OneDrive\\{rname}", x);
                        if (!string.IsNullOrEmpty(result))
                            provider[x] = result;
                    }

                    o.mpList[rname] = provider;
                }

                var odAccounts = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts");
                if (odAccounts == null)
                    continue;
                foreach (string acc in odAccounts)
                {
                    Boolean business = false;
                    Dictionary<string, string> account = new Dictionary<string, string>();
                    foreach (string x in new List<string>
                    {
                        Encoding.UTF8.GetString(Convert.FromBase64String("4enyG1ATGf7E7eQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pYCBazxyYLA=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("k6KbWG+cLP0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0dfoMQH5X44=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("VGmHQRNyiRlpaIVYE3+YCXVl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bwz1N3oR7Fw=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("a9Ng93Mqz4JK4Erscg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OIMvpRZZoPc=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("wUhM0XWeSzj4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lDspozDzKlE=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("GP8hEhagMlYo/g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TYxEYFDPXjI=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("o5w7FRQrvow=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9u9eZ1pK0+k=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("A7Ua82h9B283tS3SYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VNB4oA0PcQY=")[iii % 8])).ToArray())
                    }

                    )
                    {
                        var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts\\{acc}", x);
                        if (!string.IsNullOrEmpty(result))
                            account[x] = result;
                        if (x == Encoding.UTF8.GetString(Convert.FromBase64String("F8MwrR19rNI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VbZDxHMY36E=")[iii % 8])).ToArray()))
                            business = (String.Compare(result, Encoding.UTF8.GetString(Convert.FromBase64String("iQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uIKTdv1VVFY=")[iii % 8])).ToArray())) == 0) ? true : false;
                    }

                    var odMountPoints = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts\\{acc}\\ScopeIdToMountPointPathCache");
                    List<string> ScopeIds = new List<string>();
                    if (business == true)
                    {
                        foreach (var mp in odMountPoints)
                        {
                            ScopeIds.Add(mp.Key);
                        }
                    }
                    else
                    {
                        ScopeIds.Add(acc);
                    }

                    o.AcctoMPMapping[acc] = ScopeIds;
                    o.oneDriveList[acc] = account;
                    o.usedScopeIDs.AddRange(ScopeIds);
                }

                yield return new O_0605B384(sid, o);
            }
        }

        internal class O_0605B384 : O_4AED570F
        {
            public O_0605B384(string sid, O_DD3D4417 odsp)
            {
                Sid = sid;
                Odsp = odsp;
            }

            public string Sid { get; }
            public O_DD3D4417 Odsp { get; }
        }

        [CommandOutputType(typeof(O_0605B384))]
        internal class O_BCC1070F : TextFormatterBase
        {
            public O_BCC1070F(ITextWriter writer) : base(writer)
            {
            }

            public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
            {
                var dto = (O_0605B384)result;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("P5FgLplUow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H7EbHuR0mSg=")[iii % 8])).ToArray()), dto.Sid);
                foreach (var item in dto.Odsp.oneDriveList)
                {
                    if (item.Value.Count == 0)
                        continue;
                    string accName = item.Key;
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("md9qOpM1c/Hp9XA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lNVKGrMVCME=")[iii % 8])).ToArray()), accName);
                    foreach (var subItem in item.Value)
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("FMjdsF7JOv5JyMewBdg8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NOj9kH7pQc4=")[iii % 8])).ToArray()), subItem.Key, subItem.Value);
                    }

                    foreach (string mp in dto.Odsp.AcctoMPMapping[accName])
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("siInYk4qrMw=")[iii % 8])).ToArray()));
                        if (!dto.Odsp.mpList.ContainsKey(mp))
                            continue;
                        foreach (var mpSub in dto.Odsp.mpList[mp])
                        {
                            if (mpSub.Key == Encoding.UTF8.GetString(Convert.FromBase64String("EuQvX2TjXH847DlPfeVVcw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XoVcKymMOBY=")[iii % 8])).ToArray()))
                            {
                                DateTime parsedDate;
                                DateTime.TryParse(mpSub.Value, out parsedDate);
                                string formattedDate = parsedDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("D3XfIDUCrVomXJt5KB/0NyNZgW08XP5k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("axG7AFFmjRc=")[iii % 8])).ToArray()));
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1sqOyApxle6N2tPIEHGS/4vKhpMYLMA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9uqu6CpR6c4=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value, formattedDate);
                            }
                            else
                            {
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uRPkww1uIibiA7nDF24lN+Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mTPE4y1OXgY=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value);
                            }
                        }
                    }
                }

                List<string> AllScopeIds = new List<string>(dto.Odsp.mpList.Keys);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QKFc5uiG+dE9wx2orcKWmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tat8xsimtqM=")[iii % 8])).ToArray()));
                foreach (string scopeid in AllScopeIds)
                {
                    if (!dto.Odsp.usedScopeIDs.Contains(scopeid))
                    {
                        foreach (var mpSub in dto.Odsp.mpList[scopeid])
                        {
                            if (mpSub.Key == Encoding.UTF8.GetString(Convert.FromBase64String("FR4hAo2hcVs/FjcSlKd4Vw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WX9SdsDOFTI=")[iii % 8])).ToArray()))
                            {
                                DateTime parsedDate;
                                DateTime.TryParse(mpSub.Value, out parsedDate);
                                string formattedDate = parsedDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("t8CXJk75k/me6dN/U+TKlJvsyWtHp8DH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("06TzBiqds7Q=")[iii % 8])).ToArray()));
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XMmvJSBQ/ggBybUle0H4GFSSvXgp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOmPBQBwhTg=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value, formattedDate);
                            }
                            else
                            {
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1CMPct2zLlCJIxVyhqIo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9AMvUv2TVWA=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value);
                            }
                        }

                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uvWDBxlf+1M=")[iii % 8])).ToArray()));
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fVv60Qw5g48=")[iii % 8])).ToArray()));
            }

            public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ChVcWUht)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                            instance.GetMaxByteCount(42);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                var dto = (O_0605B384)result;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("P5FgLplUow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H7EbHuR0mSg=")[iii % 8])).ToArray()), dto.Sid);
                foreach (var item in dto.Odsp.oneDriveList)
                {
                    if (item.Value.Count == 0)
                        continue;
                    string accName = item.Key;
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("md9qOpM1c/Hp9XA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lNVKGrMVCME=")[iii % 8])).ToArray()), accName);
                    foreach (var subItem in item.Value)
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("FMjdsF7JOv5JyMewBdg8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NOj9kH7pQc4=")[iii % 8])).ToArray()), subItem.Key, subItem.Value);
                    }

                    foreach (string mp in dto.Odsp.AcctoMPMapping[accName])
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("siInYk4qrMw=")[iii % 8])).ToArray()));
                        if (!dto.Odsp.mpList.ContainsKey(mp))
                            continue;
                        foreach (var mpSub in dto.Odsp.mpList[mp])
                        {
                            if (mpSub.Key == Encoding.UTF8.GetString(Convert.FromBase64String("EuQvX2TjXH847DlPfeVVcw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XoVcKymMOBY=")[iii % 8])).ToArray()))
                            {
                                DateTime parsedDate;
                                DateTime.TryParse(mpSub.Value, out parsedDate);
                                string formattedDate = parsedDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("D3XfIDUCrVomXJt5KB/0NyNZgW08XP5k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("axG7AFFmjRc=")[iii % 8])).ToArray()));
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1sqOyApxle6N2tPIEHGS/4vKhpMYLMA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9uqu6CpR6c4=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value, formattedDate);
                            }
                            else
                            {
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uRPkww1uIibiA7nDF24lN+Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mTPE4y1OXgY=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value);
                            }
                        }
                    }
                }

                List<string> AllScopeIds = new List<string>(dto.Odsp.mpList.Keys);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QKFc5uiG+dE9wx2orcKWmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tat8xsimtqM=")[iii % 8])).ToArray()));
                foreach (string scopeid in AllScopeIds)
                {
                    if (!dto.Odsp.usedScopeIDs.Contains(scopeid))
                    {
                        foreach (var mpSub in dto.Odsp.mpList[scopeid])
                        {
                            if (mpSub.Key == Encoding.UTF8.GetString(Convert.FromBase64String("FR4hAo2hcVs/FjcSlKd4Vw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WX9SdsDOFTI=")[iii % 8])).ToArray()))
                            {
                                DateTime parsedDate;
                                DateTime.TryParse(mpSub.Value, out parsedDate);
                                string formattedDate = parsedDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("t8CXJk75k/me6dN/U+TKlJvsyWtHp8DH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("06TzBiqds7Q=")[iii % 8])).ToArray()));
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XMmvJSBQ/ggBybUle0H4GFSSvXgp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOmPBQBwhTg=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value, formattedDate);
                            }
                            else
                            {
                                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1CMPct2zLlCJIxVyhqIo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9AMvUv2TVWA=")[iii % 8])).ToArray()), mpSub.Key, mpSub.Value);
                            }
                        }

                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uvWDBxlf+1M=")[iii % 8])).ToArray()));
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fVv60Qw5g48=")[iii % 8])).ToArray()));
            }
        }

        public IEnumerable<O_4AED570F?> Execute(string[] args, string WVzkQHgM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxByteCount(42);
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
                if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("8YtVOrY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oqZkF4NJn6w=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("j+z9CJVv6f4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0K+RaeYcjI0=")[iii % 8])).ToArray())))
                    continue;
                O_DD3D4417 o = new O_DD3D4417();
                var subKeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\SyncEngines\\Providers\\OneDrive");
                if (subKeys == null)
                    continue;
                foreach (string rname in subKeys)
                {
                    Dictionary<string, string> provider = new Dictionary<string, string>();
                    foreach (string x in new List<string>
                    {
                        Encoding.UTF8.GetString(Convert.FromBase64String("G1T7VNa7WsouTfw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vz2ZJrfJI54=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("1NM25zniSnH+2yD3IORDfQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mLJFk3SNLhg=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("gaZZer0Wlb6ivQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zMksFMlG+tc=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("FMpaLTF5GAcx2VUG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qbg2Y1AUfXQ=")[iii % 8])).ToArray())
                    }

                    )
                    {
                        var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\SyncEngines\\Providers\\OneDrive\\{rname}", x);
                        if (!string.IsNullOrEmpty(result))
                            provider[x] = result;
                    }

                    o.mpList[rname] = provider;
                }

                var odAccounts = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts");
                if (odAccounts == null)
                    continue;
                foreach (string acc in odAccounts)
                {
                    Boolean business = false;
                    Dictionary<string, string> account = new Dictionary<string, string>();
                    foreach (string x in new List<string>
                    {
                        Encoding.UTF8.GetString(Convert.FromBase64String("4enyG1ATGf7E7eQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pYCBazxyYLA=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("k6KbWG+cLP0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0dfoMQH5X44=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("VGmHQRNyiRlpaIVYE3+YCXVl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bwz1N3oR7Fw=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("a9Ng93Mqz4JK4Erscg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OIMvpRZZoPc=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("wUhM0XWeSzj4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lDspozDzKlE=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("GP8hEhagMlYo/g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TYxEYFDPXjI=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("o5w7FRQrvow=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9u9eZ1pK0+k=")[iii % 8])).ToArray()),
                        Encoding.UTF8.GetString(Convert.FromBase64String("A7Ua82h9B283tS3SYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VNB4oA0PcQY=")[iii % 8])).ToArray())
                    }

                    )
                    {
                        var result = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts\\{acc}", x);
                        if (!string.IsNullOrEmpty(result))
                            account[x] = result;
                        if (x == Encoding.UTF8.GetString(Convert.FromBase64String("F8MwrR19rNI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VbZDxHMY36E=")[iii % 8])).ToArray()))
                            business = (String.Compare(result, Encoding.UTF8.GetString(Convert.FromBase64String("iQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uIKTdv1VVFY=")[iii % 8])).ToArray())) == 0) ? true : false;
                    }

                    var odMountPoints = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\OneDrive\\Accounts\\{acc}\\ScopeIdToMountPointPathCache");
                    List<string> ScopeIds = new List<string>();
                    if (business == true)
                    {
                        foreach (var mp in odMountPoints)
                        {
                            ScopeIds.Add(mp.Key);
                        }
                    }
                    else
                    {
                        ScopeIds.Add(acc);
                    }

                    o.AcctoMPMapping[acc] = ScopeIds;
                    o.oneDriveList[acc] = account;
                    o.usedScopeIDs.AddRange(ScopeIds);
                }

                yield return new O_0605B384(sid, o);
            }
        }
    }
}