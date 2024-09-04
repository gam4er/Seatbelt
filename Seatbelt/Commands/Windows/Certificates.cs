using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_8DF26989 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Ny/OF8tHPJ0VPtkQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dEq8Y6IhVf4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ESirvbDNZVsyM+W4rYkwRTYirbCtiDBYMjO2tq2MfAg0JLetqot5SzY1oPmlhHxNJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V0HF2cPtECg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_8DF26989(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        foreach (var storeLocation in new Enum[]
        {
            StoreLocation.CurrentUser,
            StoreLocation.LocalMachine
        }

        )
        {
            var store = new X509Store(StoreName.My, (StoreLocation)storeLocation);
            store.Open(OpenFlags.ReadOnly);
            foreach (var certificate in store.Certificates)
            {
                var template = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wFnSpp8rIyM=")[iii % 8])).ToArray());
                var enhancedKeyUsages = new List<string>();
                bool? keyExportable = false;
                try
                {
                    certificate.PrivateKey.ToXmlString(true);
                    keyExportable = true;
                }
                catch (Exception e)
                {
                    keyExportable = !e.Message.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("63UycDskpgvhOiA/P2W/EeA6Lz5tNroH5nMgOSgh6hHxezI1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hRpGUE1FymI=")[iii % 8])).ToArray()));
                }

                foreach (var ext in certificate.Extensions)
                {
                    if (ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("fYaco0/nYckYo5G7AdF3zF+N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OOj0wiGEBK0=")[iii % 8])).ToArray()))
                    {
                        var extUsages = ((X509EnhancedKeyUsageExtension)ext).EnhancedKeyUsages;
                        if (extUsages.Count == 0)
                            continue;
                        foreach (var extUsage in extUsages)
                        {
                            enhancedKeyUsages.Add(extUsage.FriendlyName);
                        }
                    }
                    else if (ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("cyxRMa6/sr5RPUZlk7y2rVwoVyDnl7qwVQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MEkjRcfZ290=")[iii % 8])).ToArray()) || ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("bl8Yf9sVR8tMTg8r5hZD2EFbHm6SOkDOQkgHasYaQcY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTpqC7JzLqg=")[iii % 8])).ToArray()))
                    {
                        template = ext.Format(false);
                    }
                }

                if (!Runtime.FilterResults || (Runtime.FilterResults && (DateTime.Compare(certificate.NotAfter, DateTime.Now) >= 0)))
                {
                    yield return new O_4EA69D19()
                    {
                        StoreLocation = $"{storeLocation}",
                        Issuer = certificate.Issuer,
                        Subject = certificate.Subject,
                        ValidDate = certificate.NotBefore,
                        ExpiryDate = certificate.NotAfter,
                        HasPrivateKey = certificate.HasPrivateKey,
                        KeyExportable = keyExportable,
                        Template = template,
                        Thumbprint = certificate.Thumbprint,
                        EnhancedKeyUsages = enhancedKeyUsages
                    };
                }
            }
        }
    }

