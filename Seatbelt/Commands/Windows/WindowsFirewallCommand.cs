using System;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using Microsoft.Win32;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    enum FirewallAction
    {
        ALLOW = 0,
        BLOCK = 1
    }
internal class O_588A6512 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("50V/yvAXDVrZXnTZ/gwS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sCwRrp9gfhw=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("kN0XigKssPW60wvDUb646bvFGMsd+KPustcKi1H6/P2r3hWFUbyk9q7BWcYdtPGzv8Ae0hy9v++tkkSaUbm997HFVsMUtqi0qtEJiAS8obS33FbIBKz+/7HfGM4f96Hpt8QY0xT3oe683hDEWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3rJ5p3HY0Zs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_588A6512(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var directionArgs = new List<string>();
        var protocolsArgs = new List<string>();
        var actionArgs = new List<string>();
        var profileArgs = new List<string>();
        foreach (var arg in args)
        {
            if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("k9h67/8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8rQWgIi74b4=")[iii % 8])).ToArray())))
            {
                actionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("9jN9Ya4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t18RDtmJCvU=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("bi8Kew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CkpkAhyBpuA=")[iii % 8])).ToArray())) || arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("cDI+D7M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("El5RbNhbF7A=")[iii % 8])).ToArray())))
            {
                actionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("QBm81D0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AnXTt1as06E=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("sEeG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xCT2ECu/D3A=")[iii % 8])).ToArray())))
            {
                protocolsArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("7+Fl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u6I1kbc94yI=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("UfzM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JJi8k66Tlm0=")[iii % 8])).ToArray())))
            {
                protocolsArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("McYO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZIJeRE6RK2M=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("rgY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x2gdQX7raNw=")[iii % 8])).ToArray())))
            {
                directionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Tzs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BlW+tFT/37k=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("Dl9Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YSokVsaFR3k=")[iii % 8])).ToArray())))
            {
                directionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("kesb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3p5vG/qvQsw=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("NF/Z+63J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UDC0msSnJ+U=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("jcWbDEfA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yar2bS6uel0=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("YKjijSqdTQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ENqL+0vpKM0=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("8sO54qoeKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("orHQlMtqTN8=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("HgJNcUN0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bncvHSoXV9A=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Nh05r5Mv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zmhbw/pMzjE=")[iii % 8])).ToArray()));
            }
        }

        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("DdsWzGXewC0g01r3adPQKznHWuZpz9EzL9gWgE7S2mk9wBvOZNzGIG7mD8xlzr5O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TrR6oAC9tEQ=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("QmRI4R1oRwdvbATsFGcTOWhlQOIPeBMoaHlB+hlnX05TfkjoCwE5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AQskjXgLM24=")[iii % 8])).ToArray()));
        var protocols = new Dictionary<string, string>()
        {
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("PA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DKKSVEQKL/0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("B1Dxva83").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tx+h8v9jiuk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Sw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ep4syyfisF8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("S6iEtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AuvJ5+ux5c0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vjOQ24btayM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4doq1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qJ1nhr/G+zA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("rg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("neRjv6EjEao=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yG2O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jyrewvq1Ryo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("mw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r8mNRFLt6es=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NbxbUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOwtZlw6CnU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lp/UzLZYT6w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4ec=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("srO6w0M2RbQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SdoCjBs6k20=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kB7X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xF2HAc7cwXs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P3MymVGhJVw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kMT4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04as9/6M/e0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1d0gO8dyGeQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("bCoS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KW1C6zLmGZ4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6MfKZKZTN1E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("H64r").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vul7ySlAcPE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("bn0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X00euXPTQUs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("E29FBxn5UiUcYkU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("US0LKku6EQg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jA0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vTwGUd9vD1E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7rpSPRCS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oOwCEFnbIks=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("aN0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("We+pdZf8S1w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Zmgd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nj1Nd/HQuy8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e94=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Su1Xa5iCzKg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LBeiAL8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bUXlVex8fQM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("IO8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Edu+OBl6ppM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5ZsGdIo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oNZFO8Ry/gg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("cH8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QUoQzQ8jXCc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("a4vB2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M8WEj1EKyE8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/xI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ziToKV5gvqY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("tIhYNXU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("98AZeiZ8gwM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e1A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SmdQJ01jTZM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Kful").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fL/1iUJt8Eo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("rKE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZnGJW5QqE0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7Q43").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oFtvmtTP7eY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("QvI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c8t8c2QFauI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("irxjz0RpUxA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zv8t4gksEkM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("FcU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/WGSUAsJwo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VYpP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HccfyjE5g0o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("FcA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/F7zJDoz3Y=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("s8is").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("45rhEknfs6M=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("LII=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HrCBNjLF+Fk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("wR0Sy0Jq+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mVNB5gsuqNk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("dGU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RlZs2I1isPY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fdWZTiURjg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KYfMAG48vz0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("IgE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EDUijD0+kbY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ndYnlOOl1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yYRy2qiI5E8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("KpM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GKbQ4mc1eHc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9Gk25CTx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uCx3ognAq+Y=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("kqw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oJr8zZbDYEI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("npNF0lpX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0tYElHdlxbs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("dlk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RG6mgXlSuj8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IMeb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("coPLaAW5zHs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("I3w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUTUoQ5qGWM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5GN8eg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rTEoKjYPJx8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xLs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9oJKlHRnghQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GhO5xCDTcQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U0D26XSDRbo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("P3M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DEMy6CshJoM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("I4ZTJM0e").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bcMHZoFK3ak=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("JLM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F4LLTjodHQk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RujhuKea+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C66klenJqCo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("o4w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kL4XpgSNw5s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("UUj8NEzOkLtM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HA2ufRjj2fU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("S9o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eOlbEPRbNKk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("j9UZCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y5ZaWU3ZVWA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Jk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("461Xu8B+MLU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2Ral").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6kbmxXXURB0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Qd8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cuqg/AqPmpU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("l7VfFQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3vEPR5LR0iI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("O/0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CMvfG1rUAs8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("WzaH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A2LXzpRoV2c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0As=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4zwhXaKfXzs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("OveT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("frPD5/18hR0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("c4g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QLBMcrywNOk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7nlP4E52GJb3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pz0fsmM1VcI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eyIgWiDBPsw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ZE8u2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MB8F8ur802c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("swo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hzo7nHpk2lU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kNQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ZjwOPHH+YU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("aE0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XHw0jm45ri8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("a2P12w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IjOD7fN8PU4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R9o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c+iOMizPyQM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("XNOAtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D5fS5/AHJZA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("JBk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ECp6eSC/4Ho=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VONmGI04abFp1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HbMQLqBqBsQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xYU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8bF7PpN5nHk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("PvOYBkKtvJYQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d6PuMG/rzvc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("4x0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1yiHEegNxrg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("agGB3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I0XTj4/oPds=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("bBA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WCb+m//2r3M=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RDJsVA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FmE6BO4p/PU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("D0Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O3EZf/xNP+E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Y9gL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JIpOUH83eww=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jao=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uZLDxp4iZd8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("3YpV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mdkHw2BimQY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("TF4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eGeZGwvETbQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5rab").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pPjaUVkpMog=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("hu4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s97DrPx3Wd4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("BWuc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QDjMIPDY5CI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("B/A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MsG1ZEXtAS8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("KCU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aW1s07R6O10=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("q5U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nqfdwLZ38pI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("/tl7UBIb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t/Q1HEFL9qw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/X8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yEwZp0eNKk8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("SsdLTy8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GZACH2pIlE8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("+Tc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zAOBlFucb8E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hwm0+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yUjmqisvjjQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7Ao=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2T8gcjoqQFI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("dmx4OWCx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OyM6cCz0yV8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("OxU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DiPLKhoWjes=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Bosdpw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UsdO90LKQ88=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("st0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h+p+yFIWZNE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("K9AnOw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eJtuaxgH/ME=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SrU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f40Lxd6MxpQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Gd0/Iceo90MA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UI1JF+rhtA4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9ls=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w2JQM8YvuBs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("SfAkqHD6GR541A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKBSnl20dlA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("8ts=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xOt/gLcwRdI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("MbtrfaaAUBwL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eOsdS4vPIGg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Aw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NT7g0nPp8qM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Q9va7qrhx3s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IrWjzsKOtA8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Epk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JKszQWwKrCU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("C/mhXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SL/1DfpA03o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1rQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4Id3rW4QFEs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Ee+eT/UPEQYc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cIHnb5lgcmc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("wrU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9IGnOjzP198=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7u8tNTiENnb2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("va55GH3cZjc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("yYE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/7Q9FAiO5n4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("X3wR/ydZ/7Va").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FC5Ir3MWs/Q=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9xY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wSCJ7hZzmwk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("J/0m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("datiN7ddjW4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("MHs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BkyEG3vc05c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("qxUwWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4kVgGnvJgww=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("z1k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+WF8Gs4FIGo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("K4vgHjxeKh44jPtLLFI9SiyM9Vt4RCAZPoD0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SuWZPlg3WWo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Amk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NFAMzrqA+Ks=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("uQ6HmxFEqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6k/TtlwL5RE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("yKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/5ou3OcL8a0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("53o/8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sTNsssYsFqo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("vOM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i9IsIJoReLo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("qfEqEA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4KFpRsG1Mgk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("DuM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OdFy2FXnmKA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ktKQcw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0YLeK3qux3U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("zFI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+2FFouLUO6k=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("X7rkqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HOqs6ciRDzk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("wBU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9yE4XkHqQKU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LTDh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("emOvoUo1iwE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8COa4YXJnLE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YSYU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MXBELduVjVM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("htY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("seBRe6hm0K8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("S0DYJrbQJH9GXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRL1dfeECTI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("iI8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v7ij7i7/Ugo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yEoNGXbF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mx9DNDiBiaM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("+rw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zYTsi4HTOCw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("XeLjX8F1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CqDOEo47VW0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N6aiERKPUGY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("QjIz7clThmk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FXAeqJEDxyI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("y3I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("80IjR7aw3PI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("TIBe0cn9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BdMR/ICt1sU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("vPc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hMbQU49Ol6g=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("t6WDUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4ejXA+rZ1ms=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7N4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1OxT/b055Z0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ik0YazyotiSUXAs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2QhbPm7tm3I=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("w8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+/Zd2QOeoTw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("BzPCl6s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UXqM0vgtj34=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("66o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("057OCmjCeP0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yOv6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nL+qWAsFJ5s=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ll8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FmpA3Y1w6Qc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("36JUDl3at4LWoQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kfESQBiOmss=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("XKI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZJSSpaWvqoU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ksBw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1ocg/EVBF2g=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Oig=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ah8KNO5SXJg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("vW1k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6S4iHWrjknQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBL1FWyQU8A=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("wLQw5B8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hf13tk+36Hw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("gDM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uArAkkd8h1w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LO0IVLov4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y75YEvNos+U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Pdo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BOoI1FC68k8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("oTUz1uxy9JyiBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8kVBv5gX2c4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("z3c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9kbPGIBGJMM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("g+Pl3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z6K3jyyfCe4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AnM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O0EGk3KSmM4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kuZI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("37IYTyKEelA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Q8g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evspv7406S4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("FE0rzYE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VRUF/7T0dnE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ZaU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XJF8BdcCWmQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IU1w5A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aB05tBiOAJE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("s5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iqmmATACFnQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("af7udg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JLetJsaWZVI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Trc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d4HOLU/1+1c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("05Sfwrv0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gNfc7+ikJdA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Brc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4DLcdy5/sc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("R7zgPDnTmA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AuioeWuayCQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Zfc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XM9gd9JIoaM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Q+bOmfg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BqiN2Kid9aI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Pns=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0LChHw7fPw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YsWQKMw1k6Fi34wo2SmZpXrbnWHTKdqkYMOMZdk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A6vpCLxH+tc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AxtG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mit277N1n9s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("rtpPIQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6ZcbcTMlb64=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("m65K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qp57CJecj28=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("WgZ4KQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0A1efuQ2pI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e95G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Su50LZ2HPc0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("D/T0kg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X7q6266Orfc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Qryq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c4yZ3ZoVsfk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hmpM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1iMB5x/RSvQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CJVM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OaV4sMXKb88=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9oDQBQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t9KZVvQJYec=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("nIgg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rbgVtZHGoUQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NFTmLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zxe2fYG7iN0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Q4UY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("crUuNiYOKfg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2dZB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iJgZivlbqLg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1lV9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("52VKSrSEb50=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9fqD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tNXNF20MNWs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("sTYm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gAYeoB+hdCU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fl0AGjil").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nw1DdVXVkOY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("3Agt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7TgUvihvQ68=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ggWd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0UvNs33OeF4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1K/5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5Z7J1iP/yEo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("sQ2lia8KEfKXB7o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8mLI+c57PKI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("8lLT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w2PiMS4vmek=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ic3YYCs9YayQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wJ2ATUJTTOU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R8+i").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dv6QETR42yI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("JlAwTQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cAJiHZRHZ2I=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("igpH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uzt0oKhKedY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4rc5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("svB0+dCYRlI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("lh3Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pyzkP+aqQ1s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("89+SsKA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w/L639BNWck=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Uio").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4HmdSF+Ujhk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("lbRCiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2YYW2NGPwqA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Yhbg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyfW74IMFs0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GVpS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XR4KgSTDT60=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("QNSA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ceW3QQFBHRw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GUtHYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UAoTMUes96Q=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("k/9x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("os5JzqUyHIU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Ki4u").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eXp+aTKT+Xg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7+C/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3tGG5r2g8Sg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("1Bu3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h0nn8mg9bdw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("zAJ/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/TBPTU3cEGc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("MQlB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZF0IrCgse0k=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CFnN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OWv8SMhGfyc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("nQ1f").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zkAPjzP3uXA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ZGoV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VVgnKKdYyl8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Jh0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dVBtlCm07OU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oaqj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kJiQzjZ9h2c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("73qA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vy7QJl3RtlU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("PPZT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DcRnROHvFBg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("tzZfEw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/mUWQKnOqnU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("srHe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g4PrX5uXJI8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("KtU4sg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bJxq9z3oJog=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1rlI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("54t+FcSLdmc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("AgvBKw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QVmVe2Hgjok=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("BGmg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NVuXaXx5du8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("3Je6P1U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8XvewV3Q9k=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oQ+o").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kD2Q84vvUKk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("vxGsCN415Wg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ELvR454pi0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7HIE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3UA9VMkY0WY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IUbVzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aBaZmUkygRA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("O1it").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Cmudp2l3gmY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("uvDQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6aCDNu92WQY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ij7H").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ew32G14cFjs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("scpQKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4YMAb3teO/4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oCey").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kRSAvGlv9Wk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ioTicQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ce2IaJDf0U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("RVAo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dGMbcfstac0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("N2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cSrjyH+6xck=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ysan").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U/WTzd2zxnQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5lymp0TBgQqZRre5Jtb2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tA/w92mEs08=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("I6lO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Epp7AVFlnLY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("n4z26kLwYQU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0uOUgy6ZFXw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R4kC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dro0yIrsQEY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("HCzO09WPGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SWien7z7f3o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Vo8M").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z7w7MtbE7AU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RBz6SRiAx39AHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CUy2GjXpqVI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("LLhU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HYtsYbbGgM4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("C3oGxeE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZhtooJVQ1HA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/auy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zJiLbKSs8fU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("v7bU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9/+ETVZ6B7U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Bq0R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N5khq1cU3fY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("riILMHI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UpiXUSgPkA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("E5N2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IqdH2foPwZw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fL4vWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K/t8Cx3XHb4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("lGff").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pVPtY4otrrA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YWIVDQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("My1dTja44EE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9Qu+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xD+Nr/u0Iy0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("+/rAHZwtluTL8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rpShbu9E8Yo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("eirH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SB/0mAtASQk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("axnX4Vz3lUZAFcbwR/GW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LmGnhC6e+CM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SLM9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eoYJcgt+0a4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("zqvhp3uudNDlp/C2YKh3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i9ORwgnHGbU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("GUrj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K3/W9CMq6SA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("DMlHWQuQDbE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xqw0PHnmaNU=")[iii % 8])).ToArray())
            }
        };
        string[] ruleLocations =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("alKrd2oFJ5xlTYJPVCccvEpBoEpeNhqqVnuZf2otG71Wap5lVDYQrlhxgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OR3tIz1Eddk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("FnAGNT5eSVEwWycEFWdWfStdJw4XQHBmGXowEw16dnc2dQYJGmFwdgRKNgQIYElCJFs0DB5ncGA2dRMICXZicylFBQ4XenZr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RSlVYXsTFRI=")[iii % 8])).ToArray())
        };
        foreach (var ruleLocation in ruleLocations)
        {
            var FirewallRules = ThisRunTime.GetValues(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("2nhMowomZyvWKV2THjp5K9I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oUgx/0xPFU4=")[iii % 8])).ToArray()), ruleLocation));
            if (FirewallRules != null)
            {
                var output = new O_CA646800(ruleLocation);
                var DomainProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("5AWdjHpFFLr2W7CiUUwQt/o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nzXg0D4qeds=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("E3U/A1uXPLAkfikAW54=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VhteYTfyetk=")[iii % 8])).ToArray()));
                if (DomainProfileEnabled != null)
                {
                    output.Domain.Present = true;
                    var DomainProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("/Y8Xa5tBgnzv0TpFsEiGceM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hr9qN98u7x0=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("IlPROggr5mMIVNguEyPTSRJf2DU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zja3W31Hkio=")[iii % 8])).ToArray()));
                    var DomainProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("p6Xlyk2ES0G1+8jkZo1PTLk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3JWYlgnrJiA=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("tDk0ItnJGt6FKDAs2csK0JMoOyzC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8FxSQ6ylbpE=")[iii % 8])).ToArray()));
                    var DomainProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("u7KFGDQuI+Wp7Kg2Hycn6KU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wIL4RHBBToQ=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("IuHestQiu0oJ/MS13y2/cA/nw6A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zoit07ZO3gQ=")[iii % 8])).ToArray()));
                    output.Domain.Enabled = DomainProfileEnabled == 1;
                    if (DomainProfileEnabled != null)
                    {
                        if (DomainProfileDisableNotifications != null)
                        {
                            output.Domain.DisableNotifications = DomainProfileDisableNotifications == 1;
                        }

                        if (DomainProfileInboundAction != null)
                        {
                            output.Domain.DefaultInboundAction = (FirewallAction)DomainProfileInboundAction;
                        }

                        if (DomainProfileOutboundAction != null)
                        {
                            output.Domain.DefaultOutboundAction = (FirewallAction)DomainProfileOutboundAction;
                        }
                    }
                }

                var PublicProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("EFxEYyato0QCD2lNGb6oRA4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a2w5P3bYwSg=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("+zSfiin8JNPMP4mJKfU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vlr+6EWZYro=")[iii % 8])).ToArray()));
                if (PublicProfileEnabled != null)
                {
                    output.Public.Present = true;
                    var PublicProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("UmQc4cv7ahdANzHP9OhhF0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KVRhvZuOCHs=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("pQTzojEOVauPA/q2KgZggZUI+q0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4WGVw0RiIeI=")[iii % 8])).ToArray()));
                    var PublicProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("sbeoc5Bf6faj5IVdr0zi9q8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yofVL8Aqi5o=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("75K8jlhiFUHeg7iAWGAFT8iDs4BD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q/fa7y0OYQ4=")[iii % 8])).ToArray()));
                    var PublicProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("dodJdGxYm31k1GRaU0uQfWg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dbc0KDwt+RE=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("6Uq4rDQDZ+7CV6KrPwxj1MRMpb4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rSPLzVZvAqA=")[iii % 8])).ToArray()));
                    output.Public.Enabled = PublicProfileEnabled == 1;
                    if (PublicProfileDisableNotifications != null)
                    {
                        output.Public.DisableNotifications = PublicProfileDisableNotifications == 1;
                    }

                    if (PublicProfileInboundAction != null)
                    {
                        output.Public.DefaultInboundAction = (FirewallAction)PublicProfileInboundAction;
                    }

                    if (PublicProfileOutboundAction != null)
                    {
                        output.Public.DefaultOutboundAction = (FirewallAction)PublicProfileOutboundAction;
                    }
                }

                var PrivateProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("xeT5hM+T4VDfoOGI7Y7uT9Kx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vtSE2J/hiCY=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Qo3ENUNFGSV1htI2Q0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B+OlVy8gX0w=")[iii % 8])).ToArray()));
                if (PrivateProfileEnabled != null)
                {
                    output.Private.Present = true;
                    var PrivateProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JFuuooBWxg0+H7auokvJEjMO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X2vT/tAkr3s=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Wvg2UeuwtYZw/z9F8LiArGr0P14=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hp1QMJ7cwc8=")[iii % 8])).ToArray()));
                    var PrivateProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("G1kKG1JkWQgBHRIXcHlWFwwM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YGl3RwIWMH4=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Sf+GpGEsX0147oKqYS5PQ27uiap6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZrgxRRAKwI=")[iii % 8])).ToArray()));
                    var PrivateProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("A2cgqF5ekE4ZIzikfEOfURQy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eFdd9A4s+Tg=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("bCzuwKYPrahHMfTHrQCpkkEq89I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KEWdocRjyOY=")[iii % 8])).ToArray()));
                    output.Private.Enabled = PrivateProfileEnabled == 1;
                    if (PrivateProfileDisableNotifications != null)
                    {
                        output.Private.DisableNotifications = PrivateProfileDisableNotifications == 1;
                    }

                    if (PrivateProfileInboundAction != null)
                    {
                        output.Private.DefaultInboundAction = (FirewallAction)PrivateProfileInboundAction;
                    }

                    if (PrivateProfileOutboundAction != null)
                    {
                        output.Private.DefaultOutboundAction = (FirewallAction)PrivateProfileOutboundAction;
                    }
                }

                var StandardProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("6Re8ztz6vLj2RrP23/yysPtLpA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kifBko+O3dY=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("s/nEHiWceoKE8tIdJZU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9pelfEn5POs=")[iii % 8])).ToArray()));
                if (StandardProfileEnabled != null)
                {
                    output.Standard.Present = true;
                    var StandardProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("RJ+L9FaNp81bzoTMVYupxVbDkw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P6/2qAX5xqM=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Nl0HedUJ2focWg5tzgHs0AZRDnY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjhhGKBlrbM=")[iii % 8])).ToArray()));
                    var StandardProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("ChIEUppdVBMVQwtqmVtaGxhOHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cSJ5DskpNX0=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("k08JCMJx4s+iXg0GwnPywbReBgbZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1ypvabcdloA=")[iii % 8])).ToArray()));
                    var StandardProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("frUWUCZPS8Jh5BloJUlFymzpDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BYVrDHU7Kqw=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("uqCgtdD/59qRvbqy2/Dj4Jemvac=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/snT1LKTgpQ=")[iii % 8])).ToArray()));
                    output.Standard.Enabled = StandardProfileEnabled == 1;
                    if (StandardProfileDisableNotifications != null)
                    {
                        output.Standard.DisableNotifications = StandardProfileDisableNotifications == 1;
                    }

                    if (StandardProfileInboundAction != null)
                    {
                        output.Standard.DefaultInboundAction = (FirewallAction)StandardProfileInboundAction;
                    }

                    if (StandardProfileOutboundAction != null)
                    {
                        output.Standard.DefaultOutboundAction = (FirewallAction)StandardProfileOutboundAction;
                    }
                }

                foreach (var kvp in FirewallRules)
                {
                    var rule = new O_72452439();
                    var props = ((string)kvp.Value).Split('|');
                    foreach (var prop in props)
                    {
                        var onv = prop.Split('=');
                        if (onv.Length == 1)
                        {
                            continue;
                        }

                        string key = onv[0], value = onv[1];
                        switch (onv[0])
                        {
                            case "Action":
                                rule.Action = value;
                                break;
                            case "Active":
                                break;
                            case "Dir":
                                rule.Direction = value;
                                break;
                            case "Protocol":
                                rule.Protocol = protocols[value];
                                break;
                            case "Name":
                                rule.Name = value;
                                break;
                            case "Desc":
                                rule.Description = value;
                                break;
                            case "App":
                                rule.ApplicationName = value;
                                break;
                            case "Profile":
                                rule.Profiles = value;
                                break;
                            case "RPort":
                                rule.RemotePorts = value;
                                break;
                            case "LPort":
                                rule.LocalPorts = value;
                                break;
                            case "RA4":
                                rule.RemoteAddresses = value;
                                break;
                            case "LA4":
                                rule.LocalAddresses = value;
                                break;
                        }
                    }

                    if (!Runtime.FilterResults || ((((actionArgs.Count == 0 && protocolsArgs.Count == 0 && directionArgs.Count == 0 && profileArgs.Count == 0) && !rule.Name.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+LqsCqR+zUM=")[iii % 8])).ToArray())) && !rule.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("tr6WVQ2r8zmVo4cZIPvKO4y1kk0I5NQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5dbzOWGLulc=")[iii % 8])).ToArray())) && rule.Action.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("atzodcw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KLCHFqdd+U8=")[iii % 8])).ToArray())))) || ((actionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("HQ9UEBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XGM4f20Quh8=")[iii % 8])).ToArray())) && (rule.Action == Encoding.UTF8.GetString(Convert.FromBase64String("0zRb7sc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("klg3gbAT6b4=")[iii % 8])).ToArray()))) || (actionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("AL1IDm0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QtEnbQZFNtQ=")[iii % 8])).ToArray())) && (rule.Action == Encoding.UTF8.GetString(Convert.FromBase64String("ULhjufc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EtQM2pyJ+WY=")[iii % 8])).ToArray()))) || (protocolsArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("TuQx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gqdh/bizbb8=")[iii % 8])).ToArray())) && (rule.Protocol == Encoding.UTF8.GetString(Convert.FromBase64String("BqSU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UufEMIdmETE=")[iii % 8])).ToArray()))) || (protocolsArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("aHG9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PTXtsvqW31g=")[iii % 8])).ToArray())) && (rule.Protocol == Encoding.UTF8.GetString(Convert.FromBase64String("7TIr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uHZ7sT9FUj4=")[iii % 8])).ToArray()))) || (directionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("hqc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z8lPRmcsKHA=")[iii % 8])).ToArray())) && (rule.Direction == Encoding.UTF8.GetString(Convert.FromBase64String("kEs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2SVRrdoj++o=")[iii % 8])).ToArray()))) || (directionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("ts1a").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+bgufHzLjEA=")[iii % 8])).ToArray())) && (rule.Direction == Encoding.UTF8.GetString(Convert.FromBase64String("HswU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UblgHWnCTYU=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("9dQXgtiX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sbt647H5seY=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("pV81fijm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4TBYH0GIxIM=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("coNDxTT1Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IvEqs1WBZ7A=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("a9Ofg9gUPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O6H29blgWvg=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("jS95df9l").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3VobGZYG410=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("w+uxjouo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k57T4uLLgSw=")[iii % 8])).ToArray()))))))
                    {
                        output.Rules.Add(rule);
                    }
                }

                yield return output;
            }
        }
    }

    internal class WindowsFirewallProfileSettings
    {
        public bool Present { get; set; }
        public bool Enabled { get; set; }
        public FirewallAction DefaultInboundAction { get; set; }
        public FirewallAction DefaultOutboundAction { get; set; }
        public bool DisableNotifications { get; set; }
    }

    internal class O_72452439
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ApplicationName { get; set; } = string.Empty;
        public string Protocol { get; set; } = string.Empty;
        public string Action { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;
        public string Profiles { get; set; } = string.Empty;
        public string LocalAddresses { get; set; } = string.Empty;
        public string LocalPorts { get; set; } = string.Empty;
        public string RemoteAddresses { get; set; } = string.Empty;
        public string RemotePorts { get; set; } = string.Empty;
    }

