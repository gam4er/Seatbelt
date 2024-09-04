#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_E018A322
    {
        public string FileName { get; set; }
        public DateTime LastAccessed { get; set; }
        public DateTime LastModified { get; set; }
    }
internal class O_31978EBC : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("FL/mUyBLmvw0vfxTIEWVyw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("W8qSP08k8bg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("KKgUUc0iNvwBskdBgjMx/AugA0CJZD3pRI4SUYErMPs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZMFnJe1EX5A=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_31978EBC(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("wnNFLrNgUA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("niY2S8ETDM0=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("j//GsKP7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("34qk3MqYd/g=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("0zXMB2TO8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l1CqZhGihuY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CUZX2HlgCFIYUFTL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TSMxuQwMfHI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yT6/OvOvLaz7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iFLTGqbcSN4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userOutlookBasePath = $"{dir}\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.Outlook\\";
            if (!Directory.Exists(userOutlookBasePath))
            {
                continue;
            }

            var directories = Directory.GetDirectories(userOutlookBasePath);
            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);
                var Downloads = new List<O_E018A322>();
                foreach (var file in files)
                {
                    var download = new O_E018A322();
                    download.FileName = Path.GetFileName(file);
                    download.LastAccessed = File.GetLastAccessTime(file);
                    download.LastModified = File.GetLastAccessTime(file);
                    Downloads.Add(download);
                }

                yield return new O_CA34B509()
                {
                    Folder = $"{directory}",
                    Downloads = Downloads
                };
            }
        }
    }

internal class O_CA34B509 : O_4AED570F
{
    public string Folder { get; set; }
    public List<O_E018A322> Downloads { get; set; }
}    [CommandOutputType(typeof(O_CA34B509))]
    internal class O_27B7AAE4 : TextFormatterBase
    {
        public O_27B7AAE4(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_CA34B509)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qcPPNbtwG0yp2akh52l0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ieOJWtcUfj4=")[iii % 8])).ToArray()), dto.Folder);
            WriteLine($"    LastAccessed              LastModified              FileName");
            WriteLine($"    ------------              ------------              --------");
            foreach (var download in dto.Downloads)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Ixa1vpYWUlExBOi+zQZeBzIauKzfW15cIxburJA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AzaVnu0mfnw=")[iii % 8])).ToArray()), download.LastAccessed, download.LastModified, download.FileName);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string XvjQLZHD)
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

            var dto = (O_CA34B509)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qcPPNbtwG0yp2akh52l0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ieOJWtcUfj4=")[iii % 8])).ToArray()), dto.Folder);
            WriteLine($"    LastAccessed              LastModified              FileName");
            WriteLine($"    ------------              ------------              --------");
            foreach (var download in dto.Downloads)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Ixa1vpYWUlExBOi+zQZeBzIauKzfW15cIxburJA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AzaVnu0mfnw=")[iii % 8])).ToArray()), download.LastAccessed, download.LastModified, download.FileName);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string RXFmgshT)
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

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("wnNFLrNgUA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("niY2S8ETDM0=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("j//GsKP7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("34qk3MqYd/g=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("0zXMB2TO8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l1CqZhGihuY=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("CUZX2HlgCFIYUFTL").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TSMxuQwMfHI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("yT6/OvOvLaz7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iFLTGqbcSN4=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userOutlookBasePath = $"{dir}\\AppData\\Local\\Microsoft\\Windows\\INetCache\\Content.Outlook\\";
            if (!Directory.Exists(userOutlookBasePath))
            {
                continue;
            }

            var directories = Directory.GetDirectories(userOutlookBasePath);
            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);
                var Downloads = new List<O_E018A322>();
                foreach (var file in files)
                {
                    var download = new O_E018A322();
                    download.FileName = Path.GetFileName(file);
                    download.LastAccessed = File.GetLastAccessTime(file);
                    download.LastModified = File.GetLastAccessTime(file);
                    Downloads.Add(download);
                }

                yield return new O_CA34B509()
                {
                    Folder = $"{directory}",
                    Downloads = Downloads
                };
            }
        }
    }
}}
#nullable enable
