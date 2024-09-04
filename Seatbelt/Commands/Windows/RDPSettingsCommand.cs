using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    internal class O_5ED8A1C3 : O_2183A68D
    {
        public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("cZ9h6J12EqhNvEI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I9sxm/gCZsE=")[iii % 8])).ToArray());
        public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("wUc1BL5cgxr2UTMfpUmDDfZQLg64FuAy+kc2H+pqxirnSzYMuQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kyJYa8o5o14=")[iii % 8])).ToArray());
        public override CommandGroup[] Group => new[]
        {
            CommandGroup.System,
            CommandGroup.Remote
        };
        public override bool SupportRemote => true;

        public Runtime ThisRunTime;
        public O_5ED8A1C3(Runtime runtime) : base(runtime)
        {
            ThisRunTime = runtime;
        }

        public override IEnumerable<O_4AED570F?> Execute(string[] args)
        {
            var credDelegKey = Encoding.UTF8.GetString(Convert.FromBase64String("6Co1rhXV5D/nFTy2C9f/P8gZHrMBxvkp1CMnhjXd+D7UMiCGIcbzPt4rJ7MD2OUe3ik2vQPA/zXV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u0VT2mK0llo=")[iii % 8])).ToArray());
            var restrictedAdmin = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, credDelegKey, Encoding.UTF8.GetString(Convert.FromBase64String("lipnPFra5EihK0YtRdzzWYUreSFG2vRIti5gIUfd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xE8USCizhzw=")[iii % 8])).ToArray()));
            var restrictedAdminType = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, credDelegKey, Encoding.UTF8.GetString(Convert.FromBase64String("eS63LlrKn45OL5Y/RcyIn2ovqTNGyo+OWSqwM0fNqINbLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K0vEWiij/Po=")[iii % 8])).ToArray()));
            var serverAuthLevel = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Kr2/TIGW+aI2obJTmJnmiw6fkGi4tuqpC5WBbq6q0JA+oZpvuarBl0K4p12JoMSJC5iSbf2W05YUn5Bkrg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YvbzAd3FtuQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("2HqZfQ2ISYv6bpl8B4hxh+9qgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQ/tFWjmPeI=")[iii % 8])).ToArray()));
            var termServKey = Encoding.UTF8.GetString(Convert.FromBase64String("xgxKNMN0D9zJE2MM/VY0/OYfQQn3RzLq+iV4PMNcM/36NH9A2mEBzfAxYQn6VDG5xiZ+Fv1WOOo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lUMMYJQ1XZk=")[iii % 8])).ToArray());
            var disablePwSaving = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("y/aNoXtOIqPu7I23dlAjoO7pl65+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j5/+wBkiR/M=")[iii % 8])).ToArray()));
            var nla = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("8xARQLb83sfDDQBblOjexskN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pmN0MveJqq8=")[iii % 8])).ToArray()));
            var blockClipboard = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("N25Kb7FFLN0SRkps").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("USojHNAnQLg=")[iii % 8])).ToArray()));
            var blockComPort = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("7vDN9srgNQ/L18k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iLSkhauCWWo=")[iii % 8])).ToArray()));
            var blockDrives = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("+Xdi4dPK+EncV2Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nzMLkrKolCw=")[iii % 8])).ToArray()));
            var blockLptPort = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("tVU/y+e0y1efQQI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0xFWuIbWpzI=")[iii % 8])).ToArray()));
            var blockSmartCard = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("nmSrtx401nCVQLeiPznBRw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+CHF1nxYsyM=")[iii % 8])).ToArray()));
            var blockPnp = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("3P7R+jqJ9BXq9OjbPo/xAg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("urq4iVvrmHA=")[iii % 8])).ToArray()));
            var blockPrinters = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("+cf9nYLaNknc8/k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n4OU7uO4Wiw=")[iii % 8])).ToArray()));
            yield return new O_28B2DDC6(new O_3F770CB1(restrictedAdmin != null && restrictedAdmin != 0, restrictedAdminType, serverAuthLevel, disablePwSaving == null || disablePwSaving == 1), new O_B029DD04(nla, blockClipboard, blockComPort, blockDrives, blockLptPort, blockSmartCard, blockPnp, blockPrinters));
        }

        public IEnumerable<O_4AED570F?> Execute(string[] args, string wIfOqqkt)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                        instance.GetMaxCharCount(93);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var credDelegKey = Encoding.UTF8.GetString(Convert.FromBase64String("6Co1rhXV5D/nFTy2C9f/P8gZHrMBxvkp1CMnhjXd+D7UMiCGIcbzPt4rJ7MD2OUe3ik2vQPA/zXV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u0VT2mK0llo=")[iii % 8])).ToArray());
            var restrictedAdmin = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, credDelegKey, Encoding.UTF8.GetString(Convert.FromBase64String("lipnPFra5EihK0YtRdzzWYUreSFG2vRIti5gIUfd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xE8USCizhzw=")[iii % 8])).ToArray()));
            var restrictedAdminType = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, credDelegKey, Encoding.UTF8.GetString(Convert.FromBase64String("eS63LlrKn45OL5Y/RcyIn2ovqTNGyo+OWSqwM0fNqINbLg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K0vEWiij/Po=")[iii % 8])).ToArray()));
            var serverAuthLevel = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("Kr2/TIGW+aI2obJTmJnmiw6fkGi4tuqpC5WBbq6q0JA+oZpvuarBl0K4p12JoMSJC5iSbf2W05YUn5Bkrg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YvbzAd3FtuQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("2HqZfQ2ISYv6bpl8B4hxh+9qgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQ/tFWjmPeI=")[iii % 8])).ToArray()));
            var termServKey = Encoding.UTF8.GetString(Convert.FromBase64String("xgxKNMN0D9zJE2MM/VY0/OYfQQn3RzLq+iV4PMNcM/36NH9A2mEBzfAxYQn6VDG5xiZ+Fv1WOOo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lUMMYJQ1XZk=")[iii % 8])).ToArray());
            var disablePwSaving = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("y/aNoXtOIqPu7I23dlAjoO7pl65+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j5/+wBkiR/M=")[iii % 8])).ToArray()));
            var nla = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("8xARQLb83sfDDQBblOjexskN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pmN0MveJqq8=")[iii % 8])).ToArray()));
            var blockClipboard = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("N25Kb7FFLN0SRkps").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("USojHNAnQLg=")[iii % 8])).ToArray()));
            var blockComPort = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("7vDN9srgNQ/L18k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iLSkhauCWWo=")[iii % 8])).ToArray()));
            var blockDrives = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("+Xdi4dPK+EncV2Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nzMLkrKolCw=")[iii % 8])).ToArray()));
            var blockLptPort = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("tVU/y+e0y1efQQI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0xFWuIbWpzI=")[iii % 8])).ToArray()));
            var blockSmartCard = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("nmSrtx401nCVQLeiPznBRw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+CHF1nxYsyM=")[iii % 8])).ToArray()));
            var blockPnp = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("3P7R+jqJ9BXq9OjbPo/xAg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("urq4iVvrmHA=")[iii % 8])).ToArray()));
            var blockPrinters = RegistryUtil.GetDwordValue(RegistryHive.LocalMachine, termServKey, Encoding.UTF8.GetString(Convert.FromBase64String("+cf9nYLaNknc8/k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n4OU7uO4Wiw=")[iii % 8])).ToArray()));
            yield return new O_28B2DDC6(new O_3F770CB1(restrictedAdmin != null && restrictedAdmin != 0, restrictedAdminType, serverAuthLevel, disablePwSaving == null || disablePwSaving == 1), new O_B029DD04(nla, blockClipboard, blockComPort, blockDrives, blockLptPort, blockSmartCard, blockPnp, blockPrinters));
        }
    }

    internal class O_3F770CB1
    {
        public O_3F770CB1(bool restrictedRemoteAdministration, uint? restrictedRemoteAdministrationType, uint? serverAuthLevel, bool disablePasswordSaving)
        {
            RestrictedRemoteAdministration = restrictedRemoteAdministration;
            RestrictedRemoteAdministrationType = restrictedRemoteAdministrationType;
            ServerAuthLevel = serverAuthLevel;
            DisablePasswordSaving = disablePasswordSaving;
        }

        public bool RestrictedRemoteAdministration { get; }
        public uint? RestrictedRemoteAdministrationType { get; }
        public uint? ServerAuthLevel { get; }
        public bool DisablePasswordSaving { get; }
    }

    internal class O_B029DD04
    {
        public O_B029DD04(uint? networkLevelAuthentication, uint? blockClipboardRedirection, uint? blockComPortRedirection, uint? blockDriveRedirection, uint? blockLptPortRedirection, uint? allowSmartCardRedirection, uint? blockPnPDeviceRedirection, uint? blockPrinterRedirection)
        {
            NetworkLevelAuthentication = networkLevelAuthentication;
            BlockClipboardRedirection = blockClipboardRedirection;
            BlockComPortRedirection = blockComPortRedirection;
            BlockDriveRedirection = blockDriveRedirection;
            BlockLptPortRedirection = blockLptPortRedirection;
            AllowSmartCardRedirection = allowSmartCardRedirection;
            BlockPnPDeviceRedirection = blockPnPDeviceRedirection;
            BlockPrinterRedirection = blockPrinterRedirection;
        }

        public uint? NetworkLevelAuthentication { get; }
        public uint? BlockClipboardRedirection { get; }
        public uint? BlockComPortRedirection { get; }
        public uint? BlockDriveRedirection { get; }
        public uint? BlockLptPortRedirection { get; }
        public uint? AllowSmartCardRedirection { get; }
        public uint? BlockPnPDeviceRedirection { get; }
        public uint? BlockPrinterRedirection { get; }
    }

    internal class O_28B2DDC6 : O_4AED570F
    {
        public O_28B2DDC6(O_3F770CB1 clientSettings, O_B029DD04 serverSettings)
        {
            ClientSettings = clientSettings;
            ServerSettings = serverSettings;
        }

        public O_3F770CB1 ClientSettings { get; }
        public O_B029DD04 ServerSettings { get; }
    }

    [CommandOutputType(typeof(O_28B2DDC6))]
    internal class O_A4C68D9D : TextFormatterBase
    {
        public O_A4C68D9D(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_28B2DDC6)result;
            string str;
            var server = dto.ServerSettings;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9gPTxexje9/BNaO22nJ9wMog8N8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pEeD5b8GCak=")[iii % 8])).ToArray()));
            WriteLine($"  NetworkLevelAuthentication: {server.NetworkLevelAuthentication}");
            WriteLine($"  BlockClipboardRedirection:  {server.BlockClipboardRedirection}");
            WriteLine($"  BlockComPortRedirection:    {server.BlockComPortRedirection}");
            WriteLine($"  BlockDriveRedirection:      {server.BlockDriveRedirection}");
            WriteLine($"  BlockLptPortRedirection:    {server.BlockLptPortRedirection}");
            WriteLine($"  BlockPnPDeviceRedirection:  {server.BlockPnPDeviceRedirection}");
            WriteLine($"  BlockPrinterRedirection:    {server.BlockPrinterRedirection}");
            WriteLine($"  AllowSmartCardRedirection:  {server.AllowSmartCardRedirection}");
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vfbIPXwpfaXSyvhNDw9luN7K6x5m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t6SMbVxqEcw=")[iii % 8])).ToArray()));
            WriteLine($"  DisablePasswordSaving: {dto.ClientSettings.DisablePasswordSaving}");
            WriteLine($"  RestrictedRemoteAdministration: {dto.ClientSettings.RestrictedRemoteAdministration}");
            var type = dto.ClientSettings.RestrictedRemoteAdministrationType;
            if (type != null)
            {
                if (type == 1)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("Jke9RXAyNtgmR79EaykwjBFG7HF9LTqWVG+jVHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dCLMMBlAU/g=")[iii % 8])).ToArray());
                else if (type == 2)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("DzDsBFM5A8QPMPAeTi5Gpy8w+RRUPw+FMXXaBFs5Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XVWdcTpLZuQ=")[iii % 8])).ToArray());
                else if (type == 3)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("hTAORMNs3biFMAxF2Hfb7LIxX3DOc9H29zoNEfh71fejMF9y2Hvc/bkhFlDGPv/tticb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("11V/MaoeuJg=")[iii % 8])).ToArray());
                else
                    str = $"{type} - Unknown, please report this";
                WriteLine($"  RestrictedRemoteAdministrationType: {str}");
            }

            var level = dto.ClientSettings.ServerAuthLevel;
            if (level != null)
            {
                if (level == 1)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("j0LyEUCa1UqPQvAQW4HTHrhDoyVNhdkE/WrsAEw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3SeDZCnosGo=")[iii % 8])).ToArray());
                else if (level == 2)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("zjGOgQAunvPOMZKbHTnbkO4xm5EHKJKy8HS4gQgunw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nFT/9Glc+9M=")[iii % 8])).ToArray());
                else if (level == 3)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("5XUSR2aVM8bldRBGfY41ktJ0Q3Nrij+Il38REl2CO4nDdUNxfYIyg9lkClNjxxGT1mIH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("txBjMg/nVuY=")[iii % 8])).ToArray());
                else
                    str = $"Unknown, please report this";
                WriteLine($"  ServerAuthenticationLevel: {level} - {str}");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string bJfhnejq)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                        instance.GetMaxCharCount(93);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_28B2DDC6)result;
            string str;
            var server = dto.ServerSettings;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("9gPTxexje9/BNaO22nJ9wMog8N8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pEeD5b8GCak=")[iii % 8])).ToArray()));
            WriteLine($"  NetworkLevelAuthentication: {server.NetworkLevelAuthentication}");
            WriteLine($"  BlockClipboardRedirection:  {server.BlockClipboardRedirection}");
            WriteLine($"  BlockComPortRedirection:    {server.BlockComPortRedirection}");
            WriteLine($"  BlockDriveRedirection:      {server.BlockDriveRedirection}");
            WriteLine($"  BlockLptPortRedirection:    {server.BlockLptPortRedirection}");
            WriteLine($"  BlockPnPDeviceRedirection:  {server.BlockPnPDeviceRedirection}");
            WriteLine($"  BlockPrinterRedirection:    {server.BlockPrinterRedirection}");
            WriteLine($"  AllowSmartCardRedirection:  {server.AllowSmartCardRedirection}");
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vfbIPXwpfaXSyvhNDw9luN7K6x5m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t6SMbVxqEcw=")[iii % 8])).ToArray()));
            WriteLine($"  DisablePasswordSaving: {dto.ClientSettings.DisablePasswordSaving}");
            WriteLine($"  RestrictedRemoteAdministration: {dto.ClientSettings.RestrictedRemoteAdministration}");
            var type = dto.ClientSettings.RestrictedRemoteAdministrationType;
            if (type != null)
            {
                if (type == 1)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("Jke9RXAyNtgmR79EaykwjBFG7HF9LTqWVG+jVHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dCLMMBlAU/g=")[iii % 8])).ToArray());
                else if (type == 2)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("DzDsBFM5A8QPMPAeTi5Gpy8w+RRUPw+FMXXaBFs5Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XVWdcTpLZuQ=")[iii % 8])).ToArray());
                else if (type == 3)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("hTAORMNs3biFMAxF2Hfb7LIxX3DOc9H29zoNEfh71fejMF9y2Hvc/bkhFlDGPv/tticb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("11V/MaoeuJg=")[iii % 8])).ToArray());
                else
                    str = $"{type} - Unknown, please report this";
                WriteLine($"  RestrictedRemoteAdministrationType: {str}");
            }

            var level = dto.ClientSettings.ServerAuthLevel;
            if (level != null)
            {
                if (level == 1)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("j0LyEUCa1UqPQvAQW4HTHrhDoyVNhdkE/WrsAEw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3SeDZCnosGo=")[iii % 8])).ToArray());
                else if (level == 2)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("zjGOgQAunvPOMZKbHTnbkO4xm5EHKJKy8HS4gQgunw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nFT/9Glc+9M=")[iii % 8])).ToArray());
                else if (level == 3)
                    str = Encoding.UTF8.GetString(Convert.FromBase64String("5XUSR2aVM8bldRBGfY41ktJ0Q3Nrij+Il38REl2CO4nDdUNxfYIyg9lkClNjxxGT1mIH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("txBjMg/nVuY=")[iii % 8])).ToArray());
                else
                    str = $"Unknown, please report this";
                WriteLine($"  ServerAuthenticationLevel: {level} - {str}");
            }
        }
    }
}