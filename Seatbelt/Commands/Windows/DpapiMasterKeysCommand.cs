#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_C2D05A62
    {
        public string FileName { get; set; }
        public DateTime LastAccessed { get; set; }
        public DateTime LastModified { get; set; }
    }
internal class O_4307ECB9 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("6yl43WUlH5rbPGvmaREN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r1kZrQxofuk=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("YQqg9qZYZKB9KvPv529AhF9DuOf/bw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LWPTgoYcNOE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_4307ECB9(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("T4UwrK6nDw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E9BDydzUU3U=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Ib/cjAPd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ccq+4Gq+/Qw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("DOFWFpFaXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SIQwd+Q2KXA=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("BTFuywBpTl4UJ23Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QVQIqnUFOn4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("ycUWZobgb7z7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKl6RtOTCs4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userDpapiBasePath = $"{dir}\\AppData\\Roaming\\Microsoft\\Protect\\";
            if (!Directory.Exists(userDpapiBasePath))
            {
                continue;
            }

            var directories = Directory.GetDirectories(userDpapiBasePath);
            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);
                var MasterKeys = new List<O_C2D05A62>();
                foreach (var file in files)
                {
                    if (!Regex.IsMatch(file, Encoding.UTF8.GetString(Convert.FromBase64String("8CQvjbEr84eGcl/PyHvuy/ZPMpnJR5igyjlk6YsyyL2GSVmE3T/0y+11L9KtfYGb8Dlf78ArjKeGUmOZllvO0tZPL+mrNpjf6jlE1d1g6J2aJn8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qxQCtPAGteY=")[iii % 8])).ToArray())))
                    {
                        continue;
                    }

                    var masterKey = new O_C2D05A62();
                    masterKey.FileName = Path.GetFileName(file);
                    masterKey.LastAccessed = File.GetLastAccessTime(file);
                    masterKey.LastModified = File.GetLastAccessTime(file);
                    MasterKeys.Add(masterKey);
                }

                yield return new O_FBE67245()
                {
                    Folder = $"{directory}",
                    MasterKeys = MasterKeys
                };
            }
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("NREVncsMVfNMVBWyiTRV61ZcXK2AJQ+GHVVFp5E4T5xSUEayhCMew0YTFauONQDKWhFCr5U5VcdPQUepkSMcx0tUFaeTNgDLWl9BtcF5WtZJWhWpk3Fa1E9SHOaVPlXCWlJHv5El").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PzE1xuFRdaY=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("S31ZeeN9ihoefWEy0H2yGRgyIjbGKaEUCCkiPt8zqlUvDUMD932+FBgpZyHVOKoGSztwPNN9vhAGMnAqniq6AQN9djvbfZ4cBjRpMson81cYOGkmzDGgFFFnZiPfLbpXSzBtN8sxtg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a10CU75d03U=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("xFlRG5Y306KRWWlQpTfroZcWKkS4cqqejBh4QY9Hy52tWWxeuTfnrJcNb0OgcvPtlhx+Q6Jy/KyIVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5HkKMcsXis0=")[iii % 8])).ToArray()));
    }

internal class O_FBE67245 : O_4AED570F
{
    public string Folder { get; set; }
    public List<O_C2D05A62> MasterKeys { get; set; }
}    [CommandOutputType(typeof(O_FBE67245))]
    internal class O_11C0D0C3 : TextFormatterBase
    {
        public O_11C0D0C3(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_FBE67245)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("rPlVe3mv/q2s4zNvJbaR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jNkTFBXLm98=")[iii % 8])).ToArray()), dto.Folder);
            WriteLine($"    LastAccessed              LastModified              FileName");
            WriteLine($"    ------------              ------------              --------");
            foreach (var masterkey in dto.MasterKeys)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KJrLm6I7YMk6iJab+StsnzmWxonrdmzEKJqQiaQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CLrru9kLTOQ=")[iii % 8])).ToArray()), masterkey.LastAccessed, masterkey.LastModified, masterkey.FileName);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string TWAsTyAM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.IsLeapYear(20, 7);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_FBE67245)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("rPlVe3mv/q2s4zNvJbaR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jNkTFBXLm98=")[iii % 8])).ToArray()), dto.Folder);
            WriteLine($"    LastAccessed              LastModified              FileName");
            WriteLine($"    ------------              ------------              --------");
            foreach (var masterkey in dto.MasterKeys)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KJrLm6I7YMk6iJab+StsnzmWxonrdmzEKJqQiaQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CLrru9kLTOQ=")[iii % 8])).ToArray()), masterkey.LastAccessed, masterkey.LastModified, masterkey.FileName);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string rTCmjkYX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                    instance.IsLeapYear(20, 7);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("T4UwrK6nDw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E9BDydzUU3U=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Ib/cjAPd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ccq+4Gq+/Qw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("DOFWFpFaXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SIQwd+Q2KXA=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("BTFuywBpTl4UJ23Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QVQIqnUFOn4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("ycUWZobgb7z7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iKl6RtOTCs4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userDpapiBasePath = $"{dir}\\AppData\\Roaming\\Microsoft\\Protect\\";
            if (!Directory.Exists(userDpapiBasePath))
            {
                continue;
            }

            var directories = Directory.GetDirectories(userDpapiBasePath);
            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);
                var MasterKeys = new List<O_C2D05A62>();
                foreach (var file in files)
                {
                    if (!Regex.IsMatch(file, Encoding.UTF8.GetString(Convert.FromBase64String("8CQvjbEr84eGcl/PyHvuy/ZPMpnJR5igyjlk6YsyyL2GSVmE3T/0y+11L9KtfYGb8Dlf78ArjKeGUmOZllvO0tZPL+mrNpjf6jlE1d1g6J2aJn8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qxQCtPAGteY=")[iii % 8])).ToArray())))
                    {
                        continue;
                    }

                    var masterKey = new O_C2D05A62();
                    masterKey.FileName = Path.GetFileName(file);
                    masterKey.LastAccessed = File.GetLastAccessTime(file);
                    masterKey.LastModified = File.GetLastAccessTime(file);
                    MasterKeys.Add(masterKey);
                }

                yield return new O_FBE67245()
                {
                    Folder = $"{directory}",
                    MasterKeys = MasterKeys
                };
            }
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("NREVncsMVfNMVBWyiTRV61ZcXK2AJQ+GHVVFp5E4T5xSUEayhCMew0YTFauONQDKWhFCr5U5VcdPQUepkSMcx0tUFaeTNgDLWl9BtcF5WtZJWhWpk3Fa1E9SHOaVPlXCWlJHv5El").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PzE1xuFRdaY=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("S31ZeeN9ihoefWEy0H2yGRgyIjbGKaEUCCkiPt8zqlUvDUMD932+FBgpZyHVOKoGSztwPNN9vhAGMnAqniq6AQN9djvbfZ4cBjRpMson81cYOGkmzDGgFFFnZiPfLbpXSzBtN8sxtg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a10CU75d03U=")[iii % 8])).ToArray()));
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("xFlRG5Y306KRWWlQpTfroZcWKkS4cqqejBh4QY9Hy52tWWxeuTfnrJcNb0OgcvPtlhx+Q6Jy/KyIVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5HkKMcsXis0=")[iii % 8])).ToArray()));
    }
}}
#nullable enable
