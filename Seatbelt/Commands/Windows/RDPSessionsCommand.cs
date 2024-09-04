using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using O_F41F88FA.Commands;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using static O_F41F88FA.Interop.O_17620FAB;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_F8681E61 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("33Rz2OdZVwjiXlA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jTAji4IqJGE=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("sWlslGB6YKybcn2JaH1669JOWrYlZ3H/gXVxiHY0PO2Ae2uLYHpgrM8hPoVqeWT5hnlsiGR5cayGcz6Da2F56YB9aoMs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8hwe5gUUFIw=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_F8681E61(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var computerName = Encoding.UTF8.GetString(Convert.FromBase64String("NTpupRkLix0t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WVUNxHVj5G4=")[iii % 8])).ToArray());
        if (!string.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length == 1)
        {
            computerName = args[0];
        }

        var server = WTSOpenServer(computerName);
        try
        {
            var ppSessionInfo = IntPtr.Zero;
            var sessionCount = 0;
            var level = 1;
            if (!WTSEnumerateSessionsEx(server, ref level, 0, ref ppSessionInfo, ref sessionCount))
            {
                var errCode = Marshal.GetLastWin32Error();
                WriteError($"Failed to enumerate sessions on {server}. Error: {errCode} - " + new Win32Exception(errCode).Message);
                yield break;
            }

            var current = ppSessionInfo;
            for (var i = 0; i < sessionCount; i++)
            {
                var si = (WTS_SESSION_INFO_1)Marshal.PtrToStructure(current, typeof(WTS_SESSION_INFO_1));
                current = (IntPtr)(current.ToInt64() + Marshal.SizeOf(typeof(WTS_SESSION_INFO_1)));
                IPAddress? clientIp = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientAddress, out var addressPtr, out _))
                {
                    var address = (WTS_CLIENT_ADDRESS)Marshal.PtrToStructure(addressPtr, typeof(WTS_CLIENT_ADDRESS));
                    if (address.AddressFamily == ADDRESS_FAMILY.AF_INET)
                    {
                        var str = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XLbnMgIKPy4=")[iii % 8])).ToArray()), address.Address.Skip(2).Take(4).Select(b => b.ToString()).ToArray());
                        clientIp = IPAddress.Parse(str);
                    }

                    WTSFreeMemory(addressPtr);
                }

                string? clientHostname = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientName, out var hostnamePtr, out _))
                {
                    clientHostname = Marshal.PtrToStringAuto(hostnamePtr);
                    WTSFreeMemory(hostnamePtr);
                }

                WTS_CLIENT_DISPLAY? clientResolution = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientDisplay, out var displayPtr, out _))
                {
                    clientResolution = (WTS_CLIENT_DISPLAY)Marshal.PtrToStructure(displayPtr, typeof(WTS_CLIENT_DISPLAY));
                    WTSFreeMemory(displayPtr);
                }

                int? clientBuild = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientBuildNumber, out var clientBuildNumberPtr, out _))
                {
                    clientBuild = Marshal.ReadInt32(clientBuildNumberPtr);
                    WTSFreeMemory(clientBuildNumberPtr);
                }

                long? lastInputTime = null;
                if (Environment.OSVersion.Version >= new Version(6, 0) && WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSSessionInfo, out var sessionInfoPtr, out _))
                {
                    var sessionInfo = (WTSINFO)Marshal.PtrToStructure(sessionInfoPtr, typeof(WTSINFO));
                    lastInputTime = sessionInfo.LastInputTime;
                    WTSFreeMemory(sessionInfoPtr);
                }

                byte[]? clientHardwareId = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientHardwareId, out var buffer, out var bytesRead))
                {
                    clientHardwareId = new byte[bytesRead];
                    Marshal.Copy(buffer, clientHardwareId, 0, (int)bytesRead);
                    WTSFreeMemory(buffer);
                }

                string? clientDirectory = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientDirectory, out buffer, out _))
                {
                    clientDirectory = Marshal.PtrToStringUni(buffer);
                    WTSFreeMemory(buffer);
                }

                yield return new O_978EAB6D(si.SessionID, si.pSessionName, si.pUserName, si.pDomainName, si.State, si.pHostName, si.pFarmName, lastInputTime, clientIp, clientHostname, clientResolution, clientBuild, clientHardwareId, clientDirectory);
            }

            WTSFreeMemory(ppSessionInfo);
        }
        finally
        {
            WTSCloseServer(server);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string neaKbeMB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Version instance = new System.Version();
                    instance.ToString(75);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var computerName = Encoding.UTF8.GetString(Convert.FromBase64String("NTpupRkLix0t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WVUNxHVj5G4=")[iii % 8])).ToArray());
        if (!string.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length == 1)
        {
            computerName = args[0];
        }

        var server = WTSOpenServer(computerName);
        try
        {
            var ppSessionInfo = IntPtr.Zero;
            var sessionCount = 0;
            var level = 1;
            if (!WTSEnumerateSessionsEx(server, ref level, 0, ref ppSessionInfo, ref sessionCount))
            {
                var errCode = Marshal.GetLastWin32Error();
                WriteError($"Failed to enumerate sessions on {server}. Error: {errCode} - " + new Win32Exception(errCode).Message);
                yield break;
            }

            var current = ppSessionInfo;
            for (var i = 0; i < sessionCount; i++)
            {
                var si = (WTS_SESSION_INFO_1)Marshal.PtrToStructure(current, typeof(WTS_SESSION_INFO_1));
                current = (IntPtr)(current.ToInt64() + Marshal.SizeOf(typeof(WTS_SESSION_INFO_1)));
                IPAddress? clientIp = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientAddress, out var addressPtr, out _))
                {
                    var address = (WTS_CLIENT_ADDRESS)Marshal.PtrToStructure(addressPtr, typeof(WTS_CLIENT_ADDRESS));
                    if (address.AddressFamily == ADDRESS_FAMILY.AF_INET)
                    {
                        var str = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XLbnMgIKPy4=")[iii % 8])).ToArray()), address.Address.Skip(2).Take(4).Select(b => b.ToString()).ToArray());
                        clientIp = IPAddress.Parse(str);
                    }

                    WTSFreeMemory(addressPtr);
                }

                string? clientHostname = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientName, out var hostnamePtr, out _))
                {
                    clientHostname = Marshal.PtrToStringAuto(hostnamePtr);
                    WTSFreeMemory(hostnamePtr);
                }

                WTS_CLIENT_DISPLAY? clientResolution = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientDisplay, out var displayPtr, out _))
                {
                    clientResolution = (WTS_CLIENT_DISPLAY)Marshal.PtrToStructure(displayPtr, typeof(WTS_CLIENT_DISPLAY));
                    WTSFreeMemory(displayPtr);
                }

                int? clientBuild = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientBuildNumber, out var clientBuildNumberPtr, out _))
                {
                    clientBuild = Marshal.ReadInt32(clientBuildNumberPtr);
                    WTSFreeMemory(clientBuildNumberPtr);
                }

                long? lastInputTime = null;
                if (Environment.OSVersion.Version >= new Version(6, 0) && WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSSessionInfo, out var sessionInfoPtr, out _))
                {
                    var sessionInfo = (WTSINFO)Marshal.PtrToStructure(sessionInfoPtr, typeof(WTSINFO));
                    lastInputTime = sessionInfo.LastInputTime;
                    WTSFreeMemory(sessionInfoPtr);
                }

                byte[]? clientHardwareId = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientHardwareId, out var buffer, out var bytesRead))
                {
                    clientHardwareId = new byte[bytesRead];
                    Marshal.Copy(buffer, clientHardwareId, 0, (int)bytesRead);
                    WTSFreeMemory(buffer);
                }

                string? clientDirectory = null;
                if (WTSQuerySessionInformation(server, si.SessionID, WTS_INFO_CLASS.WTSClientDirectory, out buffer, out _))
                {
                    clientDirectory = Marshal.PtrToStringUni(buffer);
                    WTSFreeMemory(buffer);
                }

                yield return new O_978EAB6D(si.SessionID, si.pSessionName, si.pUserName, si.pDomainName, si.State, si.pHostName, si.pFarmName, lastInputTime, clientIp, clientHostname, clientResolution, clientBuild, clientHardwareId, clientDirectory);
            }

            WTSFreeMemory(ppSessionInfo);
        }
        finally
        {
            WTSCloseServer(server);
        }
    }
}internal class O_978EAB6D : O_4AED570F
{
    public O_978EAB6D(uint sessionId, string sessionName, string userName, string domainName, WTS_CONNECTSTATE_CLASS state, string hostName, string farmName, long? lastInputTime, IPAddress? clientIp, string? clientHostname, WTS_CLIENT_DISPLAY? clientResolution, int? clientBuild, byte[]? clientHardwareId, string? clientDirectory)
    {
        SessionID = sessionId;
        SessionName = sessionName;
        UserName = userName;
        DomainName = domainName;
        State = state;
        HostName = hostName;
        FarmName = farmName;
        LastInputTime = lastInputTime;
        ClientIp = clientIp;
        ClientHostname = clientHostname;
        ClientResolution = clientResolution;
        ClientBuild = clientBuild;
        ClientHardwareId = clientHardwareId;
        ClientDirectory = clientDirectory;
    }

    public uint SessionID { get; }
    public string SessionName { get; }
    public string UserName { get; }
    public string DomainName { get; }
    public WTS_CONNECTSTATE_CLASS State { get; }
    public string HostName { get; }
    public string FarmName { get; }
    public long? LastInputTime { get; }
    public IPAddress? ClientIp { get; }
    public string? ClientHostname { get; }
    public WTS_CLIENT_DISPLAY? ClientResolution { get; }
    public int? ClientBuild { get; }
    public byte[]? ClientHardwareId { get; }
    public string? ClientDirectory { get; }
}
    [CommandOutputType(typeof(O_978EAB6D))]
    internal class O_5566E7D8 : TextFormatterBase
    {
        public O_5566E7D8(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_978EAB6D)result;
            var lastInputStr = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d62f4SOlv54=")[iii % 8])).ToArray());
            if (dto.LastInputTime != null)
            {
                var lastInputDt = DateTime.FromFileTimeUtc((long)dto.LastInputTime);
                var t = DateTime.UtcNow - lastInputDt;
                lastInputStr = $"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms";
            }

            var clientResolution = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rCNISkGI0rw=")[iii % 8])).ToArray());
            if (dto.ClientResolution != null && dto.ClientResolution?.HorizontalResolution != 0)
            {
                var res = dto.ClientResolution;
                clientResolution = $"{res?.HorizontalResolution}x{res?.VerticalResolution} @ {res?.ColorDepth} bits per pixel";
            }

            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("9UBogz2BsUHi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("piUb8FTu3wg=")[iii % 8])).ToArray()), -30}:  {dto.SessionID}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("8jAClf2EhxfAOBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oVVx5pTr6Vk=")[iii % 8])).ToArray()), -30}:  {dto.SessionName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("WcUScgBCd7I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DLZ3AE4jGtc=")[iii % 8])).ToArray()), -30}:  {dto.DomainName}\\{dto.UserName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("cmQtCUk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IRBMfSzL0qY=")[iii % 8])).ToArray()), -30}:  {dto.State}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("y663ShRYtE4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g8HEPlo52Ss=")[iii % 8])).ToArray()), -30}:  {dto.HostName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("hMyZjgF8hpc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wq3r408d6/I=")[iii % 8])).ToArray()), -30}:  {dto.FarmName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("O7CqbkJvya0D").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d9HZGgsBudg=")[iii % 8])).ToArray()), -30}:  {lastInputStr}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("4GJstnyYMXM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ow4F0xLseCM=")[iii % 8])).ToArray()), -30}:  {dto.ClientIp}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("wX65BUropSLxZr4BSfk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ghLQYCSc7U0=")[iii % 8])).ToArray()), -30}:  {dto.ClientHostname}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("aXRIlfvJ1YVZd02F4dTojg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Khgh8JW9h+A=")[iii % 8])).ToArray()), -30}:  {clientResolution}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("P7GyT/qTgu4Vsb8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fN3bKpTnwJs=")[iii % 8])).ToArray()), -30}:  {dto.ClientBuild}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("lKOsJyIko46lq7IjPjWiiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("18/FQkxQ6+8=")[iii % 8])).ToArray()), -30}:  {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c0iii8etKkU=")[iii % 8])).ToArray()), dto.ClientHardwareId.Select(b => b.ToString()).ToArray())}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("/0sDcA54+3/OQglhD37G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vCdqFWAMvxY=")[iii % 8])).ToArray()), -30}:  {dto.ClientDirectory}\n");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string KkUCzSRi)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Version instance = new System.Version();
                        instance.ToString(75);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_978EAB6D)result;
            var lastInputStr = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d62f4SOlv54=")[iii % 8])).ToArray());
            if (dto.LastInputTime != null)
            {
                var lastInputDt = DateTime.FromFileTimeUtc((long)dto.LastInputTime);
                var t = DateTime.UtcNow - lastInputDt;
                lastInputStr = $"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms";
            }

            var clientResolution = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rCNISkGI0rw=")[iii % 8])).ToArray());
            if (dto.ClientResolution != null && dto.ClientResolution?.HorizontalResolution != 0)
            {
                var res = dto.ClientResolution;
                clientResolution = $"{res?.HorizontalResolution}x{res?.VerticalResolution} @ {res?.ColorDepth} bits per pixel";
            }

            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("9UBogz2BsUHi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("piUb8FTu3wg=")[iii % 8])).ToArray()), -30}:  {dto.SessionID}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("8jAClf2EhxfAOBQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oVVx5pTr6Vk=")[iii % 8])).ToArray()), -30}:  {dto.SessionName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("WcUScgBCd7I=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DLZ3AE4jGtc=")[iii % 8])).ToArray()), -30}:  {dto.DomainName}\\{dto.UserName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("cmQtCUk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IRBMfSzL0qY=")[iii % 8])).ToArray()), -30}:  {dto.State}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("y663ShRYtE4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g8HEPlo52Ss=")[iii % 8])).ToArray()), -30}:  {dto.HostName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("hMyZjgF8hpc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wq3r408d6/I=")[iii % 8])).ToArray()), -30}:  {dto.FarmName}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("O7CqbkJvya0D").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d9HZGgsBudg=")[iii % 8])).ToArray()), -30}:  {lastInputStr}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("4GJstnyYMXM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ow4F0xLseCM=")[iii % 8])).ToArray()), -30}:  {dto.ClientIp}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("wX65BUropSLxZr4BSfk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ghLQYCSc7U0=")[iii % 8])).ToArray()), -30}:  {dto.ClientHostname}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("aXRIlfvJ1YVZd02F4dTojg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Khgh8JW9h+A=")[iii % 8])).ToArray()), -30}:  {clientResolution}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("P7GyT/qTgu4Vsb8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fN3bKpTnwJs=")[iii % 8])).ToArray()), -30}:  {dto.ClientBuild}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("lKOsJyIko46lq7IjPjWiiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("18/FQkxQ6+8=")[iii % 8])).ToArray()), -30}:  {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c0iii8etKkU=")[iii % 8])).ToArray()), dto.ClientHardwareId.Select(b => b.ToString()).ToArray())}");
            WriteLine($"  {Encoding.UTF8.GetString(Convert.FromBase64String("/0sDcA54+3/OQglhD37G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vCdqFWAMvxY=")[iii % 8])).ToArray()), -30}:  {dto.ClientDirectory}\n");
        }
    }
}