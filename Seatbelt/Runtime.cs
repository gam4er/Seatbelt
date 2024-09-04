#nullable disable
using O_F41F88FA.Commands;
using O_F41F88FA.Interop;
using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using O_F41F88FA.Output.Sinks;
using System.Management;
using Microsoft.Win32;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA
{
    internal class Runtime
    {
        public List<O_2183A68D> AllCommands { get; private set; } = new List<O_2183A68D>();

        public readonly IOutputSink OutputSink;
        private IEnumerable<string> Commands { get; set; }
        private IEnumerable<string> CommandGroups { get; set; }
        public bool FilterResults { get; }
        public string DelayCommands { get; }
        public bool RandomizeOrder { get; }
        public string ComputerName { get; }
        private string UserName { get; }
        private string Password { get; }
        private ManagementClass wmiRegProv { get; }

        public Runtime(IOutputSink outputSink, IEnumerable<string> commands, IEnumerable<string> commandGroups, bool filter, string delayCommands, bool randomizeOrder) : this(outputSink, commands, commandGroups, filter, randomizeOrder, delayCommands, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OwXgPHwNij8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KwXWZascFQM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lFqINzFAjTE=")[iii % 8])).ToArray()))
        {
        }

        public Runtime(IOutputSink outputSink, IEnumerable<string> commands, IEnumerable<string> commandGroups, bool filter, string delayCommands, bool randomizeOrder, string computerName) : this(outputSink, commands, commandGroups, filter, randomizeOrder, delayCommands, computerName, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UpFPhMEoSQY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tFUnVmTZPjA=")[iii % 8])).ToArray()))
        {
        }

        public Runtime(IOutputSink outputSink, IEnumerable<string> commands, IEnumerable<string> commandGroups, bool filter, bool randomizeOrder, string delayCommands, string computerName, string userName, string password)
        {
            OutputSink = outputSink;
            Commands = commands;
            CommandGroups = commandGroups;
            FilterResults = filter;
            DelayCommands = delayCommands;
            RandomizeOrder = randomizeOrder;
            ComputerName = computerName;
            UserName = userName;
            Password = password;
            if (!string.IsNullOrEmpty(computerName))
            {
                try
                {
                    if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                    {
                        OutputSink.WriteHost($"[*] Running commands remotely against the host '{computerName}' with credentials -> user:{UserName} , password:{Password}\r\n");
                        var options = new ConnectionOptions();
                        options.Username = UserName;
                        options.Password = Password;
                        options.Impersonation = ImpersonationLevel.Impersonate;
                        options.EnablePrivileges = true;
                        var scope = new ManagementScope($"\\\\{computerName}\\root\\cimv2", options);
                        scope.Connect();
                    }
                    else
                    {
                        OutputSink.WriteHost($"[*] Running commands remotely against the host '{computerName}' with current user credentials\r\n");
                        var scope = new ManagementScope($"\\\\{computerName}\\root\\cimv2");
                        scope.Connect();
                    }

                    InitializeCommands();
                }
                catch (Exception e)
                {
                    OutputSink.WriteError($"Error connecting to \"{computerName}\" : {e.Message}");
                    throw e;
                }

                wmiRegProv = O_88B64416.WMIRegConnection(computerName, userName, password);
            }
            else
            {
                InitializeCommands();
            }
        }

        public ManagementObjectSearcher GetManagementObjectSearcher(string nameSpace, string query)
        {
            if (string.IsNullOrEmpty(ComputerName))
                return new ManagementObjectSearcher(nameSpace, query);
            try
            {
                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                {
                    var options = new ConnectionOptions
                    {
                        Username = UserName,
                        Password = Password,
                        Impersonation = ImpersonationLevel.Impersonate,
                        EnablePrivileges = true
                    };
                    var scope = new ManagementScope($"\\\\{ComputerName}\\{nameSpace}", options);
                    scope.Connect();
                    var queryObj = new ObjectQuery(query);
                    return new ManagementObjectSearcher(scope, queryObj);
                }
                else
                {
                    var scope = new ManagementScope($"\\\\{ComputerName}\\{nameSpace}");
                    scope.Connect();
                    var queryObj = new ObjectQuery(query);
                    return new ManagementObjectSearcher(scope, queryObj);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error connecting to \"{ComputerName}\" : {e.Message}");
            }
        }

        public string[]? GetSubkeyNames(RegistryHive hive, string path)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetSubkeyNames(hive, path, wmiRegProv);
            }

            return RegistryUtil.GetSubkeyNames(hive, path);
        }

        public string? GetStringValue(RegistryHive hive, string path, string value)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetStringValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetStringValue(hive, path, value);
        }

        public uint? GetDwordValue(RegistryHive hive, string path, string value)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetDwordValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetDwordValue(hive, path, value);
        }

        public byte[]? GetBinaryValue(RegistryHive hive, string path, string value)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetBinaryValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetBinaryValue(hive, path, value);
        }

        public Dictionary<string, object> GetValues(RegistryHive hive, string path)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetValues(hive, path, wmiRegProv);
            }

            return RegistryUtil.GetValues(hive, path);
        }

        public string[] GetUserSIDs()
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetUserSIDs(wmiRegProv);
            }

            return RegistryUtil.GetUserSIDs();
        }

        public string[] GetDirectories(string relPath)
        {
            relPath = relPath.Trim('\\');
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return System.IO.Directory.GetDirectories($"\\\\{ComputerName}\\C$\\{relPath}\\");
            }
            else
            {
                return System.IO.Directory.GetDirectories($"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("vMdR6nK1rVOGyEc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("774inhfY6SE=")[iii % 8])).ToArray()))}\\{relPath}\\");
            }
        }

        public EventLogReader GetEventLogReader(string path, string query)
        {
            var eventsQuery = new EventLogQuery(path, PathType.LogName, query)
            {
                ReverseDirection = true
            };
            if (!string.IsNullOrEmpty(ComputerName))
            {
                var session = new EventLogSession(ComputerName);
                eventsQuery.Session = session;
            }

            var logReader = new EventLogReader(eventsQuery);
            return logReader;
        }

        public string GetEnvironmentVariable(string variableName)
        {
            if (!string.IsNullOrEmpty(ComputerName))
            {
                var result = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZJvWxhPI84=")[iii % 8])).ToArray());
                var wmiData = this.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("jMT2U1x9VB+ImQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/quZJwAePXI=")[iii % 8])).ToArray()), $"SELECT VariableValue from win32_environment WHERE name='{variableName}' AND UserName='<SYSTEM>'");
                foreach (var wmiResult in wmiData.Get())
                {
                    result = wmiResult[Encoding.UTF8.GetString(Convert.FromBase64String("CHYBr8VrSMUIdh+zwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XhdzxqQJJKA=")[iii % 8])).ToArray())].ToString();
                }

                return result;
            }
            else
            {
                return Environment.GetEnvironmentVariable(variableName);
            }
        }

        public bool ISRemote()
        {
            return !string.IsNullOrEmpty(ComputerName);
        }

        private void InitializeCommands()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!type.IsSubclassOf(typeof(O_2183A68D)) || type.IsAbstract)
                {
                    continue;
                }

                var instance = (O_2183A68D)Activator.CreateInstance(type, new object[] { this });
