using System.Collections.Generic;
using System.Linq;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Management;
using System;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    enum VBS
    {
        NOT_ENABLED = 0,
        ENABLED_NOT_RUNNING = 1,
        ENABLED_AND_RUNNING = 2
    }
internal class O_9E6775BC : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("hfnha5NJoCGi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xouED9Q8wVM=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ex0hz15ilOFZAwPeWn6EqFsAKs1Sa5X6WRstxFU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OG9EqzsM4Ig=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_9E6775BC(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        ManagementObjectCollection? data = null;
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("K6f0yY7Hvnwrp+jStP6LSDCm/9Kl+YtbPL7y3rfNon4rrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WcibvdKK1x8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YLHK+8q5x54TstTxxM2w3V3HtOHNiJHdUJHBy+ifgw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M/SGvont57Q=")[iii % 8])).ToArray()));
            data = wmiData.Get();
        }
        catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
        {
            WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("Zi3X04WWE7wvY7+5h/JRnS9u6cyt10aPYS3bxpGWV4cnfv+rrdhVnSdk4Oq62lE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rg2Mi9i2NOs=")[iii % 8])).ToArray()), ex.Message));
        }
        catch (Exception ex)
        {
            WriteError(ex.ToString());
        }

        if (data == null)
        {
            yield break;
        }

        foreach (var result in data)
        {
            var configCheck = (int[])result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("K+3OWWSecKMr7d9af5RhqTvnw0p/kHGoHew=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eIitLBb3BNo=")[iii % 8])).ToArray()));
            var serviceCheck = (int[])result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("iSRSI2F5KOqJJEMgenM54Ig0Xzh6fjs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2kExVhMQXJM=")[iii % 8])).ToArray()));
            var vbsSetting = (VBS)0;
            var configured = false;
            var running = false;
            uint? vbs = (uint)result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("J/JU1KMkGJAL+lLJuSs2mAL+QvOzJgGLGO9f86IkAIwC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cZsmoNZFdPk=")[iii % 8])).ToArray()));
            if (vbs != null)
            {
                vbsSetting = (VBS)vbs;
            }

            if (configCheck.Contains(1))
            {
                configured = true;
            }

            if (serviceCheck.Contains(1))
            {
                running = true;
            }

            yield return new O_8E85A0BE()
            {
                VirtualizationBasedSecurityStatus = vbsSetting,
                Configured = configured,
                Running = running
            };
        }
    }

class O_8E85A0BE : O_4AED570F
{
    public VBS VirtualizationBasedSecurityStatus { get; set; }
    public bool Configured { get; set; }
    public bool Running { get; set; }
}    [CommandOutputType(typeof(O_8E85A0BE))]
    internal class O_711C9430 : TextFormatterBase
    {
        public O_711C9430(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_8E85A0BE)result;
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string etXQooBs)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
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

            var dto = (O_8E85A0BE)result;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string BQqhDOWK)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
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

        ManagementObjectCollection? data = null;
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("K6f0yY7Hvnwrp+jStP6LSDCm/9Kl+YtbPL7y3rfNon4rrA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WcibvdKK1x8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YLHK+8q5x54TstTxxM2w3V3HtOHNiJHdUJHBy+ifgw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M/SGvont57Q=")[iii % 8])).ToArray()));
            data = wmiData.Get();
        }
        catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
        {
            WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("Zi3X04WWE7wvY7+5h/JRnS9u6cyt10aPYS3bxpGWV4cnfv+rrdhVnSdk4Oq62lE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rg2Mi9i2NOs=")[iii % 8])).ToArray()), ex.Message));
        }
        catch (Exception ex)
        {
            WriteError(ex.ToString());
        }

        if (data == null)
        {
            yield break;
        }

        foreach (var result in data)
        {
            var configCheck = (int[])result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("K+3OWWSecKMr7d9af5RhqTvnw0p/kHGoHew=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eIitLBb3BNo=")[iii % 8])).ToArray()));
            var serviceCheck = (int[])result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("iSRSI2F5KOqJJEMgenM54Ig0Xzh6fjs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2kExVhMQXJM=")[iii % 8])).ToArray()));
            var vbsSetting = (VBS)0;
            var configured = false;
            var running = false;
            uint? vbs = (uint)result.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("J/JU1KMkGJAL+lLJuSs2mAL+QvOzJgGLGO9f86IkAIwC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cZsmoNZFdPk=")[iii % 8])).ToArray()));
            if (vbs != null)
            {
                vbsSetting = (VBS)vbs;
            }

            if (configCheck.Contains(1))
            {
                configured = true;
            }

            if (serviceCheck.Contains(1))
            {
                running = true;
            }

            yield return new O_8E85A0BE()
            {
                VirtualizationBasedSecurityStatus = vbsSetting,
                Configured = configured,
                Running = running
            };
        }
    }
}}