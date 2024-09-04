using System;
using System.Collections.Generic;
using Microsoft.Win32;
using O_F41F88FA.Commands.Windows;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_F3334EF9 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("SnI0tUx1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GQtH2CMbBw8=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("09CdEjCeoGjvx4gWOIXyavTAgRF/lvJk7YmaFzrQ8m7nwJ0LLYk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gKnuf1/wgAs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    [Flags]
    public enum SysmonHashAlgorithm
    {
        NotDefined = 0,
        SHA1 = 1,
        MD5 = 2,
        SHA256 = 4,
        IMPHASH = 8
    }

    [Flags]
    public enum SysmonOptions
    {
        NotDefined = 0,
        NetworkConnection = 1,
        ImageLoading = 2
    }

    public O_F3334EF9(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("TULr0Vq76f53DOncWrKs6WwCqv5Drb2qekmq0lj+qO51ReTaRaq762xD+J0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GCyKszbeyYo=")[iii % 8])).ToArray()));
            yield break;
        }

        var paramsKey = Encoding.UTF8.GetString(Convert.FromBase64String("VryKPmDNnAJwl6sPS/SDLmuRqwVJ06U1Wba8GFPpoyR2uYoTVu2vL0GXrzZ14bIgaICtD1fz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BeXZaiWAwEE=")[iii % 8])).ToArray());
        var regHashAlg = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("VnYL/i8WfZlycBfkLwxytQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hhd4lkZ4Gtg=")[iii % 8])).ToArray()));
        var regOptions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("wY3WG1DIeg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jv2icj+mCbg=")[iii % 8])).ToArray()));
        var regSysmonRules = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("Jy1nXKA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dVgLOdOx7Tg=")[iii % 8])).ToArray()));
        var installed = false;
        var hashingAlgorithm = (SysmonHashAlgorithm)0;
        var sysmonOptions = (SysmonOptions)0;
        string? b64SysmonRules = null;
        if ((regHashAlg != null) || (regOptions != null) || (regSysmonRules != null))
        {
            installed = true;
        }

        if (regHashAlg != null && regHashAlg != 0)
        {
            regHashAlg = regHashAlg & 15;
            hashingAlgorithm = (SysmonHashAlgorithm)regHashAlg;
        }

        if (regOptions != null)
        {
            sysmonOptions = (SysmonOptions)regOptions;
        }

        if (regSysmonRules != null)
        {
            b64SysmonRules = Convert.ToBase64String(regSysmonRules);
        }

        yield return new O_B59DFEF1(installed, hashingAlgorithm, sysmonOptions, b64SysmonRules);
    }

internal class O_B59DFEF1 : O_4AED570F
{
    public O_B59DFEF1(bool installed, SysmonHashAlgorithm hashingAlgorithm, SysmonOptions options, string? rules)
    {
        Installed = installed;
        HashingAlgorithm = hashingAlgorithm;
        Options = options;
        Rules = rules;
    }

    public bool Installed { get; }
    public SysmonHashAlgorithm HashingAlgorithm { get; }
    public SysmonOptions Options { get; }
    public string? Rules { get; }
}    [CommandOutputType(typeof(O_B59DFEF1))]
    internal class O_EF343435 : TextFormatterBase
    {
        public O_EF343435(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_B59DFEF1)result;
            WriteLine($"Installed:        {dto.Installed}");
            WriteLine($"HashingAlgorithm: {dto.HashingAlgorithm}");
            WriteLine($"Options:          {dto.Options}");
            WriteLine($"Rules:");
            foreach (var line in Split(dto.Rules, 100))
            {
                WriteLine($"    {line}");
            }
        }

        private IEnumerable<string> Split(string? text, int lineLength)
        {
            if (text == null)
                yield break;
            var i = 0;
            for (; i < text.Length; i += lineLength)
            {
                if (i + lineLength > text.Length)
                {
                    break;
                }

                yield return text.Substring(i, lineLength);
            }

            yield return text.Substring(i);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ATvmjPyu)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxCharCount(87);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_B59DFEF1)result;
            WriteLine($"Installed:        {dto.Installed}");
            WriteLine($"HashingAlgorithm: {dto.HashingAlgorithm}");
            WriteLine($"Options:          {dto.Options}");
            WriteLine($"Rules:");
            foreach (var line in Split(dto.Rules, 100))
            {
                WriteLine($"    {line}");
            }
        }

        private IEnumerable<string> Split(string? text, int lineLength, string ieMTKCLp)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxCharCount(87);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (text == null)
                yield break;
            var i = 0;
            for (; i < text.Length; i += lineLength)
            {
                if (i + lineLength > text.Length)
                {
                    break;
                }

                yield return text.Substring(i, lineLength);
            }

            yield return text.Substring(i);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string tIpbBEcd)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxCharCount(87);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("TULr0Vq76f53DOncWrKs6WwCqv5Drb2qekmq0lj+qO51ReTaRaq762xD+J0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GCyKszbeyYo=")[iii % 8])).ToArray()));
            yield break;
        }

        var paramsKey = Encoding.UTF8.GetString(Convert.FromBase64String("VryKPmDNnAJwl6sPS/SDLmuRqwVJ06U1Wba8GFPpoyR2uYoTVu2vL0GXrzZ14bIgaICtD1fz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BeXZaiWAwEE=")[iii % 8])).ToArray());
        var regHashAlg = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("VnYL/i8WfZlycBfkLwxytQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hhd4lkZ4Gtg=")[iii % 8])).ToArray()));
        var regOptions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("wY3WG1DIeg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jv2icj+mCbg=")[iii % 8])).ToArray()));
        var regSysmonRules = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, paramsKey, Encoding.UTF8.GetString(Convert.FromBase64String("Jy1nXKA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dVgLOdOx7Tg=")[iii % 8])).ToArray()));
        var installed = false;
        var hashingAlgorithm = (SysmonHashAlgorithm)0;
        var sysmonOptions = (SysmonOptions)0;
        string? b64SysmonRules = null;
        if ((regHashAlg != null) || (regOptions != null) || (regSysmonRules != null))
        {
            installed = true;
        }

        if (regHashAlg != null && regHashAlg != 0)
        {
            regHashAlg = regHashAlg & 15;
            hashingAlgorithm = (SysmonHashAlgorithm)regHashAlg;
        }

        if (regOptions != null)
        {
            sysmonOptions = (SysmonOptions)regOptions;
        }

        if (regSysmonRules != null)
        {
            b64SysmonRules = Convert.ToBase64String(regSysmonRules);
        }

        yield return new O_B59DFEF1(installed, hashingAlgorithm, sysmonOptions, b64SysmonRules);
    }
}}