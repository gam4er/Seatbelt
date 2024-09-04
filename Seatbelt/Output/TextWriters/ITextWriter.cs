using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.TextWriters
{
    internal interface ITextWriter : IDisposable
    {
        void Write(string str);
        void WriteLine();
        void WriteLine(string str);
        void WriteLine(string format, params object? [] args);
    }
}