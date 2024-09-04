using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using static O_F41F88FA.Interop.O_B81255AD;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_77C85217 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("snwD2wsixA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0wZ2qW5DoGw=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("xu+RZ2ypderu/5d3X4N1wvrsig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lIrlEh7HVas=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public Runtime ThisRunTime;
    public O_77C85217(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        bool? sssoDomainTrusted = null;
        var sssoDomainTrustedValue = ThisRunTime.GetDwordValue(RegistryHive.CurrentUser, Encoding.UTF8.GetString(Convert.FromBase64String("eRdxW+y47OJ2NX5M6bbt6EwMS3jyt/roXQtLbO6r7OJEDEFK6ar36EQkXkHvvOzpTww3fP6t6u5EH2Rzwbbw4mcZZ3PftvPmQxZkc/aw/fVFC3hJ77jk8lgddku2qu3oBBt4Qse46/NFFHhI9Lc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KngXL5vZnoc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("EnESC6o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("egVme9kzQU0=")[iii % 8])).ToArray()));
        if (sssoDomainTrustedValue != null)
        {
            switch (sssoDomainTrustedValue)
            {
                case 0:
                    sssoDomainTrusted = false;
                    break;
                case 1:
                    sssoDomainTrusted = true;
                    break;
                default:
                    sssoDomainTrusted = false;
                    break;
            }
        }

        var netAadJoinInfo = GetNetAadInfo();
        yield return new O_EF541EF3(netAadJoinInfo, sssoDomainTrusted);
    }

    private NetAadJoinInfo? GetNetAadInfo()
    {
        var tenantId = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UzMv/74IUE=")[iii % 8])).ToArray());
        var retValue = NetGetAadJoinInformation(tenantId, out var ptrJoinInfo);
        if (retValue == 0)
        {
            var joinInfo = (DSREG_JOIN_INFO)Marshal.PtrToStructure(ptrJoinInfo, typeof(DSREG_JOIN_INFO));
            var JType = (NetAadJoinInfo.JoinType)joinInfo.joinType;
            var did = new Guid(joinInfo.DeviceId);
            var tid = new Guid(joinInfo.TenantId);
            var data = Convert.FromBase64String(joinInfo.UserSettingSyncUrl);
            var UserSettingSyncUrl = Encoding.ASCII.GetString(data);
            var ptrUserInfo = joinInfo.pUserInfo;
            DSREG_USER_INFO? userInfo = null;
            var cresult = new List<X509Certificate2>();
            Guid? uid = null;
            if (ptrUserInfo != IntPtr.Zero)
            {
                userInfo = (DSREG_USER_INFO)Marshal.PtrToStructure(ptrUserInfo, typeof(DSREG_USER_INFO));
                uid = new Guid(userInfo?.UserKeyId);
                var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);
                foreach (var certificate in store.Certificates)
                {
                    if (certificate.Subject.Equals($"CN={did}"))
                    {
                        cresult.Add(certificate);
                    }
                }

                Marshal.Release(ptrUserInfo);
            }

            Marshal.Release(ptrJoinInfo);
            NetFreeAadJoinInformation(ptrJoinInfo);
            return new NetAadJoinInfo(JType, did, joinInfo.IdpDomain, tid, joinInfo.JoinUserEmail, joinInfo.TenantDisplayName, joinInfo.MdmEnrollmentUrl, joinInfo.MdmTermsOfUseUrl, joinInfo.MdmComplianceUrl, UserSettingSyncUrl, cresult, userInfo?.UserEmail, uid, userInfo?.UserKeyName);
        }

        return null;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string eFijOSZo)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(true);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        bool? sssoDomainTrusted = null;
        var sssoDomainTrustedValue = ThisRunTime.GetDwordValue(RegistryHive.CurrentUser, Encoding.UTF8.GetString(Convert.FromBase64String("eRdxW+y47OJ2NX5M6bbt6EwMS3jyt/roXQtLbO6r7OJEDEFK6ar36EQkXkHvvOzpTww3fP6t6u5EH2Rzwbbw4mcZZ3PftvPmQxZkc/aw/fVFC3hJ77jk8lgddku2qu3oBBt4Qse46/NFFHhI9Lc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KngXL5vZnoc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("EnESC6o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("egVme9kzQU0=")[iii % 8])).ToArray()));
        if (sssoDomainTrustedValue != null)
        {
            switch (sssoDomainTrustedValue)
            {
                case 0:
                    sssoDomainTrusted = false;
                    break;
                case 1:
                    sssoDomainTrusted = true;
                    break;
                default:
                    sssoDomainTrusted = false;
                    break;
            }
        }

        var netAadJoinInfo = GetNetAadInfo();
        yield return new O_EF541EF3(netAadJoinInfo, sssoDomainTrusted);
    }

    private NetAadJoinInfo? GetNetAadInfo(string UKEAEMwK)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(true);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var tenantId = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UzMv/74IUE=")[iii % 8])).ToArray());
        var retValue = NetGetAadJoinInformation(tenantId, out var ptrJoinInfo);
        if (retValue == 0)
        {
            var joinInfo = (DSREG_JOIN_INFO)Marshal.PtrToStructure(ptrJoinInfo, typeof(DSREG_JOIN_INFO));
            var JType = (NetAadJoinInfo.JoinType)joinInfo.joinType;
            var did = new Guid(joinInfo.DeviceId);
            var tid = new Guid(joinInfo.TenantId);
            var data = Convert.FromBase64String(joinInfo.UserSettingSyncUrl);
            var UserSettingSyncUrl = Encoding.ASCII.GetString(data);
            var ptrUserInfo = joinInfo.pUserInfo;
            DSREG_USER_INFO? userInfo = null;
            var cresult = new List<X509Certificate2>();
            Guid? uid = null;
            if (ptrUserInfo != IntPtr.Zero)
            {
                userInfo = (DSREG_USER_INFO)Marshal.PtrToStructure(ptrUserInfo, typeof(DSREG_USER_INFO));
                uid = new Guid(userInfo?.UserKeyId);
                var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly);
                foreach (var certificate in store.Certificates)
                {
                    if (certificate.Subject.Equals($"CN={did}"))
                    {
                        cresult.Add(certificate);
                    }
                }

                Marshal.Release(ptrUserInfo);
            }

            Marshal.Release(ptrJoinInfo);
            NetFreeAadJoinInformation(ptrJoinInfo);
            return new NetAadJoinInfo(JType, did, joinInfo.IdpDomain, tid, joinInfo.JoinUserEmail, joinInfo.TenantDisplayName, joinInfo.MdmEnrollmentUrl, joinInfo.MdmTermsOfUseUrl, joinInfo.MdmComplianceUrl, UserSettingSyncUrl, cresult, userInfo?.UserEmail, uid, userInfo?.UserKeyName);
        }

        return null;
    }
}internal class O_EF541EF3 : O_4AED570F
{
    public O_EF541EF3(NetAadJoinInfo? netAadJoinInfo, bool? seamlessSignOnDomainTrusted)
    {
        SeamlessSignOnDomainTrusted = seamlessSignOnDomainTrusted;
        NetAadJoinInfo = netAadJoinInfo;
    }

    public bool? SeamlessSignOnDomainTrusted { get; }
    public NetAadJoinInfo? NetAadJoinInfo { get; }
}
    internal class NetAadJoinInfo
    {
        public NetAadJoinInfo(JoinType jType, Guid deviceId, string idpDomain, Guid tenantId, string joinUserEmail, string tenantDisplayName, string mdmEnrollmentUrl, string mdmTermsOfUseUrl, string mdmComplianceUrl, string userSettingSyncUrl, List<X509Certificate2> certInfo, string? userEmail, Guid? userKeyId, string? userKeyname)
        {
            JType = jType;
            DeviceId = deviceId;
            IdpDomain = idpDomain;
            TenantId = tenantId;
            JoinUserEmail = joinUserEmail;
            TenantDisplayName = tenantDisplayName;
            MdmEnrollmentUrl = mdmEnrollmentUrl;
            MdmTermsOfUseUrl = mdmTermsOfUseUrl;
            MdmComplianceUrl = mdmComplianceUrl;
            UserSettingSyncUrl = userSettingSyncUrl;
            CertInfo = certInfo;
            UserEmail = userEmail;
            UserKeyId = userKeyId;
            UserKeyname = userKeyname;
        }

        public enum JoinType
        {
            DSREG_UNKNOWN_JOIN,
            DSREG_DEVICE_JOIN,
            DSREG_WORKPLACE_JOIN,
            DSREG_NO_JOIN
        }

        public JoinType JType { get; }
        public Guid DeviceId { get; }
        public string IdpDomain { get; }
        public Guid TenantId { get; }
        public string JoinUserEmail { get; }
        public string TenantDisplayName { get; }
        public string MdmEnrollmentUrl { get; }
        public string MdmTermsOfUseUrl { get; }
        public string MdmComplianceUrl { get; }
        public string UserSettingSyncUrl { get; }
        public List<X509Certificate2> CertInfo { get; }
        public string? UserEmail { get; }
        public Guid? UserKeyId { get; }
        public string? UserKeyname { get; }
    }

    [CommandOutputType(typeof(O_EF541EF3))]
    internal class O_5372F895 : TextFormatterBase
    {
        public O_5372F895(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_EF541EF3)result;
            var netAadInfo = dto.NetAadJoinInfo;
            if (netAadInfo == null)
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yAuLpGrp8bSMC8XrXabhtp1GzvZI8uH4pk7fxUjizreBReLqT+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CurhCmGhNg=")[iii % 8])).ToArray()));
            else
            {
                WriteLine($"    TenantDisplayName           : {netAadInfo.TenantDisplayName}");
                WriteLine($"    TenantId                    : {netAadInfo.TenantId}");
                WriteLine($"    IdpDomain                   : {netAadInfo.IdpDomain}");
                WriteLine($"    MdmEnrollmentUrl            : {netAadInfo.MdmEnrollmentUrl}");
                WriteLine($"    MdmTermsOfUseUrl            : {netAadInfo.MdmTermsOfUseUrl}");
                WriteLine($"    MdmComplianceUrl            : {netAadInfo.MdmComplianceUrl}");
                WriteLine($"    UserSettingSyncUrl          : {netAadInfo.UserSettingSyncUrl}");
                WriteLine($"    DeviceId                    : {netAadInfo.DeviceId}");
                WriteLine($"    JoinType                    : {netAadInfo.JType}");
                WriteLine($"    JoinUserEmail               : {netAadInfo.JoinUserEmail}");
                WriteLine($"    UserKeyId                   : {netAadInfo.UserKeyId}");
                WriteLine($"    UserEmail                   : {netAadInfo.UserEmail}");
                WriteLine($"    UserKeyname                 : {netAadInfo.UserKeyname}\n");
                foreach (var cert in netAadInfo.CertInfo)
                {
                    WriteLine($"    Thumbprint  : {cert.Thumbprint}");
                    WriteLine($"    Subject     : {cert.Subject}");
                    WriteLine($"    Issuer      : {cert.Issuer}");
                    WriteLine($"    Expiration  : {cert.GetExpirationDateString()}");
                }
            }

            var sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tpadaBNayqQ=")[iii % 8])).ToArray());
            if (dto.SeamlessSignOnDomainTrusted == true)
                sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("NWW937AqL1o9d6LLryMLbW4ElMOlIUNxcwSqy7tvDHs9QanLoCMLejwN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HSTHqsJPbh4=")[iii % 8])).ToArray());
            else
                sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("Q7sS6aU96s4NvBro9zvhiQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a9V9nYVehaA=")[iii % 8])).ToArray());
            WriteLine($"    SeamlessSignOnDomainTrusted : {dto.SeamlessSignOnDomainTrusted}{sssoMsg}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string kmTIkvIb)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.ReaderWriterLock instance = new System.Threading.ReaderWriterLock();
                        instance.UpgradeToWriterLock(new System.TimeSpan());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_EF541EF3)result;
            var netAadInfo = dto.NetAadJoinInfo;
            if (netAadInfo == null)
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("yAuLpGrp8bSMC8XrXabhtp1GzvZI8uH4pk7fxUjizreBReLqT+k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CurhCmGhNg=")[iii % 8])).ToArray()));
            else
            {
                WriteLine($"    TenantDisplayName           : {netAadInfo.TenantDisplayName}");
                WriteLine($"    TenantId                    : {netAadInfo.TenantId}");
                WriteLine($"    IdpDomain                   : {netAadInfo.IdpDomain}");
                WriteLine($"    MdmEnrollmentUrl            : {netAadInfo.MdmEnrollmentUrl}");
                WriteLine($"    MdmTermsOfUseUrl            : {netAadInfo.MdmTermsOfUseUrl}");
                WriteLine($"    MdmComplianceUrl            : {netAadInfo.MdmComplianceUrl}");
                WriteLine($"    UserSettingSyncUrl          : {netAadInfo.UserSettingSyncUrl}");
                WriteLine($"    DeviceId                    : {netAadInfo.DeviceId}");
                WriteLine($"    JoinType                    : {netAadInfo.JType}");
                WriteLine($"    JoinUserEmail               : {netAadInfo.JoinUserEmail}");
                WriteLine($"    UserKeyId                   : {netAadInfo.UserKeyId}");
                WriteLine($"    UserEmail                   : {netAadInfo.UserEmail}");
                WriteLine($"    UserKeyname                 : {netAadInfo.UserKeyname}\n");
                foreach (var cert in netAadInfo.CertInfo)
                {
                    WriteLine($"    Thumbprint  : {cert.Thumbprint}");
                    WriteLine($"    Subject     : {cert.Subject}");
                    WriteLine($"    Issuer      : {cert.Issuer}");
                    WriteLine($"    Expiration  : {cert.GetExpirationDateString()}");
                }
            }

            var sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tpadaBNayqQ=")[iii % 8])).ToArray());
            if (dto.SeamlessSignOnDomainTrusted == true)
                sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("NWW937AqL1o9d6LLryMLbW4ElMOlIUNxcwSqy7tvDHs9QanLoCMLejwN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HSTHqsJPbh4=")[iii % 8])).ToArray());
            else
                sssoMsg = Encoding.UTF8.GetString(Convert.FromBase64String("Q7sS6aU96s4NvBro9zvhiQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a9V9nYVehaA=")[iii % 8])).ToArray());
            WriteLine($"    SeamlessSignOnDomainTrusted : {dto.SeamlessSignOnDomainTrusted}{sssoMsg}");
        }
    }
}