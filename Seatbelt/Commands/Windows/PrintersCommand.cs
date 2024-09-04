#nullable disable
using System.Collections.Generic;
using System.Management;
using O_F41F88FA.Util;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_41DEEC1B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("BV1jvkFN1sc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VS8K0DUopLQ=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("27GHj+rLaKv2/6SJ4slwq+Cs1NP9zmXuxZK90g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kt/0+4unBM4=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_41DEEC1B(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var printerQuery = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("tOb6wTu5agrHxcTrFc0dSYmQhNsonyNOk8bE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("56O2hHjtSiA=")[iii % 8])).ToArray()));
        foreach (var printer in printerQuery.Get())
        {
            var isDefault = (bool)printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("SrMYLuFPkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DtZ+T5Qj5g0=")[iii % 8])).ToArray()));
            var isNetworkPrinter = (bool)printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("pv9DQLKoJw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6Jo3N93aTPQ=")[iii % 8])).ToArray()));
            string printerSDDL = null;
            var printerName = $"{printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("wbX/lA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j9SS8fykl1M=")[iii % 8])).ToArray()))}";
            try
            {
                var info = SecurityUtil.GetSecurityInfos(printerName, Interop.Advapi32.SE_OBJECT_TYPE.SE_PRINTER);
                printerSDDL = info.SDDL;
            }
            catch
            {
            }

            yield return new O_305008C6(printerName, $"{printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("8zGUIqLv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oEX1VtechZI=")[iii % 8])).ToArray()))}", printerSDDL, isDefault, isNetworkPrinter);
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

        var printerQuery = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("tOb6wTu5agrHxcTrFc0dSYmQhNsonyNOk8bE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("56O2hHjtSiA=")[iii % 8])).ToArray()));
        foreach (var printer in printerQuery.Get())
        {
            var isDefault = (bool)printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("SrMYLuFPkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DtZ+T5Qj5g0=")[iii % 8])).ToArray()));
            var isNetworkPrinter = (bool)printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("pv9DQLKoJw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6Jo3N93aTPQ=")[iii % 8])).ToArray()));
            string printerSDDL = null;
            var printerName = $"{printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("wbX/lA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j9SS8fykl1M=")[iii % 8])).ToArray()))}";
            try
            {
                var info = SecurityUtil.GetSecurityInfos(printerName, Interop.Advapi32.SE_OBJECT_TYPE.SE_PRINTER);
                printerSDDL = info.SDDL;
            }
            catch
            {
            }

            yield return new O_305008C6(printerName, $"{printer.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("8zGUIqLv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oEX1VtechZI=")[iii % 8])).ToArray()))}", printerSDDL, isDefault, isNetworkPrinter);
        }
    }
}internal class O_305008C6 : O_4AED570F
{
    public O_305008C6(string name, string status, string sddl, bool isDefault, bool isNetworkPrinter)
    {
        Name = name;
        Status = status;
        Sddl = sddl;
        IsDefault = isDefault;
        IsNetworkPrinter = isNetworkPrinter;
    }

    public string Name { get; }
    public string Status { get; }
    public string Sddl { get; }
    public bool IsDefault { get; }
    public bool IsNetworkPrinter { get; }
}}
#nullable enable
