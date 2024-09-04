using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static O_F41F88FA.Interop.Advapi32;
using static O_F41F88FA.Interop.Secur32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_3689D5C3 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("7hGOisNq6+nMF4mKyl/q").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("un7l7606mYA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("DiHbjkNMeUg0dMySR0BhQSl03ZNNR2MEPSbAik9OaEMoJ4nUQwxqCm0HzLhDQHhDHSbAik9OaEMoe8yIRQwk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TVSp/CYiDSQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_3689D5C3(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("d7twN2Fcb0pgoWkgahVoSmS8azNtXn4NUb0I").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NM4CRQQyG2o=")[iii % 8])).ToArray()));
        var TokenInfLength = 0;
        var ThisHandle = WindowsIdentity.GetCurrent().Token;
        GetTokenInformation(ThisHandle, TOKEN_INFORMATION_CLASS.TokenPrivileges, IntPtr.Zero, TokenInfLength, out TokenInfLength);
        var TokenInformation = Marshal.AllocHGlobal(TokenInfLength);
        if (GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenPrivileges, TokenInformation, TokenInfLength, out TokenInfLength))
        {
            var ThisPrivilegeSet = (TOKEN_PRIVILEGES)Marshal.PtrToStructure(TokenInformation, typeof(TOKEN_PRIVILEGES));
            for (var index = 0; index < ThisPrivilegeSet.PrivilegeCount; index++)
            {
                var laa = ThisPrivilegeSet.Privileges[index];
                var StrBuilder = new System.Text.StringBuilder();
                var luidNameLen = 0;
                var luidPointer = Marshal.AllocHGlobal(Marshal.SizeOf(laa.Luid));
                Marshal.StructureToPtr(laa.Luid, luidPointer, true);
                LookupPrivilegeName(null, luidPointer, null, ref luidNameLen);
                StrBuilder.EnsureCapacity(luidNameLen + 1);
                if (LookupPrivilegeName(null, luidPointer, StrBuilder, ref luidNameLen))
                {
                    var strPrivilege = StrBuilder.ToString();
                    var strAttributes = String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("jx2n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9C3aci6op2Q=")[iii % 8])).ToArray()), (LuidAttributes)laa.Attributes);
                    Marshal.FreeHGlobal(luidPointer);
                    yield return new O_66C1A868(strPrivilege, strAttributes);
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string DNXHBIWF)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.ToFourDigitYear(7);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("d7twN2Fcb0pgoWkgahVoSmS8azNtXn4NUb0I").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NM4CRQQyG2o=")[iii % 8])).ToArray()));
        var TokenInfLength = 0;
        var ThisHandle = WindowsIdentity.GetCurrent().Token;
        GetTokenInformation(ThisHandle, TOKEN_INFORMATION_CLASS.TokenPrivileges, IntPtr.Zero, TokenInfLength, out TokenInfLength);
        var TokenInformation = Marshal.AllocHGlobal(TokenInfLength);
        if (GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenPrivileges, TokenInformation, TokenInfLength, out TokenInfLength))
        {
            var ThisPrivilegeSet = (TOKEN_PRIVILEGES)Marshal.PtrToStructure(TokenInformation, typeof(TOKEN_PRIVILEGES));
            for (var index = 0; index < ThisPrivilegeSet.PrivilegeCount; index++)
            {
                var laa = ThisPrivilegeSet.Privileges[index];
                var StrBuilder = new System.Text.StringBuilder();
                var luidNameLen = 0;
                var luidPointer = Marshal.AllocHGlobal(Marshal.SizeOf(laa.Luid));
                Marshal.StructureToPtr(laa.Luid, luidPointer, true);
                LookupPrivilegeName(null, luidPointer, null, ref luidNameLen);
                StrBuilder.EnsureCapacity(luidNameLen + 1);
                if (LookupPrivilegeName(null, luidPointer, StrBuilder, ref luidNameLen))
                {
                    var strPrivilege = StrBuilder.ToString();
                    var strAttributes = String.Format(Encoding.UTF8.GetString(Convert.FromBase64String("jx2n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9C3aci6op2Q=")[iii % 8])).ToArray()), (LuidAttributes)laa.Attributes);
                    Marshal.FreeHGlobal(luidPointer);
                    yield return new O_66C1A868(strPrivilege, strAttributes);
                }
            }
        }
    }
}internal class O_66C1A868 : O_4AED570F
{
    public O_66C1A868(string privilege, string attributes)
    {
        Privilege = privilege;
        Attributes = attributes;
    }

    public string Privilege { get; set; }
    public string Attributes { get; set; }
}
    [CommandOutputType(typeof(O_66C1A868))]
    internal class O_7424B4F4 : TextFormatterBase
    {
        public O_7424B4F4(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_66C1A868)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qItGfvMqLDeyix017mM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKs9Tt8eH0o=")[iii % 8])).ToArray()), dto.Privilege, dto.Attributes);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string sqnxzVjM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                        instance.ToFourDigitYear(7);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_66C1A868)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qItGfvMqLDeyix017mM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKs9Tt8eH0o=")[iii % 8])).ToArray()), dto.Privilege, dto.Attributes);
        }
    }
}