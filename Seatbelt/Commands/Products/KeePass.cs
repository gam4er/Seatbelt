using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_6D791863 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("soXHV1V1tA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+eCiBzQGxyA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("2aIfB14ptA/6mxAQXimcBfGtGARYe54e9qQfQ0tgkw/s").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8txYy0J/2o=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_6D791863(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("QUbAOeaIfA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HROzXJT7IP4=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("gN8FibvE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0Kpn5dKnToI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("1UyQXOnALQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kSn2PZysWSA=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yO7WqjGmBbvZ+NW5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jIuwy0TKcZs=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("qsIMcypO/5mY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("665gU389mus=")[iii % 8])).ToArray())))
                continue;
            if (File.Exists($"{dir}\\AppData\\Roaming\\KeePass\\KeePass.config.xml"))
            {
                string foundFile = $"{dir}\\AppData\\Roaming\\KeePass\\KeePass.config.xml";
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                yield return new O_E2550E92()
                {
                    FileName = foundFile,
                    MasterKeyGuid = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m/Yv3qzio38=")[iii % 8])).ToArray()),
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    Size = size
                };
            }

            if (File.Exists($"{dir}\\AppData\\Roaming\\KeePass\\ProtectedUserKey.bin"))
            {
                string foundFile = $"{dir}\\AppData\\Roaming\\KeePass\\ProtectedUserKey.bin";
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                byte[] blobBytes = File.ReadAllBytes(foundFile);
                var offset = 24;
                var guidMasterKeyBytes = new byte[16];
                Array.Copy(blobBytes, offset, guidMasterKeyBytes, 0, 16);
                var guidMasterKey = new Guid(guidMasterKeyBytes);
                var guidString = $"{{{guidMasterKey}}}";
                yield return new O_E2550E92()
                {
                    FileName = foundFile,
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    MasterKeyGuid = guidString,
                    Size = size
                };
            }
        }
    }

internal class O_E2550E92 : O_4AED570F
{
    public string? FileName { get; set; }
    public string? MasterKeyGuid { get; set; }
    public DateTime? LastAccessed { get; set; }
    public DateTime? LastModified { get; set; }
    public long? Size { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string QrOguAaE)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.TaiwanCalendar instance = new System.Globalization.TaiwanCalendar();
                    instance.AddYears(new System.DateTime(), 31);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("QUbAOeaIfA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HROzXJT7IP4=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("gN8FibvE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0Kpn5dKnToI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("1UyQXOnALQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kSn2PZysWSA=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yO7WqjGmBbvZ+NW5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jIuwy0TKcZs=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("qsIMcypO/5mY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("665gU389mus=")[iii % 8])).ToArray())))
                continue;
            if (File.Exists($"{dir}\\AppData\\Roaming\\KeePass\\KeePass.config.xml"))
            {
                string foundFile = $"{dir}\\AppData\\Roaming\\KeePass\\KeePass.config.xml";
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                yield return new O_E2550E92()
                {
                    FileName = foundFile,
                    MasterKeyGuid = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m/Yv3qzio38=")[iii % 8])).ToArray()),
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    Size = size
                };
            }

            if (File.Exists($"{dir}\\AppData\\Roaming\\KeePass\\ProtectedUserKey.bin"))
            {
                string foundFile = $"{dir}\\AppData\\Roaming\\KeePass\\ProtectedUserKey.bin";
                var lastAccessed = File.GetLastAccessTime(foundFile);
                var lastModified = File.GetLastWriteTime(foundFile);
                var size = new FileInfo(foundFile).Length;
                byte[] blobBytes = File.ReadAllBytes(foundFile);
                var offset = 24;
                var guidMasterKeyBytes = new byte[16];
                Array.Copy(blobBytes, offset, guidMasterKeyBytes, 0, 16);
                var guidMasterKey = new Guid(guidMasterKeyBytes);
                var guidString = $"{{{guidMasterKey}}}";
                yield return new O_E2550E92()
                {
                    FileName = foundFile,
                    LastAccessed = lastAccessed,
                    LastModified = lastModified,
                    MasterKeyGuid = guidString,
                    Size = size
                };
            }
        }
    }
}}