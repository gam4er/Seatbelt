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
    class O_F2734054
    {
        public string RemoteHost { get; set; }
        public string UserNameHint { get; set; }
    }
internal class O_959E44A9 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("e+R97yu+WYNqz0PSL6tIjkbOXg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KaAtvErIPOc=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("+GiapIe7FHv7KY+ujfUjXN9gg6+QuzVLxHuJpcPyKB/fYYnhkf4hVth9nrg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qwnsweObRj8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_959E44A9(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var SIDs = ThisRunTime.GetUserSIDs();
        foreach (var sid in SIDs)
        {
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("djN0n7k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JR5FsowPhXw=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("to7g/olx8Wk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6c2Mn/oClBo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var subkeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Terminal Server Client\\Servers");
            if (subkeys == null)
            {
                continue;
            }

            if (subkeys.Length <= 0)
            {
                continue;
            }

            var connections = new List<O_F2734054>();
            foreach (var host in subkeys)
            {
                var usernameHint = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Terminal Server Client\\Servers\\{host}", Encoding.UTF8.GetString(Convert.FromBase64String("WoDq8lw01ENHmuH0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D/OPgDJVuSY=")[iii % 8])).ToArray()));
                var connection = new O_F2734054();
                connection.RemoteHost = host;
                connection.UserNameHint = usernameHint;
                connections.Add(connection);
            }

            yield return new O_98DD29C3()
            {
                SID = sid,
                Connections = connections
            };
        }

        yield break;
    }

internal class O_98DD29C3 : O_4AED570F
{
    public string SID { get; set; }
    public List<O_F2734054> Connections { get; set; }
}    [CommandOutputType(typeof(O_98DD29C3))]
    internal class O_C9E71A77 : TextFormatterBase
    {
        public O_C9E71A77(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_98DD29C3)result;
            if (dto.Connections.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Em+nyuh6pkIRLpLA4jSRZTVnvsGsE5pgLny8zvgzm2hhJqqf8XP+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QQ7Rr4xa9AY=")[iii % 8])).ToArray()), dto.SID);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VRpfn9azKoo9VX6Om/x+z1UaLdqb/H7PVRot2pv8fs9VGi3am4ktigdUbJfelDeBAQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dToN+rvcXu8=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("RkaIWlFZtl9LS4haXFS7UkZGhVdcVLtSRkaFV1xUu1JGRoVXXFm2X0tLiFpRWbZfSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zmald3x0m3I=")[iii % 8])).ToArray()));
                foreach (var connection in dto.Connections)
                {
                    WriteLine($"  {connection.RemoteHost.PadRight(35)}{connection.UserNameHint}");
                }

                WriteLine();
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string BZGNjyou)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.Seek(518251, new System.IO.SeekOrigin());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_98DD29C3)result;
            if (dto.Connections.Count > 0)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Em+nyuh6pkIRLpLA4jSRZTVnvsGsE5pgLny8zvgzm2hhJqqf8XP+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QQ7Rr4xa9AY=")[iii % 8])).ToArray()), dto.SID);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VRpfn9azKoo9VX6Om/x+z1UaLdqb/H7PVRot2pv8fs9VGi3am4ktigdUbJfelDeBAQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dToN+rvcXu8=")[iii % 8])).ToArray()));
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("RkaIWlFZtl9LS4haXFS7UkZGhVdcVLtSRkaFV1xUu1JGRoVXXFm2X0tLiFpRWbZfSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zmald3x0m3I=")[iii % 8])).ToArray()));
                foreach (var connection in dto.Connections)
                {
                    WriteLine($"  {connection.RemoteHost.PadRight(35)}{connection.UserNameHint}");
                }

                WriteLine();
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string aXfGqFTb)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.IO.MemoryStream instance = new System.IO.MemoryStream();
                    instance.Seek(518251, new System.IO.SeekOrigin());
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
            if (!sid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("djN0n7k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JR5FsowPhXw=")[iii % 8])).ToArray())) || sid.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("to7g/olx8Wk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6c2Mn/oClBo=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var subkeys = ThisRunTime.GetSubkeyNames(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Terminal Server Client\\Servers");
            if (subkeys == null)
            {
                continue;
            }

            if (subkeys.Length <= 0)
            {
                continue;
            }

            var connections = new List<O_F2734054>();
            foreach (var host in subkeys)
            {
                var usernameHint = ThisRunTime.GetStringValue(RegistryHive.Users, $"{sid}\\Software\\Microsoft\\Terminal Server Client\\Servers\\{host}", Encoding.UTF8.GetString(Convert.FromBase64String("WoDq8lw01ENHmuH0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D/OPgDJVuSY=")[iii % 8])).ToArray()));
                var connection = new O_F2734054();
                connection.RemoteHost = host;
                connection.UserNameHint = usernameHint;
                connections.Add(connection);
            }

            yield return new O_98DD29C3()
            {
                SID = sid,
                Connections = connections
            };
        }

        yield break;
    }
}}
#nullable enable
