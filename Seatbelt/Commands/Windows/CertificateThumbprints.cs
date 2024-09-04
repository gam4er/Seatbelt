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
internal class O_4FA53271 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("rO0CfXOGmheO/BVdcpWeFp/6GWdukw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("74hwCRrg83Q=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("1K9Fi1P5LCLnq0mfUrA2PuHmTYBS+Tkm/uZIilKtMSz7pUqbRfkrPv20Ts9DvCo+4eZEgQCtMC+ytVKcVLw1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ksYr7yDZWEo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_4FA53271(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        foreach (var storeName in new Enum[]
        {
            StoreName.Root,
            StoreName.CertificateAuthority,
            StoreName.AuthRoot,
            StoreName.TrustedPeople,
            StoreName.TrustedPublisher
        }

        )
        {
            foreach (var storeLocation in new Enum[]
            {
                StoreLocation.CurrentUser,
                StoreLocation.LocalMachine
            }

            )
            {
                var store = new X509Store((StoreName)storeName, (StoreLocation)storeLocation);
                store.Open(OpenFlags.ReadOnly);
                foreach (var certificate in store.Certificates)
                {
                    if (!Runtime.FilterResults || (Runtime.FilterResults && (DateTime.Compare(certificate.NotAfter, DateTime.Now) >= 0)))
                    {
                        yield return new O_67DBEBA0()
                        {
                            StoreName = $"{storeName}",
                            StoreLocation = $"{storeLocation}",
                            SimpleName = certificate.GetNameInfo(X509NameType.SimpleName, false),
                            Thumbprint = certificate.Thumbprint,
                            ExpiryDate = certificate.NotAfter,
                        };
                    }
                }
            }
        }
    }

internal class O_67DBEBA0 : O_4AED570F
{
    public string? StoreName { get; set; }
    public string? StoreLocation { get; set; }
    public string? SimpleName { get; set; }
    public string? Thumbprint { get; set; }
    public DateTime? ExpiryDate { get; set; }
}    [CommandOutputType(typeof(O_67DBEBA0))]
    internal class O_E5551361 : TextFormatterBase
    {
        public O_E5551361(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_67DBEBA0)result;
            WriteLine($"{dto.StoreLocation}\\{dto.StoreName} - {dto.Thumbprint} ({dto.SimpleName}) {dto.ExpiryDate}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string kUtXCyMe)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(17);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_67DBEBA0)result;
            WriteLine($"{dto.StoreLocation}\\{dto.StoreName} - {dto.Thumbprint} ({dto.SimpleName}) {dto.ExpiryDate}");
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string IPaRcQdT)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(17);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        foreach (var storeName in new Enum[]
        {
            StoreName.Root,
            StoreName.CertificateAuthority,
            StoreName.AuthRoot,
            StoreName.TrustedPeople,
            StoreName.TrustedPublisher
        }

        )
        {
            foreach (var storeLocation in new Enum[]
            {
                StoreLocation.CurrentUser,
                StoreLocation.LocalMachine
            }

            )
            {
                var store = new X509Store((StoreName)storeName, (StoreLocation)storeLocation);
                store.Open(OpenFlags.ReadOnly);
                foreach (var certificate in store.Certificates)
                {
                    if (!Runtime.FilterResults || (Runtime.FilterResults && (DateTime.Compare(certificate.NotAfter, DateTime.Now) >= 0)))
                    {
                        yield return new O_67DBEBA0()
                        {
                            StoreName = $"{storeName}",
                            StoreLocation = $"{storeLocation}",
                            SimpleName = certificate.GetNameInfo(X509NameType.SimpleName, false),
                            Thumbprint = certificate.Thumbprint,
                            ExpiryDate = certificate.NotAfter,
                        };
                    }
                }
            }
        }
    }
}}