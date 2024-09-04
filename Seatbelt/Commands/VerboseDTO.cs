using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
class O_77AFBCF7 : O_4AED570F
{
    public O_77AFBCF7(string message)
    {
        Message = message;
    }

    public string Message { get; }
}
    [CommandOutputType(typeof(O_77AFBCF7))]
    internal class O_27435FC4 : TextFormatterBase
    {
        public O_27435FC4(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F dto, bool filterResults)
        {
            WriteLine(((O_77AFBCF7)dto).Message);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F dto, bool filterResults, string OWPArGZD)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.RSACryptoServiceProvider instance = new System.Security.Cryptography.RSACryptoServiceProvider();
                        instance.ExportParameters(false);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            WriteLine(((O_77AFBCF7)dto).Message);
        }
    }
}