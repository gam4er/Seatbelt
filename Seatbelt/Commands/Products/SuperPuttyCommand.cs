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
    class O_39A73883
    {
        public O_39A73883(string filePath, string sessionId, string sessionName, string host, string port, string protocol, string userName, string extraArgs)
        {
            FilePath = filePath;
            SessionID = sessionId;
            SessionName = sessionName;
            Host = host;
            Port = port;
            Protocol = protocol;
            UserName = userName;
            ExtraArgs = extraArgs;
        }

        public string FilePath { get; set; }
        public string SessionID { get; set; }
        public string SessionName { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Protocol { get; set; }
        public string UserName { get; set; }
        public string ExtraArgs { get; set; }
    }
internal class O_920EA79A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("cf5phVuW2RJW8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IosZ4CnGrGY=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("uEWZuApEaIifScm+F3p7lYxFm7wMfXKSy1aAsR1n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6zDp3XgUHfw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_920EA79A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("Q34yEmNumA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HytBdxEdxAM=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WyfxxGYH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C1KTqA9k5VQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("/CVREVD3wA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uEA3cCWbtJw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JgJDXjvNd203FEBN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YmclP06hA00=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("K2e+GSU5KXoZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("agvSOXBKTAg=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<O_39A73883>();
            string[] paths =
            {
                $"{dir}\\Documents\\SuperPuTTY\\Sessions.XML"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var sessions = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("M1KMXcZr3vMBQ54=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YDf/Lq8EsLc=")[iii % 8])).ToArray()));
                if (sessions.Count == 0)
                    continue;
                foreach (XmlNode session in sessions)
                {
                    var filePath = path;
                    var sessionID = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("sN/CE5NtSYyH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("47qxYPoCJ8U=")[iii % 8])).ToArray())].Value;
                    var sessionName = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("YUCpfCtIknpTSL8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MiXaD0In/DQ=")[iii % 8])).ToArray())].Value;
                    var host = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("NUfktw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fSiXw2w2KLU=")[iii % 8])).ToArray())].Value;
                    var port = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("pQpQ4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WUiljZdV4s=")[iii % 8])).ToArray())].Value;
                    var protocol = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("VAiMu6w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BHrjz8MxGAA=")[iii % 8])).ToArray())].Value;
                    var user = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("4y9ExDzeCW4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tlwhtlK/ZAs=")[iii % 8])).ToArray())].Value;
                    var extraArgs = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("mtvcsAQSR0as").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36OowmVTNSE=")[iii % 8])).ToArray())].Value;
                    var config = new O_39A73883(filePath, sessionID, sessionName, host, port, protocol, user, extraArgs);
                    configs.Add(config);
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_0DB98354(userName, configs);
            }
        }
    }

internal class O_0DB98354 : O_4AED570F
{
    public O_0DB98354(string userName, List<O_39A73883> configs)
    {
        UserName = userName;
        Configs = configs;
    }

    public string UserName { get; set; }
    public List<O_39A73883> Configs { get; set; }
}    [CommandOutputType(typeof(O_0DB98354))]
    internal class O_74C5E462 : TextFormatterBase
    {
        public O_74C5E462(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_0DB98354)result;
            WriteLine($"  SuperPutty Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    FilePath    : {config.FilePath}");
                WriteLine($"    SessionID   : {config.SessionID}");
                WriteLine($"    SessionName : {config.SessionName}");
                WriteLine($"    Host        : {config.Host}");
                WriteLine($"    Port        : {config.Port}");
                WriteLine($"    Protocol    : {config.Protocol}");
                WriteLine($"    Username    : {config.UserName}");
                if (!String.IsNullOrEmpty(config.ExtraArgs))
                {
                    WriteLine($"    ExtraArgs   : {config.ExtraArgs}");
                }

                WriteLine();
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string DmgDWDXt)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(6);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_0DB98354)result;
            WriteLine($"  SuperPutty Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    FilePath    : {config.FilePath}");
                WriteLine($"    SessionID   : {config.SessionID}");
                WriteLine($"    SessionName : {config.SessionName}");
                WriteLine($"    Host        : {config.Host}");
                WriteLine($"    Port        : {config.Port}");
                WriteLine($"    Protocol    : {config.Protocol}");
                WriteLine($"    Username    : {config.UserName}");
                if (!String.IsNullOrEmpty(config.ExtraArgs))
                {
                    WriteLine($"    ExtraArgs   : {config.ExtraArgs}");
                }

                WriteLine();
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string DlpOFIXL)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(6);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("Q34yEmNumA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HytBdxEdxAM=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WyfxxGYH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C1KTqA9k5VQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("/CVREVD3wA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uEA3cCWbtJw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JgJDXjvNd203FEBN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YmclP06hA00=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("K2e+GSU5KXoZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("agvSOXBKTAg=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<O_39A73883>();
            string[] paths =
            {
                $"{dir}\\Documents\\SuperPuTTY\\Sessions.XML"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var sessions = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("M1KMXcZr3vMBQ54=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YDf/Lq8EsLc=")[iii % 8])).ToArray()));
                if (sessions.Count == 0)
                    continue;
                foreach (XmlNode session in sessions)
                {
                    var filePath = path;
                    var sessionID = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("sN/CE5NtSYyH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("47qxYPoCJ8U=")[iii % 8])).ToArray())].Value;
                    var sessionName = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("YUCpfCtIknpTSL8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MiXaD0In/DQ=")[iii % 8])).ToArray())].Value;
                    var host = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("NUfktw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fSiXw2w2KLU=")[iii % 8])).ToArray())].Value;
                    var port = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("pQpQ4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WUiljZdV4s=")[iii % 8])).ToArray())].Value;
                    var protocol = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("VAiMu6w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BHrjz8MxGAA=")[iii % 8])).ToArray())].Value;
                    var user = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("4y9ExDzeCW4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tlwhtlK/ZAs=")[iii % 8])).ToArray())].Value;
                    var extraArgs = session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("mtvcsAQSR0as").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36OowmVTNSE=")[iii % 8])).ToArray())].Value;
                    var config = new O_39A73883(filePath, sessionID, sessionName, host, port, protocol, user, extraArgs);
                    configs.Add(config);
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_0DB98354(userName, configs);
            }
        }
    }
}}