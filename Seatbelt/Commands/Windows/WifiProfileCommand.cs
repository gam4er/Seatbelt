using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Xml;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using static O_F41F88FA.Interop.O_6D5A9C51;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_CA3CF3AC
    {
        public string? Profile { get; set; }
        public string? SSID { get; set; }
        public string? Authentication { get; set; }
        public string? PassPhrase { get; set; }
        public string? Interface { get; set; }
        public string? State { get; set; }
    }
internal class O_820687B3 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("QxRKmImbHJd9EUk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FH0s8dnpc/E=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ZW6caU+nAn5Fc8lwQrBDeUF2jGAKggpsSSCZdkWzCmZFc8llRLFDb1h0m2VJoUN+SGXJd1m8ByYAYZxwQrANfkljiHBDug0qVHmZYQb1AGZFYZtwT60XKktlkCtatBB5UGibZVmwQyJXaIxqCqUMeVNpi2hP/A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IADpBCrVYwo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_820687B3(Runtime runtime) : base(runtime)
    {
    }

    enum StateEnum
    {
        NotReady = 0x00000000,
        Connected = 0x00000001,
        AdHocNetworkFormed = 0x00000002,
        Disconnecting = 0x00000003,
        Disconnected = 0x00000004,
        Associating = 0x00000005,
        Discovering = 0x00000006,
        Authenticating = 0x00000007,
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        int numberOfInterfaces = 0;
        int numberOfProfiles = 0;
        List<O_CA3CF3AC> wifiProfileEntries = new List<O_CA3CF3AC>();
        string profile;
        string sSID;
        string authentication;
        string passPhrase;
        string wifiInterface;
        object state;
        var ClientHandle = IntPtr.Zero;
        uint NegotiatedVersion = 0;
        var ret = WlanOpenHandle(2, IntPtr.Zero, out NegotiatedVersion, out ClientHandle);
        if (ret == Interop.O_3BB7B919.Success)
        {
            var InterfaceListPtr = IntPtr.Zero;
            var retWlanEnum = WlanEnumInterfaces(ClientHandle, IntPtr.Zero, ref InterfaceListPtr);
            if (retWlanEnum == Interop.O_3BB7B919.Success)
            {
                numberOfInterfaces = Marshal.ReadInt32(InterfaceListPtr);
                var WlanInterfaceInfoPtr = (IntPtr)(InterfaceListPtr.ToInt64() + 8);
                for (int i = 0; i < numberOfInterfaces; i++)
                {
                    WLAN_INTERFACE_INFO WlanInterfaceInfo = (WLAN_INTERFACE_INFO)Marshal.PtrToStructure(WlanInterfaceInfoPtr, typeof(WLAN_INTERFACE_INFO));
                    wifiInterface = WlanInterfaceInfo.strInterfaceDescription;
                    state = (StateEnum)WlanInterfaceInfo.isState;
                    IntPtr ProfileListPtr = IntPtr.Zero;
                    var retGetProfileList = WlanGetProfileList(ClientHandle, WlanInterfaceInfo.InterfaceGuid, IntPtr.Zero, out ProfileListPtr);
                    if (retGetProfileList == Interop.O_3BB7B919.Success)
                    {
                        int currentNbrOfProfiles = Marshal.ReadInt32(ProfileListPtr);
                        numberOfProfiles += currentNbrOfProfiles;
                        var WlanProfileInfoPtr = (IntPtr)(ProfileListPtr.ToInt64() + 8);
                        for (int j = 0; j < currentNbrOfProfiles; j++)
                        {
                            WLAN_PROFILE_INFO WlanProfileInfo = (WLAN_PROFILE_INFO)Marshal.PtrToStructure(WlanProfileInfoPtr, typeof(WLAN_PROFILE_INFO));
                            string ProfileXml = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CnnZ9MnunY4=")[iii % 8])).ToArray());
                            UInt32 WlanProfileFlags = 4;
                            UInt32 WlanProfileAccessFlags = 0;
                            var retGetProfile = WlanGetProfile(ClientHandle, WlanInterfaceInfo.InterfaceGuid, WlanProfileInfo.strProfileName, IntPtr.Zero, out ProfileXml, ref WlanProfileFlags, out WlanProfileAccessFlags);
                            if (retGetProfile == Interop.O_3BB7B919.Success)
                            {
                                var xmlDoc = new XmlDocument();
                                xmlDoc.LoadXml(ProfileXml);
                                XmlNamespaceManager mgr = new XmlNamespaceManager(xmlDoc.NameTable);
                                mgr.AddNamespace(Encoding.UTF8.GetString(Convert.FromBase64String("jNk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4qrFF+wAaSY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("lztQRoYhl+qIOApb1W3K8owgQkKSbdfw0CFBQsthyvaWIUMZ60L509A/VlnaZ9T40DkV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/08kNrwOuJ0=")[iii % 8])).ToArray()));
                                profile = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QMKA3/eMw4g=")[iii % 8])).ToArray());
                                sSID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2FdqYD5YH3U=")[iii % 8])).ToArray());
                                authentication = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LL6vl2IBQto=")[iii % 8])).ToArray());
                                passPhrase = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7frUDtYdpAU=")[iii % 8])).ToArray());
                                try
                                {
                                    profile = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("2kG792chJ6u7PqfrOx8Hj9oApr4zFwaP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9W7VhF12a+o=")[iii % 8])).ToArray()), mgr).InnerText;
                                    sSID = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("4eX93ZKmaW2AmuHBzphJSeGk4JT7omxojaX9yMGWCkK98MD94bUKQr3w/c/FlA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zsqTrqjxJSw=")[iii % 8])).ToArray()), mgr).InnerText;
                                    passPhrase = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("idtngfviWB3opHudp9x4OYmaesiM5llzyIczgaTWYS7PgHDdr8YuL86Ve5el/nEliZp6yKrQbRHHgGyAqNR4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pvQJ8sG1FFw=")[iii % 8])).ToArray()), mgr).InnerText;
                                    authentication = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("PSgYwUFK/ydcVwTdHXTfAz1pBYg2Tv5JfHRMwR5+xhR7cw+dFW6JB2dzHvcVfsEfYnMf3RUy3RUoZgPGE3jdEntkF8YSct0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Egd2snsds2Y=")[iii % 8])).ToArray()), mgr).InnerText;
                                }
                                catch
                                {
                                }

                                O_CA3CF3AC CurrentWifiProfileEntry = new O_CA3CF3AC
{
    Profile = profile,
    SSID = sSID,
    Authentication = authentication,
    PassPhrase = passPhrase,
    Interface = wifiInterface,
    State = state.ToString()
};
                                wifiProfileEntries.Add(CurrentWifiProfileEntry);
                            }
                            else
                            {
                                WriteError($"WlanGetProfile() failed: {retGetProfile}");
                            }

                            WlanProfileInfoPtr = (IntPtr)(WlanProfileInfoPtr.ToInt64() + Marshal.SizeOf(WlanProfileInfo));
                        }

                        WlanFreeMemory(ProfileListPtr);
                    }
                    else
                    {
                        WriteError($"WlanGetProfileList() failed: {retGetProfileList}");
                    }

                    WlanInterfaceInfoPtr = (IntPtr)(WlanInterfaceInfoPtr.ToInt64() + Marshal.SizeOf(WlanInterfaceInfo));
                }

                WlanFreeMemory(InterfaceListPtr);
            }
            else
            {
                WriteError($"WlanEnumInterfaces() failed: {retWlanEnum}");
                yield break;
            }

            var retClose = WlanCloseHandle(ClientHandle, IntPtr.Zero);
            if (ret != Interop.O_3BB7B919.Success)
            {
                WriteError($"WlanCloseHandle() failed: {retClose}");
            }
        }
        else
        {
            WriteError($"WlanOpenHandle() failed: {ret}");
            yield break;
        }

        yield return new O_97D40AC0(numberOfInterfaces, numberOfProfiles, wifiProfileEntries);
    }

