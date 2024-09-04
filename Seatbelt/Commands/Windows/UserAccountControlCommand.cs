using System.Collections.Generic;
using Microsoft.Win32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_36966E8B : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("x0+8").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kg7/9dN+A7c=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("99jLXeRVIBrH9KgN+EA6Dcv8+13hRTJO1vHtXeVJNAfR7foE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("opmIfZcsU24=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.System
    };
    public override bool SupportRemote => true;

    public Runtime ThisRunTime;
    public O_36966E8B(Runtime runtime) : base(runtime)
    {
        ThisRunTime = runtime;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var consentPromptBehaviorAdmin = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("262QMZ7lsO7Ur78Gu8uRxO6WijKgyobE/5GKJrzWkM7mloAAu9eLxOa+hgqlzYHC7ZGKNrDXls7l").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iOLWZcmk4qs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qDXV08h8Pp+ZNdbQ2VAvp4os0s/fUy6igjQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("61q7oK0SSs8=")[iii % 8])).ToArray()));
        var enableLua = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("N+WCc/uAB6Y4561E3q4mjALemHDFrzGME9mYZNmzJ4YK3pJC3rI8jAr2lEjAqDaKAdmYdNWyIYYJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZKrEJ6zBVeM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mOoc1aBTjoOc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3YR9t8w2wtY=")[iii % 8])).ToArray()));
        var localAccountTokenFilterPolicy = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("+PTf8fDdrC739vDG1fONBM3PxfLO8poE3MjF5tLujA7Fz8/A1e+XBMXnycrL9Z0CzsjF9t7vig7G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q7uZpaec/ms=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9iVtnMzZuqvVP2CJ9PeyrdQMZ5HU/auY1SZnntk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ukoO/aCY2cg=")[iii % 8])).ToArray()));
        var filterAdministratorToken = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YV7D3idN18ZuXOzpAmP27FRl2d0ZYuHsRWLZyQV+9+ZcZdPvAn/s7FxN1eUcZebqV2LZ2Ql/8eZf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MhGFinAMhYM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("slehTIB26RyZV6NRlnDaGYBRv2yKb80W").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9D7NOOUEqHg=")[iii % 8])).ToArray()));
        yield return new O_A8F30596(consentPromptBehaviorAdmin, enableLua, filterAdministratorToken, localAccountTokenFilterPolicy);
    }

class O_A8F30596 : O_4AED570F
{
    public O_A8F30596(uint? consentPromptBehaviorAdmin, uint? enableLua, uint? filterAdministratorToken, uint? localAccountTokenFilterPolicy)
    {
        ConsentPromptBehaviorAdmin = consentPromptBehaviorAdmin;
        EnableLua = enableLua;
        FilterAdministratorToken = filterAdministratorToken;
        LocalAccountTokenFilterPolicy = localAccountTokenFilterPolicy;
    }

