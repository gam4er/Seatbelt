using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static O_F41F88FA.Interop.Advapi32;
using static O_F41F88FA.Interop.O_B81255AD;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    internal class O_41CA9BAE : IDisposable
    {
        enum Access : int
        {
            POLICY_READ = 0x20006,
            POLICY_ALL_ACCESS = 0x00F0FFF,
            POLICY_EXECUTE = 0X20801,
            POLICY_WRITE = 0X207F8
        }

        const uint STATUS_ACCESS_DENIED = 0xc0000022;
        const uint STATUS_INSUFFICIENT_RESOURCES = 0xc000009a;
        const uint STATUS_NO_MEMORY = 0xc0000017;
        const uint STATUS_NO_MORE_ENTRIES = 0xc000001A;
        const uint ERROR_NO_MORE_ITEMS = 2147483674;
        const uint ERROR_PRIVILEGE_DOES_NOT_EXIST = 3221225568;
        IntPtr lsaHandle;
        public O_41CA9BAE() : this(Environment.MachineName)
        {
        }

        public O_41CA9BAE(string MachineName)
        {
            LSA_OBJECT_ATTRIBUTES lsaAttr;
            lsaAttr.RootDirectory = IntPtr.Zero;
            lsaAttr.ObjectName = IntPtr.Zero;
            lsaAttr.Attributes = 0;
            lsaAttr.SecurityDescriptor = IntPtr.Zero;
            lsaAttr.SecurityQualityOfService = IntPtr.Zero;
            lsaAttr.Length = Marshal.SizeOf(typeof(LSA_OBJECT_ATTRIBUTES));
            lsaHandle = IntPtr.Zero;
            LSA_UNICODE_STRING[]? system = null;
            if (MachineName != null)
            {
                system = new LSA_UNICODE_STRING[1];
                system[0] = InitLsaString(MachineName);
            }

            var ret = LsaOpenPolicy(system, ref lsaAttr, (int)Access.POLICY_ALL_ACCESS, out lsaHandle);
            TestReturnValue(ret);
        }

        public List<Principal> ReadPrivilege(string Privilege)
        {
            var privileges = new LSA_UNICODE_STRING[1];
            privileges[0] = InitLsaString(Privilege);
            var ret = LsaEnumerateAccountsWithUserRight(lsaHandle, privileges, out var buffer, out var count);
            var Accounts = new List<Principal>();
            if (ret == 0)
            {
                var LsaInfo = new LSA_ENUMERATION_INFORMATION[count];
                var elemOffs = buffer;
                for (var i = 0; i < count; i++)
                {
                    LsaInfo[i] = (LSA_ENUMERATION_INFORMATION)Marshal.PtrToStructure((IntPtr)elemOffs, typeof(LSA_ENUMERATION_INFORMATION));
                    elemOffs = (IntPtr)(elemOffs.ToInt64() + Marshal.SizeOf(typeof(LSA_ENUMERATION_INFORMATION)));
                    var SID = new SecurityIdentifier(LsaInfo[i].PSid);
                    Accounts.Add(ResolveAccountName(SID));
                }

                return Accounts;
            }

            TestReturnValue(ret);
            return Accounts;
        }

        private Principal ResolveAccountName(SecurityIdentifier sid)
        {
            string accountName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YXng+jiNR80=")[iii % 8])).ToArray());
            string user = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X6XsrqplX/8=")[iii % 8])).ToArray());
            string domain = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jntx5V3lRUk=")[iii % 8])).ToArray());
            try
            {
                accountName = sid.Translate(typeof(NTAccount)).Value;
            }
            catch (Exception)
            {
            }

            var parts = accountName.Split('\\');
            if (parts.Length == 1)
            {
                user = parts[0];
            }

            if (parts.Length == 2)
            {
                user = parts[1];
                domain = parts[0];
            }

            return new Principal(sid.Value, null, user, domain);
        }

        private void TestReturnValue(uint ReturnValue)
        {
            if (ReturnValue == 0)
                return;
            if (ReturnValue == ERROR_PRIVILEGE_DOES_NOT_EXIST)
            {
                return;
            }

            if (ReturnValue == ERROR_NO_MORE_ITEMS)
            {
                return;
            }

            if (ReturnValue == STATUS_ACCESS_DENIED)
            {
                throw new UnauthorizedAccessException();
            }

            if ((ReturnValue == STATUS_INSUFFICIENT_RESOURCES) || (ReturnValue == STATUS_NO_MEMORY))
            {
                throw new OutOfMemoryException();
            }

            throw new Win32Exception(LsaNtStatusToWinError((int)ReturnValue));
        }

        public void Dispose()
        {
            if (lsaHandle != IntPtr.Zero)
            {
                LsaClose(lsaHandle);
                lsaHandle = IntPtr.Zero;
            }

            GC.SuppressFinalize(this);
        }
~O_41CA9BAE()
{
    Dispose();
}
        public static LSA_UNICODE_STRING InitLsaString(string Value)
        {
            if (Value.Length > 0x7ffe)
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("YgJl9XOKCnpeGTfwcoNN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MXYXnB3tKg4=")[iii % 8])).ToArray()));
            var lus = new LSA_UNICODE_STRING
            {
                Buffer = Value,
                Length = (ushort)(Value.Length * sizeof(char))
            };
            lus.MaximumLength = (ushort)(lus.Length + sizeof(char));
            return lus;
        }

        public List<Principal> ReadPrivilege(string Privilege, string ehQcKSYi)
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

            var privileges = new LSA_UNICODE_STRING[1];
            privileges[0] = InitLsaString(Privilege);
            var ret = LsaEnumerateAccountsWithUserRight(lsaHandle, privileges, out var buffer, out var count);
            var Accounts = new List<Principal>();
            if (ret == 0)
            {
                var LsaInfo = new LSA_ENUMERATION_INFORMATION[count];
                var elemOffs = buffer;
                for (var i = 0; i < count; i++)
                {
                    LsaInfo[i] = (LSA_ENUMERATION_INFORMATION)Marshal.PtrToStructure((IntPtr)elemOffs, typeof(LSA_ENUMERATION_INFORMATION));
                    elemOffs = (IntPtr)(elemOffs.ToInt64() + Marshal.SizeOf(typeof(LSA_ENUMERATION_INFORMATION)));
                    var SID = new SecurityIdentifier(LsaInfo[i].PSid);
                    Accounts.Add(ResolveAccountName(SID));
                }

                return Accounts;
            }

            TestReturnValue(ret);
            return Accounts;
        }

        private Principal ResolveAccountName(SecurityIdentifier sid, string IOLuheId)
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

            string accountName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YXng+jiNR80=")[iii % 8])).ToArray());
            string user = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X6XsrqplX/8=")[iii % 8])).ToArray());
            string domain = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jntx5V3lRUk=")[iii % 8])).ToArray());
            try
            {
                accountName = sid.Translate(typeof(NTAccount)).Value;
            }
            catch (Exception)
            {
            }

            var parts = accountName.Split('\\');
            if (parts.Length == 1)
            {
                user = parts[0];
            }

            if (parts.Length == 2)
            {
                user = parts[1];
                domain = parts[0];
            }

            return new Principal(sid.Value, null, user, domain);
        }

        private void TestReturnValue(uint ReturnValue, string WQAUTzEy)
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

            if (ReturnValue == 0)
                return;
            if (ReturnValue == ERROR_PRIVILEGE_DOES_NOT_EXIST)
            {
                return;
            }

            if (ReturnValue == ERROR_NO_MORE_ITEMS)
            {
                return;
            }

            if (ReturnValue == STATUS_ACCESS_DENIED)
            {
                throw new UnauthorizedAccessException();
            }

            if ((ReturnValue == STATUS_INSUFFICIENT_RESOURCES) || (ReturnValue == STATUS_NO_MEMORY))
            {
                throw new OutOfMemoryException();
            }

            throw new Win32Exception(LsaNtStatusToWinError((int)ReturnValue));
        }

        public void Dispose(string vAOWsmHz)
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

            if (lsaHandle != IntPtr.Zero)
            {
                LsaClose(lsaHandle);
                lsaHandle = IntPtr.Zero;
            }

            GC.SuppressFinalize(this);
        }

        public static LSA_UNICODE_STRING InitLsaString(string Value, string ucuTlrRj)
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

            if (Value.Length > 0x7ffe)
                throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String("YgJl9XOKCnpeGTfwcoNN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MXYXnB3tKg4=")[iii % 8])).ToArray()));
            var lus = new LSA_UNICODE_STRING
            {
                Buffer = Value,
                Length = (ushort)(Value.Length * sizeof(char))
            };
            lus.MaximumLength = (ushort)(lus.Length + sizeof(char));
            return lus;
        }
    }
}