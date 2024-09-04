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
internal class O_37536031 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("CkoWP+YrjgkrRhYvzzOPOzxRHDLnOw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XSN4W4lc/Uw=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("OwEpovfvUbwpHiKo7Lhk8x4fJrT88Uz7TEAQg96xAu8JHDOv9v9RvBoBJubs8Ee8Hg0gr+vsUOU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bGhHxpiYIpw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_37536031(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ibwFOOhp18yGgwwg9mvMzKmPLiX8esratbUXEMhhy821pBAQ2n7Ax66fDCvDTdPMtKclI+1/xNu+ug0rw1vQy6mwESXvfMzGtJ4CIv5vwNs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2tNjTJ8Ipak=")[iii % 8])).ToArray()));
        if (settings != null)
        {
            foreach (var kvp in settings)
            {
                if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("smkCscWi5UmVYhirxw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4RBxxaDPyxo=")[iii % 8])).ToArray())))
                {
                    var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RjA6FOQ3OyI=")[iii % 8])).ToArray()), (string[])kvp.Value);
                    WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("52tAnFOaGRK6awGMBIZX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x0s7rH+3KiI=")[iii % 8])).ToArray()), kvp.Key, result);
                    yield return new O_245B3EFA(kvp.Key, result);
                }
                else
                {
                    WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("LOX28Kzhv/Bx5bfg+/3x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DMWNwIDMjMA=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                    yield return new O_245B3EFA(kvp.Key, kvp.Value.ToString());
                }
            }
        }
    }

internal class O_245B3EFA : O_4AED570F
{
    public O_245B3EFA(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}    [CommandOutputType(typeof(O_245B3EFA))]
    internal class O_523A65B4 : TextFormatterBase
    {
        public O_523A65B4(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_245B3EFA)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("S1g08bdpjQQWWHXh4HXD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a3hPwZtEvjQ=")[iii % 8])).ToArray()), dto.Key, dto.Value);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string PphBwoTP)
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

            var dto = (O_245B3EFA)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("S1g08bdpjQQWWHXh4HXD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a3hPwZtEvjQ=")[iii % 8])).ToArray()), dto.Key, dto.Value);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string mgAMjUfs)
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

        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ibwFOOhp18yGgwwg9mvMzKmPLiX8esratbUXEMhhy821pBAQ2n7Ax66fDCvDTdPMtKclI+1/xNu+ug0rw1vQy6mwESXvfMzGtJ4CIv5vwNs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2tNjTJ8Ipak=")[iii % 8])).ToArray()));
        if (settings != null)
        {
            foreach (var kvp in settings)
            {
                if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("smkCscWi5UmVYhirxw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4RBxxaDPyxo=")[iii % 8])).ToArray())))
                {
                    var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RjA6FOQ3OyI=")[iii % 8])).ToArray()), (string[])kvp.Value);
                    WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("52tAnFOaGRK6awGMBIZX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x0s7rH+3KiI=")[iii % 8])).ToArray()), kvp.Key, result);
                    yield return new O_245B3EFA(kvp.Key, result);
                }
                else
                {
                    WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("LOX28Kzhv/Bx5bfg+/3x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DMWNwIDMjMA=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                    yield return new O_245B3EFA(kvp.Key, kvp.Value.ToString());
                }
            }
        }
    }
}}