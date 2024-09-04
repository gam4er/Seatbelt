using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_884D1952 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("ozQYP1q/rQqLOhwl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("71VrSwnX2H4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ifQlTB6nNp+v+TQZKKgx2o/4PFxMpiOfr/k0GQCoNsv74ihKGKwon6j5JE0IpjLR+7knUA3pMde+sSNcC6A2y6noeBc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("25FROWzJRb8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_884D1952(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var shutdownBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xnuBr/ZY3HD6TKaJ3HnTVuES4srvVu9d4VC9l+9C6V3xTaWI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lSLS+7MVgDM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("a7BXBiwxJcZssU8X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ONgickheUqg=")[iii % 8])).ToArray()));
        if (shutdownBytes != null)
        {
            var shutdownInt = BitConverter.ToInt64(shutdownBytes, 0);
            var shutdownTime = DateTime.FromFileTime(shutdownInt);
            yield return new O_8BA5B3A3()
            {
                LastShutdown = shutdownTime
            };
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string OyTekoOe)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxCharCount(27);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var shutdownBytes = ThisRunTime.GetBinaryValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xnuBr/ZY3HD6TKaJ3HnTVuES4srvVu9d4VC9l+9C6V3xTaWI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lSLS+7MVgDM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("a7BXBiwxJcZssU8X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ONgickheUqg=")[iii % 8])).ToArray()));
        if (shutdownBytes != null)
        {
            var shutdownInt = BitConverter.ToInt64(shutdownBytes, 0);
            var shutdownTime = DateTime.FromFileTime(shutdownInt);
            yield return new O_8BA5B3A3()
            {
                LastShutdown = shutdownTime
            };
        }
    }
}internal class O_8BA5B3A3 : O_4AED570F
{
    public DateTime LastShutdown { get; set; }
}}