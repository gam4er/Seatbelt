#nullable disable
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs
{
internal class O_320E2CBC : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("aYGfiDAgnfFXq56ILDGK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Oe7o7UJF+b4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("fx2QEQSH7dFDHNINB5aowA0LkRYOl7jcSFiQHxiWqZBCFtIKA5bt41QLhhsG06jGSBaGXgecqpBoMbYNS8LhkBxK3l5awOGQGUreXgqdqZAbSMJGRdOJ1UsZhxIf06LWDU/SGgqKvpwNGYAZHp6o3llYz0NLn6zDWViqXg+StMMD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LXjyfmvzzbA=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_320E2CBC(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var lastDays = 7;
        if (!Runtime.FilterResults)
        {
            lastDays = 30;
        }

        if (args.Length == 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("aC2wiTXsrKJfYrWEI7+n7UU3qIc0vg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K0LF5VHMws0=")[iii % 8])).ToArray()));
                yield break;
            }
        }

        WriteHost($"Collecting kernel boot (EID 12) and shutdown (EID 13) events from the last {lastDays} days\n");
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("sXykKIbZoJiuffMIgtmqzJIz+xmd0aGYiGDzIZvfpdTBZ7ogkZU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4RPTTfS8xLg=")[iii % 8])).ToArray()));
        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"
((*[System[(EventID=12 or EventID=13) and Provider[@Name='Microsoft-Windows-Kernel-General']]] or *[System/EventID=42]) or (*[System/EventID=6008]) or (*[System/EventID=1] and *[System[Provider[@Name='Microsoft-Windows-Power-Troubleshooter']]])) and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]
";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("424xmnSL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sBdC7hHm2gE=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            string action = null;
            switch (eventDetail.Id)
            {
                case 1:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("R4c2Jgk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JvBXTWzHOxs=")[iii % 8])).ToArray());
                    break;
                case 12:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("8V4AIbvZHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("giphU8+sbOM=")[iii % 8])).ToArray());
                    break;
                case 13:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("LUjcMIiVaSM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XiCpROz6Hk0=")[iii % 8])).ToArray());
                    break;
                case 42:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("7knM3c8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nSWpuL96S10=")[iii % 8])).ToArray());
                    break;
                case 6008:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("dLCvverjg3IvjbSs9vyRf3O9vprm+YB4aK+04A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B9jayY6M9Bw=")[iii % 8])).ToArray());
                    break;
            }

            yield return new O_170053FD()
            {
                DateUtc = (DateTime)eventDetail.TimeCreated?.ToUniversalTime(),
                Description = action
            };
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string GNNuqvfW)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxCharCount(12);
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
            lastDays = 30;
        }

        if (args.Length == 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("aC2wiTXsrKJfYrWEI7+n7UU3qIc0vg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K0LF5VHMws0=")[iii % 8])).ToArray()));
                yield break;
            }
        }

        WriteHost($"Collecting kernel boot (EID 12) and shutdown (EID 13) events from the last {lastDays} days\n");
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("sXykKIbZoJiuffMIgtmqzJIz+xmd0aGYiGDzIZvfpdTBZ7ogkZU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4RPTTfS8xLg=")[iii % 8])).ToArray()));
        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"
((*[System[(EventID=12 or EventID=13) and Provider[@Name='Microsoft-Windows-Kernel-General']]] or *[System/EventID=42]) or (*[System/EventID=6008]) or (*[System/EventID=1] and *[System[Provider[@Name='Microsoft-Windows-Power-Troubleshooter']]])) and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]
";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("424xmnSL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sBdC7hHm2gE=")[iii % 8])).ToArray()), query);
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            string action = null;
            switch (eventDetail.Id)
            {
                case 1:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("R4c2Jgk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JvBXTWzHOxs=")[iii % 8])).ToArray());
                    break;
                case 12:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("8V4AIbvZHA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("giphU8+sbOM=")[iii % 8])).ToArray());
                    break;
                case 13:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("LUjcMIiVaSM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XiCpROz6Hk0=")[iii % 8])).ToArray());
                    break;
                case 42:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("7knM3c8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nSWpuL96S10=")[iii % 8])).ToArray());
                    break;
                case 6008:
                    action = Encoding.UTF8.GetString(Convert.FromBase64String("dLCvverjg3IvjbSs9vyRf3O9vprm+YB4aK+04A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B9jayY6M9Bw=")[iii % 8])).ToArray());
                    break;
            }

            yield return new O_170053FD()
            {
                DateUtc = (DateTime)eventDetail.TimeCreated?.ToUniversalTime(),
                Description = action
            };
        }
    }
}internal class O_170053FD : O_4AED570F
{
    public DateTime DateUtc { get; set; }
    public string Description { get; set; }
}
    [CommandOutputType(typeof(O_170053FD))]
    internal class O_063D37B2 : TextFormatterBase
    {
        private string _currentDay = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A++a78bcmow=")[iii % 8])).ToArray());
        public O_063D37B2(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_170053FD)result;
            if (_currentDay != dto.DateUtc.ToShortDateString())
            {
                _currentDay = dto.DateUtc.ToShortDateString();
                WriteLine();
            }

            WriteLine($"  {dto.DateUtc.ToLocalTime(), -23} :  {dto.Description}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string SgXsDlTJ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxCharCount(12);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_170053FD)result;
            if (_currentDay != dto.DateUtc.ToShortDateString())
            {
                _currentDay = dto.DateUtc.ToShortDateString();
                WriteLine();
            }

            WriteLine($"  {dto.DateUtc.ToLocalTime(), -23} :  {dto.Description}");
        }
    }
}
#nullable enable