#if DEBUG
                if (instance.Command != "TEMPLATE")
                {
                    AllCommands.Add(instance);
                }
#else
                AllCommands.Add(instance);
#endif
            }

            AllCommands = AllCommands.OrderBy(c => c.Command).ToList();
        }

        public void Execute()
        {
            foreach (var group in CommandGroups)
            {
                if (!ProcessGroup(group))
                {
                    OutputSink.WriteError($"Invalid command group \"{group}\"");
                }
            }

            foreach (var command in Commands)
            {
                try
                {
                    if (!ProcessCommand(command))
                    {
                        OutputSink.WriteError($"Error running command \"{command}\"");
                    }
                }
                catch (Exception e)
                {
                    OutputSink.WriteError($"Error running {command}: {e}");
                }
            }
        }

        private bool ProcessGroup(string command)
        {
            var commandGroupStrings = Enum.GetNames(typeof(CommandGroup)).ToList().Select(g => g.ToLower());
            if (!commandGroupStrings.Contains(command.ToLower()))
                return false;
            List<O_2183A68D> toExecute;
            List<O_2183A68D> toExclude = new List<O_2183A68D>();
            foreach (var remainingCommand in Commands)
            {
                if (remainingCommand.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("27JwnknhwTU=")[iii % 8])).ToArray())))
                {
                    var foundCommand = AllCommands.FirstOrDefault(c => c.Command.Equals(remainingCommand.Substring(1), StringComparison.InvariantCultureIgnoreCase));
                    if (foundCommand != null)
                    {
                        toExclude.Add(foundCommand);
                    }
                }
            }

            switch (command.ToLower())
            {
                case "all":
                    toExecute = AllCommands.ToList();
                    break;
                default:
                    CommandGroup commandGroup;
                    try
                    {
                        var groupName = Enum.GetNames(typeof(CommandGroup)).FirstOrDefault(c => c.ToLower() == command.ToLower());
                        commandGroup = (CommandGroup)Enum.Parse(typeof(CommandGroup), groupName);
                    }
                    catch (ArgumentException)
                    {
                        return false;
                    }

                    toExecute = AllCommands.Where(g => g.Group.Contains(commandGroup)).ToList();
                    break;
            }

            var commandsFiltered = toExecute.Where(c => !toExclude.Contains(c)).ToList();
            if (RandomizeOrder)
            {
                OutputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("rpVl5z3csduHn1ehUtq929XYSqgH3vLN1dxXqh/Pu9qGn0+uHsL13JCfSqYcyrrTnMVdzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9b84x3Ku1b4=")[iii % 8])).ToArray()));
                RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
                commandsFiltered = commandsFiltered.OrderBy(x => Next(random)).ToList();
            }

            commandsFiltered.ForEach(c =>
            {
                ExecuteCommand(c, new string[] { });
            });
            return true;
        }

        private bool ProcessCommand(string commandLine)
        {
            var args = Shell32.CommandLineToArgs(commandLine);
            var commandName = args[0];
            var command = AllCommands.FirstOrDefault(c => c.Command.Equals(commandName, StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                return false;
            }

            var commandArgs = new string[]
            {
            };
            if (args.Length > 1)
            {
                commandArgs = args.SubArray(1, args.Length - 1);
            }

            ExecuteCommand(command, commandArgs);
            return true;
        }

        private void ExecuteCommand(O_2183A68D? command, string[] commandArgs)
        {
            try
            {
                if (!string.IsNullOrEmpty(DelayCommands))
                {
                    Thread.Sleep(Int32.Parse(DelayCommands));
                }

                OutputSink.WriteOutput(new O_75A28A1C($"====== {command.Command} ======\n"));
                var results = command.Execute(commandArgs);
                if (results != null)
                {
                    foreach (var result in results)
                    {
                        result.SetCommandVersion(command.CommandVersion);
                        OutputSink.WriteOutput(result);
                    }
                }
            }
            catch (Exception e)
            {
                OutputSink.WriteError($"  [!] Terminating exception running command '{command.Command}': " + e);
            }
        }

        static int Next(RNGCryptoServiceProvider random)
        {
            byte[] randomInt = new byte[4];
            random.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }

        public ManagementObjectSearcher GetManagementObjectSearcher(string nameSpace, string query, string PBkTiQql)
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

            if (string.IsNullOrEmpty(ComputerName))
                return new ManagementObjectSearcher(nameSpace, query);
            try
            {
                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                {
                    var options = new ConnectionOptions
                    {
                        Username = UserName,
                        Password = Password,
                        Impersonation = ImpersonationLevel.Impersonate,
                        EnablePrivileges = true
                    };
                    var scope = new ManagementScope($"\\\\{ComputerName}\\{nameSpace}", options);
                    scope.Connect();
                    var queryObj = new ObjectQuery(query);
                    return new ManagementObjectSearcher(scope, queryObj);
                }
                else
                {
                    var scope = new ManagementScope($"\\\\{ComputerName}\\{nameSpace}");
                    scope.Connect();
                    var queryObj = new ObjectQuery(query);
                    return new ManagementObjectSearcher(scope, queryObj);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error connecting to \"{ComputerName}\" : {e.Message}");
            }
        }

        public string[]? GetSubkeyNames(RegistryHive hive, string path, string GEpthLcd)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetSubkeyNames(hive, path, wmiRegProv);
            }

            return RegistryUtil.GetSubkeyNames(hive, path);
        }

        public string? GetStringValue(RegistryHive hive, string path, string value, string tHtogsZH)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetStringValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetStringValue(hive, path, value);
        }

        public uint? GetDwordValue(RegistryHive hive, string path, string value, string CepNkaxW)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetDwordValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetDwordValue(hive, path, value);
        }

        public byte[]? GetBinaryValue(RegistryHive hive, string path, string value, string nSDnLhqs)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetBinaryValue(hive, path, value, wmiRegProv);
            }

            return RegistryUtil.GetBinaryValue(hive, path, value);
        }

        public Dictionary<string, object> GetValues(RegistryHive hive, string path, string ExfwlVUL)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetValues(hive, path, wmiRegProv);
            }

            return RegistryUtil.GetValues(hive, path);
        }

        public string[] GetUserSIDs(string BrcjRuUX)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                return RegistryUtil.GetUserSIDs(wmiRegProv);
            }

            return RegistryUtil.GetUserSIDs();
        }

        public string[] GetDirectories(string relPath, string bcRDbdBg)
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

            relPath = relPath.Trim('\\');
            if (!string.IsNullOrEmpty(ComputerName))
            {
                return System.IO.Directory.GetDirectories($"\\\\{ComputerName}\\C$\\{relPath}\\");
            }
            else
            {
                return System.IO.Directory.GetDirectories($"{Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("vMdR6nK1rVOGyEc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("774inhfY6SE=")[iii % 8])).ToArray()))}\\{relPath}\\");
            }
        }

        public EventLogReader GetEventLogReader(string path, string query, string GSGPIpRL)
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

            var eventsQuery = new EventLogQuery(path, PathType.LogName, query)
            {
                ReverseDirection = true
            };
            if (!string.IsNullOrEmpty(ComputerName))
            {
                var session = new EventLogSession(ComputerName);
                eventsQuery.Session = session;
            }

            var logReader = new EventLogReader(eventsQuery);
            return logReader;
        }

        public string GetEnvironmentVariable(string variableName, string RBjiMdWg)
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

            if (!string.IsNullOrEmpty(ComputerName))
            {
                var result = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZJvWxhPI84=")[iii % 8])).ToArray());
                var wmiData = this.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("jMT2U1x9VB+ImQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/quZJwAePXI=")[iii % 8])).ToArray()), $"SELECT VariableValue from win32_environment WHERE name='{variableName}' AND UserName='<SYSTEM>'");
                foreach (var wmiResult in wmiData.Get())
                {
                    result = wmiResult[Encoding.UTF8.GetString(Convert.FromBase64String("CHYBr8VrSMUIdh+zwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XhdzxqQJJKA=")[iii % 8])).ToArray())].ToString();
                }

                return result;
            }
            else
            {
                return Environment.GetEnvironmentVariable(variableName);
            }
        }

        public bool ISRemote(string KdLtxOEs)
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

            return !string.IsNullOrEmpty(ComputerName);
        }

        private void InitializeCommands(string xfMjQmQb)
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

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (!type.IsSubclassOf(typeof(O_2183A68D)) || type.IsAbstract)
                {
                    continue;
                }

                var instance = (O_2183A68D)Activator.CreateInstance(type, new object[] { this });
