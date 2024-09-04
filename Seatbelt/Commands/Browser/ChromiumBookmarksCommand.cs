using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
    internal class O_1BAC4007
    {
        public O_1BAC4007(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public string Name { get; }
        public string Url { get; }
    }
internal class O_0D879548 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("MSBQtzgj5Q4wJ02zOCviCAE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ckgi2FVKkGM=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("upM/KuYH0pWEi20/7AGckMqxJSvsGZfbr5YqPKw2gJWcl2IW8xGAlcqQIjboGZOGgdIrMO8RgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6vJNWYN08vQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc,
        CommandGroup.Chromium
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_0D879548(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("8Ml74bN8SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rJwIhMEPFKQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Dcw7zaYi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XblZoc9Ba/M=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("+EL+HvwxQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vCeYf4ldNI8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("kCSmiWu8fuSBMqWa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1EHA6B7QCsQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9frybUg8dLfH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tJaeTR1PEcU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("3i5Y2nETdk3eI0fJVB5ea+0AT8ZQLkFE8ABFz2kncUnwT2zLQRNeaOcJSd9ZBl4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gm8oqjVyAiw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Nai+XM50M981paFP63kb8wCKvEP5eiHKNayqS+9JEs0Mm+5o62Em4i2MqE3/eTPi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aenOLIoVR74=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("sKcv9ed9O4uwqjDmwnATqJ6HKeDwcymem4ct4P9ePYuag3LH0XM4mYmUA9DQeT3KqIcr5P9YKoyNkzPx/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7OZfhaMcT+o=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("zbFLmIl4T17NolSJoHBVWM2/S42/eBts/pZPn6xrXmPegF6arDloS/CSV42R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kfA76M0ZOz8=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var userChromeBookmarkPath = $"{dir}{path}Bookmarks";
                if (!File.Exists(userChromeBookmarkPath))
                    continue;
                var bookmarks = new List<O_1BAC4007>();
                try
                {
                    var contents = File.ReadAllText(userChromeBookmarkPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    var roots = (Dictionary<string, object>)deserialized[Encoding.UTF8.GetString(Convert.FromBase64String("GeqCUlQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a4XtJifWOxg=")[iii % 8])).ToArray())];
                    var bookmarkBar = (Dictionary<string, object>)roots[Encoding.UTF8.GetString(Convert.FromBase64String("vckpoy6FSeKAxCe6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36ZGyEPkO4k=")[iii % 8])).ToArray())];
                    var children = (ArrayList)bookmarkBar[Encoding.UTF8.GetString(Convert.FromBase64String("wZJOlQ/pLm4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ovon+WubSwA=")[iii % 8])).ToArray())];
                    foreach (Dictionary<string, object> entry in children)
                    {
                        var bookmark = new O_1BAC4007($"{entry[Encoding.UTF8.GetString(Convert.FromBase64String("PGlD4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ugguh0K9oo4=")[iii % 8])).ToArray())].ToString().Trim()}", entry.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("ZO1Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EZ80zWvk9u8=")[iii % 8])).ToArray())) ? $"{entry[Encoding.UTF8.GetString(Convert.FromBase64String("ubHO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zMOic7gdYpw=")[iii % 8])).ToArray())]}" : Encoding.UTF8.GetString(Convert.FromBase64String("9zaXkWrAixK0VL6RbcmPEuBd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("33T4/gGt6mA=")[iii % 8])).ToArray()));
                        bookmarks.Add(bookmark);
                    }
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_9EBCBFCE(userName, userChromeBookmarkPath, bookmarks);
            }
        }
    }

internal class O_9EBCBFCE : O_4AED570F
{
    public O_9EBCBFCE(string userName, string filePath, List<O_1BAC4007> bookmarks)
    {
        UserName = userName;
        FilePath = filePath;
        Bookmarks = bookmarks;
    }

