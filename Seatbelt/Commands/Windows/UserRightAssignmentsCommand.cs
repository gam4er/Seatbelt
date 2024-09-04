#nullable disable
using O_F41F88FA.Output.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using O_F41F88FA.Output.TextWriters;
using System.Text.RegularExpressions;
using static O_F41F88FA.Interop.O_B81255AD;
using O_F41F88FA.Util;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_B37466FB : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("3cacTcwFTcr89IpM9wtEz+3bjUw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iLX5P55sKqI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("VumFliQW1HVw4sulPhTTJ0fvjJg5UeB0Zu+MniAUz3NmpsOVYxaPJ0bjr5UjCO9iYfGEgiY9zmB66LmZKhnVKzXVjqMlBNVjevGFoD8Y125544yVYVHEc3aowtAsA8ZyeOOFhG1MnCd26YaAOAXEdXvnhpVtBc4ncOienSgDwHNw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FYbr8E1xoQc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    private readonly string[] _allPrivileges = new[]
    {
        Encoding.UTF8.GetString(Convert.FromBase64String("ef5e1gvTPzd66XbIGcghDUXwessoyDEvQ/d6wh0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KpsfpXi6WFk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Sc4F9xs/CaZowjLrEzMakw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GqtEgn9WffY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("UAuDT311vw5THKhYd3KvGWY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A27BLh4eyn4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2bafT2fQWKLltLJAQdpXhv4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("itPdLhOzMO4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("69TdJiPoOXn23uonJP8ObtHH9yIn4Ts=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uLGeTkKGXhw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Q93kt8um0oZX1Minz6v2kXnOzqnLoMM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ELinxa7HpuM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("wsSX3+G2DqrBwLPI4r4WqsHTvdvtux+o9A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kaHUrYTXes8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("hOdc95NrNSuH523ol2QkIKPSbeyAYy0rsOc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("14IfhfYKQU4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("AN0L2nUD6vIAwSXKfw739B/RJsNAEPfhOtQtz3U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U7hIqBBinpc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("JYRUHehXzG0ijnwK42bKYQCIewrqUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("duEXb402uAg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("3w2SX7pIfKv+AaBTtFh8ng==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jGjWOtg9G/s=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("fF3uRQWWy3dbW8JsBIjmeH1RzUgf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LziqIGvviRY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("r5DgjzIw+feIkNaLPz3Z75m5y40zJ+Lwm53Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/PWk6lxJsJk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("NP1z8TQRLFwT71jmMSQNXgj2Zf09ABY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z5g3lFpoYjk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("a7CkdNA6V7dVupR09y1xt0q0g2XXNWCeV7KPf+wqYrpM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ONXgEb5DBdI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("T915joBBBVZuzlSIi3Q5VHPWb4KJUCI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HLg96+44VjM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("lMkfgcki6TODyTaKzyHxP6jCCp3BNuw6oss/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x6xa76hAhVY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("zqEjyPBe58/yqgvR5Wvn1eutBsDnXg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ncRqpYA7lbw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("mufMZ6ENvJK658dosRqJgaDt92C2BomBoPTsZacYvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yYKFCcJ/2fM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("V5Ed0Z9x8Nh3kQXKk3f06XadItaQZvLc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BPRUv/wDlbk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("dgFsBK+5p5pWAXIFvqCrlUI3QB6cuauNTAhADak=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JWQlaszLwvs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("oXFSiZS6HnqRYHKRhZMDfJ16SY6Htxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8hQb5+DfbBs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("LML1gtGfbGIW0dyf4IlBZhbL3IrV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f6e57bD7KBA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("+/Lh0PZNqlDF+N/GxVSOQ8H7yNjw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qJetv5Um5zU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("luT90xt/3smgwNPRF2LZ05Xz2cQRe9LAoA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xYGwsngXt6c=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("rBOmhxm/hCGpGYeTGruzNpYAgooSuYY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/3br5nfe40Q=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("sTfBcvTfpx6JHuBw78aaBYU6+w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4lKPF4CoyGw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("B9c9Hd+7nlox4QQB17GSZibdDgrDrqdEPcQEA9W6kg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VLJtb7Dd9zY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Hk7sVU1En4che8xZV0yRhypO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TSu+MCEl/eI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("VvMYlzMH159M+D6XLAnAjmzgL74xD8yUV/8tmio=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BZZK8l5oo/o=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("qbHHFJuuDiSpvOAFkq4NL6qm/AefrR8mnw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+tSVcfbBekE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("9MiTNUo698LC/bM5Tyf01cDI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p63BUDlOmLA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("UZltFUqCC1p2hW4CQIEQX2ebWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Avw+cCn3eTM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("WP/+4u2idChu1sLg8LpPImzy2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C5qth5/UHUs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("TxgAum+Jor9rEwOgc4uvvHkaNg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HH1T0hr9xtA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ko7HW8VZTdakheBy2VN62K2O80c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("weuUIqs6DLE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("p4OFM80lwiKxiKAjzD7JIpGIohrMONEmmIOxLw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9ObWSr5Rp08=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("S1ko7OvcJB5IThTz8cQkI2pVDfz0zSYW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GDx7lZioQXM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("bfW9EWbrVZpK+YMNRe1ZgVf8iw9w").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PpDuaBWfMPc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("0r1Et26OR/bvvWKlbYJ40fOxZr9pjm/k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gdgQ1gXrCIE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("/+Zk338rVJra6lzZeh4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rIMwvB17JvM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("juTZZmRvc4az5N19YHxAhbjm6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3YGNDwkKKek=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("P+0kmMMSJAIIywKP0iwxCS3rE4/FEgAVBf4ZhtMGNQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bIhw6rZhUGc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pi4FgCiTXUKlOTmYJZBbTpA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9UtQ7kz8Pik=")[iii % 8])).ToArray())
    };
    private readonly string[] _defaultPrivileges = new[]
    {
        Encoding.UTF8.GetString(Convert.FromBase64String("IjnD7orlMLIhLuvwmP4uiB435/Op/j6qGDDn+pw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cVyCnfmMV9w=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("QHhzG94iV8JhdEQH1i5E9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ex0ybrpLI5I=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("qXFSBwxlsUKqZnkQBmKhVZ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+hQQZm8OxDI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("6D7X79KUVL3UPPrg9J5bmc8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u1uVjqb3PPE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("e8y2B8bLDQV70JgXzMYQA2TAmx7z2BAWQcWQEsY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KKn1daOqeWA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Y8hgUjSjx6xkwkhFP5LBoEbET0U2pw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MK0jIFHCs8k=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("byu7nn7M2hpOJ4mScNzaLw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PE7/+xy5vUo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("XuxaE6WUaOl56nY6pIpF5l/geR6/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DYkedsvtKog=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("CWBKT62yN3AuYHxLoL8XaD9JYU2spSx3PW16").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WgUOKsPLfh4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("+L2AsisosdTfr6ulLh2Q1sS2lr4iOYs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q9jE10VR/7E=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("I/7Y9WS+RWwd9Oj1Q6ljbAL6/+RjsXJFH/zz/liucGEE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cJuckArHFwk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("f4/QjQ0pXNdenP2LBhxg1UOExoEEOHs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LOqU6GNQD7I=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("d7X5hFCZ3K5gtdCPVprEoku+7JhYjdmnQbfZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JNC86jH7sMs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pwD2y4+UAyubC97SmqEDMYIM08OYlA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9GW/pv/xcVg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("KDxQs38dQ/YYLXCrbjRe8BQ3S7RsEEU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e1kZ3Qt4MZc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("IcUhcZ6HIHob1ghsr5ENfhvMCHma").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cqBtHv/jZAg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("H+5M+oMEHcYnx234mB0g3Svjdg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TIsCn/dzcrQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("tLG4O1dhzAGLhJg3TWnCAYCx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("59TqXjsArmQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("52oIRAfPrrv9YS5EGMG5qt15P20Fx7Ww5mY9SR4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tA9aIWqg2t4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("JImnHTTSwLkkhIAMPdLDsieenA4w0dG7Eg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d+z1eFm9tNw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("xRcxXWkQA6LzIhFRbA0AtfEX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lnJjOBpkbNA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("+j/bCLglQw7dI9gfsiZYC8w97Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qVqIbdtQMWc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("kecz5FnmjgWnzg/mRP61D6XqFA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("woJggSuQ52Y=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ipi9+HhFMwWuk77iZEc+Bryaiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2f3ukA0xV2o=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("lfvwOMn0ebmj8NcR1f5Ot6r7xCQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xp6jQaeXON4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("hn4rYHNmFN2QdQ5wcn0f3bB1DElyewfZuX4ffA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1Rt4GQAScbA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ODBgy6sJkJAFMEbZqAWvtxk8QsOsCbiC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a1U0qsBs3+c=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("tlhpOVWfx16TVFE/UKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5T09WjfPtTc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("LbeHqKDLvmAakaG/sfWraz+xsL+my5p3F6S6trDfrw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ftLT2tW4ygU=")[iii % 8])).ToArray()),
    };
    public O_B37466FB(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity())
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("vtGG8n54FpiSytXnOnca1prXgfQ/bhzK09Capjt0BtWW1pTyOzomy5bW1dQ3fRvM0+WG9Td9HdWWyoH1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("86T1hl4ac7g=")[iii % 8])).ToArray()));
            yield break;
        }

        var computerName = Encoding.UTF8.GetString(Convert.FromBase64String("3faAqfUBa5bF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sZnjyJlpBOU=")[iii % 8])).ToArray());
        string filter = null;
        O_41CA9BAE lsa = null;
        if (args.Length >= 1)
        {
            computerName = args[0];
        }

        if (args.Length >= 2)
        {
            filter = Encoding.UTF8.GetString(Convert.FromBase64String("IDU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dh/KPxtqZ1U=")[iii % 8])).ToArray()) + args[1] + Encoding.UTF8.GetString(Convert.FromBase64String("enc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VF1v7hTkpKo=")[iii % 8])).ToArray());
        }

        try
        {
            lsa = new O_41CA9BAE(computerName);
        }
        catch (UnauthorizedAccessException)
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("xsQdhat64vrmzwCE7Wz58PnDApWqefg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j6pu8M0ci5k=")[iii % 8])).ToArray()));
            yield break;
        }
        catch (Exception e)
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("X1rDiMKqzjluFM6Rz6vSKGNbxcnJoNcxb0bKncWgxXx/R86bjLzLO2JAi4jfvcs7ZFnOh9i9mHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CjSr6azOolw=")[iii % 8])).ToArray()) + e);
            yield break;
        }

        var privilegeSet = filter == null ? _defaultPrivileges : _allPrivileges.Where(p => Regex.IsMatch(p, filter, RegexOptions.IgnoreCase)).ToArray();
        foreach (var priv in privilegeSet)
        {
            var principals = lsa.ReadPrivilege(priv);
            yield return new O_B2DB8A27()
            {
                Right = priv,
                Principals = principals
            };
        }

        if (lsa != null)
        {
            lsa.Dispose();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string HaRqMOjh)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JulianCalendar instance = new System.Globalization.JulianCalendar();
                    instance.IsLeapDay(15, 51, 34, 81);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity())
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("vtGG8n54FpiSytXnOnca1prXgfQ/bhzK09Capjt0BtWW1pTyOzomy5bW1dQ3fRvM0+WG9Td9HdWWyoH1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("86T1hl4ac7g=")[iii % 8])).ToArray()));
            yield break;
        }

        var computerName = Encoding.UTF8.GetString(Convert.FromBase64String("3faAqfUBa5bF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sZnjyJlpBOU=")[iii % 8])).ToArray());
        string filter = null;
        O_41CA9BAE lsa = null;
        if (args.Length >= 1)
        {
            computerName = args[0];
        }

        if (args.Length >= 2)
        {
            filter = Encoding.UTF8.GetString(Convert.FromBase64String("IDU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dh/KPxtqZ1U=")[iii % 8])).ToArray()) + args[1] + Encoding.UTF8.GetString(Convert.FromBase64String("enc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VF1v7hTkpKo=")[iii % 8])).ToArray());
        }

        try
        {
            lsa = new O_41CA9BAE(computerName);
        }
        catch (UnauthorizedAccessException)
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("xsQdhat64vrmzwCE7Wz58PnDApWqefg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j6pu8M0ci5k=")[iii % 8])).ToArray()));
            yield break;
        }
        catch (Exception e)
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("X1rDiMKqzjluFM6Rz6vSKGNbxcnJoNcxb0bKncWgxXx/R86bjLzLO2JAi4jfvcs7ZFnOh9i9mHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CjSr6azOolw=")[iii % 8])).ToArray()) + e);
            yield break;
        }

        var privilegeSet = filter == null ? _defaultPrivileges : _allPrivileges.Where(p => Regex.IsMatch(p, filter, RegexOptions.IgnoreCase)).ToArray();
        foreach (var priv in privilegeSet)
        {
            var principals = lsa.ReadPrivilege(priv);
            yield return new O_B2DB8A27()
            {
                Right = priv,
                Principals = principals
            };
        }

        if (lsa != null)
        {
            lsa.Dispose();
        }
    }
}internal class O_B2DB8A27 : O_4AED570F
{
    public string Right { get; set; }
    public List<Principal> Principals { get; set; }
}
    [CommandOutputType(typeof(O_B2DB8A27))]
    internal class O_75AE188C : TextFormatterBase
    {
        public O_75AE188C(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_B2DB8A27)result;
            WriteLine($"{dto.Right}:");
            if (dto.Principals.Count <= 0)
                return;
            foreach (var t in dto.Principals)
            {
                var accountName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rIdicTb2nxI=")[iii % 8])).ToArray());
                accountName = !string.IsNullOrEmpty(t.Domain) ? $"{t.Domain}\\{t.User}" : t.User;
                if (string.IsNullOrEmpty(accountName))
                {
                    accountName = t.Sid;
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("oiPBqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ggPhiV0F5po=")[iii % 8])).ToArray()) + accountName);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string MZMsqjFX)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                        instance.GetEra(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_B2DB8A27)result;
            WriteLine($"{dto.Right}:");
            if (dto.Principals.Count <= 0)
                return;
            foreach (var t in dto.Principals)
            {
                var accountName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rIdicTb2nxI=")[iii % 8])).ToArray());
                accountName = !string.IsNullOrEmpty(t.Domain) ? $"{t.Domain}\\{t.User}" : t.User;
                if (string.IsNullOrEmpty(accountName))
                {
                    accountName = t.Sid;
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("oiPBqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ggPhiV0F5po=")[iii % 8])).ToArray()) + accountName);
            }

            WriteLine();
        }
    }
}
#nullable enable
