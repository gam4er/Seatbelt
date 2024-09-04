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
internal class O_1CF053D4 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Odbdmc1xmCcPxsS1zGw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bLKt2qIf9kI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("JoysPHgdy+YwvY5ufhzRqACaqidyHczmBJe6bnwAzKkGkL86eBeftheWvStuANq1RZiwKj0A2rQTkL0rbg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZfneTh1zv8Y=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_1CF053D4(Runtime runtime) : base(runtime)
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
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Rd35dxjnioYkmdFqHvWVhkXdlThbpsaGRa38XFumxoY2mMduEuWDhkXdlThbpsaGRd2VOFumxoY1j9p7HvWV6ASQ0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zf21GHuG5qY=")[iii % 8])).ToArray()));
        try
        {
            var searcher = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("oXGF/Csgl+nScpv2JVTgqpwH++Y4Btigl0e6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8jTJuWh0t8M=")[iii % 8])).ToArray()));
            var retObjectCollection = searcher.Get();
            foreach (ManagementObject Process in retObjectCollection)
            {
                processNames.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("pcZVeLWVsDKR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9bQ6G9Dmw3s=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("US5yQQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H08fJJ3V28s=")[iii % 8])).ToArray())].ToString());
                if (Process[Encoding.UTF8.GetString(Convert.FromBase64String("EloQlPI7ELo4Wxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UTV9+ZNVdPY=")[iii % 8])).ToArray())] != null)
                {
                    processCommandLines.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("W6wJlCsOQZlv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C95m9059MtA=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("3KbN0WMPXuT2p8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8mgvAJhOqg=")[iii % 8])).ToArray())].ToString());
                }
            }

            var ret = GetExtendedUdpTable(IntPtr.Zero, ref tableBufferSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_MODULE, 0);
            if (ret != O_3BB7B919.Success && ret != O_3BB7B919.InsufficientBuffer)
            {
                WriteError($"Bad check value from GetExtendedUdpTable : {ret}");
                yield break;
            }

            tableBuffer = Marshal.AllocHGlobal((int)tableBufferSize);
            ret = GetExtendedUdpTable(tableBuffer, ref tableBufferSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_MODULE, 0);
            if (ret != O_3BB7B919.Success)
            {
                WriteError($"Bad return value from GetExtendedUdpTable : {ret}");
                yield break;
            }

            var ownerModuleTable = (MIB_UDPTABLE_OWNER_MODULE)Marshal.PtrToStructure(tableBuffer, typeof(MIB_UDPTABLE_OWNER_MODULE));
            rowPtr = (IntPtr)(tableBuffer.ToInt64() + Marshal.OffsetOf(typeof(MIB_UDPTABLE_OWNER_MODULE), Encoding.UTF8.GetString(Convert.FromBase64String("r7TlYT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+9WHDVqJhIY=")[iii % 8])).ToArray())).ToInt64());
            var UdpRows = new MIB_UDPROW_OWNER_MODULE[ownerModuleTable.NumEntries];
            for (var i = 0; i < ownerModuleTable.NumEntries; i++)
            {
                var udpRow = (MIB_UDPROW_OWNER_MODULE)Marshal.PtrToStructure(rowPtr, typeof(MIB_UDPROW_OWNER_MODULE));
                UdpRows[i] = udpRow;
                rowPtr = (IntPtr)((long)rowPtr + Marshal.SizeOf(udpRow));
            }

            foreach (var entry in UdpRows)
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
                yield return new O_C1EB2ACA(entry.LocalAddress.ToString(), entry.LocalPort, entry.OwningPid, processName, processCommandLine, serviceName);
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

    public IEnumerable<O_4AED570F?> Execute(string[] args, string gCQJMMZk)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxByteCount(62);
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
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Rd35dxjnioYkmdFqHvWVhkXdlThbpsaGRa38XFumxoY2mMduEuWDhkXdlThbpsaGRd2VOFumxoY1j9p7HvWV6ASQ0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zf21GHuG5qY=")[iii % 8])).ToArray()));
        try
        {
            var searcher = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("oXGF/Csgl+nScpv2JVTgqpwH++Y4Btigl0e6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8jTJuWh0t8M=")[iii % 8])).ToArray()));
            var retObjectCollection = searcher.Get();
            foreach (ManagementObject Process in retObjectCollection)
            {
                processNames.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("pcZVeLWVsDKR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9bQ6G9Dmw3s=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("US5yQQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H08fJJ3V28s=")[iii % 8])).ToArray())].ToString());
                if (Process[Encoding.UTF8.GetString(Convert.FromBase64String("EloQlPI7ELo4Wxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UTV9+ZNVdPY=")[iii % 8])).ToArray())] != null)
                {
                    processCommandLines.Add(Process[Encoding.UTF8.GetString(Convert.FromBase64String("W6wJlCsOQZlv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C95m9059MtA=")[iii % 8])).ToArray())].ToString(), Process[Encoding.UTF8.GetString(Convert.FromBase64String("3KbN0WMPXuT2p8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8mgvAJhOqg=")[iii % 8])).ToArray())].ToString());
                }
            }

            var ret = GetExtendedUdpTable(IntPtr.Zero, ref tableBufferSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_MODULE, 0);
            if (ret != O_3BB7B919.Success && ret != O_3BB7B919.InsufficientBuffer)
            {
                WriteError($"Bad check value from GetExtendedUdpTable : {ret}");
                yield break;
            }

            tableBuffer = Marshal.AllocHGlobal((int)tableBufferSize);
            ret = GetExtendedUdpTable(tableBuffer, ref tableBufferSize, true, AF_INET, UDP_TABLE_CLASS.UDP_TABLE_OWNER_MODULE, 0);
            if (ret != O_3BB7B919.Success)
            {
                WriteError($"Bad return value from GetExtendedUdpTable : {ret}");
                yield break;
            }

            var ownerModuleTable = (MIB_UDPTABLE_OWNER_MODULE)Marshal.PtrToStructure(tableBuffer, typeof(MIB_UDPTABLE_OWNER_MODULE));
            rowPtr = (IntPtr)(tableBuffer.ToInt64() + Marshal.OffsetOf(typeof(MIB_UDPTABLE_OWNER_MODULE), Encoding.UTF8.GetString(Convert.FromBase64String("r7TlYT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+9WHDVqJhIY=")[iii % 8])).ToArray())).ToInt64());
            var UdpRows = new MIB_UDPROW_OWNER_MODULE[ownerModuleTable.NumEntries];
            for (var i = 0; i < ownerModuleTable.NumEntries; i++)
            {
                var udpRow = (MIB_UDPROW_OWNER_MODULE)Marshal.PtrToStructure(rowPtr, typeof(MIB_UDPROW_OWNER_MODULE));
                UdpRows[i] = udpRow;
                rowPtr = (IntPtr)((long)rowPtr + Marshal.SizeOf(udpRow));
            }

            foreach (var entry in UdpRows)
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
                yield return new O_C1EB2ACA(entry.LocalAddress.ToString(), entry.LocalPort, entry.OwningPid, processName, processCommandLine, serviceName);
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
}internal class O_C1EB2ACA : O_4AED570F
{
    public O_C1EB2ACA(string localAddress, ushort localPort, uint processId, string? processName, string? processCommandLine, string? service)
    {
        LocalAddress = localAddress;
        LocalPort = localPort;
        ProcessId = processId;
        ProcessName = processName;
        ProcessCommandLine = processCommandLine;
        ServiceName = service;
    }

    public string LocalAddress { get; set; }
    public ushort LocalPort { get; set; }
    public uint ProcessId { get; set; }
    public string? ProcessName { get; }
    public string? ProcessCommandLine { get; }
    public string? ServiceName { get; }
}
    [CommandOutputType(typeof(O_C1EB2ACA))]
    internal class O_746FE716 : TextFormatterBase
    {
        public O_746FE716(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            if (result != null)
            {
                var dto = (O_C1EB2ACA)result;
                if (dto.ProcessCommandLine != null)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eLDJU/tlkDYl64NP+n/ffmq8n1HkNYJ+a+0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WJCyY9dIogU=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("GQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I23VesirLPU=")[iii % 8])).ToArray()) + dto.LocalPort, dto.ProcessId, dto.ServiceName, dto.ProcessCommandLine);
                }
                else
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ooCj/KibHlT/2+ngqYFRHLCM9f63ywwcsd0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gqDYzIS2LGc=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("Fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LVm7vMacNCc=")[iii % 8])).ToArray()) + dto.LocalPort, dto.ProcessId, dto.ServiceName, dto.ProcessName);
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string iHThPtdf)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxByteCount(62);
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
                var dto = (O_C1EB2ACA)result;
                if (dto.ProcessCommandLine != null)
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eLDJU/tlkDYl64NP+n/ffmq8n1HkNYJ+a+0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WJCyY9dIogU=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("GQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I23VesirLPU=")[iii % 8])).ToArray()) + dto.LocalPort, dto.ProcessId, dto.ServiceName, dto.ProcessCommandLine);
                }
                else
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ooCj/KibHlT/2+ngqYFRHLCM9f63ywwcsd0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gqDYzIS2LGc=")[iii % 8])).ToArray()), dto.LocalAddress + Encoding.UTF8.GetString(Convert.FromBase64String("Fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LVm7vMacNCc=")[iii % 8])).ToArray()) + dto.LocalPort, dto.ProcessId, dto.ServiceName, dto.ProcessName);
                }
            }
        }
    }
}