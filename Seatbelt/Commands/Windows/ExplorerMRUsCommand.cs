#nullable disable
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using O_F41F88FA.Interop;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_FCBC7476 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("CKJC77ndEWoAiGfw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tdoyg9avdBg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("SslKkBSWWCgv3FWPD8RPP2zUVIgXnR0vfNRe3B2NUT98kRKQGpdJejiRXp0ClxF6bsNdiRaBUy4vjAfcF4VOLi/pGpganU5z").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D7E6/HvkPVo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_FCBC7476(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var lastDays = 7;
        if (args.Length == 1)
        {
            lastDays = int.Parse(args[0]);
        }
        else if (!Runtime.FilterResults)
        {
            lastDays = 30;
        }

        foreach (var file in EnumRecentExplorerFiles(lastDays).OrderByDescending(e => ((O_EBDE6938)e).LastAccessDate))
        {
            yield return file;
        }
    }

    private IEnumerable<O_4AED570F> EnumRecentExplorerFiles(int lastDays)
    {
        var startTime = DateTime.Now.AddDays(-lastDays);
        object shellObj = null;
        try
        {
            var shell = Type.GetTypeFromCLSID(new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("6zvnOuvymfiAM5dJn5ya+8ky+U7r85LnnTKXP5v37/+VQ+RN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rQLUD6+xq8o=")[iii % 8])).ToArray())));
            shellObj = Activator.CreateInstance(shell);
            var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("upP9Qx8jM7+AnOs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6eqON3pOd80=")[iii % 8])).ToArray()))}\\Users\\";
            var dirs = Directory.GetDirectories(userFolder);
            foreach (var userDir in dirs)
            {
                if (userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("LB26c3hp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fGjYHxEKOPI=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("UXI4o+NHVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FRdewpYrI0E=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mOaft7xNrqSJ8Jyk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3IP51skh2oQ=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("jNnHuzgmWw6+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zbWrm21VPnw=")[iii % 8])).ToArray())))
                {
                    continue;
                }

                string userName = null;
                try
                {
                    userName = File.GetAccessControl($"{userDir}\\NTUSER.DAT").GetOwner(typeof(SecurityIdentifier)).ToString();
                    userName = Advapi32.TranslateSid(userName);
                }
                catch
                {
                    var parts = userDir.Split('\\');
                    userName = parts[parts.Length - 1];
                }

                var recentPath = $"{userDir}\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\";
                string[] recentFiles = null;
                try
                {
                    recentFiles = Directory.GetFiles(recentPath, Encoding.UTF8.GetString(Convert.FromBase64String("fljAu1U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VHas1T7xdJA=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
                }
                catch
                {
                    continue;
                }

                if (recentFiles.Length == 0)
                    continue;
                foreach (var recentFile in recentFiles)
                {
                    var lastAccessed = File.GetLastAccessTime(recentFile);
                    if (lastAccessed <= startTime)
                    {
                        continue;
                    }

                    var shortcut = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("u3S7hJrn+5GXdKqGm/Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+Abe5e6CqPk=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, new object[] { recentFile });
                    var targetPath = (string)shortcut.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("51a05wQmN0DHXw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("szfGgGFSZyE=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, shortcut, new object[] { });
                    if (targetPath.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ipKR8Vy9LlM=")[iii % 8])).ToArray()))
                    {
                        continue;
                    }

                    yield return new O_EBDE6938()
                    {
                        Application = Encoding.UTF8.GetString(Convert.FromBase64String("y6uq2oRt3gw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jtPatusfu34=")[iii % 8])).ToArray()),
                        User = userName,
                        Target = targetPath,
                        LastAccessDate = lastAccessed
                    };
                }
            }
        }
        finally
        {
            if (shellObj != null)
            {
                Marshal.ReleaseComObject(shellObj);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string RzJRZbWu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.StringBuilder instance = new System.Text.StringBuilder();
                    instance.Insert(32, 254);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var lastDays = 7;
        if (args.Length == 1)
        {
            lastDays = int.Parse(args[0]);
        }
        else if (!Runtime.FilterResults)
        {
            lastDays = 30;
        }

        foreach (var file in EnumRecentExplorerFiles(lastDays).OrderByDescending(e => ((O_EBDE6938)e).LastAccessDate))
        {
            yield return file;
        }
    }

    private IEnumerable<O_4AED570F> EnumRecentExplorerFiles(int lastDays, string Cyculqbv)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.UmAlQuraCalendar instance = new System.Globalization.UmAlQuraCalendar();
                    instance.AddMonths(new System.DateTime(), 68);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var startTime = DateTime.Now.AddDays(-lastDays);
        object shellObj = null;
        try
        {
            var shell = Type.GetTypeFromCLSID(new Guid(Encoding.UTF8.GetString(Convert.FromBase64String("6zvnOuvymfiAM5dJn5ya+8ky+U7r85LnnTKXP5v37/+VQ+RN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rQLUD6+xq8o=")[iii % 8])).ToArray())));
            shellObj = Activator.CreateInstance(shell);
            var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("upP9Qx8jM7+AnOs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6eqON3pOd80=")[iii % 8])).ToArray()))}\\Users\\";
            var dirs = Directory.GetDirectories(userFolder);
            foreach (var userDir in dirs)
            {
                if (userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("LB26c3hp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fGjYHxEKOPI=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("UXI4o+NHVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FRdewpYrI0E=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mOaft7xNrqSJ8Jyk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3IP51skh2oQ=")[iii % 8])).ToArray())) || userDir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("jNnHuzgmWw6+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zbWrm21VPnw=")[iii % 8])).ToArray())))
                {
                    continue;
                }

                string userName = null;
                try
                {
                    userName = File.GetAccessControl($"{userDir}\\NTUSER.DAT").GetOwner(typeof(SecurityIdentifier)).ToString();
                    userName = Advapi32.TranslateSid(userName);
                }
                catch
                {
                    var parts = userDir.Split('\\');
                    userName = parts[parts.Length - 1];
                }

                var recentPath = $"{userDir}\\AppData\\Roaming\\Microsoft\\Windows\\Recent\\";
                string[] recentFiles = null;
                try
                {
                    recentFiles = Directory.GetFiles(recentPath, Encoding.UTF8.GetString(Convert.FromBase64String("fljAu1U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VHas1T7xdJA=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
                }
                catch
                {
                    continue;
                }

                if (recentFiles.Length == 0)
                    continue;
                foreach (var recentFile in recentFiles)
                {
                    var lastAccessed = File.GetLastAccessTime(recentFile);
                    if (lastAccessed <= startTime)
                    {
                        continue;
                    }

                    var shortcut = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("u3S7hJrn+5GXdKqGm/Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+Abe5e6CqPk=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, new object[] { recentFile });
                    var targetPath = (string)shortcut.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("51a05wQmN0DHXw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("szfGgGFSZyE=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, shortcut, new object[] { });
                    if (targetPath.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ipKR8Vy9LlM=")[iii % 8])).ToArray()))
                    {
                        continue;
                    }

                    yield return new O_EBDE6938()
                    {
                        Application = Encoding.UTF8.GetString(Convert.FromBase64String("y6uq2oRt3gw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jtPatusfu34=")[iii % 8])).ToArray()),
                        User = userName,
                        Target = targetPath,
                        LastAccessDate = lastAccessed
                    };
                }
            }
        }
        finally
        {
            if (shellObj != null)
            {
                Marshal.ReleaseComObject(shellObj);
            }
        }
    }
}internal class O_EBDE6938 : O_4AED570F
{
    public string Application { get; set; }
    public string Target { get; set; }
    public DateTime LastAccessDate { get; set; }
    public string User { get; set; }
}
    [CommandOutputType(typeof(O_EBDE6938))]
    internal class O_B7CE1D39 : TextFormatterBase
    {
        public O_B7CE1D39(ITextWriter sink) : base(sink)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_EBDE6938)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Vl91t0s8MotHAi6nTS5v0FYEPfo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dn8OhzYcEvA=")[iii % 8])).ToArray()), dto.Application, dto.User, dto.LastAccessDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("fD0GfuPJGa9hIA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BUR/B86EVII=")[iii % 8])).ToArray())), dto.Target);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ZEZTDCRo)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.UmAlQuraCalendar instance = new System.Globalization.UmAlQuraCalendar();
                        instance.AddMonths(new System.DateTime(), 68);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_EBDE6938)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Vl91t0s8MotHAi6nTS5v0FYEPfo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dn8OhzYcEvA=")[iii % 8])).ToArray()), dto.Application, dto.User, dto.LastAccessDate.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("fD0GfuPJGa9hIA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BUR/B86EVII=")[iii % 8])).ToArray())), dto.Target);
        }
    }
}
#nullable enable
