using System.Collections.Generic;
using Microsoft.Win32;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_E09DCE35 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("uZyRPA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6t/ScU/m3eI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ViHCEB3pIaRgNsUBCqRCiGs+2AMN9mCTbDffRDXlb4ZiPcNEUNdCpEhxkRcd8HWOaz/CSFjtZ8dkKMEIEedghWk9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BVixZHiEAec=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_E09DCE35(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        yield return new O_7B44E23F(ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("bYAOBCSMgjJigiEzAaKjGFi7FBMwgIMSSro4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ps9IUHPN0Hc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("aFLPzbLX1cdAfuw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JDO8ueS2ua4=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("hAk+4ySTOeuLCxHUAb0YwbEyJOQ+gTfjuCQR2xbyKMK+IxbD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("10Z4t3PSa64=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("q3rqHloS3si5YO0SfhPfyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6gmZdz18u6w=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Yemp55w2S2Ru64bQuRhqTlTSs+CGJEVsXcSG365XWk1bw4HH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mqbvs8t3GSE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bpFoEJqnWTlbkXQdgKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PuMHdO/ELW8=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("G61N8TTiSzoUr2LGEcxqEC6WV/Yu8EUyJ4BiyQaDWhMhh2XR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SOILpWOjGX8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("WIxR+ksuIK1xnlHobTcKoGeZQ+J0CyK8dYBR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FO0ijhhbQ84=")[iii % 8])).ToArray())));
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string vmFegHQB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.RSACryptoServiceProvider instance = new System.Security.Cryptography.RSACryptoServiceProvider();
                    instance.ExportParameters(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        yield return new O_7B44E23F(ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("bYAOBCSMgjJigiEzAaKjGFi7FBMwgIMSSro4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ps9IUHPN0Hc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("aFLPzbLX1cdAfuw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JDO8ueS2ua4=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("hAk+4ySTOeuLCxHUAb0YwbEyJOQ+gTfjuCQR2xbyKMK+IxbD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("10Z4t3PSa64=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("q3rqHloS3si5YO0SfhPfyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6gmZdz18u6w=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Yemp55w2S2Ru64bQuRhqTlTSs+CGJEVsXcSG365XWk1bw4HH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mqbvs8t3GSE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bpFoEJqnWTlbkXQdgKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PuMHdO/ELW8=")[iii % 8])).ToArray())), ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("G61N8TTiSzoUr2LGEcxqEC6WV/Yu8EUyJ4BiyQaDWhMhh2XR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SOILpWOjGX8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("WIxR+ksuIK1xnlHobTcKoGeZQ+J0CyK8dYBR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FO0ijhhbQ84=")[iii % 8])).ToArray())));
    }
}internal class O_7B44E23F : O_4AED570F
{
    public O_7B44E23F(string? server, string? siteCode, string? productVersion, string? lastSuccessfulInstallParams)
    {
        Server = server;
        SiteCode = siteCode;
        ProductVersion = productVersion;
        LastSuccessfulInstallParams = lastSuccessfulInstallParams;
    }

    public string? Server { get; }
    public string? SiteCode { get; }
    public string? ProductVersion { get; }
    public string? LastSuccessfulInstallParams { get; }
}}