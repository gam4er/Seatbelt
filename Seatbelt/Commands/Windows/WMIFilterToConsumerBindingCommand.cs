using System.Collections.Generic;
using System.Management;
using System.Security.Principal;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_839DD5D8 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("1Xg0lrJL3PLwdxS+v07G8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gjV90NsnqJc=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("oP5ENa6Dgz2lt3EosdexAszjWGGezLoDmfpSM/3hvR6I/lkmrg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7Jc3Qd2j1HA=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_839DD5D8(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var BindingrClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("i4+PMzu50vaLgNQNGpXvy6enyAAHzML9kbrNGwyEyc2UvM8cHJv40JW6zwsAmPo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("19Ohb2n2naI=")[iii % 8])).ToArray()));
        foreach (ManagementObject Binding in BindingrClass.GetInstances())
        {
            var sidBytes = (byte[])Binding[Encoding.UTF8.GetString(Convert.FromBase64String("D2rws+hT/WkFXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TBiV0pw8jzo=")[iii % 8])).ToArray())];
            var CreatorSID = new SecurityIdentifier(sidBytes, 0);
            yield return new O_E54BD80E(Binding[Encoding.UTF8.GetString(Convert.FromBase64String("dzOaAjyb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MVr2dlnpaJg=")[iii % 8])).ToArray())], Binding[Encoding.UTF8.GetString(Convert.FromBase64String("H/N2s85EoFA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XJwYwLspxSI=")[iii % 8])).ToArray())], CreatorSID);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ASQkLEpA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                    instance.GetMaxByteCount(0);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var BindingrClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("i4+PMzu50vaLgNQNGpXvy6enyAAHzML9kbrNGwyEyc2UvM8cHJv40JW6zwsAmPo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("19Ohb2n2naI=")[iii % 8])).ToArray()));
        foreach (ManagementObject Binding in BindingrClass.GetInstances())
        {
            var sidBytes = (byte[])Binding[Encoding.UTF8.GetString(Convert.FromBase64String("D2rws+hT/WkFXA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TBiV0pw8jzo=")[iii % 8])).ToArray())];
            var CreatorSID = new SecurityIdentifier(sidBytes, 0);
            yield return new O_E54BD80E(Binding[Encoding.UTF8.GetString(Convert.FromBase64String("dzOaAjyb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MVr2dlnpaJg=")[iii % 8])).ToArray())], Binding[Encoding.UTF8.GetString(Convert.FromBase64String("H/N2s85EoFA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XJwYwLspxSI=")[iii % 8])).ToArray())], CreatorSID);
        }
    }
}internal class O_E54BD80E : O_4AED570F
{
    public O_E54BD80E(object consumer, object filter, object creatorSid)
    {
        Consumer = consumer;
        Filter = filter;
        CreatorSID = creatorSid;
    }

    public object Consumer { get; }
    public object Filter { get; }
    public object CreatorSID { get; }
}}