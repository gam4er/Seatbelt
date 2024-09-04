using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    enum AuditType
    {
        Success = 1,
        Failure = 2,
        SuccessAndFailure = 3
    }

    class AuditEntry
    {
        public AuditEntry(string target, string subcategory, string subcategoryGuid, AuditType auditType)
        {
            Target = target;
            Subcategory = subcategory;
            SubcategoryGUID = subcategoryGuid;
            AuditType = auditType;
        }

        public string Target { get; }
        public string Subcategory { get; }
        public string SubcategoryGUID { get; }
        public AuditType AuditType { get; }
    }
internal class O_014B0973 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("YkrH9bjYRIxKXMr5vw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Iz+jnMyIK+A=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("dqiYIlZtiUVWtc0sX36bQlqlzS5de8hQV7CMIVB6jBFSs4kmRz+YXl+vjjYTbI1FR6+DKEA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M8btTzMf6DE=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_014B0973(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("64ppNUtHShvXhw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uPMaQS4qGHQ=")[iii % 8])).ToArray()))}\\System32\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var sysnativeSearchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("znVId79tECjyeA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nQw7A9oAQkc=")[iii % 8])).ToArray()))}\\Sysnative\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var files = FindFiles(searchPath, Encoding.UTF8.GetString(Convert.FromBase64String("WgUPFXk7ZXVN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O3BrfA0VBgY=")[iii % 8])).ToArray()));
        var classicFiles = FindFiles(searchPath, Encoding.UTF8.GetString(Convert.FromBase64String("4u2rcYl151nM87k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pZ3fJeQFi3c=")[iii % 8])).ToArray()));
        foreach (var classicFilePath in classicFiles)
        {
            var result = ParseGPOPath(classicFilePath);
            var domain = result[0];
            var gpo = result[1];
            var sections = O_391D9844.ReadSections(classicFilePath);
            if (!sections.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("rhOS9pYSSgyPDIM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("62X3mOIyC3k=")[iii % 8])).ToArray())))
                continue;
            var settings = ParseClassicPolicy(classicFilePath);
            yield return new O_1FDF109F(classicFilePath, domain, gpo, Encoding.UTF8.GetString(Convert.FromBase64String("bVK6sD9OEQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dj7bw0wncq0=")[iii % 8])).ToArray()), settings);
        }

        foreach (var filePath in files)
        {
            var result = ParseGPOPath(filePath);
            var domain = result[0];
            var gpo = result[1];
            var settings = ParseAdvancedPolicy(filePath);
            yield return new O_1FDF109F(filePath, domain, gpo, Encoding.UTF8.GetString(Convert.FromBase64String("zaMxGQgGwq4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rMdHeGZlp8o=")[iii % 8])).ToArray()), settings);
        }
    }

    public string[] ParseGPOPath(string path)
    {
        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("kJoSAF7BMPKslw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w+NhdDusYp0=")[iii % 8])).ToArray()))}\\System32\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var sysnativeSearchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("fLEBzPBMfupAvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L8hyuJUhLIU=")[iii % 8])).ToArray()))}\\Sysnative\\GroupPolicy\\DataStore\\0\\sysvol\\";
        if (Regex.IsMatch(path, Encoding.UTF8.GetString(Convert.FromBase64String("HauJOh6wkns=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TtL6TnvdoUk=")[iii % 8])).ToArray())))
        {
            var rest = path.Substring(searchPath.Length, path.Length - searchPath.Length);
            var parts = rest.Split('\\');
            string[] result =
            {
                parts[0],
                parts[2]
            };
            return result;
        }
        else
        {
            var rest = path.Substring(sysnativeSearchPath.Length, path.Length - sysnativeSearchPath.Length);
            var parts = rest.Split('\\');
            string[] result =
            {
                parts[0],
                parts[2]
            };
            return result;
        }
    }

    public List<AuditEntry> ParseClassicPolicy(string path)
    {
        var results = new List<AuditEntry>();
        var settings = O_391D9844.ReadKeyValuePairs(Encoding.UTF8.GetString(Convert.FromBase64String("bNgH2Pi5UOZNxxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ka5itoyZEZM=")[iii % 8])).ToArray()), path);
        foreach (var setting in settings)
        {
            var parts = setting.Split('=');
            var result = new AuditEntry(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zGjTLazwdY0=")[iii % 8])).ToArray()), parts[0], Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kT0k1SjbI9E=")[iii % 8])).ToArray()), (AuditType)Int32.Parse(parts[1]));
            results.Add(result);
        }

        return results;
    }

    public List<AuditEntry> ParseAdvancedPolicy(string path)
    {
        var results = new List<AuditEntry>();
        using (var reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (values[0].Equals(Encoding.UTF8.GetString(Convert.FromBase64String("jp/NgnQ0K3yNn8OP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w/6u6h1aTlw=")[iii % 8])).ToArray())))
                    continue;
                string target = values[1], subcategory = values[2], subcategoryGuid = values[3];
                var auditType = (AuditType)int.Parse(values[6]);
                results.Add(new AuditEntry(target, subcategory, subcategoryGuid, auditType));
            }
        }

        return results;
    }

    public static List<string> FindFiles(string path, string pattern)
    {
        var files = new List<string>();
        try
        {
            var filesUnfiltered = GetFiles(path).ToList();
            files.AddRange(filesUnfiltered.Where(f => f.Contains(pattern.Trim('*'))));
        }
        catch (UnauthorizedAccessException)
        {
        }
        catch (PathTooLongException)
        {
        }

        return files;
    }

    private static IEnumerable<string> GetFiles(string path)
    {
        var queue = new Queue<string>();
        queue.Enqueue(path);
        while (queue.Count > 0)
        {
            path = queue.Dequeue();
            try
            {
                foreach (var subDir in Directory.GetDirectories(path))
                {
                    queue.Enqueue(subDir);
                }
            }
            catch (Exception)
            {
            }

            string[]? files = null;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (Exception)
            {
            }

            if (files == null)
                continue;
            ;
            foreach (var f in files)
            {
                yield return f;
            }
        }
    }

