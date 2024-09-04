using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_DDA13DE3 : O_4AED570F
{
    public O_DDA13DE3(string message)
    {
        Message = message;
    }

    public string Message { get; }
}
    [CommandOutputType(typeof(O_DDA13DE3))]
    internal class O_64945148 : TextFormatterBase
    {
        public O_64945148(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_DDA13DE3)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("sJMfwnaBmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9cFNjSS7ubE=")[iii % 8])).ToArray()) + dto.Message);
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

            var dto = (O_DDA13DE3)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("sJMfwnaBmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9cFNjSS7ubE=")[iii % 8])).ToArray()) + dto.Message);
        }
    }
}