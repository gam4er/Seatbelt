using Microsoft.Win32;
using System;
using System.Collections.Generic;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
    class O_39FC6857
    {
        public O_39FC6857(DateTime time, string url)
        {
            Time = time;
            Url = url;
        }

        public DateTime Time { get; }
        public string Url { get; }
    }
internal class O_ED0B889C : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("qqyG4Bmw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4+nTknXD2Jo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("eZFu+qLVzx0QumLvvNTYDELfbuag3s5JZa1W7PCTxghDizqo8N/LEEPTOv6i3N8EVZFuv+2GigVRjG6/iJvOCEmMMw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MP8an9C7qmk=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_ED0B889C(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var lastDays = 7;
        if (!Runtime.FilterResults)
        {
            lastDays = 90;
        }

        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("Hbgl2pLB+2F8ozGPkcvhNT2kYsaR0PByObg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XMpCr/+klRU=")[iii % 8])).ToArray()));
            }
        }

        var startTime = DateTime.Now.AddDays(-lastDays);
        WriteHost($"Internet Explorer typed URLs for the last {lastDays} days\n");
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("h1eFs/s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1Hq0ns54B9k=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("NBwnJHWtwEk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a19LRQbepTo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var settings = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Internet Explorer\\TypedURLs");
            if ((settings == null) || (settings.Count <= 1))
            {
                continue;
            }

            var URLs = new List<O_39FC6857>();
            foreach (var kvp in settings)
            {
                var timeBytes = ThisRunTime.GetBinaryValue(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Internet Explorer\\TypedURLsTime", kvp.Key.Trim());
                if (timeBytes == null)
                    continue;
                var timeLong = BitConverter.ToInt64(timeBytes, 0);
                var urlTime = DateTime.FromFileTime(timeLong);
                if (urlTime > startTime)
                {
                    URLs.Add(new O_39FC6857(urlTime, kvp.Value.ToString().Trim()));
                }
            }

            yield return new O_BC3E399D(sid, URLs);
        }
    }

internal class O_BC3E399D : O_4AED570F
{
    public O_BC3E399D(string sid, List<O_39FC6857> urls)
    {
        Sid = sid;
        Urls = urls;
    }

    public string Sid { get; }
    public List<O_39FC6857> Urls { get; }
}    [CommandOutputType(typeof(O_BC3E399D))]
    internal class O_7A04870B : TextFormatterBase
    {
        public O_7A04870B(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_BC3E399D)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("l7v4xO76").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZvYv96H+uE=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var url in dto.Urls)
            {
                WriteLine($"    {url.Time, -23} :  {url.Url}");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string qNWwfeRS)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.EncoderExceptionFallbackBuffer instance = new System.Text.EncoderExceptionFallbackBuffer();
                        instance.Fallback('f', 86);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_BC3E399D)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("l7v4xO76").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZvYv96H+uE=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var url in dto.Urls)
            {
                WriteLine($"    {url.Time, -23} :  {url.Url}");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string LtUiKlbL)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.EncoderExceptionFallbackBuffer instance = new System.Text.EncoderExceptionFallbackBuffer();
                    instance.Fallback('f', 86);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var lastDays = 7;
        if (!Runtime.FilterResults)
        {
            lastDays = 90;
        }

        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("Hbgl2pLB+2F8ozGPkcvhNT2kYsaR0PByObg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XMpCr/+klRU=")[iii % 8])).ToArray()));
            }
        }

        var startTime = DateTime.Now.AddDays(-lastDays);
        WriteHost($"Internet Explorer typed URLs for the last {lastDays} days\n");
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("h1eFs/s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1Hq0ns54B9k=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("NBwnJHWtwEk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a19LRQbepTo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var settings = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Internet Explorer\\TypedURLs");
            if ((settings == null) || (settings.Count <= 1))
            {
                continue;
            }

            var URLs = new List<O_39FC6857>();
            foreach (var kvp in settings)
            {
                var timeBytes = ThisRunTime.GetBinaryValue(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Internet Explorer\\TypedURLsTime", kvp.Key.Trim());
                if (timeBytes == null)
                    continue;
                var timeLong = BitConverter.ToInt64(timeBytes, 0);
                var urlTime = DateTime.FromFileTime(timeLong);
                if (urlTime > startTime)
                {
                    URLs.Add(new O_39FC6857(urlTime, kvp.Value.ToString().Trim()));
                }
            }

            yield return new O_BC3E399D(sid, URLs);
        }
    }
}}