internal class O_4EA69D19 : O_4AED570F
{
    public string? StoreLocation { get; set; }
    public string? Issuer { get; set; }
    public string? Subject { get; set; }
    public DateTime? ValidDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public bool? HasPrivateKey { get; set; }
    public bool? KeyExportable { get; set; }
    public string? Thumbprint { get; set; }
    public string? Template { get; set; }
    public List<string>? EnhancedKeyUsages { get; set; }
}    [CommandOutputType(typeof(O_4EA69D19))]
    internal class O_7688F296 : TextFormatterBase
    {
        public O_7688F296(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_4EA69D19)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("41I3UJRjgJ2sEQVQkn6L8eNSRATbK8Wq8w8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w3JkJPsR5dE=")[iii % 8])).ToArray()), dto.StoreLocation);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2sHGSHxf/Drawa8bLwq5aNrBrxsvELkzypw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+uGPOw8qmUg=")[iii % 8])).ToArray()), dto.Issuer);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IWFwTMPeJ9V1YQMZgZRiliFhAxmBjmLNMTw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AUEjOaG0QrY=")[iii % 8])).ToArray()), dto.Subject);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("D+/QciZju0ZOu+Mzair/Ig/vpjNqMP95H7I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L8+GE0oK3wI=")[iii % 8])).ToArray()), dto.ValidDate);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AWjPLQ8xszNlKf4wX3jhagFoqnVfYuExETU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IUiKVX9YwUo=")[iii % 8])).ToArray()), dto.ExpiryDate);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z8joflnrnOaZidR6Yd6Xr8/IgD8Kgc7035U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7+igHyq77o8=")[iii % 8])).ToArray()), dto.HasPrivateKey);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b3q0IWsZcb0gKIslcDBs7W9632QyZim2fyc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T1r/RBJcCc0=")[iii % 8])).ToArray()), dto.KeyExportable);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OK4Y6lZguFRq5yL2Ay36BDiubKIDN/pfKPM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GI5MgiMN2iQ=")[iii % 8])).ToArray()), dto.Thumbprint);
            if (!string.IsNullOrEmpty(dto.Template))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JdC/DKEi8qxxlctJ7HK+7SXQy0nsaL62NY0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BfDracxSns0=")[iii % 8])).ToArray()), dto.Template);
            }

            if (dto.EnhancedKeyUsages?.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SUhOLnIPvVYMDEAlYzugVA4NeGA6VA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aWgLQBpu0zU=")[iii % 8])).ToArray()));
                foreach (var eku in dto.EnhancedKeyUsages)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vcKo0x1sfFetn/PCQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("neKI8z1MXCw=")[iii % 8])).ToArray()), eku, eku == Encoding.UTF8.GetString(Convert.FromBase64String("UMgyEz8U/dRm0DMTPxS09nLQMhk/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E6RbdlFg3ZU=")[iii % 8])).ToArray()) ? Encoding.UTF8.GetString(Convert.FromBase64String("w7JGNlDr9lvD0QNkBNmxb4DzEnNQ2aQmluEDclDWuHTD8Qp/Fd6jJoLnEn4V3qNvgPMSfx/e9g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("45JmFnCw1wY=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K7c2pJLc0pc=")[iii % 8])).ToArray()));
                }
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string mfPYDRre)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Collections.SortedList instance = new System.Collections.SortedList();
                        instance.GetByIndex(45);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_4EA69D19)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("41I3UJRjgJ2sEQVQkn6L8eNSRATbK8Wq8w8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w3JkJPsR5dE=")[iii % 8])).ToArray()), dto.StoreLocation);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2sHGSHxf/Drawa8bLwq5aNrBrxsvELkzypw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+uGPOw8qmUg=")[iii % 8])).ToArray()), dto.Issuer);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IWFwTMPeJ9V1YQMZgZRiliFhAxmBjmLNMTw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AUEjOaG0QrY=")[iii % 8])).ToArray()), dto.Subject);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("D+/QciZju0ZOu+Mzair/Ig/vpjNqMP95H7I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L8+GE0oK3wI=")[iii % 8])).ToArray()), dto.ValidDate);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("AWjPLQ8xszNlKf4wX3jhagFoqnVfYuExETU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IUiKVX9YwUo=")[iii % 8])).ToArray()), dto.ExpiryDate);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z8joflnrnOaZidR6Yd6Xr8/IgD8Kgc7035U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7+igHyq77o8=")[iii % 8])).ToArray()), dto.HasPrivateKey);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("b3q0IWsZcb0gKIslcDBs7W9632QyZim2fyc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T1r/RBJcCc0=")[iii % 8])).ToArray()), dto.KeyExportable);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OK4Y6lZguFRq5yL2Ay36BDiubKIDN/pfKPM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GI5MgiMN2iQ=")[iii % 8])).ToArray()), dto.Thumbprint);
            if (!string.IsNullOrEmpty(dto.Template))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JdC/DKEi8qxxlctJ7HK+7SXQy0nsaL62NY0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BfDracxSns0=")[iii % 8])).ToArray()), dto.Template);
            }

            if (dto.EnhancedKeyUsages?.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SUhOLnIPvVYMDEAlYzugVA4NeGA6VA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aWgLQBpu0zU=")[iii % 8])).ToArray()));
                foreach (var eku in dto.EnhancedKeyUsages)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vcKo0x1sfFetn/PCQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("neKI8z1MXCw=")[iii % 8])).ToArray()), eku, eku == Encoding.UTF8.GetString(Convert.FromBase64String("UMgyEz8U/dRm0DMTPxS09nLQMhk/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E6RbdlFg3ZU=")[iii % 8])).ToArray()) ? Encoding.UTF8.GetString(Convert.FromBase64String("w7JGNlDr9lvD0QNkBNmxb4DzEnNQ2aQmluEDclDWuHTD8Qp/Fd6jJoLnEn4V3qNvgPMSfx/e9g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("45JmFnCw1wY=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K7c2pJLc0pc=")[iii % 8])).ToArray()));
                }
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string XvHaESMQ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Collections.SortedList instance = new System.Collections.SortedList();
                    instance.GetByIndex(45);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        foreach (var storeLocation in new Enum[]
        {
            StoreLocation.CurrentUser,
            StoreLocation.LocalMachine
        }

        )
        {
            var store = new X509Store(StoreName.My, (StoreLocation)storeLocation);
            store.Open(OpenFlags.ReadOnly);
            foreach (var certificate in store.Certificates)
            {
                var template = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wFnSpp8rIyM=")[iii % 8])).ToArray());
                var enhancedKeyUsages = new List<string>();
                bool? keyExportable = false;
                try
                {
                    certificate.PrivateKey.ToXmlString(true);
                    keyExportable = true;
                }
                catch (Exception e)
                {
                    keyExportable = !e.Message.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("63UycDskpgvhOiA/P2W/EeA6Lz5tNroH5nMgOSgh6hHxezI1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hRpGUE1FymI=")[iii % 8])).ToArray()));
                }

                foreach (var ext in certificate.Extensions)
                {
                    if (ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("fYaco0/nYckYo5G7AdF3zF+N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OOj0wiGEBK0=")[iii % 8])).ToArray()))
                    {
                        var extUsages = ((X509EnhancedKeyUsageExtension)ext).EnhancedKeyUsages;
                        if (extUsages.Count == 0)
                            continue;
                        foreach (var extUsage in extUsages)
                        {
                            enhancedKeyUsages.Add(extUsage.FriendlyName);
                        }
                    }
                    else if (ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("cyxRMa6/sr5RPUZlk7y2rVwoVyDnl7qwVQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MEkjRcfZ290=")[iii % 8])).ToArray()) || ext.Oid.FriendlyName == Encoding.UTF8.GetString(Convert.FromBase64String("bl8Yf9sVR8tMTg8r5hZD2EFbHm6SOkDOQkgHasYaQcY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTpqC7JzLqg=")[iii % 8])).ToArray()))
                    {
                        template = ext.Format(false);
                    }
                }

                if (!Runtime.FilterResults || (Runtime.FilterResults && (DateTime.Compare(certificate.NotAfter, DateTime.Now) >= 0)))
                {
                    yield return new O_4EA69D19()
                    {
                        StoreLocation = $"{storeLocation}",
                        Issuer = certificate.Issuer,
                        Subject = certificate.Subject,
                        ValidDate = certificate.NotBefore,
                        ExpiryDate = certificate.NotAfter,
                        HasPrivateKey = certificate.HasPrivateKey,
                        KeyExportable = keyExportable,
                        Template = template,
                        Thumbprint = certificate.Thumbprint,
                        EnhancedKeyUsages = enhancedKeyUsages
                    };
                }
            }
        }
    }
}}