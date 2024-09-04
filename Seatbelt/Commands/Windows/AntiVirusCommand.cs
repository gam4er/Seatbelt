using System;
using System.Collections.Generic;
using O_F41F88FA.Interop;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_23DCFB01 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("maTIWCDsvher").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2Mq8MXaFzGI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+9d/Hf0DDLTM1jgV4AMAsMDAbQeuXx+vyJJPOcde").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qbIYdI53acY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_23DCFB01(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (String.IsNullOrEmpty(ThisRunTime.ComputerName) && O_210F4320.IsWindowsServer())
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Tn4UIzBQsC9jahcoLUXkLy1+FDk2Uvk4eGxUbS1L/z5RTB8uKlb5PnRcHyMrQeJ4LUg3BH9K8SdobAosPEGwI34/FCIrBPE8bHYWLD1I9WpicVoaNkr0JXpsWh46VuYvf2w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DR96TV8kkEo=")[iii % 8])).ToArray()));
            yield break;
        }

        var AVResults = new List<O_A6AE78E3>();
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("SBrlzvZzvCJPB+PO02O8L04Q+Ig=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OnWKuqog2UE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("kvyIWeShxfHh/5ZT6tWktbXQknXVgJaLs9agacSB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wbnEHKf15ds=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var virusChecker in data)
            {
                AVResults.Add(new O_A6AE78E3(virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("6k5AxFSIEh3vSlY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jicztDjpa1M=")[iii % 8])).ToArray())], virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("qfTfpADQ/LK++86oBM3Av6z234ks2g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ZWrzFS/r9s=")[iii % 8])).ToArray())], virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("6FbhGmAH58//WfAWZg3EyepD/BxTLczD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mDeVcjRotKY=")[iii % 8])).ToArray())]));
            }
        }
        catch
        {
        }

        foreach (var AVResult in AVResults)
        {
            yield return AVResult;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string bEsxZfRX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                    instance.GetMonth(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (String.IsNullOrEmpty(ThisRunTime.ComputerName) && O_210F4320.IsWindowsServer())
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Tn4UIzBQsC9jahcoLUXkLy1+FDk2Uvk4eGxUbS1L/z5RTB8uKlb5PnRcHyMrQeJ4LUg3BH9K8SdobAosPEGwI34/FCIrBPE8bHYWLD1I9WpicVoaNkr0JXpsWh46VuYvf2w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DR96TV8kkEo=")[iii % 8])).ToArray()));
            yield break;
        }

        var AVResults = new List<O_A6AE78E3>();
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("SBrlzvZzvCJPB+PO02O8L04Q+Ig=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OnWKuqog2UE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("kvyIWeShxfHh/5ZT6tWktbXQknXVgJaLs9agacSB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wbnEHKf15ds=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var virusChecker in data)
            {
                AVResults.Add(new O_A6AE78E3(virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("6k5AxFSIEh3vSlY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jicztDjpa1M=")[iii % 8])).ToArray())], virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("qfTfpADQ/LK++86oBM3Av6z234ks2g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2ZWrzFS/r9s=")[iii % 8])).ToArray())], virusChecker[Encoding.UTF8.GetString(Convert.FromBase64String("6FbhGmAH58//WfAWZg3EyepD/BxTLczD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mDeVcjRotKY=")[iii % 8])).ToArray())]));
            }
        }
        catch
        {
        }

        foreach (var AVResult in AVResults)
        {
            yield return AVResult;
        }
    }
}internal class O_A6AE78E3 : O_4AED570F
{
    public O_A6AE78E3(object engine, object productExe, object reportingExe)
    {
        Engine = engine;
        ProductEXE = productExe;
        ReportingEXE = reportingExe;
    }

    public object Engine { get; }
    public object ProductEXE { get; }
    public object ReportingEXE { get; }
}}