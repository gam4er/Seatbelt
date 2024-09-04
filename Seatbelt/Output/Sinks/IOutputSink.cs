using System;
using O_F41F88FA.Commands;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Sinks
{
    internal interface IOutputSink : IDisposable
    {
        void WriteOutput(O_4AED570F dto);
        void WriteHost(string message);
        void WriteVerbose(string message);
        void WriteWarning(string message);
        void WriteError(string message);
        string GetOutput();
    }
}