internal class O_1FDF109F : O_4AED570F
{
    public O_1FDF109F(string path, string domain, string gpo, string type, List<AuditEntry> settings)
    {
        Path = path;
        Domain = domain;
        GPO = gpo;
        Type = type;
        Settings = settings;
    }

    public string Path { get; }
    public string Domain { get; }
    public string GPO { get; }
    public string Type { get; }
    public List<AuditEntry> Settings { get; }
}    [CommandOutputType(typeof(O_1FDF109F))]
    internal class O_3C3E088A : TextFormatterBase
    {
        public O_3C3E088A(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_1FDF109F)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mSG5MjeMZjyZYKllK8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uVqJHhq4VkE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Ht9PmHb4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WrAi+R+WnQI=")[iii % 8])).ToArray()), dto.Domain);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+veE9hcG2Vv6tpShC08=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2oy02joy6SY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qfrY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7qqXgwT2vuI=")[iii % 8])).ToArray()), dto.GPO);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JxPjVdPVWtInUvMCz5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B2jTef7haq8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Kuv3Dw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fpKHaj7dRA4=")[iii % 8])).ToArray()), dto.Type);
            foreach (var entry in dto.Settings)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Tr42X4XEMUhU5X1CzA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bsUGc7H0TGg=")[iii % 8])).ToArray()), entry.Subcategory, entry.AuditType);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string rRpAikog)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                        instance.GetDayOfWeek(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_1FDF109F)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("mSG5MjeMZjyZYKllK8U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uVqJHhq4VkE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Ht9PmHb4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WrAi+R+WnQI=")[iii % 8])).ToArray()), dto.Domain);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("+veE9hcG2Vv6tpShC08=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2oy02joy6SY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qfrY").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7qqXgwT2vuI=")[iii % 8])).ToArray()), dto.GPO);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JxPjVdPVWtInUvMCz5w=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B2jTef7haq8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Kuv3Dw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fpKHaj7dRA4=")[iii % 8])).ToArray()), dto.Type);
            foreach (var entry in dto.Settings)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Tr42X4XEMUhU5X1CzA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bsUGc7H0TGg=")[iii % 8])).ToArray()), entry.Subcategory, entry.AuditType);
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string YbygrKTf)
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

        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("64ppNUtHShvXhw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uPMaQS4qGHQ=")[iii % 8])).ToArray()))}\\System32\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var sysnativeSearchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("znVId79tECjyeA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nQw7A9oAQkc=")[iii % 8])).ToArray()))}\\Sysnative\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var files = FindFiles(searchPath, Encoding.UTF8.GetString(Convert.FromBase64String("WgUPFXk7ZXVN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("O3BrfA0VBgY=")[iii % 8])).ToArray()));
        var classicFiles = FindFiles(searchPath, Encoding.UTF8.GetString(Convert.FromBase64String("4u2rcYl151nM87k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pZ3fJeQFi3c=")[iii % 8])).ToArray()));
        foreach (var classicFilePath in classicFiles)
        {
            var result = ParseGPOPath(classicFilePath);
            var domain = result[0];
            var gpo = result[1];
            var sections = O_391D9844.ReadSections(classicFilePath);
            if (!sections.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("rhOS9pYSSgyPDIM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("62X3mOIyC3k=")[iii % 8])).ToArray())))
                continue;
            var settings = ParseClassicPolicy(classicFilePath);
            yield return new O_1FDF109F(classicFilePath, domain, gpo, Encoding.UTF8.GetString(Convert.FromBase64String("bVK6sD9OEQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Dj7bw0wncq0=")[iii % 8])).ToArray()), settings);
        }

        foreach (var filePath in files)
        {
            var result = ParseGPOPath(filePath);
            var domain = result[0];
            var gpo = result[1];
            var settings = ParseAdvancedPolicy(filePath);
            yield return new O_1FDF109F(filePath, domain, gpo, Encoding.UTF8.GetString(Convert.FromBase64String("zaMxGQgGwq4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rMdHeGZlp8o=")[iii % 8])).ToArray()), settings);
        }
    }

    public string[] ParseGPOPath(string path, string ncrgYRGZ)
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

        var searchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("kJoSAF7BMPKslw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w+NhdDusYp0=")[iii % 8])).ToArray()))}\\System32\\GroupPolicy\\DataStore\\0\\sysvol\\";
        var sysnativeSearchPath = $"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("fLEBzPBMfupAvA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L8hyuJUhLIU=")[iii % 8])).ToArray()))}\\Sysnative\\GroupPolicy\\DataStore\\0\\sysvol\\";
        if (Regex.IsMatch(path, Encoding.UTF8.GetString(Convert.FromBase64String("HauJOh6wkns=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TtL6TnvdoUk=")[iii % 8])).ToArray())))
        {
            var rest = path.Substring(searchPath.Length, path.Length - searchPath.Length);
            var parts = rest.Split('\\');
            string[] result =
            {
                parts[0],
                parts[2]
            };
            return result;
        }
        else
        {
            var rest = path.Substring(sysnativeSearchPath.Length, path.Length - sysnativeSearchPath.Length);
            var parts = rest.Split('\\');
            string[] result =
            {
                parts[0],
                parts[2]
            };
            return result;
        }
    }

    public List<AuditEntry> ParseClassicPolicy(string path, string KXroLsOj)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetDayOfWeek(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var results = new List<AuditEntry>();
        var settings = O_391D9844.ReadKeyValuePairs(Encoding.UTF8.GetString(Convert.FromBase64String("bNgH2Pi5UOZNxxY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ka5itoyZEZM=")[iii % 8])).ToArray()), path);
        foreach (var setting in settings)
        {
            var parts = setting.Split('=');
            var result = new AuditEntry(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zGjTLazwdY0=")[iii % 8])).ToArray()), parts[0], Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kT0k1SjbI9E=")[iii % 8])).ToArray()), (AuditType)Int32.Parse(parts[1]));
            results.Add(result);
        }

        return results;
    }

    public List<AuditEntry> ParseAdvancedPolicy(string path, string AZRgNsNA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetDayOfWeek(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var results = new List<AuditEntry>();
        using (var reader = new StreamReader(path))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (values[0].Equals(Encoding.UTF8.GetString(Convert.FromBase64String("jp/NgnQ0K3yNn8OP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w/6u6h1aTlw=")[iii % 8])).ToArray())))
                    continue;
                string target = values[1], subcategory = values[2], subcategoryGuid = values[3];
                var auditType = (AuditType)int.Parse(values[6]);
                results.Add(new AuditEntry(target, subcategory, subcategoryGuid, auditType));
            }
        }

        return results;
    }

    public static List<string> FindFiles(string path, string pattern, string xpDMjmWv)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetDayOfWeek(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var files = new List<string>();
        try
        {
            var filesUnfiltered = GetFiles(path).ToList();
            files.AddRange(filesUnfiltered.Where(f => f.Contains(pattern.Trim('*'))));
        }
        catch (UnauthorizedAccessException)
        {
        }
        catch (PathTooLongException)
        {
        }

        return files;
    }

    private static IEnumerable<string> GetFiles(string path, string XFpWlsuT)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.PersianCalendar instance = new System.Globalization.PersianCalendar();
                    instance.GetDayOfWeek(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var queue = new Queue<string>();
        queue.Enqueue(path);
        while (queue.Count > 0)
        {
            path = queue.Dequeue();
            try
            {
                foreach (var subDir in Directory.GetDirectories(path))
                {
                    queue.Enqueue(subDir);
                }
            }
            catch (Exception)
            {
            }

            string[]? files = null;
            try
            {
                files = Directory.GetFiles(path);
            }
            catch (Exception)
            {
            }

            if (files == null)
                continue;
            ;
            foreach (var f in files)
            {
                yield return f;
            }
        }
    }
}}