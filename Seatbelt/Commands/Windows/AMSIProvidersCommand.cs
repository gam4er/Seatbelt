using Microsoft.Win32;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_82EC1E73 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("5ykPFl+W93zPADktfA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pmRcXw/kmAo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("M+GckoCbYp8Qs4GBjpZ0mQbhloDJmWifQ9K+t6A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y5Pz5On/B+0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_82EC1E73(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var providers = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("jUTa1tiOIOuCRvXh/aABwbh/wMPCnDvyjnnz9OarF9yt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3gucgo/Pcq4=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        foreach (var provider in providers)
        {
            var ProviderPath = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Classes\\CLSID\\{provider}\\InprocServer32", Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kHDVNHlz0w8=")[iii % 8])).ToArray()));
            yield return new O_144B124F(provider, ProviderPath);
        }
    }

internal class O_144B124F : O_4AED570F
{
    public O_144B124F(string guid, string? providerPath)
    {
        GUID = guid;
        ProviderPath = providerPath;
    }

    public string GUID { get; set; }
    public string? ProviderPath { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string YbygrKTf)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                    instance.GetEra(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var providers = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("jUTa1tiOIOuCRvXh/aABwbh/wMPCnDvyjnnz9OarF9yt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3gucgo/Pcq4=")[iii % 8])).ToArray())) ?? new string[]
        {
        };
        foreach (var provider in providers)
        {
            var ProviderPath = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Classes\\CLSID\\{provider}\\InprocServer32", Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kHDVNHlz0w8=")[iii % 8])).ToArray()));
            yield return new O_144B124F(provider, ProviderPath);
        }
    }
}}