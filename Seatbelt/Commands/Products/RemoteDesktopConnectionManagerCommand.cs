using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_A17ACE06 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("jLsUZx3YqfGymiQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3v9XKny275g=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("dZMAp1J3lXNwnwOsSWXGF0eJBbdScMYQTZQApl50jzxM2iOiU2GBNlDaHaZJdI89RYlOpVRsgyA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ivpuwz0A5lM=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public Runtime ThisRunTime;
    public O_A17ACE06(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("dTyy5FtfOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KWnBgSksZu4=")[iii % 8])).ToArray()));
        var found = false;
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("vloCm/jp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7i9g95GK0F8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("GqIBmMc2Ng==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xsdn+bJaQoQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("17Nz7CxF9QLGpXD/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k9YVjVkpgSI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uJ0X51cbWvyK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+fF7xwJoP44=")[iii % 8])).ToArray())))
                continue;
            var userRDManFile = $"{dir}\\AppData\\Local\\Microsoft\\Remote Desktop Connection Manager\\RDCMan.settings";
            if (!File.Exists(userRDManFile))
                continue;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(userRDManFile);
            var filesToOpen = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("7QSL8PBTdDbbCIk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q23nlYMHG3k=")[iii % 8])).ToArray()));
            var items = filesToOpen[0].ChildNodes;
            var lastAccessed = File.GetLastAccessTime(userRDManFile);
            var lastModified = File.GetLastWriteTime(userRDManFile);
            var rdgFiles = new List<string>();
            foreach (XmlNode rdgFile in items)
            {
                found = true;
                rdgFiles.Add(rdgFile.InnerText);
            }

            yield return new O_AA34FF77(userRDManFile, lastAccessed, lastModified, rdgFiles);
        }

        if (found)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("9RCaod1mLhygEKLq7mYCALAQkuPhNAc3hXGRwqApBVOhWKSrzS8aGr5RtfGgZBMDtECosbo0ExT3EKzk5DMbFvVErqvkIxQBrEC1q+EoDlOzX7Tl5GZZAbFX4e3pKhIA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1TDBi4BGd3M=")[iii % 8])).ToArray()));
        }
    }

internal class O_AA34FF77 : O_4AED570F
{
    public O_AA34FF77(string fileName, DateTime lastAccessed, DateTime lastModified, List<string> rdgFiles)
    {
        FileName = fileName;
        LastAccessed = lastAccessed;
        LastModified = lastModified;
        RdgFiles = rdgFiles;
    }

    public string FileName { get; }
    public DateTime LastAccessed { get; }
    public DateTime LastModified { get; }
    public List<string> RdgFiles { get; }
}    [CommandOutputType(typeof(O_AA34FF77))]
    internal class O_67AE8ADC : TextFormatterBase
    {
        public O_67AE8ADC(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_AA34FF77)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ewhBuWAx9pMdQX+YA1y3x3tTI4A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WygT/SN8l/0=")[iii % 8])).ToArray()), dto.FileName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("89Mzvnp0j222l1L9OTHcJPOIQqA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0/Ny3RkR/B4=")[iii % 8])).ToArray()), dto.LastAccessed);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("dWMjbd88UH0wJ04im3UWLnU4Xn8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VUNuArtVNhQ=")[iii % 8])).ToArray()), dto.LastModified);
            foreach (var rdgFile in dto.RdgFiles)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("13b4Wd+D2cbXELEVlPG9u9ct6AQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("91bYefHRnYE=")[iii % 8])).ToArray()), rdgFile);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string KCPCTrDb)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.AddMonths(new System.DateTime(), 32);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_AA34FF77)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ewhBuWAx9pMdQX+YA1y3x3tTI4A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WygT/SN8l/0=")[iii % 8])).ToArray()), dto.FileName);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("89Mzvnp0j222l1L9OTHcJPOIQqA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0/Ny3RkR/B4=")[iii % 8])).ToArray()), dto.LastAccessed);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("dWMjbd88UH0wJ04im3UWLnU4Xn8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VUNuArtVNhQ=")[iii % 8])).ToArray()), dto.LastModified);
            foreach (var rdgFile in dto.RdgFiles)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("13b4Wd+D2cbXELEVlPG9u9ct6AQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("91bYefHRnYE=")[iii % 8])).ToArray()), rdgFile);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string QSwaqAZz)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                    instance.AddMonths(new System.DateTime(), 32);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("dTyy5FtfOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KWnBgSksZu4=")[iii % 8])).ToArray()));
        var found = false;
        foreach (var dir in dirs)
        {
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("vloCm/jp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7i9g95GK0F8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("GqIBmMc2Ng==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Xsdn+bJaQoQ=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("17Nz7CxF9QLGpXD/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("k9YVjVkpgSI=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("uJ0X51cbWvyK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+fF7xwJoP44=")[iii % 8])).ToArray())))
                continue;
            var userRDManFile = $"{dir}\\AppData\\Local\\Microsoft\\Remote Desktop Connection Manager\\RDCMan.settings";
            if (!File.Exists(userRDManFile))
                continue;
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(userRDManFile);
            var filesToOpen = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("7QSL8PBTdDbbCIk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q23nlYMHG3k=")[iii % 8])).ToArray()));
            var items = filesToOpen[0].ChildNodes;
            var lastAccessed = File.GetLastAccessTime(userRDManFile);
            var lastModified = File.GetLastWriteTime(userRDManFile);
            var rdgFiles = new List<string>();
            foreach (XmlNode rdgFile in items)
            {
                found = true;
                rdgFiles.Add(rdgFile.InnerText);
            }

            yield return new O_AA34FF77(userRDManFile, lastAccessed, lastModified, rdgFiles);
        }

        if (found)
        {
            WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("9RCaod1mLhygEKLq7mYCALAQkuPhNAc3hXGRwqApBVOhWKSrzS8aGr5RtfGgZBMDtECosbo0ExT3EKzk5DMbFvVErqvkIxQBrEC1q+EoDlOzX7Tl5GZZAbFX4e3pKhIA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1TDBi4BGd3M=")[iii % 8])).ToArray()));
        }
    }
}}