using System.Collections.Generic;
using System.Management;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_B17863BB : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("w5Zz8I+GLSHlknXikw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jfMHh+D0RnI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("8ZTPryP7DzTMmdqqKfpEcceB1Ksp7UR2xtHPsCmpCXXcmdK2KalMYtaQm48BwE0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v/G72EyJZBQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_B17863BB(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("pLyWbVgiHaKg4Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1tP5GQRBdM8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pIL84BRY9krXgeLqGiyBCZn0gvoEZLcSkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("98ewpVcM1mA=")[iii % 8])).ToArray()));
        using var data = wmiData.Get();
        foreach (ManagementObject result in data)
        {
            yield return new O_B872878D(result[Encoding.UTF8.GetString(Convert.FromBase64String("m3jciw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1Rmx7okbQo4=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("dqBqtQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JsEe3TjTvgE=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("gaNd0hXzTm+sqUA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xcYusWeaPhs=")[iii % 8])).ToArray())], (uint)result[Encoding.UTF8.GetString(Convert.FromBase64String("gBNzlA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9GoD8aLn1GA=")[iii % 8])).ToArray())]);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string qWzaoIiu)
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

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("pLyWbVgiHaKg4Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1tP5GQRBdM8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pIL84BRY9krXgeLqGiyBCZn0gvoEZLcSkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("98ewpVcM1mA=")[iii % 8])).ToArray()));
        using var data = wmiData.Get();
        foreach (ManagementObject result in data)
        {
            yield return new O_B872878D(result[Encoding.UTF8.GetString(Convert.FromBase64String("m3jciw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1Rmx7okbQo4=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("dqBqtQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JsEe3TjTvgE=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("gaNd0hXzTm+sqUA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xcYusWeaPhs=")[iii % 8])).ToArray())], (uint)result[Encoding.UTF8.GetString(Convert.FromBase64String("gBNzlA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9GoD8aLn1GA=")[iii % 8])).ToArray())]);
        }
    }
}internal class O_B872878D : O_4AED570F
{
    public O_B872878D(object name, object path, object description, uint type)
    {
        var typeDict = new Dictionary<uint, string>()
        {
            {
                0,
                Encoding.UTF8.GetString(Convert.FromBase64String("FtfxfZ4ae2gk2w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ur6CFr5eCQE=")[iii % 8])).ToArray())
            },
            {
                1,
                Encoding.UTF8.GetString(Convert.FromBase64String("GHJBm4pCYKEtdU0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SAAo9f5iMdQ=")[iii % 8])).ToArray())
            },
            {
                2,
                Encoding.UTF8.GetString(Convert.FromBase64String("pWBbN/jnzA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4QUtXpuC7PI=")[iii % 8])).ToArray())
            },
            {
                3,
                Encoding.UTF8.GetString(Convert.FromBase64String("nsyI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("15zLlsnX8ak=")[iii % 8])).ToArray())
            },
            {
                2147483648,
                Encoding.UTF8.GetString(Convert.FromBase64String("qh48damo9X2YEm9f7YHueg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ndPHonshxQ=")[iii % 8])).ToArray())
            },
            {
                2147483649,
                Encoding.UTF8.GetString(Convert.FromBase64String("mfB54HfQt9es93WuQpSLy6c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yYIQjgPw5qI=")[iii % 8])).ToArray())
            },
            {
                2147483650,
                Encoding.UTF8.GetString(Convert.FromBase64String("ZfKmLjN9W8dF+rkp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IZfQR1AYe4Y=")[iii % 8])).ToArray())
            },
            {
                2147483651,
                Encoding.UTF8.GetString(Convert.FromBase64String("tFYquts7mX6T").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/QZpmppf9Bc=")[iii % 8])).ToArray())
            },
        };
        Name = name;
        Path = path;
        Description = description;
        Type = typeDict[type];
    }

    public object Name { get; }
    public object Path { get; }
    public object Description { get; }
    public object Type { get; }
}}