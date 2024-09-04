using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Net;
using System.Reflection;
using O_F41F88FA.Interop;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_6363B96E
    {
        public O_6363B96E(string ipAddress, string physicalAddress, string entryType)
        {
            IpAddress = ipAddress;
            PhysicalAddress = physicalAddress;
            EntryType = entryType;
        }

        public string IpAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string EntryType { get; set; }
    }
internal class O_1FAD9A6C : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("7g1x9e55k4w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r18hoY8b/+k=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("xyb38AnBaH3ub+fxCJN5e/9vxdYqwWh06SPhpBuPeDXqK+X0DoRuNeIh4usIjH1h4iDqpFKEbWDiOeXoH49oNf8gpOUIkTw46mY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i0+EhHrhHBU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_1FAD9A6C(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var adapterIdToInterfaceMap = new SortedDictionary<uint, O_06C7774A>();
        foreach (var networkInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
            BuildIndexToInterfaceMap(networkInterface, adapterIdToInterfaceMap);
        }

        var bytesNeeded = 0;
        var result = Iphlpapi.GetIpNetTable(IntPtr.Zero, ref bytesNeeded, false);
        if (result != O_3BB7B919.InsufficientBuffer)
        {
            throw new Exception($"GetIpNetTable: Expected insufficient buffer but got {result}");
        }

        var buffer = Marshal.AllocCoTaskMem(bytesNeeded);
        try
        {
            result = Iphlpapi.GetIpNetTable(buffer, ref bytesNeeded, false);
            if (result != 0)
            {
                throw new Exception($"GetIpNetTable error: {result}");
            }

            var entries = Marshal.ReadInt32(buffer);
            var currentBuffer = new IntPtr(buffer.ToInt64() + Marshal.SizeOf(typeof(int)));
            var arpEntries = new List<Iphlpapi.MIB_IPNETROW>();
            for (var index = 0; index < entries; index++)
            {
                arpEntries.Add((Iphlpapi.MIB_IPNETROW)Marshal.PtrToStructure(new IntPtr(currentBuffer.ToInt64() + (index * Marshal.SizeOf(typeof(Iphlpapi.MIB_IPNETROW)))), typeof(Iphlpapi.MIB_IPNETROW)));
            }

            var sortedArpEntries = arpEntries.OrderBy(o => o.dwIndex).ToList();
            uint? currentAdapterIndex = null;
            foreach (var arpEntry in sortedArpEntries)
            {
                var adapterIndex = (uint)arpEntry.dwIndex;
                if (currentAdapterIndex != adapterIndex)
                {
                    if (!adapterIdToInterfaceMap.ContainsKey(adapterIndex))
                    {
                        adapterIdToInterfaceMap[adapterIndex] = new O_06C7774A(adapterIndex, Encoding.UTF8.GetString(Convert.FromBase64String("9lWx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mHrQC0EIoHs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("8jrZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nBW48mFjZgo=")[iii % 8])).ToArray()));
                    }

                    currentAdapterIndex = adapterIndex;
                }

                var ipAddress = new IPAddress(BitConverter.GetBytes(arpEntry.dwAddr));
                var macBytes = new[]
                {
                    arpEntry.mac0,
                    arpEntry.mac1,
                    arpEntry.mac2,
                    arpEntry.mac3,
                    arpEntry.mac4,
                    arpEntry.mac5
                };
                var physicalAddress = BitConverter.ToString(macBytes);
                var entryType = (Iphlpapi.ArpEntryType)arpEntry.dwType;
                var entry = new O_6363B96E(ipAddress.ToString(), physicalAddress, entryType.ToString());
                adapterIdToInterfaceMap[adapterIndex].Entries.Add(entry);
            }
        }
        finally
        {
            if (buffer != IntPtr.Zero)
                Iphlpapi.FreeMibTable(buffer);
        }

        foreach (var adapter in adapterIdToInterfaceMap)
        {
            yield return adapter.Value;
        }
    }

    private static void BuildIndexToInterfaceMap(NetworkInterface ni, SortedDictionary<uint, O_06C7774A> adapters)
    {
        var adapterProperties = ni.GetIPProperties();
        if (adapterProperties == null)
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("IgglipJaKtwVRzeDglol1wAXJIOEWg3jQRciiYYfNscIAiM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YWdQ5vZ6RLM=")[iii % 8])).ToArray()));
        var index = (uint? )ni.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("87RM+qw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mtoon9RCxlc=")[iii % 8])).ToArray()), BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(ni);
        if (index == null)
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("PSRc61Dbp8sKa07iQNugygouW+FVmKyEFyVN4kzbp9ETKUz1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fksphzT7yaQ=")[iii % 8])).ToArray()));
        var adapter = new O_06C7774A(index.Value, ni.Name, ni.Description);
        adapterProperties.UnicastAddresses.ToList().ForEach(ip => adapter.InterfaceIPs.Add(ip.Address.ToString()));
        adapterProperties.DnsAddresses.ToList().ForEach(dns => adapter.DnsServers.Add(dns.ToString()));
        adapters.Add(index.Value, adapter);
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string EtkyljUB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
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

        var adapterIdToInterfaceMap = new SortedDictionary<uint, O_06C7774A>();
        foreach (var networkInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
            BuildIndexToInterfaceMap(networkInterface, adapterIdToInterfaceMap);
        }

        var bytesNeeded = 0;
        var result = Iphlpapi.GetIpNetTable(IntPtr.Zero, ref bytesNeeded, false);
        if (result != O_3BB7B919.InsufficientBuffer)
        {
            throw new Exception($"GetIpNetTable: Expected insufficient buffer but got {result}");
        }

        var buffer = Marshal.AllocCoTaskMem(bytesNeeded);
        try
        {
            result = Iphlpapi.GetIpNetTable(buffer, ref bytesNeeded, false);
            if (result != 0)
            {
                throw new Exception($"GetIpNetTable error: {result}");
            }

            var entries = Marshal.ReadInt32(buffer);
            var currentBuffer = new IntPtr(buffer.ToInt64() + Marshal.SizeOf(typeof(int)));
            var arpEntries = new List<Iphlpapi.MIB_IPNETROW>();
            for (var index = 0; index < entries; index++)
            {
                arpEntries.Add((Iphlpapi.MIB_IPNETROW)Marshal.PtrToStructure(new IntPtr(currentBuffer.ToInt64() + (index * Marshal.SizeOf(typeof(Iphlpapi.MIB_IPNETROW)))), typeof(Iphlpapi.MIB_IPNETROW)));
            }

            var sortedArpEntries = arpEntries.OrderBy(o => o.dwIndex).ToList();
            uint? currentAdapterIndex = null;
            foreach (var arpEntry in sortedArpEntries)
            {
                var adapterIndex = (uint)arpEntry.dwIndex;
                if (currentAdapterIndex != adapterIndex)
                {
                    if (!adapterIdToInterfaceMap.ContainsKey(adapterIndex))
                    {
                        adapterIdToInterfaceMap[adapterIndex] = new O_06C7774A(adapterIndex, Encoding.UTF8.GetString(Convert.FromBase64String("9lWx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mHrQC0EIoHs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("8jrZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nBW48mFjZgo=")[iii % 8])).ToArray()));
                    }

                    currentAdapterIndex = adapterIndex;
                }

                var ipAddress = new IPAddress(BitConverter.GetBytes(arpEntry.dwAddr));
                var macBytes = new[]
                {
                    arpEntry.mac0,
                    arpEntry.mac1,
                    arpEntry.mac2,
                    arpEntry.mac3,
                    arpEntry.mac4,
                    arpEntry.mac5
                };
                var physicalAddress = BitConverter.ToString(macBytes);
                var entryType = (Iphlpapi.ArpEntryType)arpEntry.dwType;
                var entry = new O_6363B96E(ipAddress.ToString(), physicalAddress, entryType.ToString());
                adapterIdToInterfaceMap[adapterIndex].Entries.Add(entry);
            }
        }
        finally
        {
            if (buffer != IntPtr.Zero)
                Iphlpapi.FreeMibTable(buffer);
        }

        foreach (var adapter in adapterIdToInterfaceMap)
        {
            yield return adapter.Value;
        }
    }

    private static void BuildIndexToInterfaceMap(NetworkInterface ni, SortedDictionary<uint, O_06C7774A> adapters, string kmApRUGg)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
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

        var adapterProperties = ni.GetIPProperties();
        if (adapterProperties == null)
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("IgglipJaKtwVRzeDglol1wAXJIOEWg3jQRciiYYfNscIAiM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YWdQ5vZ6RLM=")[iii % 8])).ToArray()));
        var index = (uint? )ni.GetType().GetField(Encoding.UTF8.GetString(Convert.FromBase64String("87RM+qw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mtoon9RCxlc=")[iii % 8])).ToArray()), BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(ni);
        if (index == null)
            throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("PSRc61Dbp8sKa07iQNugygouW+FVmKyEFyVN4kzbp9ETKUz1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fksphzT7yaQ=")[iii % 8])).ToArray()));
        var adapter = new O_06C7774A(index.Value, ni.Name, ni.Description);
        adapterProperties.UnicastAddresses.ToList().ForEach(ip => adapter.InterfaceIPs.Add(ip.Address.ToString()));
        adapterProperties.DnsAddresses.ToList().ForEach(dns => adapter.DnsServers.Add(dns.ToString()));
        adapters.Add(index.Value, adapter);
    }
}internal class O_06C7774A : O_4AED570F
{
    public O_06C7774A(uint index, string name, string description)
    {
        InterfaceIndex = index;
        InterfaceName = name;
        InterfaceDescription = description;
    }

    public uint InterfaceIndex { get; }
    public string InterfaceName { get; }
    public string InterfaceDescription { get; }
    public List<string> InterfaceIPs { get; set; } = new List<string>();
    public List<string> DnsServers { get; set; } = new List<string>();
    public List<O_6363B96E> Entries { get; set; } = new List<O_6363B96E>();
}
    [CommandOutputType(typeof(O_06C7774A))]
    internal class O_4476C7D9 : TextFormatterBase
    {
        public O_4476C7D9(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_06C7774A)result;
            WriteLine($"  {dto.InterfaceName} --- Index {dto.InterfaceIndex}");
            WriteLine($"    Interface Description : {dto.InterfaceDescription}");
            WriteLine($"    Interface IPs      : {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("GLA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NJDpWtbhLfo=")[iii % 8])).ToArray()), dto.InterfaceIPs.ToArray())}");
            if (dto.DnsServers.Count > 0)
            {
                WriteLine($"    DNS Servers        : {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("/JE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0LHOQpSa+wM=")[iii % 8])).ToArray()), dto.DnsServers.ToArray())}\n");
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("INd+TRd9S0BymTsZflJbQXKSLR5+Mx8FINcOBSdgVkZhm34sOndNQHOEfk1+Mx8FVI4uCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("APdebV4TPyU=")[iii % 8])).ToArray()));
            foreach (var entry in dto.Entries)
            {
                WriteLine($"    {entry.IpAddress, -22}{entry.PhysicalAddress, -22}{entry.EntryType}");
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q2cQSnetW5A=")[iii % 8])).ToArray()));
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string OXfdWJbB)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.GregorianCalendar instance = new System.Globalization.GregorianCalendar();
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

            var dto = (O_06C7774A)result;
            WriteLine($"  {dto.InterfaceName} --- Index {dto.InterfaceIndex}");
            WriteLine($"    Interface Description : {dto.InterfaceDescription}");
            WriteLine($"    Interface IPs      : {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("GLA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NJDpWtbhLfo=")[iii % 8])).ToArray()), dto.InterfaceIPs.ToArray())}");
            if (dto.DnsServers.Count > 0)
            {
                WriteLine($"    DNS Servers        : {string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("/JE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0LHOQpSa+wM=")[iii % 8])).ToArray()), dto.DnsServers.ToArray())}\n");
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("INd+TRd9S0BymTsZflJbQXKSLR5+Mx8FINcOBSdgVkZhm34sOndNQHOEfk1+Mx8FVI4uCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("APdebV4TPyU=")[iii % 8])).ToArray()));
            foreach (var entry in dto.Entries)
            {
                WriteLine($"    {entry.IpAddress, -22}{entry.PhysicalAddress, -22}{entry.EntryType}");
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("SQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q2cQSnetW5A=")[iii % 8])).ToArray()));
        }
    }
}