using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_2EE28C2A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("zc5U").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("moMd2ymMEMc=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("imvJj9X7UvSoe8SVk/MX4/hJ6rXV6wfiqmc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2B6n/PWacoc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_2EE28C2A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var wmiQuery = Encoding.UTF8.GetString(Convert.FromBase64String("XcwDCs28HBouzx0Aw+hrWWCaXTDtp1FAe90KHf2xT0RrxA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dqlvb67IPDA=")[iii % 8])).ToArray());
        var wmiNamespace = Encoding.UTF8.GetString(Convert.FromBase64String("udpZnJK8ZF69hw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y7U26M7fDTM=")[iii % 8])).ToArray());
        if (args.Length == 1)
        {
            wmiQuery = args[0];
        }
        else if (args.Length == 2)
        {
            wmiNamespace = args[0];
            wmiQuery = args[1];
        }

        var results = new List<OrderedDictionary>();
        using (var searcher = ThisRunTime.GetManagementObjectSearcher(wmiNamespace, wmiQuery))
        {
            using var items = searcher.Get();
            foreach (ManagementObject result in items)
            {
                var properties = new OrderedDictionary();
                foreach (var prop in result.Properties)
                {
                    properties.Add(prop.Name, prop.Value);
                }

                results.Add(properties);
            }
        }

        yield return new O_CACA4DCD(results);
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string GmfAuvgb)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxByteCount(12);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiQuery = Encoding.UTF8.GetString(Convert.FromBase64String("XcwDCs28HBouzx0Aw+hrWWCaXTDtp1FAe90KHf2xT0RrxA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dqlvb67IPDA=")[iii % 8])).ToArray());
        var wmiNamespace = Encoding.UTF8.GetString(Convert.FromBase64String("udpZnJK8ZF69hw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y7U26M7fDTM=")[iii % 8])).ToArray());
        if (args.Length == 1)
        {
            wmiQuery = args[0];
        }
        else if (args.Length == 2)
        {
            wmiNamespace = args[0];
            wmiQuery = args[1];
        }

        var results = new List<OrderedDictionary>();
        using (var searcher = ThisRunTime.GetManagementObjectSearcher(wmiNamespace, wmiQuery))
        {
            using var items = searcher.Get();
            foreach (ManagementObject result in items)
            {
                var properties = new OrderedDictionary();
                foreach (var prop in result.Properties)
                {
                    properties.Add(prop.Name, prop.Value);
                }

                results.Add(properties);
            }
        }

        yield return new O_CACA4DCD(results);
    }
}internal class O_CACA4DCD : O_4AED570F
{
    public O_CACA4DCD(List<OrderedDictionary> results)
    {
        QueryResults = results;
    }

    public List<OrderedDictionary> QueryResults { get; }
}
    [CommandOutputType(typeof(O_CACA4DCD))]
    internal class O_BC03815F : TextFormatterBase
    {
        public O_BC03815F(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_CACA4DCD)result;
            foreach (var resultEntry in dto.QueryResults)
            {
                var enumerator = resultEntry.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var value = enumerator.Value;
                    if (value == null)
                    {
                        continue;
                    }

                    var valueType = value.GetType();
                    var valueName = enumerator.Key?.ToString();
                    if (valueType.IsArray)
                    {
                        WriteArrayValue(valueType, valueName, value);
                    }
                    else
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UqmTO5F5pk8Ps8hwjCk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("conoC71UlX8=")[iii % 8])).ToArray()), valueName, value);
                    }
                }

                WriteLine();
            }
        }

        private void WriteArrayValue(Type valueType, string? valueName, object value)
        {
            var elemType = valueType.GetElementType();
            var name = $"{valueName}({valueType.Name})";
            if (elemType == typeof(string))
            {
                WriteLine($"  {name, -30}:");
                foreach (var s in (string[])value)
                {
                    WriteLine($"      {s}");
                }
            }
            else
            {
                IEnumerable<string> s = ((IEnumerable)value).Cast<object>().Select(x => x.ToString()).ToArray();
                var v = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yu1noCY+kV8=")[iii % 8])).ToArray()), (string[])s);
                WriteLine($"  {name, -30}: {v}");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ecQyaTHp)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxByteCount(12);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_CACA4DCD)result;
            foreach (var resultEntry in dto.QueryResults)
            {
                var enumerator = resultEntry.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    var value = enumerator.Value;
                    if (value == null)
                    {
                        continue;
                    }

                    var valueType = value.GetType();
                    var valueName = enumerator.Key?.ToString();
                    if (valueType.IsArray)
                    {
                        WriteArrayValue(valueType, valueName, value);
                    }
                    else
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UqmTO5F5pk8Ps8hwjCk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("conoC71UlX8=")[iii % 8])).ToArray()), valueName, value);
                    }
                }

                WriteLine();
            }
        }

        private void WriteArrayValue(Type valueType, string? valueName, object value, string IhayJrFF)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxByteCount(12);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var elemType = valueType.GetElementType();
            var name = $"{valueName}({valueType.Name})";
            if (elemType == typeof(string))
            {
                WriteLine($"  {name, -30}:");
                foreach (var s in (string[])value)
                {
                    WriteLine($"      {s}");
                }
            }
            else
            {
                IEnumerable<string> s = ((IEnumerable)value).Cast<object>().Select(x => x.ToString()).ToArray();
                var v = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yu1noCY+kV8=")[iii % 8])).ToArray()), (string[])s);
                WriteLine($"  {name, -30}: {v}");
            }
        }
    }
}