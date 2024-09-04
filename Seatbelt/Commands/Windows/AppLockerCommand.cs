#nullable disable
using Microsoft.Win32;
using O_F41F88FA.Util;
using System.Collections.Generic;
using System.Management;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_6FA04BA2 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Vzgl598VLLBk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FkhVq7B2R9U=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Jk7ie+Md/moVHuFS+Ar8YQBNvhflGLVmCU3mVuAS8Gs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zz6SN4x+lQ8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_6FA04BA2(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("t+Ttw1axy32zuQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xYuCtwrSohA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gIrLE61OseeyouJ6zknlyKeqpxC8VdyJpKbpZdxF4syhue41izrG4Zadwnage/zM8/Knca9q4eCXnPE1yQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("08+HVu4akak=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        string appIdSvcState = Encoding.UTF8.GetString(Convert.FromBase64String("HvYBEis1jM4j/AdEJDmcgCk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZNzZEJW6e4=")[iii % 8])).ToArray());
        var rules = new List<string>();
        foreach (var o in data)
        {
            var result = (ManagementObject)o;
            appIdSvcState = result[Encoding.UTF8.GetString(Convert.FromBase64String("nzCbO5E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zET6T/SkCQ4=")[iii % 8])).ToArray())].ToString();
        }

        var keys = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("0mSatve7Gs7dW5Ou6bkBzvJXsavjqAfY7m2IntezBs/ufI+e06gY/bM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gQv8woDaaKs=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        if (keys != null && keys.Length != 0)
        {
            foreach (var key in keys)
            {
                var keyName = key;
                var enforcementMode = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"Software\\Policies\\Microsoft\\Windows\\SrpV2\\{key}", Encoding.UTF8.GetString(Convert.FromBase64String("+doBiI0olTHZ2hOqkC+V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vLRn5/9L8Fw=")[iii % 8])).ToArray()));
                var enforcementModeStr = enforcementMode switch
                {
                    null => Encoding.UTF8.GetString(Convert.FromBase64String("THyam6isgZdLdJvJrqc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IhPuu8vD7/E=")[iii % 8])).ToArray()),
                    0 => Encoding.UTF8.GetString(Convert.FromBase64String("6UMEzOVuA1PMUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qDZgpZFOTjw=")[iii % 8])).ToArray()),
                    1 => Encoding.UTF8.GetString(Convert.FromBase64String("I/efw+3i3c0r9p3J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zpn5rJ+BuO0=")[iii % 8])).ToArray()),
                    _ => $"Unknown value {enforcementMode}"};
                var ids = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("fNV4UD7M3exz6nFIIM7G7FzmU00q38D6QNxqeB7Ewe1AzW14Gt/f3x3m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7oeJEmtr4k=")[iii % 8])).ToArray()) + key);
                foreach (var id in ids)
                {
                    var rule = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"Software\\Policies\\Microsoft\\Windows\\SrpV2\\{key}\\{id}", Encoding.UTF8.GetString(Convert.FromBase64String("apm3gOY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PPjb9YMX4yM=")[iii % 8])).ToArray()));
                    rules.Add(rule);
                }

                yield return new O_81B62776(configured: true, appIdSvcState, keyName, enforcementModeStr, rules);
            }
        }
        else
        {
            yield return new O_81B62776(configured: false, appIdSvcState, keyName: null, enforcementMode: null, rules: null);
        }
    }

internal class O_81B62776 : O_4AED570F
{
    public O_81B62776(bool configured, string appIdSvcState, string? keyName, string? enforcementMode, List<string>? rules)
    {
        Configured = configured;
        AppIdSvcState = appIdSvcState;
        KeyName = keyName;
        EnforcementMode = enforcementMode;
        Rules = rules;
    }

