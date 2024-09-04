using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using static O_F41F88FA.Interop.Secur32;
using static O_F41F88FA.Interop.Advapi32;
using static O_F41F88FA.Interop.Kernel32;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    internal static class SecurityUtil
    {
        public static bool IsHighIntegrity()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static string[] GetTokenGroupSids()
        {
            var TokenInfLength = 0;
            var Result = GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenGroups, IntPtr.Zero, TokenInfLength, out TokenInfLength);
            var TokenInformation = Marshal.AllocHGlobal(TokenInfLength);
            Result = GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenGroups, TokenInformation, TokenInfLength, out TokenInfLength);
            if (!Result)
            {
                Marshal.FreeHGlobal(TokenInformation);
                throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("9uuCjxa9zQzMpYSIDviZF8jgjc0TtosXjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o4Xj7XrY7Xg=")[iii % 8])).ToArray()));
            }

            var groups = (TOKEN_GROUPS)Marshal.PtrToStructure(TokenInformation, typeof(TOKEN_GROUPS));
            var userSIDS = new string[groups.GroupCount];
            var sidAndAttrSize = Marshal.SizeOf(new SID_AND_ATTRIBUTES());
            for (var i = 0; i < groups.GroupCount; i++)
            {
                var sidAndAttributes = (SID_AND_ATTRIBUTES)Marshal.PtrToStructure(new IntPtr(TokenInformation.ToInt64() + i * sidAndAttrSize + IntPtr.Size), typeof(SID_AND_ATTRIBUTES));
                ConvertSidToStringSid(sidAndAttributes.Sid, out var sid);
                userSIDS[i] = sid;
            }

            Marshal.FreeHGlobal(TokenInformation);
            return userSIDS;
        }

        public static bool IsLocalAdmin()
        {
            return GetTokenGroupSids().Contains(Encoding.UTF8.GetString(Convert.FromBase64String("PM4cxarsmPRC1hnc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b+Mt6J/Bq8Y=")[iii % 8])).ToArray()));
        }

        [Flags]
        public enum GenericAceMask : uint
        {
            FileReadData = 0x00000001,
            FileWriteData = 0x00000002,
            FileAppendData = 0x00000004,
            FileReadEA = 0x00000008,
            FileWriteEA = 0x00000010,
            FileExecute = 0x00000020,
            FileDeleteChild = 0x00000040,
            FileReadAttributes = 0x00000080,
            FileWriteAttributes = 0x00000100,
            Delete = 0x00010000,
            ReadControl = 0x00020000,
            WriteDac = 0x00040000,
            WriteOwner = 0x00080000,
            Synchronize = 0x00100000,
            AccessSystemSecurity = 0x01000000,
            MaximumAllowed = 0x02000000,
            GenericAll = 0x10000000,
            GenericExecute = 0x20000000,
            GenericWrite = 0x40000000,
            GenericRead = 0x80000000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_INFOS
        {
            public string Owner;
            public RawSecurityDescriptor SecurityDescriptor;
            public string SDDL;
        }

        public static SECURITY_INFOS GetSecurityInfos(string ObjectName, SE_OBJECT_TYPE ObjectType)
        {
            var pSidOwner = IntPtr.Zero;
            var pSidGroup = IntPtr.Zero;
            var pDacl = IntPtr.Zero;
            var pSacl = IntPtr.Zero;
            var pSecurityDescriptor = IntPtr.Zero;
            var info = SecurityInfos.DiscretionaryAcl | SecurityInfos.Owner;
            var infos = new SECURITY_INFOS();
            var errorReturn = GetNamedSecurityInfo(ObjectName, ObjectType, info, out pSidOwner, out pSidGroup, out pDacl, out pSacl, out pSecurityDescriptor);
            if (errorReturn != 0)
            {
                return infos;
            }

            if (ConvertSecurityDescriptorToStringSecurityDescriptor(pSecurityDescriptor, 1, SecurityInfos.DiscretionaryAcl | SecurityInfos.Owner, out var pSddlString, out _))
            {
                infos.SDDL = Marshal.PtrToStringUni(pSddlString) ?? string.Empty;
            }

            var ownerSid = new SecurityIdentifier(pSidOwner);
            infos.Owner = ownerSid.Value;
            if (pSddlString != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pSddlString);
            }

            if (pSecurityDescriptor != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pSecurityDescriptor);
            }

            return infos;
        }

        public static bool IsHighIntegrity(string nMrSWMnH)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(75);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static string[] GetTokenGroupSids(string QnIJRoiK)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(75);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var TokenInfLength = 0;
            var Result = GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenGroups, IntPtr.Zero, TokenInfLength, out TokenInfLength);
            var TokenInformation = Marshal.AllocHGlobal(TokenInfLength);
            Result = GetTokenInformation(WindowsIdentity.GetCurrent().Token, TOKEN_INFORMATION_CLASS.TokenGroups, TokenInformation, TokenInfLength, out TokenInfLength);
            if (!Result)
            {
                Marshal.FreeHGlobal(TokenInformation);
                throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("9uuCjxa9zQzMpYSIDviZF8jgjc0TtosXjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o4Xj7XrY7Xg=")[iii % 8])).ToArray()));
            }

            var groups = (TOKEN_GROUPS)Marshal.PtrToStructure(TokenInformation, typeof(TOKEN_GROUPS));
            var userSIDS = new string[groups.GroupCount];
            var sidAndAttrSize = Marshal.SizeOf(new SID_AND_ATTRIBUTES());
            for (var i = 0; i < groups.GroupCount; i++)
            {
                var sidAndAttributes = (SID_AND_ATTRIBUTES)Marshal.PtrToStructure(new IntPtr(TokenInformation.ToInt64() + i * sidAndAttrSize + IntPtr.Size), typeof(SID_AND_ATTRIBUTES));
                ConvertSidToStringSid(sidAndAttributes.Sid, out var sid);
                userSIDS[i] = sid;
            }

            Marshal.FreeHGlobal(TokenInformation);
            return userSIDS;
        }

        public static bool IsLocalAdmin(string GAfeTQcm)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                        instance.SubstringByTextElements(75);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return GetTokenGroupSids().Contains(Encoding.UTF8.GetString(Convert.FromBase64String("PM4cxarsmPRC1hnc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b+Mt6J/Bq8Y=")[iii % 8])).ToArray()));
        }

        public static SECURITY_INFOS GetSecurityInfos(string ObjectName, SE_OBJECT_TYPE ObjectType, string XSTGlifC)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.WriteByte(150);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var pSidOwner = IntPtr.Zero;
            var pSidGroup = IntPtr.Zero;
            var pDacl = IntPtr.Zero;
            var pSacl = IntPtr.Zero;
            var pSecurityDescriptor = IntPtr.Zero;
            var info = SecurityInfos.DiscretionaryAcl | SecurityInfos.Owner;
            var infos = new SECURITY_INFOS();
            var errorReturn = GetNamedSecurityInfo(ObjectName, ObjectType, info, out pSidOwner, out pSidGroup, out pDacl, out pSacl, out pSecurityDescriptor);
            if (errorReturn != 0)
            {
                return infos;
            }

            if (ConvertSecurityDescriptorToStringSecurityDescriptor(pSecurityDescriptor, 1, SecurityInfos.DiscretionaryAcl | SecurityInfos.Owner, out var pSddlString, out _))
            {
                infos.SDDL = Marshal.PtrToStringUni(pSddlString) ?? string.Empty;
            }

            var ownerSid = new SecurityIdentifier(pSidOwner);
            infos.Owner = ownerSid.Value;
            if (pSddlString != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pSddlString);
            }

            if (pSecurityDescriptor != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pSecurityDescriptor);
            }

            return infos;
        }
    }
}