using System;
using System.Collections.Generic;
using System.Linq;
using O_F41F88FA.Interop;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_85E28F15 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("7HXOSCEdWjTlYNtVOwFeKw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("owW6IU5zO1g=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("4rQgmg5oUm3Hsj2PQgdkfM+pJpxLVA1LwbE2nQ4PVHDP/QSjZw4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rt1T7i4nIhk=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_85E28F15(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var results = new List<O_ABB262A2>();
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("Zo1Ozqf7rNNi0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FOIhuvuYxb4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("o+UlCH2cSdKRzQxhfakZ6JnPB2F3phrokcwFHkqpHfnQ5jsCc+g+9Z6TWxJxuB31n84IIXitCOiF0gw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8KBpTT7IaZw=")[iii % 8])).ToArray()));
        var featureList = wmiData.Get();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DXSyhCVdfuFHaLOcLV1+4UQ5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dkSeqR0gXpo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("djovbw0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JU5OG2gk+X0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hqdQ7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yMY9iNHj9rw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sFhC33L53A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8zkyqxuWsts=")[iii % 8])).ToArray()));
        foreach (var feature in featureList)
        {
            var state = (OptionalFeatureState)Enum.Parse(typeof(OptionalFeatureState), feature[Encoding.UTF8.GetString(Convert.FromBase64String("bIX3pZA/AqJRivC0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JeuE0fFTbvE=")[iii % 8])).ToArray())].ToString());
            if (Runtime.FilterResults && state != OptionalFeatureState.Enabled)
                continue;
            results.Add(new O_ABB262A2(feature[Encoding.UTF8.GetString(Convert.FromBase64String("c+DEZA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PYGpAa/RPV8=")[iii % 8])).ToArray())].ToString(), feature[Encoding.UTF8.GetString(Convert.FromBase64String("seeXdwNC6Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8obnA2oth/8=")[iii % 8])).ToArray())].ToString(), state));
        }

        foreach (var result in results.OrderBy(r => r.Name))
        {
            yield return result;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string gahQQMap)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxCharCount(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var results = new List<O_ABB262A2>();
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("Zo1Ozqf7rNNi0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FOIhuvuYxb4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("o+UlCH2cSdKRzQxhfakZ6JnPB2F3phrokcwFHkqpHfnQ5jsCc+g+9Z6TWxJxuB31n84IIXitCOiF0gw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8KBpTT7IaZw=")[iii % 8])).ToArray()));
        var featureList = wmiData.Get();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DXSyhCVdfuFHaLOcLV1+4UQ5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dkSeqR0gXpo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("djovbw0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JU5OG2gk+X0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hqdQ7Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yMY9iNHj9rw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sFhC33L53A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8zkyqxuWsts=")[iii % 8])).ToArray()));
        foreach (var feature in featureList)
        {
            var state = (OptionalFeatureState)Enum.Parse(typeof(OptionalFeatureState), feature[Encoding.UTF8.GetString(Convert.FromBase64String("bIX3pZA/AqJRivC0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JeuE0fFTbvE=")[iii % 8])).ToArray())].ToString());
            if (Runtime.FilterResults && state != OptionalFeatureState.Enabled)
                continue;
            results.Add(new O_ABB262A2(feature[Encoding.UTF8.GetString(Convert.FromBase64String("c+DEZA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PYGpAa/RPV8=")[iii % 8])).ToArray())].ToString(), feature[Encoding.UTF8.GetString(Convert.FromBase64String("seeXdwNC6Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8obnA2oth/8=")[iii % 8])).ToArray())].ToString(), state));
        }

        foreach (var result in results.OrderBy(r => r.Name))
        {
            yield return result;
        }
    }
}internal class O_ABB262A2 : O_4AED570F
{
    public O_ABB262A2(string name, string caption, OptionalFeatureState state)
    {
        Name = name;
        Caption = caption;
        State = state;
    }

    public string Name { get; }
    public string Caption { get; }
    public OptionalFeatureState State { get; }
}
    internal enum OptionalFeatureState
    {
        Enabled = 1,
        Disabled = 2,
        Absent = 3,
        Unknown = 4
    }

    [CommandOutputType(typeof(O_ABB262A2))]
    internal class O_2BCE3EFD : TextFormatterBase
    {
        public O_2BCE3EFD(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_ABB262A2)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("90xw2Yopk0a9UHHBgimTRr4B").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jHxc9LJUsz0=")[iii % 8])).ToArray()), dto.State, dto.Name, dto.Caption);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string uDNnmbRL)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxCharCount(61);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_ABB262A2)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("90xw2Yopk0a9UHHBgimTRr4B").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jHxc9LJUsz0=")[iii % 8])).ToArray()), dto.State, dto.Name, dto.Caption);
        }
    }
}