#nullable disable
using Microsoft.Win32;
using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Interop;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_9A96A87B
    {
        public string Product { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
    }
internal class O_2CF25CF2 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("EY0pQdjjhuYLmA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XutPKLuGy7Q=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("SqtOH4lsc8ZqvlxWmGwwzmu5RA/KfCDOYe1OH4Zsc8dsvlxWwmUy2HHtH1aOaCrYLA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bc0oduoJU6s=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_2CF25CF2(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var lastDays = 7;
        if (args.Length == 1)
        {
            lastDays = int.Parse(args[0]);
        }
        else if (!Runtime.FilterResults)
        {
            lastDays = 30;
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("IQS2IBKLnuANBKRtOJ+Z/QcP4yAYiou0Fg+gKBmNk+1EH7AoE9mZ/QgPsG0Rlo20EAKmbRuYjOBEEfMwV52e7Rc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZGrDTXf5/5Q=")[iii % 8])).ToArray()), lastDays);
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("4X0mKz9i1cuWfSYrPmLVwdggJnB0fNTe2m97cC81y44=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("610GUA9O+PM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yJo3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iepH1kteBzU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rDa0Hw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+UXRbUeaSyk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("izBPurAcX7u0Ig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x1E8zvF/PN4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UugKiexgx34=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FIFm7KIBqhs=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("g5kalqBJzieDmRqXoEnEad6ZQd2+SNtrkcRBhvdXiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o7lhpoxk9lo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("RHf1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aVrY2aUz52s=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UfGfSA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fNyyZZ2Hebo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("3CQfsS+MuPbcJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8QkynAKhlds=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yYmX19hWHTc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5KS6+vV7MBo=")[iii % 8])).ToArray()));
        foreach (var file in EnumRecentOfficeFiles(lastDays).OrderByDescending(e => ((O_82A76845)e).LastAccessDate))
        {
            yield return file;
        }
    }

    private IEnumerable<O_4AED570F> EnumRecentOfficeFiles(int lastDays)
    {
        foreach (var sid in Registry.Users.GetSubKeyNames())
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("IYdq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cqpbHS5XisQ=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sTDZJ7WUAIc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7nO1RsbnZfQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string userName = null;
            try
            {
                userName = Advapi32.TranslateSid(sid);
            }
            catch
            {
                userName = sid;
            }

            var officeVersion = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Office")?.Where(k => float.TryParse(k, NumberStyles.AllowDecimalPoint, new CultureInfo(Encoding.UTF8.GetString(Convert.FromBase64String("A5AdqoI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zv4w7cDqlps=")[iii % 8])).ToArray())), out _));
            if (officeVersion is null)
                continue;
            foreach (var version in officeVersion)
            {
                foreach (O_82A76845 mru in GetMRUsFromVersionKey($"{sid}\\Software\\Microsoft\\Office\\{version}"))
                {
                    if (mru.LastAccessDate <= DateTime.Now.AddDays(-lastDays))
                        continue;
                    mru.User = userName;
                    yield return mru;
                }
            }
        }
    }

    private IEnumerable<O_4AED570F> GetMRUsFromVersionKey(string officeVersionSubkeyPath)
    {
        var officeApplications = RegistryUtil.GetSubkeyNames(RegistryHive.Users, officeVersionSubkeyPath);
        if (officeApplications == null)
        {
            yield break;
        }

        foreach (var app in officeApplications)
        {
            foreach (var mru in GetMRUsValues($"{officeVersionSubkeyPath}\\{app}\\File MRU"))
            {
                yield return mru;
            }

            var logonAapps = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{officeVersionSubkeyPath}\\{app}\\User MRU");
            if (logonAapps == null)
                continue;
            foreach (var logonApp in logonAapps)
            {
                foreach (var mru in GetMRUsValues($"{officeVersionSubkeyPath}\\{app}\\User MRU\\{logonApp}\\File MRU"))
                {
                    ((O_82A76845)mru).Application = app;
                    yield return mru;
                }
            }
        }
    }

    private IEnumerable<O_4AED570F> GetMRUsValues(string fileMRUKeyPath)
    {
        var values = RegistryUtil.GetValues(RegistryHive.Users, fileMRUKeyPath);
        if (values == null)
            yield break;
        foreach (string mru in values.Values)
        {
            var m = ParseMruString(mru);
            if (m != null)
            {
                yield return m;
            }
        }
    }

    private O_82A76845? ParseMruString(string mru)
    {
        var matches = Regex.Matches(mru, Encoding.UTF8.GetString(Convert.FromBase64String("im2RHonpgaeMBudG+bj/1otqkSuMyKGnrHfnJZS++df9CeMj+buc0Y1X5wXlvpq6+w+XVJvPnaPpauBXirjp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1jbKf6STwIo=")[iii % 8])).ToArray()));
        if (matches.Count == 0)
        {
            return null;
        }

        long timestamp = 0;
        var dateHexString = matches[0].Groups[1].Value;
        var filename = matches[0].Groups[matches[0].Groups.Count - 1].Value;
        try
        {
            timestamp = long.Parse(dateHexString, NumberStyles.HexNumber);
        }
        catch
        {
            WriteError($"Could not parse MRU timestamp. Parsed timestamp: {dateHexString} MRU value: {mru}");
        }

        return new O_82A76845()
        {
            Application = Encoding.UTF8.GetString(Convert.FromBase64String("PEYp3UFN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cyBPtCIomYA=")[iii % 8])).ToArray()),
            LastAccessDate = DateTime.FromFileTimeUtc(timestamp),
            User = null,
            Target = filename
        };
    }

