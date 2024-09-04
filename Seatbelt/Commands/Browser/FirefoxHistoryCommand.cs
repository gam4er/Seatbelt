using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_2D3C06EE : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("0ChbcE48zw7/Ml16Wio=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lkEpFShTt0Y=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("z8IZ/q8YuHDx2kvrpR72db/lAv+vLfdpv8sC/r4E6mi/xQLhrxg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n6NrjcprmBE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_2D3C06EE(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("060At0gDKw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j/hz0jpwdyQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("EIVShhz3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QPAw6nWUW/c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("eVCvw1U7hg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PTXJoiBX8vw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("3fsnYCNF1fLM7SRz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mZ5BAVYpodI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("vg/jC96kl0eM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/2OPK4vX8jU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userFirefoxBasePath = $"{dir}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\";
            if (Directory.Exists(userFirefoxBasePath))
            {
                var history = new List<string>();
                var directories = Directory.GetDirectories(userFirefoxBasePath);
                foreach (var directory in directories)
                {
                    var firefoxHistoryFile = $"{directory}\\places.sqlite";
                    var historyRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("LUgqXPTDyjJ1XDZc8M/fOmNJMk2thYNpLXsCX9uS8W0tH2QAu4XwaF58KXep4odvLgl3AN/j22gpYGF2uZqKfCpedQup4oYdWVceF9qCiWAqXnULqeKFeQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BSBeKIS/rEY=")[iii % 8])).ToArray()));
                    try
                    {
                        using (var r = new StreamReader(firefoxHistoryFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                var m = historyRegex.Match(line);
                                if (m.Success)
                                {
                                    history.Add(m.Groups[0].ToString().Trim());
                                }
                            }
                        }
                    }
                    catch (IOException exception)
                    {
                        WriteError($"IO exception, places.sqlite file likely in use (i.e. Firefox is likely running). {exception.Message}");
                    }
                    catch (Exception e)
                    {
                        WriteError(e.ToString());
                    }
                }

                yield return new O_83C336E7(userName, history);
            }
        }
    }

internal class O_83C336E7 : O_4AED570F
{
    public O_83C336E7(string userName, List<string> history)
    {
        UserName = userName;
        History = history;
    }

    public string UserName { get; }
    public List<string> History { get; }
}    [CommandOutputType(typeof(O_83C336E7))]
    internal class O_8DAA4C84 : TextFormatterBase
    {
        public O_8DAA4C84(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_83C336E7)result;
            WriteLine($"\n    History ({dto.UserName}):\n");
            foreach (var history in dto.History)
            {
                WriteLine($"       {history}");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string rShWfNHS)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                        instance.GetMaxByteCount(86);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_83C336E7)result;
            WriteLine($"\n    History ({dto.UserName}):\n");
            foreach (var history in dto.History)
            {
                WriteLine($"       {history}");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string tILNymSJ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                    instance.GetMaxByteCount(86);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("060At0gDKw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j/hz0jpwdyQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("EIVShhz3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QPAw6nWUW/c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("eVCvw1U7hg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PTXJoiBX8vw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("3fsnYCNF1fLM7SRz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mZ5BAVYpodI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("vg/jC96kl0eM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/2OPK4vX8jU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userFirefoxBasePath = $"{dir}\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\";
            if (Directory.Exists(userFirefoxBasePath))
            {
                var history = new List<string>();
                var directories = Directory.GetDirectories(userFirefoxBasePath);
                foreach (var directory in directories)
                {
                    var firefoxHistoryFile = $"{directory}\\places.sqlite";
                    var historyRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("LUgqXPTDyjJ1XDZc8M/fOmNJMk2thYNpLXsCX9uS8W0tH2QAu4XwaF58KXep4odvLgl3AN/j22gpYGF2uZqKfCpedQup4oYdWVceF9qCiWAqXnULqeKFeQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BSBeKIS/rEY=")[iii % 8])).ToArray()));
                    try
                    {
                        using (var r = new StreamReader(firefoxHistoryFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                var m = historyRegex.Match(line);
                                if (m.Success)
                                {
                                    history.Add(m.Groups[0].ToString().Trim());
                                }
                            }
                        }
                    }
                    catch (IOException exception)
                    {
                        WriteError($"IO exception, places.sqlite file likely in use (i.e. Firefox is likely running). {exception.Message}");
                    }
                    catch (Exception e)
                    {
                        WriteError(e.ToString());
                    }
                }

                yield return new O_83C336E7(userName, history);
            }
        }
    }
}}