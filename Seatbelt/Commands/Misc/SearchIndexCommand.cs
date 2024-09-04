#nullable disable
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_43FBE431 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("PdZB/8zp8okK1lg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("brMgja+Bu+c=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("YQ6ihtICzaNDDquA2ALZtF8W54DDR5+RWRWjm9xRn5VVGrWXwwL2qFQev9iLRtqgUQ6rgItW2rRdW6iSiwXPp0MItIPEUNvhHlvvldlFyqtVFbPc2Auf+w1b+4fOQ82lWFu3ld9KgeYMC6aA30fNqAFXt5XfVtq0Xknr2oUMgQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MHvH9Ksiv8Y=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_43FBE431(Runtime runtime) : base(runtime)
    {
    }

    private IEnumerable<O_A25BC503> SearchWindowsIndex(string searchPath = @"C:\Users\", string criteria = "password")
    {
        var format = Encoding.UTF8.GetString(Convert.FromBase64String("nzIiKH4Oigi1BBoIUHTjL6kaPgxJMu4yvwcCDER2+SK/AwsAExzDN6k4GQNYKIYItQQaCFB0+TK2EkI+RCnePqFZKgxJP+kpqRYaCFl2+SK/AwsAEx7LL6k2DQ5YKdk+qFs9FE4uzzbiJAsMTznCdY0CGgJOL8c2rQUXTXsI5RbsJBceST/HEqITCxUdDeIenjJOLlI03jqlGR1FF3aKfO5dFV1AcIh85VcvI3l6+RiDJytNAHqNIP0KSU18FO575CQXHkk/x3WKHgIIeCLePqIEBwJTepd761kaFUl9ihSeVz0UTi7PNuIxBwFYH9IvqRkdBFI0imbsUEAJUjmNe4MlTj5EKd4+oVkoBFE/7yO4EgAeVDXEe/FXSUNZNckj61chPx0J0yi4EgNDezPGPokPGghTKcM0oldTTRp02iu4UE4ib3r5Ir8DCwATHMM3qTIWGVg02TKjGU5QHX2EK7wDFkodFfh7nw4dGVg3hB2lGwsoRS7PNb8eAQMdZ4p84g8CHhp65QnsJBceST/HdYoeAgh4It4+ogQHAlN6l3vrWRYBTiKNe4MlTj5EKd4+oVkoBFE/7yO4EgAeVDXEe/FXSUNNKZt87Dg8TW4j2S+pGkArVDbPHrQDCwNOM8U17EpOShMsyCjrVyE/HQnTKLgSA0N7M8Y+iQ8aCFMpwzSiV1NNGnTJNKIRBwoaeuUJ7CQXHkk/x3WKHgIIeCLePqIEBwJTepd761kHA1R9gw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zHdubT1aqls=")[iii % 8])).ToArray());
        var connectionString = Encoding.UTF8.GetString(Convert.FromBase64String("9AKswtnIV6OZI6bVws9a/+cfr9jR2F2j4COMj/XURrTKFKbQkPxAvtQVscDZyUHshjGzxNzFUbDQGazajftbv8AftMeS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pHDDtLCsMtE=")[iii % 8])).ToArray());
        using var connection = new OleDbConnection(connectionString);
        var query = string.Format(format, criteria, searchPath);
#pragma warning disable CA2100
        var command = new OleDbCommand(query, connection);
