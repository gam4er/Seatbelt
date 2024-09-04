#nullable disable
using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_2404849F : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("rR5yzAXIAx6NHnD1FtMF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6HAEpXenbXM=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("ql/vvFEn4KqMROunRib654xE6e4RGdXeoQ69qFsl8O+bWb2vWi202a1u0e5dJ/Llm0f8ul0m+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6SqdzjRJlIo=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => false;

    public O_2404849F(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var pathString = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("dR3VSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JXyhIys29Ew=")[iii % 8])).ToArray()));
        var paths = pathString.Split(';');
        foreach (var path in paths)
        {
            var SDDL = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I9qHiweDLFI=")[iii % 8])).ToArray());
            if (!String.IsNullOrEmpty(path.Trim()))
            {
                try
                {
                    var security = Directory.GetAccessControl(path, AccessControlSections.Owner | AccessControlSections.Access);
                    SDDL = security.GetSecurityDescriptorSddlForm(AccessControlSections.Owner | AccessControlSections.Access);
                }
                catch
                {
                }

                yield return new O_F2D1C167()
                {
                    Name = path.Trim(),
                    SDDL = SDDL
                };
            }
        }
    }

internal class O_F2D1C167 : O_4AED570F
{
    public string Name { get; set; }
    public string SDDL { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string oKRPOXTQ)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.Cryptography.X509Certificates.X509Certificate instance = new System.Security.Cryptography.X509Certificates.X509Certificate();
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var pathString = Environment.GetEnvironmentVariable(Encoding.UTF8.GetString(Convert.FromBase64String("dR3VSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JXyhIys29Ew=")[iii % 8])).ToArray()));
        var paths = pathString.Split(';');
        foreach (var path in paths)
        {
            var SDDL = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I9qHiweDLFI=")[iii % 8])).ToArray());
            if (!String.IsNullOrEmpty(path.Trim()))
            {
                try
                {
                    var security = Directory.GetAccessControl(path, AccessControlSections.Owner | AccessControlSections.Access);
                    SDDL = security.GetSecurityDescriptorSddlForm(AccessControlSections.Owner | AccessControlSections.Access);
                }
                catch
                {
                }

                yield return new O_F2D1C167()
                {
                    Name = path.Trim(),
                    SDDL = SDDL
                };
            }
        }
    }
}}
#nullable enable