#if DEBUG
                if (instance.Command != "TEMPLATE")
                {
                    AllCommands.Add(instance);
                }
#else
                AllCommands.Add(instance);
#endif
            }

            AllCommands = AllCommands.OrderBy(c => c.Command).ToList();
        }

        public void Execute(string wzpSPFDM)
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

            foreach (var group in CommandGroups)
            {
                if (!ProcessGroup(group))
                {
                    OutputSink.WriteError($"Invalid command group \"{group}\"");
                }
            }

            foreach (var command in Commands)
            {
                try
                {
                    if (!ProcessCommand(command))
                    {
                        OutputSink.WriteError($"Error running command \"{command}\"");
                    }
                }
                catch (Exception e)
                {
                    OutputSink.WriteError($"Error running {command}: {e}");
                }
            }
        }

        private bool ProcessGroup(string command, string ZRRQKmLy)
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

            var commandGroupStrings = Enum.GetNames(typeof(CommandGroup)).ToList().Select(g => g.ToLower());
            if (!commandGroupStrings.Contains(command.ToLower()))
                return false;
            List<O_2183A68D> toExecute;
            List<O_2183A68D> toExclude = new List<O_2183A68D>();
            foreach (var remainingCommand in Commands)
            {
                if (remainingCommand.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String("9g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("27JwnknhwTU=")[iii % 8])).ToArray())))
                {
                    var foundCommand = AllCommands.FirstOrDefault(c => c.Command.Equals(remainingCommand.Substring(1), StringComparison.InvariantCultureIgnoreCase));
                    if (foundCommand != null)
                    {
                        toExclude.Add(foundCommand);
                    }
                }
            }

            switch (command.ToLower())
            {
                case "all":
                    toExecute = AllCommands.ToList();
                    break;
                default:
                    CommandGroup commandGroup;
                    try
                    {
                        var groupName = Enum.GetNames(typeof(CommandGroup)).FirstOrDefault(c => c.ToLower() == command.ToLower());
                        commandGroup = (CommandGroup)Enum.Parse(typeof(CommandGroup), groupName);
                    }
                    catch (ArgumentException)
                    {
                        return false;
                    }

                    toExecute = AllCommands.Where(g => g.Group.Contains(commandGroup)).ToList();
                    break;
            }

            var commandsFiltered = toExecute.Where(c => !toExclude.Contains(c)).ToList();
            if (RandomizeOrder)
            {
                OutputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("rpVl5z3csduHn1ehUtq929XYSqgH3vLN1dxXqh/Pu9qGn0+uHsL13JCfSqYcyrrTnMVdzQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9b84x3Ku1b4=")[iii % 8])).ToArray()));
                RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();
                commandsFiltered = commandsFiltered.OrderBy(x => Next(random)).ToList();
            }

            commandsFiltered.ForEach(c =>
            {
                ExecuteCommand(c, new string[] { });
            });
            return true;
        }

        private bool ProcessCommand(string commandLine, string FktxRIis)
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

            var args = Shell32.CommandLineToArgs(commandLine);
            var commandName = args[0];
            var command = AllCommands.FirstOrDefault(c => c.Command.Equals(commandName, StringComparison.InvariantCultureIgnoreCase));
            if (command == null)
            {
                return false;
            }

            var commandArgs = new string[]
            {
            };
            if (args.Length > 1)
            {
                commandArgs = args.SubArray(1, args.Length - 1);
            }

            ExecuteCommand(command, commandArgs);
            return true;
        }

        private void ExecuteCommand(O_2183A68D? command, string[] commandArgs, string ONRcdive)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(14);
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
                if (!string.IsNullOrEmpty(DelayCommands))
                {
                    Thread.Sleep(Int32.Parse(DelayCommands));
                }

                OutputSink.WriteOutput(new O_75A28A1C($"====== {command.Command} ======\n"));
                var results = command.Execute(commandArgs);
                if (results != null)
                {
                    foreach (var result in results)
                    {
                        result.SetCommandVersion(command.CommandVersion);
                        OutputSink.WriteOutput(result);
                    }
                }
            }
            catch (Exception e)
            {
                OutputSink.WriteError($"  [!] Terminating exception running command '{command.Command}': " + e);
            }
        }

        static int Next(RNGCryptoServiceProvider random, string kHlMnERE)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(14);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            byte[] randomInt = new byte[4];
            random.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }
    }
}
#nullable enable