    public string UserName { get; }
    public string FilePath { get; }
    public List<O_1BAC4007> Bookmarks { get; }
}    [CommandOutputType(typeof(O_9EBCBFCE))]
    internal class O_230D47AE : TextFormatterBase
    {
        public O_230D47AE(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_9EBCBFCE)result;
            if (dto.Bookmarks.Count > 0)
            {
                WriteLine($"Bookmarks ({dto.FilePath}):\n");
                foreach (var bookmark in dto.Bookmarks)
                {
                    WriteLine($"    Name : {bookmark.Name}");
                    WriteLine($"    URL  : {bookmark.Url}\n");
                }

                WriteLine();
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string BBBmPqMA)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.IsLeapDay(31, 38, 36, 22);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_9EBCBFCE)result;
            if (dto.Bookmarks.Count > 0)
            {
                WriteLine($"Bookmarks ({dto.FilePath}):\n");
                foreach (var bookmark in dto.Bookmarks)
                {
                    WriteLine($"    Name : {bookmark.Name}");
                    WriteLine($"    URL  : {bookmark.Url}\n");
                }

                WriteLine();
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string QTSLmiPf)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                    instance.IsLeapDay(31, 38, 36, 22);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("8Ml74bN8SA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rJwIhMEPFKQ=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Dcw7zaYi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XblZoc9Ba/M=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("+EL+HvwxQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vCeYf4ldNI8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("kCSmiWu8fuSBMqWa").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1EHA6B7QCsQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9frybUg8dLfH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tJaeTR1PEcU=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("3i5Y2nETdk3eI0fJVB5ea+0AT8ZQLkFE8ABFz2kncUnwT2zLQRNeaOcJSd9ZBl4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gm8oqjVyAiw=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("Nai+XM50M981paFP63kb8wCKvEP5eiHKNayqS+9JEs0Mm+5o62Em4i2MqE3/eTPi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aenOLIoVR74=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("sKcv9ed9O4uwqjDmwnATqJ6HKeDwcymem4ct4P9ePYuag3LH0XM4mYmUA9DQeT3KqIcr5P9YKoyNkzPx/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7OZfhaMcT+o=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("zbFLmIl4T17NolSJoHBVWM2/S42/eBts/pZPn6xrXmPegF6arDloS/CSV42R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kfA76M0ZOz8=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var userChromeBookmarkPath = $"{dir}{path}Bookmarks";
                if (!File.Exists(userChromeBookmarkPath))
                    continue;
                var bookmarks = new List<O_1BAC4007>();
                try
                {
                    var contents = File.ReadAllText(userChromeBookmarkPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    var roots = (Dictionary<string, object>)deserialized[Encoding.UTF8.GetString(Convert.FromBase64String("GeqCUlQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a4XtJifWOxg=")[iii % 8])).ToArray())];
                    var bookmarkBar = (Dictionary<string, object>)roots[Encoding.UTF8.GetString(Convert.FromBase64String("vckpoy6FSeKAxCe6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("36ZGyEPkO4k=")[iii % 8])).ToArray())];
                    var children = (ArrayList)bookmarkBar[Encoding.UTF8.GetString(Convert.FromBase64String("wZJOlQ/pLm4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ovon+WubSwA=")[iii % 8])).ToArray())];
                    foreach (Dictionary<string, object> entry in children)
                    {
                        var bookmark = new O_1BAC4007($"{entry[Encoding.UTF8.GetString(Convert.FromBase64String("PGlD4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ugguh0K9oo4=")[iii % 8])).ToArray())].ToString().Trim()}", entry.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("ZO1Y").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EZ80zWvk9u8=")[iii % 8])).ToArray())) ? $"{entry[Encoding.UTF8.GetString(Convert.FromBase64String("ubHO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zMOic7gdYpw=")[iii % 8])).ToArray())]}" : Encoding.UTF8.GetString(Convert.FromBase64String("9zaXkWrAixK0VL6RbcmPEuBd").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("33T4/gGt6mA=")[iii % 8])).ToArray()));
                        bookmarks.Add(bookmark);
                    }
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_9EBCBFCE(userName, userChromeBookmarkPath, bookmarks);
            }
        }
    }
}}