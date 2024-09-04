using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static O_F41F88FA.Interop.Secur32;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_E124CEC7 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("meStwBsR7ySm4qXBBg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1YvKr3VCilc=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("DeKwoY4WY5U25Lmqj0Fj0Cn4t6qPEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WovexeFhELU=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_E124CEC7(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() || ThisRunTime.ISRemote())
        {
            var userDomainRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PqsoK7bJPf1S6m9j/YtOvheheGj3iSr2WA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("esRFSt+nAN8=")[iii % 8])).ToArray()));
            var logonIdRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("VBClcOpW0gc6V557rzaU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GH/CH4Qftjo=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("RFs0NvqqqDl7Rzo2+vnbdH5dMnnDx7J1BT4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CDRTWZSK+1w=")[iii % 8])).ToArray()));
            var logonMap = new Dictionary<string, string[]>();
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("noQiAnlcrcea2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7OtNdiU/xKo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bmJ+Z1A9Nf0dYWBtXklCvlMUAH1fBnKwWEN9TEYacKU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PScyIhNpFdc=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (ManagementObject result in data)
            {
                var m = logonIdRegex.Match(result[Encoding.UTF8.GetString(Convert.FromBase64String("RrcATWQ68UV2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AtJwKApelCs=")[iii % 8])).ToArray())].ToString());
                if (!m.Success)
                {
                    continue;
                }

                var logonId = m.Groups[1].ToString();
                var m2 = userDomainRegex.Match(result[Encoding.UTF8.GetString(Convert.FromBase64String("NMp7IYKEVk8b0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("daQPROHhMio=")[iii % 8])).ToArray())].ToString());
                if (!m2.Success)
                {
                    continue;
                }

                var domain = m2.Groups[1].ToString();
                var user = m2.Groups[2].ToString();
                logonMap.Add(logonId, new[] { domain, user });
            }

            var wmiData2 = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("YU0f5PEOl2hlEA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EyJwkK1t/gU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("uiTT5AiGgV/JJ83uBvL2HIdSrf4HvcYahzL60ji7zhs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6WGfoUvSoXU=")[iii % 8])).ToArray()));
            var data2 = wmiData2.Get();
            foreach (var o in data2)
            {
                var result2 = (ManagementObject)o;
                var userDomain = new string[2]
                {
                    Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JMTadJqUCAc=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9EgQEmg5kro=")[iii % 8])).ToArray())
                };
                try
                {
                    userDomain = logonMap[result2[Encoding.UTF8.GetString(Convert.FromBase64String("MbP2VOig5A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fdyRO4bpgFk=")[iii % 8])).ToArray())].ToString()];
                }
                catch
                {
                }

                var domain = userDomain[0];
                var userName = userDomain[1];
                var startTime = new DateTime();
                var logonType = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BF3d+YMS6m8=")[iii % 8])).ToArray());
                try
                {
                    startTime = ManagementDateTimeConverter.ToDateTime(result2[Encoding.UTF8.GetString(Convert.FromBase64String("TZGPaY7Fj0J7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HuXuG/qR5i8=")[iii % 8])).ToArray())].ToString());
                }
                catch
                {
                }

                try
                {
                    logonType = $"{(SECURITY_LOGON_TYPE)(int.Parse(result2[Encoding.UTF8.GetString(Convert.FromBase64String("K2AFo8wVM5oC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zw9izKJBSuo=")[iii % 8])).ToArray())].ToString()))}";
                }
                catch
                {
                }

                yield return new O_7BDECA4F(Encoding.UTF8.GetString(Convert.FromBase64String("F3D6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QD2zxYDb6NA=")[iii % 8])).ToArray()), userName, domain, result2[Encoding.UTF8.GetString(Convert.FromBase64String("/9B3amNNUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s78QBQ0ENoE=")[iii % 8])).ToArray())].ToString(), logonType, result2[Encoding.UTF8.GetString(Convert.FromBase64String("E4nR1Us3mgoxndHUQTe+AjGXxNpL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UvylvS5Z7mM=")[iii % 8])).ToArray())].ToString(), startTime, null, null, null, null, null);
            }
        }
        else
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("etk1TCcPNJtFxTtMJ1xH1kDfMwMFfCbXPLw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NrZSI0kvZ/4=")[iii % 8])).ToArray()));
            var logonSessions = new List<O_7BDECA4F>();
            var systime = new DateTime(1601, 1, 1, 0, 0, 0, 0);
            var ret = LsaEnumerateLogonSessions(out var count, out var luidPtr);
            for (ulong i = 0; i < count; i++)
            {
                ret = LsaGetLogonSessionData(luidPtr, out var sessionData);
                var data = (SECURITY_LOGON_SESSION_DATA)Marshal.PtrToStructure(sessionData, typeof(SECURITY_LOGON_SESSION_DATA));
                if (data.PSiD != IntPtr.Zero)
                {
                    var username = Marshal.PtrToStringUni(data.Username.Buffer).Trim();
                    var sid = new System.Security.Principal.SecurityIdentifier(data.PSiD);
                    var domain = Marshal.PtrToStringUni(data.LoginDomain.Buffer).Trim();
                    var authpackage = Marshal.PtrToStringUni(data.AuthenticationPackage.Buffer).Trim();
                    var logonType = (SECURITY_LOGON_TYPE)data.LogonType;
                    var logonTime = systime.AddTicks((long)data.LoginTime);
                    var logonServer = Marshal.PtrToStringUni(data.LogonServer.Buffer).Trim();
                    var dnsDomainName = Marshal.PtrToStringUni(data.DnsDomainName.Buffer).Trim();
                    var upn = Marshal.PtrToStringUni(data.Upn.Buffer).Trim();
                    var logonID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5WHoCbtRg9o=")[iii % 8])).ToArray());
                    try
                    {
                        logonID = data.LoginID.LowPart.ToString();
                    }
                    catch
                    {
                    }

                    var userSID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WB4hJm9pag=")[iii % 8])).ToArray());
                    try
                    {
                        userSID = sid.Value;
                    }
                    catch
                    {
                    }

                    yield return new O_7BDECA4F(Encoding.UTF8.GetString(Convert.FromBase64String("Sv54").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bq058+78hQ0=")[iii % 8])).ToArray()), username, domain, logonID, logonType.ToString(), authpackage, null, logonTime, logonServer, dnsDomainName, upn, userSID);
                }

                luidPtr = (IntPtr)((long)luidPtr.ToInt64() + Marshal.SizeOf(typeof(LUID)));
                LsaFreeReturnBuffer(sessionData);
            }

            LsaFreeReturnBuffer(luidPtr);
        }
    }

