using Microsoft.Win32;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_4D53A282 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("xSQVNbFSRQznECc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iXdUZtQmMWU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("AdGkD+QGJzsk7IJct0s6IS7ukEv+DTRvLPeRR7cTMiwm44JK5Eo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TYLlL5djU08=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_4D53A282(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("7TBnC25A1njLG0Y6RXnJVNAdRjBHXu9P4ipbMV9/5VfiJUc+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vmk0XysNijs=")[iii % 8])).ToArray()));
        if ((settings != null) && (settings.Count != 0))
        {
            foreach (var kvp in settings)
            {
                if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("re34ePJ5uHKK5uJi8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/pSLDJcUliE=")[iii % 8])).ToArray())))
                {
                    var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("eQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Va6YXvo07Oo=")[iii % 8])).ToArray()), (string[])kvp.Value);
                    yield return new O_7E02EBA0(kvp.Key, result);
                }
                else if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("shmo59Vlr12YFL4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4WDbk7AIgR8=")[iii % 8])).ToArray())))
                {
                    var result = System.BitConverter.ToString((byte[])kvp.Value);
                    yield return new O_7E02EBA0(kvp.Key, result);
                }
                else
                {
                    yield return new O_7E02EBA0(kvp.Key, kvp.Value.ToString());
                }
            }
        }
    }

internal class O_7E02EBA0 : O_4AED570F
{
    public O_7E02EBA0(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}    [CommandOutputType(typeof(O_7E02EBA0))]
    internal class O_5DCAAECA : TextFormatterBase
    {
        public O_5DCAAECA(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_7E02EBA0)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("F8mU5Xg7wW5KydX1LyeP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N+nv1VQW8l4=")[iii % 8])).ToArray()), dto.Key, dto.Value);
            if (Regex.IsMatch(dto.Key, Encoding.UTF8.GetString(Convert.FromBase64String("+Yn/+mJqL+qKvP3se2I89tk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("quycjxADW5M=")[iii % 8])).ToArray())) && Regex.IsMatch(dto.Value, Encoding.UTF8.GetString(Convert.FromBase64String("Tn0cxSqFANIUeUE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YFdroUPiZaE=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WIM2n4v7knsv53/YtaK7exHQNtq+sK03Hcc2kvChozoRzWLaqKXvKxnQZci/o6t7HdtizbGyuzIXzTbWo/G/NAvQf928tO4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eKMWv9DRz1s=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("hDKBFuBhKVw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1kfvV5MxeRA=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase) && dto.Value == Encoding.UTF8.GetString(Convert.FromBase64String("tQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJERUBS6gKE=")[iii % 8])).ToArray()))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EAoYiHgY4698eXn7cBLu/V9eXctXV9qvfUVczQNbza9VRFnKT1farhBzV90DRdfjXApWx1cS3OoQS1rERhLK4BBLW8tGQc2vXFlZ21Ac2/dVDUuITlfT4EJTGM1CQdfjSQQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MCo4qCMyvo8=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("SQyRD3YxhCFoFpYcfT6VFmkkhgN9Mw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DWXibhRd4XM=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase) && dto.Value == Encoding.UTF8.GetString(Convert.FromBase64String("OA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CKGr58xvq1c=")[iii % 8])).ToArray()))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B2UwYT/ek/F1AUBhNpG9pVUsczUBkO6QQyh5L0S5obVCZXkyRJGgsEUpdSVF1Je+UmVzIArUu6JCZWAgF4fjpU8gPSkFh6bxUyowIAeXq6JUZUIFNNShvwcxeCgX1L2oVDF1LEo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J0UQQWT0ztE=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("eOpvwyLqo3RHwWHSKcWyUUnpZd8fw6Vm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LIUEpkymxhU=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine($"    [*] TokenLeakDetectDelaySecs is set to '{dto.Value}' - logon sessions will be cleared after this number of seconds!");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string QlUbMlpT)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                        instance.GetMaxByteCount(45);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_7E02EBA0)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("F8mU5Xg7wW5KydX1LyeP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N+nv1VQW8l4=")[iii % 8])).ToArray()), dto.Key, dto.Value);
            if (Regex.IsMatch(dto.Key, Encoding.UTF8.GetString(Convert.FromBase64String("+Yn/+mJqL+qKvP3se2I89tk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("quycjxADW5M=")[iii % 8])).ToArray())) && Regex.IsMatch(dto.Value, Encoding.UTF8.GetString(Convert.FromBase64String("Tn0cxSqFANIUeUE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YFdroUPiZaE=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WIM2n4v7knsv53/YtaK7exHQNtq+sK03Hcc2kvChozoRzWLaqKXvKxnQZci/o6t7HdtizbGyuzIXzTbWo/G/NAvQf928tO4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eKMWv9DRz1s=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("hDKBFuBhKVw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1kfvV5MxeRA=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase) && dto.Value == Encoding.UTF8.GetString(Convert.FromBase64String("tQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJERUBS6gKE=")[iii % 8])).ToArray()))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EAoYiHgY4698eXn7cBLu/V9eXctXV9qvfUVczQNbza9VRFnKT1farhBzV90DRdfjXApWx1cS3OoQS1rERhLK4BBLW8tGQc2vXFlZ21Ac2/dVDUuITlfT4EJTGM1CQdfjSQQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MCo4qCMyvo8=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("SQyRD3YxhCFoFpYcfT6VFmkkhgN9Mw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DWXibhRd4XM=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase) && dto.Value == Encoding.UTF8.GetString(Convert.FromBase64String("OA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CKGr58xvq1c=")[iii % 8])).ToArray()))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("B2UwYT/ek/F1AUBhNpG9pVUsczUBkO6QQyh5L0S5obVCZXkyRJGgsEUpdSVF1Je+UmVzIArUu6JCZWAgF4fjpU8gPSkFh6bxUyowIAeXq6JUZUIFNNShvwcxeCgX1L2oVDF1LEo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J0UQQWT0ztE=")[iii % 8])).ToArray()));
            }

            if (dto.Key.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("eOpvwyLqo3RHwWHSKcWyUUnpZd8fw6Vm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LIUEpkymxhU=")[iii % 8])).ToArray()), System.StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine($"    [*] TokenLeakDetectDelaySecs is set to '{dto.Value}' - logon sessions will be cleared after this number of seconds!");
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ECgjQKQs)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                    instance.GetMaxByteCount(45);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var settings = ThisRunTime.GetValues(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("7TBnC25A1njLG0Y6RXnJVNAdRjBHXu9P4ipbMV9/5VfiJUc+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vmk0XysNijs=")[iii % 8])).ToArray()));
        if ((settings != null) && (settings.Count != 0))
        {
            foreach (var kvp in settings)
            {
                if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("re34ePJ5uHKK5uJi8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/pSLDJcUliE=")[iii % 8])).ToArray())))
                {
                    var result = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("eQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Va6YXvo07Oo=")[iii % 8])).ToArray()), (string[])kvp.Value);
                    yield return new O_7E02EBA0(kvp.Key, result);
                }
                else if (kvp.Value.GetType().IsArray && (kvp.Value.GetType().GetElementType().ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("shmo59Vlr12YFL4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4WDbk7AIgR8=")[iii % 8])).ToArray())))
                {
                    var result = System.BitConverter.ToString((byte[])kvp.Value);
                    yield return new O_7E02EBA0(kvp.Key, result);
                }
                else
                {
                    yield return new O_7E02EBA0(kvp.Key, kvp.Value.ToString());
                }
            }
        }
    }
}}