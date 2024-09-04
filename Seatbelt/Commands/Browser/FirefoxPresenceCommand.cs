using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_87678929 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("S5Kj3EzV+sp/nqLcRNnn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DfvRuSq6gpo=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("OSKCqUla6tIcao6kVky43gk+jqRFCYzSCC+BpVoJrNIWL5TqR1GjyA4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ekrnyiIpyrs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_87678929(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("5qwg7GaP0w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uvlTiRT8jzw=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("oFtNSVRM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8C4vJT0vXmo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("T7o3W47okA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C99ROvuE5MQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("zT2yczVcrLjcK7Fg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iVjUEkAw2Jg=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("f4tD0V/d4qxN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Pucv8Qquh94=")[iii % 8])).ToArray())))
                continue;
            var userFirefoxBasePath = $"{dir}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\";
            if (!Directory.Exists(userFirefoxBasePath))
                continue;
            var historyLastModified = new DateTime();
            var credentialFile3LastModified = new DateTime();
            var credentialFile4LastModified = new DateTime();
            var directories = Directory.GetDirectories(userFirefoxBasePath);
            foreach (var directory in directories)
            {
                var firefoxHistoryFile = $"{directory}\\places.sqlite";
                if (File.Exists(firefoxHistoryFile))
                {
                    historyLastModified = File.GetLastWriteTime(firefoxHistoryFile);
                }

                var firefoxCredentialFile3 = $"{directory}\\key3.db";
                if (File.Exists(firefoxCredentialFile3))
                {
                    credentialFile3LastModified = File.GetLastWriteTime(firefoxCredentialFile3);
                }

                var firefoxCredentialFile4 = $"{directory}\\key4.db";
                if (File.Exists(firefoxCredentialFile4))
                {
                    credentialFile4LastModified = File.GetLastWriteTime(firefoxCredentialFile4);
                }

                if (historyLastModified != DateTime.MinValue || credentialFile3LastModified != DateTime.MinValue || credentialFile4LastModified != DateTime.MinValue)
                {
                    yield return new O_90883E87(directory, historyLastModified, credentialFile3LastModified, credentialFile4LastModified);
                }
            }
        }
    }

internal class O_90883E87 : O_4AED570F
{
    public O_90883E87(string folder, DateTime historyLastModified, DateTime credentialFile3LastModified, DateTime credentialFile4LastModified)
    {
        Folder = folder;
        HistoryLastModified = historyLastModified;
        CredentialFile3LastModified = credentialFile3LastModified;
        CredentialFile4LastModified = credentialFile4LastModified;
    }

    public string Folder { get; }
    public DateTime HistoryLastModified { get; }
    public DateTime CredentialFile3LastModified { get; }
    public DateTime CredentialFile4LastModified { get; }
}    [CommandOutputType(typeof(O_90883E87))]
    internal class O_6BBF1E75 : TextFormatterBase
    {
        public O_6BBF1E75(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_90883E87)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Oz4VfS6fbg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gx5uTVPDZMg=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.HistoryLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2xLip8xMSBSYV7GpmE1IHI9X5afLFF9Fhhvip9EcBD2SQbbomUUEE5Jep6vLTlEb20aq4ssbYhyJV6Tok2hWHJpVp6DLX0sYllOs4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+zLCh+s8JHU=")[iii % 8])).ToArray()), dto.HistoryLastModified);
            }

            if (dto.CredentialFile3LastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MWw9QP5+jmIiYnkC/jXLOzFsPUD5PZArbGU9QOM1y1hjKXkFt2GCen0/PQaweY43MT5oDvlGg3pjPEoFuzXDc2U4bRPjOsR8eDh1Fbs7iHR8Y3kKsXqDdWI4eAm3OrhzcD5tN7x3wg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUwdYNkV6xs=")[iii % 8])).ToArray()), dto.CredentialFile3LastModified);
            }

            if (dto.CredentialFile4LastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+Kbg4TMVlhzsqKSjM17TRfim4OE0VohVpa/g4S5e0yaq46SkegqaBLT14Kd9EpZJ+PS1rzQtmwSq9pekdl7bDazysLIuUdwCsfKotHZQkAq1qaSrfBGbC6vypah6UaANufSwlnEc2g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2IbAwRR+82U=")[iii % 8])).ToArray()), dto.CredentialFile4LastModified);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string JogcjWve)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                        instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_90883E87)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Oz4VfS6fbg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gx5uTVPDZMg=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.HistoryLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2xLip8xMSBSYV7GpmE1IHI9X5afLFF9Fhhvip9EcBD2SQbbomUUEE5Jep6vLTlEb20aq4ssbYhyJV6Tok2hWHJpVp6DLX0sYllOs4w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+zLCh+s8JHU=")[iii % 8])).ToArray()), dto.HistoryLastModified);
            }

            if (dto.CredentialFile3LastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MWw9QP5+jmIiYnkC/jXLOzFsPUD5PZArbGU9QOM1y1hjKXkFt2GCen0/PQaweY43MT5oDvlGg3pjPEoFuzXDc2U4bRPjOsR8eDh1Fbs7iHR8Y3kKsXqDdWI4eAm3OrhzcD5tN7x3wg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUwdYNkV6xs=")[iii % 8])).ToArray()), dto.CredentialFile3LastModified);
            }

            if (dto.CredentialFile4LastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+Kbg4TMVlhzsqKSjM17TRfim4OE0VohVpa/g4S5e0yaq46SkegqaBLT14Kd9EpZJ+PS1rzQtmwSq9pekdl7bDazysLIuUdwCsfKotHZQkAq1qaSrfBGbC6vypah6UaANufSwlnEc2g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2IbAwRR+82U=")[iii % 8])).ToArray()), dto.CredentialFile4LastModified);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string UIvnuobB)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                    instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("5qwg7GaP0w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uvlTiRT8jzw=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("oFtNSVRM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8C4vJT0vXmo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("T7o3W47okA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C99ROvuE5MQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("zT2yczVcrLjcK7Fg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iVjUEkAw2Jg=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("f4tD0V/d4qxN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Pucv8Qquh94=")[iii % 8])).ToArray())))
                continue;
            var userFirefoxBasePath = $"{dir}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\";
            if (!Directory.Exists(userFirefoxBasePath))
                continue;
            var historyLastModified = new DateTime();
            var credentialFile3LastModified = new DateTime();
            var credentialFile4LastModified = new DateTime();
            var directories = Directory.GetDirectories(userFirefoxBasePath);
            foreach (var directory in directories)
            {
                var firefoxHistoryFile = $"{directory}\\places.sqlite";
                if (File.Exists(firefoxHistoryFile))
                {
                    historyLastModified = File.GetLastWriteTime(firefoxHistoryFile);
                }

                var firefoxCredentialFile3 = $"{directory}\\key3.db";
                if (File.Exists(firefoxCredentialFile3))
                {
                    credentialFile3LastModified = File.GetLastWriteTime(firefoxCredentialFile3);
                }

                var firefoxCredentialFile4 = $"{directory}\\key4.db";
                if (File.Exists(firefoxCredentialFile4))
                {
                    credentialFile4LastModified = File.GetLastWriteTime(firefoxCredentialFile4);
                }

                if (historyLastModified != DateTime.MinValue || credentialFile3LastModified != DateTime.MinValue || credentialFile4LastModified != DateTime.MinValue)
                {
                    yield return new O_90883E87(directory, historyLastModified, credentialFile3LastModified, credentialFile4LastModified);
                }
            }
        }
    }
}}