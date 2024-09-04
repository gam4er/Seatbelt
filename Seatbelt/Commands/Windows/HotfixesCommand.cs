using System;
using System.Collections.Generic;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_D72AD724 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("IL50RWKMP+M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aNEAIwv0WpA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("k0P+aTn4Igm+DeVyLPInFL9erTUu/S9MjWDENA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2i2NHViUTmw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_D72AD724(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("IkC1G5hxhJAOQKdWqmqLgAhZs1a1bJGCDlalBdMjo4sVDuoXkW/PxCpHowSScIqCEw61BplikYEUAuADjmbFkA9L4FGwaoaWCF2vEIlWlYAGWqUF2iOGiwpDoRiZLeju").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zy7Adv0D5eQ=")[iii % 8])).ToArray()));
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("tHOB3aGD8QiwLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xhzuqf3gmGU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/Ir2C3pY8GCPiegBdCyHI8H8iBFoebkpxInTNnxityPBqt88UGK3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r8+6TjkM0Eo=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        foreach (var hotfix in data)
        {
            DateTime? InstalledOn;
            try
            {
                InstalledOn = Convert.ToDateTime(hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("m+gbAVGRVWe2yQY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0oZodTD9OQI=")[iii % 8])).ToArray())].ToString()).ToUniversalTime();
            }
            catch
            {
                InstalledOn = null;
            }

            yield return new O_CF740C91(hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("y2D8e4ZRYxc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gw+IPe8pKlM=")[iii % 8])).ToArray())].ToString(), InstalledOn, hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("TJZ+bUjwf61hnGM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CPMNDjqZD9k=")[iii % 8])).ToArray())].ToString(), hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("8gKzGEhhQ2zfLrk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u2zAbCkNLwk=")[iii % 8])).ToArray())].ToString());
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string IPaRcQdT)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(17);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("IkC1G5hxhJAOQKdWqmqLgAhZs1a1bJGCDlalBdMjo4sVDuoXkW/PxCpHowSScIqCEw61BplikYEUAuADjmbFkA9L4FGwaoaWCF2vEIlWlYAGWqUF2iOGiwpDoRiZLeju").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zy7Adv0D5eQ=")[iii % 8])).ToArray()));
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("tHOB3aGD8QiwLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xhzuqf3gmGU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/Ir2C3pY8GCPiegBdCyHI8H8iBFoebkpxInTNnxityPBqt88UGK3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r8+6TjkM0Eo=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        foreach (var hotfix in data)
        {
            DateTime? InstalledOn;
            try
            {
                InstalledOn = Convert.ToDateTime(hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("m+gbAVGRVWe2yQY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0oZodTD9OQI=")[iii % 8])).ToArray())].ToString()).ToUniversalTime();
            }
            catch
            {
                InstalledOn = null;
            }

            yield return new O_CF740C91(hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("y2D8e4ZRYxc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gw+IPe8pKlM=")[iii % 8])).ToArray())].ToString(), InstalledOn, hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("TJZ+bUjwf61hnGM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CPMNDjqZD9k=")[iii % 8])).ToArray())].ToString(), hotfix[Encoding.UTF8.GetString(Convert.FromBase64String("8gKzGEhhQ2zfLrk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u2zAbCkNLwk=")[iii % 8])).ToArray())].ToString());
        }
    }
}internal class O_CF740C91 : O_4AED570F
{
    public O_CF740C91(string hotFixID, DateTime? installedOnUTC, string description, string installedBy)
    {
        HotFixID = hotFixID;
        InstalledOnUTC = installedOnUTC;
        Description = description;
        InstalledBy = installedBy;
    }

    public string HotFixID { get; set; }
    public DateTime? InstalledOnUTC { get; set; }
    public string Description { get; set; }
    public string InstalledBy { get; set; }
}
    [CommandOutputType(typeof(O_CF740C91))]
    internal class O_0A4167C7 : TextFormatterBase
    {
        public O_0A4167C7(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_CF740C91)result;
            WriteLine($"  {dto.HotFixID, -10} {dto.InstalledOnUTC?.ToLocalTime(), -22} {dto.Description, -30} {dto.InstalledBy}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string kUtXCyMe)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(17);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_CF740C91)result;
            WriteLine($"  {dto.HotFixID, -10} {dto.InstalledOnUTC?.ToLocalTime(), -22} {dto.Description, -30} {dto.InstalledBy}");
        }
    }
}