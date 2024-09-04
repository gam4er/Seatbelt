#nullable disable
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Interop;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_C2B01D33 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("G++KUsYnSX8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WJ3vNoNJPBI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ES2/TySc04wxMOpWKYuSmyExuEcvmpKNJya4BTLOwZkiJq4CIpzXnDEtvksggsHYITCjTCbO8YoxJ49MNIPXijU3rwpo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VEPKIkHusvg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_C2B01D33(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var ret = Advapi32.CredEnumerate(null, 0, out var count, out var pCredentials);
        if (!ret)
        {
            var lastError = Marshal.GetLastWin32Error();
            throw new Win32Exception(lastError);
        }

        for (var n = 0; n < count; n++)
        {
            var credentialPtr = Marshal.ReadIntPtr(pCredentials, n * Marshal.SizeOf(typeof(IntPtr)));
            var credential = (Advapi32.CREDENTIAL)Marshal.PtrToStructure(credentialPtr, typeof(Advapi32.CREDENTIAL));
            string password = null;
            if (credential.CredentialBlob != IntPtr.Zero)
            {
                var passwordBytes = new byte[credential.CredentialBlobSize];
                Marshal.Copy(credential.CredentialBlob, passwordBytes, 0, credential.CredentialBlobSize);
                var flags = Advapi32.IsTextUnicodeFlags.IS_TEXT_UNICODE_STATISTICS;
                if (Advapi32.IsTextUnicode(passwordBytes, passwordBytes.Length, ref flags))
                {
                    password = Encoding.Unicode.GetString(passwordBytes);
                }
                else
                {
                    password = BitConverter.ToString(passwordBytes).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/wG0DXiWh0M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oqFDV6svVs8=")[iii % 8])).ToArray()));
                }
            }

            yield return new O_A55183BA(credential.TargetName, credential.Comment, credential.UserName, password, credential.Type, credential.Persist, DateTime.FromFileTime(credential.LastWritten));
        }

        Advapi32.CredFree(pCredentials);
    }

internal class O_A55183BA : O_4AED570F
{
    public O_A55183BA(string target, string comment, string username, string password, Advapi32.CredentialType credentialType, Advapi32.PersistenceType persistenceType, DateTime lastWriteTime)
    {
        Target = target;
        Comment = comment;
        Username = username;
        Password = password;
        CredentialType = credentialType;
        PersistenceType = persistenceType;
        LastWriteTime = lastWriteTime;
    }

    public string Target { get; }
    public string Comment { get; }
    public string Username { get; }
    public string Password { get; }
    public Advapi32.CredentialType CredentialType { get; }
    public Advapi32.PersistenceType PersistenceType { get; }
    public DateTime LastWriteTime { get; }
}    [CommandOutputType(typeof(O_A55183BA))]
    internal class O_80287F36 : TextFormatterBase
    {
        public O_80287F36(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_A55183BA)result;
            WriteLine($"  Target              : {dto.Target}");
            if (!String.IsNullOrEmpty(dto.Comment))
            {
                WriteLine($"  Comment             : {dto.Comment}");
            }

            WriteLine($"  UserName            : {dto.Username}");
            WriteLine($"  Password            : {dto.Password}");
            WriteLine($"  CredentialType      : {dto.CredentialType}");
            WriteLine($"  PersistenceType     : {dto.PersistenceType}");
            WriteLine($"  LastWriteTime       : {dto.LastWriteTime}\r\n");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string doMpoFLr)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JulianCalendar instance = new System.Globalization.JulianCalendar();
                        instance.GetMonthsInYear(38, 1);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_A55183BA)result;
            WriteLine($"  Target              : {dto.Target}");
            if (!String.IsNullOrEmpty(dto.Comment))
            {
                WriteLine($"  Comment             : {dto.Comment}");
            }

            WriteLine($"  UserName            : {dto.Username}");
            WriteLine($"  Password            : {dto.Password}");
            WriteLine($"  CredentialType      : {dto.CredentialType}");
            WriteLine($"  PersistenceType     : {dto.PersistenceType}");
            WriteLine($"  LastWriteTime       : {dto.LastWriteTime}\r\n");
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string UAzDONfL)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JulianCalendar instance = new System.Globalization.JulianCalendar();
                    instance.GetMonthsInYear(38, 1);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var ret = Advapi32.CredEnumerate(null, 0, out var count, out var pCredentials);
        if (!ret)
        {
            var lastError = Marshal.GetLastWin32Error();
            throw new Win32Exception(lastError);
        }

        for (var n = 0; n < count; n++)
        {
            var credentialPtr = Marshal.ReadIntPtr(pCredentials, n * Marshal.SizeOf(typeof(IntPtr)));
            var credential = (Advapi32.CREDENTIAL)Marshal.PtrToStructure(credentialPtr, typeof(Advapi32.CREDENTIAL));
            string password = null;
            if (credential.CredentialBlob != IntPtr.Zero)
            {
                var passwordBytes = new byte[credential.CredentialBlobSize];
                Marshal.Copy(credential.CredentialBlob, passwordBytes, 0, credential.CredentialBlobSize);
                var flags = Advapi32.IsTextUnicodeFlags.IS_TEXT_UNICODE_STATISTICS;
                if (Advapi32.IsTextUnicode(passwordBytes, passwordBytes.Length, ref flags))
                {
                    password = Encoding.Unicode.GetString(passwordBytes);
                }
                else
                {
                    password = BitConverter.ToString(passwordBytes).Replace(Encoding.UTF8.GetString(Convert.FromBase64String("0g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/wG0DXiWh0M=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("gg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oqFDV6svVs8=")[iii % 8])).ToArray()));
                }
            }

            yield return new O_A55183BA(credential.TargetName, credential.Comment, credential.UserName, password, credential.Type, credential.Persist, DateTime.FromFileTime(credential.LastWritten));
        }

        Advapi32.CredFree(pCredentials);
    }
}}
#nullable enable
