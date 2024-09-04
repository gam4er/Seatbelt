using O_F41F88FA.Output.Formatters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;
using O_F41F88FA.Util;
using O_F41F88FA.Output.TextWriters;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_4A153DF2 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("eOqjQzNE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N7nqLVUrflU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("jAjGOA0zMo/uANs3ATNVteAMm3EPYR60px3QMhpmD7niSfoCTmUYrr0A2j9CMxiorUec").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zmm1UW4Tfdw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_4A153DF2(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var ProductName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("JEIZb1fUUVUrYBZ4UtpQXxFZI0xJ20dfAF5fVXTpYEUFXxp1VONGQgREEHU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dy1/GyC1IzA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("laFsXtoDSHekvmY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xdMDOq9gPDk=")[iii % 8])).ToArray()));
        var EditionID = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("SxIvotCOEu9EMCC11YAT5X4JFYHOgQTlbw5pmPOzI/9qDyy407kF+GsUJrg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GH1J1qfvYIo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ZQbPhl0A9bVk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IGKm8jRvm/w=")[iii % 8])).ToArray()));
        var ReleaseId = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YTg/ZgANB7NuGjBxBQMGuVQjBUUeAhG5RSR5XCMwNqNAJTx8AzoQpEE+Nnw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MldZEndsddY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("M5iYcONPxF0F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yf30FYI8oRQ=")[iii % 8])).ToArray()));
        var BuildBranch = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("M6/Ss4152sM8jd2kiHfbyQa06JCTdszJF7OUia5E69MSstGpjk7N1BOp26k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YMC0x/oYqKY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bFfOz4Yc+qlAQc8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LiKno+JeiMg=")[iii % 8])).ToArray()));
        var CurrentMajorVersionNumber = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("S2xxW5bm/mxETn5Mk+j/Zn53S3iI6ehmb3A3YbXbz3xqcXJBldHpe2tqeEE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GAMXL+GHjAk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("6JM1ky7UqUrKjCiTHd+vdMKJKa8+179i2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+ZH4Uu63Qc=")[iii % 8])).ToArray()));
        var CurrentVersion = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("a0Iw3re3YjJkYD/JsrljOF5ZCv2puHQ4T1525JSKUyJKXzPEtIB1JUtEOcQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OC1WqsDWEFc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("vy/p/Vf/EWiZKOjmXf8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/FqbjzKRZT4=")[iii % 8])).ToArray()));
        var BuildNumber = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("KSD9FkhqwvEmAvIBTWTD+xw7xzVWZdT7DTy7LGtX8+EIPf4MS13V5gkm9Aw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ek+bYj8LsJQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1kvM4pb15FjgV9L0ve79ePBM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lT6+kPObkBo=")[iii % 8])).ToArray()));
        var UBR = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("CCHOrTNjVAYHA8G6Nm1VDD069I4tbEIMLD2IlxBeZRYpPM23MFRDESgnx7c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W06o2UQCJmM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("asDP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4KdaQQWUe0=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(UBR))
        {
            BuildNumber += (Encoding.UTF8.GetString(Convert.FromBase64String("8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3DAsjusZVoU=")[iii % 8])).ToArray()) + UBR);
        }

        if (ThisRunTime.ISRemote())
        {
            var isHighIntegrity = true;
            var isLocalAdmin = true;
            var arch = ThisRunTime.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("Mu0YLYpZMFow4BY8jEIqQSf8AzudTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yr9Xbs8KYxU=")[iii % 8])).ToArray()));
            var ProcessorCount = ThisRunTime.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("E3fx3V9hxRMbfezNVXDfDw5t7sw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XSK8nxozmlw=")[iii % 8])).ToArray()));
            var isVM = IsVirtualMachine();
            var bootTimeUtc = new DateTime();
            var strHostName = ThisRunTime.ComputerName;
            var domain = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rgFnZO84Qn0=")[iii % 8])).ToArray());
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("MXPtDV5HWqo1Lg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QxyCeQIkM8c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zvSlViIyyEry/KhaL2aOfPL86WQoKNs8wtKmXjEznGvvwrBANSOF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZHJM0FG6A4=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var o in data)
            {
                var result = (ManagementObject)o;
                domain = result[Encoding.UTF8.GetString(Convert.FromBase64String("nVXtBpfH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2TqAZ/6pWuM=")[iii % 8])).ToArray())].ToString();
            }

            var machineGuid = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("6mokGNGU4PnlaAsv9LrB099RPg/0rMLI1kIQLfa9yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uSViTIbVsrw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Tl75ITRq25Z2Vv4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Az+aSV0EvtE=")[iii % 8])).ToArray()));
            var temp = new string[0];
            yield return new O_4D9BF75E(strHostName, domain, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ugQAnpjzpb0=")[iii % 8])).ToArray()), ProductName, EditionID, ReleaseId, BuildNumber, BuildBranch, CurrentMajorVersionNumber.ToString(), CurrentVersion, arch, ProcessorCount, isVM, bootTimeUtc, isHighIntegrity, isLocalAdmin, DateTime.UtcNow, null, null, null, null, temp, machineGuid);
        }
        else
        {
            var isHighIntegrity = SecurityUtil.IsHighIntegrity();
            var isLocalAdmin = SecurityUtil.IsLocalAdmin();
            var arch = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("sWvpe0Rrd6WzZudqQnBtvqR68m1TfQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4TmmOAE4JOo=")[iii % 8])).ToArray()));
            var ProcessorCount = Environment.ProcessorCount.ToString();
            var isVM = IsVirtualMachine();
            var now = DateTime.UtcNow;
            var bootTimeUtc = now - TimeSpan.FromMilliseconds(Environment.TickCount);
            var strHostName = Dns.GetHostName();
            var properties = IPGlobalProperties.GetIPGlobalProperties();
            var dnsDomain = properties.DomainName;
            var timeZone = TimeZone.CurrentTimeZone;
            var cultureInfo = CultureInfo.InstalledUICulture;
            var inputLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
            var installedInputLanguages = new List<string>();
            foreach (InputLanguage l in InputLanguage.InstalledInputLanguages)
                installedInputLanguages.Add(l.LayoutName);
            var machineGuid = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("a9HvfAeOZ9lk08BLIqBG817q9WsitkXoV/nbSSCnTA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OJ6pKFDPNZw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PS0WUZmiri0FJRE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cEx1OfDMy2o=")[iii % 8])).ToArray()));
            yield return new O_4D9BF75E(strHostName, dnsDomain, WindowsIdentity.GetCurrent().Name, ProductName, EditionID, ReleaseId, BuildNumber, BuildBranch, CurrentMajorVersionNumber.ToString(), CurrentVersion, arch, ProcessorCount, isVM, bootTimeUtc, isHighIntegrity, isLocalAdmin, DateTime.UtcNow, timeZone.StandardName, timeZone.GetUtcOffset(DateTime.Now).ToString(), cultureInfo.ToString(), inputLanguage, installedInputLanguages.ToArray(), machineGuid);
        }
    }

    private bool IsVirtualMachine()
    {
        using (var searcher = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("sIt5dyyqpEO01g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wuQWA3DJzS4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UesKqrMuW2ki6BSgvXosKmy9VJCTNRYzd/oDvYMjCDdn4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ao5mz9Bae0M=")[iii % 8])).ToArray())))
        {
            using (var items = searcher.Get())
            {
                foreach (var item in items)
                {
                    var manufacturer = item[Encoding.UTF8.GetString(Convert.FromBase64String("AY45jzUJglI5nTKI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TO9X+lNo4SY=")[iii % 8])).ToArray())].ToString().ToLower();
                    if ((manufacturer == Encoding.UTF8.GetString(Convert.FromBase64String("+yoq9rRtS53iYyrrqW5Lifc3IOu1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lkNJhNseJPs=")[iii % 8])).ToArray()) && item[Encoding.UTF8.GetString(Convert.FromBase64String("Q2k26eA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DgZSjIzrtXw=")[iii % 8])).ToArray())].ToString().ToUpperInvariant().Contains(Encoding.UTF8.GetString(Convert.FromBase64String("CFmPRMzceg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XhDdEJmdNlE=")[iii % 8])).ToArray()))) || manufacturer.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("mVD0Krmd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7z2DS8v48VI=")[iii % 8])).ToArray())) || manufacturer.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("L9pk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V78KNSz5y4g=")[iii % 8])).ToArray())) || item[Encoding.UTF8.GetString(Convert.FromBase64String("vUSt0Tk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8CvJtFUvN3I=")[iii % 8])).ToArray())].ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("MUxurnrJRfUIXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZyUc2g+oKbc=")[iii % 8])).ToArray()))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
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

        var ProductName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("JEIZb1fUUVUrYBZ4UtpQXxFZI0xJ20dfAF5fVXTpYEUFXxp1VONGQgREEHU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dy1/GyC1IzA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("laFsXtoDSHekvmY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xdMDOq9gPDk=")[iii % 8])).ToArray()));
        var EditionID = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("SxIvotCOEu9EMCC11YAT5X4JFYHOgQTlbw5pmPOzI/9qDyy407kF+GsUJrg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GH1J1qfvYIo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ZQbPhl0A9bVk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IGKm8jRvm/w=")[iii % 8])).ToArray()));
        var ReleaseId = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YTg/ZgANB7NuGjBxBQMGuVQjBUUeAhG5RSR5XCMwNqNAJTx8AzoQpEE+Nnw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MldZEndsddY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("M5iYcONPxF0F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yf30FYI8oRQ=")[iii % 8])).ToArray()));
        var BuildBranch = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("M6/Ss4152sM8jd2kiHfbyQa06JCTdszJF7OUia5E69MSstGpjk7N1BOp26k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YMC0x/oYqKY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bFfOz4Yc+qlAQc8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LiKno+JeiMg=")[iii % 8])).ToArray()));
        var CurrentMajorVersionNumber = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("S2xxW5bm/mxETn5Mk+j/Zn53S3iI6ehmb3A3YbXbz3xqcXJBldHpe2tqeEE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GAMXL+GHjAk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("6JM1ky7UqUrKjCiTHd+vdMKJKa8+179i2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q+ZH4Uu63Qc=")[iii % 8])).ToArray()));
        var CurrentVersion = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("a0Iw3re3YjJkYD/JsrljOF5ZCv2puHQ4T1525JSKUyJKXzPEtIB1JUtEOcQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OC1WqsDWEFc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("vy/p/Vf/EWiZKOjmXf8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/FqbjzKRZT4=")[iii % 8])).ToArray()));
        var BuildNumber = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("KSD9FkhqwvEmAvIBTWTD+xw7xzVWZdT7DTy7LGtX8+EIPf4MS13V5gkm9Aw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ek+bYj8LsJQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1kvM4pb15FjgV9L0ve79ePBM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lT6+kPObkBo=")[iii % 8])).ToArray()));
        var UBR = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("CCHOrTNjVAYHA8G6Nm1VDD069I4tbEIMLD2IlxBeZRYpPM23MFRDESgnx7c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W06o2UQCJmM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("asDP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4KdaQQWUe0=")[iii % 8])).ToArray()));
        if (!string.IsNullOrEmpty(UBR))
        {
            BuildNumber += (Encoding.UTF8.GetString(Convert.FromBase64String("8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3DAsjusZVoU=")[iii % 8])).ToArray()) + UBR);
        }

        if (ThisRunTime.ISRemote())
        {
            var isHighIntegrity = true;
            var isLocalAdmin = true;
            var arch = ThisRunTime.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("Mu0YLYpZMFow4BY8jEIqQSf8AzudTw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yr9Xbs8KYxU=")[iii % 8])).ToArray()));
            var ProcessorCount = ThisRunTime.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("E3fx3V9hxRMbfezNVXDfDw5t7sw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XSK8nxozmlw=")[iii % 8])).ToArray()));
            var isVM = IsVirtualMachine();
            var bootTimeUtc = new DateTime();
            var strHostName = ThisRunTime.ComputerName;
            var domain = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rgFnZO84Qn0=")[iii % 8])).ToArray());
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("MXPtDV5HWqo1Lg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QxyCeQIkM8c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zvSlViIyyEry/KhaL2aOfPL86WQoKNs8wtKmXjEznGvvwrBANSOF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZHJM0FG6A4=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var o in data)
            {
                var result = (ManagementObject)o;
                domain = result[Encoding.UTF8.GetString(Convert.FromBase64String("nVXtBpfH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2TqAZ/6pWuM=")[iii % 8])).ToArray())].ToString();
            }

            var machineGuid = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("6mokGNGU4PnlaAsv9LrB099RPg/0rMLI1kIQLfa9yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uSViTIbVsrw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Tl75ITRq25Z2Vv4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Az+aSV0EvtE=")[iii % 8])).ToArray()));
            var temp = new string[0];
            yield return new O_4D9BF75E(strHostName, domain, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ugQAnpjzpb0=")[iii % 8])).ToArray()), ProductName, EditionID, ReleaseId, BuildNumber, BuildBranch, CurrentMajorVersionNumber.ToString(), CurrentVersion, arch, ProcessorCount, isVM, bootTimeUtc, isHighIntegrity, isLocalAdmin, DateTime.UtcNow, null, null, null, null, temp, machineGuid);
        }
        else
        {
            var isHighIntegrity = SecurityUtil.IsHighIntegrity();
            var isLocalAdmin = SecurityUtil.IsLocalAdmin();
            var arch = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("sWvpe0Rrd6WzZudqQnBtvqR68m1TfQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4TmmOAE4JOo=")[iii % 8])).ToArray()));
            var ProcessorCount = Environment.ProcessorCount.ToString();
            var isVM = IsVirtualMachine();
            var now = DateTime.UtcNow;
            var bootTimeUtc = now - TimeSpan.FromMilliseconds(Environment.TickCount);
            var strHostName = Dns.GetHostName();
            var properties = IPGlobalProperties.GetIPGlobalProperties();
            var dnsDomain = properties.DomainName;
            var timeZone = TimeZone.CurrentTimeZone;
            var cultureInfo = CultureInfo.InstalledUICulture;
            var inputLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
            var installedInputLanguages = new List<string>();
            foreach (InputLanguage l in InputLanguage.InstalledInputLanguages)
                installedInputLanguages.Add(l.LayoutName);
            var machineGuid = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("a9HvfAeOZ9lk08BLIqBG817q9WsitkXoV/nbSSCnTA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OJ6pKFDPNZw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PS0WUZmiri0FJRE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cEx1OfDMy2o=")[iii % 8])).ToArray()));
            yield return new O_4D9BF75E(strHostName, dnsDomain, WindowsIdentity.GetCurrent().Name, ProductName, EditionID, ReleaseId, BuildNumber, BuildBranch, CurrentMajorVersionNumber.ToString(), CurrentVersion, arch, ProcessorCount, isVM, bootTimeUtc, isHighIntegrity, isLocalAdmin, DateTime.UtcNow, timeZone.StandardName, timeZone.GetUtcOffset(DateTime.Now).ToString(), cultureInfo.ToString(), inputLanguage, installedInputLanguages.ToArray(), machineGuid);
        }
    }

    private bool IsVirtualMachine(string ObybMSKS)
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

        using (var searcher = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("sIt5dyyqpEO01g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wuQWA3DJzS4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UesKqrMuW2ki6BSgvXosKmy9VJCTNRYzd/oDvYMjCDdn4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ao5mz9Bae0M=")[iii % 8])).ToArray())))
        {
            using (var items = searcher.Get())
            {
                foreach (var item in items)
                {
                    var manufacturer = item[Encoding.UTF8.GetString(Convert.FromBase64String("AY45jzUJglI5nTKI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TO9X+lNo4SY=")[iii % 8])).ToArray())].ToString().ToLower();
                    if ((manufacturer == Encoding.UTF8.GetString(Convert.FromBase64String("+yoq9rRtS53iYyrrqW5Lifc3IOu1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lkNJhNseJPs=")[iii % 8])).ToArray()) && item[Encoding.UTF8.GetString(Convert.FromBase64String("Q2k26eA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DgZSjIzrtXw=")[iii % 8])).ToArray())].ToString().ToUpperInvariant().Contains(Encoding.UTF8.GetString(Convert.FromBase64String("CFmPRMzceg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XhDdEJmdNlE=")[iii % 8])).ToArray()))) || manufacturer.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("mVD0Krmd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7z2DS8v48VI=")[iii % 8])).ToArray())) || manufacturer.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("L9pk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V78KNSz5y4g=")[iii % 8])).ToArray())) || item[Encoding.UTF8.GetString(Convert.FromBase64String("vUSt0Tk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8CvJtFUvN3I=")[iii % 8])).ToArray())].ToString() == Encoding.UTF8.GetString(Convert.FromBase64String("MUxurnrJRfUIXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZyUc2g+oKbc=")[iii % 8])).ToArray()))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}internal class O_4D9BF75E : O_4AED570F
{
    public O_4D9BF75E(string hostname, string domain, string username, string? productName, string? editionId, string? releaseId, string? build, string? buildBranch, string? currentMajorVersionNumber, string? currentVersion, string architecture, string processorCount, bool isVirtualMachine, DateTime bootTimeUtc, bool isHighIntegrity, bool isLocalAdmin, DateTime currentTimeUtc, string? timeZone, string? timeZoneUtcOffset, string? locale, string? inputLanguage, string[]? installedInputLanguages, string? machineGuid)
    {
        Hostname = hostname;
        Domain = domain;
        Username = username;
        ProductName = productName;
        EditionId = editionId;
        ReleaseId = releaseId;
        Build = build;
        BuildBranch = buildBranch;
        CurrentMajorVersionNumber = currentMajorVersionNumber;
        CurrentVersion = currentVersion;
        Architecture = architecture;
        ProcessorCount = processorCount;
        IsVirtualMachine = isVirtualMachine;
        BootTimeUtc = bootTimeUtc;
        IsHighIntegrity = isHighIntegrity;
        IsLocalAdmin = isLocalAdmin;
        CurrentTimeUtc = currentTimeUtc;
        TimeZone = timeZone;
        TimeZoneUtcOffset = timeZoneUtcOffset;
        Locale = locale;
        InputLanguage = inputLanguage;
        InstalledInputLanguages = installedInputLanguages;
        MachineGuid = machineGuid;
    }

    public string Hostname { get; set; }
    public string Domain { get; set; }
    public string Username { get; set; }
    public string? ProductName { get; set; }
    public string? EditionId { get; set; }
    public string? ReleaseId { get; set; }
    public string? Build { get; set; }
    public string? BuildBranch { get; set; }
    public string? CurrentMajorVersionNumber { get; set; }
    public string? CurrentVersion { get; set; }
    public string Architecture { get; set; }
    public string ProcessorCount { get; set; }
    public bool IsVirtualMachine { get; set; }
    public DateTime BootTimeUtc { get; set; }
    public bool IsHighIntegrity { get; set; }
    public bool IsLocalAdmin { get; set; }
    public DateTime CurrentTimeUtc { get; set; }
    public string? TimeZone { get; set; }
    public string? TimeZoneUtcOffset { get; set; }
    public string? Locale { get; set; }

    public string? InputLanguage;
    public string[]? InstalledInputLanguages;
    public string? MachineGuid { get; set; }
}
    [CommandOutputType(typeof(O_4D9BF75E))]
    internal class O_861E766A : TextFormatterBase
    {
        public O_861E766A(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_4D9BF75E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XyE8m4mPIRECO2eL3pNv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fwFHq6WiEiE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("V0tGgKsNtnE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HyQ19MVs2xQ=")[iii % 8])).ToArray()), dto.Hostname);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8UQozWf+u22sXnPdMOL1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0WRT/UvTiF0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("3UkeunVKo1T4SxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mSZz2xwkgxo=")[iii % 8])).ToArray()), dto.Domain);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("266AjkdHSZ2GtNueEFsH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+477vmtqeq0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("7iZCnebGL50=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u1Un74inQvg=")[iii % 8])).ToArray()), dto.Username);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8wh4PuyO582uEiMuu5Kp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0ygDDsCj1P0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("IW+0uOpVNa8QcL4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cR3b3J82QeE=")[iii % 8])).ToArray()), dto.ProductName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mtjrjFM6WhvHwrCcBCYU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uviQvH8XaSs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("4etmEvpZ2TPg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pI8PZpM2t3o=")[iii % 8])).ToArray()), dto.EditionId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mX67xvLE7f/EZODWpdij").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uV7A9t7p3s8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Tyjsvmgp/+15").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HU2A2wlamqQ=")[iii % 8])).ToArray()), dto.ReleaseId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EqMxaYegquxPuWp50Lzk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MoNKWauNmdw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mJJc+l8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2uc1ljuvKl0=")[iii % 8])).ToArray()), dto.Build);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1b+AvqoVWT6Ipduu/QkX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9Z/7joY4ag4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mbgOQTlLdgy1rg8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("281nLV0JBG0=")[iii % 8])).ToArray()), dto.BuildBranch);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("l8yu0rIhJqbK1vXC5T1o").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+zV4p4MFZY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qmxNmBJ58hiIc1CYIXL0JoB2UaQCeuQwmw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6Rk/6ncXhlU=")[iii % 8])).ToArray()), dto.CurrentMajorVersionNumber);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("nbrpEx/4+e/AoLIDSOS3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vZqSIzPVyt8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pOoY+xLqzp2C7RngGOo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("559qiXeEuss=")[iii % 8])).ToArray()), dto.CurrentVersion);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Lw17vozTMBdyFyCu289+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dy0AjqD+Ayc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("E+iUfkEpfaIm74Vz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Upr3FihdGME=")[iii % 8])).ToArray()), dto.Architecture);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xZfx5F+0+cuYjar0CKi3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5beK1HOZyvs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("vl/+OQtdcgCcbv4vAFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7i2RWm4uAW8=")[iii % 8])).ToArray()), dto.ProcessorCount);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VsUxx5q7wW4L32rXzaeP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("duVK97aW8l4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("i180k45k8JauYQOZlHnrkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wixi+vwQhfc=")[iii % 8])).ToArray()), dto.IsVirtualMachine);
            var uptime = TimeSpan.FromTicks(dto.CurrentTimeUtc.Ticks - dto.BootTimeUtc.Ticks);
            var bootTimeStr = $"{uptime.Days:00}:{uptime.Hours:00}:{uptime.Minutes:00}:{uptime.Seconds:00}";
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("P5cBF3HucntijVoHJvI8azfjFVM8r2E+b8MTSjj5YTAtylM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H7d6J13DQUs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("5CREZbHztQLzP0gxzfuoF9QkUzg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pksrEeWa2Gc=")[iii % 8])).ToArray()), dto.BootTimeUtc, bootTimeStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XgyExqH5QOsDFt/W9uUO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fiz/9o3Uc9s=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MrouJOvccPMdoSA42w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("etNJTKKyBJY=")[iii % 8])).ToArray()), dto.IsHighIntegrity);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("PQr4N148LhJgEKMnCSBg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HSqDB3IRHSI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9Sh5Bbpkf+zYNlwE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vFs1atkFE60=")[iii % 8])).ToArray()), dto.IsLocalAdmin);
            if (!dto.IsHighIntegrity && dto.IsLocalAdmin)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yFB49FvwA9ihHni5Zb43jYVQMbp0vzmKgQQh9GKvKtidAz2mILMt2IlQNLtjuzLYiRQ1vW6zLYyaESy7cvpz2L0xG/RjuzDYihV4tnmqP4ubFTz6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6HBY1ADaXvg=")[iii % 8])).ToArray()));
            }

            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("b+efl00Q0PdF/4iwXB0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LJLt5Sh+pKM=")[iii % 8])).ToArray()), -30}:  {dto.CurrentTimeUtc} (Local time: {dto.CurrentTimeUtc.ToLocalTime()})");
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mDYVdgIYqcnFLE5mVQTn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uBZuRi41mvk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UOFbM/vZOUU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BIg2VqG2VyA=")[iii % 8])).ToArray()), dto.TimeZone);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pkxGpUKBE2L7Vh21FZ1d").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hmw9lW6sIFI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("iA1cm9zQEj+TAleN48s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3GQx/oa/fFo=")[iii % 8])).ToArray()), dto.TimeZoneUtcOffset);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BaBNkm1JJYVYuhaCOlVr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JYA2okFkFrU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pQ3erdAhAReLFs+/wQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7GOu2KRtYHk=")[iii % 8])).ToArray()), dto.InputLanguage);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EMXsgaFwr9pN37eR9mzh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MOWXsY1dnOo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("O6Rvq064Fs4Wg3KvWqA2yhytab5IsQk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("csoc3y/Ueqs=")[iii % 8])).ToArray()), string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("gHs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rFv/VnrKuZA=")[iii % 8])).ToArray()), dto.InstalledInputLanguages));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Pvf4FILo+NFj7aME1fS2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HteDJK7Fy+E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DBzWkvAm2Lc0FNE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QX21+plIvfA=")[iii % 8])).ToArray()), dto.MachineGuid);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string BafTXhvC)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                        instance.ExportCspBlob(true);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_4D9BF75E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XyE8m4mPIRECO2eL3pNv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fwFHq6WiEiE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("V0tGgKsNtnE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HyQ19MVs2xQ=")[iii % 8])).ToArray()), dto.Hostname);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8UQozWf+u22sXnPdMOL1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0WRT/UvTiF0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("3UkeunVKo1T4SxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mSZz2xwkgxo=")[iii % 8])).ToArray()), dto.Domain);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("266AjkdHSZ2GtNueEFsH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+477vmtqeq0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("7iZCnebGL50=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u1Un74inQvg=")[iii % 8])).ToArray()), dto.Username);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8wh4PuyO582uEiMuu5Kp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0ygDDsCj1P0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("IW+0uOpVNa8QcL4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cR3b3J82QeE=")[iii % 8])).ToArray()), dto.ProductName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mtjrjFM6WhvHwrCcBCYU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uviQvH8XaSs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("4etmEvpZ2TPg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pI8PZpM2t3o=")[iii % 8])).ToArray()), dto.EditionId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mX67xvLE7f/EZODWpdij").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uV7A9t7p3s8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Tyjsvmgp/+15").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HU2A2wlamqQ=")[iii % 8])).ToArray()), dto.ReleaseId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EqMxaYegquxPuWp50Lzk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MoNKWauNmdw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mJJc+l8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2uc1ljuvKl0=")[iii % 8])).ToArray()), dto.Build);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1b+AvqoVWT6Ipduu/QkX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9Z/7joY4ag4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mbgOQTlLdgy1rg8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("281nLV0JBG0=")[iii % 8])).ToArray()), dto.BuildBranch);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("l8yu0rIhJqbK1vXC5T1o").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+zV4p4MFZY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qmxNmBJ58hiIc1CYIXL0JoB2UaQCeuQwmw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6Rk/6ncXhlU=")[iii % 8])).ToArray()), dto.CurrentMajorVersionNumber);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("nbrpEx/4+e/AoLIDSOS3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vZqSIzPVyt8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pOoY+xLqzp2C7RngGOo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("559qiXeEuss=")[iii % 8])).ToArray()), dto.CurrentVersion);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Lw17vozTMBdyFyCu289+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dy0AjqD+Ayc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("E+iUfkEpfaIm74Vz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Upr3FihdGME=")[iii % 8])).ToArray()), dto.Architecture);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xZfx5F+0+cuYjar0CKi3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5beK1HOZyvs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("vl/+OQtdcgCcbv4vAFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7i2RWm4uAW8=")[iii % 8])).ToArray()), dto.ProcessorCount);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VsUxx5q7wW4L32rXzaeP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("duVK97aW8l4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("i180k45k8JauYQOZlHnrkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wixi+vwQhfc=")[iii % 8])).ToArray()), dto.IsVirtualMachine);
            var uptime = TimeSpan.FromTicks(dto.CurrentTimeUtc.Ticks - dto.BootTimeUtc.Ticks);
            var bootTimeStr = $"{uptime.Days:00}:{uptime.Hours:00}:{uptime.Minutes:00}:{uptime.Seconds:00}";
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("P5cBF3HucntijVoHJvI8azfjFVM8r2E+b8MTSjj5YTAtylM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H7d6J13DQUs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("5CREZbHztQLzP0gxzfuoF9QkUzg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pksrEeWa2Gc=")[iii % 8])).ToArray()), dto.BootTimeUtc, bootTimeStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("XgyExqH5QOsDFt/W9uUO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fiz/9o3Uc9s=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MrouJOvccPMdoSA42w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("etNJTKKyBJY=")[iii % 8])).ToArray()), dto.IsHighIntegrity);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("PQr4N148LhJgEKMnCSBg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HSqDB3IRHSI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9Sh5Bbpkf+zYNlwE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vFs1atkFE60=")[iii % 8])).ToArray()), dto.IsLocalAdmin);
            if (!dto.IsHighIntegrity && dto.IsLocalAdmin)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yFB49FvwA9ihHni5Zb43jYVQMbp0vzmKgQQh9GKvKtidAz2mILMt2IlQNLtjuzLYiRQ1vW6zLYyaESy7cvpz2L0xG/RjuzDYihV4tnmqP4ubFTz6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6HBY1ADaXvg=")[iii % 8])).ToArray()));
            }

            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("b+efl00Q0PdF/4iwXB0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LJLt5Sh+pKM=")[iii % 8])).ToArray()), -30}:  {dto.CurrentTimeUtc} (Local time: {dto.CurrentTimeUtc.ToLocalTime()})");
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mDYVdgIYqcnFLE5mVQTn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uBZuRi41mvk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UOFbM/vZOUU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BIg2VqG2VyA=")[iii % 8])).ToArray()), dto.TimeZone);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("pkxGpUKBE2L7Vh21FZ1d").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hmw9lW6sIFI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("iA1cm9zQEj+TAleN48s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3GQx/oa/fFo=")[iii % 8])).ToArray()), dto.TimeZoneUtcOffset);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BaBNkm1JJYVYuhaCOlVr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JYA2okFkFrU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("pQ3erdAhAReLFs+/wQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7GOu2KRtYHk=")[iii % 8])).ToArray()), dto.InputLanguage);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EMXsgaFwr9pN37eR9mzh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MOWXsY1dnOo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("O6Rvq064Fs4Wg3KvWqA2yhytab5IsQk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("csoc3y/Ueqs=")[iii % 8])).ToArray()), string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("gHs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rFv/VnrKuZA=")[iii % 8])).ToArray()), dto.InstalledInputLanguages));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Pvf4FILo+NFj7aME1fS2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HteDJK7Fy+E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DBzWkvAm2Lc0FNE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QX21+plIvfA=")[iii % 8])).ToArray()), dto.MachineGuid);
        }
    }
}