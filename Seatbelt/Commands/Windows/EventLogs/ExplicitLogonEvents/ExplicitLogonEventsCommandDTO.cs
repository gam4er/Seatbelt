#nullable disable
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows.EventLogs.ExplicitLogonEvents
{
internal class O_B860970F : O_4AED570F
{
    public string SubjectUser { get; set; }
    public string SubjectDomain { get; set; }
    public string TargetUser { get; set; }
    public string TargetDomain { get; set; }
    public string Process { get; set; }
    public string IpAddress { get; set; }
    public DateTime? TimeCreatedUtc { get; set; }
}}
#nullable enable
