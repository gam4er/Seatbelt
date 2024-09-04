using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_9DD2A65C : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("9eNYvB6Fzc7Y3VmnG5zC388=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vI0ryH/poas=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("I/K9RkTRe1QOvL5AStliUh7v7kRM3DdFAvnuQEDafkIe7rc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("apzOMiW9FzE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_9DD2A65C(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string[] productKeys =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("gN8wkm/TN8ePxxmxDqZWsJ3/EqNk3wzhof8FqV7mOdW6/hKpT+E5wabiBKNW5jPnoeMfqVbOMOy6/gWyWf4J3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("05B2xjiSZYI=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("W5fppAOschhUlcaTJoJTMm6s86c9g0Qyf6vzsyGfUjhmrPmVJp5JMmaE+p49g1MpabTD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CNiv8FTtIF0=")[iii % 8])).ToArray())
        };
        foreach (var productKey in productKeys)
        {
            var architecture = Encoding.UTF8.GetString(Convert.FromBase64String("BDUX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fA0hVwdAf78=")[iii % 8])).ToArray());
            if (productKey.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("EKqX93spmhgfqLjAXge7MiWRjfRFBqwyNJaN4FkaujgtkYfGXhuhMi25hM1FBrspIom9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q+XRoyxoyF0=")[iii % 8])).ToArray())))
            {
                architecture = Encoding.UTF8.GetString(Convert.FromBase64String("NxRn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TyJT5C3N5DU=")[iii % 8])).ToArray());
            }

            var subkeyNames = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, productKey) ?? new string[]
            {
            };
            foreach (var subkeyName in subkeyNames)
            {
                var DisplayName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("3nFa5VQ2NHj7dUw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mhgplThXTTY=")[iii % 8])).ToArray()));
                var DisplayVersion = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("xDiDZRGgBIPlI4N8Eq8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gFHwFX3BfdU=")[iii % 8])).ToArray()));
                var Publisher = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("kZhxJbUnoFqz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("we0TSdxUyD8=")[iii % 8])).ToArray()));
                var InstallDateStr = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("0Uz5aRN1nfj5Vu9OBms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mCKKHXIZ8bw=")[iii % 8])).ToArray()));
                var InstallDate = new DateTime();
                if (InstallDateStr != null && !String.IsNullOrEmpty(InstallDateStr))
                {
                    try
                    {
                        var year = InstallDateStr.Substring(0, 4);
                        var month = InstallDateStr.Substring(4, 2);
                        var day = InstallDateStr.Substring(6, 2);
                        var date = $"{year}-{month}-{day}";
                        InstallDate = DateTime.Parse(date);
                    }
                    catch
                    {
                    }
                }

                if (DisplayName != null && !String.IsNullOrEmpty(DisplayName))
                {
                    yield return new O_D9C8973D(DisplayName, DisplayVersion, Publisher, InstallDate, architecture);
                }
            }
        }
    }

internal class O_D9C8973D : O_4AED570F
{
    public O_D9C8973D(string displayName, string? displayVersion, string? publisher, DateTime installDate, string architecture)
    {
        DisplayName = displayName;
        DisplayVersion = displayVersion;
        Publisher = publisher;
        InstallDate = installDate;
        Architecture = architecture;
    }

    public string DisplayName { get; }
    public string? DisplayVersion { get; }
    public string? Publisher { get; }
    public DateTime InstallDate { get; }
    public string Architecture { get; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string oiNkVpep)
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

        string[] productKeys =
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("gN8wkm/TN8ePxxmxDqZWsJ3/EqNk3wzhof8FqV7mOdW6/hKpT+E5wabiBKNW5jPnoeMfqVbOMOy6/gWyWf4J3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("05B2xjiSZYI=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("W5fppAOschhUlcaTJoJTMm6s86c9g0Qyf6vzsyGfUjhmrPmVJp5JMmaE+p49g1MpabTD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CNiv8FTtIF0=")[iii % 8])).ToArray())
        };
        foreach (var productKey in productKeys)
        {
            var architecture = Encoding.UTF8.GetString(Convert.FromBase64String("BDUX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fA0hVwdAf78=")[iii % 8])).ToArray());
            if (productKey.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("EKqX93spmhgfqLjAXge7MiWRjfRFBqwyNJaN4FkaujgtkYfGXhuhMi25hM1FBrspIom9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q+XRoyxoyF0=")[iii % 8])).ToArray())))
            {
                architecture = Encoding.UTF8.GetString(Convert.FromBase64String("NxRn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TyJT5C3N5DU=")[iii % 8])).ToArray());
            }

            var subkeyNames = ThisRunTime.GetSubkeyNames(RegistryHive.LocalMachine, productKey) ?? new string[]
            {
            };
            foreach (var subkeyName in subkeyNames)
            {
                var DisplayName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("3nFa5VQ2NHj7dUw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mhgplThXTTY=")[iii % 8])).ToArray()));
                var DisplayVersion = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("xDiDZRGgBIPlI4N8Eq8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gFHwFX3BfdU=")[iii % 8])).ToArray()));
                var Publisher = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("kZhxJbUnoFqz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("we0TSdxUyD8=")[iii % 8])).ToArray()));
                var InstallDateStr = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"{productKey}\\{subkeyName}", Encoding.UTF8.GetString(Convert.FromBase64String("0Uz5aRN1nfj5Vu9OBms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mCKKHXIZ8bw=")[iii % 8])).ToArray()));
                var InstallDate = new DateTime();
                if (InstallDateStr != null && !String.IsNullOrEmpty(InstallDateStr))
                {
                    try
                    {
                        var year = InstallDateStr.Substring(0, 4);
                        var month = InstallDateStr.Substring(4, 2);
                        var day = InstallDateStr.Substring(6, 2);
                        var date = $"{year}-{month}-{day}";
                        InstallDate = DateTime.Parse(date);
                    }
                    catch
                    {
                    }
                }

                if (DisplayName != null && !String.IsNullOrEmpty(DisplayName))
                {
                    yield return new O_D9C8973D(DisplayName, DisplayVersion, Publisher, InstallDate, architecture);
                }
            }
        }
    }
}}