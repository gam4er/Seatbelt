using System;
using System.Collections.Generic;
using System.Linq;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using static O_F41F88FA.Interop.O_B81255AD;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_08D39204 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("GNUWLbe3hBYhygY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VLp1TNvw9nk=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("WF8G+LPMs5RvEAS6tcCvwHFCB6Cm0u/ANB0OoLrN4cByWRulusC6kzZRBLn2xrGPY0Ab9f7AsYdjXQ27ooH+3TZTB7im1LeFZF4JuLOBt482VQagu8SxgWJVQQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FjBo1dahw+A=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_08D39204(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string? computerName = null;
        if (!String.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length >= 1)
        {
            computerName = args[0];
        }

        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("d8RvMKmQTghAi01yr5xSXH7Zbmi8jh5UWMVlPaGYUx5c2XJ1pY1NVTOh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OasBHcz9Pnw=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("k7w8zT23F/K+8BefHq0E4PL4MYMV+Bn2v7I1nwKwHeOh+Vrn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0tBQ7XHYdJM=")[iii % 8])).ToArray()));
        foreach (var group in GetLocalGroups(computerName))
        {
            var members = GetLocalGroupMembers(computerName, group.name)?.ToList();
            if (members != null && members.Any())
            {
                yield return new O_8DE39670(computerName ?? Environment.MachineName, group.name, group.comment, members);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string RIFBFBTl)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetDaysInMonth(34, 15, 9);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string? computerName = null;
        if (!String.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length >= 1)
        {
            computerName = args[0];
        }

        WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("d8RvMKmQTghAi01yr5xSXH7Zbmi8jh5UWMVlPaGYUx5c2XJ1pY1NVTOh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OasBHcz9Pnw=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("k7w8zT23F/K+8BefHq0E4PL4MYMV+Bn2v7I1nwKwHeOh+Vrn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0tBQ7XHYdJM=")[iii % 8])).ToArray()));
        foreach (var group in GetLocalGroups(computerName))
        {
            var members = GetLocalGroupMembers(computerName, group.name)?.ToList();
            if (members != null && members.Any())
            {
                yield return new O_8DE39670(computerName ?? Environment.MachineName, group.name, group.comment, members);
            }
        }
    }
}internal class O_8DE39670 : O_4AED570F
{
    public O_8DE39670(string computerName, string groupName, string groupComment, IEnumerable<Principal> members)
    {
        ComputerName = computerName;
        GroupName = groupName;
        GroupComment = groupComment;
        Members = members;
    }

    public string ComputerName { get; }
    public string GroupName { get; }
    public string GroupComment { get; }
    public IEnumerable<Principal> Members { get; }
}
    [CommandOutputType(typeof(O_8DE39670))]
    internal class O_BF3DA0AC : TextFormatterBase
    {
        public O_BF3DA0AC(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            if (result == null)
            {
                return;
            }

            var dto = (O_8DE39670)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kPaxFZSUKijsrapClMUwdZitqUKd5Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sNabP7TvGlU=")[iii % 8])).ToArray()), dto.ComputerName, dto.GroupName, dto.GroupComment);
            if (dto.Members != null)
            {
                foreach (var member in dto.Members)
                {
                    WriteLine($"  {member.Class, -15} {member.Domain + Encoding.UTF8.GetString(Convert.FromBase64String("0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jr/8L1Kv3hU=")[iii % 8])).ToArray()) + member.User, -40} {member.Sid}");
                }
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string iywhfGKi)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                        instance.GetDaysInMonth(34, 15, 9);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (result == null)
            {
                return;
            }

            var dto = (O_8DE39670)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kPaxFZSUKijsrapClMUwdZitqUKd5Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sNabP7TvGlU=")[iii % 8])).ToArray()), dto.ComputerName, dto.GroupName, dto.GroupComment);
            if (dto.Members != null)
            {
                foreach (var member in dto.Members)
                {
                    WriteLine($"  {member.Class, -15} {member.Domain + Encoding.UTF8.GetString(Convert.FromBase64String("0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jr/8L1Kv3hU=")[iii % 8])).ToArray()) + member.User, -40} {member.Sid}");
                }
            }

            WriteLine();
        }
    }
}