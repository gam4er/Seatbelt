using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_4BF931DF : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("u+D+zmFX2rSH48HCYHDdo5I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("64+JqxMEstE=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("YlSdQY1MJK4RYZNEi1YStVRdkBONSy+uXl2ZE4ZNMqleQ4UTiE0tuEIRmlycBDK4X0KVR4dSJP1DVJtWlgQsvEVSlFadCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MTH8M+4kQd0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_4BF931DF(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var powershellRegex = MiscUtil.GetProcessCmdLineRegex();
        var context = 3;
        if (args.Length >= 1)
        {
            var allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("iw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+RYsyNCWtI=")[iii % 8])).ToArray()), args);
            powershellRegex = new[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("SevHB3SUWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Fb60YgbnB8Q=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("R3Nf0KId").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FwY9vMt+TwM=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MonZbKrjTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("duy/Dd+PO+g=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("TxYZB0Bk29deABoU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C3N/ZjUIr/c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("qj1pKGEexzeY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("61EFCDRtokU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var consoleHistoryPath = $"{dir}\\AppData\\Roaming\\Microsoft\\Windows\\PowerShell\\PSReadline\\ConsoleHost_history.txt";
            if (!File.Exists(consoleHistoryPath))
                continue;
            var content = File.ReadAllText(consoleHistoryPath);
            foreach (var reg in powershellRegex)
            {
                var m = reg.Match(content);
                if (!m.Success)
                    continue;
                var contextLines = new List<string>();
                var scriptBlockParts = content.Split('\n');
                for (var i = 0; i < scriptBlockParts.Length; i++)
                {
                    if (!scriptBlockParts[i].Contains(m.Value))
                        continue;
                    var printed = 0;
                    for (var j = 1; i - j > 0 && printed < context; j++)
                    {
                        if (scriptBlockParts[i - j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EjKOTNFkvx4=")[iii % 8])).ToArray()))
                            continue;
                        contextLines.Add(scriptBlockParts[i - j].Trim());
                        printed++;
                    }

                    printed = 0;
                    contextLines.Add(m.Value.Trim());
                    for (var j = 1; printed < context && i + j < scriptBlockParts.Length; j++)
                    {
                        if (scriptBlockParts[i + j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E3XfgwNr6Zs=")[iii % 8])).ToArray()))
                            continue;
                        contextLines.Add(scriptBlockParts[i + j].Trim());
                        printed++;
                    }

                    break;
                }

                var contextJoined = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aO9LEPAcjpY=")[iii % 8])).ToArray()), contextLines.ToArray());
                yield return new O_87DB36ED(userName, consoleHistoryPath, m.Value, contextJoined);
            }
        }
    }

internal class O_87DB36ED : O_4AED570F
{
    public O_87DB36ED(string? userName, string? fileName, string? match, string? context)
    {
        UserName = userName;
        FileName = fileName;
        Match = match;
        Context = context;
    }

    public string? UserName { get; set; }
    public string? FileName { get; set; }
    public string? Match { get; set; }
    public string? Context { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string vJBznYba)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                    instance.GetDayOfWeek(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var powershellRegex = MiscUtil.GetProcessCmdLineRegex();
        var context = 3;
        if (args.Length >= 1)
        {
            var allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("iw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+RYsyNCWtI=")[iii % 8])).ToArray()), args);
            powershellRegex = new[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("SevHB3SUWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Fb60YgbnB8Q=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("R3Nf0KId").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FwY9vMt+TwM=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MonZbKrjTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("duy/Dd+PO+g=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("TxYZB0Bk29deABoU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C3N/ZjUIr/c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("qj1pKGEexzeY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("61EFCDRtokU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var consoleHistoryPath = $"{dir}\\AppData\\Roaming\\Microsoft\\Windows\\PowerShell\\PSReadline\\ConsoleHost_history.txt";
            if (!File.Exists(consoleHistoryPath))
                continue;
            var content = File.ReadAllText(consoleHistoryPath);
            foreach (var reg in powershellRegex)
            {
                var m = reg.Match(content);
                if (!m.Success)
                    continue;
                var contextLines = new List<string>();
                var scriptBlockParts = content.Split('\n');
                for (var i = 0; i < scriptBlockParts.Length; i++)
                {
                    if (!scriptBlockParts[i].Contains(m.Value))
                        continue;
                    var printed = 0;
                    for (var j = 1; i - j > 0 && printed < context; j++)
                    {
                        if (scriptBlockParts[i - j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EjKOTNFkvx4=")[iii % 8])).ToArray()))
                            continue;
                        contextLines.Add(scriptBlockParts[i - j].Trim());
                        printed++;
                    }

                    printed = 0;
                    contextLines.Add(m.Value.Trim());
                    for (var j = 1; printed < context && i + j < scriptBlockParts.Length; j++)
                    {
                        if (scriptBlockParts[i + j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E3XfgwNr6Zs=")[iii % 8])).ToArray()))
                            continue;
                        contextLines.Add(scriptBlockParts[i + j].Trim());
                        printed++;
                    }

                    break;
                }

                var contextJoined = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aO9LEPAcjpY=")[iii % 8])).ToArray()), contextLines.ToArray());
                yield return new O_87DB36ED(userName, consoleHistoryPath, m.Value, contextJoined);
            }
        }
    }
}}