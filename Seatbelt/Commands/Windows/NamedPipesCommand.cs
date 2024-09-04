#nullable disable
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Security.AccessControl;
using static O_F41F88FA.Interop.Kernel32;
using System.IO;
using O_F41F88FA.Interop;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_3AE22304 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("u4SDxTEIJ+mQlg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9eXuoFVYTpk=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("knOOYxsn5hOsd8NoHmrzCfAygmgGJ+QfvXaCZBNitjufXsNvEWH5CLFzl28QabYbsnbDZwx0+Rm1c5djGyfmCLNxhnUMJ/8Uun2Rax5z/xWyPA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3BLjBn8Hlno=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_3AE22304(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var namedPipes = new List<string>();
        WIN32_FIND_DATA lpFindFileData;
        var ptr = FindFirstFile(Encoding.UTF8.GetString(Convert.FromBase64String("nIlGlRxrBDGc/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wNVoyWwCdFQ=")[iii % 8])).ToArray()), out lpFindFileData);
        namedPipes.Add(lpFindFileData.cFileName);
        while (FindNextFile(ptr, out lpFindFileData))
        {
            namedPipes.Add(lpFindFileData.cFileName);
        }

        FindClose(ptr);
        namedPipes.Sort();
        foreach (var namedPipe in namedPipes)
        {
            string? svProcessPath = null;
            int? svProcessId = null;
            string? svProcessName = null;
            int? svSessionId = null;
            IntPtr hPipe = IntPtr.Zero;
            try
            {
                hPipe = CreateFile($"\\\\.\\pipe\\{namedPipe}", FileAccess.Read, FileShare.None, IntPtr.Zero, FileMode.Open, FileAttributes.Normal, IntPtr.Zero);
                if (hPipe.ToInt64() != O_3BB7B919.InvalidHandle)
                {
                    bool bvRet = GetNamedPipeServerProcessId(hPipe, out int pipeServerPid);
                    try
                    {
                        if (bvRet)
                        {
                            var svProcess = System.Diagnostics.Process.GetProcessById(pipeServerPid);
                            svProcessId = pipeServerPid;
                            svProcessName = svProcess.ProcessName;
                            svProcessPath = svProcess.MainModule.FileName;
                        }
                    }
                    catch
                    {
                    }

                    bvRet = GetNamedPipeServerSessionId(hPipe, out int pipeServerSessionId);
                    if (bvRet)
                    {
                        svSessionId = pipeServerSessionId;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (hPipe != IntPtr.Zero && hPipe.ToInt64() != O_3BB7B919.InvalidHandle)
                {
                    CloseHandle(hPipe);
                }
            }

            string? sddl = GetSddl(Encoding.UTF8.GetString(Convert.FromBase64String("8/U6Mc/W26Dz0iQQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r6kUbb+/q8U=")[iii % 8])).ToArray()));
            yield return new O_4C1AA4E8()
            {
                Name = namedPipe,
                Sddl = sddl,
                ServerProcessName = svProcessName,
                ServerProcessPID = svProcessId,
                ServerProcessPath = svProcessPath,
                ServerSessionId = svSessionId,
            };
        }
    }

    private string? GetSddl(string namedPipe)
    {
        try
        {
            var security = File.GetAccessControl($"\\\\.\\pipe\\{namedPipe}");
            var sddl = security.GetSecurityDescriptorSddlForm(AccessControlSections.All);
            return sddl;
        }
        catch
        {
            return null;
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string rnLgwsRI)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ChineseLunisolarCalendar instance = new System.Globalization.ChineseLunisolarCalendar();
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

        var namedPipes = new List<string>();
        WIN32_FIND_DATA lpFindFileData;
        var ptr = FindFirstFile(Encoding.UTF8.GetString(Convert.FromBase64String("nIlGlRxrBDGc/w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wNVoyWwCdFQ=")[iii % 8])).ToArray()), out lpFindFileData);
        namedPipes.Add(lpFindFileData.cFileName);
        while (FindNextFile(ptr, out lpFindFileData))
        {
            namedPipes.Add(lpFindFileData.cFileName);
        }

        FindClose(ptr);
        namedPipes.Sort();
        foreach (var namedPipe in namedPipes)
        {
            string? svProcessPath = null;
            int? svProcessId = null;
            string? svProcessName = null;
            int? svSessionId = null;
            IntPtr hPipe = IntPtr.Zero;
            try
            {
                hPipe = CreateFile($"\\\\.\\pipe\\{namedPipe}", FileAccess.Read, FileShare.None, IntPtr.Zero, FileMode.Open, FileAttributes.Normal, IntPtr.Zero);
                if (hPipe.ToInt64() != O_3BB7B919.InvalidHandle)
                {
                    bool bvRet = GetNamedPipeServerProcessId(hPipe, out int pipeServerPid);
                    try
                    {
                        if (bvRet)
                        {
                            var svProcess = System.Diagnostics.Process.GetProcessById(pipeServerPid);
                            svProcessId = pipeServerPid;
                            svProcessName = svProcess.ProcessName;
                            svProcessPath = svProcess.MainModule.FileName;
                        }
                    }
                    catch
                    {
                    }

                    bvRet = GetNamedPipeServerSessionId(hPipe, out int pipeServerSessionId);
                    if (bvRet)
                    {
                        svSessionId = pipeServerSessionId;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (hPipe != IntPtr.Zero && hPipe.ToInt64() != O_3BB7B919.InvalidHandle)
                {
                    CloseHandle(hPipe);
                }
            }

            string? sddl = GetSddl(Encoding.UTF8.GetString(Convert.FromBase64String("8/U6Mc/W26Dz0iQQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("r6kUbb+/q8U=")[iii % 8])).ToArray()));
            yield return new O_4C1AA4E8()
            {
                Name = namedPipe,
                Sddl = sddl,
                ServerProcessName = svProcessName,
                ServerProcessPID = svProcessId,
                ServerProcessPath = svProcessPath,
                ServerSessionId = svSessionId,
            };
        }
    }

    private string? GetSddl(string namedPipe, string RZYkxylR)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.ChineseLunisolarCalendar instance = new System.Globalization.ChineseLunisolarCalendar();
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

        try
        {
            var security = File.GetAccessControl($"\\\\.\\pipe\\{namedPipe}");
            var sddl = security.GetSecurityDescriptorSddlForm(AccessControlSections.All);
            return sddl;
        }
        catch
        {
            return null;
        }
    }
}internal class O_4C1AA4E8 : O_4AED570F
{
    public string Name { get; set; }
    public string? Sddl { get; set; }
    public string? ServerProcessName { get; set; }
    public int? ServerProcessPID { get; set; }
    public string? ServerProcessPath { get; set; }
    public int? ServerSessionId { get; internal set; }
}
    [CommandOutputType(typeof(O_4C1AA4E8))]
    internal class O_931E7392 : TextFormatterBase
    {
        public O_931E7392(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_4C1AA4E8)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("G6jlow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EdPV3jZ7viQ=")[iii % 8])).ToArray()), dto.Name);
            if (dto.ServerProcessPID != null)
            {
                WriteLine($"    Server Process Id   : {dto.ServerProcessPID}");
            }

            if (dto.ServerSessionId != null)
            {
                WriteLine($"    Server Session Id   : {dto.ServerSessionId}");
            }

            if (!string.IsNullOrEmpty(dto.ServerProcessPath))
            {
                WriteLine($"    Server Process Name : {dto.ServerProcessName}");
            }

            if (!string.IsNullOrEmpty(dto.ServerProcessPath))
            {
                WriteLine($"    Server Process Path : {dto.ServerProcessPath}");
            }

            if (!string.IsNullOrEmpty(dto.Sddl))
            {
                WriteLine($"    Pipe SDDL           : {dto.Sddl}");
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string DqkopQkO)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ChineseLunisolarCalendar instance = new System.Globalization.ChineseLunisolarCalendar();
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

            var dto = (O_4C1AA4E8)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("G6jlow==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EdPV3jZ7viQ=")[iii % 8])).ToArray()), dto.Name);
            if (dto.ServerProcessPID != null)
            {
                WriteLine($"    Server Process Id   : {dto.ServerProcessPID}");
            }

            if (dto.ServerSessionId != null)
            {
                WriteLine($"    Server Session Id   : {dto.ServerSessionId}");
            }

            if (!string.IsNullOrEmpty(dto.ServerProcessPath))
            {
                WriteLine($"    Server Process Name : {dto.ServerProcessName}");
            }

            if (!string.IsNullOrEmpty(dto.ServerProcessPath))
            {
                WriteLine($"    Server Process Path : {dto.ServerProcessPath}");
            }

            if (!string.IsNullOrEmpty(dto.Sddl))
            {
                WriteLine($"    Pipe SDDL           : {dto.Sddl}");
            }
        }
    }
}
#nullable enable
