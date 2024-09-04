using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_8D64AA06 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("CSBbSikaecYhNkZxOC1/2TwnRg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SFU/I11KFqo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("/u2fpzuRKdHL7JKgKMJ6wtb527on1HrG2v+SvTvDIw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v5j7zk+xWrQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_8D64AA06(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("yz+GfdD3lSzEHYlq1fmUJv4kvF7O+IMm7yO8StLklSz2JLZs1eWOJvYMsGbL/4Qg/SO8Wt7lkyz1DKF8w/+T").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mFDgCaeW50k=")[iii % 8])).ToArray()));
        if (settings == null)
            yield break;
        foreach (var kvp in settings)
        {
            if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType()?.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("0UT/3rXfyPb2T+XEtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gj2MqtCy5qU=")[iii % 8])).ToArray())))
            {
                var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("QA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bH0lu3rsSoE=")[iii % 8])).ToArray()), (string[])kvp.Value);
                yield return new O_371534EF(kvp.Key, result);
            }
            else
            {
                yield return new O_371534EF(kvp.Key, $"{kvp.Value}");
            }
        }
    }

internal class O_371534EF : O_4AED570F
{
    public O_371534EF(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}    [CommandOutputType(typeof(O_371534EF))]
    internal class O_3ABDBA24 : TextFormatterBase
    {
        public O_3ABDBA24(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_371534EF)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B7vj+XyNfFNau6LpK5Ey").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J5uYyVCgT2M=")[iii % 8])).ToArray()), dto.Key, dto.Value);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string etXQooBs)
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

            var dto = (O_371534EF)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B7vj+XyNfFNau6LpK5Ey").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J5uYyVCgT2M=")[iii % 8])).ToArray()), dto.Key, dto.Value);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string BQqhDOWK)
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

        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("yz+GfdD3lSzEHYlq1fmUJv4kvF7O+IMm7yO8StLklSz2JLZs1eWOJvYMsGbL/4Qg/SO8Wt7lkyz1DKF8w/+T").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mFDgCaeW50k=")[iii % 8])).ToArray()));
        if (settings == null)
            yield break;
        foreach (var kvp in settings)
        {
            if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType()?.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("0UT/3rXfyPb2T+XEtw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gj2MqtCy5qU=")[iii % 8])).ToArray())))
            {
                var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("QA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bH0lu3rsSoE=")[iii % 8])).ToArray()), (string[])kvp.Value);
                yield return new O_371534EF(kvp.Key, result);
            }
            else
            {
                yield return new O_371534EF(kvp.Key, $"{kvp.Value}");
            }
        }
    }
}}