using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static O_F41F88FA.Interop.O_E24FBBBE;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_421BFBD4 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Khxuuxa+iz4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y3gC3kLX5ls=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("01aYbLvkx3T1W4k5p//ZNuRBzHavqscx4lyCfbqqxz3vUIk5veLRdOJGnmus5MB09ECJa+75lDjgQJg5oOTEIfUd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gTPsGcmKtFQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_421BFBD4(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var lastInputInfo = new LastInputInfo();
        lastInputInfo.Size = (uint)Marshal.SizeOf(lastInputInfo);
        if (GetLastInputInfo(ref lastInputInfo))
        {
            var currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            yield return new O_B137EF9D(currentUser, ((uint)Environment.TickCount - lastInputInfo.Time));
        }
        else
        {
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string bEsxZfRX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                    instance.GetMonth(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var lastInputInfo = new LastInputInfo();
        lastInputInfo.Size = (uint)Marshal.SizeOf(lastInputInfo);
        if (GetLastInputInfo(ref lastInputInfo))
        {
            var currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            yield return new O_B137EF9D(currentUser, ((uint)Environment.TickCount - lastInputInfo.Time));
        }
        else
        {
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
    }
}internal class O_B137EF9D : O_4AED570F
{
    public O_B137EF9D(string currentUser, uint milliseconds)
    {
        CurrentUser = currentUser;
        Milliseconds = milliseconds;
    }

    public string CurrentUser { get; }
    public uint Milliseconds { get; }
}
    [CommandOutputType(typeof(O_B137EF9D))]
    internal class O_7AAC72A0 : TextFormatterBase
    {
        public O_7AAC72A0(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_B137EF9D)result;
            var t = TimeSpan.FromMilliseconds(dto.Milliseconds);
            var idleTime = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JBOAET6iO1YkEoARPqI+ViQRgBE+oiBWJBCAET+iPh8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XyO6VQzfU2w=")[iii % 8])).ToArray()), t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            WriteLine($"  CurrentUser : {dto.CurrentUser}");
            WriteLine($"  Idletime    : {idleTime} ({dto.Milliseconds} milliseconds)\n");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string tUUFBwLO)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                        instance.GetMonth(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_B137EF9D)result;
            var t = TimeSpan.FromMilliseconds(dto.Milliseconds);
            var idleTime = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JBOAET6iO1YkEoARPqI+ViQRgBE+oiBWJBCAET+iPh8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XyO6VQzfU2w=")[iii % 8])).ToArray()), t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
            WriteLine($"  CurrentUser : {dto.CurrentUser}");
            WriteLine($"  Idletime    : {idleTime} ({dto.Milliseconds} milliseconds)\n");
        }
    }
}