using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Browser
{
internal class O_34FA5C50 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("JOuR56mb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ba7FhsvoG8g=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("SrdjI84TW5xgtWgomnpwkHWraT+LKBWcZKV1").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BccGTe5aNeg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.User
    };
    public override bool SupportRemote => false;

    public O_34FA5C50(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        var shell = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("y9AgxO6gEifo1CzL4/o6OPY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mLhFqIKOU1c=")[iii % 8])).ToArray()));
        var shellObj = Activator.CreateInstance(shell);
        var windows = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("37DCswWDmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iNms12r06vA=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, null);
        var openTabs = windows.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("S95Vo78=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CLEgzcur/OQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, windows, null);
        var openTabsCount = int.Parse(openTabs.ToString());
        for (var i = 0; i < openTabsCount; i++)
        {
            object? item = windows.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("0oc6rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m/NfwTIJSvk=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, windows, new object[] { i });
            string locationName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pGOyFm12hVA=")[iii % 8])).ToArray()), locationUrl = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+J4zjPFwAvg=")[iii % 8])).ToArray());
            try
            {
                locationName = (string)item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("2eUjBFDCS7fb6y0A").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lYpAZSSrJNk=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                locationUrl = (string)item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("IBFX4NKO2So5DFg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bH40gabntkQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                Marshal.ReleaseComObject(item);
                item = null;
            }
            catch
            {
            }

            if (Regex.IsMatch(locationUrl, Encoding.UTF8.GetString(Convert.FromBase64String("KT2evZj/YHs7TNnnx6ZvbF8FgrnWoDxt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AWP2yeyPE0Q=")[iii % 8])).ToArray())))
            {
                yield return new O_71FF6B09(locationName, locationUrl);
            }
        }

        Marshal.ReleaseComObject(windows);
        Marshal.ReleaseComObject(shellObj);
    }

internal class O_71FF6B09 : O_4AED570F
{
    public O_71FF6B09(string locationName, string locationUrl)
    {
        LocationName = locationName;
        LocationUrl = locationUrl;
    }

    public string LocationName { get; }
    public string LocationUrl { get; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string xynpFsef)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Text.UTF32Encoding instance = new System.Text.UTF32Encoding();
                    instance.GetMaxByteCount(95);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        var shell = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("y9AgxO6gEifo1CzL4/o6OPY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mLhFqIKOU1c=")[iii % 8])).ToArray()));
        var shellObj = Activator.CreateInstance(shell);
        var windows = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("37DCswWDmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iNms12r06vA=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, null);
        var openTabs = windows.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("S95Vo78=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CLEgzcur/OQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, windows, null);
        var openTabsCount = int.Parse(openTabs.ToString());
        for (var i = 0; i < openTabsCount; i++)
        {
            object? item = windows.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("0oc6rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m/NfwTIJSvk=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, windows, new object[] { i });
            string locationName = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pGOyFm12hVA=")[iii % 8])).ToArray()), locationUrl = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+J4zjPFwAvg=")[iii % 8])).ToArray());
            try
            {
                locationName = (string)item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("2eUjBFDCS7fb6y0A").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lYpAZSSrJNk=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                locationUrl = (string)item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("IBFX4NKO2So5DFg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bH40gabntkQ=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                Marshal.ReleaseComObject(item);
                item = null;
            }
            catch
            {
            }

            if (Regex.IsMatch(locationUrl, Encoding.UTF8.GetString(Convert.FromBase64String("KT2evZj/YHs7TNnnx6ZvbF8FgrnWoDxt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AWP2yeyPE0Q=")[iii % 8])).ToArray())))
            {
                yield return new O_71FF6B09(locationName, locationUrl);
            }
        }

        Marshal.ReleaseComObject(windows);
        Marshal.ReleaseComObject(shellObj);
    }
}}