internal class O_CA646800 : O_4AED570F
{
    public O_CA646800(string location)
    {
        Domain = new WindowsFirewallProfileSettings();
        Private = new WindowsFirewallProfileSettings();
        Public = new WindowsFirewallProfileSettings();
        Standard = new WindowsFirewallProfileSettings();
        Rules = new List<O_72452439>();
        Location = location;
    }

    public String Location { get; set; }
    public WindowsFirewallProfileSettings Domain { get; set; }
    public WindowsFirewallProfileSettings Private { get; set; }
    public WindowsFirewallProfileSettings Public { get; set; }
    public WindowsFirewallProfileSettings Standard { get; set; }
    public List<O_72452439> Rules { get; set; }
}    [CommandOutputType(typeof(O_CA646800))]
    internal class O_3ABDBA24 : TextFormatterBase
    {
        public O_3ABDBA24(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_CA646800)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pfM3r0IfB2DJvHTuFlZILsm8dO4WVkguybx07hZMSHXZ4V4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6ZxUzjZ2aA4=")[iii % 8])).ToArray()), dto.Location);
            if (dto.Domain.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1BLweUEfLzXiEvtxRBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kH2dGChxD2U=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AYJ4RRFRAcNNxzxFdB9AgQGCeEV0H0CBAYJ4RXQFQNoR3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IaJYZVQ/YKE=")[iii % 8])).ToArray()), dto.Domain.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zAHHmdreNKCOTYL38cMup4VChs332CmyzAHHmb6NZ7rcXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7CHnuZ63R8E=")[iii % 8])).ToArray()), dto.Domain.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fyKm5UjIS6MqbvKMYs9CtzFmx6Z4xEKsfyKm5SyXDblvfw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XwKGxQytLcI=")[iii % 8])).ToArray()), dto.Domain.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UVRKAdZ+y8UEGB5u52/PywQaDmDxb8TLH1RKAbIhjd9BCWA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cXRqIZIbraQ=")[iii % 8])).ToArray()), dto.Domain.DefaultOutboundAction);
            }

            if (dto.Private.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8vN/IuTekA7y83ky7MaQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ooEWVIWq9S4=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("o2dozxpxh1TvIizPfz/GFqNnaM9/P8YWo2doz38lxk2zOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g0dI718f5jY=")[iii % 8])).ToArray()), dto.Private.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VUT1bMk+WSYXCLAC4iNDIRwHtDjkOEQ0VUT1bK1tCjxFGQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dWTVTI1XKkc=")[iii % 8])).ToArray()), dto.Private.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Q6nh9WDefqAW5bWcStl3tA3tgLZQ0nevQ6nh9QSBOLpT9A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y4nB1SS7GME=")[iii % 8])).ToArray()), dto.Private.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8yYW9Dao/JumakKbB7n4laZoUpURufOVvSYW9FL3uoHjezw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0wY21HLNmvo=")[iii % 8])).ToArray()), dto.Private.DefaultOutboundAction);
            }

            if (dto.Public.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CFbEFn/XhKoqTMATetE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WCOmeha0pPo=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2oFPAdUo4Y6WxAsBsGagzNqBTwGwZqDM2oFPAbB8oJfK3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+qFvIZBGgOw=")[iii % 8])).ToArray()), dto.Public.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KancfnwCOv9r5ZkQVx8g+GDqnSpRBCftKancfhhRaeU59A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CYn8XjhrSZ4=")[iii % 8])).ToArray()), dto.Public.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Xlf1C6qQ2yENQu9BK1KeJ89Ppcepkpj0Xlf1Er1BXbBJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8Vl/9GrPJQ0=")[iii % 8])).ToArray()), dto.Public.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xv3Qs0WqBXGTsYTcdLsBf5OzlNJiuwp/iP3QsyH1Q2vWoPo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5t3wkwHPYxA=")[iii % 8])).ToArray()), dto.Public.DefaultOutboundAction);
            }

            if (dto.Standard.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("h6eUkEGg2Wj0g4eRQ6jHaQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1NP1/iXBqww=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xz5Mj1ivKuOLewiPPeFrocc+TI894Wuhxz5Mjz37a/rXYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5x5srx3BS4E=")[iii % 8])).ToArray()), dto.Standard.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JEVlYgf61A9mCSAMLOfOCG0GJDYq/MkdJEVlYmOphxU0GA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BGVFQkOTp24=")[iii % 8])).ToArray()), dto.Standard.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("arodLFFRxw8/9klFe1bOGyT+fG9hXc4AarodLDUOgRV65w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Spo9DBU0oW4=")[iii % 8])).ToArray()), dto.Standard.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IIhr+hmeYlx1xD+VKI9mUnXGL5s+j21Sbohr+n3BJEYw1UE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKhL2l37BD0=")[iii % 8])).ToArray()), dto.Standard.DefaultOutboundAction);
            }

            if (dto.Rules.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BWRYr000Ew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VxE0yj4OGUw=")[iii % 8])).ToArray()));
                foreach (var rule in dto.Rules)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("lwdRniu0QoaXBz/fZvFChpcHP99m8UKcl1wvgg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tycf/0bRYqY=")[iii % 8])).ToArray()), rule.Name);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uhkwqe3Eu5/qTR2j8Ifp1roZVOy+h+nMukJEsQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mjl0zJ6nyfY=")[iii % 8])).ToArray()), rule.Description);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8BSsTVKu8/KxQIRSTIz7/LUUzR0C4rqr8E/dQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0DTtPSLCmpE=")[iii % 8])).ToArray()), rule.ApplicationName);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b6PLO/YPKAwg77tpuVtnT2+ju2m5W2dVb/irNA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T4ObSZl7R28=")[iii % 8])).ToArray()), rule.Protocol);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qIYjQ3QRu2SohkIAIFj0KqiGQgAgWPQwqN1SXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKZiIAB41Ao=")[iii % 8])).ToArray()), rule.Action);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("L0JVu1b7wR9mDX/yBL6CSy9CMfIEvoJRLxkhrw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D2IR0iSeoms=")[iii % 8])).ToArray()), rule.Direction);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+Y62nbHmzZ683cbP/qCE0vmOxs/+oITI+dXWkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2a7m796ApPI=")[iii % 8])).ToArray()), rule.Profiles);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XdttQD3/U/Q8n0VdZM5QpgnbAQ9+vh/uXYARUmTlDqk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ffshL16eP9Q=")[iii % 8])).ToArray()), rule.LocalAddresses, rule.LocalPorts);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BnFNRR06y1cGEHtEAm/vXVQlPwBQdZ8IBiovXUoujk8s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JlEfIHBVvzI=")[iii % 8])).ToArray()), rule.RemoteAddresses, rule.RemotePorts);
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string GMYLMvDi)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.StringBuilder instance = new System.Text.StringBuilder();
                        instance.Insert(92, true);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_CA646800)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pfM3r0IfB2DJvHTuFlZILsm8dO4WVkguybx07hZMSHXZ4V4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6ZxUzjZ2aA4=")[iii % 8])).ToArray()), dto.Location);
            if (dto.Domain.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1BLweUEfLzXiEvtxRBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kH2dGChxD2U=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AYJ4RRFRAcNNxzxFdB9AgQGCeEV0H0CBAYJ4RXQFQNoR3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IaJYZVQ/YKE=")[iii % 8])).ToArray()), dto.Domain.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zAHHmdreNKCOTYL38cMup4VChs332CmyzAHHmb6NZ7rcXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7CHnuZ63R8E=")[iii % 8])).ToArray()), dto.Domain.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fyKm5UjIS6MqbvKMYs9CtzFmx6Z4xEKsfyKm5SyXDblvfw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XwKGxQytLcI=")[iii % 8])).ToArray()), dto.Domain.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UVRKAdZ+y8UEGB5u52/PywQaDmDxb8TLH1RKAbIhjd9BCWA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cXRqIZIbraQ=")[iii % 8])).ToArray()), dto.Domain.DefaultOutboundAction);
            }

            if (dto.Private.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8vN/IuTekA7y83ky7MaQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ooEWVIWq9S4=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("o2dozxpxh1TvIizPfz/GFqNnaM9/P8YWo2doz38lxk2zOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g0dI718f5jY=")[iii % 8])).ToArray()), dto.Private.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VUT1bMk+WSYXCLAC4iNDIRwHtDjkOEQ0VUT1bK1tCjxFGQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dWTVTI1XKkc=")[iii % 8])).ToArray()), dto.Private.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Q6nh9WDefqAW5bWcStl3tA3tgLZQ0nevQ6nh9QSBOLpT9A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y4nB1SS7GME=")[iii % 8])).ToArray()), dto.Private.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8yYW9Dao/JumakKbB7n4laZoUpURufOVvSYW9FL3uoHjezw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0wY21HLNmvo=")[iii % 8])).ToArray()), dto.Private.DefaultOutboundAction);
            }

            if (dto.Public.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CFbEFn/XhKoqTMATetE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WCOmeha0pPo=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2oFPAdUo4Y6WxAsBsGagzNqBTwGwZqDM2oFPAbB8oJfK3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+qFvIZBGgOw=")[iii % 8])).ToArray()), dto.Public.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KancfnwCOv9r5ZkQVx8g+GDqnSpRBCftKancfhhRaeU59A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CYn8XjhrSZ4=")[iii % 8])).ToArray()), dto.Public.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Xlf1C6qQ2yENQu9BK1KeJ89Ppcepkpj0Xlf1Er1BXbBJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8Vl/9GrPJQ0=")[iii % 8])).ToArray()), dto.Public.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xv3Qs0WqBXGTsYTcdLsBf5OzlNJiuwp/iP3QsyH1Q2vWoPo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5t3wkwHPYxA=")[iii % 8])).ToArray()), dto.Public.DefaultOutboundAction);
            }

            if (dto.Standard.Present)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("h6eUkEGg2Wj0g4eRQ6jHaQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1NP1/iXBqww=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xz5Mj1ivKuOLewiPPeFrocc+TI894Wuhxz5Mjz37a/rXYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5x5srx3BS4E=")[iii % 8])).ToArray()), dto.Standard.Enabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JEVlYgf61A9mCSAMLOfOCG0GJDYq/MkdJEVlYmOphxU0GA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BGVFQkOTp24=")[iii % 8])).ToArray()), dto.Standard.DisableNotifications);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("arodLFFRxw8/9klFe1bOGyT+fG9hXc4AarodLDUOgRV65w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Spo9DBU0oW4=")[iii % 8])).ToArray()), dto.Standard.DefaultInboundAction);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IIhr+hmeYlx1xD+VKI9mUnXGL5s+j21Sbohr+n3BJEYw1UE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKhL2l37BD0=")[iii % 8])).ToArray()), dto.Standard.DefaultOutboundAction);
            }

            if (dto.Rules.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BWRYr000Ew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VxE0yj4OGUw=")[iii % 8])).ToArray()));
                foreach (var rule in dto.Rules)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("lwdRniu0QoaXBz/fZvFChpcHP99m8UKcl1wvgg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tycf/0bRYqY=")[iii % 8])).ToArray()), rule.Name);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uhkwqe3Eu5/qTR2j8Ifp1roZVOy+h+nMukJEsQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mjl0zJ6nyfY=")[iii % 8])).ToArray()), rule.Description);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8BSsTVKu8/KxQIRSTIz7/LUUzR0C4rqr8E/dQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0DTtPSLCmpE=")[iii % 8])).ToArray()), rule.ApplicationName);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b6PLO/YPKAwg77tpuVtnT2+ju2m5W2dVb/irNA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T4ObSZl7R28=")[iii % 8])).ToArray()), rule.Protocol);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qIYjQ3QRu2SohkIAIFj0KqiGQgAgWPQwqN1SXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKZiIAB41Ao=")[iii % 8])).ToArray()), rule.Action);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("L0JVu1b7wR9mDX/yBL6CSy9CMfIEvoJRLxkhrw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D2IR0iSeoms=")[iii % 8])).ToArray()), rule.Direction);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+Y62nbHmzZ683cbP/qCE0vmOxs/+oITI+dXWkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2a7m796ApPI=")[iii % 8])).ToArray()), rule.Profiles);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XdttQD3/U/Q8n0VdZM5QpgnbAQ9+vh/uXYARUmTlDqk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ffshL16eP9Q=")[iii % 8])).ToArray()), rule.LocalAddresses, rule.LocalPorts);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BnFNRR06y1cGEHtEAm/vXVQlPwBQdZ8IBiovXUoujk8s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JlEfIHBVvzI=")[iii % 8])).ToArray()), rule.RemoteAddresses, rule.RemotePorts);
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string wljsjYaU)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.StringBuilder instance = new System.Text.StringBuilder();
                    instance.Insert(92, true);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var directionArgs = new List<string>();
        var protocolsArgs = new List<string>();
        var actionArgs = new List<string>();
        var profileArgs = new List<string>();
        foreach (var arg in args)
        {
            if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("k9h67/8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8rQWgIi74b4=")[iii % 8])).ToArray())))
            {
                actionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("9jN9Ya4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t18RDtmJCvU=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("bi8Kew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CkpkAhyBpuA=")[iii % 8])).ToArray())) || arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("cDI+D7M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("El5RbNhbF7A=")[iii % 8])).ToArray())))
            {
                actionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("QBm81D0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AnXTt1as06E=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("sEeG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xCT2ECu/D3A=")[iii % 8])).ToArray())))
            {
                protocolsArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("7+Fl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u6I1kbc94yI=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("UfzM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JJi8k66Tlm0=")[iii % 8])).ToArray())))
            {
                protocolsArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("McYO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZIJeRE6RK2M=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("rgY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x2gdQX7raNw=")[iii % 8])).ToArray())))
            {
                directionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Tzs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BlW+tFT/37k=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("Dl9Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YSokVsaFR3k=")[iii % 8])).ToArray())))
            {
                directionArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("kesb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3p5vG/qvQsw=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("NF/Z+63J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UDC0msSnJ+U=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("jcWbDEfA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yar2bS6uel0=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("YKjijSqdTQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ENqL+0vpKM0=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("8sO54qoeKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("orHQlMtqTN8=")[iii % 8])).ToArray()));
            }
            else if (arg.ToLower().Equals(Encoding.UTF8.GetString(Convert.FromBase64String("HgJNcUN0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bncvHSoXV9A=")[iii % 8])).ToArray())))
            {
                profileArgs.Add(Encoding.UTF8.GetString(Convert.FromBase64String("Nh05r5Mv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zmhbw/pMzjE=")[iii % 8])).ToArray()));
            }
        }

        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("DdsWzGXewC0g01r3adPQKznHWuZpz9EzL9gWgE7S2mk9wBvOZNzGIG7mD8xlzr5O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TrR6oAC9tEQ=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("QmRI4R1oRwdvbATsFGcTOWhlQOIPeBMoaHlB+hlnX05TfkjoCwE5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AQskjXgLM24=")[iii % 8])).ToArray()));
        var protocols = new Dictionary<string, string>()
        {
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("PA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DKKSVEQKL/0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("B1Dxva83").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tx+h8v9jiuk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Sw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ep4syyfisF8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("S6iEtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AuvJ5+ux5c0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vjOQ24btayM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4doq1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qJ1nhr/G+zA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("rg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("neRjv6EjEao=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yG2O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jyrewvq1Ryo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("mw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r8mNRFLt6es=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NbxbUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOwtZlw6CnU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lp/UzLZYT6w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4ec=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("srO6w0M2RbQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SdoCjBs6k20=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kB7X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xF2HAc7cwXs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P3MymVGhJVw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kMT4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04as9/6M/e0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1d0gO8dyGeQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("bCoS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KW1C6zLmGZ4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6MfKZKZTN1E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("H64r").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Vul7ySlAcPE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("bn0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X00euXPTQUs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("E29FBxn5UiUcYkU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("US0LKku6EQg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jA0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vTwGUd9vD1E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7rpSPRCS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oOwCEFnbIks=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("aN0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("We+pdZf8S1w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Zmgd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nj1Nd/HQuy8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e94=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Su1Xa5iCzKg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LBeiAL8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bUXlVex8fQM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("IO8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Edu+OBl6ppM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5ZsGdIo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oNZFO8Ry/gg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("cH8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QUoQzQ8jXCc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("a4vB2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M8WEj1EKyE8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/xI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ziToKV5gvqY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("tIhYNXU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("98AZeiZ8gwM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e1A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SmdQJ01jTZM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Kful").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fL/1iUJt8Eo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("rKE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZnGJW5QqE0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7Q43").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oFtvmtTP7eY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("QvI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c8t8c2QFauI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("irxjz0RpUxA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zv8t4gksEkM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("FcU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/WGSUAsJwo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VYpP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HccfyjE5g0o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("FcA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J/F7zJDoz3Y=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("s8is").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("45rhEknfs6M=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("LII=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HrCBNjLF+Fk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("wR0Sy0Jq+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mVNB5gsuqNk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("dGU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RlZs2I1isPY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fdWZTiURjg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KYfMAG48vz0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("IgE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EDUijD0+kbY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ndYnlOOl1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yYRy2qiI5E8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("KpM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GKbQ4mc1eHc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9Gk25CTx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uCx3ognAq+Y=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("kqw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oJr8zZbDYEI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("npNF0lpX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0tYElHdlxbs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("dlk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RG6mgXlSuj8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IMeb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("coPLaAW5zHs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("I3w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUTUoQ5qGWM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5GN8eg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rTEoKjYPJx8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xLs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9oJKlHRnghQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GhO5xCDTcQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U0D26XSDRbo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("P3M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DEMy6CshJoM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("I4ZTJM0e").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bcMHZoFK3ak=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("JLM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F4LLTjodHQk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RujhuKea+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C66klenJqCo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("o4w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kL4XpgSNw5s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("UUj8NEzOkLtM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HA2ufRjj2fU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("S9o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eOlbEPRbNKk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("j9UZCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y5ZaWU3ZVWA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Jk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("461Xu8B+MLU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2Ral").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6kbmxXXURB0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Qd8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cuqg/AqPmpU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("l7VfFQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3vEPR5LR0iI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("O/0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CMvfG1rUAs8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("WzaH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A2LXzpRoV2c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0As=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4zwhXaKfXzs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("OveT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("frPD5/18hR0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("c4g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QLBMcrywNOk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7nlP4E52GJb3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pz0fsmM1VcI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eyIgWiDBPsw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ZE8u2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MB8F8ur802c=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("swo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hzo7nHpk2lU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kNQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ZjwOPHH+YU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("aE0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XHw0jm45ri8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("a2P12w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IjOD7fN8PU4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R9o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c+iOMizPyQM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("XNOAtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D5fS5/AHJZA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("JBk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ECp6eSC/4Ho=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VONmGI04abFp1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HbMQLqBqBsQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xYU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8bF7PpN5nHk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("PvOYBkKtvJYQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d6PuMG/rzvc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("4x0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1yiHEegNxrg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("agGB3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I0XTj4/oPds=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("bBA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WCb+m//2r3M=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RDJsVA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FmE6BO4p/PU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("D0Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O3EZf/xNP+E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Y9gL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JIpOUH83eww=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jao=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uZLDxp4iZd8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("3YpV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mdkHw2BimQY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("TF4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eGeZGwvETbQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5rab").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pPjaUVkpMog=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("hu4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s97DrPx3Wd4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("BWuc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QDjMIPDY5CI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("B/A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MsG1ZEXtAS8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("KCU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aW1s07R6O10=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("q5U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nqfdwLZ38pI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("/tl7UBIb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t/Q1HEFL9qw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/X8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yEwZp0eNKk8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("SsdLTy8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GZACH2pIlE8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("+Tc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zAOBlFucb8E=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hwm0+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yUjmqisvjjQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7Ao=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2T8gcjoqQFI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("dmx4OWCx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OyM6cCz0yV8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("OxU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DiPLKhoWjes=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Bosdpw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UsdO90LKQ88=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("st0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h+p+yFIWZNE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("K9AnOw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eJtuaxgH/ME=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SrU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f40Lxd6MxpQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Gd0/Iceo90MA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UI1JF+rhtA4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9ls=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w2JQM8YvuBs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("SfAkqHD6GR541A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKBSnl20dlA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("8ts=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xOt/gLcwRdI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("MbtrfaaAUBwL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eOsdS4vPIGg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Aw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NT7g0nPp8qM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Q9va7qrhx3s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IrWjzsKOtA8=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Epk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JKszQWwKrCU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("C/mhXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SL/1DfpA03o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1rQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4Id3rW4QFEs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Ee+eT/UPEQYc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cIHnb5lgcmc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("wrU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9IGnOjzP198=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("7u8tNTiENnb2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("va55GH3cZjc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("yYE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/7Q9FAiO5n4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("X3wR/ydZ/7Va").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FC5Ir3MWs/Q=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9xY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wSCJ7hZzmwk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("J/0m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("datiN7ddjW4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("MHs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BkyEG3vc05c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("qxUwWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4kVgGnvJgww=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("z1k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+WF8Gs4FIGo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("K4vgHjxeKh44jPtLLFI9SiyM9Vt4RCAZPoD0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SuWZPlg3WWo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Amk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NFAMzrqA+Ks=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("uQ6HmxFEqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6k/TtlwL5RE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("yKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/5ou3OcL8a0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("53o/8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sTNsssYsFqo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("vOM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i9IsIJoReLo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("qfEqEA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4KFpRsG1Mgk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("DuM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OdFy2FXnmKA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ktKQcw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0YLeK3qux3U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("zFI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+2FFouLUO6k=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("X7rkqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HOqs6ciRDzk=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("wBU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9yE4XkHqQKU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LTDh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("emOvoUo1iwE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("xxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8COa4YXJnLE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YSYU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MXBELduVjVM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("htY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("seBRe6hm0K8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("S0DYJrbQJH9GXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRL1dfeECTI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("iI8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v7ij7i7/Ugo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yEoNGXbF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mx9DNDiBiaM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("+rw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zYTsi4HTOCw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("XeLjX8F1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CqDOEo47VW0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N6aiERKPUGY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("QjIz7clThmk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FXAeqJEDxyI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("y3I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("80IjR7aw3PI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("TIBe0cn9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BdMR/ICt1sU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("vPc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hMbQU49Ol6g=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("t6WDUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4ejXA+rZ1ms=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7N4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1OxT/b055Z0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ik0YazyotiSUXAs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2QhbPm7tm3I=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("w8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+/Zd2QOeoTw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("BzPCl6s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UXqM0vgtj34=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("66o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("057OCmjCeP0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("yOv6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nL+qWAsFJ5s=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ll8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FmpA3Y1w6Qc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("36JUDl3at4LWoQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kfESQBiOmss=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("XKI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZJSSpaWvqoU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ksBw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1ocg/EVBF2g=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Oig=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ah8KNO5SXJg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("vW1k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6S4iHWrjknQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("jCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBL1FWyQU8A=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("wLQw5B8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hf13tk+36Hw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("gDM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uArAkkd8h1w=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("LO0IVLov4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y75YEvNos+U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Pdo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BOoI1FC68k8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("oTUz1uxy9JyiBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8kVBv5gX2c4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("z3c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9kbPGIBGJMM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("g+Pl3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z6K3jyyfCe4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AnM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O0EGk3KSmM4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("kuZI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("37IYTyKEelA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Q8g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evspv7406S4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("FE0rzYE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VRUF/7T0dnE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ZaU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XJF8BdcCWmQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IU1w5A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aB05tBiOAJE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("s5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iqmmATACFnQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("af7udg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JLetJsaWZVI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Trc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d4HOLU/1+1c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("05Sfwrv0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gNfc7+ikJdA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Brc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4DLcdy5/sc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("R7zgPDnTmA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AuioeWuayCQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Zfc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XM9gd9JIoaM=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Q+bOmfg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BqiN2Kid9aI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Pns=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0LChHw7fPw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YsWQKMw1k6Fi34wo2SmZpXrbnWHTKdqkYMOMZdk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A6vpCLxH+tc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("AxtG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mit277N1n9s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("rtpPIQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6ZcbcTMlb64=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("m65K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qp57CJecj28=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("WgZ4KQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0A1efuQ2pI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("e95G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Su50LZ2HPc0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("D/T0kg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X7q6266Orfc=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Qryq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c4yZ3ZoVsfk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hmpM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1iMB5x/RSvQ=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CJVM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OaV4sMXKb88=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9oDQBQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t9KZVvQJYec=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("nIgg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rbgVtZHGoUQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("NFTmLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zxe2fYG7iN0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Q4UY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("crUuNiYOKfg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2dZB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iJgZivlbqLg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1lV9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("52VKSrSEb50=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("9fqD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tNXNF20MNWs=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("sTYm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gAYeoB+hdCU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fl0AGjil").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nw1DdVXVkOY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("3Agt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7TgUvihvQ68=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ggWd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0UvNs33OeF4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1K/5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5Z7J1iP/yEo=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("sQ2lia8KEfKXB7o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8mLI+c57PKI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("8lLT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w2PiMS4vmek=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ic3YYCs9YayQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wJ2ATUJTTOU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R8+i").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dv6QETR42yI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("JlAwTQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cAJiHZRHZ2I=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("igpH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uzt0oKhKedY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("4rc5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("svB0+dCYRlI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("lh3Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pyzkP+aqQ1s=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("89+SsKA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w/L639BNWck=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("0Uio").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4HmdSF+Ujhk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("lbRCiA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2YYW2NGPwqA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Yhbg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyfW74IMFs0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GVpS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XR4KgSTDT60=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("QNSA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ceW3QQFBHRw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("GUtHYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UAoTMUes96Q=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("k/9x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("os5JzqUyHIU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Ki4u").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eXp+aTKT+Xg=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7+C/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3tGG5r2g8Sg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("1Bu3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h0nn8mg9bdw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("zAJ/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/TBPTU3cEGc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("MQlB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZF0IrCgse0k=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("CFnN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OWv8SMhGfyc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("nQ1f").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zkAPjzP3uXA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("ZGoV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VVgnKKdYyl8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Jh0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dVBtlCm07OU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oaqj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kJiQzjZ9h2c=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("73qA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vy7QJl3RtlU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("PPZT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DcRnROHvFBg=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("tzZfEw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/mUWQKnOqnU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("srHe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g4PrX5uXJI8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("KtU4sg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bJxq9z3oJog=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("1rlI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("54t+FcSLdmc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("AgvBKw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QVmVe2Hgjok=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("BGmg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NVuXaXx5du8=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("3Je6P1U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8XvewV3Q9k=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oQ+o").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kD2Q84vvUKk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("vxGsCN415Wg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ELvR454pi0=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("7HIE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3UA9VMkY0WY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IUbVzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aBaZmUkygRA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("O1it").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Cmudp2l3gmY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("uvDQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6aCDNu92WQY=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ij7H").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ew32G14cFjs=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("scpQKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4YMAb3teO/4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("oCey").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kRSAvGlv9Wk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ioTicQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ce2IaJDf0U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("RVAo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dGMbcfstac0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("N2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cSrjyH+6xck=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Ysan").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U/WTzd2zxnQ=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("5lymp0TBgQqZRre5Jtb2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tA/w92mEs08=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("I6lO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Epp7AVFlnLY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("n4z26kLwYQU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0uOUgy6ZFXw=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("R4kC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dro0yIrsQEY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("HCzO09WPGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SWien7z7f3o=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Vo8M").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z7w7MtbE7AU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("RBz6SRiAx39AHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CUy2GjXpqVI=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("LLhU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HYtsYbbGgM4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("C3oGxeE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZhtooJVQ1HA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("/auy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zJiLbKSs8fU=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("v7bU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9/+ETVZ6B7U=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Bq0R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N5khq1cU3fY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("riILMHI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UpiXUSgPkA=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("E5N2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IqdH2foPwZw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("fL4vWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K/t8Cx3XHb4=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("lGff").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pVPtY4otrrA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("YWIVDQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("My1dTja44EE=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("9Qu+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xD+Nr/u0Iy0=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("+/rAHZwtluTL8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rpShbu9E8Yo=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("eirH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SB/0mAtASQk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("axnX4Vz3lUZAFcbwR/GW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LmGnhC6e+CM=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("SLM9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eoYJcgt+0a4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("zqvhp3uudNDlp/C2YKh3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i9ORwgnHGbU=")[iii % 8])).ToArray())
            },
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("GUrj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K3/W9CMq6SA=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("DMlHWQuQDbE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xqw0PHnmaNU=")[iii % 8])).ToArray())
            }
        };
        string[] ruleLocations =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("alKrd2oFJ5xlTYJPVCccvEpBoEpeNhqqVnuZf2otG71Wap5lVDYQrlhxgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OR3tIz1Eddk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("FnAGNT5eSVEwWycEFWdWfStdJw4XQHBmGXowEw16dnc2dQYJGmFwdgRKNgQIYElCJFs0DB5ncGA2dRMICXZicylFBQ4XenZr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RSlVYXsTFRI=")[iii % 8])).ToArray())
        };
        foreach (var ruleLocation in ruleLocations)
        {
            var FirewallRules = ThisRunTime.GetValues(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("2nhMowomZyvWKV2THjp5K9I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oUgx/0xPFU4=")[iii % 8])).ToArray()), ruleLocation));
            if (FirewallRules != null)
            {
                var output = new O_CA646800(ruleLocation);
                var DomainProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("5AWdjHpFFLr2W7CiUUwQt/o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nzXg0D4qeds=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("E3U/A1uXPLAkfikAW54=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VhteYTfyetk=")[iii % 8])).ToArray()));
                if (DomainProfileEnabled != null)
                {
                    output.Domain.Present = true;
                    var DomainProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("/Y8Xa5tBgnzv0TpFsEiGceM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hr9qN98u7x0=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("IlPROggr5mMIVNguEyPTSRJf2DU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zja3W31Hkio=")[iii % 8])).ToArray()));
                    var DomainProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("p6Xlyk2ES0G1+8jkZo1PTLk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3JWYlgnrJiA=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("tDk0ItnJGt6FKDAs2csK0JMoOyzC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8FxSQ6ylbpE=")[iii % 8])).ToArray()));
                    var DomainProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("u7KFGDQuI+Wp7Kg2Hycn6KU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wIL4RHBBToQ=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("IuHestQiu0oJ/MS13y2/cA/nw6A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zoit07ZO3gQ=")[iii % 8])).ToArray()));
                    output.Domain.Enabled = DomainProfileEnabled == 1;
                    if (DomainProfileEnabled != null)
                    {
                        if (DomainProfileDisableNotifications != null)
                        {
                            output.Domain.DisableNotifications = DomainProfileDisableNotifications == 1;
                        }

                        if (DomainProfileInboundAction != null)
                        {
                            output.Domain.DefaultInboundAction = (FirewallAction)DomainProfileInboundAction;
                        }

                        if (DomainProfileOutboundAction != null)
                        {
                            output.Domain.DefaultOutboundAction = (FirewallAction)DomainProfileOutboundAction;
                        }
                    }
                }

                var PublicProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("EFxEYyato0QCD2lNGb6oRA4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a2w5P3bYwSg=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("+zSfiin8JNPMP4mJKfU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vlr+6EWZYro=")[iii % 8])).ToArray()));
                if (PublicProfileEnabled != null)
                {
                    output.Public.Present = true;
                    var PublicProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("UmQc4cv7ahdANzHP9OhhF0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KVRhvZuOCHs=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("pQTzojEOVauPA/q2KgZggZUI+q0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4WGVw0RiIeI=")[iii % 8])).ToArray()));
                    var PublicProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("sbeoc5Bf6faj5IVdr0zi9q8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yofVL8Aqi5o=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("75K8jlhiFUHeg7iAWGAFT8iDs4BD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q/fa7y0OYQ4=")[iii % 8])).ToArray()));
                    var PublicProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("dodJdGxYm31k1GRaU0uQfWg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dbc0KDwt+RE=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("6Uq4rDQDZ+7CV6KrPwxj1MRMpb4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rSPLzVZvAqA=")[iii % 8])).ToArray()));
                    output.Public.Enabled = PublicProfileEnabled == 1;
                    if (PublicProfileDisableNotifications != null)
                    {
                        output.Public.DisableNotifications = PublicProfileDisableNotifications == 1;
                    }

                    if (PublicProfileInboundAction != null)
                    {
                        output.Public.DefaultInboundAction = (FirewallAction)PublicProfileInboundAction;
                    }

                    if (PublicProfileOutboundAction != null)
                    {
                        output.Public.DefaultOutboundAction = (FirewallAction)PublicProfileOutboundAction;
                    }
                }

                var PrivateProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("xeT5hM+T4VDfoOGI7Y7uT9Kx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vtSE2J/hiCY=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Qo3ENUNFGSV1htI2Q0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B+OlVy8gX0w=")[iii % 8])).ToArray()));
                if (PrivateProfileEnabled != null)
                {
                    output.Private.Present = true;
                    var PrivateProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JFuuooBWxg0+H7auokvJEjMO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X2vT/tAkr3s=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Wvg2UeuwtYZw/z9F8LiArGr0P14=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hp1QMJ7cwc8=")[iii % 8])).ToArray()));
                    var PrivateProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("G1kKG1JkWQgBHRIXcHlWFwwM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YGl3RwIWMH4=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Sf+GpGEsX0147oKqYS5PQ27uiap6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZrgxRRAKwI=")[iii % 8])).ToArray()));
                    var PrivateProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("A2cgqF5ekE4ZIzikfEOfURQy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eFdd9A4s+Tg=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("bCzuwKYPrahHMfTHrQCpkkEq89I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KEWdocRjyOY=")[iii % 8])).ToArray()));
                    output.Private.Enabled = PrivateProfileEnabled == 1;
                    if (PrivateProfileDisableNotifications != null)
                    {
                        output.Private.DisableNotifications = PrivateProfileDisableNotifications == 1;
                    }

                    if (PrivateProfileInboundAction != null)
                    {
                        output.Private.DefaultInboundAction = (FirewallAction)PrivateProfileInboundAction;
                    }

                    if (PrivateProfileOutboundAction != null)
                    {
                        output.Private.DefaultOutboundAction = (FirewallAction)PrivateProfileOutboundAction;
                    }
                }

                var StandardProfileEnabled = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("6Re8ztz6vLj2RrP23/yysPtLpA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kifBko+O3dY=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("s/nEHiWceoKE8tIdJZU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9pelfEn5POs=")[iii % 8])).ToArray()));
                if (StandardProfileEnabled != null)
                {
                    output.Standard.Present = true;
                    var StandardProfileInboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("RJ+L9FaNp81bzoTMVYupxVbDkw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P6/2qAX5xqM=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("Nl0HedUJ2focWg5tzgHs0AZRDnY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjhhGKBlrbM=")[iii % 8])).ToArray()));
                    var StandardProfileOutboundAction = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("ChIEUppdVBMVQwtqmVtaGxhOHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cSJ5DskpNX0=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("k08JCMJx4s+iXg0GwnPywbReBgbZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1ypvabcdloA=")[iii % 8])).ToArray()));
                    var StandardProfileDisableNotifications = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("frUWUCZPS8Jh5BloJUlFymzpDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BYVrDHU7Kqw=")[iii % 8])).ToArray()), ruleLocation), Encoding.UTF8.GetString(Convert.FromBase64String("uqCgtdD/59qRvbqy2/Dj4Jemvac=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/snT1LKTgpQ=")[iii % 8])).ToArray()));
                    output.Standard.Enabled = StandardProfileEnabled == 1;
                    if (StandardProfileDisableNotifications != null)
                    {
                        output.Standard.DisableNotifications = StandardProfileDisableNotifications == 1;
                    }

                    if (StandardProfileInboundAction != null)
                    {
                        output.Standard.DefaultInboundAction = (FirewallAction)StandardProfileInboundAction;
                    }

                    if (StandardProfileOutboundAction != null)
                    {
                        output.Standard.DefaultOutboundAction = (FirewallAction)StandardProfileOutboundAction;
                    }
                }

                foreach (var kvp in FirewallRules)
                {
                    var rule = new O_72452439();
                    var props = ((string)kvp.Value).Split('|');
                    foreach (var prop in props)
                    {
                        var onv = prop.Split('=');
                        if (onv.Length == 1)
                        {
                            continue;
                        }

                        string key = onv[0], value = onv[1];
                        switch (onv[0])
                        {
                            case "Action":
                                rule.Action = value;
                                break;
                            case "Active":
                                break;
                            case "Dir":
                                rule.Direction = value;
                                break;
                            case "Protocol":
                                rule.Protocol = protocols[value];
                                break;
                            case "Name":
                                rule.Name = value;
                                break;
                            case "Desc":
                                rule.Description = value;
                                break;
                            case "App":
                                rule.ApplicationName = value;
                                break;
                            case "Profile":
                                rule.Profiles = value;
                                break;
                            case "RPort":
                                rule.RemotePorts = value;
                                break;
                            case "LPort":
                                rule.LocalPorts = value;
                                break;
                            case "RA4":
                                rule.RemoteAddresses = value;
                                break;
                            case "LA4":
                                rule.LocalAddresses = value;
                                break;
                        }
                    }

                    if (!Runtime.FilterResults || ((((actionArgs.Count == 0 && protocolsArgs.Count == 0 && directionArgs.Count == 0 && profileArgs.Count == 0) && !rule.Name.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+LqsCqR+zUM=")[iii % 8])).ToArray())) && !rule.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("tr6WVQ2r8zmVo4cZIPvKO4y1kk0I5NQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5dbzOWGLulc=")[iii % 8])).ToArray())) && rule.Action.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("atzodcw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KLCHFqdd+U8=")[iii % 8])).ToArray())))) || ((actionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("HQ9UEBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XGM4f20Quh8=")[iii % 8])).ToArray())) && (rule.Action == Encoding.UTF8.GetString(Convert.FromBase64String("0zRb7sc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("klg3gbAT6b4=")[iii % 8])).ToArray()))) || (actionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("AL1IDm0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QtEnbQZFNtQ=")[iii % 8])).ToArray())) && (rule.Action == Encoding.UTF8.GetString(Convert.FromBase64String("ULhjufc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EtQM2pyJ+WY=")[iii % 8])).ToArray()))) || (protocolsArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("TuQx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gqdh/bizbb8=")[iii % 8])).ToArray())) && (rule.Protocol == Encoding.UTF8.GetString(Convert.FromBase64String("BqSU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UufEMIdmETE=")[iii % 8])).ToArray()))) || (protocolsArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("aHG9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PTXtsvqW31g=")[iii % 8])).ToArray())) && (rule.Protocol == Encoding.UTF8.GetString(Convert.FromBase64String("7TIr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uHZ7sT9FUj4=")[iii % 8])).ToArray()))) || (directionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("hqc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z8lPRmcsKHA=")[iii % 8])).ToArray())) && (rule.Direction == Encoding.UTF8.GetString(Convert.FromBase64String("kEs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2SVRrdoj++o=")[iii % 8])).ToArray()))) || (directionArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("ts1a").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+bgufHzLjEA=")[iii % 8])).ToArray())) && (rule.Direction == Encoding.UTF8.GetString(Convert.FromBase64String("HswU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UblgHWnCTYU=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("9dQXgtiX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sbt647H5seY=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("pV81fijm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4TBYH0GIxIM=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("coNDxTT1Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IvEqs1WBZ7A=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("a9Ofg9gUPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O6H29blgWvg=")[iii % 8])).ToArray()))) || (profileArgs.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("jS95df9l").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3VobGZYG410=")[iii % 8])).ToArray())) && (rule.Profiles.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("w+uxjouo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k57T4uLLgSw=")[iii % 8])).ToArray()))))))
                    {
                        output.Rules.Add(rule);
                    }
                }

                yield return output;
            }
        }
    }
}}