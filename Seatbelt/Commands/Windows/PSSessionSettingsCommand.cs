using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Util;
using System.Xml;
using System.Collections.Generic;
using System.Security.AccessControl;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    class O_9E24156B
    {
        public O_9E24156B(string principal, string sid, string permission)
        {
            Principal = principal;
            Sid = sid;
            Permission = permission;
        }

        public string Principal { get; }
        public string Sid { get; }
        public string Permission { get; }
    }
internal class O_3F7D0F09 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("oxsUiXvDdfSdGyKYfNly/IA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("80hH7AiwHJs=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("OMhHVME9/3sY1RJp92/Nag7VW1bKb81qCdJbV8M8vmkPyV8Z0Cf7Lw/DVVDXO+x2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("faYyOaRPng8=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_3F7D0F09(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("B/h+y41mbF09tnzGjW8pSia4P+SUcDgJMPM/yI8jLU0//3HAknc+SCb5bYc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UpYfqeEDTCk=")[iii % 8])).ToArray()));
            yield break;
        }

        var plugins = new[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("HdkqYxd1MKgknhl+D2MtnTjVJX0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ULBJEXgGX84=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("GeB7s0+hhYsgp0iuV7eYvjzsdK0OhYWfP+90rlc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VIkYwSDS6u0=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("n4PcDggpjUWmxO8TED+QcLqP0xBUaA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0uq/fGda4iM=")[iii % 8])).ToArray())
        };
        foreach (var plugin in plugins)
        {
            var config = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WSMAN\\Plugin\\{plugin}", Encoding.UTF8.GetString(Convert.FromBase64String("40iDAkqh9evs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oCftZCPGraY=")[iii % 8])).ToArray()));
            if (config == null)
                continue;
            ;
            var access = new List<O_9E24156B>();
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(config);
            var security = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("YxDlKX+CYcs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MHWGXA3rFbI=")[iii % 8])).ToArray()));
            if (security.Count <= 0)
                continue;
            foreach (XmlAttribute attr in security[0].Attributes)
            {
                if (attr.Name != Encoding.UTF8.GetString(Convert.FromBase64String("YNYqRg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M7JOKlQOipg=")[iii % 8])).ToArray()))
                    continue;
                var desc = new RawSecurityDescriptor(attr.Value);
                foreach (QualifiedAce ace in desc.DiscretionaryAcl)
                {
                    var principal = ace.SecurityIdentifier.Translate(typeof(System.Security.Principal.NTAccount)).ToString();
                    var accessStr = ace.AceQualifier.ToString();
                    access.Add(new O_9E24156B(principal, ace.SecurityIdentifier.ToString(), accessStr));
                }
            }

            yield return new O_C494E4E9(plugin, access);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string ZHoleDau)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.IO.MemoryStream instance = new System.IO.MemoryStream();
                    instance.Seek(489910, new System.IO.SeekOrigin());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        if (!SecurityUtil.IsHighIntegrity() && !ThisRunTime.ISRemote())
        {
            WriteError(Encoding.UTF8.GetString(Convert.FromBase64String("B/h+y41mbF09tnzGjW8pSia4P+SUcDgJMPM/yI8jLU0//3HAknc+SCb5bYc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UpYfqeEDTCk=")[iii % 8])).ToArray()));
            yield break;
        }

        var plugins = new[]
        {
            Encoding.UTF8.GetString(Convert.FromBase64String("HdkqYxd1MKgknhl+D2MtnTjVJX0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ULBJEXgGX84=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("GeB7s0+hhYsgp0iuV7eYvjzsdK0OhYWfP+90rlc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VIkYwSDS6u0=")[iii % 8])).ToArray()),
            Encoding.UTF8.GetString(Convert.FromBase64String("n4PcDggpjUWmxO8TED+QcLqP0xBUaA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0uq/fGda4iM=")[iii % 8])).ToArray())
        };
        foreach (var plugin in plugins)
        {
            var config = ThisRunTime.GetStringValue(RegistryHive.LocalMachine, $"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WSMAN\\Plugin\\{plugin}", Encoding.UTF8.GetString(Convert.FromBase64String("40iDAkqh9evs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oCftZCPGraY=")[iii % 8])).ToArray()));
            if (config == null)
                continue;
            ;
            var access = new List<O_9E24156B>();
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(config);
            var security = xmlDoc.GetElementsByTagName(Encoding.UTF8.GetString(Convert.FromBase64String("YxDlKX+CYcs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MHWGXA3rFbI=")[iii % 8])).ToArray()));
            if (security.Count <= 0)
                continue;
            foreach (XmlAttribute attr in security[0].Attributes)
            {
                if (attr.Name != Encoding.UTF8.GetString(Convert.FromBase64String("YNYqRg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M7JOKlQOipg=")[iii % 8])).ToArray()))
                    continue;
                var desc = new RawSecurityDescriptor(attr.Value);
                foreach (QualifiedAce ace in desc.DiscretionaryAcl)
                {
                    var principal = ace.SecurityIdentifier.Translate(typeof(System.Security.Principal.NTAccount)).ToString();
                    var accessStr = ace.AceQualifier.ToString();
                    access.Add(new O_9E24156B(principal, ace.SecurityIdentifier.ToString(), accessStr));
                }
            }

            yield return new O_C494E4E9(plugin, access);
        }
    }
}internal class O_C494E4E9 : O_4AED570F
{
    public O_C494E4E9(string plugin, List<O_9E24156B> permission)
    {
        Plugin = plugin;
        Permission = permission;
    }

    public string Plugin { get; }
    public List<O_9E24156B> Permission { get; }
}
    [CommandOutputType(typeof(O_C494E4E9))]
    internal class O_9DE5870F : TextFormatterBase
    {
        public O_9DE5870F(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_C494E4E9)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("D2zw0Q6UH5UPN47N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L0y+sGPxP68=")[iii % 8])).ToArray()), dto.Plugin);
            foreach (var access in dto.Permission)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vB5wvvsvfaevCy2+oD9x8a0SfayyYg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nD5QnoAfUYo=")[iii % 8])).ToArray()), access.Principal, access.Permission);
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string pZSouRVU)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.Seek(489910, new System.IO.SeekOrigin());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_C494E4E9)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("D2zw0Q6UH5UPN47N").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L0y+sGPxP68=")[iii % 8])).ToArray()), dto.Plugin);
            foreach (var access in dto.Permission)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("vB5wvvsvfaevCy2+oD9x8a0SfayyYg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nD5QnoAfUYo=")[iii % 8])).ToArray()), access.Principal, access.Permission);
            }

            WriteLine();
        }
    }
}