using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_F5CF150E : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("9RwRXhXPRjvVFR5eGw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pnBwPX6fNF4=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("u9X3BFzZNvuenfsJQ89k94vJ+wlQikX+md75R1HDeveLnfcfXtli").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+L2SZzeqFpI=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Slack
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_F5CF150E(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("fnix0/n2yQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ii3CtouFle8=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("57XUat8v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t8C2BrZMtWQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("xhI63We7Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gndcvBLXK7Y=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("BO8LJsPq68IV+Qg1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QIptR7aGn+I=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("s79szyFnLIiB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8tMA73QUSfo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var slackBasePath = $"{dir}\\AppData\\Roaming\\Slack\\";
            if (!Directory.Exists(slackBasePath))
            {
                continue;
            }

            DateTime? cookiesLastWriteTime = null, workspacesLastWriteTime = null, downloadsLastWriteTime = null;
            var userSlackCookiesPath = $"{dir}\\AppData\\Roaming\\Slack\\Cookies";
            if (File.Exists(userSlackCookiesPath))
            {
                cookiesLastWriteTime = File.GetLastWriteTime(userSlackCookiesPath);
            }

            var userSlackWorkspacesPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-workspaces";
            if (File.Exists(userSlackWorkspacesPath))
            {
                workspacesLastWriteTime = File.GetLastWriteTime(userSlackWorkspacesPath);
            }

            var userSlackDownloadsPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-downloads";
            if (File.Exists(userSlackDownloadsPath))
            {
                downloadsLastWriteTime = File.GetLastWriteTime(userSlackDownloadsPath);
            }

            if (cookiesLastWriteTime != null || workspacesLastWriteTime != null || downloadsLastWriteTime != null)
            {
                yield return new O_80011568(folder: $"{dir}\\AppData\\Roaming\\Slack\\", cookiesLastWriteTime, workspacesLastWriteTime, downloadsLastWriteTime);
            }
        }
    }

internal class O_80011568 : O_4AED570F
{
    public O_80011568(string folder, DateTime? cookiesLastModified, DateTime? workspacesLastModified, DateTime? downloadsLastModified)
    {
        Folder = folder;
        CookiesLastModified = cookiesLastModified;
        WorkspacesLastModified = workspacesLastModified;
        DownloadsLastModified = downloadsLastModified;
    }

    public string? Folder { get; }
    public DateTime? CookiesLastModified { get; }
    public DateTime? WorkspacesLastModified { get; }
    public DateTime? DownloadsLastModified { get; }
}    [CommandOutputType(typeof(O_80011568))]
    internal class O_90BE8F53 : TextFormatterBase
    {
        public O_90BE8F53(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_80011568)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CXhNkYhp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KVg2ofVjp0I=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.CookiesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("K8YJfoNox1Rgj0wtgwuIGyvGCX6EC4gbK8YJfoQLiBsjnRkjjQuIASvGbTHTRcRUaoIJKsxOiBxIiUY1zU7bHCuHRzqEDNtPZJRIOcF321dqhUJz00TaUHiWSD3BWI8bbY9FO9cL3FQrhUUxyk6IaGeHSjWESstYbpVa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C+YpXqQrqDs=")[iii % 8])).ToArray()), dto.CookiesLastModified);
            }

            if (dto.WorkspacesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LHkgboUqVORjK2EpxypU/G06a2PVGVX7fylhLccFALAkIjAzi1YHqix5UjvMVlP4aXknHc4XRPtbNnIl0QZG82kqJ27BGUr9bTdk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DFkATqJ2J5A=")[iii % 8])).ToArray()), dto.WorkspacesLastModified);
            }

            if (dto.DownloadsLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IYUevco0TTBu11/6iDRNKGDGVbCJB0kqbcpf+Z5PHmQp3g7gxEgefiGFbOiDSEosZIUZzoEJXS9FyknzgQdfIHKCHv6CBVMlb8E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AaU+ne1oPkQ=")[iii % 8])).ToArray()), dto.DownloadsLastModified);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string GoTlsmbo)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(72);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_80011568)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CXhNkYhp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KVg2ofVjp0I=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.CookiesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("K8YJfoNox1Rgj0wtgwuIGyvGCX6EC4gbK8YJfoQLiBsjnRkjjQuIASvGbTHTRcRUaoIJKsxOiBxIiUY1zU7bHCuHRzqEDNtPZJRIOcF321dqhUJz00TaUHiWSD3BWI8bbY9FO9cL3FQrhUUxyk6IaGeHSjWESstYbpVa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C+YpXqQrqDs=")[iii % 8])).ToArray()), dto.CookiesLastModified);
            }

            if (dto.WorkspacesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("LHkgboUqVORjK2EpxypU/G06a2PVGVX7fylhLccFALAkIjAzi1YHqix5UjvMVlP4aXknHc4XRPtbNnIl0QZG82kqJ27BGUr9bTdk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DFkATqJ2J5A=")[iii % 8])).ToArray()), dto.WorkspacesLastModified);
            }

            if (dto.DownloadsLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IYUevco0TTBu11/6iDRNKGDGVbCJB0kqbcpf+Z5PHmQp3g7gxEgefiGFbOiDSEosZIUZzoEJXS9FyknzgQdfIHKCHv6CBVMlb8E=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AaU+ne1oPkQ=")[iii % 8])).ToArray()), dto.DownloadsLastModified);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string lhWygCWZ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                    instance.GetFrame(72);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("fnix0/n2yQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ii3CtouFle8=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("57XUat8v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t8C2BrZMtWQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("xhI63We7Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gndcvBLXK7Y=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("BO8LJsPq68IV+Qg1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QIptR7aGn+I=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("s79szyFnLIiB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8tMA73QUSfo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var slackBasePath = $"{dir}\\AppData\\Roaming\\Slack\\";
            if (!Directory.Exists(slackBasePath))
            {
                continue;
            }

            DateTime? cookiesLastWriteTime = null, workspacesLastWriteTime = null, downloadsLastWriteTime = null;
            var userSlackCookiesPath = $"{dir}\\AppData\\Roaming\\Slack\\Cookies";
            if (File.Exists(userSlackCookiesPath))
            {
                cookiesLastWriteTime = File.GetLastWriteTime(userSlackCookiesPath);
            }

            var userSlackWorkspacesPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-workspaces";
            if (File.Exists(userSlackWorkspacesPath))
            {
                workspacesLastWriteTime = File.GetLastWriteTime(userSlackWorkspacesPath);
            }

            var userSlackDownloadsPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-downloads";
            if (File.Exists(userSlackDownloadsPath))
            {
                downloadsLastWriteTime = File.GetLastWriteTime(userSlackDownloadsPath);
            }

            if (cookiesLastWriteTime != null || workspacesLastWriteTime != null || downloadsLastWriteTime != null)
            {
                yield return new O_80011568(folder: $"{dir}\\AppData\\Roaming\\Slack\\", cookiesLastWriteTime, workspacesLastWriteTime, downloadsLastWriteTime);
            }
        }
    }
}}