using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_A76DAE01 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("K/NG8iwLrGM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b70VsU1oxAY=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Bcv+lTvfF+QkpcjbLMwd6TKlhcMx31TbDMyE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QYWttVi+dIw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_A76DAE01(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        ManagementObjectCollection? data = null;
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("OdiPueAdh3gl04G/2A2adD2F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S7fgzbxu8xk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PKrxa8x/JLpPqe9hwgtJwym74mrBeEf8BorTWsxKZ/gK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b++9Lo8rBJA=")[iii % 8])).ToArray()));
            data = wmiData.Get();
        }
        catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
        {
            WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JIs4tLEBFJFX7TezqG9gn2jCBoKYYlK/bM5EzLtsevxnxwKfnwFGsmXdAoWAQFGwYYtLgYVPWrFxxkOfmVFDs3bfBojMV1aud8IMgp8BXLok/AqCiE5Erz6LW8PeEQLuLQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BKtj7OwhM9w=")[iii % 8])).ToArray()), ex.Message));
        }
        catch (Exception ex)
        {
            WriteError(ex.ToString());
        }

        if (data == null)
        {
            yield break;
        }

        foreach (var o in data)
        {
            var result = (ManagementObject)o;
            yield return new O_A328A704(result[Encoding.UTF8.GetString(Convert.FromBase64String("vaqh9uM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+MTVhJodrjQ=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("87nmLw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vdiLSgnCO80=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("Giiafw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XknuHuzY+88=")[iii % 8])).ToArray())]);
        }

        data.Dispose();
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string rTCmjkYX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                    instance.Cancel(true);
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
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("OdiPueAdh3gl04G/2A2adD2F").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S7fgzbxu8xk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PKrxa8x/JLpPqe9hwgtJwym74mrBeEf8BorTWsxKZ/gK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b++9Lo8rBJA=")[iii % 8])).ToArray()));
            data = wmiData.Get();
        }
        catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
        {
            WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("JIs4tLEBFJFX7TezqG9gn2jCBoKYYlK/bM5EzLtsevxnxwKfnwFGsmXdAoWAQFGwYYtLgYVPWrFxxkOfmVFDs3bfBojMV1aud8IMgp8BXLok/AqCiE5Erz6LW8PeEQLuLQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BKtj7OwhM9w=")[iii % 8])).ToArray()), ex.Message));
        }
        catch (Exception ex)
        {
            WriteError(ex.ToString());
        }

        if (data == null)
        {
            yield break;
        }

        foreach (var o in data)
        {
            var result = (ManagementObject)o;
            yield return new O_A328A704(result[Encoding.UTF8.GetString(Convert.FromBase64String("vaqh9uM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+MTVhJodrjQ=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("87nmLw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vdiLSgnCO80=")[iii % 8])).ToArray())], result[Encoding.UTF8.GetString(Convert.FromBase64String("Giiafw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XknuHuzY+88=")[iii % 8])).ToArray())]);
        }

        data.Dispose();
    }
}internal class O_A328A704 : O_4AED570F
{
    public O_A328A704(object entry, object name, object data)
    {
        Entry = entry;
        Name = name;
        Data = data;
    }

    public object Entry { get; set; }
    public object Name { get; set; }
    public object Data { get; set; }
}}