#pragma warning restore CA2100
        connection.Open();
        OleDbDataReader reader;
        try
        {
            reader = command.ExecuteReader();
        }
        catch
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("yPQZ1rJWIKryugnBu0F5/unyHZSNVmGs/vJY/bBXZab46FSUjVZhrP7yWP2wV2WmvfMLlLJaa7vx41jasUcgrOj0Ft2wVC4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nZp4tN4zAN4=")[iii % 8])).ToArray()));
            yield break;
        }

        while (reader.Read())
        {
            var AutoSummary = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jVLKmnVB73Q=")[iii % 8])).ToArray());
            var FileOwner = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lo918VXeXQ8=")[iii % 8])).ToArray());
            try
            {
                AutoSummary = reader.GetString(5);
            }
            catch
            {
            }

            try
            {
                FileOwner = reader.GetString(1);
            }
            catch
            {
            }

            yield return new O_A25BC503()
            {
                Path = reader.GetString(0),
                FileOwner = FileOwner,
                Size = Decimal.ToUInt64((Decimal)reader.GetValue(2)),
                DateCreated = reader.GetDateTime(3),
                DateAccessed = reader.GetDateTime(4),
                AutoSummary = AutoSummary
            };
        }

        connection.Close();
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (args.Length == 0)
        {
            foreach (var result in SearchWindowsIndex())
            {
                yield return result;
            }
        }
        else if (args.Length == 1)
        {
            if (System.IO.Directory.Exists(args[0]))
            {
                foreach (var result in SearchWindowsIndex(args[0]))
                {
                    yield return result;
                }
            }
            else
            {
                var terms = args[0].Split(',');
                foreach (var term in terms)
                {
                    foreach (var result in SearchWindowsIndex(Encoding.UTF8.GetString(Convert.FromBase64String("ZP2y0HSK72l7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J8fuhQfvnRo=")[iii % 8])).ToArray()), term))
                    {
                        yield return result;
                    }
                }
            }
        }
        else if (args.Length == 2)
        {
            var terms = args[1].Split(',');
            foreach (var term in terms)
            {
                foreach (var result in SearchWindowsIndex(args[0], term))
                {
                    yield return result;
                }
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string VyDOJqVo)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.KoreanLunisolarCalendar instance = new System.Globalization.KoreanLunisolarCalendar();
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

        if (args.Length == 0)
        {
            foreach (var result in SearchWindowsIndex())
            {
                yield return result;
            }
        }
        else if (args.Length == 1)
        {
            if (System.IO.Directory.Exists(args[0]))
            {
                foreach (var result in SearchWindowsIndex(args[0]))
                {
                    yield return result;
                }
            }
            else
            {
                var terms = args[0].Split(',');
                foreach (var term in terms)
                {
                    foreach (var result in SearchWindowsIndex(Encoding.UTF8.GetString(Convert.FromBase64String("ZP2y0HSK72l7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J8fuhQfvnRo=")[iii % 8])).ToArray()), term))
                    {
                        yield return result;
                    }
                }
            }
        }
        else if (args.Length == 2)
        {
            var terms = args[1].Split(',');
            foreach (var term in terms)
            {
                foreach (var result in SearchWindowsIndex(args[0], term))
                {
                    yield return result;
                }
            }
        }
    }
}internal class O_A25BC503 : O_4AED570F
{
    public string Path { get; set; }
    public string FileOwner { get; set; }
    public UInt64 Size { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateAccessed { get; set; }
    public string AutoSummary { get; set; }
}
    [CommandOutputType(typeof(O_A25BC503))]
    internal class O_F49A51EF : TextFormatterBase
    {
        public O_F49A51EF(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_A25BC503)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eMOLJFieXNgRl85pLcwQ2BGNzjI9kQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MbfuSQ3sMPg=")[iii % 8])).ToArray()), dto.Path);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("FA6nbNn7vEEgR+sptqzyBHJd63Km8Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UmfLCZaM0iQ=")[iii % 8])).ToArray()), dto.FileOwner);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0lgkVYDg9/ehEX4QgOD396ELfkuQvQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gTFeMKDA19c=")[iii % 8])).ToArray()), dto.Size);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fjMOY0uTZ0NONx4mKMEiAhpoWn04nA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OlJ6BgjhAiI=")[iii % 8])).ToArray()), dto.DateCreated);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("x+t7kKsGyt7w+WqRykWJm6OwL47aGA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g4oP9eplqbs=")[iii % 8])).ToArray()), dto.DateAccessed);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fvyd/3ctxtpe+5CwBHiLlx+z").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4npkCRYq7c=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zxk10iQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tClI2C62Qj8=")[iii % 8])).ToArray()), dto.AutoSummary);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string hjOHvlBl)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanLunisolarCalendar instance = new System.Globalization.KoreanLunisolarCalendar();
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

            var dto = (O_A25BC503)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eMOLJFieXNgRl85pLcwQ2BGNzjI9kQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MbfuSQ3sMPg=")[iii % 8])).ToArray()), dto.Path);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("FA6nbNn7vEEgR+sptqzyBHJd63Km8Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UmfLCZaM0iQ=")[iii % 8])).ToArray()), dto.FileOwner);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0lgkVYDg9/ehEX4QgOD396ELfkuQvQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gTFeMKDA19c=")[iii % 8])).ToArray()), dto.Size);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fjMOY0uTZ0NONx4mKMEiAhpoWn04nA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OlJ6BgjhAiI=")[iii % 8])).ToArray()), dto.DateCreated);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("x+t7kKsGyt7w+WqRykWJm6OwL47aGA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g4oP9eplqbs=")[iii % 8])).ToArray()), dto.DateAccessed);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fvyd/3ctxtpe+5CwBHiLlx+z").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P4npkCRYq7c=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("zxk10iQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tClI2C62Qj8=")[iii % 8])).ToArray()), dto.AutoSummary);
        }
    }
}
#nullable enable
