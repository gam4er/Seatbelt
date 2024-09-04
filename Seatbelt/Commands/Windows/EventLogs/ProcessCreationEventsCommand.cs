using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs
{
internal class O_701AAFFB : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("iou1zcdGmCGonLvay1qFJ6yctNrR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2vnarqI162I=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("qR/EenaJ2u6aH854Z5PGoNkBxH5g2oH6z1WTMDONwLqRTdh8fYnAupAbzjl3m92v1w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+W2rGRP6qc4=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_701AAFFB(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("DX0yyNr/Luo3MzDF2vZr/Sw9c+fD6Xq+OnZzy9i6b/o1ej3Dxe58/yx8IYQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WBNTqraaDp4=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteVerbose($"Searching process creation logs (EID 4688) for sensitive data.");
        WriteVerbose($"Format: Date(Local time),User,Command line.\n");
        var processCmdLineRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("34k0wBlzh+8=")[iii % 8])).ToArray()), args);
            processCmdLineRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var query = $"*[System/EventID=4688]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("NA8MK4/4ue0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z2pvXv2RzZQ=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var user = eventDetail.Properties[1].Value.ToString().Trim();
            var commandLine = eventDetail.Properties[8].Value.ToString().Trim();
            foreach (var reg in processCmdLineRegex)
            {
                var m = reg.Match(commandLine);
                if (m.Success)
                {
                    yield return new O_AADB0A75(eventDetail.TimeCreated?.ToUniversalTime(), eventDetail.Id, user, commandLine);
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string yPAvObOt)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.X509Certificates.X509Certificate instance = new System.Security.Cryptography.X509Certificates.X509Certificate();
                //instance.GetCertHashString(new System.Security.Cryptography.HashAlgorithmName());
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
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("DX0yyNr/Luo3MzDF2vZr/Sw9c+fD6Xq+OnZzy9i6b/o1ej3Dxe58/yx8IYQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WBNTqraaDp4=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteVerbose($"Searching process creation logs (EID 4688) for sensitive data.");
        WriteVerbose($"Format: Date(Local time),User,Command line.\n");
        var processCmdLineRegex = MiscUtil.GetProcessCmdLineRegex();
        if (args.Length >= 1)
        {
            string allArgs = String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("34k0wBlzh+8=")[iii % 8])).ToArray()), args);
            processCmdLineRegex = new Regex[]
            {
                new Regex(allArgs, RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
        }

        var query = $"*[System/EventID=4688]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("NA8MK4/4ue0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z2pvXv2RzZQ=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var user = eventDetail.Properties[1].Value.ToString().Trim();
            var commandLine = eventDetail.Properties[8].Value.ToString().Trim();
            foreach (var reg in processCmdLineRegex)
            {
                var m = reg.Match(commandLine);
                if (m.Success)
                {
                    yield return new O_AADB0A75(eventDetail.TimeCreated?.ToUniversalTime(), eventDetail.Id, user, commandLine);
                }
            }
        }
    }
}internal class O_AADB0A75 : O_4AED570F
{
    public O_AADB0A75(DateTime? timeCreatedUtc, int eventId, string user, string match)
    {
        TimeCreatedUtc = timeCreatedUtc;
        EventID = eventId;
        User = user;
        Match = match;
    }

    public DateTime? TimeCreatedUtc { get; set; }
    public int EventID { get; set; }
    public string User { get; set; }
    public string Match { get; set; }
}
    [CommandOutputType(typeof(O_AADB0A75))]
    internal class O_26BD6418 : TextFormatterBase
    {
        public O_26BD6418(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_AADB0A75)result;
            WriteLine($"  {dto.TimeCreatedUtc?.ToLocalTime(), -22}  {dto.User, -30} {dto.Match}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string DDnVlZRv)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.X509Certificates.X509Certificate instance = new System.Security.Cryptography.X509Certificates.X509Certificate();
                    //instance.GetCertHashString(new System.Security.Cryptography.HashAlgorithmName());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_AADB0A75)result;
            WriteLine($"  {dto.TimeCreatedUtc?.ToLocalTime(), -22}  {dto.User, -30} {dto.Match}");
        }
    }
}