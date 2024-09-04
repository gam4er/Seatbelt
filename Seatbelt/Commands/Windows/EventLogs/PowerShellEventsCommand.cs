using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs
{
internal class O_1206113B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("BM7Zblpj3xc4zet9TV7DAQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VKGuCygwt3I=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("hQ5kJ5gY2fG5DTMxiTnY5KFBcS6FKNq0uQ50McpjhaXlVTpinSLF/PUSdiyZIsX9owQzJos/0Lo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1WETQupLsZQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_1206113B(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteVerbose($"Searching script block logs (EID 4104) for sensitive data.\n");
        var context = 3;
        string[] powershellLogs =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("4jUuaAOOAsvbcRpzApkC2txxHXUbmB/+xzkhdkOyHcjdPTlzA5MMwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r1xNGmz9ba0=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("wFCHZQsth7nHVp5kFgmc/PtV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lznpAWRa9Jk=")[iii % 8])).ToArray())
        };
        var powershellRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Dg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LjTeVgIVoB0=")[iii % 8])).ToArray()), args);
            powershellRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        foreach (var logName in powershellLogs)
        {
            var query = Encoding.UTF8.GetString(Convert.FromBase64String("3WdkszWjEjPYeUGvKKM+GsoIBvpyig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9zw3ykbXd14=")[iii % 8])).ToArray());
            var logReader = ThisRunTime.GetEventLogReader(logName, query);
            for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
            {
                var scriptBlock = eventDetail.Properties[2].Value.ToString();
                foreach (var reg in powershellRegex)
                {
                    var m = reg.Match(scriptBlock);
                    if (!m.Success)
                        continue;
                    var contextLines = new List<string>();
                    var scriptBlockParts = scriptBlock.Split('\n');
                    for (var i = 0; i < scriptBlockParts.Length; i++)
                    {
                        if (!scriptBlockParts[i].Contains(m.Value))
                            continue;
                        var printed = 0;
                        for (var j = 1; i - j > 0 && printed < context; j++)
                        {
                            if (scriptBlockParts[i - j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKHi0kaO3zc=")[iii % 8])).ToArray()))
                                continue;
                            contextLines.Add(scriptBlockParts[i - j].Trim());
                            printed++;
                        }

                        printed = 0;
                        contextLines.Add(m.Value.Trim());
                        for (var j = 1; printed < context && i + j < scriptBlockParts.Length; j++)
                        {
                            if (scriptBlockParts[i + j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SW64d9ppiW4=")[iii % 8])).ToArray()))
                                continue;
                            contextLines.Add(scriptBlockParts[i + j].Trim());
                            printed++;
                        }

                        break;
                    }

                    var contextJoined = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("nQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l5mgKfFK3X8=")[iii % 8])).ToArray()), contextLines.ToArray());
                    yield return new O_3AAD1509(eventDetail.TimeCreated, eventDetail.Id, $"{eventDetail.UserId}", m.Value, contextJoined);
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string GualZWcS)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
                    instance.IsLeapDay(13, 89, 51, 71);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteVerbose($"Searching script block logs (EID 4104) for sensitive data.\n");
        var context = 3;
        string[] powershellLogs =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("4jUuaAOOAsvbcRpzApkC2txxHXUbmB/+xzkhdkOyHcjdPTlzA5MMwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r1xNGmz9ba0=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("wFCHZQsth7nHVp5kFgmc/PtV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lznpAWRa9Jk=")[iii % 8])).ToArray())
        };
        var powershellRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Dg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LjTeVgIVoB0=")[iii % 8])).ToArray()), args);
            powershellRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        foreach (var logName in powershellLogs)
        {
            var query = Encoding.UTF8.GetString(Convert.FromBase64String("3WdkszWjEjPYeUGvKKM+GsoIBvpyig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9zw3ykbXd14=")[iii % 8])).ToArray());
            var logReader = ThisRunTime.GetEventLogReader(logName, query);
            for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
            {
                var scriptBlock = eventDetail.Properties[2].Value.ToString();
                foreach (var reg in powershellRegex)
                {
                    var m = reg.Match(scriptBlock);
                    if (!m.Success)
                        continue;
                    var contextLines = new List<string>();
                    var scriptBlockParts = scriptBlock.Split('\n');
                    for (var i = 0; i < scriptBlockParts.Length; i++)
                    {
                        if (!scriptBlockParts[i].Contains(m.Value))
                            continue;
                        var printed = 0;
                        for (var j = 1; i - j > 0 && printed < context; j++)
                        {
                            if (scriptBlockParts[i - j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKHi0kaO3zc=")[iii % 8])).ToArray()))
                                continue;
                            contextLines.Add(scriptBlockParts[i - j].Trim());
                            printed++;
                        }

                        printed = 0;
                        contextLines.Add(m.Value.Trim());
                        for (var j = 1; printed < context && i + j < scriptBlockParts.Length; j++)
                        {
                            if (scriptBlockParts[i + j].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SW64d9ppiW4=")[iii % 8])).ToArray()))
                                continue;
                            contextLines.Add(scriptBlockParts[i + j].Trim());
                            printed++;
                        }

                        break;
                    }

                    var contextJoined = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("nQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l5mgKfFK3X8=")[iii % 8])).ToArray()), contextLines.ToArray());
                    yield return new O_3AAD1509(eventDetail.TimeCreated, eventDetail.Id, $"{eventDetail.UserId}", m.Value, contextJoined);
                }
            }
        }
    }
}internal class O_3AAD1509 : O_4AED570F
{
    public O_3AAD1509(DateTime? timeCreated, int eventId, string userId, string match, string context)
    {
        TimeCreated = timeCreated;
        EventId = eventId;
        UserId = userId;
        Match = match;
        Context = context;
    }

    public DateTime? TimeCreated { get; }
    public int EventId { get; }
    public string UserId { get; }
    public string Match { get; }
    public string Context { get; }
}}