#nullable disable
using System.Collections.Generic;
using System.Management;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_6D37288A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("DslwY2AMxJcq3mVg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q6gAEwVogOU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("4aGDnKQMhYjVopaLswvBl92kg533A9OM1fKxo54C").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tNLm7tcrpeU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_6D37288A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("dZnqY2Pm8L1xxA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B/aFFz+FmdA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("x35U7q/nACS0fUrkoZNXZ/oIKvSC1lR5+0lzyIPdTmv3T3HEgg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lDsYq+yzIA4=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("mBhjt5yUOr6nEGWiitAyjLwYM5C0uTPw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1XkTx/nwGvo=")[iii % 8])).ToArray()));
        foreach (ManagementObject result in data)
        {
            yield return new O_52290D54()
            {
                LocalName = result[Encoding.UTF8.GetString(Convert.FromBase64String("GB2tM4RGbIMx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VHLOUugIDe4=")[iii % 8])).ToArray())].ToString(),
                RemoteName = result[Encoding.UTF8.GetString(Convert.FromBase64String("77LmP4M8wbDQsg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vdeLUPdZj9E=")[iii % 8])).ToArray())].ToString(),
                RemotePath = result[Encoding.UTF8.GetString(Convert.FromBase64String("nkOP1+8L0SG4Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zCbiuJtugUA=")[iii % 8])).ToArray())].ToString(),
                Status = result[Encoding.UTF8.GetString(Convert.FromBase64String("GSHp+gjn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SlWIjn2UTIg=")[iii % 8])).ToArray())].ToString(),
                ConnectionState = result[Encoding.UTF8.GetString(Convert.FromBase64String("i9I2gPy2NxWn0wua+KEm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yL1Y7pnVQ3w=")[iii % 8])).ToArray())].ToString(),
                Persistent = result[Encoding.UTF8.GetString(Convert.FromBase64String("0Avc+PNRJw7uGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gG6ui5oiU2s=")[iii % 8])).ToArray())].ToString(),
                UserName = result[Encoding.UTF8.GetString(Convert.FromBase64String("esf+tbEbluc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7Sbx/96+4I=")[iii % 8])).ToArray())].ToString(),
                Description = result[Encoding.UTF8.GetString(Convert.FromBase64String("im7qxz5t9E2nZPc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zguZpEwEhDk=")[iii % 8])).ToArray())].ToString()
            };
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string EQKivTot)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                    instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("dZnqY2Pm8L1xxA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B/aFFz+FmdA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("x35U7q/nACS0fUrkoZNXZ/oIKvSC1lR5+0lzyIPdTmv3T3HEgg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lDsYq+yzIA4=")[iii % 8])).ToArray()));
        var data = wmiData.Get();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("mBhjt5yUOr6nEGWiitAyjLwYM5C0uTPw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1XkTx/nwGvo=")[iii % 8])).ToArray()));
        foreach (ManagementObject result in data)
        {
            yield return new O_52290D54()
            {
                LocalName = result[Encoding.UTF8.GetString(Convert.FromBase64String("GB2tM4RGbIMx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VHLOUugIDe4=")[iii % 8])).ToArray())].ToString(),
                RemoteName = result[Encoding.UTF8.GetString(Convert.FromBase64String("77LmP4M8wbDQsg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vdeLUPdZj9E=")[iii % 8])).ToArray())].ToString(),
                RemotePath = result[Encoding.UTF8.GetString(Convert.FromBase64String("nkOP1+8L0SG4Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zCbiuJtugUA=")[iii % 8])).ToArray())].ToString(),
                Status = result[Encoding.UTF8.GetString(Convert.FromBase64String("GSHp+gjn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SlWIjn2UTIg=")[iii % 8])).ToArray())].ToString(),
                ConnectionState = result[Encoding.UTF8.GetString(Convert.FromBase64String("i9I2gPy2NxWn0wua+KEm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yL1Y7pnVQ3w=")[iii % 8])).ToArray())].ToString(),
                Persistent = result[Encoding.UTF8.GetString(Convert.FromBase64String("0Avc+PNRJw7uGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gG6ui5oiU2s=")[iii % 8])).ToArray())].ToString(),
                UserName = result[Encoding.UTF8.GetString(Convert.FromBase64String("esf+tbEbluc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7Sbx/96+4I=")[iii % 8])).ToArray())].ToString(),
                Description = result[Encoding.UTF8.GetString(Convert.FromBase64String("im7qxz5t9E2nZPc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zguZpEwEhDk=")[iii % 8])).ToArray())].ToString()
            };
        }
    }
}internal class O_52290D54 : O_4AED570F
{
    public string LocalName { get; set; }
    public string RemoteName { get; set; }
    public string RemotePath { get; set; }
    public string Status { get; set; }
    public string ConnectionState { get; set; }
    public string Persistent { get; set; }
    public string UserName { get; set; }
    public string Description { get; set; }
}}
#nullable enable