    public uint? ConsentPromptBehaviorAdmin { get; set; }
    public uint? EnableLua { get; set; }
    public uint? FilterAdministratorToken { get; set; }
    public uint? LocalAccountTokenFilterPolicy { get; set; }
}    [CommandOutputType(typeof(O_A8F30596))]
    internal class O_2FD4A4A7 : TextFormatterBase
    {
        public O_2FD4A4A7(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_A8F30596)result;
            switch (dto.ConsentPromptBehaviorAdmin)
            {
                case 0:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1VrCaYA69e+IWoN51ya7/9ha9zaMZ7SwmArNMMJw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9Xq5WawXxt8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DvT7oIOSCm0/9Pijkr4bVSzt/LyUvRpQJPU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZuV0+b8fj0=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 1:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("65f4rEjBt2+2l7m8H935f+aX0+4LgfQrhNnQ+QeZ9jqP0vD3EIP0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y7eDnGTshF8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("k/BXr1YXNg2i8FSsRzsnNbHpULNBOCYwufE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0J853DN5Ql0=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 2:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UhZxMj1UvmcPFjAiakjwd18WWnB+FP0jIlN4b3gNyTIcT0VsQhzuIgBTTmdiEvk4Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjYKAhF5jVc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hnzYEh4tuwO3fNsRDwGqO6Rl3w4JAqs+rH0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xRO2YXtDz1M=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 3:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jqm1LLsZYRzTqfQ87AUvDIOpnm74WSJY6Oa8X+VRNl/g5rpT+Wc3T9v7q1jyRzlYwfk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ronOHJc0Uiw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("KhnUBDyIrB8bGdcHLaS9JwgA0xgrp7wiABg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aXa6d1nm2E8=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 4:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gD28l3d1n6PdPf2HIGnRs409l9U0Ndzn5nK19z4qwfrUWaLJIhbD5+9zlMI4Ld725Hi0zC833A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oB3Hp1tYrJM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("OZQhv+HFrL8IlCK88Om9hxuNJqP26ryCE5U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evtPzISr2O8=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 5:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("db7CYaudQokovoNx/IEMmXi+6SPo3QHNE/HLH+jeJtA7+tYm9PIY1zTs0DT0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VZ65UYewcbk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SzpVPG8HlHt6OlY/fiuFQ2kjUiB4KIRGYTs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CFU7Twpp4Cs=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                default:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("96v9Cd7rydaqq7wZorSVi6f/wFaAiJWIgOLoXZ2xiaS+5edLm6OJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("14uGOfLG+uY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("W59uhNEzsfBqn22HwB+gyHmGaZjGHKHNcZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GPAA97RdxaA=")[iii % 8])).ToArray()));
                    break;
            }

            bool enableLua = dto.EnableLua == 1 || dto.EnableLua == null;
            bool localAccountFilterPolicyEnabled = dto.LocalAccountTokenFilterPolicy == 1;
            bool filterAdministratorTokenEnabled = dto.FilterAdministratorToken == 1;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GSh1CwA9YndEKDQbVyEs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OQgOOywQUUc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rUIrWGRPq+ipDGJzewqy/KsML1RpSIvYjBNj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CxKOggq570=")[iii % 8])).ToArray()), dto.EnableLua);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QhVxcMkY0HEfFTBgngSe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YjUKQOU140E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("IyrmanmanngAMOt/QbSWfgED7Gdhvo9LACnsaGw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b0WFCxXb/Rs=")[iii % 8])).ToArray()), dto.LocalAccountTokenFilterPolicy);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2NYkrASqztSF1mW8U7aA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+PZfnCiH/eQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1oBK2qi9mFP9gEjHvrurVuSGVPqipLxZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kOkmrs3P2Tc=")[iii % 8])).ToArray()), dto.FilterAdministratorToken);
            if (!enableLua)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1JN3/ghGhzGh8hT+Oh/6dZ3ANrw/Cb4//pN3/nM38EzU8jmncw2+fJ3dPq0nHrtlncUy/j8DuXCYkza9MAOvf4CTNL89TLh01MYkuzdMvH6Gkzu/JwmocJiTOrElCbd0msd5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9LNX3lNs2hE=")[iii % 8])).ToArray()));
            }

            if (enableLua && !localAccountFilterPolicyEnabled && !filterAdministratorTokenEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("DRHD2f85nI1pVIWY0X+1jXpYjZ3LZLKNXlSXjc19pt4NHMO2yn+4jVlZhtn2WoWAGAHT2ch8osxBEYKdyXqvjUxSgJbRfbWNTlCN2cZ24dheVIfZwnyzjUFQl5zWcq2NQF6VnMl2r9kD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTHj+aQTwa0=")[iii % 8])).ToArray()));
            }

            if (enableLua && localAccountFilterPolicyEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jTfCmUPki/bheIHYdI+1tcJijM1Mob2zw1GL1WyrpIbCe4vaYe7r640mzJlZoK/2zHOP0HanpaLfdpbQbqv2usJ0g9U4r7W1wmKMzTitt7iNdYeZbb2zso1xjcs4oreiyGWD1TijuaDIeofXbOA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rRfiuRjO1tY=")[iii % 8])).ToArray()));
            }

            if (enableLua && !localAccountFilterPolicyEnabled && filterAdministratorTokenEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4h39cJwJbvaOUr4xq2JQta1IsySTTFizrHu0PLNGQYatUbQzvgNAs7YdqT/nExO3rFn9Fq5PR7OwfLk9rk1apbZPvCSoUWe5qVizcPoeE+fsN/1w5wNo/J8dkT+kQl/2o16+P7JNR6XiXrw+qUxH9qBY/SW0Rlf2pFKvcKtCR7OwXLFwqkxFs69YsyTp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wj3dUMcjM9Y=")[iii % 8])).ToArray()));
            }
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string rlcWzmtM)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                        instance.GetDayOfMonth(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_A8F30596)result;
            switch (dto.ConsentPromptBehaviorAdmin)
            {
                case 0:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1VrCaYA69e+IWoN51ya7/9ha9zaMZ7SwmArNMMJw").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9Xq5WawXxt8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("DvT7oIOSCm0/9Pijkr4bVSzt/LyUvRpQJPU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TZuV0+b8fj0=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 1:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("65f4rEjBt2+2l7m8H935f+aX0+4LgfQrhNnQ+QeZ9jqP0vD3EIP0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y7eDnGTshF8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("k/BXr1YXNg2i8FSsRzsnNbHpULNBOCYwufE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0J853DN5Ql0=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 2:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("UhZxMj1UvmcPFjAiakjwd18WWnB+FP0jIlN4b3gNyTIcT0VsQhzuIgBTTmdiEvk4Ag==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cjYKAhF5jVc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("hnzYEh4tuwO3fNsRDwGqO6Rl3w4JAqs+rH0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xRO2YXtDz1M=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 3:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jqm1LLsZYRzTqfQ87AUvDIOpnm74WSJY6Oa8X+VRNl/g5rpT+Wc3T9v7q1jyRzlYwfk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ronOHJc0Uiw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("KhnUBDyIrB8bGdcHLaS9JwgA0xgrp7wiABg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aXa6d1nm2E8=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 4:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("gD28l3d1n6PdPf2HIGnRs409l9U0Ndzn5nK19z4qwfrUWaLJIhbD5+9zlMI4Ld725Hi0zC833A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oB3Hp1tYrJM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("OZQhv+HFrL8IlCK88Om9hxuNJqP26ryCE5U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("evtPzISr2O8=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                case 5:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("db7CYaudQokovoNx/IEMmXi+6SPo3QHNE/HLH+jeJtA7+tYm9PIY1zTs0DT0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VZ65UYewcbk=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SzpVPG8HlHt6OlY/fiuFQ2kjUiB4KIRGYTs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CFU7Twpp4Cs=")[iii % 8])).ToArray()), dto.ConsentPromptBehaviorAdmin);
                    break;
                default:
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("96v9Cd7rydaqq7wZorSVi6f/wFaAiJWIgOLoXZ2xiaS+5edLm6OJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("14uGOfLG+uY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("W59uhNEzsfBqn22HwB+gyHmGaZjGHKHNcZ4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GPAA97RdxaA=")[iii % 8])).ToArray()));
                    break;
            }

            bool enableLua = dto.EnableLua == 1 || dto.EnableLua == null;
            bool localAccountFilterPolicyEnabled = dto.LocalAccountTokenFilterPolicy == 1;
            bool filterAdministratorTokenEnabled = dto.FilterAdministratorToken == 1;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("GSh1CwA9YndEKDQbVyEs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OQgOOywQUUc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rUIrWGRPq+ipDGJzewqy/KsML1RpSIvYjBNj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CxKOggq570=")[iii % 8])).ToArray()), dto.EnableLua);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("QhVxcMkY0HEfFTBgngSe").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YjUKQOU140E=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("IyrmanmanngAMOt/QbSWfgED7Gdhvo9LACnsaGw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("b0WFCxXb/Rs=")[iii % 8])).ToArray()), dto.LocalAccountTokenFilterPolicy);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("2NYkrASqztSF1mW8U7aA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+PZfnCiH/eQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1oBK2qi9mFP9gEjHvrurVuSGVPqipLxZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kOkmrs3P2Tc=")[iii % 8])).ToArray()), dto.FilterAdministratorToken);
            if (!enableLua)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1JN3/ghGhzGh8hT+Oh/6dZ3ANrw/Cb4//pN3/nM38EzU8jmncw2+fJ3dPq0nHrtlncUy/j8DuXCYkza9MAOvf4CTNL89TLh01MYkuzdMvH6Gkzu/JwmocJiTOrElCbd0msd5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9LNX3lNs2hE=")[iii % 8])).ToArray()));
            }

            if (enableLua && !localAccountFilterPolicyEnabled && !filterAdministratorTokenEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("DRHD2f85nI1pVIWY0X+1jXpYjZ3LZLKNXlSXjc19pt4NHMO2yn+4jVlZhtn2WoWAGAHT2ch8osxBEYKdyXqvjUxSgJbRfbWNTlCN2cZ24dheVIfZwnyzjUFQl5zWcq2NQF6VnMl2r9kD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTHj+aQTwa0=")[iii % 8])).ToArray()));
            }

            if (enableLua && localAccountFilterPolicyEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jTfCmUPki/bheIHYdI+1tcJijM1Mob2zw1GL1WyrpIbCe4vaYe7r640mzJlZoK/2zHOP0HanpaLfdpbQbqv2usJ0g9U4r7W1wmKMzTitt7iNdYeZbb2zso1xjcs4oreiyGWD1TijuaDIeofXbOA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rRfiuRjO1tY=")[iii % 8])).ToArray()));
            }

            if (enableLua && !localAccountFilterPolicyEnabled && filterAdministratorTokenEnabled)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("4h39cJwJbvaOUr4xq2JQta1IsySTTFizrHu0PLNGQYatUbQzvgNAs7YdqT/nExO3rFn9Fq5PR7OwfLk9rk1apbZPvCSoUWe5qVizcPoeE+fsN/1w5wNo/J8dkT+kQl/2o16+P7JNR6XiXrw+qUxH9qBY/SW0Rlf2pFKvcKtCR7OwXLFwqkxFs69YsyTp").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wj3dUMcjM9Y=")[iii % 8])).ToArray()));
            }
        }
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string WxhdNHfH)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.JapaneseCalendar instance = new System.Globalization.JapaneseCalendar();
                    instance.GetDayOfMonth(new System.DateTime());
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var consentPromptBehaviorAdmin = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("262QMZ7lsO7Ur78Gu8uRxO6WijKgyobE/5GKJrzWkM7mloAAu9eLxOa+hgqlzYHC7ZGKNrDXls7l").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iOLWZcmk4qs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("qDXV08h8Pp+ZNdbQ2VAvp4os0s/fUy6igjQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("61q7oK0SSs8=")[iii % 8])).ToArray()));
        var enableLua = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("N+WCc/uAB6Y4561E3q4mjALemHDFrzGME9mYZNmzJ4YK3pJC3rI8jAr2lEjAqDaKAdmYdNWyIYYJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZKrEJ6zBVeM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("mOoc1aBTjoOc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3YR9t8w2wtY=")[iii % 8])).ToArray()));
        var localAccountTokenFilterPolicy = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("+PTf8fDdrC739vDG1fONBM3PxfLO8poE3MjF5tLujA7Fz8/A1e+XBMXnycrL9Z0CzsjF9t7vig7G").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("q7uZpaec/ms=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9iVtnMzZuqvVP2CJ9PeyrdQMZ5HU/auY1SZnntk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ukoO/aCY2cg=")[iii % 8])).ToArray()));
        var filterAdministratorToken = ThisRunTime.GetDwordValue(RegistryHive.LocalMachine, Encoding.UTF8.GetString(Convert.FromBase64String("YV7D3idN18ZuXOzpAmP27FRl2d0ZYuHsRWLZyQV+9+ZcZdPvAn/s7FxN1eUcZebqV2LZ2Ql/8eZf").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MhGFinAMhYM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("slehTIB26RyZV6NRlnDaGYBRv2yKb80W").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9D7NOOUEqHg=")[iii % 8])).ToArray()));
        yield return new O_A8F30596(consentPromptBehaviorAdmin, enableLua, filterAdministratorToken, localAccountTokenFilterPolicy);
    }
}}