#nullable disable
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using O_F41F88FA.Output.Formatters;
using static O_F41F88FA.Interop.O_F8D7398B;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_E15B54D1 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("nKsGf2H+r7yqvitWcOG2t7qI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zvtFMgCO39k=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("3LuqWKClDTTNnpsKoKUdZPCntl626xR17769Tg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n87YKsXLeRQ=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    private const uint RPC_X_NO_MORE_ENTRIES = 1772;
    public O_E15B54D1(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        uint retCode;
        uint status;
        var ifId = new RPC_IF_ID();
        string host = null;
        if (args.Length >= 1)
        {
            host = args[0];
        }

        retCode = RpcStringBindingCompose(null, Encoding.UTF8.GetString(Convert.FromBase64String("IFvanBhy8aERTNiP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tji7/3YtmNE=")[iii % 8])).ToArray()), host, null, null, out var stringBinding);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcStringBindingCompose : {retCode}");
            yield break;
        }

        retCode = RpcBindingFromStringBinding(stringBinding, out var bindingHandle);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcBindingFromStringBinding : {retCode}");
            yield break;
        }

        retCode = RpcMgmtEpEltInqBegin(bindingHandle, 0, 0, 0, 0, out var inquiryContext);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcMgmtEpEltInqBegin : {retCode}");
            yield break;
        }

        do
        {
            status = RpcMgmtEpEltInqNext(inquiryContext, ref ifId, out var elementBinding, 0, out var elementAnnotation);
            if (status == RPC_X_NO_MORE_ENTRIES)
            {
                break;
            }
            else if (status != 0)
            {
                Console.WriteLine($"RpcMgmtEpEltInqNext failed. Error code: {status}");
                break;
            }

            string annotation = elementAnnotation.ToString();
            string binding = elementBinding.ToString();
            yield return new O_E5AEFE7F(ifId.Uuid, annotation, binding, new Version(ifId.VersMajor, ifId.VersMinor));
        }
        while (status == 0);
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string sryHqCjw)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.SecureString instance = new System.Security.SecureString();
                    instance.InsertAt(84, 'u');
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        uint retCode;
        uint status;
        var ifId = new RPC_IF_ID();
        string host = null;
        if (args.Length >= 1)
        {
            host = args[0];
        }

        retCode = RpcStringBindingCompose(null, Encoding.UTF8.GetString(Convert.FromBase64String("IFvanBhy8aERTNiP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Tji7/3YtmNE=")[iii % 8])).ToArray()), host, null, null, out var stringBinding);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcStringBindingCompose : {retCode}");
            yield break;
        }

        retCode = RpcBindingFromStringBinding(stringBinding, out var bindingHandle);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcBindingFromStringBinding : {retCode}");
            yield break;
        }

        retCode = RpcMgmtEpEltInqBegin(bindingHandle, 0, 0, 0, 0, out var inquiryContext);
        if (retCode != 0)
        {
            WriteError($"Bad return value from RpcMgmtEpEltInqBegin : {retCode}");
            yield break;
        }

        do
        {
            status = RpcMgmtEpEltInqNext(inquiryContext, ref ifId, out var elementBinding, 0, out var elementAnnotation);
            if (status == RPC_X_NO_MORE_ENTRIES)
            {
                break;
            }
            else if (status != 0)
            {
                Console.WriteLine($"RpcMgmtEpEltInqNext failed. Error code: {status}");
                break;
            }

            string annotation = elementAnnotation.ToString();
            string binding = elementBinding.ToString();
            yield return new O_E5AEFE7F(ifId.Uuid, annotation, binding, new Version(ifId.VersMajor, ifId.VersMinor));
        }
        while (status == 0);
    }
}public class O_E5AEFE7F : O_4AED570F
{
    public O_E5AEFE7F(Guid interfaceId, string annotation, string bindingString, Version version)
    {
        InterfaceId = interfaceId;
        Annotation = annotation;
        BindingString = bindingString;
        Version = version;
    }

    public Guid InterfaceId { get; set; }
    public string Annotation { get; set; }
    public string BindingString { get; set; }
    public Version Version { get; internal set; }
}
    [CommandOutputType(typeof(O_E5AEFE7F))]
    internal class O_90A98118 : TextFormatterBase
    {
        public O_90A98118(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_E5AEFE7F)result;
            WriteLine($"  {dto.InterfaceId} v{dto.Version} ({dto.Annotation}): {dto.BindingString}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string nUHNuhgU)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.SecureString instance = new System.Security.SecureString();
                        instance.InsertAt(84, 'u');
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_E5AEFE7F)result;
            WriteLine($"  {dto.InterfaceId} v{dto.Version} ({dto.Annotation}): {dto.BindingString}");
        }
    }
}
#nullable enable
