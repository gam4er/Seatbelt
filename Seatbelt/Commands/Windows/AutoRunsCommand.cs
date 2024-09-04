#nullable disable
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
internal class O_D8B1EF8E : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("GF3md4dbIJs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WSiSGNUuTug=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("KhKz5/GNROVLAr/tsopF6gkLovv+jFL5Ahez+/6PQ+QMFablog==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a2fHiNH/MYs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_D8B1EF8E(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string[] autorunLocations = new string[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("vi+Ba/S+l9+xLa5c0ZC29YsUm2jKkaH1mhObfNaNt/+DFJFa0Yys9YM8lUrN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WDHP6P/xZo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("Ha63V3ueURISrJhgXrBwOCiVrVRFsWc4OZKtQFmtcTIgladmXqxqOCC9o3ZCkG00Kw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TuHxAyzfA1c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("Y5ZTrjzVSbJsjnqNXaAoxX62cZ832XKUQrZmlQ3gR6BZt3GVHOdHtEWrZ58F4E2SQqp8lQXISYJe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MNkV+muUG/c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("PNcMQlokgxIzzyVhO1HiZSH3LnNRKLg0Hfc5eWsRjQAG9i55ehaNFBrqOHNjEYcyHesjeWM5gyIB1yR1aA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b5hKFg1l0Vc=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("G5vKQSJmBvsUmeV2B0gn0S6g0EIcSTDRP6fQVgBVJtsmoNpwB1Q90SaI3mAbdDHMPr3vcA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SNSMFXUnVL4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("AynDJYNHt0EMK+wSpmmWazYS2Sa9aIFrJxXZMqF0l2E+EtMUpnWMaz461wS6SYtnNTXgA6JvhmE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UGaFcdQG5QQ=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("3JU9GJlFKOXTjRQ7+DBJksG1HymSSRPD/bUII6hwJvfmtB8juXcm4/qoCSmgcCzF/akSI6BYKNXhiR4+uG0ZxQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j9p7TM4EeqA=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("wQOJNhRX4vHOG6AVdSKDhtwjqwcfW9nX4CO8DSVi7OP7IqsNNGXs9+c+vQctYubR4D+mDS1K4sH8A6EBJkXVxuQlrAc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kkzPYkMWsLQ=")[iii % 8])).ToArray())
        };
        foreach (string autorunLocation in autorunLocations)
        {
            var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, autorunLocation);
            if ((settings != null) && (settings.Count != 0))
            {
                O_38A99EC8 entry = new O_38A99EC8();
                entry.Key = System.String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("uZcs4D2VHRGM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8dxgrQfJZiE=")[iii % 8])).ToArray()), autorunLocation);
                entry.Entries = new List<string>();
                foreach (KeyValuePair<string, object> kvp in settings)
                {
                    entry.Entries.Add(kvp.Value.ToString());
                }

                yield return entry;
            }
        }
    }

internal class O_38A99EC8 : O_4AED570F
{
    public string Key { get; set; }
    public List<string> Entries { get; set; }
}    [CommandOutputType(typeof(O_38A99EC8))]
    internal class O_45A50CF0 : TextFormatterBase
    {
        public O_45A50CF0(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_38A99EC8)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("L7Acv0SvqPQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JZA8xHTSiM4=")[iii % 8])).ToArray()), dto.Key);
            foreach (string entry in dto.Entries)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("NGBauWc3IA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FEB6mRwHXZ0=")[iii % 8])).ToArray()), entry);
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string tMknWNlI)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Version instance = new System.Version();
                        instance.ToString(73);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_38A99EC8)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("L7Acv0SvqPQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JZA8xHTSiM4=")[iii % 8])).ToArray()), dto.Key);
            foreach (string entry in dto.Entries)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("NGBauWc3IA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FEB6mRwHXZ0=")[iii % 8])).ToArray()), entry);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string uUsYYXho)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(73);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string[] autorunLocations = new string[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("vi+Ba/S+l9+xLa5c0ZC29YsUm2jKkaH1mhObfNaNt/+DFJFa0Yys9YM8lUrN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WDHP6P/xZo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("Ha63V3ueURISrJhgXrBwOCiVrVRFsWc4OZKtQFmtcTIgladmXqxqOCC9o3ZCkG00Kw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TuHxAyzfA1c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("Y5ZTrjzVSbJsjnqNXaAoxX62cZ832XKUQrZmlQ3gR6BZt3GVHOdHtEWrZ58F4E2SQqp8lQXISYJe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MNkV+muUG/c=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("PNcMQlokgxIzzyVhO1HiZSH3LnNRKLg0Hfc5eWsRjQAG9i55ehaNFBrqOHNjEYcyHesjeWM5gyIB1yR1aA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b5hKFg1l0Vc=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("G5vKQSJmBvsUmeV2B0gn0S6g0EIcSTDRP6fQVgBVJtsmoNpwB1Q90SaI3mAbdDHMPr3vcA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SNSMFXUnVL4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("AynDJYNHt0EMK+wSpmmWazYS2Sa9aIFrJxXZMqF0l2E+EtMUpnWMaz461wS6SYtnNTXgA6JvhmE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UGaFcdQG5QQ=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("3JU9GJlFKOXTjRQ7+DBJksG1HymSSRPD/bUII6hwJvfmtB8juXcm4/qoCSmgcCzF/akSI6BYKNXhiR4+uG0ZxQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j9p7TM4EeqA=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("wQOJNhRX4vHOG6AVdSKDhtwjqwcfW9nX4CO8DSVi7OP7IqsNNGXs9+c+vQctYubR4D+mDS1K4sH8A6EBJkXVxuQlrAc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kkzPYkMWsLQ=")[iii % 8])).ToArray())
        };
        foreach (string autorunLocation in autorunLocations)
        {
            var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, autorunLocation);
            if ((settings != null) && (settings.Count != 0))
            {
                O_38A99EC8 entry = new O_38A99EC8();
                entry.Key = System.String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("uZcs4D2VHRGM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8dxgrQfJZiE=")[iii % 8])).ToArray()), autorunLocation);
                entry.Entries = new List<string>();
                foreach (KeyValuePair<string, object> kvp in settings)
                {
                    entry.Entries.Add(kvp.Value.ToString());
                }

                yield return entry;
            }
        }
    }
}}
#nullable enable
