#nullable disable
using Microsoft.Win32;
using O_F41F88FA.Util;
using System;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_C4F748A3 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("NiRfPEWrsV0WJF0DVra2UREmTCY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c0opVTfE3zA=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("dKdtXySf4jlSvGlEM574dFK8aw03kORwVrBzSDI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N9IfLUHxlhk=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System,
        CommandGroup.Remote
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_C4F748A3(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var envVariables = new List<O_10B96862>();
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("ttZi2urF3Bayiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xLkNrramtXs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9rNTBPa5Q2fWs00v9KAGHuu3UgS5mwJAzLddDfCbAl7Qsx8H56IOEtK/UVKnkgZc079NDvugBlzR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pdY/YZXNYzI=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var envVariable in data)
            {
                envVariables.Add(new O_10B96862(envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("KZL6D37c0aI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOGffTC9vMc=")[iii % 8])).ToArray())], envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("XhPWpA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EHK7wWC5AC8=")[iii % 8])).ToArray())], envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("VF3VPk2K3TZUXcsiSQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AjynVyzosVM=")[iii % 8])).ToArray())]));
            }
        }
        catch
        {
        }

        foreach (var envVariable in envVariables)
        {
            yield return envVariable;
        }
    }

internal class O_10B96862 : O_4AED570F
{
    public O_10B96862(object userName, object name, object value)
    {
        UserName = userName.ToString();
        Name = name.ToString();
        Value = value.ToString();
    }

    public string UserName { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}    [CommandOutputType(typeof(O_10B96862))]
    internal class O_9CD1FBDF : TextFormatterBase
    {
        public O_9CD1FBDF(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_10B96862)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("/Ix2zEesxa+h1zzQRrLD56eecA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3KwN/GuB9po=")[iii % 8])).ToArray()), dto.UserName, dto.Name, dto.Value);
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string KtrCjFkf)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Collections.ArrayList instance = new System.Collections.ArrayList();
                        instance.Reverse(4, 47);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_10B96862)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("/Ix2zEesxa+h1zzQRrLD56eecA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3KwN/GuB9po=")[iii % 8])).ToArray()), dto.UserName, dto.Name, dto.Value);
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string CYlSipSA)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Collections.ArrayList instance = new System.Collections.ArrayList();
                    instance.Reverse(4, 47);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var envVariables = new List<O_10B96862>();
        try
        {
            var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("ttZi2urF3Bayiw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xLkNrramtXs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9rNTBPa5Q2fWs00v9KAGHuu3UgS5mwJAzLddDfCbAl7Qsx8H56IOEtK/UVKnkgZc079NDvugBlzR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pdY/YZXNYzI=")[iii % 8])).ToArray()));
            var data = wmiData.Get();
            foreach (var envVariable in data)
            {
                envVariables.Add(new O_10B96862(envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("KZL6D37c0aI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fOGffTC9vMc=")[iii % 8])).ToArray())], envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("XhPWpA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EHK7wWC5AC8=")[iii % 8])).ToArray())], envVariable[Encoding.UTF8.GetString(Convert.FromBase64String("VF3VPk2K3TZUXcsiSQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AjynVyzosVM=")[iii % 8])).ToArray())]));
            }
        }
        catch
        {
        }

        foreach (var envVariable in envVariables)
        {
            yield return envVariable;
        }
    }
}}
#nullable enable
