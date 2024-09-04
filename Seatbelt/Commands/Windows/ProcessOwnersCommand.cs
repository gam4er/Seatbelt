#nullable disable
using System;
using System.Collections.Generic;
using System.Management;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_A27FE08D : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("JPNtehnSFLsD72drDw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dIECGXyhZ/Q=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("6SUKVUgclg3VPwoWUheCXtI/ChsRUoFf1DMBSFJSnUTIJERMSAaZDdQnCl5TAd8N/T8WG1MXnELPNUROUhff").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u1BkOyFy8S0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_A27FE08D(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("ZK1yc2/nqZlg8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NsIdBzOk4NQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Zpgo+qmal0cVmzbwp+7gBFvuVuC6vNgOUK4Xn72G8j9w/Tfamb3eAluUIJ/L85dd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nd1kv+rOt20=")[iii % 8])).ToArray()));
        var retObjectCollection = wmiData.Get();
        foreach (ManagementObject Process in retObjectCollection)
        {
            var OwnerInfo = new string[2];
            try
            {
                Process.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("dR9T0cWKKZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MnonnrLkTOw=")[iii % 8])).ToArray()), (object[])OwnerInfo);
            }
            catch
            {
            }

            var owner = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fFbwJunu/AE=")[iii % 8])).ToArray());
            if (OwnerInfo[0] != null)
            {
                owner = String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("ttuSD8t62Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zevvU7BLpFE=")[iii % 8])).ToArray()), OwnerInfo[1], OwnerInfo[0]);
                yield return new O_102C866E()
                {
                    ProcessName = Process[Encoding.UTF8.GetString(Convert.FromBase64String("RL2owA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CtzFpZjPr3A=")[iii % 8])).ToArray())],
                    ProcessID = Process[Encoding.UTF8.GetString(Convert.FromBase64String("EaHYYxom1YYl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QdO3AH9Vps8=")[iii % 8])).ToArray())],
                    Owner = owner
                };
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string GXfPSERt)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.IO.StringWriter instance = new System.IO.StringWriter();
                    instance.Write('d');
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("ZK1yc2/nqZlg8A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NsIdBzOk4NQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Zpgo+qmal0cVmzbwp+7gBFvuVuC6vNgOUK4Xn72G8j9w/Tfamb3eAluUIJ/L85dd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nd1kv+rOt20=")[iii % 8])).ToArray()));
        var retObjectCollection = wmiData.Get();
        foreach (ManagementObject Process in retObjectCollection)
        {
            var OwnerInfo = new string[2];
            try
            {
                Process.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("dR9T0cWKKZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MnonnrLkTOw=")[iii % 8])).ToArray()), (object[])OwnerInfo);
            }
            catch
            {
            }

            var owner = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fFbwJunu/AE=")[iii % 8])).ToArray());
            if (OwnerInfo[0] != null)
            {
                owner = String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("ttuSD8t62Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zevvU7BLpFE=")[iii % 8])).ToArray()), OwnerInfo[1], OwnerInfo[0]);
                yield return new O_102C866E()
                {
                    ProcessName = Process[Encoding.UTF8.GetString(Convert.FromBase64String("RL2owA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CtzFpZjPr3A=")[iii % 8])).ToArray())],
                    ProcessID = Process[Encoding.UTF8.GetString(Convert.FromBase64String("EaHYYxom1YYl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QdO3AH9Vps8=")[iii % 8])).ToArray())],
                    Owner = owner
                };
            }
        }
    }
}internal class O_102C866E : O_4AED570F
{
    public object ProcessName { get; set; }
    public object ProcessID { get; set; }
    public object Owner { get; set; }
}
    [CommandOutputType(typeof(O_102C866E))]
    internal class O_333261FE : TextFormatterBase
    {
        public O_333261FE(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_102C866E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("iVnEaQ2UJXqJWcVpDZAleolZxjg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qSL0RSChFQc=")[iii % 8])).ToArray()), dto.ProcessName, dto.ProcessID, dto.Owner);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string qedOuALU)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.StringWriter instance = new System.IO.StringWriter();
                        instance.Write('d');
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_102C866E)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("iVnEaQ2UJXqJWcVpDZAleolZxjg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qSL0RSChFQc=")[iii % 8])).ToArray()), dto.ProcessName, dto.ProcessID, dto.Owner);
        }
    }
}
#nullable enable
