using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_75A28A1C : O_4AED570F
{
    public O_75A28A1C(string message)
    {
        Message = message;
    }

    public string Message { get; }
}
    [CommandOutputType(typeof(O_75A28A1C))]
    internal class O_DF88C2BA : TextFormatterBase
    {
        public O_DF88C2BA(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_75A28A1C)result;
            WriteLine(dto.Message);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string DNttyqMm)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.Seek(61294, new System.IO.SeekOrigin());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_75A28A1C)result;
            WriteLine(dto.Message);
        }
    }
}