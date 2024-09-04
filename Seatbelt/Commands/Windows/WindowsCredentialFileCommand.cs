using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    internal class O_8BC87FE5
    {
        public O_8BC87FE5(string fileName, string description, Guid guidMasterKey, DateTime lastAccessed, DateTime lastModified, long size)
        {
            FileName = fileName;
            Description = description;
            GuidMasterKey = guidMasterKey;
            LastAccessed = lastAccessed;
            LastModified = lastModified;
            Size = size;
        }

        public string FileName { get; set; }
        public string Description { get; set; }
        public Guid GuidMasterKey { get; set; }
        public DateTime LastAccessed { get; set; }
        public DateTime LastModified { get; set; }
        public long Size { get; set; }
    }
internal class O_99C48D6F : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("+6vBJD50yHjep8slP3fSWsCExiw0cA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rMKvQFEDuzs=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("gGrcSMAVDc+0cddIygwKhrZvkmj/Iy6m92HeQ80R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1wOyLK9ifu8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_99C48D6F(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var systemRoot = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("gDgjTD9CWbW8NQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("00FQOFovC9o=")[iii % 8])).ToArray()));
        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("Xb5xhJ4SsORnsWc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DscC8Pt/9JY=")[iii % 8])).ToArray()))}\\Users\\";
        var credentialFolders = new List<string>()
        {
            $"{systemRoot}\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\System32\\config\\systemprofile\\AppData\\Roaming\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\LocalService\\AppData\\Roaming\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\Credentials"};
        foreach (var dir in Directory.GetDirectories(userFolder))
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("NBJ63/bs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZGcYs5+PegU=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("XY2TAkPvIQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gej1YzaDVZo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("FHBI9GeQ97MFZkvn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UBUulRL8g5M=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JZIZ6W81eesX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZP51yTpGHJk=")[iii % 8])).ToArray())))
            {
                continue;
            }

            credentialFolders.Add($"{dir}\\AppData\\Local\\Microsoft\\Credentials\\");
            credentialFolders.Add($"{dir}\\AppData\\Roaming\\Microsoft\\Credentials\\");
        };
        foreach (var credPath in credentialFolders)
        {
            foreach (var commandDtoBase in GetCredentialsFromDirectory(credPath))
                yield return commandDtoBase;
        }
    }

    private IEnumerable<O_4AED570F> GetCredentialsFromDirectory(string credPath)
    {
        if (!Directory.Exists(credPath))
            yield break;
        var userFiles = Directory.GetFiles(credPath);
        if (userFiles.Length == 0)
            yield break;
        var userCredentials = userFiles.Select(CredentialFile).ToList();
        yield return new O_8CB6CE5F(credPath, userCredentials);
    }

    private O_8BC87FE5 CredentialFile(string file)
    {
        var size = new FileInfo(file).Length;
        var credentialArray = File.ReadAllBytes(file);
        var guidMasterKeyArray = new byte[16];
        Array.Copy(credentialArray, 36, guidMasterKeyArray, 0, 16);
        var guidMasterKey = new Guid(guidMasterKeyArray);
        var stringLenArray = new byte[16];
        Array.Copy(credentialArray, 56, stringLenArray, 0, 4);
        var descLen = BitConverter.ToInt32(stringLenArray, 0);
        var descBytes = new byte[descLen - 4];
        Array.Copy(credentialArray, 60, descBytes, 0, descBytes.Length);
        var desc = Encoding.Unicode.GetString(descBytes);
        var cred = new O_8BC87FE5(Path.GetFileName(file), desc, guidMasterKey, File.GetLastAccessTime(file), File.GetLastAccessTime(file), size);
        return cred;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string hOUFjgeu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.AddYears(new System.DateTime(), 65);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var systemRoot = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("gDgjTD9CWbW8NQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("00FQOFovC9o=")[iii % 8])).ToArray()));
        var userFolder = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("Xb5xhJ4SsORnsWc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DscC8Pt/9JY=")[iii % 8])).ToArray()))}\\Users\\";
        var credentialFolders = new List<string>()
        {
            $"{systemRoot}\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\System32\\config\\systemprofile\\AppData\\Roaming\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\LocalService\\AppData\\Roaming\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\NetworkService\\AppData\\Local\\Microsoft\\Credentials",
            $"{systemRoot}\\ServiceProfiles\\NetworkService\\AppData\\Roaming\\Microsoft\\Credentials"};
        foreach (var dir in Directory.GetDirectories(userFolder))
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("NBJ63/bs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZGcYs5+PegU=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("XY2TAkPvIQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gej1YzaDVZo=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("FHBI9GeQ97MFZkvn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UBUulRL8g5M=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JZIZ6W81eesX").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZP51yTpGHJk=")[iii % 8])).ToArray())))
            {
                continue;
            }

            credentialFolders.Add($"{dir}\\AppData\\Local\\Microsoft\\Credentials\\");
            credentialFolders.Add($"{dir}\\AppData\\Roaming\\Microsoft\\Credentials\\");
        };
        foreach (var credPath in credentialFolders)
        {
            foreach (var commandDtoBase in GetCredentialsFromDirectory(credPath))
                yield return commandDtoBase;
        }
    }

    private IEnumerable<O_4AED570F> GetCredentialsFromDirectory(string credPath, string bAIhDrQt)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.AddYears(new System.DateTime(), 65);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!Directory.Exists(credPath))
            yield break;
        var userFiles = Directory.GetFiles(credPath);
        if (userFiles.Length == 0)
            yield break;
        var userCredentials = userFiles.Select(CredentialFile).ToList();
        yield return new O_8CB6CE5F(credPath, userCredentials);
    }

    private O_8BC87FE5 CredentialFile(string file, string JTdTzolO)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.AddYears(new System.DateTime(), 65);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var size = new FileInfo(file).Length;
        var credentialArray = File.ReadAllBytes(file);
        var guidMasterKeyArray = new byte[16];
        Array.Copy(credentialArray, 36, guidMasterKeyArray, 0, 16);
        var guidMasterKey = new Guid(guidMasterKeyArray);
        var stringLenArray = new byte[16];
        Array.Copy(credentialArray, 56, stringLenArray, 0, 4);
        var descLen = BitConverter.ToInt32(stringLenArray, 0);
        var descBytes = new byte[descLen - 4];
        Array.Copy(credentialArray, 60, descBytes, 0, descBytes.Length);
        var desc = Encoding.Unicode.GetString(descBytes);
        var cred = new O_8BC87FE5(Path.GetFileName(file), desc, guidMasterKey, File.GetLastAccessTime(file), File.GetLastAccessTime(file), size);
        return cred;
    }
}internal class O_8CB6CE5F : O_4AED570F
{
    public O_8CB6CE5F(string folder, List<O_8BC87FE5> credentials)
    {
        Folder = folder;
        CredentialInfo = credentials;
    }

    public string Folder { get; set; }
    public List<O_8BC87FE5> CredentialInfo { get; }
}
    [CommandOutputType(typeof(O_8CB6CE5F))]
    internal class O_581F0E19 : TextFormatterBase
    {
        public O_581F0E19(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_8CB6CE5F)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xiJJiRBgyUHGOC+dTHmm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5gIP5nwErDM=")[iii % 8])).ToArray()), dto.Folder);
            foreach (var credentialFile in dto.CredentialInfo)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vf0zEIagPx/TvH5V4OlzWr3nM0vwtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nd0TMMDJU3o=")[iii % 8])).ToArray()), credentialFile.FileName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zwb2JU/ebAidT6ZxYtRxS88c9n47xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ybWBQu7H2s=")[iii % 8])).ToArray()), credentialFile.Description);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ZtCWmYANX6Qjgv3ctEwM8GbKlsL9EQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RvC2uc1sLNA=")[iii % 8])).ToArray()), credentialFile.GuidMasterKey);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4gFwLI15ahaxUjVo7DopU+IbcHf8Zw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wiFQDMwaCXM=")[iii % 8])).ToArray()), credentialFile.LastAccessed);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("rJy5+LvQT6nq1fy81p8L4KyGuaPGwg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jLyZ2Pa/K8A=")[iii % 8])).ToArray()), credentialFile.LastModified);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hW2YEmyRi2+FbZgSH9jRKoV3mEkPhfs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pU24Mj/48Qo=")[iii % 8])).ToArray()), credentialFile.Size);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string DIvMrnCo)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                        instance.AddYears(new System.DateTime(), 65);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_8CB6CE5F)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xiJJiRBgyUHGOC+dTHmm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5gIP5nwErDM=")[iii % 8])).ToArray()), dto.Folder);
            foreach (var credentialFile in dto.CredentialInfo)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vf0zEIagPx/TvH5V4OlzWr3nM0vwtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nd0TMMDJU3o=")[iii % 8])).ToArray()), credentialFile.FileName);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zwb2JU/ebAidT6ZxYtRxS88c9n47xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7ybWBQu7H2s=")[iii % 8])).ToArray()), credentialFile.Description);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ZtCWmYANX6Qjgv3ctEwM8GbKlsL9EQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RvC2uc1sLNA=")[iii % 8])).ToArray()), credentialFile.GuidMasterKey);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4gFwLI15ahaxUjVo7DopU+IbcHf8Zw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wiFQDMwaCXM=")[iii % 8])).ToArray()), credentialFile.LastAccessed);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("rJy5+LvQT6nq1fy81p8L4KyGuaPGwg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jLyZ2Pa/K8A=")[iii % 8])).ToArray()), credentialFile.LastModified);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hW2YEmyRi2+FbZgSH9jRKoV3mEkPhfs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pU24Mj/48Qo=")[iii % 8])).ToArray()), credentialFile.Size);
            }

            WriteLine();
        }
    }
}