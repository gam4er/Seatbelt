using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_A9C80A61 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("j0Ie/A7EnWyvQg3fFc2Law==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xixqmXyh7hg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("764edG4vxIG5jh5nKX3Hm6GCAyBmPNWRpY4eZysrwICkiAVzKy3AhrmCAm54fcic7ZMYZSso0pe/wAMgbTLNlqiVXiBFMtWX98cEYWA40tKjiB4tfy/IhKSGHCB/NMyX4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zedwAAtdofI=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_A9C80A61(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var patterns = new string[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("oELXHkER").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ijK2bTI76Dg=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("UR5C6Qfhv5JR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e3oriGCT3v8=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("LzGQuDCU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BW7iy1G+s5M=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("IFfgoWY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CnmEzgUMP1U=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("tiNj7VkN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nA0Hgjp1HbE=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("jBYdtVQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pjht0Dl4WFo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("BWDJ9vE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L065kpfyuDk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("owyA/Zc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iSLwm++B8kk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("RpMVpHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bL1llU7DUU4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("2hvuNUM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8DWeRTcH2RM=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("CnpK4DKt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IFQ6kEbVz+I=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("s2ZYbzY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mUguHFJPLbg=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("3+bO5HU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9ci2iAa33H4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("zzCMAnUV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5R70bgZtSBA=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("z9l46mQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5fcTjgZiTYM=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("/QNRUTSD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1y06NVb7VEo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("95ekoms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3bnPxxImWy4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("S87s9m26Z15jxOfAZa4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKuJpgzJFHA=")[iii % 8])).ToArray())
        };
        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("dXfY2TvfkjNPeM4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Jg6rrV6y1kE=")[iii % 8])).ToArray()))}\\Users\\";
        var files = FindFiles(searchPath, string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PyVSgfW0P+o=")[iii % 8])).ToArray()), patterns));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dlyJjOlWyU4YPcrPrAWaZhN5g4nlQN4LXD3Kz6x1218U").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fB3q74wluis=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZUp3AprAWhRlSnoPl81aFGVKdwKawFoUaEd6D5rAWhRl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SGdaL7ftdzk=")[iii % 8])).ToArray()));
        foreach (var file in files)
        {
            var info = new FileInfo(file);
            string? owner = null;
            string? sddl = null;
            try
            {
                sddl = info.GetAccessControl(System.Security.AccessControl.AccessControlSections.All).GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.All);
                owner = File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            }
            catch
            {
            }

            yield return new O_546DA94C($"{file}", info.Length, info.CreationTime, info.LastAccessTime, info.LastWriteTime, sddl, owner);
        }
    }

    public static List<string> FindFiles(string path, string patterns)
    {
        var files = new List<string>();
        try
        {
            var filesUnfiltered = GetFiles(path).ToList();
            foreach (var pattern in patterns.Split(';'))
            {
                files.AddRange(filesUnfiltered.Where(f => f.Contains(pattern.Trim('*'))));
            }
        }
        catch (UnauthorizedAccessException)
        {
        }
        catch (PathTooLongException)
        {
        }

        return files;
    }

    private static IEnumerable<string> GetFiles(string path)
    {
        var queue = new Queue<string>();
        queue.Enqueue(path);
        while (queue.Count > 0)
        {
            path = queue.Dequeue();
            try
            {
                foreach (var subDir in Directory.GetDirectories(path))
                {
                    queue.Enqueue(subDir);
                }
            }
            catch (Exception)
            {
            }

            string[]? files = null;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (Exception)
            {
            }

            if (files == null)
                continue;
            foreach (var f in files)
            {
                yield return f;
            }
        }
    }

internal class O_546DA94C : O_4AED570F
{
    public O_546DA94C(string path, long size, DateTime dateCreated, DateTime dateAccessed, DateTime dateModified, string? sddl, string? fileOwner)
    {
        Path = path;
        Size = size;
        DateCreated = dateCreated;
        DateAccessed = dateAccessed;
        DateModified = dateModified;
        Sddl = sddl;
        FileOwner = fileOwner;
    }

