#nullable disable
using Microsoft.Win32;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_B635FF20
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
internal class O_1C22F262 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("d6kX1eSa9IpgpAn65IX8mVy1FA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MtFnuYvokfg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+FbIRBdMCmjSQ8dOC11YDYhB3k9bGElCx17KTx1L").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qjOrIXk4Ki0=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_1C22F262(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("c9mGmt8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IPS3t+plD/c=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("iyBPLywUySQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1GMjTl9nrFc=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var recentCommands = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU");
            if ((recentCommands == null) || (recentCommands.Count == 0))
            {
                continue;
            }

            var commands = new List<O_B635FF20>();
            foreach (var kvp in recentCommands)
            {
                var command = new O_B635FF20();
                command.Key = kvp.Key;
                command.Value = $"{kvp.Value}";
                commands.Add(command);
            }

            yield return new O_354F7537(sid, commands);
        }
    }

internal class O_354F7537 : O_4AED570F
{
    public O_354F7537(string sid, List<O_B635FF20> commands)
    {
        Sid = sid;
        Commands = commands;
    }

    public string Sid { get; set; }
    public List<O_B635FF20> Commands { get; set; }
}    [CommandOutputType(typeof(O_354F7537))]
    internal class O_CD50B2D2 : TextFormatterBase
    {
        public O_CD50B2D2(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_354F7537)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fVrjUIn1XnE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d3rDK7mIfks=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var runCommand in dto.Commands)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hrM+EOfOKNKXo2MQpt4khJfu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ppMeMJz+BP8=")[iii % 8])).ToArray()), runCommand.Key, runCommand.Value);
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string JxEcTIOb)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                        instance.GetMaxCharCount(68);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_354F7537)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("fVrjUIn1XnE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("d3rDK7mIfks=")[iii % 8])).ToArray()), dto.Sid);
            foreach (var runCommand in dto.Commands)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("hrM+EOfOKNKXo2MQpt4khJfu").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ppMeMJz+BP8=")[iii % 8])).ToArray()), runCommand.Key, runCommand.Value);
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string jDGvBziA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UnicodeEncoding instance = new System.Text.UnicodeEncoding();
                    instance.GetMaxCharCount(68);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("c9mGmt8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IPS3t+plD/c=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("iyBPLywUySQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1GMjTl9nrFc=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var recentCommands = ThisRunTime.GetValues(RegistryHive.Users, $"{sid}\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU");
            if ((recentCommands == null) || (recentCommands.Count == 0))
            {
                continue;
            }

            var commands = new List<O_B635FF20>();
            foreach (var kvp in recentCommands)
            {
                var command = new O_B635FF20();
                command.Key = kvp.Key;
                command.Value = $"{kvp.Value}";
                commands.Add(command);
            }

            yield return new O_354F7537(sid, commands);
        }
    }
}}
#nullable enable
