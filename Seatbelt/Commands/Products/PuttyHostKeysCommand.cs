using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_B7C59DF4 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("YXrvZDJvsApFRP5pOA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MQ+bEEsn33k=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("c14axMQknaJUSxWB81eF90hQH9WAb6iuUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ID9soaAEzdc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_B7C59DF4(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("nO9TMd0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z8JiHOiJVHs=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9nPnuRpA2/A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qTCL2GkzvoM=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var hostKeys = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\SshHostKeys\\");
            if (hostKeys == null || hostKeys.Count == 0)
            {
                continue;
            }

            var keys = new List<string>();
            foreach (var kvp in hostKeys)
            {
                keys.Add($"{kvp.Key}");
            }

            yield return new O_FBA13A79(sid, keys);
        }
    }

internal class O_FBA13A79 : O_4AED570F
{
    public O_FBA13A79(string sid, List<string> hostKeys)
    {
        Sid = sid;
        HostKeys = hostKeys;
    }

    public string Sid { get; }
    public List<string> HostKeys { get; }
}    [CommandOutputType(typeof(O_FBA13A79))]
    internal class O_94412494 : TextFormatterBase
    {
        public O_94412494(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_FBA13A79)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qImR8Z0rnQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKnqweALp68=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var hostKey in dto.HostKeys)
            {
                WriteLine($"    {hostKey}");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string PXmBcPhW)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                        instance.ToFourDigitYear(16);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_FBA13A79)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qImR8Z0rnQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKnqweALp68=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var hostKey in dto.HostKeys)
            {
                WriteLine($"    {hostKey}");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string IsewVyTu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                    instance.ToFourDigitYear(16);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("nO9TMd0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z8JiHOiJVHs=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9nPnuRpA2/A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qTCL2GkzvoM=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var hostKeys = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\Software\\SimonTatham\\PuTTY\\SshHostKeys\\");
            if (hostKeys == null || hostKeys.Count == 0)
            {
                continue;
            }

            var keys = new List<string>();
            foreach (var kvp in hostKeys)
            {
                keys.Add($"{kvp.Key}");
            }

            yield return new O_FBA13A79(sid, keys);
        }
    }
}}