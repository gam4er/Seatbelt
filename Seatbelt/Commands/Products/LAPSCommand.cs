using System.Collections.Generic;
using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_87DF1B5C : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Y8YOyA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L4demwK7A6o=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("AUJCrLGFe/w5anyY4to+4Ssje5Hign/kIWZ2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TQMS/5H2Hog=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_87DF1B5C(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var AdmPwdEnabled = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("yGxbLpKPBWTHU1I2jI0eZOhfcDOGnBhy9GVJeraLBXfyYFgpua8TbMt0WQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mwM9WuXudwE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zJS1WaRLXLXskrRstw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jfDYCdMvGds=")[iii % 8])).ToArray()));
        if (AdmPwdEnabled != null && !AdmPwdEnabled.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PcgxHi704FQ=")[iii % 8])).ToArray())))
        {
            var LAPSAdminAccountName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("aXzUC2DGjTZmQ90TfsSWNklP/xZ01ZAgVXXGX0TCjSVTcNcMS+abPmpk1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OhOyfxen/1M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9WJrwRtSnA7bc2jcO3KSCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tAYGqHUT/20=")[iii % 8])).ToArray()));
            var LAPSPasswordComplexity = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("P5MVsIaceDEwrByomJ5jMR+gPq2Sj2UnA5oH5KKYeCIFnxa3rbxuOTyLFw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bPxzxPH9ClQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zTJbct/Lmd/ePEVxxMGT0ukq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nVMoAaik67s=")[iii % 8])).ToArray()));
            var LAPSPasswordLength = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("OBQM/lnERkU3KwXmR8ZdRRgnJ+NN11tTBB0eqn3ARlYCGA/5cuRQTTsMDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a3tqii6lNCA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zgl2pzsp3qzSDWuzOC4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nmgF1ExGrMg=")[iii % 8])).ToArray()));
            var LAPSPwdExpirationProtectionEnabled = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("oiXetZ7a1/CtGtetgNjM8IIW9aiKycrmnizM4bre1+OYKd2ytfrB+KE93A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8Uq4wem7pZU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("C3ZN3KXixAs6dUD2s8LfFi9kSu20/cM8NWBL9bj2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WwEpmd2SrXk=")[iii % 8])).ToArray()));
            yield return new O_9D30096A((AdmPwdEnabled == Encoding.UTF8.GetString(Convert.FromBase64String("qw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mhdlTMNCr+o=")[iii % 8])).ToArray())), LAPSAdminAccountName, LAPSPasswordComplexity, LAPSPasswordLength, LAPSPwdExpirationProtectionEnabled);
        }
        else
        {
            yield return new O_9D30096A(admPwdEnabled: false, lapsAdminAccountName: null, lapsPasswordComplexity: null, lapsPasswordLength: null, lapsPwdExpirationProtectionEnabled: null);
        }
    }

class O_9D30096A : O_4AED570F
{
    public O_9D30096A(bool admPwdEnabled, string? lapsAdminAccountName, string? lapsPasswordComplexity, string? lapsPasswordLength, string? lapsPwdExpirationProtectionEnabled)
    {
        AdmPwdEnabled = admPwdEnabled;
        LAPSAdminAccountName = lapsAdminAccountName;
        LAPSPasswordComplexity = lapsPasswordComplexity;
        LAPSPasswordLength = lapsPasswordLength;
        LapsPwdExpirationProtectionEnabled = lapsPwdExpirationProtectionEnabled;
    }

