using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_C9E57412 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("1aXfI5tOzrrepN44mVXC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ls2tTPYnu9c=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("seCu7H+c01CP+Pz5dZqdVcHCtO11gpYepOW7+jWtgVCX5PPQaoqBUMHptexugIFIwee183+c").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4YHcnxrv8zE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc,
        CommandGroup.Chromium
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_C9E57412(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("r+m5yCW3xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("87zKrVfEmrQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uhaSt2t1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6mPw2wIWKNg=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WOVb0rqusQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HIA9s8/CxVQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("EvSVYEsoigYD4pZz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VpHzAT5E/iY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MDO7ApW0HTQC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cV/XIsDHeEY=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Rn+nifBUz3dGcria1VnnUXVRsJXRafh+aFG6nOhgyHNoHpOYwFTnUn9YtozYQec=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gj7X+bQ1uxY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("s34lCqNn8SOzczoZhmrZD4ZcJxWUaeM2s3oxHYJa0DGKTXU+hnLkHqtaMxuSavEe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7z9VeucGhUI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ouG9zfpO8rui7KLe30PamIzBu9jtQOCuicG/2OJt9LuIxeD/zEDxqZvSkejNSvT6usG53OJr47yf1aHJ4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/qDNvb4vhto=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("DAl61EbgBhsMGmXFb+gcHQwHesFw4FIpPy5+02PzFyYfOG/WY6EhDjEqZsFe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UEgKpAKBcno=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var userChromiumHistoryPath = $"{dir}{path}History";
                if (File.Exists(userChromiumHistoryPath))
                {
                    var historyRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("QrcB6rc4BCgaox3qszQRIAy2Gfvufk1zQoQp6ZhpP3dC4E+2+H4+cjGDAsHqGUl1QfZctpwYFXJGn0rA+mFEZkWhXr3qGUgHNqg1oZl5R3pFoV696hlLYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("at91nsdEYlw=")[iii % 8])).ToArray()));
                    var URLs = new List<string>();
                    try
                    {
                        using var fs = new FileStream(userChromiumHistoryPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using var r = new StreamReader(fs);
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            var m = historyRegex.Match(line);
                            if (m.Success)
                            {
                                URLs.Add($"{m.Groups[0].ToString().Trim()}");
                            }
                        }
                    }
                    catch (IOException exception)
                    {
                        WriteError($"IO exception, history file likely in use (i.e. browser is likely running): {exception.Message}");
                    }
                    catch (Exception exception)
                    {
                        WriteError(exception.ToString());
                    }

                    yield return new O_8E41BA5B(userName, userChromiumHistoryPath, URLs);
                }
            }
        }
    }

internal class O_8E41BA5B : O_4AED570F
{
    public O_8E41BA5B(string userName, string filePath, List<string> urLs)
    {
        UserName = userName;
        FilePath = filePath;
        URLs = urLs;
    }

    public string UserName { get; }
    public string FilePath { get; }
    public List<string> URLs { get; }
}    [CommandOutputType(typeof(O_8E41BA5B))]
    internal class O_E2384155 : TextFormatterBase
    {
        public O_E2384155(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_8E41BA5B)result;
            WriteLine($"History ({dto.FilePath}):\n");
            foreach (var url in dto.URLs)
            {
                WriteLine($"  {url}");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string yrfmPYhz)
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

            var dto = (O_8E41BA5B)result;
            WriteLine($"History ({dto.FilePath}):\n");
            foreach (var url in dto.URLs)
            {
                WriteLine($"  {url}");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string BolCKghi)
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

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("r+m5yCW3xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("87zKrVfEmrQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uhaSt2t1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6mPw2wIWKNg=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("WOVb0rqusQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HIA9s8/CxVQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("EvSVYEsoigYD4pZz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VpHzAT5E/iY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("MDO7ApW0HTQC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cV/XIsDHeEY=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("Rn+nifBUz3dGcria1VnnUXVRsJXRafh+aFG6nOhgyHNoHpOYwFTnUn9YtozYQec=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gj7X+bQ1uxY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("s34lCqNn8SOzczoZhmrZD4ZcJxWUaeM2s3oxHYJa0DGKTXU+hnLkHqtaMxuSavEe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7z9VeucGhUI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("ouG9zfpO8rui7KLe30PamIzBu9jtQOCuicG/2OJt9LuIxeD/zEDxqZvSkejNSvT6usG53OJr47yf1aHJ4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/qDNvb4vhto=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("DAl61EbgBhsMGmXFb+gcHQwHesFw4FIpPy5+02PzFyYfOG/WY6EhDjEqZsFe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UEgKpAKBcno=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var userChromiumHistoryPath = $"{dir}{path}History";
                if (File.Exists(userChromiumHistoryPath))
                {
                    var historyRegex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("QrcB6rc4BCgaox3qszQRIAy2Gfvufk1zQoQp6ZhpP3dC4E+2+H4+cjGDAsHqGUl1QfZctpwYFXJGn0rA+mFEZkWhXr3qGUgHNqg1oZl5R3pFoV696hlLYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("at91nsdEYlw=")[iii % 8])).ToArray()));
                    var URLs = new List<string>();
                    try
                    {
                        using var fs = new FileStream(userChromiumHistoryPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        using var r = new StreamReader(fs);
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            var m = historyRegex.Match(line);
                            if (m.Success)
                            {
                                URLs.Add($"{m.Groups[0].ToString().Trim()}");
                            }
                        }
                    }
                    catch (IOException exception)
                    {
                        WriteError($"IO exception, history file likely in use (i.e. browser is likely running): {exception.Message}");
                    }
                    catch (Exception exception)
                    {
                        WriteError(exception.ToString());
                    }

                    yield return new O_8E41BA5B(userName, userChromiumHistoryPath, URLs);
                }
            }
        }
    }
}}