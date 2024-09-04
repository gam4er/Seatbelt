using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
class O_56497D89 : O_4AED570F
{
    public O_56497D89(string message)
    {
        Message = message;
    }

    public string Message { get; }
}
    [CommandOutputType(typeof(O_56497D89))]
    internal class O_AE6533F0 : TextFormatterBase
    {
        public O_AE6533F0(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F dto, bool filterResults)
        {
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OZp1hvvMeVNO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("btsnyLKCPmk=")[iii % 8])).ToArray()) + ((O_56497D89)dto).Message);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F dto, bool filterResults, string YbygrKTf)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseLunisolarCalendar instance = new System.Globalization.JapaneseLunisolarCalendar();
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

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("OZp1hvvMeVNO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("btsnyLKCPmk=")[iii % 8])).ToArray()) + ((O_56497D89)dto).Message);
        }
    }
}