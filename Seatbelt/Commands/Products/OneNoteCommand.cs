using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Products
{
internal class O_7D249D08 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("CpeNPEudzg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RfnociTpq0o=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("17O11TmyHX7VtbLEOZ8SePCvtoF/lB9+6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m9rGoRn9cxs=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public Runtime ThisRunTime;
    public O_7D249D08(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("6XPU3M+ppg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tSanub3a+tI=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("l831Tmqx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x7iXIgPSYfo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("23wl/PeN3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nxlDnYLhq7o=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("53ZdvCjW0WP2YF6v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oxM73V26pUM=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("e/YVKOHSbExJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Opp5CLShCT4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userOneNoteBasePath = $"{dir}\\AppData\\Local\\Microsoft\\OneNote";
            var resultFiles = new List<String>();
            if (Directory.Exists(userOneNoteBasePath))
            {
                var oneNoteFiles = Directory.GetFiles(userOneNoteBasePath, Encoding.UTF8.GetString(Convert.FromBase64String("wbUEbK8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("65trAspUfc8=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
                resultFiles.AddRange(oneNoteFiles);
            }

            yield return new O_F4467FE4(userName, resultFiles);
        }
    }

internal class O_F4467FE4 : O_4AED570F
{
    public O_F4467FE4(string userName, List<string> files)
    {
        UserName = userName;
        Files = files;
    }

    public string UserName { get; }
    public List<string> Files { get; }
}    [CommandOutputType(typeof(O_F4467FE4))]
    internal class O_4C383933 : TextFormatterBase
    {
        public O_4C383933(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_F4467FE4)result;
            WriteLine($"\n    OneNote files ({dto.UserName}):\n");
            foreach (var file in dto.Files)
            {
                WriteLine($"       {file}");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string gmmyalnq)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                        instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_F4467FE4)result;
            WriteLine($"\n    OneNote files ({dto.UserName}):\n");
            foreach (var file in dto.Files)
            {
                WriteLine($"       {file}");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string USMJWxOZ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                    instance.ImportParameters(new System.Security.Cryptography.DSAParameters());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("6XPU3M+ppg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tSanub3a+tI=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("l831Tmqx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x7iXIgPSYfo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("23wl/PeN3w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nxlDnYLhq7o=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("53ZdvCjW0WP2YF6v").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oxM73V26pUM=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("e/YVKOHSbExJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Opp5CLShCT4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userOneNoteBasePath = $"{dir}\\AppData\\Local\\Microsoft\\OneNote";
            var resultFiles = new List<String>();
            if (Directory.Exists(userOneNoteBasePath))
            {
                var oneNoteFiles = Directory.GetFiles(userOneNoteBasePath, Encoding.UTF8.GetString(Convert.FromBase64String("wbUEbK8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("65trAspUfc8=")[iii % 8])).ToArray()), SearchOption.AllDirectories);
                resultFiles.AddRange(oneNoteFiles);
            }

            yield return new O_F4467FE4(userName, resultFiles);
        }
    }
}}