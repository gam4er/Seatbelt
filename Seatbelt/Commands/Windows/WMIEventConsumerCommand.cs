using System.Collections.Generic;
using System.Management;
using System.Security.Principal;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_DF75625B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("BLcToNn6J0gQlTSW2vIsTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U/pa5a+fSTw=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("jDSSOo2tVzaJfaQ4m+N0W4Myjz2L4GUJsw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wF3hTv6NAHs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_DF75625B(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var opt = new EnumerationOptions();
        opt.EnumerateDeep = true;
        var EventConsumerClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("Aoj9td8Z0dYCh6aL/jXs6y6guobjbMHdG6K2h/kV8ewtob6M/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XtTT6Y1WnoI=")[iii % 8])).ToArray()));
        foreach (ManagementObject EventConsumer in EventConsumerClass.GetInstances(opt))
        {
            var systemprops = EventConsumer.SystemProperties;
            var ConsumerType = $"{systemprops[Encoding.UTF8.GetString(Convert.FromBase64String("hc3pdk4d4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2pKqOg9OsXs=")[iii % 8])).ToArray())].Value}";
            var sidBytes = (byte[])EventConsumer[Encoding.UTF8.GetString(Convert.FromBase64String("9v3i+4EnJu/8yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tY+HmvVIVLw=")[iii % 8])).ToArray())];
            var creatorSid = new SecurityIdentifier(sidBytes, 0);
            var properties = new Dictionary<string, object>();
            foreach (var prop in EventConsumer.Properties)
            {
                if (!prop.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("aU8ZmEoW9jRjeQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Kj18+T55hGc=")[iii % 8])).ToArray())))
                {
                    properties[prop.Name] = prop.Value;
                }
            }

            yield return new O_0D1C2316($"{EventConsumer[Encoding.UTF8.GetString(Convert.FromBase64String("+eOzrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t4LeyXKJ26k=")[iii % 8])).ToArray())]}", creatorSid, ConsumerType, properties);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string OxxtoGYx)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                    instance.GetLeapMonth(28, 96);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var opt = new EnumerationOptions();
        opt.EnumerateDeep = true;
        var EventConsumerClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("Aoj9td8Z0dYCh6aL/jXs6y6guobjbMHdG6K2h/kV8ewtob6M/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XtTT6Y1WnoI=")[iii % 8])).ToArray()));
        foreach (ManagementObject EventConsumer in EventConsumerClass.GetInstances(opt))
        {
            var systemprops = EventConsumer.SystemProperties;
            var ConsumerType = $"{systemprops[Encoding.UTF8.GetString(Convert.FromBase64String("hc3pdk4d4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2pKqOg9OsXs=")[iii % 8])).ToArray())].Value}";
            var sidBytes = (byte[])EventConsumer[Encoding.UTF8.GetString(Convert.FromBase64String("9v3i+4EnJu/8yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tY+HmvVIVLw=")[iii % 8])).ToArray())];
            var creatorSid = new SecurityIdentifier(sidBytes, 0);
            var properties = new Dictionary<string, object>();
            foreach (var prop in EventConsumer.Properties)
            {
                if (!prop.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("aU8ZmEoW9jRjeQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Kj18+T55hGc=")[iii % 8])).ToArray())))
                {
                    properties[prop.Name] = prop.Value;
                }
            }

            yield return new O_0D1C2316($"{EventConsumer[Encoding.UTF8.GetString(Convert.FromBase64String("+eOzrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t4LeyXKJ26k=")[iii % 8])).ToArray())]}", creatorSid, ConsumerType, properties);
        }
    }
}internal class O_0D1C2316 : O_4AED570F
{
    public O_0D1C2316(object name, object consumerType, object creatorSid, object properties)
    {
        Name = name;
        ConsumerType = consumerType;
        CreatorSid = creatorSid;
        Properties = properties;
    }

    public object Name { get; }
    public object ConsumerType { get; }
    public object CreatorSid { get; }
    public object Properties { get; }
}
    [CommandOutputType(typeof(O_0D1C2316))]
    internal class O_FD4BFA91 : TextFormatterBase
    {
        public O_FD4BFA91(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_0D1C2316)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Y3Zx2UsvZt4+dirJRzh1zmMtO5Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q1YK6WcCVe4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("EaQJhA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X8Vk4fiJCuI=")[iii % 8])).ToArray()), dto.Name);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yt1VzO+DjhiX3Q7c45SdCMqGH4E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6v0u/MOuvSg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SnilL0KJxrVdbrs5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRfLXDfko8c=")[iii % 8])).ToArray()), dto.ConsumerType);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("oX7KVya+Z6X8fpFHKql0taElgBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gV6xZwqTVJU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("NGg2ME1y380+Xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dxpTUTkdrZ4=")[iii % 8])).ToArray()), dto.CreatorSid);
            foreach (var kvp in (Dictionary<string, object>)dto.Properties)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("5rDWWLL8ApS7sI1IvusRhObrnBU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xpCtaJ7RMaQ=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string kJGPlcia)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                        instance.GetLeapMonth(28, 96);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_0D1C2316)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Y3Zx2UsvZt4+dirJRzh1zmMtO5Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q1YK6WcCVe4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("EaQJhA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X8Vk4fiJCuI=")[iii % 8])).ToArray()), dto.Name);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yt1VzO+DjhiX3Q7c45SdCMqGH4E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6v0u/MOuvSg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SnilL0KJxrVdbrs5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CRfLXDfko8c=")[iii % 8])).ToArray()), dto.ConsumerType);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("oX7KVya+Z6X8fpFHKql0taElgBo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gV6xZwqTVJU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("NGg2ME1y380+Xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dxpTUTkdrZ4=")[iii % 8])).ToArray()), dto.CreatorSid);
            foreach (var kvp in (Dictionary<string, object>)dto.Properties)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("5rDWWLL8ApS7sI1IvusRhObrnBU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xpCtaJ7RMaQ=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
            }
        }
    }
}