internal class O_97D40AC0 : O_4AED570F
{
    public O_97D40AC0(int nbrInterface, int nbrProfile, List<O_CA3CF3AC> wifiProfileEntries)
    {
        NumberOfInterfaces = nbrInterface;
        NumberOfProfiles = nbrProfile;
        WifiProfileEntries = wifiProfileEntries;
    }

    public int NumberOfInterfaces { get; set; }
    public int NumberOfProfiles { get; set; }
    public List<O_CA3CF3AC> WifiProfileEntries { get; set; }
}    [CommandOutputType(typeof(O_97D40AC0))]
    internal class O_80287F36 : TextFormatterBase
    {
        public O_80287F36(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_97D40AC0)result;
            WriteLine($"Number of interfaces : {dto.NumberOfInterfaces}");
            WriteLine($"Number of profiles   : {dto.NumberOfProfiles}\n");
            foreach (O_CA3CF3AC entry in dto.WifiProfileEntries)
            {
                WriteLine($"Profile        : {entry.Profile}");
                WriteLine($"SSID           : {entry.SSID}");
                WriteLine($"Interface      : {entry.Interface}");
                WriteLine($"State          : {entry.State}");
                WriteLine($"Authentication : {entry.Authentication}");
                WriteLine($"PassPrhase     : {entry.PassPhrase}\n");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string fhbYaCxq)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(76);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_97D40AC0)result;
            WriteLine($"Number of interfaces : {dto.NumberOfInterfaces}");
            WriteLine($"Number of profiles   : {dto.NumberOfProfiles}\n");
            foreach (O_CA3CF3AC entry in dto.WifiProfileEntries)
            {
                WriteLine($"Profile        : {entry.Profile}");
                WriteLine($"SSID           : {entry.SSID}");
                WriteLine($"Interface      : {entry.Interface}");
                WriteLine($"State          : {entry.State}");
                WriteLine($"Authentication : {entry.Authentication}");
                WriteLine($"PassPrhase     : {entry.PassPhrase}\n");
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string nCWfiwXa)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                    instance.SubstringByTextElements(76);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        int numberOfInterfaces = 0;
        int numberOfProfiles = 0;
        List<O_CA3CF3AC> wifiProfileEntries = new List<O_CA3CF3AC>();
        string profile;
        string sSID;
        string authentication;
        string passPhrase;
        string wifiInterface;
        object state;
        var ClientHandle = IntPtr.Zero;
        uint NegotiatedVersion = 0;
        var ret = WlanOpenHandle(2, IntPtr.Zero, out NegotiatedVersion, out ClientHandle);
        if (ret == Interop.O_3BB7B919.Success)
        {
            var InterfaceListPtr = IntPtr.Zero;
            var retWlanEnum = WlanEnumInterfaces(ClientHandle, IntPtr.Zero, ref InterfaceListPtr);
            if (retWlanEnum == Interop.O_3BB7B919.Success)
            {
                numberOfInterfaces = Marshal.ReadInt32(InterfaceListPtr);
                var WlanInterfaceInfoPtr = (IntPtr)(InterfaceListPtr.ToInt64() + 8);
                for (int i = 0; i < numberOfInterfaces; i++)
                {
                    WLAN_INTERFACE_INFO WlanInterfaceInfo = (WLAN_INTERFACE_INFO)Marshal.PtrToStructure(WlanInterfaceInfoPtr, typeof(WLAN_INTERFACE_INFO));
                    wifiInterface = WlanInterfaceInfo.strInterfaceDescription;
                    state = (StateEnum)WlanInterfaceInfo.isState;
                    IntPtr ProfileListPtr = IntPtr.Zero;
                    var retGetProfileList = WlanGetProfileList(ClientHandle, WlanInterfaceInfo.InterfaceGuid, IntPtr.Zero, out ProfileListPtr);
                    if (retGetProfileList == Interop.O_3BB7B919.Success)
                    {
                        int currentNbrOfProfiles = Marshal.ReadInt32(ProfileListPtr);
                        numberOfProfiles += currentNbrOfProfiles;
                        var WlanProfileInfoPtr = (IntPtr)(ProfileListPtr.ToInt64() + 8);
                        for (int j = 0; j < currentNbrOfProfiles; j++)
                        {
                            WLAN_PROFILE_INFO WlanProfileInfo = (WLAN_PROFILE_INFO)Marshal.PtrToStructure(WlanProfileInfoPtr, typeof(WLAN_PROFILE_INFO));
                            string ProfileXml = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CnnZ9MnunY4=")[iii % 8])).ToArray());
                            UInt32 WlanProfileFlags = 4;
                            UInt32 WlanProfileAccessFlags = 0;
                            var retGetProfile = WlanGetProfile(ClientHandle, WlanInterfaceInfo.InterfaceGuid, WlanProfileInfo.strProfileName, IntPtr.Zero, out ProfileXml, ref WlanProfileFlags, out WlanProfileAccessFlags);
                            if (retGetProfile == Interop.O_3BB7B919.Success)
                            {
                                var xmlDoc = new XmlDocument();
                                xmlDoc.LoadXml(ProfileXml);
                                XmlNamespaceManager mgr = new XmlNamespaceManager(xmlDoc.NameTable);
                                mgr.AddNamespace(Encoding.UTF8.GetString(Convert.FromBase64String("jNk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4qrFF+wAaSY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("lztQRoYhl+qIOApb1W3K8owgQkKSbdfw0CFBQsthyvaWIUMZ60L509A/VlnaZ9T40DkV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/08kNrwOuJ0=")[iii % 8])).ToArray()));
                                profile = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QMKA3/eMw4g=")[iii % 8])).ToArray());
                                sSID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2FdqYD5YH3U=")[iii % 8])).ToArray());
                                authentication = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LL6vl2IBQto=")[iii % 8])).ToArray());
                                passPhrase = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7frUDtYdpAU=")[iii % 8])).ToArray());
                                try
                                {
                                    profile = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("2kG792chJ6u7PqfrOx8Hj9oApr4zFwaP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9W7VhF12a+o=")[iii % 8])).ToArray()), mgr).InnerText;
                                    sSID = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("4eX93ZKmaW2AmuHBzphJSeGk4JT7omxojaX9yMGWCkK98MD94bUKQr3w/c/FlA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zsqTrqjxJSw=")[iii % 8])).ToArray()), mgr).InnerText;
                                    passPhrase = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("idtngfviWB3opHudp9x4OYmaesiM5llzyIczgaTWYS7PgHDdr8YuL86Ve5el/nEliZp6yKrQbRHHgGyAqNR4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pvQJ8sG1FFw=")[iii % 8])).ToArray()), mgr).InnerText;
                                    authentication = xmlDoc.SelectSingleNode(Encoding.UTF8.GetString(Convert.FromBase64String("PSgYwUFK/ydcVwTdHXTfAz1pBYg2Tv5JfHRMwR5+xhR7cw+dFW6JB2dzHvcVfsEfYnMf3RUy3RUoZgPGE3jdEntkF8YSct0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Egd2snsds2Y=")[iii % 8])).ToArray()), mgr).InnerText;
                                }
                                catch
                                {
                                }

                                O_CA3CF3AC CurrentWifiProfileEntry = new O_CA3CF3AC
                                {
                                    Profile = profile,
                                    SSID = sSID,
                                    Authentication = authentication,
                                    PassPhrase = passPhrase,
                                    Interface = wifiInterface,
                                    State = state.ToString()
                                };
                                wifiProfileEntries.Add(CurrentWifiProfileEntry);
                            }
                            else
                            {
                                WriteError($"WlanGetProfile() failed: {retGetProfile}");
                            }

                            WlanProfileInfoPtr = (IntPtr)(WlanProfileInfoPtr.ToInt64() + Marshal.SizeOf(WlanProfileInfo));
                        }

                        WlanFreeMemory(ProfileListPtr);
                    }
                    else
                    {
                        WriteError($"WlanGetProfileList() failed: {retGetProfileList}");
                    }

                    WlanInterfaceInfoPtr = (IntPtr)(WlanInterfaceInfoPtr.ToInt64() + Marshal.SizeOf(WlanInterfaceInfo));
                }

                WlanFreeMemory(InterfaceListPtr);
            }
            else
            {
                WriteError($"WlanEnumInterfaces() failed: {retWlanEnum}");
                yield break;
            }

            var retClose = WlanCloseHandle(ClientHandle, IntPtr.Zero);
            if (ret != Interop.O_3BB7B919.Success)
            {
                WriteError($"WlanCloseHandle() failed: {retClose}");
            }
        }
        else
        {
            WriteError($"WlanOpenHandle() failed: {ret}");
            yield break;
        }

        yield return new O_97D40AC0(numberOfInterfaces, numberOfProfiles, wifiProfileEntries);
    }
}}