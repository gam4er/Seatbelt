using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_EAA5DD1A : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("Oa8f+s8TAAweph77wjEeGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("esNwj6tQcmk=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ojbMMFFdoUePBLBebEe8Rcwj82pzX6dYwwLzcGNW7kORBPt6eEanQY9B+XZ6V70=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("42GfHxYyziA=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_EAA5DD1A(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("h0XOhCGWEw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2xC94VPlTxA=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("1RJYDNgG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hWc6YLFlj5c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("tvIaF4SruQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8pd8dvHHzRI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sQJx1STP496gFHLG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WcXtFGjl/4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("hbmIXm1Zb6W3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xNXkfjgqCtc=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var awsKeyFile = $"{dir}\\.aws\\credentials";
            if (File.Exists(awsKeyFile))
            {
                var lastAccessed = File.GetLastAccessTime(awsKeyFile);
                var lastModified = File.GetLastWriteTime(awsKeyFile);
                var size = new FileInfo(awsKeyFile).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("KfAH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aKdUSGD+sSM=")[iii % 8])).ToArray()), awsKeyFile, lastAccessed, lastModified, size);
            }

            string[] googleCredLocations =
            {
                $"{dir}\\AppData\\Roaming\\gcloud\\credentials.db",
                $"{dir}\\AppData\\Roaming\\gcloud\\legacy_credentials",
                $"{dir}\\AppData\\Roaming\\gcloud\\access_tokens.db"};
            foreach (var googleCredLocation in googleCredLocations)
            {
                if (!File.Exists(googleCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(googleCredLocation);
                var lastModified = File.GetLastWriteTime(googleCredLocation);
                var size = new FileInfo(googleCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("G13J9z+h").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XDKmkFPEY7k=")[iii % 8])).ToArray()), googleCredLocation, lastAccessed, lastModified, size);
            }

            string[] azureCredLocations =
            {
                $"{dir}\\.azure\\azureProfile.json",
                $"{dir}\\.azure\\TokenCache.dat",
                $"{dir}\\.azure\\AzureRMContext.json",
                $"{dir}\\AppData\\Roaming\\Windows Azure Powershell\\TokenCache.dat",
                $"{dir}\\AppData\\Roaming\\Windows Azure Powershell\\AzureRMContext.json"};
            foreach (var azureCredLocation in azureCredLocations)
            {
                if (!File.Exists(azureCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(azureCredLocation);
                var lastModified = File.GetLastWriteTime(azureCredLocation);
                var size = new FileInfo(azureCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("ankndKE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KwNSBsQJb64=")[iii % 8])).ToArray()), azureCredLocation, lastAccessed, lastModified, size);
            }

            string[] bluemixCredLocations =
            {
                $"{dir}\\.bluemix\\config.json",
                $"{dir}\\.bluemix\\.cf\\config.json"};
            foreach (var bluemixCredLocation in bluemixCredLocations)
            {
                if (!File.Exists(bluemixCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(bluemixCredLocation);
                var lastModified = File.GetLastWriteTime(bluemixCredLocation);
                var size = new FileInfo(bluemixCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("ibIiR5U1Lg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y95XIvhcVo8=")[iii % 8])).ToArray()), bluemixCredLocation, lastAccessed, lastModified, size);
            }
        }
    }

internal class O_2DB4352B : O_4AED570F
{
    public O_2DB4352B(string type, string fileName, DateTime lastAccessed, DateTime lastModified, long size)
    {
        Type = type;
        FileName = fileName;
        LastAccessed = lastAccessed;
        LastModified = lastModified;
        Size = size;
    }

    public string Type { get; }
    public string FileName { get; }
    public DateTime LastAccessed { get; }
    public DateTime LastModified { get; }
    public long Size { get; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string PeKkXgVt)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.StringInfo instance = new System.Globalization.StringInfo();
                    instance.SubstringByTextElements(29);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("h0XOhCGWEw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2xC94VPlTxA=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("1RJYDNgG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hWc6YLFlj5c=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("tvIaF4SruQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8pd8dvHHzRI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sQJx1STP496gFHLG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WcXtFGjl/4=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("hbmIXm1Zb6W3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xNXkfjgqCtc=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var awsKeyFile = $"{dir}\\.aws\\credentials";
            if (File.Exists(awsKeyFile))
            {
                var lastAccessed = File.GetLastAccessTime(awsKeyFile);
                var lastModified = File.GetLastWriteTime(awsKeyFile);
                var size = new FileInfo(awsKeyFile).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("KfAH").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aKdUSGD+sSM=")[iii % 8])).ToArray()), awsKeyFile, lastAccessed, lastModified, size);
            }

            string[] googleCredLocations =
            {
                $"{dir}\\AppData\\Roaming\\gcloud\\credentials.db",
                $"{dir}\\AppData\\Roaming\\gcloud\\legacy_credentials",
                $"{dir}\\AppData\\Roaming\\gcloud\\access_tokens.db"};
            foreach (var googleCredLocation in googleCredLocations)
            {
                if (!File.Exists(googleCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(googleCredLocation);
                var lastModified = File.GetLastWriteTime(googleCredLocation);
                var size = new FileInfo(googleCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("G13J9z+h").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XDKmkFPEY7k=")[iii % 8])).ToArray()), googleCredLocation, lastAccessed, lastModified, size);
            }

            string[] azureCredLocations =
            {
                $"{dir}\\.azure\\azureProfile.json",
                $"{dir}\\.azure\\TokenCache.dat",
                $"{dir}\\.azure\\AzureRMContext.json",
                $"{dir}\\AppData\\Roaming\\Windows Azure Powershell\\TokenCache.dat",
                $"{dir}\\AppData\\Roaming\\Windows Azure Powershell\\AzureRMContext.json"};
            foreach (var azureCredLocation in azureCredLocations)
            {
                if (!File.Exists(azureCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(azureCredLocation);
                var lastModified = File.GetLastWriteTime(azureCredLocation);
                var size = new FileInfo(azureCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("ankndKE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KwNSBsQJb64=")[iii % 8])).ToArray()), azureCredLocation, lastAccessed, lastModified, size);
            }

            string[] bluemixCredLocations =
            {
                $"{dir}\\.bluemix\\config.json",
                $"{dir}\\.bluemix\\.cf\\config.json"};
            foreach (var bluemixCredLocation in bluemixCredLocations)
            {
                if (!File.Exists(bluemixCredLocation))
                    continue;
                var lastAccessed = File.GetLastAccessTime(bluemixCredLocation);
                var lastModified = File.GetLastWriteTime(bluemixCredLocation);
                var size = new FileInfo(bluemixCredLocation).Length;
                yield return new O_2DB4352B(Encoding.UTF8.GetString(Convert.FromBase64String("ibIiR5U1Lg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y95XIvhcVo8=")[iii % 8])).ToArray()), bluemixCredLocation, lastAccessed, lastModified, size);
            }
        }
    }
}}