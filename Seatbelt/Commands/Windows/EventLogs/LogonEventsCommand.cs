using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using O_F41F88FA.Util;
using O_F41F88FA.Interop;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using static O_F41F88FA.Interop.Secur32;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs
{
internal class O_A7473834 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("DuF3NXn0wV8s+mM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Qo4QWhextzo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Hmhzj8NYOsI3aWCTjVAawjdpYMDkPH+AZDUgyY0eLds/J2CIyFgs0TFyZonZAX/RJGJ6lI0UMNN8J1CFyxkq2CYne4aNSW+UNmZtk4FYPsY1cnmFwwx/iW8neIHeDH/scmN1md5W").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UgcU4K14X7Q=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_A7473834(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("TgEYjihvd9d0TxqDKGYywG9BWaExeSODeQpZjSoqNsd2BheFN34lwm8AC8MtZHfCOwcQiywqPs1vCh6eLX4ug3gAF5ghciON").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G2957EQKV6M=")[iii % 8])).ToArray()));
            yield break;
        }

        var NTLMv1Users = new HashSet<string>();
        var NTLMv2Users = new HashSet<string>();
        var KerberosUsers = new HashSet<string>();
        var lastDays = 10;
        if (ThisRunTime.ISRemote())
        {
            lastDays = 5;
        }
        else if (O_210F4320.IsWindowsServer())
        {
            lastDays = 1;
        }

        string? userRegex = null;
        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("5IsZ4g57CPSFkA23DXESoMSXXv4NagPnwIs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pfl+l2MeZoA=")[iii % 8])).ToArray()));
            }
        }

        if (args.Length >= 2)
        {
            userRegex = args[1];
        }

        WriteVerbose($"Listing 4624 Account Logon Events for the last {lastDays} days.\n");
        if (userRegex != null)
        {
            WriteVerbose($"Username Filter: {userRegex}");
        }

        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"*[System/EventID=4624] and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("FLBGauXo1mc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R9UlH5eBoh4=")[iii % 8])).ToArray()), query);
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("d1yBXXzdzWkyHaFRdZTaeiUbsEBEy+tpezC6U37W2mInGfl9YfnqfyUZpkc96/t5PRm2QETL62k5HbhRPfn7bz8Zu0B42+9vPhO7ZHDb5XowGZtVfN2iVzostFd62el+GR24UT3s72kwGaF7ZMzsdCISsWFi3fw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V3zVNBG4jhs=")[iii % 8])).ToArray()));
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var subjectUserName = eventDetail.Properties[1].Value.ToString();
            var subjectDomainName = eventDetail.Properties[2].Value.ToString();
            var targetUserName = eventDetail.Properties[5].Value.ToString();
            var targetDomainName = eventDetail.Properties[6].Value.ToString();
            var logonType = $"{(SECURITY_LOGON_TYPE)(int.Parse(eventDetail.Properties[8].Value.ToString()))}";
            var authenticationPackageName = eventDetail.Properties[10].Value.ToString();
            var lmPackageName = eventDetail.Properties[14].Value.ToString();
            lmPackageName = lmPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("7w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wr25Jp3z4ug=")[iii % 8])).ToArray()) ? Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJrtlKYHt18=")[iii % 8])).ToArray()) : lmPackageName;
            var ipAddress = eventDetail.Properties[18].Value.ToString();
            var targetOutboundUserName = Encoding.UTF8.GetString(Convert.FromBase64String("wA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7YTnyI1YqgI=")[iii % 8])).ToArray());
            var targetOutboundDomainName = Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X/Yh8vF7r3w=")[iii % 8])).ToArray());
            if (eventDetail.Properties.Count > 22)
            {
                targetOutboundUserName = eventDetail.Properties[22].Value.ToString();
                targetOutboundDomainName = eventDetail.Properties[23].Value.ToString();
            }

            var userIgnoreRegex = Encoding.UTF8.GetString(Convert.FromBase64String("zqgF+ZiKbXvszBnjipIIZdXSAOmIm1R41dQB75mVCGXV0gDpiJtUY93GEo2Q7gUPzasq5JyTBW2grW/94KJpeN/OD+2Ei3sW3M8R74Wi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kIBWoMveKDY=")[iii % 8])).ToArray()) + Environment.MachineName + Encoding.UTF8.GetString(Convert.FromBase64String("55UCyw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u7Er73e3mWM=")[iii % 8])).ToArray());
            if (userRegex == null && Regex.IsMatch(targetUserName, userIgnoreRegex, RegexOptions.IgnoreCase))
                continue;
            var domainIgnoreRegex = Encoding.UTF8.GetString(Convert.FromBase64String("ItoKtHfgj2UopwWsd/uHdDS7CqV+kg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fPJE4Fe2xjc=")[iii % 8])).ToArray());
            if (userRegex == null && Regex.IsMatch(targetDomainName, domainIgnoreRegex, RegexOptions.IgnoreCase))
                continue;
            if (userRegex != null && !Regex.IsMatch(targetUserName, userRegex, RegexOptions.IgnoreCase))
                continue;
            if (logonType == Encoding.UTF8.GetString(Convert.FromBase64String("otuIxGXbmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7L78swqp8pg=")[iii % 8])).ToArray()))
            {
                var accountName = $"{targetDomainName}\\{targetUserName}";
                if (authenticationPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("VvUYBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GKFUSqam2s0=")[iii % 8])).ToArray()))
                {
                    switch (lmPackageName)
                    {
                        case "NTLM V1":
                            NTLMv1Users.Add(accountName);
                            break;
                        case "NTLM V2":
                            NTLMv2Users.Add(accountName);
                            break;
                    }
                }
                else if (authenticationPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("K5bGsUHSJXU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YPO00ySgSgY=")[iii % 8])).ToArray()))
                {
                    KerberosUsers.Add(accountName);
                }
            }

            yield return new O_D0B31D54(eventDetail.TimeCreated?.ToUniversalTime(), targetUserName, targetDomainName, logonType, ipAddress, subjectUserName, subjectDomainName, authenticationPackageName, lmPackageName, targetOutboundUserName, targetOutboundDomainName);
        }

        if (NTLMv1Users.Count > 0 || NTLMv2Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("0W3/wUSe9af7LLztX4P+oahtvvtEnvW7ryS870STsKG0bavmWYWwuLout+dek7CgqCSx6RC4xJmWbP/AZLrd+Kkos+9J1v20om296xCG/6aoJL3iVQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("203fjjD2kNU=")[iii % 8])).ToArray()));
        }

        if (NTLMv1Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("rnI6hEMDXQvKJmnlQRVGFsE8bqxDAUYbhCZ15VQIWw2EP3umSAlcG4QnaaxOBxIw8B5X5VZREw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pFIaxSBgMn4=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("/e9lCq4cPhOz71MHr100HP27VACoWX0TvqxTELVILlX95RYrj3AQWPfvVASoVDgB/a1FRahSNBS7plIC+3IJPpDvXw26UDEXs6hZSqlZLgKyoU8AqBw8HLnvSA2+Un0Rr65fDrJSOlKpp1kI+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3c88Zds8XXI=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZI0pqvTTgix1jQaLzPbHNDDEBJ/M9800ZMQU3omukn9kzxWR0/vMe04=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RK1n/rieolo=")[iii % 8])).ToArray()));
            PrintUserSet(NTLMv1Users);
        }

        if (NTLMv2Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("zM/Vf9PNJ42om4Ye0ds8kKOBgVfTzzyd5puaHsTGIYvmgpRd2McmneaahlfeyWi2kqO4HsacaQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xu/1PrCuSPg=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("omezJnI1DxzsZ4Urc3QFE6IJjz1JQSAw9HXKL2hnTAnqIpksJ3QPHu0yhD10NQ4EojSEIGFzBRPlZ6QdS1hMHuomhiViewsYrTWPOnd6Ag7nNMQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gkfqSQcVbH0=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZmFteFZCwhMoYUB/RgyBBjQ4FHZNBoERNCBXfAMWyRcvMxRnQhHSBSkzUGQNaA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RkE0FyNioXI=")[iii % 8])).ToArray()));
            PrintUserSet(NTLMv2Users);
        }

        if (KerberosUsers.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("5If1RGpgEreBy7l/dWxcts7SpnVwdhK5j9GwMGNwRrmLyaF5YWRGtIqHoX8icVq4nYe4cWFtW7+Lh6Bja2tV8aXCp3Jnd12iwK0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7qfVEAIFMtE=")[iii % 8])).ToArray()));
            PrintUserSet(KerberosUsers);
        }
    }

    private void PrintUserSet(HashSet<string> users)
    {
        var set = users.OrderBy(u => u).ToArray();
        var line = new StringBuilder();
        for (var i = 0; i < set.Length; i++)
        {
            if (i % 3 == 0)
            {
                WriteHost(line.ToString());
                line.Length = 0;
                line.Append(Encoding.UTF8.GetString(Convert.FromBase64String("heU3AQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pcUXIXWwlfs=")[iii % 8])).ToArray()));
            }

            line.Append(set.ElementAt(i).PadRight(30));
        }

        WriteHost(line.ToString());
        WriteHost();
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ksOXRAcm)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(70);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("TgEYjihvd9d0TxqDKGYywG9BWaExeSODeQpZjSoqNsd2BheFN34lwm8AC8MtZHfCOwcQiywqPs1vCh6eLX4ug3gAF5ghciON").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G2957EQKV6M=")[iii % 8])).ToArray()));
            yield break;
        }

        var NTLMv1Users = new HashSet<string>();
        var NTLMv2Users = new HashSet<string>();
        var KerberosUsers = new HashSet<string>();
        var lastDays = 10;
        if (ThisRunTime.ISRemote())
        {
            lastDays = 5;
        }
        else if (O_210F4320.IsWindowsServer())
        {
            lastDays = 1;
        }

        string? userRegex = null;
        if (args.Length >= 1)
        {
            if (!int.TryParse(args[0], out lastDays))
            {
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("5IsZ4g57CPSFkA23DXESoMSXXv4NagPnwIs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pfl+l2MeZoA=")[iii % 8])).ToArray()));
            }
        }

        if (args.Length >= 2)
        {
            userRegex = args[1];
        }

        WriteVerbose($"Listing 4624 Account Logon Events for the last {lastDays} days.\n");
        if (userRegex != null)
        {
            WriteVerbose($"Username Filter: {userRegex}");
        }

        var startTime = DateTime.Now.AddDays(-lastDays);
        var endTime = DateTime.Now;
        var query = $@"*[System/EventID=4624] and *[System[TimeCreated[@SystemTime >= '{startTime.ToUniversalTime():o}']]] and *[System[TimeCreated[@SystemTime <= '{endTime.ToUniversalTime():o}']]]";
        var logReader = ThisRunTime.GetEventLogReader(Encoding.UTF8.GetString(Convert.FromBase64String("FLBGauXo1mc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R9UlH5eBoh4=")[iii % 8])).ToArray()), query);
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("d1yBXXzdzWkyHaFRdZTaeiUbsEBEy+tpezC6U37W2mInGfl9YfnqfyUZpkc96/t5PRm2QETL62k5HbhRPfn7bz8Zu0B42+9vPhO7ZHDb5XowGZtVfN2iVzostFd62el+GR24UT3s72kwGaF7ZMzsdCISsWFi3fw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V3zVNBG4jhs=")[iii % 8])).ToArray()));
        for (var eventDetail = logReader.ReadEvent(); eventDetail != null; eventDetail = logReader.ReadEvent())
        {
            var subjectUserName = eventDetail.Properties[1].Value.ToString();
            var subjectDomainName = eventDetail.Properties[2].Value.ToString();
            var targetUserName = eventDetail.Properties[5].Value.ToString();
            var targetDomainName = eventDetail.Properties[6].Value.ToString();
            var logonType = $"{(SECURITY_LOGON_TYPE)(int.Parse(eventDetail.Properties[8].Value.ToString()))}";
            var authenticationPackageName = eventDetail.Properties[10].Value.ToString();
            var lmPackageName = eventDetail.Properties[14].Value.ToString();
            lmPackageName = lmPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("7w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wr25Jp3z4ug=")[iii % 8])).ToArray()) ? Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJrtlKYHt18=")[iii % 8])).ToArray()) : lmPackageName;
            var ipAddress = eventDetail.Properties[18].Value.ToString();
            var targetOutboundUserName = Encoding.UTF8.GetString(Convert.FromBase64String("wA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7YTnyI1YqgI=")[iii % 8])).ToArray());
            var targetOutboundDomainName = Encoding.UTF8.GetString(Convert.FromBase64String("cg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X/Yh8vF7r3w=")[iii % 8])).ToArray());
            if (eventDetail.Properties.Count > 22)
            {
                targetOutboundUserName = eventDetail.Properties[22].Value.ToString();
                targetOutboundDomainName = eventDetail.Properties[23].Value.ToString();
            }

            var userIgnoreRegex = Encoding.UTF8.GetString(Convert.FromBase64String("zqgF+ZiKbXvszBnjipIIZdXSAOmIm1R41dQB75mVCGXV0gDpiJtUY93GEo2Q7gUPzasq5JyTBW2grW/94KJpeN/OD+2Ei3sW3M8R74Wi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kIBWoMveKDY=")[iii % 8])).ToArray()) + Environment.MachineName + Encoding.UTF8.GetString(Convert.FromBase64String("55UCyw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u7Er73e3mWM=")[iii % 8])).ToArray());
            if (userRegex == null && Regex.IsMatch(targetUserName, userIgnoreRegex, RegexOptions.IgnoreCase))
                continue;
            var domainIgnoreRegex = Encoding.UTF8.GetString(Convert.FromBase64String("ItoKtHfgj2UopwWsd/uHdDS7CqV+kg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fPJE4Fe2xjc=")[iii % 8])).ToArray());
            if (userRegex == null && Regex.IsMatch(targetDomainName, domainIgnoreRegex, RegexOptions.IgnoreCase))
                continue;
            if (userRegex != null && !Regex.IsMatch(targetUserName, userRegex, RegexOptions.IgnoreCase))
                continue;
            if (logonType == Encoding.UTF8.GetString(Convert.FromBase64String("otuIxGXbmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7L78swqp8pg=")[iii % 8])).ToArray()))
            {
                var accountName = $"{targetDomainName}\\{targetUserName}";
                if (authenticationPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("VvUYBw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GKFUSqam2s0=")[iii % 8])).ToArray()))
                {
                    switch (lmPackageName)
                    {
                        case "NTLM V1":
                            NTLMv1Users.Add(accountName);
                            break;
                        case "NTLM V2":
                            NTLMv2Users.Add(accountName);
                            break;
                    }
                }
                else if (authenticationPackageName == Encoding.UTF8.GetString(Convert.FromBase64String("K5bGsUHSJXU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YPO00ySgSgY=")[iii % 8])).ToArray()))
                {
                    KerberosUsers.Add(accountName);
                }
            }

            yield return new O_D0B31D54(eventDetail.TimeCreated?.ToUniversalTime(), targetUserName, targetDomainName, logonType, ipAddress, subjectUserName, subjectDomainName, authenticationPackageName, lmPackageName, targetOutboundUserName, targetOutboundDomainName);
        }

        if (NTLMv1Users.Count > 0 || NTLMv2Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("0W3/wUSe9af7LLztX4P+oahtvvtEnvW7ryS870STsKG0bavmWYWwuLout+dek7CgqCSx6RC4xJmWbP/AZLrd+Kkos+9J1v20om296xCG/6aoJL3iVQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("203fjjD2kNU=")[iii % 8])).ToArray()));
        }

        if (NTLMv1Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("rnI6hEMDXQvKJmnlQRVGFsE8bqxDAUYbhCZ15VQIWw2EP3umSAlcG4QnaaxOBxIw8B5X5VZREw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pFIaxSBgMn4=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("/e9lCq4cPhOz71MHr100HP27VACoWX0TvqxTELVILlX95RYrj3AQWPfvVASoVDgB/a1FRahSNBS7plIC+3IJPpDvXw26UDEXs6hZSqlZLgKyoU8AqBw8HLnvSA2+Un0Rr65fDrJSOlKpp1kI+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3c88Zds8XXI=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZI0pqvTTgix1jQaLzPbHNDDEBJ/M9800ZMQU3omukn9kzxWR0/vMe04=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RK1n/rieolo=")[iii % 8])).ToArray()));
            PrintUserSet(NTLMv1Users);
        }

        if (NTLMv2Users.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("zM/Vf9PNJ42om4Ye0ds8kKOBgVfTzzyd5puaHsTGIYvmgpRd2McmneaahlfeyWi2kqO4HsacaQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xu/1PrCuSPg=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("omezJnI1DxzsZ4Urc3QFE6IJjz1JQSAw9HXKL2hnTAnqIpksJ3QPHu0yhD10NQ4EojSEIGFzBRPlZ6QdS1hMHuomhiViewsYrTWPOnd6Ag7nNMQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gkfqSQcVbH0=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZmFteFZCwhMoYUB/RgyBBjQ4FHZNBoERNCBXfAMWyRcvMxRnQhHSBSkzUGQNaA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RkE0FyNioXI=")[iii % 8])).ToArray()));
            PrintUserSet(NTLMv2Users);
        }

        if (KerberosUsers.Count > 0)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("5If1RGpgEreBy7l/dWxcts7SpnVwdhK5j9GwMGNwRrmLyaF5YWRGtIqHoX8icVq4nYe4cWFtW7+Lh6Bja2tV8aXCp3Jnd12iwK0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7qfVEAIFMtE=")[iii % 8])).ToArray()));
            PrintUserSet(KerberosUsers);
        }
    }

    private void PrintUserSet(HashSet<string> users, string htlGfXVi)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(70);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var set = users.OrderBy(u => u).ToArray();
        var line = new StringBuilder();
        for (var i = 0; i < set.Length; i++)
        {
            if (i % 3 == 0)
            {
                WriteHost(line.ToString());
                line.Length = 0;
                line.Append(Encoding.UTF8.GetString(Convert.FromBase64String("heU3AQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pcUXIXWwlfs=")[iii % 8])).ToArray()));
            }

            line.Append(set.ElementAt(i).PadRight(30));
        }

        WriteHost(line.ToString());
        WriteHost();
    }
}internal class O_D0B31D54 : O_4AED570F
{
    public O_D0B31D54(DateTime? timeCreatedUtc, string targetUserName, string targetDomainName, string logonType, string ipAddress, string subjectUserName, string subjectDomainName, string authenticationPackage, string lmPackage, string targetOutboundUserName, string targetOutboundDomainName)
    {
        TimeCreatedUtc = timeCreatedUtc;
        TargetUserName = targetUserName;
        TargetDomainName = targetDomainName;
        LogonType = logonType;
        IpAddress = ipAddress;
        SubjectUserName = subjectUserName;
        SubjectDomainName = subjectDomainName;
        AuthenticationPackage = authenticationPackage;
        LmPackage = lmPackage;
        TargetOutboundUserName = targetOutboundUserName;
        TargetOutboundDomainName = targetOutboundDomainName;
    }

    public DateTime? TimeCreatedUtc { get; set; }
    public string TargetUserName { get; set; }
    public string TargetDomainName { get; set; }
    public string LogonType { get; set; }
    public string IpAddress { get; set; }
    public string SubjectUserName { get; set; }
    public string SubjectDomainName { get; set; }
    public string AuthenticationPackage { get; set; }
    public string LmPackage { get; set; }
    public string TargetOutboundUserName { get; set; }
    public string TargetOutboundDomainName { get; set; }
}
    [CommandOutputType(typeof(O_D0B31D54))]
    internal class O_6DECF828 : TextFormatterBase
    {
        public O_6DECF828(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_D0B31D54)result;
            var targetUser = dto.TargetDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("Jg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eiUmGmpQK9Y=")[iii % 8])).ToArray()) + dto.TargetUserName;
            var subjectUser = dto.SubjectDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("7A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sDP+NI7m+No=")[iii % 8])).ToArray()) + dto.SubjectUserName;
            string targetOutboundUser = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("diSWlk3+Azc=")[iii % 8])).ToArray());
            if (dto.TargetOutboundUserName != Encoding.UTF8.GetString(Convert.FromBase64String("eA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VckyrpN+2ok=")[iii % 8])).ToArray()))
            {
                targetOutboundUser = dto.TargetOutboundDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vuIZuvrxNQ0=")[iii % 8])).ToArray()) + dto.TargetOutboundUserName;
            }

            WriteLine($"  {dto.TimeCreatedUtc?.ToLocalTime()},{targetUser},{dto.LogonType},{dto.IpAddress},{subjectUser},{dto.AuthenticationPackage},{dto.LmPackage},{targetOutboundUser}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string bLDyyeBK)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Random instance = new System.Random();
                        instance.Next(70);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_D0B31D54)result;
            var targetUser = dto.TargetDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("Jg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eiUmGmpQK9Y=")[iii % 8])).ToArray()) + dto.TargetUserName;
            var subjectUser = dto.SubjectDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("7A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sDP+NI7m+No=")[iii % 8])).ToArray()) + dto.SubjectUserName;
            string targetOutboundUser = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("diSWlk3+Azc=")[iii % 8])).ToArray());
            if (dto.TargetOutboundUserName != Encoding.UTF8.GetString(Convert.FromBase64String("eA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VckyrpN+2ok=")[iii % 8])).ToArray()))
            {
                targetOutboundUser = dto.TargetOutboundDomainName + Encoding.UTF8.GetString(Convert.FromBase64String("4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vuIZuvrxNQ0=")[iii % 8])).ToArray()) + dto.TargetOutboundUserName;
            }

            WriteLine($"  {dto.TimeCreatedUtc?.ToLocalTime()},{targetUser},{dto.LogonType},{dto.IpAddress},{subjectUser},{dto.AuthenticationPackage},{dto.LmPackage},{targetOutboundUser}");
        }
    }
}