    public bool Configured { get; }
    public string AppIdSvcState { get; }
    public string? KeyName { get; }
    public string? EnforcementMode { get; }
    public List<string>? Rules { get; }
}    [CommandOutputType(typeof(O_81B62776))]
    internal class O_B771F1FF : TextFormatterBase
    {
        public O_B771F1FF(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_81B62776)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("J0LNxNKU1FB3K9K9+de1U2IQ4Ifs0bVJdELt3vK+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B2KW7o+0lSA=")[iii % 8])).ToArray()), dto.AppIdSvcState);
            if (dto.AppIdSvcState != Encoding.UTF8.GetString(Convert.FromBase64String("D4ot8NUN8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xf9DnrxjlG0=")[iii % 8])).ToArray()))
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Pr0KAoFrC45f7VpOtSI9y2y9Q1H6LznaPu9fTLQoOMk+/09BuzQlyz7pQkf6ACbeV9l5VLlhP90+80VW+jMjwHD0REXQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hp0qItpBVq4=")[iii % 8])).ToArray()));
            if (!dto.Configured)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6iA51ynwjMe6TA2eH7W/l6RvFt0Xv6PRo2cXjxG0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ygBi/XTQzbc=")[iii % 8])).ToArray()));
            }
            else if (dto.EnforcementMode.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("xY2AgDannGHChYHSMKw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+L0oFXI8gc=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6R3X7oAMQXuyDYrutUloe6pSmaiyQWkprFk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yT33ztsmHFs=")[iii % 8])).ToArray()), dto.KeyName);
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6CGRt0wMINrCeoHqTD55p4tvkexdKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4gGxl2xXCoc=")[iii % 8])).ToArray()), dto.KeyName, dto.EnforcementMode);
                if (dto.Rules.Count == 0)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JG+6vtKjKsBZb9Tx0vEEhmE8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BE+anvKDceo=")[iii % 8])).ToArray()));
                }
                else
                {
                    foreach (var rule in dto.Rules)
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LDFPUziUXvxRMRRDZQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DBFvcxi0BdY=")[iii % 8])).ToArray()), rule);
                    }
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string sPJfBNWN)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(88, 78);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_81B62776)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("J0LNxNKU1FB3K9K9+de1U2IQ4Ifs0bVJdELt3vK+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B2KW7o+0lSA=")[iii % 8])).ToArray()), dto.AppIdSvcState);
            if (dto.AppIdSvcState != Encoding.UTF8.GetString(Convert.FromBase64String("D4ot8NUN8w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xf9DnrxjlG0=")[iii % 8])).ToArray()))
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Pr0KAoFrC45f7VpOtSI9y2y9Q1H6LznaPu9fTLQoOMk+/09BuzQlyz7pQkf6ACbeV9l5VLlhP90+80VW+jMjwHD0REXQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hp0qItpBVq4=")[iii % 8])).ToArray()));
            if (!dto.Configured)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6iA51ynwjMe6TA2eH7W/l6RvFt0Xv6PRo2cXjxG0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ygBi/XTQzbc=")[iii % 8])).ToArray()));
            }
            else if (dto.EnforcementMode.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("xY2AgDannGHChYHSMKw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+L0oFXI8gc=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6R3X7oAMQXuyDYrutUloe6pSmaiyQWkprFk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yT33ztsmHFs=")[iii % 8])).ToArray()), dto.KeyName);
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("6CGRt0wMINrCeoHqTD55p4tvkexdKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4gGxl2xXCoc=")[iii % 8])).ToArray()), dto.KeyName, dto.EnforcementMode);
                if (dto.Rules.Count == 0)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JG+6vtKjKsBZb9Tx0vEEhmE8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BE+anvKDceo=")[iii % 8])).ToArray()));
                }
                else
                {
                    foreach (var rule in dto.Rules)
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LDFPUziUXvxRMRRDZQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DBFvcxi0BdY=")[iii % 8])).ToArray()), rule);
                    }
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string toCSleZZ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                    instance.SubstringByTextElements(88, 78);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("t+Ttw1axy32zuQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xYuCtwrSohA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gIrLE61OseeyouJ6zknlyKeqpxC8VdyJpKbpZdxF4syhue41izrG4Zadwnage/zM8/Knca9q4eCXnPE1yQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("08+HVu4akak=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        string appIdSvcState = Encoding.UTF8.GetString(Convert.FromBase64String("HvYBEis1jM4j/AdEJDmcgCk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZNzZEJW6e4=")[iii % 8])).ToArray());
        var rules = new List<string>();
        foreach (var o in data)
        {
            var result = (ManagementObject)o;
            appIdSvcState = result[Encoding.UTF8.GetString(Convert.FromBase64String("nzCbO5E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zET6T/SkCQ4=")[iii % 8])).ToArray())].ToString();
        }

        var keys = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("0mSatve7Gs7dW5Ou6bkBzvJXsavjqAfY7m2IntezBs/ufI+e06gY/bM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gQv8woDaaKs=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        if (keys != null && keys.Length != 0)
        {
            foreach (var key in keys)
            {
                var keyName = key;
                var enforcementMode = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, $"Software\\Policies\\Microsoft\\Windows\\SrpV2\\{key}", Encoding.UTF8.GetString(Convert.FromBase64String("+doBiI0olTHZ2hOqkC+V").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vLRn5/9L8Fw=")[iii % 8])).ToArray()));
                var enforcementModeStr = enforcementMode switch
                {
                    null => Encoding.UTF8.GetString(Convert.FromBase64String("THyam6isgZdLdJvJrqc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IhPuu8vD7/E=")[iii % 8])).ToArray()),
                    0 => Encoding.UTF8.GetString(Convert.FromBase64String("6UMEzOVuA1PMUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qDZgpZFOTjw=")[iii % 8])).ToArray()),
                    1 => Encoding.UTF8.GetString(Convert.FromBase64String("I/efw+3i3c0r9p3J").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zpn5rJ+BuO0=")[iii % 8])).ToArray()),
                    _ => $"Unknown value {enforcementMode}"};
                var ids = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("fNV4UD7M3exz6nFIIM7G7FzmU00q38D6QNxqeB7Ewe1AzW14Gt/f3x3m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7oeJEmtr4k=")[iii % 8])).ToArray()) + key);
                foreach (var id in ids)
                {
                    var rule = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"Software\\Policies\\Microsoft\\Windows\\SrpV2\\{key}\\{id}", Encoding.UTF8.GetString(Convert.FromBase64String("apm3gOY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PPjb9YMX4yM=")[iii % 8])).ToArray()));
                    rules.Add(rule);
                }

                yield return new O_81B62776(configured: true, appIdSvcState, keyName, enforcementModeStr, rules);
            }
        }
        else
        {
            yield return new O_81B62776(configured: false, appIdSvcState, keyName: null, enforcementMode: null, rules: null);
        }
    }
}}
#nullable enable