internal class O_7BDECA4F : O_4AED570F
{
    public O_7BDECA4F(string enumerationMethod, string userName, string domain, string logonId, string logonType, string authenticationPackage, DateTime? startTime, DateTime? logonTime, string? logonServer, string? logonServerDnsDomain, string? userPrincipalName, string? userSid)
    {
        EnumerationMethod = enumerationMethod;
        UserName = userName;
        Domain = domain;
        LogonId = logonId;
        LogonType = logonType;
        AuthenticationPackage = authenticationPackage;
        StartTime = startTime;
        LogonTime = logonTime;
        LogonServer = logonServer;
        LogonServerDnsDomain = logonServerDnsDomain;
        UserPrincipalName = userPrincipalName;
        UserSID = userSid;
    }

    public string EnumerationMethod { get; }
    public string UserName { get; }
    public string Domain { get; }
    public string LogonId { get; }
    public string LogonType { get; }
    public string AuthenticationPackage { get; }
    public DateTime? StartTime { get; }
    public DateTime? LogonTime { get; }
    public string? LogonServer { get; }
    public string? LogonServerDnsDomain { get; }
    public string? UserPrincipalName { get; }
    public string? UserSID { get; }
}    [CommandOutputType(typeof(O_7BDECA4F))]
    internal class O_0C364ED2 : TextFormatterBase
    {
        public O_0C364ED2(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_7BDECA4F)result;
            if (dto.EnumerationMethod.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("jGXQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2yiZVqfwaFU=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2y+D4ZjKBoiwYsaUy49U5vEvg5TLj1Tm8TWDz9vS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0Q+jtOuvdMY=")[iii % 8])).ToArray()), dto.UserName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("c/N9+zU7He1z8xm0eHpUo3PzGbR4elSjafNCpCU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U9M5lFhadIM=")[iii % 8])).ToArray()), dto.Domain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3p9FfAnj9t6anykzTqy4t96fKTNOrLi3xJ9yIxM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/r8JE26MmJc=")[iii % 8])).ToArray()), dto.LogonId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("wdHn9WjHhIyYgc66L4jK+MHRi7oviMr429HQqnI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4fGrmg+o6tg=")[iii % 8])).ToArray()), dto.LogonType);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("dIkJVZYSC5wgwCtBlhMBnATIK0uDHQvSbokzEJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VKlIIOJ6bvI=")[iii % 8])).ToArray()), dto.AuthenticationPackage);
                WriteLine($"  StartTime             : {dto.StartTime}");
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qEC9ahOD6JfhDotwBpDUq+kNjTlW0ZjFskCTKQs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iGDoGXbxuOU=")[iii % 8])).ToArray()), dto.UserPrincipalName);
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ggi55dyDJPXpRfyQj8Z2m6gIuZCPxnabqBK5y5+b").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iCiZsK/mVrs=")[iii % 8])).ToArray()), dto.UserName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OrxA4slbJV46vCSthBpsEDq8JK2EGmwQILx/vdk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GpwEjaQ6TDA=")[iii % 8])).ToArray()), dto.Domain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("frb7W9mJ80c6tpcUnsa9Ln62lxSexr0uZLbMBMM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xpa3NL7mnQ4=")[iii % 8])).ToArray()), dto.LogonId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("74nKbeZwQ02Lib8+oyIwJO+Jvz6jIjAk9YnkLv4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z6mfHoMCEAQ=")[iii % 8])).ToArray()), dto.UserSID);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LmazAMLTDWZ6L5EUwtIHZl4nkR7X3A0oNGaJRcs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dkbydba7aAg=")[iii % 8])).ToArray()), dto.AuthenticationPackage);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ik1/1IZh8vTTHVabwS68gIpNE5vBLryAkE1Ii5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qm0zu+EOnKA=")[iii % 8])).ToArray()), dto.LogonType);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UJkz6NIchhsZ1BqnlVPIb1CZX6eVU8hvSpkEt8g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cLl/h7Vz6E8=")[iii % 8])).ToArray()), dto.LogonTime);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4kZJyzCOTmSnFHPBJcEAF+JGJYR3wQAX+EZ+lCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wmYFpFfhIDc=")[iii % 8])).ToArray()), dto.LogonServer);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QuBRMgp1IvkHsms4H14C+SavcDwEdGyKWOBmbRA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YsAdXW0aTKo=")[iii % 8])).ToArray()), dto.LogonServerDnsDomain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uWpxMHEh/9rwJEcqZDLD5vgnQWM0c4+Io2pfc2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mUokQxRTr6g=")[iii % 8])).ToArray()), dto.UserPrincipalName);
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ZPdRweFA)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Random instance = new System.Random();
                        instance.Next(89, 94);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_7BDECA4F)result;
            if (dto.EnumerationMethod.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("jGXQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2yiZVqfwaFU=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2y+D4ZjKBoiwYsaUy49U5vEvg5TLj1Tm8TWDz9vS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0Q+jtOuvdMY=")[iii % 8])).ToArray()), dto.UserName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("c/N9+zU7He1z8xm0eHpUo3PzGbR4elSjafNCpCU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("U9M5lFhadIM=")[iii % 8])).ToArray()), dto.Domain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3p9FfAnj9t6anykzTqy4t96fKTNOrLi3xJ9yIxM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/r8JE26MmJc=")[iii % 8])).ToArray()), dto.LogonId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("wdHn9WjHhIyYgc66L4jK+MHRi7oviMr429HQqnI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4fGrmg+o6tg=")[iii % 8])).ToArray()), dto.LogonType);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("dIkJVZYSC5wgwCtBlhMBnATIK0uDHQvSbokzEJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VKlIIOJ6bvI=")[iii % 8])).ToArray()), dto.AuthenticationPackage);
                WriteLine($"  StartTime             : {dto.StartTime}");
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qEC9ahOD6JfhDotwBpDUq+kNjTlW0ZjFskCTKQs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iGDoGXbxuOU=")[iii % 8])).ToArray()), dto.UserPrincipalName);
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ggi55dyDJPXpRfyQj8Z2m6gIuZCPxnabqBK5y5+b").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iCiZsK/mVrs=")[iii % 8])).ToArray()), dto.UserName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OrxA4slbJV46vCSthBpsEDq8JK2EGmwQILx/vdk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GpwEjaQ6TDA=")[iii % 8])).ToArray()), dto.Domain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("frb7W9mJ80c6tpcUnsa9Ln62lxSexr0uZLbMBMM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xpa3NL7mnQ4=")[iii % 8])).ToArray()), dto.LogonId);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("74nKbeZwQ02Lib8+oyIwJO+Jvz6jIjAk9YnkLv4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("z6mfHoMCEAQ=")[iii % 8])).ToArray()), dto.UserSID);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LmazAMLTDWZ6L5EUwtIHZl4nkR7X3A0oNGaJRcs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dkbydba7aAg=")[iii % 8])).ToArray()), dto.AuthenticationPackage);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ik1/1IZh8vTTHVabwS68gIpNE5vBLryAkE1Ii5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qm0zu+EOnKA=")[iii % 8])).ToArray()), dto.LogonType);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UJkz6NIchhsZ1BqnlVPIb1CZX6eVU8hvSpkEt8g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cLl/h7Vz6E8=")[iii % 8])).ToArray()), dto.LogonTime);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4kZJyzCOTmSnFHPBJcEAF+JGJYR3wQAX+EZ+lCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wmYFpFfhIDc=")[iii % 8])).ToArray()), dto.LogonServer);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QuBRMgp1IvkHsms4H14C+SavcDwEdGyKWOBmbRA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YsAdXW0aTKo=")[iii % 8])).ToArray()), dto.LogonServerDnsDomain);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("uWpxMHEh/9rwJEcqZDLD5vgnQWM0c4+Io2pfc2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mUokQxRTr6g=")[iii % 8])).ToArray()), dto.UserPrincipalName);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string uxxDQFWP)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Random instance = new System.Random();
                    instance.Next(89, 94);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() || ThisRunTime.ISRemote())
        {
            var userDomainRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PqsoK7bJPf1S6m9j/YtOvheheGj3iSr2WA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("esRFSt+nAN8=")[iii % 8])).ToArray()));
            var logonIdRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("VBClcOpW0gc6V557rzaU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GH/CH4Qftjo=")[iii % 8])).ToArray()));
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("RFs0NvqqqDl7Rzo2+vnbdH5dMnnDx7J1BT4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CDRTWZSK+1w=")[iii % 8])).ToArray()));
            var logonMap = new Dictionary<string, string[]>();
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("noQiAnlcrcea2Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7OtNdiU/xKo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bmJ+Z1A9Nf0dYWBtXklCvlMUAH1fBnKwWEN9TEYacKU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PScyIhNpFdc=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (ManagementObject result in data)
            {
                var m = logonIdRegex.Match(result[Encoding.UTF8.GetString(Convert.FromBase64String("RrcATWQ68UV2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AtJwKApelCs=")[iii % 8])).ToArray())].ToString());
                if (!m.Success)
                {
                    continue;
                }

                var logonId = m.Groups[1].ToString();
                var m2 = userDomainRegex.Match(result[Encoding.UTF8.GetString(Convert.FromBase64String("NMp7IYKEVk8b0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("daQPROHhMio=")[iii % 8])).ToArray())].ToString());
                if (!m2.Success)
                {
                    continue;
                }

                var domain = m2.Groups[1].ToString();
                var user = m2.Groups[2].ToString();
                logonMap.Add(logonId, new[] { domain, user });
            }

            var wmiData2 = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("YU0f5PEOl2hlEA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EyJwkK1t/gU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("uiTT5AiGgV/JJ83uBvL2HIdSrf4HvcYahzL60ji7zhs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6WGfoUvSoXU=")[iii % 8])).ToArray()));
            var data2 = wmiData2.Get();
            foreach (var o in data2)
            {
                var result2 = (ManagementObject)o;
                var userDomain = new string[2]
                {
                    Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JMTadJqUCAc=")[iii % 8])).ToArray()),
                    Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9EgQEmg5kro=")[iii % 8])).ToArray())
                };
                try
                {
                    userDomain = logonMap[result2[Encoding.UTF8.GetString(Convert.FromBase64String("MbP2VOig5A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fdyRO4bpgFk=")[iii % 8])).ToArray())].ToString()];
                }
                catch
                {
                }

                var domain = userDomain[0];
                var userName = userDomain[1];
                var startTime = new DateTime();
                var logonType = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BF3d+YMS6m8=")[iii % 8])).ToArray());
                try
                {
                    startTime = ManagementDateTimeConverter.ToDateTime(result2[Encoding.UTF8.GetString(Convert.FromBase64String("TZGPaY7Fj0J7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HuXuG/qR5i8=")[iii % 8])).ToArray())].ToString());
                }
                catch
                {
                }

                try
                {
                    logonType = $"{(SECURITY_LOGON_TYPE)(int.Parse(result2[Encoding.UTF8.GetString(Convert.FromBase64String("K2AFo8wVM5oC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zw9izKJBSuo=")[iii % 8])).ToArray())].ToString()))}";
                }
                catch
                {
                }

                yield return new O_7BDECA4F(Encoding.UTF8.GetString(Convert.FromBase64String("F3D6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QD2zxYDb6NA=")[iii % 8])).ToArray()), userName, domain, result2[Encoding.UTF8.GetString(Convert.FromBase64String("/9B3amNNUg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s78QBQ0ENoE=")[iii % 8])).ToArray())].ToString(), logonType, result2[Encoding.UTF8.GetString(Convert.FromBase64String("E4nR1Us3mgoxndHUQTe+AjGXxNpL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UvylvS5Z7mM=")[iii % 8])).ToArray())].ToString(), startTime, null, null, null, null, null);
            }
        }
        else
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("etk1TCcPNJtFxTtMJ1xH1kDfMwMFfCbXPLw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NrZSI0kvZ/4=")[iii % 8])).ToArray()));
            var logonSessions = new List<O_7BDECA4F>();
            var systime = new DateTime(1601, 1, 1, 0, 0, 0, 0);
            var ret = LsaEnumerateLogonSessions(out var count, out var luidPtr);
            for (ulong i = 0; i < count; i++)
            {
                ret = LsaGetLogonSessionData(luidPtr, out var sessionData);
                var data = (SECURITY_LOGON_SESSION_DATA)Marshal.PtrToStructure(sessionData, typeof(SECURITY_LOGON_SESSION_DATA));
                if (data.PSiD != IntPtr.Zero)
                {
                    var username = Marshal.PtrToStringUni(data.Username.Buffer).Trim();
                    var sid = new System.Security.Principal.SecurityIdentifier(data.PSiD);
                    var domain = Marshal.PtrToStringUni(data.LoginDomain.Buffer).Trim();
                    var authpackage = Marshal.PtrToStringUni(data.AuthenticationPackage.Buffer).Trim();
                    var logonType = (SECURITY_LOGON_TYPE)data.LogonType;
                    var logonTime = systime.AddTicks((long)data.LoginTime);
                    var logonServer = Marshal.PtrToStringUni(data.LogonServer.Buffer).Trim();
                    var dnsDomainName = Marshal.PtrToStringUni(data.DnsDomainName.Buffer).Trim();
                    var upn = Marshal.PtrToStringUni(data.Upn.Buffer).Trim();
                    var logonID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5WHoCbtRg9o=")[iii % 8])).ToArray());
                    try
                    {
                        logonID = data.LoginID.LowPart.ToString();
                    }
                    catch
                    {
                    }

                    var userSID = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7WB4hJm9pag=")[iii % 8])).ToArray());
                    try
                    {
                        userSID = sid.Value;
                    }
                    catch
                    {
                    }

                    yield return new O_7BDECA4F(Encoding.UTF8.GetString(Convert.FromBase64String("Sv54").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bq058+78hQ0=")[iii % 8])).ToArray()), username, domain, logonID, logonType.ToString(), authpackage, null, logonTime, logonServer, dnsDomainName, upn, userSID);
                }

                luidPtr = (IntPtr)((long)luidPtr.ToInt64() + Marshal.SizeOf(typeof(LUID)));
                LsaFreeReturnBuffer(sessionData);
            }

            LsaFreeReturnBuffer(luidPtr);
        }
    }
}}