using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_0AE08354 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("YtCYwSjwuStB1bDAPg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L7PZp02V+kQ=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("HgKyzAjaEy0ZDbnNW5kxID4Cu90JmyonNwX8zhKWOz0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WGvcqHv6Xk4=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_0AE08354(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!Runtime.FilterResults || (args.Length == 1))
        {
            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("h+3BftjCrgylur1ow8GsDZg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xNedLqqtyX4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Mk6xEfh8tBwQGc0H43+2HVFclXm8Oo8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cXTtQYoT024=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Sb9xWmTMLdNr6GlrYsIW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CoUtChajSqE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("b+ieOCdzWkZJvLYPaHFBTwyBpwg8eUFMX44=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LNLCfEgQLys=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hJ90CQ0xxc+b").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x6UoXH5Ut7w=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                foreach (string foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("UxjpFGOx5/tKHIoXc+PM/1IFlBl1qPj7TQ3pCGyh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PnnHcAHNtJI=")[iii % 8])).ToArray()), path))
                {
                    var lastAccessed = File.GetLastAccessTime(foundFile);
                    var lastModified = File.GetLastWriteTime(foundFile);
                    var size = new FileInfo(foundFile).Length;
                    yield return new O_B517DD7E()
                    {
                        FileName = foundFile,
                        LastAccessed = lastAccessed,
                        LastModified = lastModified,
                        Size = size
                    };
                }
            }
        }
        else
        {
            string[] paths =
            {
                $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("JNA8E2O2K6Ee3yo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d6lPZwbbb9M=")[iii % 8])).ToArray()))}\\Users\\All Users\\McAfee\\Agent\\DB\\ma.db",
                $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("CEIc8zi5zi4yTQo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Wztvh13Uilw=")[iii % 8])).ToArray()))}\\ProgramData\\McAfee\\Agent\\DB\\ma.db"};
            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    var lastAccessed = File.GetLastAccessTime(path);
                    var lastModified = File.GetLastWriteTime(path);
                    var size = new FileInfo(path).Length;
                    yield return new O_B517DD7E()
                    {
                        FileName = path,
                        LastAccessed = lastAccessed,
                        LastModified = lastModified,
                        Size = size
                    };
                }
            }
        }
    }

internal class O_B517DD7E : O_4AED570F
{
    public string? FileName { get; set; }
    public DateTime? LastAccessed { get; set; }
    public DateTime? LastModified { get; set; }
    public long? Size { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string awxMtFUh)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF7Encoding instance = new System.Text.UTF7Encoding();
                    instance.GetMaxCharCount(51);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!Runtime.FilterResults || (args.Length == 1))
        {
            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("h+3BftjCrgylur1ow8GsDZg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xNedLqqtyX4=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Mk6xEfh8tBwQGc0H43+2HVFclXm8Oo8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cXTtQYoT024=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Sb9xWmTMLdNr6GlrYsIW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CoUtChajSqE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("b+ieOCdzWkZJvLYPaHFBTwyBpwg8eUFMX44=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LNLCfEgQLys=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("hJ90CQ0xxc+b").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x6UoXH5Ut7w=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                foreach (string foundFile in MiscUtil.GetFileList(Encoding.UTF8.GetString(Convert.FromBase64String("UxjpFGOx5/tKHIoXc+PM/1IFlBl1qPj7TQ3pCGyh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PnnHcAHNtJI=")[iii % 8])).ToArray()), path))
                {
                    var lastAccessed = File.GetLastAccessTime(foundFile);
                    var lastModified = File.GetLastWriteTime(foundFile);
                    var size = new FileInfo(foundFile).Length;
                    yield return new O_B517DD7E()
                    {
                        FileName = foundFile,
                        LastAccessed = lastAccessed,
                        LastModified = lastModified,
                        Size = size
                    };
                }
            }
        }
        else
        {
            string[] paths =
            {
                $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("JNA8E2O2K6Ee3yo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d6lPZwbbb9M=")[iii % 8])).ToArray()))}\\Users\\All Users\\McAfee\\Agent\\DB\\ma.db",
                $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("CEIc8zi5zi4yTQo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Wztvh13Uilw=")[iii % 8])).ToArray()))}\\ProgramData\\McAfee\\Agent\\DB\\ma.db"};
            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    var lastAccessed = File.GetLastAccessTime(path);
                    var lastModified = File.GetLastWriteTime(path);
                    var size = new FileInfo(path).Length;
                    yield return new O_B517DD7E()
                    {
                        FileName = path,
                        LastAccessed = lastAccessed,
                        LastModified = lastModified,
                        Size = size
                    };
                }
            }
        }
    }
}}