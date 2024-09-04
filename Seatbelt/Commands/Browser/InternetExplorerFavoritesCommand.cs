using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_0C3745E8 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("R1i0fe5dDlx6eIE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dh3yHJgyfDU=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+bNCpGQBg5KQmE6xegCUg8L9UKBgAJSPxLhF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sN02wRZv5uY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_0C3745E8(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("sqUzslg+ew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7vBA1ypNJ2Q=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("pVEf7TjY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9SR9gVG7Y4Y=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("s7la3TUUog==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("99w8vEB41oI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("X146Xod4x89OSDlN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GztcP/IUs+8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("eC2HtfUijghK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OUHrlaBR63o=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userFavoritesPath = $"{dir}\\Favorites\\";
            if (!Directory.Exists(userFavoritesPath))
            {
                continue;
            }

            var bookmarkPaths = Directory.GetFiles(userFavoritesPath, Encoding.UTF8.GetString(Convert.FromBase64String("F4X9Itg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PauIULT1asI=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
            if (bookmarkPaths.Length == 0)
            {
                continue;
            }

            var favorites = new List<string>();
            foreach (var bookmarkPath in bookmarkPaths)
            {
                using var rdr = new StreamReader(bookmarkPath);
                string line;
                var url = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ULOQh2ALraU=")[iii % 8])).ToArray());
                while ((line = rdr.ReadLine()) != null)
                {
                    if (!line.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("p+wQcA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8r5cTfiKvEM=")[iii % 8])).ToArray()), StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    if (line.Length > 4)
                    {
                        url = line.Substring(4);
                    }

                    break;
                }

                favorites.Add(url.Trim());
            }

            yield return new O_B39D6AD4(userName, favorites);
        }
    }

internal class O_B39D6AD4 : O_4AED570F
{
    public O_B39D6AD4(string userName, List<string> favorites)
    {
        UserName = userName;
        Favorites = favorites;
    }

    public string UserName { get; }
    public List<string> Favorites { get; }
}    [CommandOutputType(typeof(O_B39D6AD4))]
    internal class O_8DAA4C84 : TextFormatterBase
    {
        public O_8DAA4C84(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_B39D6AD4)result;
            WriteLine($"Favorites ({dto.UserName}):\n");
            foreach (var favorite in dto.Favorites)
            {
                WriteLine($"  {favorite}");
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
                        System.Text.EncoderExceptionFallbackBuffer instance = new System.Text.EncoderExceptionFallbackBuffer();
                        instance.Fallback('f', 86);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_B39D6AD4)result;
            WriteLine($"Favorites ({dto.UserName}):\n");
            foreach (var favorite in dto.Favorites)
            {
                WriteLine($"  {favorite}");
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
                    System.Text.EncoderExceptionFallbackBuffer instance = new System.Text.EncoderExceptionFallbackBuffer();
                    instance.Fallback('f', 86);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("sqUzslg+ew==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7vBA1ypNJ2Q=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("pVEf7TjY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9SR9gVG7Y4Y=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("s7la3TUUog==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("99w8vEB41oI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("X146Xod4x89OSDlN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GztcP/IUs+8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("eC2HtfUijghK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OUHrlaBR63o=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userFavoritesPath = $"{dir}\\Favorites\\";
            if (!Directory.Exists(userFavoritesPath))
            {
                continue;
            }

            var bookmarkPaths = Directory.GetFiles(userFavoritesPath, Encoding.UTF8.GetString(Convert.FromBase64String("F4X9Itg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PauIULT1asI=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
            if (bookmarkPaths.Length == 0)
            {
                continue;
            }

            var favorites = new List<string>();
            foreach (var bookmarkPath in bookmarkPaths)
            {
                using var rdr = new StreamReader(bookmarkPath);
                string line;
                var url = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ULOQh2ALraU=")[iii % 8])).ToArray());
                while ((line = rdr.ReadLine()) != null)
                {
                    if (!line.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("p+wQcA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8r5cTfiKvEM=")[iii % 8])).ToArray()), StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    if (line.Length > 4)
                    {
                        url = line.Substring(4);
                    }

                    break;
                }

                favorites.Add(url.Trim());
            }

            yield return new O_B39D6AD4(userName, favorites);
        }
    }
}}