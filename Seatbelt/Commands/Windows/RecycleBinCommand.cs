#nullable disable
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
internal class O_84323D86 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("S9vAOEfLHhJw0A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gb6jQSSne1A=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("j0MYT8HE+7jmQxVHkrb3tb9UEUeSpvu45lMYTteQ97LmXhMCxoz39qpWDlaS16L2olYEUZLJsrmoWwQCxYvgvbUXG1DdibK35kIOR8DE8bmoQxhaxsU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xjd9IrLkktY=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    public O_84323D86(Runtime runtime) : base(runtime)
    {
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("hAtgMvpIKzyUB21r300ieaVOVCLtTCdy9hprLrlIL2+iTjB7uWAvZaVk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1m4DS5kkThw=")[iii % 8])).ToArray()));
        var lastDays = 30;
        var startTime = DateTime.Now.AddDays(-lastDays);
        var shell = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("Ts1K7z0nq/NtyUbgMH2D7HM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HaUvg1EJ6oM=")[iii % 8])).ToArray()));
        var shellObj = Activator.CreateInstance(shell);
        var recycle = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("L+R6nMgfZTME").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YYUX+btvBFA=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, new object[] { 10 });
        var items = recycle.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("K6NhPwM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YtcEUnAy84o=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, recycle, null);
        var count = items.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("YcMWpU4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Iqxjyzr9NKc=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, items, null);
        var deletedCount = int.Parse(count.ToString());
        for (var i = 0; i < deletedCount; i++)
        {
            var item = items.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("T4R9CA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BvAYZbIxZhM=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, items, new object[] { i });
            var DateDeleted = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("l/ENWnkNpmCC+xZPchu3fQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0ol5PxdpwwQ=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, item, new object[] { Encoding.UTF8.GetString(Convert.FromBase64String("L6WWRl8AELkZv5xRVggQrx2ogHZfAVufGbg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fNzlMjptPus=")[iii % 8])).ToArray()) });
            var modifiedDate = DateTime.Parse(DateDeleted.ToString());
            if (modifiedDate > startTime)
            {
                var Name = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("EMRFSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XqUoLm3PZxs=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var Path = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("qtibtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+rnv3HEdVgU=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var Size = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("8ltRMw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oTIrVruKmcw=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var DeletedFrom = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("q0DdlOZr0sC+SsaB7X3D3Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7jip8YgPt6Q=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, item, new object[] { Encoding.UTF8.GetString(Convert.FromBase64String("CZEtL5qPXcQ/iyc4k4dd0j+EOy+ahjXkNYU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WuheW//ic5Y=")[iii % 8])).ToArray()) });
                yield return new O_BBAEDF59()
                {
                    Name = Name.ToString(),
                    Path = Path.ToString(),
                    Size = (int)Size,
                    DeletedFrom = DeletedFrom.ToString(),
                    DateDeleted = (DateTime)DateDeleted
                };
            }

            Marshal.ReleaseComObject(item);
            item = null;
        }

        Marshal.ReleaseComObject(recycle);
        recycle = null;
        Marshal.ReleaseComObject(shellObj);
        shellObj = null;
    }

internal class O_BBAEDF59 : O_4AED570F
{
    public string Name { get; set; }
    public string Path { get; set; }
    public int Size { get; set; }
    public string DeletedFrom { get; set; }
    public DateTime DateDeleted { get; set; }
}    public IEnumerable<O_4AED570F?> Execute(string[] args, string ZyXPCunX)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.KoreanLunisolarCalendar instance = new System.Globalization.KoreanLunisolarCalendar();
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

        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("hAtgMvpIKzyUB21r300ieaVOVCLtTCdy9hprLrlIL2+iTjB7uWAvZaVk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1m4DS5kkThw=")[iii % 8])).ToArray()));
        var lastDays = 30;
        var startTime = DateTime.Now.AddDays(-lastDays);
        var shell = Type.GetTypeFromProgID(Encoding.UTF8.GetString(Convert.FromBase64String("Ts1K7z0nq/NtyUbgMH2D7HM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HaUvg1EJ6oM=")[iii % 8])).ToArray()));
        var shellObj = Activator.CreateInstance(shell);
        var recycle = shellObj.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("L+R6nMgfZTME").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YYUX+btvBFA=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, shellObj, new object[] { 10 });
        var items = recycle.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("K6NhPwM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YtcEUnAy84o=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, recycle, null);
        var count = items.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("YcMWpU4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Iqxjyzr9NKc=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, items, null);
        var deletedCount = int.Parse(count.ToString());
        for (var i = 0; i < deletedCount; i++)
        {
            var item = items.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("T4R9CA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BvAYZbIxZhM=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, items, new object[] { i });
            var DateDeleted = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("l/ENWnkNpmCC+xZPchu3fQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0ol5PxdpwwQ=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, item, new object[] { Encoding.UTF8.GetString(Convert.FromBase64String("L6WWRl8AELkZv5xRVggQrx2ogHZfAVufGbg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fNzlMjptPus=")[iii % 8])).ToArray()) });
            var modifiedDate = DateTime.Parse(DateDeleted.ToString());
            if (modifiedDate > startTime)
            {
                var Name = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("EMRFSw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XqUoLm3PZxs=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var Path = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("qtibtA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+rnv3HEdVgU=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var Size = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("8ltRMw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oTIrVruKmcw=")[iii % 8])).ToArray()), BindingFlags.GetProperty, null, item, null);
                var DeletedFrom = item.GetType().InvokeMember(Encoding.UTF8.GetString(Convert.FromBase64String("q0DdlOZr0sC+SsaB7X3D3Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7jip8YgPt6Q=")[iii % 8])).ToArray()), BindingFlags.InvokeMethod, null, item, new object[] { Encoding.UTF8.GetString(Convert.FromBase64String("CZEtL5qPXcQ/iyc4k4dd0j+EOy+ahjXkNYU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WuheW//ic5Y=")[iii % 8])).ToArray()) });
                yield return new O_BBAEDF59()
                {
                    Name = Name.ToString(),
                    Path = Path.ToString(),
                    Size = (int)Size,
                    DeletedFrom = DeletedFrom.ToString(),
                    DateDeleted = (DateTime)DateDeleted
                };
            }

            Marshal.ReleaseComObject(item);
            item = null;
        }

        Marshal.ReleaseComObject(recycle);
        recycle = null;
        Marshal.ReleaseComObject(shellObj);
        shellObj = null;
    }
}}
#nullable enable
