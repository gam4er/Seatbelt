#nullable disable
using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_B25CFBD2 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("zG0NB2oeV/LrVyY5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gjlBSjl7I4Y=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("UKYvQpx2gQF2lw171XSVAXedDS/PcoABd5wEfA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HvJjD7wX9HU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_B25CFBD2(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        yield return new O_9035B3A6()
        {
            LanmanCompatibilityLevel = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ATxlSMWDTx4nN2RZzppQMjwxZFPMvXYpDgZ5UtScfDEOCWVd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UkUWPKDuE10=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Sx0R1PcXRBZuEjvX8xNcLmIGN9c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B3BSu5pnJWI=")[iii % 8])).ToArray())),
            ClientRequireSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("VeUKb7w+b2Vz7gt+tydwSWjoC3S1AFZSWs8caa86UEN1wDV6tz5SSFHzC3CqJ1JSb/MXR4kyQUdr+Q1+qyA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bpx5G9lTMyY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("H/BKykX5ct4o9k7NRf9u3iTyVd5Y/mXo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZU7vyyLF40=")[iii % 8])).ToArray())) == 1,
            ClientNegotiateSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("/eUvALD3oqXb7i4Ru+69icDoLhu5yZuS8s85BqPznYPdwBAVu/efiPnzLh+m7p+Sx/MyKIX7jIfD+SgRp+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rpxcdNWa/uY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1X6FfAB9Tq/zZZZ3GGFOo/d+hWoZang=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kBDkHmwYHco=")[iii % 8])).ToArray())) == 1,
            ServerRequireSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xHovpivtyE/icS63IPTXY/l3Lr0i0/F4y1A5oDjp92nkXxCzIM31YsRmLqQr8shc9nE9vyv08X7k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lwNc0k6AlAw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("NWcTeK9l2aYCYRd/r2PFpg5lDGyyYs6Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZwJiDcYXvPU=")[iii % 8])).ToArray())) == 1,
            ServerNegotiateSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ArOMNKSAy6ckuI0lr5nUiz++jS+tvvKQDZmaMreE9IEilrMhr6D2igKvjTakn8u0MLieLaSZ8pYi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ucr/QMHtl+Q=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VB8i1XGz5nxyBDHeaa/mcHYfIsNopNA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EXFDtx3WtRk=")[iii % 8])).ToArray())) == 1,
            LdapSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("zFZJi6j19bXqXUiao+zqmfFbSJChy8yCw3xfjbvxypPsc3a7jMg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ny86/82YqfY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("w/TmG+k8KV7hxO4l3jUnSebE3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j7CnS6pQQDs=")[iii % 8])).ToArray())),
            NTLMMinClientSec = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("XbP+r/UOUYp7mN+e3jdOpmCe35TcEGi9UqnClcQxYqVSpt6a7A5enz+1nQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Duqt+7BDDck=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gm/jJXW4tpagcuomTIK9tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zBuPSDjR2NU=")[iii % 8])).ToArray())),
            NTLMMinServerSec = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("gu1tvj4G3xekxkyPFT/AO7/ATIUXGOYgjfdRhA857DiN+E2LJwbQAuDrDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0bQ+6ntLg1Q=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("nQHsDfADjKK2B/YFzzmHkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("03WAYL1q4vE=")[iii % 8])).ToArray())),
            InboundRestrictions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("i+E2AkKk4Kyt6jcTSb3/gLbsNxlLmtmbhNsqGFO704OE1DYXe4TvuenHdQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2JhFdifJvO8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("dagvzpoOqLN1qD/fgRGiqUCDCPalM7mmQas12Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J81cuuhny8c=")[iii % 8])).ToArray())),
            OutboundRestrictions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("6SpJCIsfHe/PIUgZgAYCw9QnSBOCISTY5hBVEpoALsDmH0kdsj8S+osMCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ulM6fO5yQaw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Bjvg4owfqtQHO/3ylxiu7gAS3sKMF6/GPT0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VF6Tlv52yaA=")[iii % 8])).ToArray())),
            InboundAuditing = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("FzSr/vZrbTUxP6rv/XJyGSo5quX/VVQCGA635Od0XhoYAavrz0tiIHUS6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RE3YipMGMXY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("id1jx1e2PoCtwXHHTYMVt4TlU9xCgj2Kqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yKgHriPkW+M=")[iii % 8])).ToArray())),
            OutboundExceptions = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("CRzkAsRte/AvF+UTz3Rk3DQR5RnNU0LHBib4GNVySN8GKeQX/U105Ws6pw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WmWXdqEAJ7M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ieuT1GxQ+5ym6I3UZmruvIfUn8N0QciD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yof6sQIkuvA=")[iii % 8])).ToArray())),
        };
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string cIfXTqjL)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                    instance.AddMonths(new System.DateTime(), 54);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        yield return new O_9035B3A6()
        {
            LanmanCompatibilityLevel = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ATxlSMWDTx4nN2RZzppQMjwxZFPMvXYpDgZ5UtScfDEOCWVd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UkUWPKDuE10=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Sx0R1PcXRBZuEjvX8xNcLmIGN9c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B3BSu5pnJWI=")[iii % 8])).ToArray())),
            ClientRequireSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("VeUKb7w+b2Vz7gt+tydwSWjoC3S1AFZSWs8caa86UEN1wDV6tz5SSFHzC3CqJ1JSb/MXR4kyQUdr+Q1+qyA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bpx5G9lTMyY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("H/BKykX5ct4o9k7NRf9u3iTyVd5Y/mXo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZU7vyyLF40=")[iii % 8])).ToArray())) == 1,
            ClientNegotiateSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("/eUvALD3oqXb7i4Ru+69icDoLhu5yZuS8s85BqPznYPdwBAVu/efiPnzLh+m7p+Sx/MyKIX7jIfD+SgRp+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rpxcdNWa/uY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1X6FfAB9Tq/zZZZ3GGFOo/d+hWoZang=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kBDkHmwYHco=")[iii % 8])).ToArray())) == 1,
            ServerRequireSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("xHovpivtyE/icS63IPTXY/l3Lr0i0/F4y1A5oDjp92nkXxCzIM31YsRmLqQr8shc9nE9vyv08X7k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lwNc0k6AlAw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("NWcTeK9l2aYCYRd/r2PFpg5lDGyyYs6Q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZwJiDcYXvPU=")[iii % 8])).ToArray())) == 1,
            ServerNegotiateSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("ArOMNKSAy6ckuI0lr5nUiz++jS+tvvKQDZmaMreE9IEilrMhr6D2igKvjTakn8u0MLieLaSZ8pYi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ucr/QMHtl+Q=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VB8i1XGz5nxyBDHeaa/mcHYfIsNopNA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EXFDtx3WtRk=")[iii % 8])).ToArray())) == 1,
            LdapSigning = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("zFZJi6j19bXqXUiao+zqmfFbSJChy8yCw3xfjbvxypPsc3a7jMg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ny86/82YqfY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("w/TmG+k8KV7hxO4l3jUnSebE3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j7CnS6pQQDs=")[iii % 8])).ToArray())),
            NTLMMinClientSec = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("XbP+r/UOUYp7mN+e3jdOpmCe35TcEGi9UqnClcQxYqVSpt6a7A5enz+1nQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Duqt+7BDDck=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gm/jJXW4tpagcuomTIK9tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zBuPSDjR2NU=")[iii % 8])).ToArray())),
            NTLMMinServerSec = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("gu1tvj4G3xekxkyPFT/AO7/ATIUXGOYgjfdRhA857DiN+E2LJwbQAuDrDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0bQ+6ntLg1Q=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("nQHsDfADjKK2B/YFzzmHkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("03WAYL1q4vE=")[iii % 8])).ToArray())),
            InboundRestrictions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("i+E2AkKk4Kyt6jcTSb3/gLbsNxlLmtmbhNsqGFO704OE1DYXe4TvuenHdQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2JhFdifJvO8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("dagvzpoOqLN1qD/fgRGiqUCDCPalM7mmQas12Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J81cuuhny8c=")[iii % 8])).ToArray())),
            OutboundRestrictions = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("6SpJCIsfHe/PIUgZgAYCw9QnSBOCISTY5hBVEpoALsDmH0kdsj8S+osMCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ulM6fO5yQaw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Bjvg4owfqtQHO/3ylxiu7gAS3sKMF6/GPT0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VF6Tlv52yaA=")[iii % 8])).ToArray())),
            InboundAuditing = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("FzSr/vZrbTUxP6rv/XJyGSo5quX/VVQCGA635Od0XhoYAavrz0tiIHUS6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RE3YipMGMXY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("id1jx1e2PoCtwXHHTYMVt4TlU9xCgj2Kqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yKgHriPkW+M=")[iii % 8])).ToArray())),
            OutboundExceptions = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("CRzkAsRte/AvF+UTz3Rk3DQR5RnNU0LHBib4GNVySN8GKeQX/U105Ws6pw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WmWXdqEAJ7M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ieuT1GxQ+5ym6I3UZmruvIfUn8N0QciD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yof6sQIkuvA=")[iii % 8])).ToArray())),
        };
    }
}
    [Flags]
    enum SessionSecurity : uint
    {
        None = 0x00000000,
        Integrity = 0x00000010,
        Confidentiality = 0x00000020,
        NTLMv2 = 0x00080000,
        Require128BitKey = 0x20000000,
        Require56BitKey = 0x80000000
    }
