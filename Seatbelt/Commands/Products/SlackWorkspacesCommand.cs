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
    class O_87BB59BA
    {
        public string? Name { get; set; }
        public string? Domain { get; set; }
        public string? ID { get; set; }
    }
internal class O_D27C95D8 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("CorjDWP/lx4ylfIPa82L").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WeaCbgio+Gw=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("Dra8sFIIB5Awru6lWA5JlX7wva9WGEzcKbi8qEQLRpI7pOnjURJLlC0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XtfOwzd7J/E=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User,
        CommandGroup.Slack
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_D27C95D8(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("uUe4OBGa5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5RLLXWPpu7E=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("pRKtuLqj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WfP1NPA9nU=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JS3zER6usA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YUiVcGvCxM8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sFRTN8E3uimhQlAk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9DE1VrRbzgk=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("x4ebMFODoon1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("huv3EAbwx/s=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userSlackWorkspacesPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-workspaces";
            if (File.Exists(userSlackWorkspacesPath))
            {
                var workspaces = new List<O_87BB59BA>();
                try
                {
                    var contents = File.ReadAllText(userSlackWorkspacesPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    foreach (var w in deserialized)
                    {
                        var settings = (Dictionary<string, object>)w.Value;
                        var workspace = new O_87BB59BA();
                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("mP9C3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9p4vuSydE/g=")[iii % 8])).ToArray())))
                        {
                            workspace.Name = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("KAe+dQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RmbTEDG/E4A=")[iii % 8])).ToArray())]}";
                        }

                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("lpIxWHa8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8v1cOR/S6aQ=")[iii % 8])).ToArray())))
                        {
                            workspace.Domain = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("Y4+S8/Ev").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B+D/kphBMzQ=")[iii % 8])).ToArray())]}";
                        }

                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("II8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SeuVSGkBl8Q=")[iii % 8])).ToArray())))
                        {
                            workspace.ID = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("zTQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pFCi4scflhk=")[iii % 8])).ToArray())]}";
                        }

                        workspaces.Add(workspace);
                    }
                }
                catch (IOException exception)
                {
                    WriteError(exception.ToString());
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_6CEC576A(userName, workspaces);
            }
        }
    }

internal class O_6CEC576A : O_4AED570F
{
    public O_6CEC576A(string userName, List<O_87BB59BA> workspaces)
    {
        UserName = userName;
        Workspaces = workspaces;
    }

    public string UserName { get; }
    public List<O_87BB59BA> Workspaces { get; }
}    [CommandOutputType(typeof(O_6CEC576A))]
    internal class O_8BA700A3 : TextFormatterBase
    {
        public O_8BA700A3(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_6CEC576A)result;
            WriteLine($"  Workspaces ({dto.UserName}):\n");
            foreach (var workspace in dto.Workspaces)
            {
                WriteLine($"    Name   : {workspace.Name}");
                WriteLine($"    Domain : {workspace.Domain}");
                WriteLine($"    ID     : {workspace.ID}\n");
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string EjHLsDmo)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                        instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_6CEC576A)result;
            WriteLine($"  Workspaces ({dto.UserName}):\n");
            foreach (var workspace in dto.Workspaces)
            {
                WriteLine($"    Name   : {workspace.Name}");
                WriteLine($"    Domain : {workspace.Domain}");
                WriteLine($"    ID     : {workspace.ID}\n");
            }

            WriteLine();
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ERgTsBea)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Runtime.Remoting.ObjRef instance = new System.Runtime.Remoting.ObjRef();
                    instance.GetRealObject(new System.Runtime.Serialization.StreamingContext());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var dirs = ThisRunTime.GetDirectories(Encoding.UTF8.GetString(Convert.FromBase64String("uUe4OBGa5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5RLLXWPpu7E=")[iii % 8])).ToArray()));
        foreach (var dir in dirs)
        {
            var parts = dir.Split('\\');
            var userName = parts[parts.Length - 1];
            if (dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("pRKtuLqj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9WfP1NPA9nU=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("JS3zER6usA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YUiVcGvCxM8=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("sFRTN8E3uimhQlAk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9DE1VrRbzgk=")[iii % 8])).ToArray())) || dir.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("x4ebMFODoon1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("huv3EAbwx/s=")[iii % 8])).ToArray())))
            {
                continue;
            }

            var userSlackWorkspacesPath = $"{dir}\\AppData\\Roaming\\Slack\\storage\\slack-workspaces";
            if (File.Exists(userSlackWorkspacesPath))
            {
                var workspaces = new List<O_87BB59BA>();
                try
                {
                    var contents = File.ReadAllText(userSlackWorkspacesPath);
                    var json = new JavaScriptSerializer();
                    var deserialized = json.Deserialize<Dictionary<string, object>>(contents);
                    foreach (var w in deserialized)
                    {
                        var settings = (Dictionary<string, object>)w.Value;
                        var workspace = new O_87BB59BA();
                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("mP9C3A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9p4vuSydE/g=")[iii % 8])).ToArray())))
                        {
                            workspace.Name = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("KAe+dQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RmbTEDG/E4A=")[iii % 8])).ToArray())]}";
                        }

                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("lpIxWHa8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8v1cOR/S6aQ=")[iii % 8])).ToArray())))
                        {
                            workspace.Domain = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("Y4+S8/Ev").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B+D/kphBMzQ=")[iii % 8])).ToArray())]}";
                        }

                        if (settings.ContainsKey(Encoding.UTF8.GetString(Convert.FromBase64String("II8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SeuVSGkBl8Q=")[iii % 8])).ToArray())))
                        {
                            workspace.ID = $"{settings[Encoding.UTF8.GetString(Convert.FromBase64String("zTQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pFCi4scflhk=")[iii % 8])).ToArray())]}";
                        }

                        workspaces.Add(workspace);
                    }
                }
                catch (IOException exception)
                {
                    WriteError(exception.ToString());
                }
                catch (Exception exception)
                {
                    WriteError(exception.ToString());
                }

                yield return new O_6CEC576A(userName, workspaces);
            }
        }
    }
}}