internal class O_82A76845 : O_4AED570F
{
    public string Application { get; set; }
    public string Target { get; set; }
    public DateTime LastAccessDate { get; set; }
    public string User { get; set; }
}    [CommandOutputType(typeof(O_82A76845))]
    internal class O_CC2AAB58 : TextFormatterBase
    {
        public O_CC2AAB58(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_82A76845)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mFeNMNoRsq+YV40x2hG44cVX1nvEEKfjigrWII0P9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uHf2APY8itI=")[iii % 8])).ToArray()), dto.Application, dto.User, dto.LastAccessDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("+bZKrtTc1qnkqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gM8z1/mRm4Q=")[iii % 8])).ToArray())), dto.Target);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string UQTyCUTj)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(61);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_82A76845)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mFeNMNoRsq+YV40x2hG44cVX1nvEEKfjigrWII0P9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uHf2APY8itI=")[iii % 8])).ToArray()), dto.Application, dto.User, dto.LastAccessDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("+bZKrtTc1qnkqw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gM8z1/mRm4Q=")[iii % 8])).ToArray())), dto.Target);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string fDmvJuQQ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var lastDays = 7;
        if (args.Length == 1)
        {
            lastDays = int.Parse(args[0]);
        }
        else if (!Runtime.FilterResults)
        {
            lastDays = 30;
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("IQS2IBKLnuANBKRtOJ+Z/QcP4yAYiou0Fg+gKBmNk+1EH7AoE9mZ/QgPsG0Rlo20EAKmbRuYjOBEEfMwV52e7Rc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZGrDTXf5/5Q=")[iii % 8])).ToArray()), lastDays);
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("4X0mKz9i1cuWfSYrPmLVwdggJnB0fNTe2m97cC81y44=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("610GUA9O+PM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yJo3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iepH1kteBzU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rDa0Hw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+UXRbUeaSyk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("izBPurAcX7u0Ig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x1E8zvF/PN4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UugKiexgx34=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FIFm7KIBqhs=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("g5kalqBJzieDmRqXoEnEad6ZQd2+SNtrkcRBhvdXiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o7lhpoxk9lo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("RHf1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aVrY2aUz52s=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UfGfSA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fNyyZZ2Hebo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("3CQfsS+MuPbcJA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8QkynAKhlds=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yYmX19hWHTc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5KS6+vV7MBo=")[iii % 8])).ToArray()));
        foreach (var file in EnumRecentOfficeFiles(lastDays).OrderByDescending(e => ((O_82A76845)e).LastAccessDate))
        {
            yield return file;
        }
    }

    private IEnumerable<O_4AED570F> EnumRecentOfficeFiles(int lastDays, string ZGFRMrmE)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        foreach (var sid in Registry.Users.GetSubKeyNames())
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("IYdq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cqpbHS5XisQ=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sTDZJ7WUAIc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7nO1RsbnZfQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string userName = null;
            try
            {
                userName = Advapi32.TranslateSid(sid);
            }
            catch
            {
                userName = sid;
            }

            var officeVersion = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Office")?.Where(k => float.TryParse(k, NumberStyles.AllowDecimalPoint, new CultureInfo(Encoding.UTF8.GetString(Convert.FromBase64String("A5AdqoI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zv4w7cDqlps=")[iii % 8])).ToArray())), out _));
            if (officeVersion is null)
                continue;
            foreach (var version in officeVersion)
            {
                foreach (O_82A76845 mru in GetMRUsFromVersionKey($"{sid}\\Software\\Microsoft\\Office\\{version}"))
                {
                    if (mru.LastAccessDate <= DateTime.Now.AddDays(-lastDays))
                        continue;
                    mru.User = userName;
                    yield return mru;
                }
            }
        }
    }

    private IEnumerable<O_4AED570F> GetMRUsFromVersionKey(string officeVersionSubkeyPath, string uqJJThKf)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var officeApplications = RegistryUtil.GetSubkeyNames(RegistryHive.Users, officeVersionSubkeyPath);
        if (officeApplications == null)
        {
            yield break;
        }

        foreach (var app in officeApplications)
        {
            foreach (var mru in GetMRUsValues($"{officeVersionSubkeyPath}\\{app}\\File MRU"))
            {
                yield return mru;
            }

            var logonAapps = RegistryUtil.GetSubkeyNames(RegistryHive.Users, $"{officeVersionSubkeyPath}\\{app}\\User MRU");
            if (logonAapps == null)
                continue;
            foreach (var logonApp in logonAapps)
            {
                foreach (var mru in GetMRUsValues($"{officeVersionSubkeyPath}\\{app}\\User MRU\\{logonApp}\\File MRU"))
                {
                    ((O_82A76845)mru).Application = app;
                    yield return mru;
                }
            }
        }
    }

    private IEnumerable<O_4AED570F> GetMRUsValues(string fileMRUKeyPath, string HsXCmRnk)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var values = RegistryUtil.GetValues(RegistryHive.Users, fileMRUKeyPath);
        if (values == null)
            yield break;
        foreach (string mru in values.Values)
        {
            var m = ParseMruString(mru);
            if (m != null)
            {
                yield return m;
            }
        }
    }

    private O_82A76845? ParseMruString(string mru, string oYAoLbzM)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(61);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var matches = Regex.Matches(mru, Encoding.UTF8.GetString(Convert.FromBase64String("im2RHonpgaeMBudG+bj/1otqkSuMyKGnrHfnJZS++df9CeMj+buc0Y1X5wXlvpq6+w+XVJvPnaPpauBXirjp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1jbKf6STwIo=")[iii % 8])).ToArray()));
        if (matches.Count == 0)
        {
            return null;
        }

        long timestamp = 0;
        var dateHexString = matches[0].Groups[1].Value;
        var filename = matches[0].Groups[matches[0].Groups.Count - 1].Value;
        try
        {
            timestamp = long.Parse(dateHexString, NumberStyles.HexNumber);
        }
        catch
        {
            WriteError($"Could not parse MRU timestamp. Parsed timestamp: {dateHexString} MRU value: {mru}");
        }

        return new O_82A76845()
        {
            Application = Encoding.UTF8.GetString(Convert.FromBase64String("PEYp3UFN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cyBPtCIomYA=")[iii % 8])).ToArray()),
            LastAccessDate = DateTime.FromFileTimeUtc(timestamp),
            User = null,
            Target = filename
        };
    }
}}
#nullable enable
