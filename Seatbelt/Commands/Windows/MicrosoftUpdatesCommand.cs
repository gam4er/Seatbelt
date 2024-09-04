using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_3FB96BCD : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("I1YP14+unCoaahzBgamWPw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bj9speDd80w=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("wtXLChRAWSrsyshMLQlPKOfY008qCRIu6tiHaRZkEw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g7mnKlkpOlg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_3FB96BCD(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("JZBvtfMgOiMJkH34vDM3O0reV7H1IDQkD5hu+OMiPzYUm2nVnA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YP4a2JZSW1c=")[iii % 8])).ToArray()));
        var searcher = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("WYcIRvHX0pdgwD5E+sXJlDq9DlXsx9WUZg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FO5rNJ6kvfE=")[iii % 8])).ToArray()));
        var searcherObj = Activator.CreateInstance(searcher);
        var count = (int)searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("IoafDohCIXYtipguiEQ5WQqWhS4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZePrWuc2QBo=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, searcherObj, new object[] { });
        var results = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("dtdRRQcMe6VTzUZO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J6I0N35EEtY=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, searcherObj, new object[] { 0, count });
        for (int i = 0; i < count; ++i)
        {
            var item = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("jF5vsA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xSoK3Z+rJpQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, results, new object[] { i });
            var title = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("9gp7HJA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("omMPcPULiOk=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { }).ToString();
            var date = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("RtZmCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ArcSbJSBE3E=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            var description = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("Y68Uw5fcKAxOpQk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J8pnoOW1WHg=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            var clientApplicationID = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("3M6S1/0PXW7vzpLR8g91cfHrvw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n6L7spN7HB4=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            string hotfixId = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/sKfOVRngl4=")[iii % 8])).ToArray());
            Regex reg = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("eE+hf1Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mw39G33BuQ4=")[iii % 8])).ToArray()));
            var matches = reg.Matches(title);
            if (matches.Count > 0)
            {
                hotfixId = matches[0].ToString();
            }

            yield return new O_2C0A69AB(hotfixId, Convert.ToDateTime(date.ToString()).ToUniversalTime(), title, clientApplicationID.ToString(), description.ToString());
            Marshal.ReleaseComObject(item);
        }

        Marshal.ReleaseComObject(results);
        Marshal.ReleaseComObject(searcherObj);
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string AkzcQWPu)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Security.SecureString instance = new System.Security.SecureString();
                    instance.AppendChar('a');
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("JZBvtfMgOiMJkH34vDM3O0reV7H1IDQkD5hu+OMiPzYUm2nVnA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YP4a2JZSW1c=")[iii % 8])).ToArray()));
        var searcher = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("WYcIRvHX0pdgwD5E+sXJlDq9DlXsx9WUZg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FO5rNJ6kvfE=")[iii % 8])).ToArray()));
        var searcherObj = Activator.CreateInstance(searcher);
        var count = (int)searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("IoafDohCIXYtipguiEQ5WQqWhS4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZePrWuc2QBo=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, searcherObj, new object[] { });
        var results = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("dtdRRQcMe6VTzUZO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J6I0N35EEtY=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, searcherObj, new object[] { 0, count });
        for (int i = 0; i < count; ++i)
        {
            var item = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("jF5vsA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xSoK3Z+rJpQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, results, new object[] { i });
            var title = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("9gp7HJA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("omMPcPULiOk=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { }).ToString();
            var date = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("RtZmCQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ArcSbJSBE3E=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            var description = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("Y68Uw5fcKAxOpQk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("J8pnoOW1WHg=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            var clientApplicationID = searcherObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("3M6S1/0PXW7vzpLR8g91cfHrvw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n6L7spN7HB4=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, new object[] { });
            string hotfixId = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/sKfOVRngl4=")[iii % 8])).ToArray());
            Regex reg = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("eE+hf1Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Mw39G33BuQ4=")[iii % 8])).ToArray()));
            var matches = reg.Matches(title);
            if (matches.Count > 0)
            {
                hotfixId = matches[0].ToString();
            }

            yield return new O_2C0A69AB(hotfixId, Convert.ToDateTime(date.ToString()).ToUniversalTime(), title, clientApplicationID.ToString(), description.ToString());
            Marshal.ReleaseComObject(item);
        }

        Marshal.ReleaseComObject(results);
        Marshal.ReleaseComObject(searcherObj);
    }
}internal class O_2C0A69AB : O_4AED570F
{
    public O_2C0A69AB(string hotFixID, DateTime? installedOnUTC, string title, string dlientApplicationID, string description)
    {
        HotFixID = hotFixID;
        InstalledOnUTC = installedOnUTC;
        Title = title;
        ClientApplicationID = dlientApplicationID;
        Description = description;
    }

    public string HotFixID { get; set; }
    public DateTime? InstalledOnUTC { get; set; }
    public string Title { get; set; }
    public string ClientApplicationID { get; set; }
    public string Description { get; set; }
}
    [CommandOutputType(typeof(O_2C0A69AB))]
    internal class O_0DE9EA5F : TextFormatterBase
    {
        public O_0DE9EA5F(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_2C0A69AB)result;
            WriteLine($"  {dto.HotFixID, -10} {dto.InstalledOnUTC?.ToLocalTime(), -23} {dto.ClientApplicationID, -20} {dto.Title}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string cwwITomx)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.SecureString instance = new System.Security.SecureString();
                        instance.AppendChar('a');
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_2C0A69AB)result;
            WriteLine($"  {dto.HotFixID, -10} {dto.InstalledOnUTC?.ToLocalTime(), -23} {dto.ClientApplicationID, -20} {dto.Title}");
        }
    }
}