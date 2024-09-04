#nullable disable
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs
{
internal class O_8DD4BBE5 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("SgWO98vSvHR8Eonp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GXz9mqS8+QI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("GR0PrL+xYBc4Cx+ko6xgBDgBHbW5sC5HJgsbsvD3cU5qExW1uP8zAiQXFbW5qSVHLgUIoP4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SmR8wdDfQGc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_8DD4BBE5(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("gr8UxjsqxpC48RbLOyODh6P/VekiPJLEtbRVxTlvh4C6uBvNJDuUhaO+B4o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("19F1pFdP5uQ=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteVerbose($"Searching Sysmon process creation logs (Sysmon ID 1) for sensitive data.\n");
        Regex[] processCmdLineRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Vw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d+wT66C42Fs=")[iii % 8])).ToArray()), args);
            processCmdLineRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var query = Encoding.UTF8.GetString(Convert.FromBase64String("/zeiLt29Ib/6KYcywL0NluhdrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1WzxV67JRNI=")[iii % 8])).ToArray());
        EventLogReader logReader = null;
        try
        {
            logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("HR9lUmIwDdQkW1FJYycNxSNbVVl+Lg3cfzl2RX8iFts/GGdM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UHYGIA1DYrI=")[iii % 8])).ToArray()), query);
        }
        catch
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("NzoYk5M341ANdAiEmiC6BDEtCpyQPONBFDEXhd8+rEMReFmihiGuSwx0FZiUN69dQjoWhd87rVcWNRWdmjbt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YlR58f9SwyQ=")[iii % 8])).ToArray()));
            yield break;
        }

        var i = 0;
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            ++i;
            var commandLine = eventDetail.Properties[10].Value.ToString().Trim();
            if (commandLine != Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("43KoW1YcbJs=")[iii % 8])).ToArray()))
            {
                foreach (var reg in processCmdLineRegex)
                {
                    var m = reg.Match(commandLine);
                    if (m.Success)
                    {
                        var userName = eventDetail.Properties[12].Value.ToString().Trim();
                        yield return new O_A5BD4B1E()
                        {
                            TimeCreated = eventDetail.TimeCreated,
                            EventID = eventDetail.Id,
                            UserName = userName,
                            Match = m.Value
                        };
                    }
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string RzJRZbWu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.StringBuilder instance = new System.Text.StringBuilder();
                    instance.Insert(32, 254);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("gr8UxjsqxpC48RbLOyODh6P/VekiPJLEtbRVxTlvh4C6uBvNJDuUhaO+B4o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("19F1pFdP5uQ=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteVerbose($"Searching Sysmon process creation logs (Sysmon ID 1) for sensitive data.\n");
        Regex[] processCmdLineRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Vw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d+wT66C42Fs=")[iii % 8])).ToArray()), args);
            processCmdLineRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var query = Encoding.UTF8.GetString(Convert.FromBase64String("/zeiLt29Ib/6KYcywL0NluhdrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1WzxV67JRNI=")[iii % 8])).ToArray());
        EventLogReader logReader = null;
        try
        {
            logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("HR9lUmIwDdQkW1FJYycNxSNbVVl+Lg3cfzl2RX8iFts/GGdM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UHYGIA1DYrI=")[iii % 8])).ToArray()), query);
        }
        catch
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("NzoYk5M341ANdAiEmiC6BDEtCpyQPONBFDEXhd8+rEMReFmihiGuSwx0FZiUN69dQjoWhd87rVcWNRWdmjbt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YlR58f9SwyQ=")[iii % 8])).ToArray()));
            yield break;
        }

        var i = 0;
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            ++i;
            var commandLine = eventDetail.Properties[10].Value.ToString().Trim();
            if (commandLine != Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("43KoW1YcbJs=")[iii % 8])).ToArray()))
            {
                foreach (var reg in processCmdLineRegex)
                {
                    var m = reg.Match(commandLine);
                    if (m.Success)
                    {
                        var userName = eventDetail.Properties[12].Value.ToString().Trim();
                        yield return new O_A5BD4B1E()
                        {
                            TimeCreated = eventDetail.TimeCreated,
                            EventID = eventDetail.Id,
                            UserName = userName,
                            Match = m.Value
                        };
                    }
                }
            }
        }
    }
}internal class O_A5BD4B1E : O_4AED570F
{
    public DateTime? TimeCreated { get; set; }
    public int EventID { get; set; }
    public string UserName { get; set; }
    public string Match { get; set; }
}}
#nullable enable