    public string Path { get; }
    public long Size { get; }
    public DateTime DateCreated { get; }
    public DateTime DateAccessed { get; }
    public DateTime DateModified { get; }
    public string? Sddl { get; }
    public string? FileOwner { get; }
}    [CommandOutputType(typeof(O_546DA94C))]
    internal class O_636DA14D : TextFormatterBase
    {
        public O_636DA14D(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_546DA94C)result;
            WriteLine($"{dto.DateAccessed:yyyy-MM-dd}    {dto.DateModified:yyyy-MM-dd}    {dto.Path}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string nNgowcOZ)
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

            var dto = (O_546DA94C)result;
            WriteLine($"{dto.DateAccessed:yyyy-MM-dd}    {dto.DateModified:yyyy-MM-dd}    {dto.Path}");
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string eNdTutWe)
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

        var patterns = new string[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("oELXHkER").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ijK2bTI76Dg=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("UR5C6Qfhv5JR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("e3oriGCT3v8=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("LzGQuDCU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BW7iy1G+s5M=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("IFfgoWY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CnmEzgUMP1U=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("tiNj7VkN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nA0Hgjp1HbE=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("jBYdtVQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pjht0Dl4WFo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("BWDJ9vE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L065kpfyuDk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("owyA/Zc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iSLwm++B8kk=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("RpMVpHw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bL1llU7DUU4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("2hvuNUM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8DWeRTcH2RM=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("CnpK4DKt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IFQ6kEbVz+I=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("s2ZYbzY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mUguHFJPLbg=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("3+bO5HU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9ci2iAa33H4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("zzCMAnUV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5R70bgZtSBA=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("z9l46mQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5fcTjgZiTYM=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("/QNRUTSD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1y06NVb7VEo=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("95ekoms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3bnPxxImWy4=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("S87s9m26Z15jxOfAZa4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AKuJpgzJFHA=")[iii % 8])).ToArray())
        };
        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("dXfY2TvfkjNPeM4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Jg6rrV6y1kE=")[iii % 8])).ToArray()))}\\Users\\";
        var files = FindFiles(searchPath, string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PyVSgfW0P+o=")[iii % 8])).ToArray()), patterns));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dlyJjOlWyU4YPcrPrAWaZhN5g4nlQN4LXD3Kz6x1218U").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fB3q74wluis=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("ZUp3AprAWhRlSnoPl81aFGVKdwKawFoUaEd6D5rAWhRl").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SGdaL7ftdzk=")[iii % 8])).ToArray()));
        foreach (var file in files)
        {
            var info = new FileInfo(file);
            string? owner = null;
            string? sddl = null;
            try
            {
                sddl = info.GetAccessControl(System.Security.AccessControl.AccessControlSections.All).GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections.All);
                owner = File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            }
            catch
            {
            }

            yield return new O_546DA94C($"{file}", info.Length, info.CreationTime, info.LastAccessTime, info.LastWriteTime, sddl, owner);
        }
    }

    public static List<string> FindFiles(string path, string patterns, string AKYmzcfx)
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

        var files = new List<string>();
        try
        {
            var filesUnfiltered = GetFiles(path).ToList();
            foreach (var pattern in patterns.Split(';'))
            {
                files.AddRange(filesUnfiltered.Where(f => f.Contains(pattern.Trim('*'))));
            }
        }
        catch (UnauthorizedAccessException)
        {
        }
        catch (PathTooLongException)
        {
        }

        return files;
    }

    private static IEnumerable<string> GetFiles(string path, string AxaeZbHT)
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

        var queue = new Queue<string>();
        queue.Enqueue(path);
        while (queue.Count > 0)
        {
            path = queue.Dequeue();
            try
            {
                foreach (var subDir in Directory.GetDirectories(path))
                {
                    queue.Enqueue(subDir);
                }
            }
            catch (Exception)
            {
            }

            string[]? files = null;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (Exception)
            {
            }

            if (files == null)
                continue;
            foreach (var f in files)
            {
                yield return f;
            }
        }
    }
}}