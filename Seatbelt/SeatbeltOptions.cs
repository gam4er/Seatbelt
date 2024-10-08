using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA
{
    class O_F2A11310
    {
        public O_F2A11310(IEnumerable<string> commands, IEnumerable<string> commandGroup, string? outputFile, bool filterResults, bool quietMode, bool randomizeOrder, string? delayCommands, string? computerName, string? userName, string? password)
        {
            Commands = commands;
            CommandGroups = commandGroup;
            OutputFile = outputFile;
            FilterResults = filterResults;
            RandomizeOrder = randomizeOrder;
            QuietMode = quietMode;
            DelayCommands = delayCommands;
            ComputerName = computerName;
            UserName = userName;
            Password = password;
        }

        public IEnumerable<string> Commands { get; set; }
        public IEnumerable<string> CommandGroups { get; set; }
        public string? OutputFile { get; set; }
        public bool FilterResults { get; set; }
        public bool RandomizeOrder { get; set; }
        public bool QuietMode { get; set; }
        public string? DelayCommands { get; set; }
        public string? ComputerName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}