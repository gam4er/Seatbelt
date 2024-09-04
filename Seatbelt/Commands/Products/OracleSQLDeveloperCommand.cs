using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_370811FA : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("lXUKGpmk9tCWQw4PkK3K8b91").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2gdrefXBpYE=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("xCPjN/qeYDDjKeE2qe1+DsYv+zbl0V8n8GruPOfQSiH2I+I9+pBXL+5q6zrl21w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gkqNU4m+L0I=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_370811FA(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("9INO3UlL+h3OjFg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p/o9qSwmvm8=")[iii % 8])).ToArray()))}\\Users\\";
        var dirs = Directory.GetDirectories(userFolder);
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("YFPrpLmd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MCaJyND+BbY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("chPewoFghQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nna4o/QM8XE=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WsIQvBf9RjRL1BOv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hqd23WKRMhQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("8uYxHdBCzd/A").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s4pdPYUxqK0=")[iii % 8])).ToArray())))
                continue;
            foreach (string foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("nYQ6y5jXeWSRhSeLhdlh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/utUpf20DQ0=")[iii % 8])).ToArray()), $"{dir}\\AppData\\Roaming\\SQL Developer\\"))
            {
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                yield return new O_0FDEAD5C()
                {
                    FileName = foundFile,
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    Size = size
                };
            }
        }
    }

internal class O_0FDEAD5C : O_4AED570F
{
    public string? FileName { get; set; }
    public DateTime? LastAccessed { get; set; }
    public DateTime? LastModified { get; set; }
    public long? Size { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string kBfstJOJ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetMonthsInYear(70, 2);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("9INO3UlL+h3OjFg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p/o9qSwmvm8=")[iii % 8])).ToArray()))}\\Users\\";
        var dirs = Directory.GetDirectories(userFolder);
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("YFPrpLmd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MCaJyND+BbY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("chPewoFghQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nna4o/QM8XE=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WsIQvBf9RjRL1BOv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Hqd23WKRMhQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("8uYxHdBCzd/A").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("s4pdPYUxqK0=")[iii % 8])).ToArray())))
                continue;
            foreach (string foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("nYQ6y5jXeWSRhSeLhdlh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/utUpf20DQ0=")[iii % 8])).ToArray()), $"{dir}\\AppData\\Roaming\\SQL Developer\\"))
            {
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                yield return new O_0FDEAD5C()
                {
                    FileName = foundFile,
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    Size = size
                };
            }
        }
    }
}}