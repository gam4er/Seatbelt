using System;
using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_DFA2EACB : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("/eFEEVu8xCPP7k8bUK7F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qogqdTTLt2c=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("7HINTxK1Ihz/fgVOE6Y0TptoBl8Jqz9byDtLQhOhPUnfcg1MXacpX9duEEISrHFQ1HgCXxStP0+S").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uxtjK33CUTw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_DFA2EACB(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        yield return new O_E409597E(new WindowsDefenderSettings(Encoding.UTF8.GetString(Convert.FromBase64String("17XOfZFbyXXYt+FKtHXoX+KO1H6vdP9f84mobaN8/l7gn/p1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hPqIKcYamzA=")[iii % 8])).ToArray()), ThisRunTime), new WindowsDefenderSettings(Encoding.UTF8.GetString(Convert.FromBase64String("jPyd+1MSiN2D47TDbTCz/azvlsZnIbXrsNWv81M6tPywxKiPQDa8/bHXvt1Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("37PbrwRT2pg=")[iii % 8])).ToArray()), ThisRunTime));
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string cbSgjPlP)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(53);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        yield return new O_E409597E(new WindowsDefenderSettings(Encoding.UTF8.GetString(Convert.FromBase64String("17XOfZFbyXXYt+FKtHXoX+KO1H6vdP9f84mobaN8/l7gn/p1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hPqIKcYamzA=")[iii % 8])).ToArray()), ThisRunTime), new WindowsDefenderSettings(Encoding.UTF8.GetString(Convert.FromBase64String("jPyd+1MSiN2D47TDbTCz/azvlsZnIbXrsNWv81M6tPywxKiPQDa8/bHXvt1Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("37PbrwRT2pg=")[iii % 8])).ToArray()), ThisRunTime));
    }
}
    internal class AsrRule
    {
        public AsrRule(Guid rule, int state)
        {
            Rule = rule;
            State = state;
        }

        public Guid Rule { get; }
        public int State { get; }
    }

    internal class AsrSettings
    {
        public AsrSettings(bool enabled)
        {
            Enabled = enabled;
            Rules = new List<AsrRule>();
            Exclusions = new List<string>();
        }

        public bool Enabled { get; }
        public List<AsrRule> Rules { get; }
        public List<string> Exclusions { get; }
    }
internal class O_E409597E : O_4AED570F
{
    public O_E409597E(WindowsDefenderSettings localSettings, WindowsDefenderSettings groupPolicySettings)
    {
        LocalSettings = localSettings;
        GroupPolicySettings = groupPolicySettings;
    }

    public WindowsDefenderSettings LocalSettings { get; set; }
    public WindowsDefenderSettings GroupPolicySettings { get; set; }
}
    internal class WindowsDefenderSettings
    {
        public WindowsDefenderSettings(string defenderKeyPath, Runtime runtime)
        {
            var pathExclusionData = runtime.GetValues(RegistryHive.LocalMachine, $"{defenderKeyPath}\\Exclusions\\Paths");
            PathExclusions = new List<string>();
            foreach (var kvp in pathExclusionData)
            {
                PathExclusions.Add(kvp.Key);
            }

            PolicyManagerPathExclusions = new List<string>();
            var excludedPaths = runtime.GetStringValue(RegistryHive.LocalMachine, $"{defenderKeyPath}\\Policy Manager", Encoding.UTF8.GetString(Convert.FromBase64String("/uNJd18W32zr+l5zWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u5sqGypyugg=")[iii % 8])).ToArray()));
            if (excludedPaths != null)
            {
                foreach (var s in excludedPaths.Split('|'))
                {
                    PolicyManagerPathExclusions.Add(s);
                }
            }

            var processExclusionData = runtime.GetValues(RegistryHive.LocalMachine, $"{defenderKeyPath}\\Exclusions\\Processes");
            ProcessExclusions = new List<string>();
            foreach (var kvp in processExclusionData)
            {
                ProcessExclusions.Add(kvp.Key);
            }

            var extensionExclusionData = runtime.GetValues(RegistryHive.LocalMachine, $"{defenderKeyPath}\\Exclusions\\Extensions");
            ExtensionExclusions = new List<string>();
            foreach (var kvp in extensionExclusionData)
            {
                ExtensionExclusions.Add(kvp.Key);
            }

            var asrKeyPath = $"{defenderKeyPath}\\Windows Defender Exploit Guard\\ASR";
            var asrEnabled = runtime.GetDwordValue(RegistryHive.LocalMachine, asrKeyPath, Encoding.UTF8.GetString(Convert.FromBase64String("ehGlljtovytKCKeeC0CYPmA7oJYxcg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P2nV+lQBy2w=")[iii % 8])).ToArray()));
            AsrSettings = new AsrSettings(asrEnabled != null && (asrEnabled != 0));
            foreach (var value in runtime.GetValues(RegistryHive.LocalMachine, $"{asrKeyPath}\\Rules"))
            {
                AsrSettings.Rules.Add(new AsrRule(new Guid(value.Key), int.Parse((string)value.Value)));
            }

            foreach (var value in runtime.GetValues(RegistryHive.LocalMachine, $"{asrKeyPath}\\ASROnlyExclusions"))
            {
                AsrSettings.Exclusions.Add(value.Key);
            }
        }

        public List<string> PathExclusions { get; }
        public List<string> PolicyManagerPathExclusions { get; }
        public List<string> ProcessExclusions { get; }
        public List<string> ExtensionExclusions { get; }
        public AsrSettings AsrSettings { get; }
    }

    [CommandOutputType(typeof(O_E409597E))]
    internal class O_21A92342 : TextFormatterBase
    {
        public O_21A92342(ITextWriter writer) : base(writer)
        {
        }

        private Dictionary<string, string> _AsrGuids = new Dictionary<string, string>
        {
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("iGZXty3K1b/BZgG/e9eAuIoxHO94ntfwjTYE6CqZge3aagnv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7FIxjhn6tN0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7XnT6twfuBbDNfPv0Va6H490zPnbVrob23zT58QfvwjAeJzqxVq4DsZ726nUV7AWyzXM+9hcvAnccM8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rxW8ibc/2Xo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("OazWJYLijoIhqNd+1Krc0jn4nn+FtozKPvmGIoDhjoQ8+tAk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DM6zR7WH6Oc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5ZF3RhZIijHCnm1RFAeBacibOFUSHIon05R5SRERzybFm21WHgmbLMPda0YPAZ891A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p/0YJX1o70k=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ao3EV6/NvI4WjcQK/obpiwyJjAz8z+uSAtvFXvqfudtf3JYM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O7+hbpir3b8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("MnD/nuCUInkeL6LdyuQ8MBN9/JH4lBNiH3Gwsu3SHHMVPP2c6MYaGQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cByQ/Yu0dRA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("qtrw+egJa6K02fGrvRxprquB6PbrAmu2+4D1r+kGa6L8gPz3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mbjFzt4xXZs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hk1R/qQHQvGiSF3470Z956hIXfy7TmL5twFY76BKLfS2RF/ppklqt6FZW/66U2z1qEQe/qBJefKqVTc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xCE+nc8nDZc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("EJpV8nPmyYwKmFCmfqjMiUGfTqYpvMvHFMoAon7mmt1EzFvw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J69jxEuF+Oo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("HmAA6+L+I9M6ZQztqb8cxTBlDOn9twPbLywJ+uazTNwyZgrr/bcC0nxvAOzs/gXbKGNP5/22Ccd8fB3n6rsfxjl/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XAxviInebLU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("LdipdZEkqPdk2Kknmj758irT4SSbIvrrfNz1d5Uq+fF80voh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SevMRaITzcY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("po0oLrYEpp6SgBQur02ci8SONW2LZr+clog3Of1CnpCJwSssqEqPl42PIG25S5uRiI4mKbhAzJqchCQ4qUWOk4HBJCKzUImRkA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5OFHTd0k7P8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("WmnpaMshPJ0VOeNvyz5sx1xv/TKedm2JAW7hb892PZAOOeU6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OAzQCqoTWKQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("XW8r/A2hnr56YDHrB+OXoz9gK/ES5JWyP2U28Auhnqt+aii/Be2So3F3ZP4I5duxemEp/g/t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HwNEn2aB+8Y=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("knpKuMxpjGuPKBq7y3KJbJEqU+7GZthykC4d6Jxvij3EKEy5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("okt+jP9fvV8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("CfIb3LcU4QYu/QHLvVboG2v4HdO5R6QYOfEZn65B6hAi8BOfqVroGzjtVMu0Uf1eJvsRy/xVpA45+wLesFHqHS6yVN67UaheJOxUy65B9wou+lTTtUfwXijsHcu5Ru0f").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S550v9w0hH4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("YUXS4/z5UT8vF4SwqOEEazFDm+Or/1ZwY0WEtP/0AW07EIW0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AnS2gcnMMF0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("H0dSABOSFKMkV1JEUoYQrT5RVFQbmQziK1NWSRyFFuI4VVlTHZsVozhR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SjQ3IHL2YsI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("L8HUU4/R16s7k4YGi5nS+iTCz1LahYfgd5fbVd2C0PRzkIAC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FqTiMLu05s0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("0dweVi3Zgtr21BRbMpCAxLPDBVAnlYjG9JAXRymUwdz71VFiL5eFx+TDUVkpmoDEs8MUVjOLiNzqkBBAMpGO2vrECBU1jIPb6sMFUCvZycTg0QJGaJyZzbo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k7BxNUb54ag=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("f6PYg7ljJhk2qtuCti9zSCOikNW5YCZXIquO1rZmcE0voovU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G5K9t4ACR3o=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IMQgWBBbwdoNyypICFvS2gfJO1IUFcKIDdomXBIV0NwLxigbHQnexUL4HH4DHtKIA8YrGyw2+IgBxyJWGhXV2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YqhPO3t7sag=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7XDjbLM1c3aidOBp4Ch0dLggrD7sZnc/viG2OrMydHO2IOBr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j0KBX9UFQBI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("zGLMTyzERH/6fNZfM4FVMe9gxwwyikJ46WDGSGeUQ37ta9BfIpcRZeZv1ww1kV8x6HzMQWexYlM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jg6jLEfkMRE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Fqc1tQlLcH0JoDK8C159fUGpKbRbQX5pQfM16AkSeCdBqTK1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JJEEjDlzSUQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("KcnXN1SM9zUNzNsxH8/XPgbQ1j1czcw6BMuYNU/c1DoIxMw9UMLLcw3X1zkfz8o2CtHROliM2zsCydx0T97XMA7WyzFM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a6W4VD+suFM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("DwzXZNR18VEVCdc11DnwAgxczTGPdfVOXgqGadcl8lIBW9Iz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ODrgULYUxGM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("uag1uKDE+WqUpj/7mYHZap62er25i9UumLY/ur+N1mnbpzKyp4CYfomrOb64l919").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+8Ra28vkuA4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("BekEtjfPXzpN7ASyMtUObAbuTbY5zVsiVuxW7TfBCTpRulW2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YN9g1AD4Og8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("pE9AmFybhA6UUEaIQ96aCIMDW5NF1IEMjgN4tn6bkR2DTVvbRM6WGIVRRotD0psF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5iMv+ze79Gs=")[iii % 8])).ToArray())
            },
        };
        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_E409597E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3z+4WFdQjeP3Nb1QVVmQ7sA1r01SUpO9qQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k1DbOTs89M4=")[iii % 8])).ToArray()));
            DisplayDefenderSettings(dto.LocalSettings);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gJAUBt5gEsjv/Hcv60sf/+/uaijgSEyW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ipoeQY4vP6w=")[iii % 8])).ToArray()));
            DisplayDefenderSettings(dto.GroupPolicySettings);
        }

        void DisplayDefenderSettings(WindowsDefenderSettings settings)
        {
            var pathExclusions = settings.PathExclusions;
            var processExclusions = settings.ProcessExclusions;
            var extensionExclusions = settings.ExtensionExclusions;
            var asrSettings = settings.AsrSettings;
            if (pathExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2Lqpshte3gSX4uqOD1nfS7zpsw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0pqJ4noqtiQ=")[iii % 8])).ToArray()));
                foreach (var path in pathExclusions)
                {
                    WriteLine($"    {path}");
                }
            }

            if (pathExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SwZ5YD/r6pQ4azheMeDmhRFHLVgV/+CbNFUwXz70uQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QSZZMFCHg/c=")[iii % 8])).ToArray()));
                foreach (var path in pathExclusions)
                {
                    WriteLine($"    {path}");
                }
            }

            if (processExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XIg+sZzk84Ul2z6kluj8lSXBcY+d").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vqge4e6LkOA=")[iii % 8])).ToArray()));
                foreach (var process in processExclusions)
                {
                    WriteLine($"    {process}");
                }
            }

            if (extensionExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gceJcCMpOjD4jsZbexgnPeeS2lw0Myw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i+epNVtdX14=")[iii % 8])).ToArray()));
                foreach (var ext in extensionExclusions)
                {
                    WriteLine($"    {ext}");
                }
            }

            if (asrSettings.Enabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6Howkix9u+SJekOmKm+75Id6QrY8fLnzizV+8wp8tuKRYBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4loQ01gJ2oc=")[iii % 8])).ToArray()));
                WriteLine($"    {Encoding.UTF8.GetString(Convert.FromBase64String("qTDj1sI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+kSCoqcfObw=")[iii % 8])).ToArray()), -10} Rule\n");
                foreach (var rule in asrSettings.Rules)
                {
                    string state;
                    if (rule.State == 0)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("fiLmKh8UN+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OkuVS314Uo0=")[iii % 8])).ToArray());
                    else if (rule.State == 1)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("RMDWVCf17w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bqy5N0yQi3c=")[iii % 8])).ToArray());
                    else if (rule.State == 2)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("Oeqnabpwlw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eJ/DAM4V8yU=")[iii % 8])).ToArray());
                    else
                        state = $"{rule.State} - Unknown";
                    var asrRule = _AsrGuids.ContainsKey(rule.Rule.ToString()) ? _AsrGuids[rule.Rule.ToString()] : $"{rule.Rule} - Please report this";
                    WriteLine($"    {state, -10} {asrRule}");
                }

                if (asrSettings.Exclusions.Count > 0)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YmBN35r3pmQQIwHruszpTxt6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aEBtnsmlhiE=")[iii % 8])).ToArray()));
                    foreach (var exclusion in asrSettings.Exclusions)
                    {
                        WriteLine($"    {exclusion}");
                    }
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string XTpqfhix)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                        instance.UnregisterTypeForComClients(53);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_E409597E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3z+4WFdQjeP3Nb1QVVmQ7sA1r01SUpO9qQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k1DbOTs89M4=")[iii % 8])).ToArray()));
            DisplayDefenderSettings(dto.LocalSettings);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gJAUBt5gEsjv/Hcv60sf/+/uaijgSEyW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ipoeQY4vP6w=")[iii % 8])).ToArray()));
            DisplayDefenderSettings(dto.GroupPolicySettings);
        }

        void DisplayDefenderSettings(WindowsDefenderSettings settings, string wADywhCD)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                        instance.UnregisterTypeForComClients(53);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var pathExclusions = settings.PathExclusions;
            var processExclusions = settings.ProcessExclusions;
            var extensionExclusions = settings.ExtensionExclusions;
            var asrSettings = settings.AsrSettings;
            if (pathExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2Lqpshte3gSX4uqOD1nfS7zpsw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0pqJ4noqtiQ=")[iii % 8])).ToArray()));
                foreach (var path in pathExclusions)
                {
                    WriteLine($"    {path}");
                }
            }

            if (pathExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SwZ5YD/r6pQ4azheMeDmhRFHLVgV/+CbNFUwXz70uQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QSZZMFCHg/c=")[iii % 8])).ToArray()));
                foreach (var path in pathExclusions)
                {
                    WriteLine($"    {path}");
                }
            }

            if (processExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XIg+sZzk84Ul2z6kluj8lSXBcY+d").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vqge4e6LkOA=")[iii % 8])).ToArray()));
                foreach (var process in processExclusions)
                {
                    WriteLine($"    {process}");
                }
            }

            if (extensionExclusions.Count != 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gceJcCMpOjD4jsZbexgnPeeS2lw0Myw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i+epNVtdX14=")[iii % 8])).ToArray()));
                foreach (var ext in extensionExclusions)
                {
                    WriteLine($"    {ext}");
                }
            }

            if (asrSettings.Enabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6Howkix9u+SJekOmKm+75Id6QrY8fLnzizV+8wp8tuKRYBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4loQ01gJ2oc=")[iii % 8])).ToArray()));
                WriteLine($"    {Encoding.UTF8.GetString(Convert.FromBase64String("qTDj1sI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+kSCoqcfObw=")[iii % 8])).ToArray()), -10} Rule\n");
                foreach (var rule in asrSettings.Rules)
                {
                    string state;
                    if (rule.State == 0)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("fiLmKh8UN+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OkuVS314Uo0=")[iii % 8])).ToArray());
                    else if (rule.State == 1)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("RMDWVCf17w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bqy5N0yQi3c=")[iii % 8])).ToArray());
                    else if (rule.State == 2)
                        state = Encoding.UTF8.GetString(Convert.FromBase64String("Oeqnabpwlw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eJ/DAM4V8yU=")[iii % 8])).ToArray());
                    else
                        state = $"{rule.State} - Unknown";
                    var asrRule = _AsrGuids.ContainsKey(rule.Rule.ToString()) ? _AsrGuids[rule.Rule.ToString()] : $"{rule.Rule} - Please report this";
                    WriteLine($"    {state, -10} {asrRule}");
                }

                if (asrSettings.Exclusions.Count > 0)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YmBN35r3pmQQIwHruszpTxt6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aEBtnsmlhiE=")[iii % 8])).ToArray()));
                    foreach (var exclusion in asrSettings.Exclusions)
                    {
                        WriteLine($"    {exclusion}");
                    }
                }
            }
        }
    }
}