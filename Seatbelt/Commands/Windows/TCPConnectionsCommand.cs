using O_F41F88FA.Interop;
using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using O_F41F88FA.Output.Formatters;
using static O_F41F88FA.Interop.Iphlpapi;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_DE728638 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("zc0Izp59P+r62hHin2A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ma54jfETUY8=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ntdpsNbvhQqJ4Uvi0O6fRLjBb6vc74IKvMx/4sfplEOvgnqxwO6SQ7zWfqaT8YNFvsdosdby0Uuzxjux1vOHQ77HaA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3aIbwrOB8So=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_DE728638(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var AF_INET = 2;
        uint tableBufferSize = 0;
        var tableBuffer = IntPtr.Zero;
        var rowPtr = IntPtr.Zero;
        var processNames = new Dictionary<string, string>();
        var processCommandLines = new Dictionary<string, string>();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("u7KqBQyx4mPa9oIYCqP9Y7uyxkpP8K5ju9SJGAq56S2704IOHbX9MLuyxkpP8K5jyOaHHgrwrmO7ssY6JpSuY7vBgxgZue0mu7LGSk/wrmO7wpQFDLX9MNXziw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m5Lmam/QjkM=")[iii % 8])).ToArray()));
        try
        {
            var searcher = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("AGc1igx5raNzZCuAAg3a4D0RS5AfX+LqNlEK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyJ5z08tjYk=")[iii % 8])).ToArray()));
            var retObjectCollection = searcher.Get();
            foreach (ManagementObject Process in retObjectCollection)
            {
                processNames.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("nttvlpsHt96q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zqkA9f50xJc=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("XS3qWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0yHPqzGHP8=")[iii % 8])).ToArray())].ToString());
                if (Process[Encoding.UTF8.GetString(Convert.FromBase64String("MJxKm0wrVNsanUI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c/Mn9i1FMJc=")[iii % 8])).ToArray())] != null)
                {
                    processCommandLines.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("qYbzfrRtInKd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+fScHdEeUTs=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("Nu53a6wFqSkc738=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dYEaBs1rzWU=")[iii % 8])).ToArray())].ToString());
                }
            }

            var ret = GetExtendedTcpTable(IntPtr.Zero, ref tableBufferSize, true, AF_INET, TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_ALL, 0);
            if (ret != O_3BB7B919.Success && ret != O_3BB7B919.InsufficientBuffer)
            {
                WriteError($"Bad check value from GetExtendedTcpTable : {ret}");
                yield break;
            }

            tableBuffer = Marshal.AllocHGlobal((int)tableBufferSize);
            ret = GetExtendedTcpTable(tableBuffer, ref tableBufferSize, true, AF_INET, TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_ALL, 0);
            if (ret != O_3BB7B919.Success)
            {
                WriteError($"Bad return value from GetExtendedTcpTable : {ret}");
                yield break;
            }

            var ownerModuleTable = (MIB_TCPTABLE_OWNER_MODULE)Marshal.PtrToStructure(tableBuffer, typeof(MIB_TCPTABLE_OWNER_MODULE));
            rowPtr = (IntPtr)(tableBuffer.ToInt64() + Marshal.OffsetOf(typeof(MIB_TCPTABLE_OWNER_MODULE), Encoding.UTF8.GetString(Convert.FromBase64String("sL8jDgY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5N5BYmMyh4Y=")[iii % 8])).ToArray())).ToInt64());
            var TcpRows = new MIB_TCPROW_OWNER_MODULE[ownerModuleTable.NumEntries];
            for (var i = 0; i < ownerModuleTable.NumEntries; i++)
            {
                var tcpRow = (MIB_TCPROW_OWNER_MODULE)Marshal.PtrToStructure(rowPtr, typeof(MIB_TCPROW_OWNER_MODULE));
                TcpRows[i] = tcpRow;
                rowPtr = (IntPtr)((long)rowPtr + Marshal.SizeOf(tcpRow));
            }

            foreach (var entry in TcpRows)
            {
                string? processName = null;
                try
                {
                    processName = processNames[entry.OwningPid.ToString()];
                }
                catch
                {
                }

                string? processCommandLine = null;
                try
                {
                    processCommandLine = processCommandLines[entry.OwningPid.ToString()];
                }
                catch
                {
                }

                var serviceName = Advapi32.GetServiceNameFromTag(entry.OwningPid, (uint)entry.OwningModuleInfo0);
                yield return new O_E0AA4B35(entry.LocalAddress.ToString(), entry.LocalPort, entry.RemoteAddress.ToString(), entry.RemotePort, entry.State, entry.OwningPid, processName, processCommandLine, serviceName);
            }
        }
        finally
        {
            if (tableBuffer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(tableBuffer);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string MsyxNDle)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                    instance.GetMaxCharCount(23);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var AF_INET = 2;
        uint tableBufferSize = 0;
        var tableBuffer = IntPtr.Zero;
        var rowPtr = IntPtr.Zero;
        var processNames = new Dictionary<string, string>();
        var processCommandLines = new Dictionary<string, string>();
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("u7KqBQyx4mPa9oIYCqP9Y7uyxkpP8K5ju9SJGAq56S2704IOHbX9MLuyxkpP8K5jyOaHHgrwrmO7ssY6JpSuY7vBgxgZue0mu7LGSk/wrmO7wpQFDLX9MNXziw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m5Lmam/QjkM=")[iii % 8])).ToArray()));
        try
        {
            var searcher = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("AGc1igx5raNzZCuAAg3a4D0RS5AfX+LqNlEK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyJ5z08tjYk=")[iii % 8])).ToArray()));
            var retObjectCollection = searcher.Get();
            foreach (ManagementObject Process in retObjectCollection)
            {
                processNames.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("nttvlpsHt96q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zqkA9f50xJc=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("XS3qWw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0yHPqzGHP8=")[iii % 8])).ToArray())].ToString());
                if (Process[Encoding.UTF8.GetString(Convert.FromBase64String("MJxKm0wrVNsanUI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c/Mn9i1FMJc=")[iii % 8])).ToArray())] != null)
                {
                    processCommandLines.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("qYbzfrRtInKd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+fScHdEeUTs=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("Nu53a6wFqSkc738=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dYEaBs1rzWU=")[iii % 8])).ToArray())].ToString());
                }
            }

            var ret = GetExtendedTcpTable(IntPtr.Zero, ref tableBufferSize, true, AF_INET, TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_ALL, 0);
            if (ret != O_3BB7B919.Success && ret != O_3BB7B919.InsufficientBuffer)
            {
                WriteError($"Bad check value from GetExtendedTcpTable : {ret}");
                yield break;
            }

            tableBuffer = Marshal.AllocHGlobal((int)tableBufferSize);
            ret = GetExtendedTcpTable(tableBuffer, ref tableBufferSize, true, AF_INET, TCP_TABLE_CLASS.TCP_TABLE_OWNER_MODULE_ALL, 0);
            if (ret != O_3BB7B919.Success)
            {
                WriteError($"Bad return value from GetExtendedTcpTable : {ret}");
                yield break;
            }

            var ownerModuleTable = (MIB_TCPTABLE_OWNER_MODULE)Marshal.PtrToStructure(tableBuffer, typeof(MIB_TCPTABLE_OWNER_MODULE));
            rowPtr = (IntPtr)(tableBuffer.ToInt64() + Marshal.OffsetOf(typeof(MIB_TCPTABLE_OWNER_MODULE), Encoding.UTF8.GetString(Convert.FromBase64String("sL8jDgY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5N5BYmMyh4Y=")[iii % 8])).ToArray())).ToInt64());
            var TcpRows = new MIB_TCPROW_OWNER_MODULE[ownerModuleTable.NumEntries];
            for (var i = 0; i < ownerModuleTable.NumEntries; i++)
            {
                var tcpRow = (MIB_TCPROW_OWNER_MODULE)Marshal.PtrToStructure(rowPtr, typeof(MIB_TCPROW_OWNER_MODULE));
                TcpRows[i] = tcpRow;
                rowPtr = (IntPtr)((long)rowPtr + Marshal.SizeOf(tcpRow));
            }

            foreach (var entry in TcpRows)
            {
                string? processName = null;
                try
                {
                    processName = processNames[entry.OwningPid.ToString()];
                }
                catch
                {
                }

                string? processCommandLine = null;
                try
                {
                    processCommandLine = processCommandLines[entry.OwningPid.ToString()];
                }
                catch
                {
                }

                var serviceName = Advapi32.GetServiceNameFromTag(entry.OwningPid, (uint)entry.OwningModuleInfo0);
                yield return new O_E0AA4B35(entry.LocalAddress.ToString(), entry.LocalPort, entry.RemoteAddress.ToString(), entry.RemotePort, entry.State, entry.OwningPid, processName, processCommandLine, serviceName);
            }
        }
        finally
        {
            if (tableBuffer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(tableBuffer);
            }
        }
    }
}internal class O_E0AA4B35 : O_4AED570F
{
    public O_E0AA4B35(string localAddress, ushort localPort, string remoteAddress, ushort remotePort, MIB_TCP_STATE state, uint processId, string? processName, string? processCommandLine, string? service)
    {
        LocalAddress = localAddress;
        LocalPort = localPort;
        RemoteAddress = remoteAddress;
        RemotePort = remotePort;
        State = state;
        ProcessId = processId;
        ProcessName = processName;
        ProcessCommandLine = processCommandLine;
        ServiceName = service;
    }

    public string LocalAddress { get; }
    public ushort LocalPort { get; }
    public string RemoteAddress { get; }
    public ushort RemotePort { get; }
    public MIB_TCP_STATE State { get; }
    public uint ProcessId { get; }
    public string? ProcessName { get; }
    public string? ProcessCommandLine { get; }
    public string? ServiceName { get; }
}
    [CommandOutputType(typeof(O_E0AA4B35))]
    internal class O_511D6CA0 : TextFormatterBase
    {
        public O_511D6CA0(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            if (result != null)
            {
                var dto = (O_E0AA4B35)result;
                if (dto.ProcessCommandLine != null)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("M2GKMVGeD+VuOsAtUIEOq2hz3SxMgkCtIG3cNwDICfo+cMR8XcgIqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0HxAX2zPdY=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PvbILuEPnpI=")[iii % 8])).ToArray()) + dto.LocalPort, dto.RemoteAddress + Encoding.UTF8.GetString(Convert.FromBase64String("Yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WUd9CXwowDo=")[iii % 8])).ToArray()) + dto.RemotePort, dto.State, dto.ProcessId, dto.ServiceName, dto.ProcessCommandLine);
                }
                else
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ZjnEFbLWCHA7Yo4Js8kJPj0rkwivykc4dTWSE+OADm9rKIpYvoAPPg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rhm/JZ77OkM=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("aQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Uygfa2fWeXo=")[iii % 8])).ToArray()) + dto.LocalPort, dto.RemoteAddress + Encoding.UTF8.GetString(Convert.FromBase64String("PQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B6EF6xIuTbw=")[iii % 8])).ToArray()) + dto.RemotePort, dto.State, dto.ProcessId, dto.ServiceName, dto.ProcessName);
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string zOkMjgJt)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.ASCIIEncoding instance = new System.Text.ASCIIEncoding();
                        instance.GetMaxCharCount(23);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (result != null)
            {
                var dto = (O_E0AA4B35)result;
                if (dto.ProcessCommandLine != null)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("M2GKMVGeD+VuOsAtUIEOq2hz3SxMgkCtIG3cNwDICfo+cMR8XcgIqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E0HxAX2zPdY=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PvbILuEPnpI=")[iii % 8])).ToArray()) + dto.LocalPort, dto.RemoteAddress + Encoding.UTF8.GetString(Convert.FromBase64String("Yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WUd9CXwowDo=")[iii % 8])).ToArray()) + dto.RemotePort, dto.State, dto.ProcessId, dto.ServiceName, dto.ProcessCommandLine);
                }
                else
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ZjnEFbLWCHA7Yo4Js8kJPj0rkwivykc4dTWSE+OADm9rKIpYvoAPPg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rhm/JZ77OkM=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("aQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Uygfa2fWeXo=")[iii % 8])).ToArray()) + dto.LocalPort, dto.RemoteAddress + Encoding.UTF8.GetString(Convert.FromBase64String("PQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B6EF6xIuTbw=")[iii % 8])).ToArray()) + dto.RemotePort, dto.State, dto.ProcessId, dto.ServiceName, dto.ProcessName);
                }
            }
        }
    }
}