    public bool AdmPwdEnabled { get; }
    public string? LAPSAdminAccountName { get; }
    public string? LAPSPasswordComplexity { get; }
    public string? LAPSPasswordLength { get; }
    public string? LapsPwdExpirationProtectionEnabled { get; }
}    [CommandOutputType(typeof(O_9D30096A))]
    internal class O_72661E32 : TextFormatterBase
    {
        public O_72661E32(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_9D30096A)result;
            if (dto.AdmPwdEnabled.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("Z3ZpWLE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ARcFK9TYy60=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hREixwbxRTH1YlmDNKUpGctCDYw3vWwU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pTF57VvRCXA=")[iii % 8])).ToArray()));
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z/lOkOFnyHiS+Q+AtnuG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("79k1oM1K+08=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MJyVHJy2fVoesaAr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fN3FT7zzEzs=")[iii % 8])).ToArray()), dto.AdmPwdEnabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Wf69/MGHb/kE/vzslpsh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ed7GzO2qXM4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PBh7SjuTnSAZNwtYeLGWOB4tC1d6v5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cFkrGRvS+U0=")[iii % 8])).ToArray()), dto.LAPSAdminAccountName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vbMVU9MIP4Dgs1RDhBRx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZNuY/8lDLc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("AwhiI5uIYxY8Pl0C3/hBCiI5XhXDsXYc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T0kycLvYAmU=")[iii % 8])).ToArray()), dto.LAPSPasswordComplexity);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KX3pV6O/ArV0fahH9KNM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CV2SZ4+SMYI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("LuEjnJap4u0R1xy90tnP+wzHB6c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YqBzz7b5g54=")[iii % 8])).ToArray()), dto.LAPSPasswordLength);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hvGUH8ZhA/Db8dUPkX1N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ptHvL+pMMMc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("nG0cXWbrGvK5Xi16L8EMooBeI3ojzRbrv0JsSyjPAO61SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0CxMDkauYoI=")[iii % 8])).ToArray()), dto.LapsPwdExpirationProtectionEnabled);
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string qWtwPRkP)
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

            var dto = (O_9D30096A)result;
            if (dto.AdmPwdEnabled.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("Z3ZpWLE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ARcFK9TYy60=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hREixwbxRTH1YlmDNKUpGctCDYw3vWwU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pTF57VvRCXA=")[iii % 8])).ToArray()));
            }
            else
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("z/lOkOFnyHiS+Q+AtnuG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("79k1oM1K+08=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MJyVHJy2fVoesaAr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fN3FT7zzEzs=")[iii % 8])).ToArray()), dto.AdmPwdEnabled);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Wf69/MGHb/kE/vzslpsh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ed7GzO2qXM4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("PBh7SjuTnSAZNwtYeLGWOB4tC1d6v5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cFkrGRvS+U0=")[iii % 8])).ToArray()), dto.LAPSAdminAccountName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vbMVU9MIP4Dgs1RDhBRx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZNuY/8lDLc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("AwhiI5uIYxY8Pl0C3/hBCiI5XhXDsXYc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T0kycLvYAmU=")[iii % 8])).ToArray()), dto.LAPSPasswordComplexity);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KX3pV6O/ArV0fahH9KNM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CV2SZ4+SMYI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("LuEjnJap4u0R1xy90tnP+wzHB6c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YqBzz7b5g54=")[iii % 8])).ToArray()), dto.LAPSPasswordLength);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hvGUH8ZhA/Db8dUPkX1N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ptHvL+pMMMc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("nG0cXWbrGvK5Xi16L8EMooBeI3ojzRbrv0JsSyjPAO61SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0CxMDkauYoI=")[iii % 8])).ToArray()), dto.LapsPwdExpirationProtectionEnabled);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string anfqRwhK)
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

        var AdmPwdEnabled = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("yGxbLpKPBWTHU1I2jI0eZOhfcDOGnBhy9GVJeraLBXfyYFgpua8TbMt0WQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mwM9WuXudwE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zJS1WaRLXLXskrRstw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jfDYCdMvGds=")[iii % 8])).ToArray()));
        if (AdmPwdEnabled != null && !AdmPwdEnabled.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PcgxHi704FQ=")[iii % 8])).ToArray())))
        {
            var LAPSAdminAccountName = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("aXzUC2DGjTZmQ90TfsSWNklP/xZ01ZAgVXXGX0TCjSVTcNcMS+abPmpk1g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OhOyfxen/1M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9WJrwRtSnA7bc2jcO3KSCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tAYGqHUT/20=")[iii % 8])).ToArray()));
            var LAPSPasswordComplexity = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("P5MVsIaceDEwrByomJ5jMR+gPq2Sj2UnA5oH5KKYeCIFnxa3rbxuOTyLFw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bPxzxPH9ClQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zTJbct/Lmd/ePEVxxMGT0ukq").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nVMoAaik67s=")[iii % 8])).ToArray()));
            var LAPSPasswordLength = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("OBQM/lnERkU3KwXmR8ZdRRgnJ+NN11tTBB0eqn3ARlYCGA/5cuRQTTsMDg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a3tqii6lNCA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("zgl2pzsp3qzSDWuzOC4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nmgF1ExGrMg=")[iii % 8])).ToArray()));
            var LAPSPwdExpirationProtectionEnabled = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("oiXetZ7a1/CtGtetgNjM8IIW9aiKycrmnizM4bre1+OYKd2ytfrB+KE93A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8Uq4wem7pZU=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("C3ZN3KXixAs6dUD2s8LfFi9kSu20/cM8NWBL9bj2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WwEpmd2SrXk=")[iii % 8])).ToArray()));
            yield return new O_9D30096A((AdmPwdEnabled == Encoding.UTF8.GetString(Convert.FromBase64String("qw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mhdlTMNCr+o=")[iii % 8])).ToArray())), LAPSAdminAccountName, LAPSPasswordComplexity, LAPSPasswordLength, LAPSPwdExpirationProtectionEnabled);
        }
        else
        {
            yield return new O_9D30096A(admPwdEnabled: false, lapsAdminAccountName: null, lapsPasswordComplexity: null, lapsPasswordLength: null, lapsPwdExpirationProtectionEnabled: null);
        }
    }
}}