internal class O_9035B3A6 : O_4AED570F
{
    public uint? LanmanCompatibilityLevel { get; set; }
    public bool ClientRequireSigning { get; set; }
    public bool ClientNegotiateSigning { get; set; }
    public bool ServerRequireSigning { get; set; }
    public bool ServerNegotiateSigning { get; set; }
    public uint? LdapSigning { get; set; }
    public uint? NTLMMinClientSec { get; set; }
    public uint? NTLMMinServerSec { get; set; }
    public uint? InboundRestrictions { get; internal set; }
    public uint? OutboundRestrictions { get; internal set; }
    public uint? InboundAuditing { get; internal set; }
    public string OutboundExceptions { get; internal set; }
}
    [CommandOutputType(typeof(O_9035B3A6))]
    internal class O_0AB80752 : TextFormatterBase
    {
        public O_0AB80752(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_9035B3A6)result;
            string lmStr = null;
            switch (dto.LanmanCompatibilityLevel)
            {
                case 0:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("fRdShUFwclsIUnK1LXEfCUsBTI4PT1oI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LnI84WE8P3s=")[iii % 8])).ToArray());
                    break;
                case 1:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("IVPmOK9zc5dUFsYIw3IemlJj+zmvcWr7P0C6fPxaTcQbWeZ8/FpdwgBf/CWvVliXHFPvM/tWX8MXUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjaIXI8/Prc=")[iii % 8])).ToArray());
                    break;
                case 2:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("QlcHOL8Xi3RcEhs57CmwVmJXSTPxNaY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ETJpXJ9Z3zg=")[iii % 8])).ToArray());
                    break;
                case null:
                case 3:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("HrPAmos8GP8AoJze2Rc/wyK43ZuLHSLfNPaD3vwbIoRm9sqbzRM53zk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tdau/qtyTLM=")[iii % 8])).ToArray());
                    break;
                case 4:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("TWXSEVgMGfpTdo5VCic+xnFuzxBYLSPaZy6cMTt4beR7ZskGHWIB+w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HgC8dXhCTbY=")[iii % 8])).ToArray());
                    break;
                case 5:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("wHR8xlz2El3eZyCCDt01Yfx/Ycdc1yh96j8y5j+CZkP2d2fRGZgKXLM3Muwo9As=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kxESony4RhE=")[iii % 8])).ToArray());
                    break;
                default:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("+vTt/uq/gw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r5qGkIXI7SM=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JP6/Cfxro1tHsZ4Y83KrV22ymhzrSqdDYbLTSLIm+BV/7o5A6Te/HA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BN7zaJIGwjU=")[iii % 8])).ToArray()), dto.LanmanCompatibilityLevel, lmStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CHpkuSUq3z1RMyOZGAj1PVE/MIMYCPVu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AlpE93Fmkh0=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mIMRvSDTZuLRxl/pUpZU+9HRVM5plEvn1sQRvSDTH67Dk0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uKMxnQDzJY4=")[iii % 8])).ToArray()), dto.ClientRequireSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qpETQJLfW9rj1F0U/Jp/2f7YUhTXrHHR5NhdB5LfIpbxgU4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("irEzYLL/GLY=")[iii % 8])).ToArray()), dto.ClientNegotiateSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("g0raDKlyEBnRHJ9e2zcyCcoYn3/gNS0VzQ3aDKlyeVzYWoc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o2r6LIlSQ3w=")[iii % 8])).ToArray()), dto.ServerRequireSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kfDq3Se4adzDpq+PSf1d1sW5q4liy1Pe37mkmie4AJnK4Lc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sdDK/QeYOrk=")[iii % 8])).ToArray()), dto.ServerNegotiateSigning);
            string ldapSigningStr;
            switch (dto.LdapSigning)
            {
                case 0:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("D4Wfbbe8vMkvjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qeq/Ht7b0qA=")[iii % 8])).ToArray());
                    break;
                case 1:
                case null:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("MYHb73wjPJ0axM/pbyQ0hxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f+S8gAhKXek=")[iii % 8])).ToArray());
                    break;
                case 2:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("wWz4H4yNcEDAYO4EjJFy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kwmJauX/FWA=")[iii % 8])).ToArray());
                    break;
                default:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("UFRX042L5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTo8veL8iZA=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4lqB1AiGGSqjCvKdT8g8IKVagdQIhnVu4lqB1AiGb265StzUAN1kM+s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wnqh9CimVU4=")[iii % 8])).ToArray()), dto.LdapSigning, ldapSigningStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("50zlfOjIQseCAuV86NhE3IQYvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WzFL427Ma4=")[iii % 8])).ToArray()));
            if (dto.NTLMMinClientSec != null)
            {
                var clientSessionSecurity = (SessionSecurity)dto.NTLMMinClientSec;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kupfN8mGte/+hzJ+h+WX0tekC0SMxdubkupfN8mGwZvJ+gI3wd3Kxps=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ssp/F+mm+7s=")[iii % 8])).ToArray()), dto.NTLMMinClientSec, clientSessionSecurity);
                if (dto.LanmanCompatibilityLevel < 3 && !clientSessionSecurity.HasFlag(SessionSecurity.NTLMv2))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("lc9Y7XcQCELuziXtGWRkL5WMFKQyXlwRlZwNvSdfWhaVoSyBGkYZQw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("te94zVcwKGI=")[iii % 8])).ToArray()));
                }
            }

            if (dto.NTLMMinServerSec != null)
            {
                var serverSessionSecurity = (SessionSecurity)dto.NTLMMinServerSec;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WRcfFpCG4JE1enJf3vXLtw9STWXVxY7lWRcfFpCGlOUCB0IWmN2fuFA9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eTc/NrCmrsU=")[iii % 8])).ToArray()), dto.NTLMMinServerSec, serverSessionSecurity);
                if (dto.LanmanCompatibilityLevel < 3 && !serverSessionSecurity.HasFlag(SessionSecurity.NTLMv2))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("cY/AggJsiMMKjr2CbBjkrnHchdBUJcuGIo+PzAI4wIoij43DQSTBjTSPk9dSPMeRJY+u9m4B3tJw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ua/goiJMqOM=")[iii % 8])).ToArray()));
                }
            }

            string inboundRestrictStr;
            switch (dto.InboundRestrictions)
            {
                case 0:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("DeOO1xgdTMUg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TI/iuG89Lak=")[iii % 8])).ToArray());
                    break;
                case 1:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("DAQa3gOv93NoBRvKQqf1PykCF8hWoO9s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SGF0pyPOmx8=")[iii % 8])).ToArray());
                    break;
                case 2:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("XcS+5si95ps5wLP8h6nkg2o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GaHQn+jcivc=")[iii % 8])).ToArray());
                    break;
                default:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("+Bm0U+8VCDjYE6Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tnbAc4twblE=")[iii % 8])).ToArray());
                    break;
            }

            string outboundRestrictStr;
            switch (dto.OutboundRestrictions)
            {
                case 0:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("K8HMgOFEOKIG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aq2g75ZkWc4=")[iii % 8])).ToArray());
                    break;
                case 1:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("7Me1ZKqiX0fB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rbLRDd6CPis=")[iii % 8])).ToArray());
                    break;
                case 2:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("NJERaF4HxKM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cPR/EX5mqM8=")[iii % 8])).ToArray());
                    break;
                default:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("fRbByhKbLz9dHNE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M3m16nb+SVY=")[iii % 8])).ToArray());
                    break;
            }

            string inboundAuditStr;
            switch (dto.InboundAuditing)
            {
                case 0:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("nA5kjOK6gA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2GcX7YDW5VI=")[iii % 8])).ToArray());
                    break;
                case 1:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("tR+FFtxTwsSFFY0A2ViFhZYellTUWY/EmR/EFdNVjdCeBZc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8HHkdLA24qU=")[iii % 8])).ToArray());
                    break;
                case 2:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("Ptb7Egq5UlQO3PMED7IVFR3X6FAHsB4VGtv5HxOyBkY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e7iacGbccjU=")[iii % 8])).ToArray());
                    break;
                default:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("NxevU6w7GBEXHb8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eXjbc8hefng=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("N6l++0fyDll8/DrcZ9ctHh3oMNEz7CYKSfs31mfXLBdO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PYletRO+Q3k=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OVlfQrzqkSJ7FgoM+Ji9P20LFgHoo7ciallfQrzq4mxiSQJK5/ulZQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GXl/YpzK2Ew=")[iii % 8])).ToArray()), dto.InboundRestrictions, inboundRestrictStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gcrw8tONR9XViL+nnclaxdKeoruQ2WHPz5nw8tONMoDa2q36iJx1iQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oerQ0vOtCKA=")[iii % 8])).ToArray()), dto.OutboundRestrictions, outboundRestrictStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OaJDSk3ckoV77RYECb2uj3D2CgQK3PvLOaJDSk3c4ctish5CFs2mwg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GYJjam382+s=")[iii % 8])).ToArray()), dto.InboundAuditing, inboundAuditStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ue1no+vRtFPtryj2pZW+XvqoN/einpVVue1no+vRwQbi/To=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mc1Hg8vx+yY=")[iii % 8])).ToArray()), dto.OutboundExceptions);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string PPCjxgGQ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HebrewCalendar instance = new System.Globalization.HebrewCalendar();
                        instance.AddMonths(new System.DateTime(), 54);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_9035B3A6)result;
            string lmStr = null;
            switch (dto.LanmanCompatibilityLevel)
            {
                case 0:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("fRdShUFwclsIUnK1LXEfCUsBTI4PT1oI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LnI84WE8P3s=")[iii % 8])).ToArray());
                    break;
                case 1:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("IVPmOK9zc5dUFsYIw3IemlJj+zmvcWr7P0C6fPxaTcQbWeZ8/FpdwgBf/CWvVliXHFPvM/tWX8MXUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjaIXI8/Prc=")[iii % 8])).ToArray());
                    break;
                case 2:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("QlcHOL8Xi3RcEhs57CmwVmJXSTPxNaY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ETJpXJ9Z3zg=")[iii % 8])).ToArray());
                    break;
                case null:
                case 3:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("HrPAmos8GP8AoJze2Rc/wyK43ZuLHSLfNPaD3vwbIoRm9sqbzRM53zk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tdau/qtyTLM=")[iii % 8])).ToArray());
                    break;
                case 4:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("TWXSEVgMGfpTdo5VCic+xnFuzxBYLSPaZy6cMTt4beR7ZskGHWIB+w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HgC8dXhCTbY=")[iii % 8])).ToArray());
                    break;
                case 5:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("wHR8xlz2El3eZyCCDt01Yfx/Ycdc1yh96j8y5j+CZkP2d2fRGZgKXLM3Muwo9As=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kxESony4RhE=")[iii % 8])).ToArray());
                    break;
                default:
                    lmStr = Encoding.UTF8.GetString(Convert.FromBase64String("+vTt/uq/gw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r5qGkIXI7SM=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JP6/Cfxro1tHsZ4Y83KrV22ymhzrSqdDYbLTSLIm+BV/7o5A6Te/HA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BN7zaJIGwjU=")[iii % 8])).ToArray()), dto.LanmanCompatibilityLevel, lmStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CHpkuSUq3z1RMyOZGAj1PVE/MIMYCPVu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AlpE93Fmkh0=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mIMRvSDTZuLRxl/pUpZU+9HRVM5plEvn1sQRvSDTH67Dk0w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uKMxnQDzJY4=")[iii % 8])).ToArray()), dto.ClientRequireSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qpETQJLfW9rj1F0U/Jp/2f7YUhTXrHHR5NhdB5LfIpbxgU4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("irEzYLL/GLY=")[iii % 8])).ToArray()), dto.ClientNegotiateSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("g0raDKlyEBnRHJ9e2zcyCcoYn3/gNS0VzQ3aDKlyeVzYWoc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o2r6LIlSQ3w=")[iii % 8])).ToArray()), dto.ServerRequireSigning);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kfDq3Se4adzDpq+PSf1d1sW5q4liy1Pe37mkmie4AJnK4Lc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sdDK/QeYOrk=")[iii % 8])).ToArray()), dto.ServerNegotiateSigning);
            string ldapSigningStr;
            switch (dto.LdapSigning)
            {
                case 0:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("D4Wfbbe8vMkvjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qeq/Ht7b0qA=")[iii % 8])).ToArray());
                    break;
                case 1:
                case null:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("MYHb73wjPJ0axM/pbyQ0hxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f+S8gAhKXek=")[iii % 8])).ToArray());
                    break;
                case 2:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("wWz4H4yNcEDAYO4EjJFy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kwmJauX/FWA=")[iii % 8])).ToArray());
                    break;
                default:
                    ldapSigningStr = Encoding.UTF8.GetString(Convert.FromBase64String("UFRX042L5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTo8veL8iZA=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4lqB1AiGGSqjCvKdT8g8IKVagdQIhnVu4lqB1AiGb265StzUAN1kM+s=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wnqh9CimVU4=")[iii % 8])).ToArray()), dto.LdapSigning, ldapSigningStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("50zlfOjIQseCAuV86NhE3IQYvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WzFL427Ma4=")[iii % 8])).ToArray()));
            if (dto.NTLMMinClientSec != null)
            {
                var clientSessionSecurity = (SessionSecurity)dto.NTLMMinClientSec;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("kupfN8mGte/+hzJ+h+WX0tekC0SMxdubkupfN8mGwZvJ+gI3wd3Kxps=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ssp/F+mm+7s=")[iii % 8])).ToArray()), dto.NTLMMinClientSec, clientSessionSecurity);
                if (dto.LanmanCompatibilityLevel < 3 && !clientSessionSecurity.HasFlag(SessionSecurity.NTLMv2))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("lc9Y7XcQCELuziXtGWRkL5WMFKQyXlwRlZwNvSdfWhaVoSyBGkYZQw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("te94zVcwKGI=")[iii % 8])).ToArray()));
                }
            }

            if (dto.NTLMMinServerSec != null)
            {
                var serverSessionSecurity = (SessionSecurity)dto.NTLMMinServerSec;
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("WRcfFpCG4JE1enJf3vXLtw9STWXVxY7lWRcfFpCGlOUCB0IWmN2fuFA9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eTc/NrCmrsU=")[iii % 8])).ToArray()), dto.NTLMMinServerSec, serverSessionSecurity);
                if (dto.LanmanCompatibilityLevel < 3 && !serverSessionSecurity.HasFlag(SessionSecurity.NTLMv2))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("cY/AggJsiMMKjr2CbBjkrnHchdBUJcuGIo+PzAI4wIoij43DQSTBjTSPk9dSPMeRJY+u9m4B3tJw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ua/goiJMqOM=")[iii % 8])).ToArray()));
                }
            }

            string inboundRestrictStr;
            switch (dto.InboundRestrictions)
            {
                case 0:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("DeOO1xgdTMUg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TI/iuG89Lak=")[iii % 8])).ToArray());
                    break;
                case 1:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("DAQa3gOv93NoBRvKQqf1PykCF8hWoO9s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SGF0pyPOmx8=")[iii % 8])).ToArray());
                    break;
                case 2:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("XcS+5si95ps5wLP8h6nkg2o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GaHQn+jcivc=")[iii % 8])).ToArray());
                    break;
                default:
                    inboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("+Bm0U+8VCDjYE6Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tnbAc4twblE=")[iii % 8])).ToArray());
                    break;
            }

            string outboundRestrictStr;
            switch (dto.OutboundRestrictions)
            {
                case 0:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("K8HMgOFEOKIG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aq2g75ZkWc4=")[iii % 8])).ToArray());
                    break;
                case 1:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("7Me1ZKqiX0fB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rbLRDd6CPis=")[iii % 8])).ToArray());
                    break;
                case 2:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("NJERaF4HxKM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cPR/EX5mqM8=")[iii % 8])).ToArray());
                    break;
                default:
                    outboundRestrictStr = Encoding.UTF8.GetString(Convert.FromBase64String("fRbByhKbLz9dHNE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M3m16nb+SVY=")[iii % 8])).ToArray());
                    break;
            }

            string inboundAuditStr;
            switch (dto.InboundAuditing)
            {
                case 0:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("nA5kjOK6gA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2GcX7YDW5VI=")[iii % 8])).ToArray());
                    break;
                case 1:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("tR+FFtxTwsSFFY0A2ViFhZYellTUWY/EmR/EFdNVjdCeBZc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8HHkdLA24qU=")[iii % 8])).ToArray());
                    break;
                case 2:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("Ptb7Egq5UlQO3PMED7IVFR3X6FAHsB4VGtv5HxOyBkY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e7iacGbccjU=")[iii % 8])).ToArray());
                    break;
                default:
                    inboundAuditStr = Encoding.UTF8.GetString(Convert.FromBase64String("NxevU6w7GBEXHb8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eXjbc8hefng=")[iii % 8])).ToArray());
                    break;
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("N6l++0fyDll8/DrcZ9ctHh3oMNEz7CYKSfs31mfXLBdO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PYletRO+Q3k=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OVlfQrzqkSJ7FgoM+Ji9P20LFgHoo7ciallfQrzq4mxiSQJK5/ulZQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GXl/YpzK2Ew=")[iii % 8])).ToArray()), dto.InboundRestrictions, inboundRestrictStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gcrw8tONR9XViL+nnclaxdKeoruQ2WHPz5nw8tONMoDa2q36iJx1iQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oerQ0vOtCKA=")[iii % 8])).ToArray()), dto.OutboundRestrictions, outboundRestrictStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OaJDSk3ckoV77RYECb2uj3D2CgQK3PvLOaJDSk3c4ctish5CFs2mwg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GYJjam382+s=")[iii % 8])).ToArray()), dto.InboundAuditing, inboundAuditStr);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ue1no+vRtFPtryj2pZW+XvqoN/einpVVue1no+vRwQbi/To=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mc1Hg8vx+yY=")[iii % 8])).ToArray()), dto.OutboundExceptions);
        }
    }
}
#nullable enable
