using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    internal abstract class O_2183A68D
    {
        public abstract string Command { get; }
        public virtual string CommandVersion { get; set; }
        public abstract string Description { get; }
        public abstract CommandGroup[] Group { get; }
        public abstract bool SupportRemote { get; }
        public Runtime Runtime { get; set; }

        protected O_2183A68D(Runtime runtime)
        {
            CommandVersion = Encoding.UTF8.GetString(Convert.FromBase64String("X7b4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bpjI4Qdnkhs=")[iii % 8])).ToArray());
            Runtime = runtime;
        }

        public abstract IEnumerable<O_4AED570F?> Execute(string[] args);
        public void WriteOutput(O_4AED570F dto) => throw new NotImplementedException();
        public void WriteVerbose(string message) => Runtime.OutputSink.WriteVerbose(message);
        public void WriteWarning(string message) => Runtime.OutputSink.WriteWarning(message);
        public void WriteError(string message) => Runtime.OutputSink.WriteError(message);
        public void WriteHost(string format = "", params object[] args) => Runtime.OutputSink.WriteHost(string.Format(format, args));
    }
}