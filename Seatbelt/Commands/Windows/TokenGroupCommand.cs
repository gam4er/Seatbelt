using System.Collections.Generic;
using System.Security.Principal;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_7C324DFB : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("ZN1qXmS3/IxFwnI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MLIBOwrwjuM=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Gzqj6O/msr4qPLLo+PyrqSF1tejg/KOtI3KnpuizpKMiM6+mrPSyozoitQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T1LGyIyTwMw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_7C324DFB(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Q4UpEpiwy4pUnzAFk/nMikeCNBWNrbU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("APBbYP3ev6o=")[iii % 8])).ToArray()));
        var wi = WindowsIdentity.GetCurrent();
        foreach (var group in wi.Groups)
        {
            var groupName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8/y35YTJa3U=")[iii % 8])).ToArray());
            try
            {
                groupName = group.Translate(typeof(NTAccount)).ToString();
            }
            catch
            {
            }

            yield return new O_64D6C700($"{(SecurityIdentifier)group}", groupName);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ZjtQXlPW)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                    instance.GetDayOfYear(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Q4UpEpiwy4pUnzAFk/nMikeCNBWNrbU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("APBbYP3ev6o=")[iii % 8])).ToArray()));
        var wi = WindowsIdentity.GetCurrent();
        foreach (var group in wi.Groups)
        {
            var groupName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8/y35YTJa3U=")[iii % 8])).ToArray());
            try
            {
                groupName = group.Translate(typeof(NTAccount)).ToString();
            }
            catch
            {
            }

            yield return new O_64D6C700($"{(SecurityIdentifier)group}", groupName);
        }
    }
}internal class O_64D6C700 : O_4AED570F
{
    public O_64D6C700(string groupSid, string groupName)
    {
        GroupSID = groupSid;
        GroupName = groupName;
    }

    public string GroupSID { get; set; }
    public string GroupName { get; set; }
}
    [CommandOutputType(typeof(O_64D6C700))]
    internal class O_744A5642 : TextFormatterBase
    {
        public O_744A5642(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_64D6C700)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TlZjUIfJ+/ETVmNR1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bnYYYKvkz8E=")[iii % 8])).ToArray()), dto.GroupName, dto.GroupSID);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string UcLSThqM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                        instance.GetDayOfYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_64D6C700)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("TlZjUIfJ+/ETVmNR1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bnYYYKvkz8E=")[iii % 8])).ToArray()), dto.GroupName, dto.GroupSID);
        }
    }
}