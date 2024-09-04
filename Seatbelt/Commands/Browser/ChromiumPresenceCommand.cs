using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Diagnostics;
using O_F41F88FA.Util;
using Microsoft.Win32;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_B48C984A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("ivITyhIZ2nKZ6ATWGh7Meg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yZphpX9wrx8=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("CaufBNSkY1Qs45MJy7IxWDm3kwnY9wBVOKyXApCSJ1ov7LgV3qEmEgWznxXe9yVUJqaJR9qvKk4+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SsP6Z7/XQz0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Chromium,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_B48C984A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        string chromeVersion = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FqFg7I3h0qw=")[iii % 8])).ToArray());
        if (!ThisRunTime.ISRemote())
        {
            var chromePath = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("19X8vxOz/gnY19OINp3fI+Lu5rwtnMgj8+nmqDGA3inq7uyONoHFI+rG+5s00vwt8PLJtyea3iPp/5SOPJc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJq660TyrEw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iMZfAq6sbKc=")[iii % 8])).ToArray()));
            if (chromePath != null)
            {
                chromeVersion = FileVersionInfo.GetVersionInfo(chromePath).ProductVersion;
            }
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("TRDnwt1j4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUWUp68QvsU=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("k//utWYV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w4qM2Q92GC4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("UJP8tQ7Yfg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FPaa1Hu0CuI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("wHIsfB3EZr3RZC9v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hBdKHWioEp0=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("O6WmkF8ejpgJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("esnKsApt6+o=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("50L2Fo8clmfnT+kFqhG+QdRs4QquIaFuyWzrA5cokWPJI8IHvxy+Qt5l5xOnCb4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uwOGZst94gY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("290wd8e765vb0C9k4rbDt+7/MmjwtfmO29kkYOaGyoni7mBD4q7+psP5Jmb2tuum").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h5xAB4Pan/o=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2mXUqasyjkPaaMu6jj+mYPRF0ry8PJxW8UXWvLMRiEPwQYmbnTyNUeNW+IycNogCwkXQuLMXn0TnUcitsw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hiSk2e9T+iI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("10gg+lITOgLXWz/rexsgBNdGIO9kE24w5G8k/XcAKz/EeTX4d1IdF+prPO9K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iwlQihZyTmM=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var chromeBasePath = $"{dir}{path}";
                if (!Directory.Exists(chromeBasePath))
                {
                    continue;
                }

                var history = new DateTime();
                var cookies = new DateTime();
                var loginData = new DateTime();
                var userChromeHistoryPath = $"{chromeBasePath}History";
                if (File.Exists(userChromeHistoryPath))
                {
                    history = File.GetLastWriteTime(userChromeHistoryPath);
                }

                var userChromeCookiesPath = $"{chromeBasePath}Cookies";
                if (File.Exists(userChromeCookiesPath))
                {
                    cookies = File.GetLastWriteTime(userChromeCookiesPath);
                }

                var userChromeLoginDataPath = $"{chromeBasePath}LoginData";
                if (File.Exists(userChromeLoginDataPath))
                {
                    loginData = File.GetLastWriteTime(userChromeLoginDataPath);
                }

                if (history != DateTime.MinValue || cookies != DateTime.MinValue || loginData != DateTime.MinValue)
                {
                    yield return new O_8E19C753($"{chromeBasePath}", history, cookies, loginData, chromeVersion);
                }
            }
        }
    }

internal class O_8E19C753 : O_4AED570F
{
    public O_8E19C753(string folder, DateTime historyLastModified, DateTime cookiesLastModified, DateTime loginDataLastModified, string chromeVersion)
    {
        Folder = folder;
        HistoryLastModified = historyLastModified;
        CookiesLastModified = cookiesLastModified;
        LoginDataLastModified = loginDataLastModified;
        ChromeVersion = chromeVersion;
    }

