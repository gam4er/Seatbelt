using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_E0886B7B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("8aO1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g8bSnlOHr1I=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("BZCQ12FD4BF3npLHMkHzBCKQhJ46f9kkGqmk0XRD5QklkNfcaxf2DTGUgtJmHrIJJZKC03dZ5khqyNflQlbmAArVrNd8Q9YNJ4Gf4zJswA0wkI/jMmzwBziZvtl8WOANEoeF0WBEzw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V/X3vhI3kmg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_E0886B7B(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var hive = RegistryHive.LocalMachine;
        var keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("m1WQqIAvGHU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yDr23PdOahA=")[iii % 8])).ToArray());
        var depth = 0;
        var regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("qw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hevn6ZXtNHs=")[iii % 8])).ToArray()));
        var ignoreErrors = true;
        var computer = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9N0xjwjMWSQ=")[iii % 8])).ToArray());
        if (args.Length == 0)
        {
            depth = 1;
            regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("7nkWZd44tQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ihxwBKtUwQw=")[iii % 8])).ToArray()));
        }

        if (args.Length >= 1)
        {
            var separatorPos = args[0].IndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ilO1THgvyVI=")[iii % 8])).ToArray()));
            if (separatorPos == -1)
            {
                hive = RegistryUtil.GetHive(args[0]);
                keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MRmvt38tE8Q=")[iii % 8])).ToArray());
            }
            else if (separatorPos == args[0].Length)
            {
                var hiveStr = args[0].Substring(0, separatorPos);
                hive = RegistryUtil.GetHive(hiveStr);
                keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2Wj6Ya0aZnc=")[iii % 8])).ToArray());
            }
            else
            {
                var hiveStr = args[0].Substring(0, separatorPos);
                hive = RegistryUtil.GetHive(hiveStr);
                keyPath = args[0].Substring(separatorPos + 1);
            }
        }

        if (args.Length >= 2)
        {
            if (!int.TryParse(args[1], out depth))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("urSP0Llcjg6N+4rdrw+FQZ2+isi1XIETnq6X2bMI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+dv6vN184GE=")[iii % 8])).ToArray()));
            }
        }

        if (args.Length >= 3)
        {
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
        }

        if (args.Length >= 4)
        {
            ignoreErrors = bool.Parse(args[3]);
        }

        if (args.Length >= 5)
        {
            computer = args[4];
        }

        foreach (var output in EnumerateRootKey(computer, hive, keyPath, regex, depth, ignoreErrors))
        {
            yield return output;
        }
    }

    private IEnumerable<O_13C2B2E0> EnumerateRootKey(string computer, RegistryHive hive, string keyPath, Regex regex, int depth, bool ignoreErrors)
    {
        using var rootHive = RegistryKey.OpenRemoteBaseKey(hive, computer);
        using var key = rootHive.OpenSubKey(keyPath);
        foreach (var output in EnumerateRegistryKey(key, regex, depth, ignoreErrors))
        {
            yield return output;
        }
    }

    private IEnumerable<O_13C2B2E0> EnumerateRegistryKey(RegistryKey key, Regex regex, int depth, bool ignoreErrors)
    {
        if (key == null)
        {
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("XgFkK6jE1HdjAHo+ssjFew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EHQIR/qhsx4=")[iii % 8])).ToArray()));
        }

        if (depth < 0)
        {
            yield break;
        }

        var outputKeyPath = key.ToString().Replace(Encoding.UTF8.GetString(Convert.FromBase64String("YNdk6SA6UOFp0H79PjVX62bZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KJwhsH92H6I=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("KZ9GrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YdQK4avNuLA=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("aXM9z/GGGaJzfTbC8ZAftXM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ITh4lq7FTPA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("HX1T3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VTYQifRu/gc=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("pNAAu762dbi/yACxvqd2trg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7JtF4uH1Ofk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gvwvfw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yrdsLSKOPNM=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("Baa1wBlXUnsfvg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Te3wmUYCAT4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("BEqU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TAHBj7ms48U=")[iii % 8])).ToArray()));
        var sddl = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SmajYvdPmmI=")[iii % 8])).ToArray());
        if (!Runtime.FilterResults)
        {
            try
            {
                var accessControl = key.GetAccessControl();
                sddl = accessControl.GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.Access | System.Security.AccessControl.AccessControlSections.Owner);
            }
            catch
            {
            }
        }

        var defaultValue = key.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ql1DWllfkVk=")[iii % 8])).ToArray()));
        if (regex.IsMatch(Encoding.UTF8.GetString(Convert.FromBase64String("EOubgCJT0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dI794Vc/prA=")[iii % 8])).ToArray())) || (regex.IsMatch(outputKeyPath) || (defaultValue != null && regex.IsMatch($"{defaultValue}"))))
        {
            yield return new O_13C2B2E0(outputKeyPath, Encoding.UTF8.GetString(Convert.FromBase64String("BIqP34Agvd4F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LO7queFV0ao=")[iii % 8])).ToArray()), defaultValue, RegistryValueKind.String, sddl);
        }

        foreach (var valueName in key.GetValueNames())
        {
            if (valueName == null || valueName == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oKpyDpeJThU=")[iii % 8])).ToArray()))
                continue;
            var valueKind = key.GetValueKind(valueName);
            var value = key.GetValue(valueName);
            if (regex.IsMatch(valueName) || regex.IsMatch($"{value}"))
            {
                yield return new O_13C2B2E0(outputKeyPath, valueName, value, valueKind, sddl);
            }
        }

        foreach (var subkeyName in key.GetSubKeyNames())
        {
            RegistryKey? subkey = null;
            try
            {
                subkey = key.OpenSubKey(subkeyName);
            }
            catch (Exception e)
            {
                if (!ignoreErrors)
                {
                    throw new Exception($"Error accessing {(key + Encoding.UTF8.GetString(Convert.FromBase64String("Kw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dxYh95V3WQg=")[iii % 8])).ToArray()) + subkeyName)}: " + e);
                }
            }

            if (subkey == null)
                continue;
            foreach (var result in EnumerateRegistryKey(subkey, regex, (depth - 1), ignoreErrors))
            {
                yield return result;
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string JAZhAZPl)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                    instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var hive = RegistryHive.LocalMachine;
        var keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("m1WQqIAvGHU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yDr23PdOahA=")[iii % 8])).ToArray());
        var depth = 0;
        var regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("qw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hevn6ZXtNHs=")[iii % 8])).ToArray()));
        var ignoreErrors = true;
        var computer = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9N0xjwjMWSQ=")[iii % 8])).ToArray());
        if (args.Length == 0)
        {
            depth = 1;
            regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("7nkWZd44tQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ihxwBKtUwQw=")[iii % 8])).ToArray()));
        }

        if (args.Length >= 1)
        {
            var separatorPos = args[0].IndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ilO1THgvyVI=")[iii % 8])).ToArray()));
            if (separatorPos == -1)
            {
                hive = RegistryUtil.GetHive(args[0]);
                keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MRmvt38tE8Q=")[iii % 8])).ToArray());
            }
            else if (separatorPos == args[0].Length)
            {
                var hiveStr = args[0].Substring(0, separatorPos);
                hive = RegistryUtil.GetHive(hiveStr);
                keyPath = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2Wj6Ya0aZnc=")[iii % 8])).ToArray());
            }
            else
            {
                var hiveStr = args[0].Substring(0, separatorPos);
                hive = RegistryUtil.GetHive(hiveStr);
                keyPath = args[0].Substring(separatorPos + 1);
            }
        }

        if (args.Length >= 2)
        {
            if (!int.TryParse(args[1], out depth))
            {
                WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("urSP0Llcjg6N+4rdrw+FQZ2+isi1XIETnq6X2bMI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+dv6vN184GE=")[iii % 8])).ToArray()));
            }
        }

        if (args.Length >= 3)
        {
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
        }

        if (args.Length >= 4)
        {
            ignoreErrors = bool.Parse(args[3]);
        }

        if (args.Length >= 5)
        {
            computer = args[4];
        }

        foreach (var output in EnumerateRootKey(computer, hive, keyPath, regex, depth, ignoreErrors))
        {
            yield return output;
        }
    }

    private IEnumerable<O_13C2B2E0> EnumerateRootKey(string computer, RegistryHive hive, string keyPath, Regex regex, int depth, bool ignoreErrors, string wXGoWgQJ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                    instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        using var rootHive = RegistryKey.OpenRemoteBaseKey(hive, computer);
        using var key = rootHive.OpenSubKey(keyPath);
        foreach (var output in EnumerateRegistryKey(key, regex, depth, ignoreErrors))
        {
            yield return output;
        }
    }

    private IEnumerable<O_13C2B2E0> EnumerateRegistryKey(RegistryKey key, Regex regex, int depth, bool ignoreErrors, string xIeoTpHs)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                    instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (key == null)
        {
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("XgFkK6jE1HdjAHo+ssjFew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EHQIR/qhsx4=")[iii % 8])).ToArray()));
        }

        if (depth < 0)
        {
            yield break;
        }

        var outputKeyPath = key.ToString().Replace(Encoding.UTF8.GetString(Convert.FromBase64String("YNdk6SA6UOFp0H79PjVX62bZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KJwhsH92H6I=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("KZ9GrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YdQK4avNuLA=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("aXM9z/GGGaJzfTbC8ZAftXM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ITh4lq7FTPA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("HX1T3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VTYQifRu/gc=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("pNAAu762dbi/yACxvqd2trg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7JtF4uH1Ofk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gvwvfw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yrdsLSKOPNM=")[iii % 8])).ToArray())).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("Baa1wBlXUnsfvg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Te3wmUYCAT4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("BEqU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TAHBj7ms48U=")[iii % 8])).ToArray()));
        var sddl = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SmajYvdPmmI=")[iii % 8])).ToArray());
        if (!Runtime.FilterResults)
        {
            try
            {
                var accessControl = key.GetAccessControl();
                sddl = accessControl.GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.Access | System.Security.AccessControl.AccessControlSections.Owner);
            }
            catch
            {
            }
        }

        var defaultValue = key.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ql1DWllfkVk=")[iii % 8])).ToArray()));
        if (regex.IsMatch(Encoding.UTF8.GetString(Convert.FromBase64String("EOubgCJT0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dI794Vc/prA=")[iii % 8])).ToArray())) || (regex.IsMatch(outputKeyPath) || (defaultValue != null && regex.IsMatch($"{defaultValue}"))))
        {
            yield return new O_13C2B2E0(outputKeyPath, Encoding.UTF8.GetString(Convert.FromBase64String("BIqP34Agvd4F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LO7queFV0ao=")[iii % 8])).ToArray()), defaultValue, RegistryValueKind.String, sddl);
        }

        foreach (var valueName in key.GetValueNames())
        {
            if (valueName == null || valueName == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oKpyDpeJThU=")[iii % 8])).ToArray()))
                continue;
            var valueKind = key.GetValueKind(valueName);
            var value = key.GetValue(valueName);
            if (regex.IsMatch(valueName) || regex.IsMatch($"{value}"))
            {
                yield return new O_13C2B2E0(outputKeyPath, valueName, value, valueKind, sddl);
            }
        }

        foreach (var subkeyName in key.GetSubKeyNames())
        {
            RegistryKey? subkey = null;
            try
            {
                subkey = key.OpenSubKey(subkeyName);
            }
            catch (Exception e)
            {
                if (!ignoreErrors)
                {
                    throw new Exception($"Error accessing {(key + Encoding.UTF8.GetString(Convert.FromBase64String("Kw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dxYh95V3WQg=")[iii % 8])).ToArray()) + subkeyName)}: " + e);
                }
            }

            if (subkey == null)
                continue;
            foreach (var result in EnumerateRegistryKey(subkey, regex, (depth - 1), ignoreErrors))
            {
                yield return result;
            }
        }
    }
}public class O_13C2B2E0 : O_4AED570F
{
    public O_13C2B2E0(string key, string valueName, object value, object valueKind, string sddl)
    {
        Key = key;
        ValueName = valueName;
        Value = value;
        ValueKind = valueKind;
        SDDL = sddl;
    }

    public string Key { get; }
    public string ValueName { get; }
    public object Value { get; }
    public object ValueKind { get; }
    public object SDDL { get; }
}
    [CommandOutputType(typeof(O_13C2B2E0))]
    internal class O_114F1B65 : TextFormatterBase
    {
        public O_114F1B65(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            if (result == null)
            {
                return;
            }

            var dto = (O_13C2B2E0)result;
            if ((int)dto.ValueKind == (int)RegistryValueKind.MultiString)
            {
                var values = (string[])dto.Value;
                if (String.IsNullOrEmpty((string)dto.SDDL))
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} :\n{String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("dA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fkhclIH8eUQ=")[iii % 8])).ToArray()), values)}");
                }
                else
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} :\n{String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("iA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gliKZQ0SemI=")[iii % 8])).ToArray()), values)}\n  {dto.SDDL}");
                }
            }
            else
            {
                if (String.IsNullOrEmpty((string)dto.SDDL))
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} : {dto.Value}");
                }
                else
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} : {dto.Value}\n  {dto.SDDL}");
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string PVREXIWp)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                        instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
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

            var dto = (O_13C2B2E0)result;
            if ((int)dto.ValueKind == (int)RegistryValueKind.MultiString)
            {
                var values = (string[])dto.Value;
                if (String.IsNullOrEmpty((string)dto.SDDL))
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} :\n{String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("dA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fkhclIH8eUQ=")[iii % 8])).ToArray()), values)}");
                }
                else
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} :\n{String.Join(Encoding.UTF8.GetString(Convert.FromBase64String("iA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gliKZQ0SemI=")[iii % 8])).ToArray()), values)}\n  {dto.SDDL}");
                }
            }
            else
            {
                if (String.IsNullOrEmpty((string)dto.SDDL))
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} : {dto.Value}");
                }
                else
                {
                    WriteLine($"{dto.Key} ! {dto.ValueName} : {dto.Value}\n  {dto.SDDL}");
                }
            }
        }
    }
}