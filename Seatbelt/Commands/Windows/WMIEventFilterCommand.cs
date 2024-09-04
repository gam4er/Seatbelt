using System.Collections.Generic;
using System.Management;
using System.Security.Principal;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_E64AECC6 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("ZYpSZE4WHw50rndVXQE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MscbIThzcXo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("zAUpSe8KDLDJTB9L+UQv3cYFNkn5WCg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gGxaPZwqW/0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_E64AECC6(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var EventFilterClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("YooVtPBMLh1ihU6K0WATIE6iUofMOT4We6BehtZFCCVKs0k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PtY76KIDYUk=")[iii % 8])).ToArray()));
        foreach (ManagementObject EventFilter in EventFilterClass.GetInstances())
        {
            var sidBytes = (byte[])EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("ASDpAhU8lhcLFg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QlKMY2FT5EQ=")[iii % 8])).ToArray())];
            var creatorSid = new SecurityIdentifier(sidBytes, 0);
            yield return new O_205563B5(EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("g6nAyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zcitrAQO79A=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("txYQ4ZckwqupChs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6EleoNphkfs=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("LLnJplM/tpIMvNypRBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ac+syCdx1/8=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("x581uag=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lupQy9GgEkM=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("xRjxepQNwsjzGPVviA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lG2UCO1Bo6Y=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("wB+Jv5oZrzzgGp8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hWns0e5YzF8=")[iii % 8])).ToArray())], creatorSid);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string hiHOzFgz)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.KoreanLunisolarCalendar instance = new System.Globalization.KoreanLunisolarCalendar();
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

        var EventFilterClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String("YooVtPBMLh1ihU6K0WATIE6iUofMOT4We6BehtZFCCVKs0k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PtY76KIDYUk=")[iii % 8])).ToArray()));
        foreach (ManagementObject EventFilter in EventFilterClass.GetInstances())
        {
            var sidBytes = (byte[])EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("ASDpAhU8lhcLFg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QlKMY2FT5EQ=")[iii % 8])).ToArray())];
            var creatorSid = new SecurityIdentifier(sidBytes, 0);
            yield return new O_205563B5(EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("g6nAyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zcitrAQO79A=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("txYQ4ZckwqupChs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6EleoNphkfs=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("LLnJplM/tpIMvNypRBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ac+syCdx1/8=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("x581uag=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lupQy9GgEkM=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("xRjxepQNwsjzGPVviA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lG2UCO1Bo6Y=")[iii % 8])).ToArray())], EventFilter[Encoding.UTF8.GetString(Convert.FromBase64String("wB+Jv5oZrzzgGp8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hWns0e5YzF8=")[iii % 8])).ToArray())], creatorSid);
        }
    }
}internal class O_205563B5 : O_4AED570F
{
    public O_205563B5(object name, object ns, object eventNamespace, object query, object queryLanguage, object eventAccess, object creatorSid)
    {
        Name = name;
        Namespace = ns;
        EventNamespace = eventNamespace;
        Query = query;
        QueryLanguage = queryLanguage;
        EventAccess = eventAccess;
        CreatorSid = creatorSid;
    }

    public object Name { get; }
    public object Namespace { get; }
    public object EventNamespace { get; }
    public object Query { get; }
    public object QueryLanguage { get; }
    public object EventAccess { get; }
    public object CreatorSid { get; }
}}