    public string Folder { get; }
    public DateTime HistoryLastModified { get; }
    public DateTime CookiesLastModified { get; }
    public DateTime LoginDataLastModified { get; }
    public string ChromeVersion { get; }
}    [CommandOutputType(typeof(O_8E19C753))]
    internal class O_65947B97 : TextFormatterBase
    {
        public O_65947B97(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_8E19C753)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+LeFM0HvoZE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9b2lEzrf3Js=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.HistoryLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qhOSdO8xulb+XMAt71nzBaoTmi/4BPoFqgmSdJoMvQX+W9d07zq7V+Ve2yGlMbpW/lzALe9ZsErnXtM6rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ijOyVMh50yU=")[iii % 8])).ToArray()), dto.HistoryLastModified);
            }

            if (dto.CookiesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("aIIzu4LfHSQjy3bogrxSa2iCO+CV4VtraJgzu/fpHGsbynLp1dgiChjrPMjN/QA7C8ph9Mj5UiQ6gmfzwLw/IiXLePrR5lJpLNJy68ymSCgg0Hz2wL5SJifGZvfA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SKITm6Wccks=")[iii % 8])).ToArray()), dto.CookiesLastModified);
            }

            if (dto.LoginDataLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("h03Zw7ORmIzOA9mn9amWzIdN0ZikoN7Lh1fZw8aomcv0BZiR5Jmnqvck1rD8vIWb5AWLjPm414TVTY2L8f26gsoEkoLgp9fJwx2Yk/3nzYjPH5aO8f/XhsgJjI/x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p23545Td9+s=")[iii % 8])).ToArray()), dto.LoginDataLastModified);
            }

            if (dto.Folder.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("kjjsv2Ou").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1VeD2A/Le6c=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KubvQDRINqtlq6pAQm4sqmOpoUA0K375KubvQDQrfvkq5u9ANCt++Srm9UA0cG6k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CsbPYBQLXtk=")[iii % 8])).ToArray()), dto.ChromeVersion);
                if (dto.ChromeVersion.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("lQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rRSPHaJnGZU=")[iii % 8])).ToArray())))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3WYkbMXbpAXdEGE+lpLrS90vd2zdy68J3ShhO8W/1GStDyQ/hpPhSJhmaTmWj6RHmGZxP4Cf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UYETOX7hCU=")[iii % 8])).ToArray()));
                }
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string ljcxmUVb)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.WriteByte(116);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_8E19C753)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+LeFM0HvoZE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9b2lEzrf3Js=")[iii % 8])).ToArray()), dto.Folder);
            if (dto.HistoryLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qhOSdO8xulb+XMAt71nzBaoTmi/4BPoFqgmSdJoMvQX+W9d07zq7V+Ve2yGlMbpW/lzALe9ZsErnXtM6rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ijOyVMh50yU=")[iii % 8])).ToArray()), dto.HistoryLastModified);
            }

            if (dto.CookiesLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("aIIzu4LfHSQjy3bogrxSa2iCO+CV4VtraJgzu/fpHGsbynLp1dgiChjrPMjN/QA7C8ph9Mj5UiQ6gmfzwLw/IiXLePrR5lJpLNJy68ymSCgg0Hz2wL5SJifGZvfA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SKITm6Wccks=")[iii % 8])).ToArray()), dto.CookiesLastModified);
            }

            if (dto.LoginDataLastModified != DateTime.MinValue)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("h03Zw7ORmIzOA9mn9amWzIdN0ZikoN7Lh1fZw8aomcv0BZiR5Jmnqvck1rD8vIWb5AWLjPm414TVTY2L8f26gsoEkoLgp9fJwx2Yk/3nzYjPH5aO8f/XhsgJjI/x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p23545Td9+s=")[iii % 8])).ToArray()), dto.LoginDataLastModified);
            }

            if (dto.Folder.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("kjjsv2Ou").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1VeD2A/Le6c=")[iii % 8])).ToArray())))
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("KubvQDRINqtlq6pAQm4sqmOpoUA0K375KubvQDQrfvkq5u9ANCt++Srm9UA0cG6k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CsbPYBQLXtk=")[iii % 8])).ToArray()), dto.ChromeVersion);
                if (dto.ChromeVersion.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("lQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rRSPHaJnGZU=")[iii % 8])).ToArray())))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("3WYkbMXbpAXdEGE+lpLrS90vd2zdy68J3ShhO8W/1GStDyQ/hpPhSJhmaTmWj6RHmGZxP4Cf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/UYETOX7hCU=")[iii % 8])).ToArray()));
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string FZbEXcbQ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.IO.MemoryStream instance = new System.IO.MemoryStream();
                    instance.WriteByte(24);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        string chromeVersion = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FqFg7I3h0qw=")[iii % 8])).ToArray());
        if (!ThisRunTime.ISRemote())
        {
            var chromePath = RegistryUtil.GetStringValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("19X8vxOz/gnY19OINp3fI+Lu5rwtnMgj8+nmqDGA3inq7uyONoHFI+rG+5s00vwt8PLJtyea3iPp/5SOPJc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hJq660TyrEw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iMZfAq6sbKc=")[iii % 8])).ToArray()));
            if (chromePath != null)
            {
                chromeVersion = FileVersionInfo.GetVersionInfo(chromePath).ProductVersion;
            }
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("TRDnwt1j4g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EUWUp68QvsU=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("k//utWYV").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w4qM2Q92GC4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("UJP8tQ7Yfg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FPaa1Hu0CuI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("wHIsfB3EZr3RZC9v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hBdKHWioEp0=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("O6WmkF8ejpgJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("esnKsApt6+o=")[iii % 8])).ToArray())))
            {
                continue;
            }

            string[] paths =
            {
                Encoding.UTF8.GetString(Convert.FromBase64String("50L2Fo8clmfnT+kFqhG+QdRs4QquIaFuyWzrA5cokWPJI8IHvxy+Qt5l5xOnCb4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uwOGZst94gY=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("290wd8e765vb0C9k4rbDt+7/MmjwtfmO29kkYOaGyoni7mBD4q7+psP5Jmb2tuum").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h5xAB4Pan/o=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("2mXUqasyjkPaaMu6jj+mYPRF0ry8PJxW8UXWvLMRiEPwQYmbnTyNUeNW+IycNogCwkXQuLMXn0TnUcitsw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hiSk2e9T+iI=")[iii % 8])).ToArray()),
                Encoding.UTF8.GetString(Convert.FromBase64String("10gg+lITOgLXWz/rexsgBNdGIO9kE24w5G8k/XcAKz/EeTX4d1IdF+prPO9K").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iwlQihZyTmM=")[iii % 8])).ToArray())
            };
            foreach (string path in paths)
            {
                var chromeBasePath = $"{dir}{path}";
                if (!Directory.Exists(chromeBasePath))
                {
                    continue;
                }

                var history = new DateTime();
                var cookies = new DateTime();
                var loginData = new DateTime();
                var userChromeHistoryPath = $"{chromeBasePath}History";
                if (File.Exists(userChromeHistoryPath))
                {
                    history = File.GetLastWriteTime(userChromeHistoryPath);
                }

                var userChromeCookiesPath = $"{chromeBasePath}Cookies";
                if (File.Exists(userChromeCookiesPath))
                {
                    cookies = File.GetLastWriteTime(userChromeCookiesPath);
                }

                var userChromeLoginDataPath = $"{chromeBasePath}LoginData";
                if (File.Exists(userChromeLoginDataPath))
                {
                    loginData = File.GetLastWriteTime(userChromeLoginDataPath);
                }

                if (history != DateTime.MinValue || cookies != DateTime.MinValue || loginData != DateTime.MinValue)
                {
                    yield return new O_8E19C753($"{chromeBasePath}", history, cookies, loginData, chromeVersion);
                }
            }
        }
    }
}}