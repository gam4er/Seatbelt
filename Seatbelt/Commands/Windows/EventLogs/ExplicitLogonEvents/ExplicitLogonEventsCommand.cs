using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs.ExplicitLogonEvents
{
internal class O_AD9CFF85 : O_2183A68D
{
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("JIBthB4XntpBtHKPGBrXyxedc5wEVN/rF51znFc9s45VzinQXlSR3A6VPZwfEdfdBJtomh4Ajo4EjniGA1SbwQbWPawSEpbbDYw9hxFUwI4FmWSbW1SW3AaNcI0ZANeTXNhxiQQA1/ZBnHyRBFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yfgd6Hd0964=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc,
        CommandGroup.Remote
    };
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("ZB9noXXr1/ZtCHCics3I508TZA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IWcXzRyIvoI=")[iii % 8])).ToArray());
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_AD9CFF85(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        const string eventId = "4648";
        string? userFilterRegex = null;
        var lastDays = 7;
        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("6kgkyVWPgmyLUzCcVoWYOMpUY9VWnol/zkg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qzpDvDjq7Bg=")[iii % 8])).ToArray()));
                yield break;
            }
        }
        else
        {
            if (!Runtime.FilterResults)
            {
                lastDays = 30;
            }
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("T7xcnpHStUt18l6TkdvwXG78HbGIxOEfeLcdnZOX9Ft3u1OVjsPnXm69T9I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GtI9/P23lT8=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("XRvW7fPVuCslRJGhuv6ne30bxvDum5x5dBbA9+7SvmcxN9P89M+sKzxS5LnqybBodAHWufbUuGx0FoX29JuqeHgcwrnq175ifwbA4e6bvHl0FsD37tK+Z2I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EXKlmZq73ws=")[iii % 8])).ToArray()));
        if (args.Length >= 2)
        {
            userFilterRegex = args[1];
            WriteHost($"Username Filter: {userFilterRegex}");
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("osC5LCPXNlaCx6A9Ipk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7bXNXFajFhA=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("4I7YE+WYfT+yyZBKnctMLOz+h1Gr3VotksuGS6TMWnKT25dUrdtdC7PLhxKByGg6pNyQTbuYBHPt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wK71Psi4KV4=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("BWEZlQRZX4YFNU20RU5IkEEkS6UMTFbVUiBW8RBeX5EFNUrxCUJdmkt/L9s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JUEl0WUtOvU=")[iii % 8])).ToArray()));
        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"*[System/EventID={eventId}] and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("p+DdBTYb3D8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9IW+cERyqEY=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var subjectUserName = eventDetail.Properties[1].Value.ToString();
            var subjectDomainName = eventDetail.Properties[2].Value.ToString();
            var targetUserName = eventDetail.Properties[5].Value.ToString();
            var targetDomainName = eventDetail.Properties[6].Value.ToString();
            var processName = eventDetail.Properties[11].Value.ToString();
            var ipAddress = eventDetail.Properties[12].Value.ToString();
            if (Runtime.FilterResults && Regex.IsMatch(targetUserName, Environment.MachineName) || Regex.IsMatch(targetDomainName, Encoding.UTF8.GetString(Convert.FromBase64String("Dz1oHOIQJ1AjfFgW/kRPeyJhUiTlCmN7JjVjEuIFYHEjPAo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("URUuc4xkBxQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            if (userFilterRegex != null && !Regex.IsMatch(targetUserName, userFilterRegex))
                continue;
            yield return new O_B860970F()
            {
                TimeCreatedUtc = eventDetail.TimeCreated?.ToUniversalTime(),
                SubjectUser = subjectUserName,
                SubjectDomain = subjectDomainName,
                TargetUser = targetUserName,
                TargetDomain = targetDomainName,
                Process = processName,
                IpAddress = ipAddress
            };
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string CYlSipSA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                    instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        const string eventId = "4648";
        string? userFilterRegex = null;
        var lastDays = 7;
        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("6kgkyVWPgmyLUzCcVoWYOMpUY9VWnol/zkg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qzpDvDjq7Bg=")[iii % 8])).ToArray()));
                yield break;
            }
        }
        else
        {
            if (!Runtime.FilterResults)
            {
                lastDays = 30;
            }
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("T7xcnpHStUt18l6TkdvwXG78HbGIxOEfeLcdnZOX9Ft3u1OVjsPnXm69T9I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GtI9/P23lT8=")[iii % 8])).ToArray()));
            yield break;
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("XRvW7fPVuCslRJGhuv6ne30bxvDum5x5dBbA9+7SvmcxN9P89M+sKzxS5LnqybBodAHWufbUuGx0FoX29JuqeHgcwrnq175ifwbA4e6bvHl0FsD37tK+Z2I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EXKlmZq73ws=")[iii % 8])).ToArray()));
        if (args.Length >= 2)
        {
            userFilterRegex = args[1];
            WriteHost($"Username Filter: {userFilterRegex}");
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("osC5LCPXNlaCx6A9Ipk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7bXNXFajFhA=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("4I7YE+WYfT+yyZBKnctMLOz+h1Gr3VotksuGS6TMWnKT25dUrdtdC7PLhxKByGg6pNyQTbuYBHPt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wK71Psi4KV4=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("BWEZlQRZX4YFNU20RU5IkEEkS6UMTFbVUiBW8RBeX5EFNUrxCUJdmkt/L9s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JUEl0WUtOvU=")[iii % 8])).ToArray()));
        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"*[System/EventID={eventId}] and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("p+DdBTYb3D8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9IW+cERyqEY=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var subjectUserName = eventDetail.Properties[1].Value.ToString();
            var subjectDomainName = eventDetail.Properties[2].Value.ToString();
            var targetUserName = eventDetail.Properties[5].Value.ToString();
            var targetDomainName = eventDetail.Properties[6].Value.ToString();
            var processName = eventDetail.Properties[11].Value.ToString();
            var ipAddress = eventDetail.Properties[12].Value.ToString();
            if (Runtime.FilterResults && Regex.IsMatch(targetUserName, Environment.MachineName) || Regex.IsMatch(targetDomainName, Encoding.UTF8.GetString(Convert.FromBase64String("Dz1oHOIQJ1AjfFgW/kRPeyJhUiTlCmN7JjVjEuIFYHEjPAo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("URUuc4xkBxQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            if (userFilterRegex != null && !Regex.IsMatch(targetUserName, userFilterRegex))
                continue;
            yield return new O_B860970F()
            {
                TimeCreatedUtc = eventDetail.TimeCreated?.ToUniversalTime(),
                SubjectUser = subjectUserName,
                SubjectDomain = subjectDomainName,
                TargetUser = targetUserName,
                TargetDomain = targetDomainName,
                Process = processName,
                IpAddress = ipAddress
            };
        }
    }
}}