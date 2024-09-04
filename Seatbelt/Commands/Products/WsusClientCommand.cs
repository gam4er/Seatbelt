using System.Collections.Generic;
using Microsoft.Win32;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_28318AC3 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("8whnvw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pFsy7MgqF3c=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+ZyRr16xiCX9kI29VLTbUN6Rnr9U5qhg3IOWqFS12y35pqqYGOaIYNqBlqVWtdclx5PfqkG2l2zNlJ2nVA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rvX/yzHG+wU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_28318AC3(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        yield return new O_442EB30E((ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("PnfRT5xopTIxaPh3okqeEh5k2nKoW5gEAl7jR5xAmRMCT+RHnECZEwJP5E67TZYDCGTWTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bTiXG8sp93c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Ri28U1rwfWxlO6s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E17ZBA+jGB4=")[iii % 8])).ToArray())) == 1), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("HJkAeLbrDtQThilAiMk19DyKC0WC2DPiILAycLbDMvUgoTVwtsMy9SChNXmRzj3lKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T9ZGLOGqXJE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("oniB2f7DGpM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9S3SvIy1f+E=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("133LH4Nj7KLYYuInvUHXgvduwCK3UNGU61T5F4NL0IPrRf4Xg0vQg+tF/h6kRt+T4Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hDKNS9Qivuc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/W6ut9/ZmdjaaKO1zum40elyvrPZ0qvJzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qB7K1qu8yr0=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Pj0wcPRRX58xIhlIynNkvx4uO03AYmKpAhQCePR5Y74CBQV49HljvgIFBXHTdGyuCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bXJ2JKMQDdo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YerRiT7TAxRl2vCLOtU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nr+C/V+ndmc=")[iii % 8])).ToArray())));
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string vmFegHQB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.X509Certificates.X509Certificate instance = new System.Security.Cryptography.X509Certificates.X509Certificate();
                    instance.ToString(true);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        yield return new O_442EB30E((ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("PnfRT5xopTIxaPh3okqeEh5k2nKoW5gEAl7jR5xAmRMCT+RHnECZEwJP5E67TZYDCGTWTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bTiXG8sp93c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Ri28U1rwfWxlO6s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E17ZBA+jGB4=")[iii % 8])).ToArray())) == 1), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("HJkAeLbrDtQThilAiMk19DyKC0WC2DPiILAycLbDMvUgoTVwtsMy9SChNXmRzj3lKg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T9ZGLOGqXJE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("oniB2f7DGpM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9S3SvIy1f+E=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("133LH4Nj7KLYYuInvUHXgvduwCK3UNGU61T5F4NL0IPrRf4Xg0vQg+tF/h6kRt+T4Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hDKNS9Qivuc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("/W6ut9/ZmdjaaKO1zum40elyvrPZ0qvJzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qB7K1qu8yr0=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Pj0wcPRRX58xIhlIynNkvx4uO03AYmKpAhQCePR5Y74CBQV49HljvgIFBXHTdGyuCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bXJ2JKMQDdo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YerRiT7TAxRl2vCLOtU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nr+C/V+ndmc=")[iii % 8])).ToArray())));
    }
}internal class O_442EB30E : O_4AED570F
{
    public O_442EB30E(bool? useWuServer, string? server, string? alternateServer, string? statisticsServer)
    {
        UseWUServer = useWuServer;
        Server = server;
        AlternateServer = alternateServer;
        StatisticsServer = statisticsServer;
    }

    public bool? UseWUServer { get; set; }
    public string? Server { get; set; }
    public string? AlternateServer { get; set; }
    public string? StatisticsServer { get; set; }
}}