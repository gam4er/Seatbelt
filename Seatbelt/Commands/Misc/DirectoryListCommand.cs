using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    public class O_8BB37900
    {
        public O_8BB37900(string path, int depth)
        {
            Path = path;
            Depth = depth;
        }

        public string Path { get; }
        public int Depth { get; }
    }
internal class O_6FA8CF2E : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("OxgJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X3F7qmkd6JI=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ClYtbo8tdvMqWi01mmJ8/iNNLTTcT2m6Ilo4e4lhZLZmUzdpiH4w7zVaLGnbLXT1MVEydZ1pY7ZmWzF5iWB19DJMcjqdY3S6IlotcYhiYLogUDJ+mX9jum5eLH2JYHX0Mkx+J8EtS/4vTTt5iGJi4xsfBXeddVT/Nks2R9xWYv8hWiZH3FZy9SlTF32SYmL/A00sdY5+TQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rj9eGvwNEJo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    private Stack<O_8BB37900> _dirList = new Stack<O_8BB37900>();
    public O_6FA8CF2E(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string directory;
        Regex? regex = null;
        int maxDepth;
        var ignoreErrors = false;
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("K+Uw2XIzc8525TDYcjNzznblMNtyM3uDK754lFQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C8VL6V4eQv4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ClxXCj0d8Jg1Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rj0kfnx+k/0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("GyYLVIA5+h0y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V0d4INdLk2k=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VCp/Zw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0MFAscQeqs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("GPZx/A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SJcFlNrQrVg=")[iii % 8])).ToArray()));
        if (args.Length == 0)
        {
            directory = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("s30HVeAYvBCJchE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4AR0IYV1+GI=")[iii % 8])).ToArray()))}\\Users\\";
            regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PEraSaHN4W0RCZEH/7urYQwLzEalu9kgJg2GHeKC63wRHqEH+InpZwMGlhTLgvZjFg2VQdO7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YmLlaI/nhQg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase);
            maxDepth = 2;
            ignoreErrors = true;
        }
        else if (args.Length == 1)
        {
            directory = args[0];
            maxDepth = 0;
        }
        else if (args.Length == 2)
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
        }
        else if (args.Length == 3)
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
        }
        else
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
            ignoreErrors = true;
        }

        directory = Path.GetFullPath(Environment.ExpandEnvironmentVariables(directory));
        if (!directory.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xHx5AGyzgXg=")[iii % 8])).ToArray())))
            directory += Encoding.UTF8.GetString(Convert.FromBase64String("fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I6NSRc91Q9E=")[iii % 8])).ToArray());
        _dirList.Push(new O_8BB37900(directory, 0));
        while (_dirList.Any())
        {
            var query = _dirList.Pop();
            foreach (var dto in GetDirectories(regex, ignoreErrors, query, maxDepth))
                yield return dto;
            foreach (var dto in GetFiles(regex, ignoreErrors, query))
                yield return dto;
        }
    }

    private IEnumerable<O_3F60E36C> GetFiles(Regex? regex, bool ignoreErrors, O_8BB37900 query)
    {
        string[] files;
        try
        {
            files = Directory.GetFiles(query.Path);
        }
        catch (Exception e)
        {
            files = new string[]
            {
            };
            if (!ignoreErrors)
            {
                WriteError(e.ToString());
            }
        }

        foreach (var file in files)
        {
            if (regex != null && !regex.IsMatch(file) && !regex.IsMatch(query.Path))
            {
                continue;
            }

            long? size = null;
            try
            {
                var info = new FileInfo(file);
                size = info.Length;
            }
            catch
            {
            }

            yield return WriteOutput(file, size);
        }
    }

    private IEnumerable<O_3F60E36C> GetDirectories(Regex? regex, bool ignoreErrors, O_8BB37900 query, int maxDepth)
    {
        string[] directories;
        try
        {
            directories = Directory.GetDirectories(query.Path);
        }
        catch (Exception e)
        {
            directories = new string[]
            {
            };
            if (!ignoreErrors)
            {
                WriteError(e.ToString());
            }
        }

        foreach (var dir in directories)
        {
            var matchesIncludeFilter = regex == null || regex.IsMatch(dir);
            if (query.Depth + 1 <= maxDepth)
                _dirList.Push(new O_8BB37900(dir, query.Depth + 1));
            if (!matchesIncludeFilter)
                continue;
            if (!dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("gg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3sAJ6tlTREE=")[iii % 8])).ToArray())))
            {
                yield return WriteOutput(dir + Encoding.UTF8.GetString(Convert.FromBase64String("Ww==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0WnwJ4JNZE=")[iii % 8])).ToArray()), 0);
            }
            else
            {
                yield return WriteOutput(dir, 0);
            }
        }
    }

    private O_3F60E36C WriteOutput(string path, long? size)
    {
        DateTime? lastAccess = null;
        DateTime? lastWrite = null;
        try
        {
            lastAccess = Directory.GetLastAccessTime(path);
            lastWrite = Directory.GetLastWriteTime(path);
        }
        catch
        {
        }

        return new O_3F60E36C(lastAccess, lastWrite, size, path);
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string qHypMRTM)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                    instance.GetEra(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string directory;
        Regex? regex = null;
        int maxDepth;
        var ignoreErrors = false;
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("K+Uw2XIzc8525TDYcjNzznblMNtyM3uDK754lFQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C8VL6V4eQv4=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ClxXCj0d8Jg1Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Rj0kfnx+k/0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("GyYLVIA5+h0y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V0d4INdLk2k=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VCp/Zw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0MFAscQeqs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("GPZx/A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SJcFlNrQrVg=")[iii % 8])).ToArray()));
        if (args.Length == 0)
        {
            directory = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("s30HVeAYvBCJchE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4AR0IYV1+GI=")[iii % 8])).ToArray()))}\\Users\\";
            regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PEraSaHN4W0RCZEH/7urYQwLzEalu9kgJg2GHeKC63wRHqEH+InpZwMGlhTLgvZjFg2VQdO7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YmLlaI/nhQg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase);
            maxDepth = 2;
            ignoreErrors = true;
        }
        else if (args.Length == 1)
        {
            directory = args[0];
            maxDepth = 0;
        }
        else if (args.Length == 2)
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
        }
        else if (args.Length == 3)
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
        }
        else
        {
            directory = args[0];
            maxDepth = int.Parse(args[1]);
            regex = new Regex(args[2], RegexOptions.IgnoreCase);
            ignoreErrors = true;
        }

        directory = Path.GetFullPath(Environment.ExpandEnvironmentVariables(directory));
        if (!directory.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("mA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xHx5AGyzgXg=")[iii % 8])).ToArray())))
            directory += Encoding.UTF8.GetString(Convert.FromBase64String("fw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I6NSRc91Q9E=")[iii % 8])).ToArray());
        _dirList.Push(new O_8BB37900(directory, 0));
        while (_dirList.Any())
        {
            var query = _dirList.Pop();
            foreach (var dto in GetDirectories(regex, ignoreErrors, query, maxDepth))
                yield return dto;
            foreach (var dto in GetFiles(regex, ignoreErrors, query))
                yield return dto;
        }
    }

    private IEnumerable<O_3F60E36C> GetFiles(Regex? regex, bool ignoreErrors, O_8BB37900 query, string ZdLrgzOy)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                    instance.GetEra(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string[] files;
        try
        {
            files = Directory.GetFiles(query.Path);
        }
        catch (Exception e)
        {
            files = new string[]
            {
            };
            if (!ignoreErrors)
            {
                WriteError(e.ToString());
            }
        }

        foreach (var file in files)
        {
            if (regex != null && !regex.IsMatch(file) && !regex.IsMatch(query.Path))
            {
                continue;
            }

            long? size = null;
            try
            {
                var info = new FileInfo(file);
                size = info.Length;
            }
            catch
            {
            }

            yield return WriteOutput(file, size);
        }
    }

    private IEnumerable<O_3F60E36C> GetDirectories(Regex? regex, bool ignoreErrors, O_8BB37900 query, int maxDepth, string ZIKejpht)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                    instance.GetEra(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string[] directories;
        try
        {
            directories = Directory.GetDirectories(query.Path);
        }
        catch (Exception e)
        {
            directories = new string[]
            {
            };
            if (!ignoreErrors)
            {
                WriteError(e.ToString());
            }
        }

        foreach (var dir in directories)
        {
            var matchesIncludeFilter = regex == null || regex.IsMatch(dir);
            if (query.Depth + 1 <= maxDepth)
                _dirList.Push(new O_8BB37900(dir, query.Depth + 1));
            if (!matchesIncludeFilter)
                continue;
            if (!dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("gg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3sAJ6tlTREE=")[iii % 8])).ToArray())))
            {
                yield return WriteOutput(dir + Encoding.UTF8.GetString(Convert.FromBase64String("Ww==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B0WnwJ4JNZE=")[iii % 8])).ToArray()), 0);
            }
            else
            {
                yield return WriteOutput(dir, 0);
            }
        }
    }

    private O_3F60E36C WriteOutput(string path, long? size, string PJzZoKKv)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                    instance.GetEra(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        DateTime? lastAccess = null;
        DateTime? lastWrite = null;
        try
        {
            lastAccess = Directory.GetLastAccessTime(path);
            lastWrite = Directory.GetLastWriteTime(path);
        }
        catch
        {
        }

        return new O_3F60E36C(lastAccess, lastWrite, size, path);
    }
}internal class O_3F60E36C : O_4AED570F
{
    public O_3F60E36C(DateTime? lastAccess, DateTime? lastWrite, long? size, string path)
    {
        LastAccess = lastAccess;
        LastWrite = lastWrite;
        Size = size;
        Path = path;
    }

    public DateTime? LastAccess { get; }
    public DateTime? LastWrite { get; }
    public long? Size { get; }
    public string Path { get; }
}
    [CommandOutputType(typeof(O_3F60E36C))]
    internal class O_C154AF59 : TextFormatterBase
    {
        public O_C154AF59(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_3F60E36C)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zprP3+leiv+Tms/e6V6K/5Oaz93pXoKyzsGHkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7rq078Vzu88=")[iii % 8])).ToArray()), dto.LastWrite?.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("3hLpYYJOgrg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p2vELM9j5tw=")[iii % 8])).ToArray())), dto.LastAccess?.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("Q6+impVppSA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OtaP19hEwUQ=")[iii % 8])).ToArray())), dto.Size == null ? Encoding.UTF8.GetString(Convert.FromBase64String("loHw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qb7PxDSA2fg=")[iii % 8])).ToArray()) : BytesToString(dto.Size.Value), dto.Path);
        }

        private string BytesToString(long byteCount)
        {
            string[] suf =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("mA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2jKXvg4HgDY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Bmk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TStJG9hO5Bk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Om4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dyz7HST0yrE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IY4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZswwBLY9oKI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("M2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zyu0SNqgcrI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VV0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BR82FVXqGOc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("CoQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T8ZmY/xS9hk=")[iii % 8])).ToArray())
            };
            if (byteCount == 0)
                return Encoding.UTF8.GetString(Convert.FromBase64String("6Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2W48PGDZPXQ=")[iii % 8])).ToArray()) + suf[0];
            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num) + suf[place];
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string wruifDiE)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                        instance.GetEra(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_3F60E36C)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zprP3+leiv+Tms/e6V6K/5Oaz93pXoKyzsGHkg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7rq078Vzu88=")[iii % 8])).ToArray()), dto.LastWrite?.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("3hLpYYJOgrg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p2vELM9j5tw=")[iii % 8])).ToArray())), dto.LastAccess?.ToString(Encoding.UTF8.GetString(Convert.FromBase64String("Q6+impVppSA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OtaP19hEwUQ=")[iii % 8])).ToArray())), dto.Size == null ? Encoding.UTF8.GetString(Convert.FromBase64String("loHw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qb7PxDSA2fg=")[iii % 8])).ToArray()) : BytesToString(dto.Size.Value), dto.Path);
        }

        private string BytesToString(long byteCount, string fFRVXbVH)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
                        instance.GetEra(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            string[] suf =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("mA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2jKXvg4HgDY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Bmk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TStJG9hO5Bk=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Om4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dyz7HST0yrE=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("IY4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZswwBLY9oKI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("M2k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zyu0SNqgcrI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("VV0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BR82FVXqGOc=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("CoQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("T8ZmY/xS9hk=")[iii % 8])).ToArray())
            };
            if (byteCount == 0)
                return Encoding.UTF8.GetString(Convert.FromBase64String("6Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2W48PGDZPXQ=")[iii % 8])).ToArray()) + suf[0];
            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num) + suf[place];
        }
    }
}