using O_F41F88FA.Commands;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Formatters
{
    internal abstract class TextFormatterBase
    {
        private readonly ITextWriter _textWriter;
        protected TextFormatterBase(ITextWriter sink)
        {
            _textWriter = sink;
        }

        public abstract void FormatResult(O_2183A68D? command, O_4AED570F results, bool filterResults);
        protected void Write(string str) => _textWriter.Write(str);
        protected void WriteLine() => _textWriter.WriteLine();
        protected void WriteLine(string str) => _textWriter.WriteLine(str);
        protected void WriteLine(string format, params object? [] args) => _textWriter.WriteLine(format, args);
    }
}