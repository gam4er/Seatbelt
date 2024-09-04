#nullable disable
using System;
using System.Collections.Generic;
using static O_F41F88FA.Interop.O_B81255AD;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_81BF00D4 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("3m2e6Tx7TO/gcQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kgL9iFAuP4o=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("0FSHslau9KL5SZf/GvnptOhTgaEa+um05RyWthrv4qX1TYH8XufysP5XgbcWruC/+BuUpF6u7bDvT8SgX/qh+f1Jg6ZX6++lvAbZ81nh7KHpT4GhVO/stLxPi/Nf4PS8+UmFp1+n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nDvk0zqOgdE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_81BF00D4(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string computerName = null;
        if (!String.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length == 1)
        {
            computerName = args[0];
        }

        foreach (var localUser in GetLocalUsers(computerName))
        {
            var enabled = ((localUser.flags >> 1) & 1) == 0;
            var pwdLastSet = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var lastLogon = new DateTime(1970, 1, 1, 0, 0, 0);
            if (localUser.passwordAge != 0)
            {
                pwdLastSet = DateTime.Now.AddSeconds(-localUser.passwordAge);
            }

            if (localUser.last_logon != 0)
            {
                lastLogon = lastLogon.AddSeconds(localUser.last_logon).ToLocalTime();
            }

            yield return new O_D4B9D728(computerName ?? Encoding.UTF8.GetString(Convert.FromBase64String("Gd28iS4EyTYB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dbLf6EJspkU=")[iii % 8])).ToArray()), localUser.name, enabled, localUser.user_id, (Priv)localUser.priv, localUser.comment, pwdLastSet, lastLogon, localUser.num_logons);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string rnLgwsRI)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ChineseLunisolarCalendar instance = new System.Globalization.ChineseLunisolarCalendar();
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

        string computerName = null;
        if (!String.IsNullOrEmpty(ThisRunTime.ComputerName))
        {
            computerName = ThisRunTime.ComputerName;
        }
        else if (args.Length == 1)
        {
            computerName = args[0];
        }

        foreach (var localUser in GetLocalUsers(computerName))
        {
            var enabled = ((localUser.flags >> 1) & 1) == 0;
            var pwdLastSet = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var lastLogon = new DateTime(1970, 1, 1, 0, 0, 0);
            if (localUser.passwordAge != 0)
            {
                pwdLastSet = DateTime.Now.AddSeconds(-localUser.passwordAge);
            }

            if (localUser.last_logon != 0)
            {
                lastLogon = lastLogon.AddSeconds(localUser.last_logon).ToLocalTime();
            }

            yield return new O_D4B9D728(computerName ?? Encoding.UTF8.GetString(Convert.FromBase64String("Gd28iS4EyTYB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dbLf6EJspkU=")[iii % 8])).ToArray()), localUser.name, enabled, localUser.user_id, (Priv)localUser.priv, localUser.comment, pwdLastSet, lastLogon, localUser.num_logons);
        }
    }
}internal class O_D4B9D728 : O_4AED570F
{
    public O_D4B9D728(string computerName, string userName, bool enabled, uint rid, Priv userType, string comment, DateTime pwdLastSet, DateTime lastLogon, uint numLogins)
    {
        ComputerName = computerName;
        UserName = userName;
        Enabled = enabled;
        Rid = rid;
        UserType = userType;
        Comment = comment;
        PwdLastSet = pwdLastSet;
        LastLogon = lastLogon;
        NumLogins = numLogins;
    }

    public string ComputerName { get; }
    public string UserName { get; }
    public bool Enabled { get; }
    public uint Rid { get; }
    public Priv UserType { get; }
    public string Comment { get; }
    public DateTime PwdLastSet { get; }
    public DateTime LastLogon { get; }
    public uint NumLogins { get; }
}}
#nullable enable
