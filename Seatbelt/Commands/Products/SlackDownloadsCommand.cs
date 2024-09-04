using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    class O_D6EAFE82
    {
        public string? TeamID { get; set; }
        public string? UserID { get; set; }
        public string? DownloadPath { get; set; }
        public DateTime? StartTime { get; set; }
    }
internal class O_1E94569D : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("OwjpL4ar0LYGCOctiZw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aGSITO3vv8E=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Ejn4GmkLjpYsIaoPYw3Ak2J/+QVtG8XaJjf9B2AXz5Mxf6oPZRTLhA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QliKaQx4rvc=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Slack
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_1E94569D(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("gucy2sDHCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3rJBv7K0Vs0=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("VXMPP3tn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BQZtUxIE6y4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CBqTHao0JQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TH/1fN9YURw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MtTqE/JBfbcjwukA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("drGMcoctCZc=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("OGwYlqUr/VYK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eQB0tvBYmCQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userSlackDownloadsPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-downloads";
            if (File.Exists(userSlackDownloadsPath))
            {
                var Downloads = new List<O_D6EAFE82>();
                try
                {
                    var contents = File.ReadAllText(userSlackDownloadsPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    foreach (var w in deserialized)
                    {
                        var dls = (Dictionary<string, object>)w.Value;
                        foreach (var x in dls)
                        {
                            var dl = (Dictionary<string, object>)x.Value;
                            var download = new O_D6EAFE82();
                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("h9CTWvA2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("87XyN7lSlqY=")[iii % 8])).ToArray())))
                            {
                                download.TeamID = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("r9Dgq+L2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("27WBxquSFGc=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("wVhm9+M6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tCsDhapeFvU=")[iii % 8])).ToArray())))
                            {
                                download.UserID = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("IqcuI5d2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V9RLUd4SotQ=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("1nifII0DOfzidpwm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("shfoTuFsWJg=")[iii % 8])).ToArray())))
                            {
                                download.DownloadPath = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("pkb1pFOtWR2SSPai").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wimCyj/COHk=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("w83XV3W8UDbV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sLm2JQHoOVs=")[iii % 8])).ToArray())))
                            {
                                try
                                {
                                    download.StartTime = MiscUtil.UnixEpochToDateTime(long.Parse($"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("RwG8EmYpx2xR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NHXdYBJ9rgE=")[iii % 8])).ToArray())]}"));
                                }
                                catch
                                {
                                }
                            }

                            Downloads.Add(download);
                        }
                    }
                }
                catch (IOException exception)
                {
                    WriteError(exception.ToString());
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_F5497623(userName, Downloads);
            }
        }
    }

internal class O_F5497623 : O_4AED570F
{
    public O_F5497623(string userName, List<O_D6EAFE82> downloads)
    {
        UserName = userName;
        Downloads = downloads;
    }

    public string UserName { get; }
    public List<O_D6EAFE82> Downloads { get; }
}    [CommandOutputType(typeof(O_F5497623))]
    internal class O_A017355C : TextFormatterBase
    {
        public O_A017355C(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_F5497623)result;
            WriteLine($"  Downloads ({dto.UserName}):\n");
            foreach (var download in dto.Downloads)
            {
                WriteLine($"    TeamID       : {download.TeamID}");
                WriteLine($"    UserId       : {download.UserID}");
                WriteLine($"    DownloadPath : {download.DownloadPath}");
                WriteLine($"    StartTime    : {download.StartTime}\n");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string OSbbcgrV)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Collections.SortedList instance = new System.Collections.SortedList();
                        instance.GetKey(52);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_F5497623)result;
            WriteLine($"  Downloads ({dto.UserName}):\n");
            foreach (var download in dto.Downloads)
            {
                WriteLine($"    TeamID       : {download.TeamID}");
                WriteLine($"    UserId       : {download.UserID}");
                WriteLine($"    DownloadPath : {download.DownloadPath}");
                WriteLine($"    StartTime    : {download.StartTime}\n");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string bcoSgxbw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Collections.SortedList instance = new System.Collections.SortedList();
                    instance.GetKey(52);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("gucy2sDHCg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3rJBv7K0Vs0=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("VXMPP3tn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BQZtUxIE6y4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CBqTHao0JQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TH/1fN9YURw=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MtTqE/JBfbcjwukA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("drGMcoctCZc=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("OGwYlqUr/VYK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eQB0tvBYmCQ=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userSlackDownloadsPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-downloads";
            if (File.Exists(userSlackDownloadsPath))
            {
                var Downloads = new List<O_D6EAFE82>();
                try
                {
                    var contents = File.ReadAllText(userSlackDownloadsPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    foreach (var w in deserialized)
                    {
                        var dls = (Dictionary<string, object>)w.Value;
                        foreach (var x in dls)
                        {
                            var dl = (Dictionary<string, object>)x.Value;
                            var download = new O_D6EAFE82();
                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("h9CTWvA2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("87XyN7lSlqY=")[iii % 8])).ToArray())))
                            {
                                download.TeamID = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("r9Dgq+L2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("27WBxquSFGc=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("wVhm9+M6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tCsDhapeFvU=")[iii % 8])).ToArray())))
                            {
                                download.UserID = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("IqcuI5d2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("V9RLUd4SotQ=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("1nifII0DOfzidpwm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("shfoTuFsWJg=")[iii % 8])).ToArray())))
                            {
                                download.DownloadPath = $"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("pkb1pFOtWR2SSPai").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wimCyj/COHk=")[iii % 8])).ToArray())]}";
                            }

                            if (dl.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("w83XV3W8UDbV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sLm2JQHoOVs=")[iii % 8])).ToArray())))
                            {
                                try
                                {
                                    download.StartTime = MiscUtil.UnixEpochToDateTime(long.Parse($"{dl[Encoding.UTF8.GetString(Convert.FromBase64String("RwG8EmYpx2xR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NHXdYBJ9rgE=")[iii % 8])).ToArray())]}"));
                                }
                                catch
                                {
                                }
                            }

                            Downloads.Add(download);
                        }
                    }
                }
                catch (IOException exception)
                {
                    WriteError(exception.ToString());
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_F5497623(userName, Downloads);
            }
        }
    }
}}