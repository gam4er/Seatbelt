#nullable disable
using System;
using System.Collections.Generic;
using static O_F41F88FA.Interop.Secur32;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_C26B49D9 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("UyJAdBRRLalQJkBqB188ow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AEcjAWY4WdA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("XW/PmIyYz3x9cpqBgY+Oe31iz4eAntcoaGDZnoiNy3s4Ys+Hm4/AfHR4mpSfi8dkeWPWkMmf3WF2Zpqwh5/DbWpgzpC6j819amjOjLmLzWN5Zt+GqMKH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GAG69enqrgg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_C26B49D9(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("WuHGKwV+EE4p1MQ9HHYDUnqOrw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CYSlXncXZDc=")[iii % 8])).ToArray()));
        var securityPackages = new List<O_DED810D6>();
        var ret = EnumerateSecurityPackages(out var pcPackages, out var ppPackageInfo);
        var ppPackageInfoItr = ppPackageInfo;
        for (ulong i = 0; i < pcPackages; i++)
        {
            var packageInfo = (SecPkgInfo)Marshal.PtrToStructure(ppPackageInfoItr, typeof(SecPkgInfo));
            var securityPackage = new O_DED810D6()
{
    Name = packageInfo.Name.ToString(),
    Comment = packageInfo.Comment.ToString(),
    Capabilities = packageInfo.fCapabilities,
    MaxToken = packageInfo.cbMaxToken,
    RPCID = packageInfo.wRPCID,
    Version = packageInfo.wVersion
};
            securityPackages.Add(securityPackage);
            ppPackageInfoItr = (IntPtr)((long)ppPackageInfoItr.ToInt64() + Marshal.SizeOf(typeof(SecPkgInfo)));
        }

        foreach (var securityPackage in securityPackages)
        {
            yield return securityPackage;
        }

        FreeContextBuffer(ppPackageInfo);
    }

internal class O_DED810D6 : O_4AED570F
{
    public string Name { get; set; }
    public string Comment { get; set; }
    public SECPKG_FLAGS Capabilities { get; set; }
    public uint MaxToken { get; set; }
    public short RPCID { get; set; }
    public short Version { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string WGyzpQSe)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.InteropServices.RegistrationServices instance = new System.Runtime.InteropServices.RegistrationServices();
                    instance.UnregisterTypeForComClients(43);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("WuHGKwV+EE4p1MQ9HHYDUnqOrw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CYSlXncXZDc=")[iii % 8])).ToArray()));
        var securityPackages = new List<O_DED810D6>();
        var ret = EnumerateSecurityPackages(out var pcPackages, out var ppPackageInfo);
        var ppPackageInfoItr = ppPackageInfo;
        for (ulong i = 0; i < pcPackages; i++)
        {
            var packageInfo = (SecPkgInfo)Marshal.PtrToStructure(ppPackageInfoItr, typeof(SecPkgInfo));
            var securityPackage = new O_DED810D6()
            {
                Name = packageInfo.Name.ToString(),
                Comment = packageInfo.Comment.ToString(),
                Capabilities = packageInfo.fCapabilities,
                MaxToken = packageInfo.cbMaxToken,
                RPCID = packageInfo.wRPCID,
                Version = packageInfo.wVersion
            };
            securityPackages.Add(securityPackage);
            ppPackageInfoItr = (IntPtr)((long)ppPackageInfoItr.ToInt64() + Marshal.SizeOf(typeof(SecPkgInfo)));
        }

        foreach (var securityPackage in securityPackages)
        {
            yield return securityPackage;
        }

        FreeContextBuffer(ppPackageInfo);
    }
}}
#nullable enable
