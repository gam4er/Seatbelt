using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs.ExplicitLogonEvents
{
    [CommandOutputType(typeof(O_B860970F))]
    internal class O_462E34E4 : TextFormatterBase
    {
        private readonly Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();
        public O_462E34E4(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_B860970F)result;
            var targetUser = dto.TargetDomain + Encoding.UTF8.GetString(Convert.FromBase64String("4A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vIAAakjf9i4=")[iii % 8])).ToArray()) + dto.TargetUser;
            var subjectUser = dto.SubjectDomain + Encoding.UTF8.GetString(Convert.FromBase64String("oA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/LdAtukIXzM=")[iii % 8])).ToArray()) + dto.SubjectUser;
            var uniqueCredKey = $"{targetUser},{dto.Process},{subjectUser},{dto.IpAddress}";
            WriteLine($"{dto.TimeCreatedUtc?.ToLocalTime().ToString(Encoding.UTF8.GetString(Convert.FromBase64String("y7IbiuDKcqT/hhSG7N9msKaLQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hv807oTlC90=")[iii % 8])).ToArray()))},{uniqueCredKey}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string oKRPOXTQ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.X509Certificates.X509Certificate instance = new System.Security.Cryptography.X509Certificates.X509Certificate();
                    //instance.GetCertHashString(new System.Security.Cryptography.HashAlgorithmName());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_B860970F)result;
            var targetUser = dto.TargetDomain + Encoding.UTF8.GetString(Convert.FromBase64String("4A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vIAAakjf9i4=")[iii % 8])).ToArray()) + dto.TargetUser;
            var subjectUser = dto.SubjectDomain + Encoding.UTF8.GetString(Convert.FromBase64String("oA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/LdAtukIXzM=")[iii % 8])).ToArray()) + dto.SubjectUser;
            var uniqueCredKey = $"{targetUser},{dto.Process},{subjectUser},{dto.IpAddress}";
            WriteLine($"{dto.TimeCreatedUtc?.ToLocalTime().ToString(Encoding.UTF8.GetString(Convert.FromBase64String("y7IbiuDKcqT/hhSG7N9msKaLQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hv807oTlC90=")[iii % 8])).ToArray()))},{uniqueCredKey}");
        }
    }
}