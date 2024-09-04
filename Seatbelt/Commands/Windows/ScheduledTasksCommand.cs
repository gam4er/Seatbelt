#nullable disable
using System;
using System.Collections.Generic;
using System.Management;
using System.Text.RegularExpressions;
using static O_F41F88FA.Interop.Secur32;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands.Windows
{
    enum StateEnum
    {
        Unknown = 0,
        Disabled = 1,
        Queued = 2,
        Ready = 3,
        Running = 4
    };
    enum RunlevelEnum
    {
        TASK_RUNLEVEL_LUA = 0,
        TASK_RUNLEVEL_HIGHEST = 1
    }

    class O_A664A7BA
    {
        public string DisplayName { get; set; }
        public string GroupId { get; set; }
        public string Id { get; set; }
        public string LogonType { get; set; }
        public string RunLevel { get; set; }
        public string UserId { get; set; }
    }

    class O_B4B33E7C
    {
        public object Type { get; set; }
        public object Enabled { get; set; }
        public object EndBoundary { get; set; }
        public object ExecutionTimeLimit { get; set; }
        public object StartBoundary { get; set; }
        public object Duration { get; set; }
        public object Interval { get; set; }
        public object StopAtDurationEnd { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }

    class O_C2B9DBD9
    {
        public object Type { get; set; }
        public object Id { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }

    internal class O_2EAD8157 : O_2183A68D
    {
        public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("LKtnvhoRZW8bnG6oFRc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f8gP235kCQo=")[iii % 8])).ToArray());
        public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("kYtRHFnJK5qmyE0YTtc03+qeUBgd6wq268hNEVzIZ56wjVdeSZwmiraAVgtY2Gedu8geNFTfNZCxh18NGpBn3e+OTBVRnmebt4VJCh3dK5Piu1oRWNgyk6eMGQ1czyyM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wug5eT28R/8=")[iii % 8])).ToArray());
        public override CommandGroup[] Group => new[]
        {
            CommandGroup.Misc
        };
        public override bool SupportRemote => true;

        public Runtime ThisRunTime;
        public O_2EAD8157(Runtime runtime) : base(runtime)
        {
            ThisRunTime = runtime;
        }

        public override IEnumerable<O_4AED570F?> Execute(string[] args)
        {
            WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("RGwLO0VaxudlcAp9fBPW9mJmAW5kVsG1fmIWcHsTjeNjYkVMRXqMnw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CgNlGwgzpZU=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("kU+7GjUTkhy0VrtfIlCOGKNIpBpuBpMY8HSac296").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0CPXOkZw+nk=")[iii % 8])).ToArray()));
            ManagementObjectCollection data = null;
            try
            {
                var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("F0QjAF4F1g03RD8bZDzjOSxFKBt1O+M6JFgnJ2Eg2gowRykG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RStMdAJIv24=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VnHQ6486uyMlcs7hgU7WWkNgw/2vBv5tcFj5ypgP6GI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTScrsxumwk=")[iii % 8])).ToArray()));
                data = wmiData.Get();
            }
            catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
            {
                WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("NH/0raVDfp5HGfuqqwAxtnAqw5CcNzigf3iPorUqebB4PtyG2BY3smI+xpmZATW2NHfCnJYKNKZ5f9yAiBM2oWA6y9WOBiugfTDBhtgMP/NDNsGRlxQq6TRngMfIUmv6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FF+v9fhjWdM=")[iii % 8])).ToArray()), ex.Message));
            }
            catch (Exception ex)
            {
                WriteError(ex.ToString());
            }

            if (data == null)
            {
                yield break;
            }

            foreach (var o in data)
            {
                var result = (ManagementObject)o;
                if (Runtime.FilterResults)
                {
                    if (Regex.IsMatch($"{result[Encoding.UTF8.GetString(Convert.FromBase64String("2HomBFqE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQ9SbDX2/TE=")[iii % 8])).ToArray())]}", Encoding.UTF8.GetString(Convert.FromBase64String("K1t9sdHyXOYS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZjIew76BM4A=")[iii % 8])).ToArray())))
                    {
                        continue;
                    }
                }

                var tempPrincipal = (ManagementBaseObject)result[Encoding.UTF8.GetString(Convert.FromBase64String("/bRMBIzIzajB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rcYlau+hvck=")[iii % 8])).ToArray())];
                var settings = (ManagementBaseObject)result[Encoding.UTF8.GetString(Convert.FromBase64String("yho9HRJa73Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mX9JaXs0iAU=")[iii % 8])).ToArray())];
                var actions = (ManagementBaseObject[])result[Encoding.UTF8.GetString(Convert.FromBase64String("U5u5LGSsWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EvjNRQvCKgo=")[iii % 8])).ToArray())];
                var triggers = (ManagementBaseObject[])result[Encoding.UTF8.GetString(Convert.FromBase64String("C42jotbDihY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X//KxbGm+GU=")[iii % 8])).ToArray())];
                var Principal = new O_A664A7BA();
                Principal.DisplayName = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("dx2K7LWEv+9SGZw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M3T5nNnlxqE=")[iii % 8])).ToArray())]}";
                Principal.Id = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("bBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JX9oJHbHwvo=")[iii % 8])).ToArray())]}";
                Principal.GroupId = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("iZZcuicEQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zuQzz1dNJFo=")[iii % 8])).ToArray())]}";
                var tempLogonType = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("+3BiIX2gTY/S").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tx8FThP0NP8=")[iii % 8])).ToArray())]}";
                Principal.LogonType = $"{(SECURITY_LOGON_TYPE)Int32.Parse(tempLogonType)}";
                var tempRunLevel = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("+LMOeH5Se1Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qsZgNBskHjg=")[iii % 8])).ToArray())]}";
                Principal.RunLevel = $"{(RunlevelEnum)Int32.Parse(tempRunLevel)}";
                Principal.UserId = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("WOrxd/eW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZmUBb7yPg4=")[iii % 8])).ToArray())]}";
                var Actions = new List<O_C2B9DBD9>();
                foreach (var obj in actions)
                {
                    var action = new O_C2B9DBD9();
                    action.Type = $"{obj.SystemProperties[Encoding.UTF8.GetString(Convert.FromBase64String("NFFAV+6Y+5cnT0BR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aw4TAr7dqdQ=")[iii % 8])).ToArray())].Value}";
                    var Properties = new Dictionary<string, object>();
                    foreach (var prop in obj.Properties)
                    {
                        if (!prop.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("1VpeqOp+IVbge1Om6ms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hQkdx4cOVCI=")[iii % 8])).ToArray())))
                        {
                            Properties[prop.Name] = prop.Value;
                        }
                    }

                    action.Properties = Properties;
                    Actions.Add(action);
                }

                var TriggerObjects = new List<O_B4B33E7C>();
                if (triggers != null)
                {
                    foreach (var obj in triggers)
                    {
                        var trigger = new O_B4B33E7C();
                        trigger.Type = $"{obj.SystemProperties[Encoding.UTF8.GetString(Convert.FromBase64String("6LvSF2KKMQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+SRWyPZYt4=")[iii % 8])).ToArray())].Value}";
                        trigger.Enabled = obj[Encoding.UTF8.GetString(Convert.FromBase64String("Ijkv6OsqVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z1dOiodPMzg=")[iii % 8])).ToArray())];
                        trigger.EndBoundary = obj[Encoding.UTF8.GetString(Convert.FromBase64String("NKYMhyZtKroQuhE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cchoxUkYRN4=")[iii % 8])).ToArray())];
                        trigger.ExecutionTimeLimit = obj[Encoding.UTF8.GetString(Convert.FromBase64String("ifav1wJCJlCi2qPZEnomUqX6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zI7KtHc2Tz8=")[iii % 8])).ToArray())];
                        trigger.StartBoundary = obj[Encoding.UTF8.GetString(Convert.FromBase64String("hi452qdGhAS7Pjnaqg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1VpYqNME63E=")[iii % 8])).ToArray())];
                        var repetitionobj = (ManagementBaseObject)obj[Encoding.UTF8.GetString(Convert.FromBase64String("TYwPr0CkqHVQhw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P+l/yjTN3Bw=")[iii % 8])).ToArray())];
                        trigger.Duration = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("P0DUEzs2nzI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ezWmck9f8Fw=")[iii % 8])).ToArray())];
                        trigger.Interval = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("AsTB8bsjrQE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S6q1lMlVzG0=")[iii % 8])).ToArray())];
                        trigger.StopAtDurationEnd = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("+y65tv3Ff1baO6Kv099+Tcw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qFrWxryxOyM=")[iii % 8])).ToArray())];
                        var properties = new Dictionary<string, string>();
                        foreach (var prop in obj.Properties)
                        {
                            if (!Regex.IsMatch($"{prop.Name}", Encoding.UTF8.GetString(Convert.FromBase64String("ztHhyKmlCZni0eHIqaApmvLb+ey1vRew/9D++LOtBJvT3PDoi60GnPPJzvmmth+36MDz6aa2EonV0O3os60fnOjb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h7WdjcfEa/U=")[iii % 8])).ToArray())))
                            {
                                properties.Add(prop.Name, $"{prop.Value}");
                            }
                        }

                        trigger.Properties = properties;
                        TriggerObjects.Add(trigger);
                    }
                }

                yield return new O_572A3E52()
                {
                    Name = result[Encoding.UTF8.GetString(Convert.FromBase64String("xGPulZZMOkA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kAKd/tgtVyU=")[iii % 8])).ToArray())],
                    Principal = Principal,
                    Author = result[Encoding.UTF8.GetString(Convert.FromBase64String("XB52buLA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HWsCBo2y0Ug=")[iii % 8])).ToArray())],
                    Description = result[Encoding.UTF8.GetString(Convert.FromBase64String("dqDpdDObYplbqvQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MsWaF0HyEu0=")[iii % 8])).ToArray())],
                    Source = result[Encoding.UTF8.GetString(Convert.FromBase64String("4x5LofUC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sHE+05ZnkVk=")[iii % 8])).ToArray())],
                    State = (StateEnum)result[Encoding.UTF8.GetString(Convert.FromBase64String("8eMvcLQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("opdOBNFDQSs=")[iii % 8])).ToArray())],
                    SDDL = result[Encoding.UTF8.GetString(Convert.FromBase64String("XvcpM6yHGI9J9zklrIccgmLg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZJKRt7ubPY=")[iii % 8])).ToArray())],
                    Actions = Actions,
                    Triggers = TriggerObjects,
                    Enabled = settings[Encoding.UTF8.GetString(Convert.FromBase64String("ncJ7RpQzBA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2KwaJPhWYGA=")[iii % 8])).ToArray())],
                    TaskPath = result[Encoding.UTF8.GetString(Convert.FromBase64String("Uu9OOIZR9x4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bo49U9Ywg3Y=")[iii % 8])).ToArray())],
                    Hidden = settings[Encoding.UTF8.GetString(Convert.FromBase64String("stLMdSvi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+ruoEU6MvjI=")[iii % 8])).ToArray())],
                    Date = result[Encoding.UTF8.GetString(Convert.FromBase64String("wUm1XQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hSjBOK7n54E=")[iii % 8])).ToArray())],
                    AllowDemandStart = settings[Encoding.UTF8.GetString(Convert.FromBase64String("m4nx7h0VzAO7i/nSHjDbGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2uWdgWpRqW4=")[iii % 8])).ToArray())],
                    AllowHardTerminate = settings[Encoding.UTF8.GetString(Convert.FromBase64String("k6IykLTnTrm2mjuNrsZBqqar").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0s5e/8OvL8s=")[iii % 8])).ToArray())],
                    DisallowStartIfOnBatteries = settings[Encoding.UTF8.GetString(Convert.FromBase64String("ax/V+MWbyEJ8Asfr3b7BekE0x+3dktVcSgU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L3amman3pzU=")[iii % 8])).ToArray())],
                    ExecutionTimeLimit = settings[Encoding.UTF8.GetString(Convert.FromBase64String("GY0LkeeZJvQyoQef96Em9jWB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XPVu8pLtT5s=")[iii % 8])).ToArray())],
                    StopIfGoingOnBatteries = settings[Encoding.UTF8.GetString(Convert.FromBase64String("anozsXFDDe9QYDuOVmcr9E1rLqhdVg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OQ5cwTglSoA=")[iii % 8])).ToArray())]
                };
            }

            data.Dispose();
        }

        public IEnumerable<O_4AED570F?> Execute(string[] args, string jMXReIUX)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.AddMonths(new System.DateTime(), 68);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            WriteHost(Runtime.FilterResults ? Encoding.UTF8.GetString(Convert.FromBase64String("RGwLO0VaxudlcAp9fBPW9mJmAW5kVsG1fmIWcHsTjeNjYkVMRXqMnw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CgNlGwgzpZU=")[iii % 8])).ToArray()) : Encoding.UTF8.GetString(Convert.FromBase64String("kU+7GjUTkhy0VrtfIlCOGKNIpBpuBpMY8HSac296").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0CPXOkZw+nk=")[iii % 8])).ToArray()));
            ManagementObjectCollection data = null;
            try
            {
                var wmiData = ThisRunTime.GetManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String("F0QjAF4F1g03RD8bZDzjOSxFKBt1O+M6JFgnJ2Eg2gowRykG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RStMdAJIv24=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("VnHQ6486uyMlcs7hgU7WWkNgw/2vBv5tcFj5ypgP6GI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTScrsxumwk=")[iii % 8])).ToArray()));
                data = wmiData.Get();
            }
            catch (ManagementException ex)when (ex.ErrorCode == ManagementStatus.InvalidNamespace)
            {
                WriteError(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("NH/0raVDfp5HGfuqqwAxtnAqw5CcNzigf3iPorUqebB4PtyG2BY3smI+xpmZATW2NHfCnJYKNKZ5f9yAiBM2oWA6y9WOBiugfTDBhtgMP/NDNsGRlxQq6TRngMfIUmv6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FF+v9fhjWdM=")[iii % 8])).ToArray()), ex.Message));
            }
            catch (Exception ex)
            {
                WriteError(ex.ToString());
            }

            if (data == null)
            {
                yield break;
            }

            foreach (var o in data)
            {
                var result = (ManagementObject)o;
                if (Runtime.FilterResults)
                {
                    if (Regex.IsMatch($"{result[Encoding.UTF8.GetString(Convert.FromBase64String("2HomBFqE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQ9SbDX2/TE=")[iii % 8])).ToArray())]}", Encoding.UTF8.GetString(Convert.FromBase64String("K1t9sdHyXOYS").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZjIew76BM4A=")[iii % 8])).ToArray())))
                    {
                        continue;
                    }
                }

                var tempPrincipal = (ManagementBaseObject)result[Encoding.UTF8.GetString(Convert.FromBase64String("/bRMBIzIzajB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rcYlau+hvck=")[iii % 8])).ToArray())];
                var settings = (ManagementBaseObject)result[Encoding.UTF8.GetString(Convert.FromBase64String("yho9HRJa73Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mX9JaXs0iAU=")[iii % 8])).ToArray())];
                var actions = (ManagementBaseObject[])result[Encoding.UTF8.GetString(Convert.FromBase64String("U5u5LGSsWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EvjNRQvCKgo=")[iii % 8])).ToArray())];
                var triggers = (ManagementBaseObject[])result[Encoding.UTF8.GetString(Convert.FromBase64String("C42jotbDihY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("X//KxbGm+GU=")[iii % 8])).ToArray())];
                var Principal = new O_A664A7BA();
                Principal.DisplayName = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("dx2K7LWEv+9SGZw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M3T5nNnlxqE=")[iii % 8])).ToArray())]}";
                Principal.Id = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("bBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JX9oJHbHwvo=")[iii % 8])).ToArray())]}";
                Principal.GroupId = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("iZZcuicEQA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zuQzz1dNJFo=")[iii % 8])).ToArray())]}";
                var tempLogonType = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("+3BiIX2gTY/S").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tx8FThP0NP8=")[iii % 8])).ToArray())]}";
                Principal.LogonType = $"{(SECURITY_LOGON_TYPE)Int32.Parse(tempLogonType)}";
                var tempRunLevel = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("+LMOeH5Se1Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qsZgNBskHjg=")[iii % 8])).ToArray())]}";
                Principal.RunLevel = $"{(RunlevelEnum)Int32.Parse(tempRunLevel)}";
                Principal.UserId = $"{tempPrincipal[Encoding.UTF8.GetString(Convert.FromBase64String("WOrxd/eW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZmUBb7yPg4=")[iii % 8])).ToArray())]}";
                var Actions = new List<O_C2B9DBD9>();
                foreach (var obj in actions)
                {
                    var action = new O_C2B9DBD9();
                    action.Type = $"{obj.SystemProperties[Encoding.UTF8.GetString(Convert.FromBase64String("NFFAV+6Y+5cnT0BR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aw4TAr7dqdQ=")[iii % 8])).ToArray())].Value}";
                    var Properties = new Dictionary<string, object>();
                    foreach (var prop in obj.Properties)
                    {
                        if (!prop.Name.Equals(Encoding.UTF8.GetString(Convert.FromBase64String("1VpeqOp+IVbge1Om6ms=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hQkdx4cOVCI=")[iii % 8])).ToArray())))
                        {
                            Properties[prop.Name] = prop.Value;
                        }
                    }

                    action.Properties = Properties;
                    Actions.Add(action);
                }

                var TriggerObjects = new List<O_B4B33E7C>();
                if (triggers != null)
                {
                    foreach (var obj in triggers)
                    {
                        var trigger = new O_B4B33E7C();
                        trigger.Type = $"{obj.SystemProperties[Encoding.UTF8.GetString(Convert.FromBase64String("6LvSF2KKMQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("t+SRWyPZYt4=")[iii % 8])).ToArray())].Value}";
                        trigger.Enabled = obj[Encoding.UTF8.GetString(Convert.FromBase64String("Ijkv6OsqVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z1dOiodPMzg=")[iii % 8])).ToArray())];
                        trigger.EndBoundary = obj[Encoding.UTF8.GetString(Convert.FromBase64String("NKYMhyZtKroQuhE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cchoxUkYRN4=")[iii % 8])).ToArray())];
                        trigger.ExecutionTimeLimit = obj[Encoding.UTF8.GetString(Convert.FromBase64String("ifav1wJCJlCi2qPZEnomUqX6").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zI7KtHc2Tz8=")[iii % 8])).ToArray())];
                        trigger.StartBoundary = obj[Encoding.UTF8.GetString(Convert.FromBase64String("hi452qdGhAS7Pjnaqg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1VpYqNME63E=")[iii % 8])).ToArray())];
                        var repetitionobj = (ManagementBaseObject)obj[Encoding.UTF8.GetString(Convert.FromBase64String("TYwPr0CkqHVQhw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P+l/yjTN3Bw=")[iii % 8])).ToArray())];
                        trigger.Duration = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("P0DUEzs2nzI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ezWmck9f8Fw=")[iii % 8])).ToArray())];
                        trigger.Interval = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("AsTB8bsjrQE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S6q1lMlVzG0=")[iii % 8])).ToArray())];
                        trigger.StopAtDurationEnd = repetitionobj[Encoding.UTF8.GetString(Convert.FromBase64String("+y65tv3Ff1baO6Kv099+Tcw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qFrWxryxOyM=")[iii % 8])).ToArray())];
                        var properties = new Dictionary<string, string>();
                        foreach (var prop in obj.Properties)
                        {
                            if (!Regex.IsMatch($"{prop.Name}", Encoding.UTF8.GetString(Convert.FromBase64String("ztHhyKmlCZni0eHIqaApmvLb+ey1vRew/9D++LOtBJvT3PDoi60GnPPJzvmmth+36MDz6aa2EonV0O3os60fnOjb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h7WdjcfEa/U=")[iii % 8])).ToArray())))
                            {
                                properties.Add(prop.Name, $"{prop.Value}");
                            }
                        }

                        trigger.Properties = properties;
                        TriggerObjects.Add(trigger);
                    }
                }

                yield return new O_572A3E52()
                {
                    Name = result[Encoding.UTF8.GetString(Convert.FromBase64String("xGPulZZMOkA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kAKd/tgtVyU=")[iii % 8])).ToArray())],
                    Principal = Principal,
                    Author = result[Encoding.UTF8.GetString(Convert.FromBase64String("XB52buLA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HWsCBo2y0Ug=")[iii % 8])).ToArray())],
                    Description = result[Encoding.UTF8.GetString(Convert.FromBase64String("dqDpdDObYplbqvQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MsWaF0HyEu0=")[iii % 8])).ToArray())],
                    Source = result[Encoding.UTF8.GetString(Convert.FromBase64String("4x5LofUC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sHE+05ZnkVk=")[iii % 8])).ToArray())],
                    State = (StateEnum)result[Encoding.UTF8.GetString(Convert.FromBase64String("8eMvcLQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("opdOBNFDQSs=")[iii % 8])).ToArray())],
                    SDDL = result[Encoding.UTF8.GetString(Convert.FromBase64String("XvcpM6yHGI9J9zklrIccgmLg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DZJKRt7ubPY=")[iii % 8])).ToArray())],
                    Actions = Actions,
                    Triggers = TriggerObjects,
                    Enabled = settings[Encoding.UTF8.GetString(Convert.FromBase64String("ncJ7RpQzBA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2KwaJPhWYGA=")[iii % 8])).ToArray())],
                    TaskPath = result[Encoding.UTF8.GetString(Convert.FromBase64String("Uu9OOIZR9x4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bo49U9Ywg3Y=")[iii % 8])).ToArray())],
                    Hidden = settings[Encoding.UTF8.GetString(Convert.FromBase64String("stLMdSvi").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+ruoEU6MvjI=")[iii % 8])).ToArray())],
                    Date = result[Encoding.UTF8.GetString(Convert.FromBase64String("wUm1XQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hSjBOK7n54E=")[iii % 8])).ToArray())],
                    AllowDemandStart = settings[Encoding.UTF8.GetString(Convert.FromBase64String("m4nx7h0VzAO7i/nSHjDbGg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2uWdgWpRqW4=")[iii % 8])).ToArray())],
                    AllowHardTerminate = settings[Encoding.UTF8.GetString(Convert.FromBase64String("k6IykLTnTrm2mjuNrsZBqqar").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0s5e/8OvL8s=")[iii % 8])).ToArray())],
                    DisallowStartIfOnBatteries = settings[Encoding.UTF8.GetString(Convert.FromBase64String("ax/V+MWbyEJ8Asfr3b7BekE0x+3dktVcSgU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("L3amman3pzU=")[iii % 8])).ToArray())],
                    ExecutionTimeLimit = settings[Encoding.UTF8.GetString(Convert.FromBase64String("GY0LkeeZJvQyoQef96Em9jWB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XPVu8pLtT5s=")[iii % 8])).ToArray())],
                    StopIfGoingOnBatteries = settings[Encoding.UTF8.GetString(Convert.FromBase64String("anozsXFDDe9QYDuOVmcr9E1rLqhdVg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OQ5cwTglSoA=")[iii % 8])).ToArray())]
                };
            }

            data.Dispose();
        }
    }

    internal class O_572A3E52 : O_4AED570F
    {
        public object Name { get; set; }
        public O_A664A7BA Principal { get; set; }
        public object Author { get; set; }
        public object Description { get; set; }
        public object Source { get; set; }
        public object State { get; set; }
        public object SDDL { get; set; }
        public List<O_C2B9DBD9> Actions { get; set; }
        public List<O_B4B33E7C> Triggers { get; set; }
        public object Enabled { get; set; }
        public object TaskPath { get; set; }
        public object Hidden { get; set; }
        public object Date { get; set; }
        public object AllowDemandStart { get; set; }
        public object AllowHardTerminate { get; set; }
        public object DisallowStartIfOnBatteries { get; set; }
        public object ExecutionTimeLimit { get; set; }
        public object StopIfGoingOnBatteries { get; set; }
    }

    [CommandOutputType(typeof(O_572A3E52))]
    internal class O_F61582AC : TextFormatterBase
    {
        public O_F61582AC(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_572A3E52)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Ew6cg7u92yNTGFiAvnkfNAXcD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8GxBQiLDxFw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("E282yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XQ5brvwSijA=")[iii % 8])).ToArray()), dto.Name);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("v+lHqCdtbvni6Ry4K3o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8k8mAtAXck=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("uSJSqLsLboSF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6VA7xthiHuU=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1Wrs6RHJ6RvZZ//5TNOyC9Ux/bQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9UrMyTHpkis=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("muYNUP5AmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3ZRiJY4J/fY=")[iii % 8])).ToArray()), dto.Principal.GroupId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8RdIah0qZbH9Glt6QDA+ofFMWTc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0TdoSj0KHoE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("0sE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m6Uaf6meCy4=")[iii % 8])).ToArray()), dto.Principal.Id);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ICE/7Np1RUssLCz8h28eWyB6LrE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AAEfzPpVPns=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("J1/WqG542X4O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("azCxxwAsoA4=")[iii % 8])).ToArray()), dto.Principal.LogonType);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YVMOnv3XY7JtXh2OoM04omEIH8M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QXMuvt33GII=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sC6fvTCXwm4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4lvx8VXhpwI=")[iii % 8])).ToArray()), dto.Principal.RunLevel);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("U+nE4oIHkGxf5Nfy3x3LfFOy1b8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c8nkwqIn61w=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Mq66fTvs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z93fD3KIwT8=")[iii % 8])).ToArray()), dto.Principal.UserId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("N/iF/Zcflp1q+N7tmwiFjTejz7A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F9j+zbsypa0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ymdaqEjI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ixIuwCe6bOk=")[iii % 8])).ToArray()), dto.Author);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("J5v5b/MqD3x6m6J//z0cbCfAsyI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B7uCX98HPEw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rt4TXEQfSa2D1A4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6rtgPzZ2Odk=")[iii % 8])).ToArray()), dto.Description);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IqAmZ7ibq1h/oH13tIy4SCL7bCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AoBdV5S2mGg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YH/jwfFO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MxCWs5IrMa0=")[iii % 8])).ToArray()), dto.Source);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("bOf5Sa6OgZsx56JZopmSi2y8swQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TMeCeYKjsqs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("WqyGJsg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CdjnUq2wxxA=")[iii % 8])).ToArray()), dto.State);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ua0htBPFlZHkrXqkH9KGgbn2a/k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mY1ahD/opqE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("aeZzTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OqI3Aprm8Bg=")[iii % 8])).ToArray()), dto.SDDL);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Sx/nJ6+rg7oWH7w3o7yQqktErWo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("az+cF4OGsIo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("173PpxLuOA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ktOuxX6LXE4=")[iii % 8])).ToArray()), dto.Enabled);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Jn0QFJI0Xuh7fUsEniNN+CYmWlk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bl1rJL4Zbdg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yiAa5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jkFughUqWFo=")[iii % 8])).ToArray()), (DateTime)Convert.ToDateTime(dto.Date));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("//ue9p4112Ci+8XmkiLEcP+g1Ls=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("39vlxrIY5FA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MKTh2a0PNFgQpunlriojQQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cciNttpLUTU=")[iii % 8])).ToArray()), dto.AllowDemandStart);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("otWcqI1uklf/1ce4gXmBR6KO1uU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gvXnmKFDoWc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bgpw8TIvqVp5F2LiKgqgYkQhYuQqJrRETxA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KmMDkF5Dxi0=")[iii % 8])).ToArray()), dto.DisallowStartIfOnBatteries);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MY9SvBrQtwJsjwmsFsekEjHUGPE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ea8pjDb9hDI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("eFgcP87b/j5TdBAx3uP+PFRU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PSB5XLuvl1E=")[iii % 8])).ToArray()), dto.ExecutionTimeLimit);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("/htQEi+MdFejGwsCI5tnR/5AGl8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3jsrIgOhR2c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SbsNmBjD3RBzoQWnP+f7C26qEIE01g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gs9i6FGlmn8=")[iii % 8])).ToArray()), dto.StopIfGoingOnBatteries);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YH7OFJS6siY9fpUEmK0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QF61JLiXgRY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1Kh2FBj5Xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lcsCfXeXLSc=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JT86KsCaIdAoMjcnzZch0CgyNyfNlyHQKDI3J82XIdAoMjcn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BR8aCuC6DP0=")[iii % 8])).ToArray()));
            foreach (var action in dto.Actions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JO3Wuy/l6hMo4MWrcv+xAyS2x+Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BM32mw/FkSM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UgB5Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BnkJB/qVbGE=")[iii % 8])).ToArray()), action.Type);
                foreach (var kvp in (Dictionary<string, object>)action.Properties)
                {
                    if (!String.IsNullOrEmpty($"{kvp.Value}"))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eaqwu6HJHzp1p6Or/NNEKnnxoeY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WYqQm4HpZAo=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MU8pTwtvi2g8QiRCBmKLaDxCJEIGYotoPEIkQgZii2g8QiRC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EW8JbytPpkU=")[iii % 8])).ToArray()));
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VU6HpMuDr00ITty0x5Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dW78lOeunH0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("QCNR2OzIqdU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FFE4v4ut26Y=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BX2FsB91ID8IcIi9EnggPwhwiL0SeCA/CHCIvRJ4ID8IcIi9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JV2lkD9VDRI=")[iii % 8])).ToArray()));
            foreach (var trigger in dto.Triggers)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CwaVJ5qfzB8HC4Y3x4WXDwtdhHo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Kya1B7q/ty8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UUwbMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTVrVx5R4QE=")[iii % 8])).ToArray()), trigger.Type);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qd6OB+pS0lSl050Xt0iJRKmFn1o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("if6uJ8pyqWQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("J/EjUqStkA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yp9CMMjI9Fg=")[iii % 8])).ToArray()), trigger.Enabled);
                if (!String.IsNullOrEmpty($"{trigger.StartBoundary}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jvAklaYc2RGC/TeF+waCAY6rNcg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rtAEtYY8oiE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("keG5PN4vVc6s8bk80w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wpXYTqptOrs=")[iii % 8])).ToArray()), trigger.StartBoundary);
                }

                if (!String.IsNullOrEmpty($"{trigger.EndBoundary}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("wJRrjO9CyhvMmXicsliRC8DPetE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4LRLrM9isSs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9lsSNxUwLmbSRw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("szV2dXpFQAI=")[iii % 8])).ToArray()), trigger.EndBoundary);
                }

                if (!String.IsNullOrEmpty($"{trigger.ExecutionTimeLimit}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Gl66WKWr+QYWU6lI+LGiFhoFqwU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("On6aeIWLgjY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("n0zDmoJXv/u0YM+Ukm+/+bNA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2jSm+fcj1pQ=")[iii % 8])).ToArray()), trigger.ExecutionTimeLimit);
                }

                if (!String.IsNullOrEmpty($"{trigger.Duration}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jQYQgr59wgOBCwOS42eZE41dAd8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rSYwop5duTM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("xU/50f0V+I0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gTqLsIl8l+M=")[iii % 8])).ToArray()), trigger.Duration);
                }

                if (!String.IsNullOrEmpty($"{trigger.Interval}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Zppq27u2JIhql3nL5qx/mGbBe4Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RrpK+5uWX7g=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ENJzrXGDmpE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WbwHyAP1+/0=")[iii % 8])).ToArray()), trigger.Interval);
                }

                if (!String.IsNullOrEmpty($"{trigger.StopAtDurationEnd}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("C62h16nMSfsHoLLH9NYS6wv2sIo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K42B94nsMss=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("dnz+W3JMSg9XaeVCXFZLFEE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JQiRKzM4Dno=")[iii % 8])).ToArray()), trigger.StopAtDurationEnd);
                }

                if (trigger.Properties != null)
                {
                    foreach (var kvp in trigger.Properties)
                    {
                        if (!String.IsNullOrEmpty(kvp.Value))
                        {
                            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xhlpu3TQ9IbKFHqrKcqvlsZCeOY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5jlJm1Twj7Y=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                        }
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0oY5La83B4TfizQgojoHhN+LNCCiOgeE34s0IKI6B4TfizQg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8qYZDY8XKqk=")[iii % 8])).ToArray()));
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string gvKyKXGn)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.AddMonths(new System.DateTime(), 68);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_572A3E52)result;
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0Ew6cg7u92yNTGFiAvnkfNAXcD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8GxBQiLDxFw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("E282yw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XQ5brvwSijA=")[iii % 8])).ToArray()), dto.Name);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("v+lHqCdtbvni6Ry4K3o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n8k8mAtAXck=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("uSJSqLsLboSF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6VA7xthiHuU=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("1Wrs6RHJ6RvZZ//5TNOyC9Ux/bQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9UrMyTHpkis=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("muYNUP5AmQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3ZRiJY4J/fY=")[iii % 8])).ToArray()), dto.Principal.GroupId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("8RdIah0qZbH9Glt6QDA+ofFMWTc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0TdoSj0KHoE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("0sE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m6Uaf6meCy4=")[iii % 8])).ToArray()), dto.Principal.Id);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ICE/7Np1RUssLCz8h28eWyB6LrE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AAEfzPpVPns=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("J1/WqG542X4O").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("azCxxwAsoA4=")[iii % 8])).ToArray()), dto.Principal.LogonType);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YVMOnv3XY7JtXh2OoM04omEIH8M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QXMuvt33GII=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("sC6fvTCXwm4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4lvx8VXhpwI=")[iii % 8])).ToArray()), dto.Principal.RunLevel);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("U+nE4oIHkGxf5Nfy3x3LfFOy1b8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c8nkwqIn61w=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("Mq66fTvs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z93fD3KIwT8=")[iii % 8])).ToArray()), dto.Principal.UserId);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("N/iF/Zcflp1q+N7tmwiFjTejz7A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("F9j+zbsypa0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ymdaqEjI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ixIuwCe6bOk=")[iii % 8])).ToArray()), dto.Author);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("J5v5b/MqD3x6m6J//z0cbCfAsyI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("B7uCX98HPEw=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("rt4TXEQfSa2D1A4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6rtgPzZ2Odk=")[iii % 8])).ToArray()), dto.Description);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("IqAmZ7ibq1h/oH13tIy4SCL7bCo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AoBdV5S2mGg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("YH/jwfFO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MxCWs5IrMa0=")[iii % 8])).ToArray()), dto.Source);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("bOf5Sa6OgZsx56JZopmSi2y8swQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TMeCeYKjsqs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("WqyGJsg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CdjnUq2wxxA=")[iii % 8])).ToArray()), dto.State);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("ua0htBPFlZHkrXqkH9KGgbn2a/k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mY1ahD/opqE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("aeZzTg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OqI3Aprm8Bg=")[iii % 8])).ToArray()), dto.SDDL);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Sx/nJ6+rg7oWH7w3o7yQqktErWo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("az+cF4OGsIo=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("173PpxLuOA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ktOuxX6LXE4=")[iii % 8])).ToArray()), dto.Enabled);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Jn0QFJI0Xuh7fUsEniNN+CYmWlk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bl1rJL4Zbdg=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("yiAa5w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jkFughUqWFo=")[iii % 8])).ToArray()), (DateTime)Convert.ToDateTime(dto.Date));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("//ue9p4112Ci+8XmkiLEcP+g1Ls=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("39vlxrIY5FA=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("MKTh2a0PNFgQpunlriojQQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cciNttpLUTU=")[iii % 8])).ToArray()), dto.AllowDemandStart);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("otWcqI1uklf/1ce4gXmBR6KO1uU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gvXnmKFDoWc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("bgpw8TIvqVp5F2LiKgqgYkQhYuQqJrRETxA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KmMDkF5Dxi0=")[iii % 8])).ToArray()), dto.DisallowStartIfOnBatteries);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MY9SvBrQtwJsjwmsFsekEjHUGPE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ea8pjDb9hDI=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("eFgcP87b/j5TdBAx3uP+PFRU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PSB5XLuvl1E=")[iii % 8])).ToArray()), dto.ExecutionTimeLimit);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("/htQEi+MdFejGwsCI5tnR/5AGl8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3jsrIgOhR2c=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("SbsNmBjD3RBzoQWnP+f7C26qEIE01g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Gs9i6FGlmn8=")[iii % 8])).ToArray()), dto.StopIfGoingOnBatteries);
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("YH7OFJS6siY9fpUEmK0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QF61JLiXgRY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("1Kh2FBj5Xg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lcsCfXeXLSc=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JT86KsCaIdAoMjcnzZch0CgyNyfNlyHQKDI3J82XIdAoMjcn").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BR8aCuC6DP0=")[iii % 8])).ToArray()));
            foreach (var action in dto.Actions)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("JO3Wuy/l6hMo4MWrcv+xAyS2x+Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BM32mw/FkSM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UgB5Yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BnkJB/qVbGE=")[iii % 8])).ToArray()), action.Type);
                foreach (var kvp in (Dictionary<string, object>)action.Properties)
                {
                    if (!String.IsNullOrEmpty($"{kvp.Value}"))
                    {
                        WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("eaqwu6HJHzp1p6Or/NNEKnnxoeY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WYqQm4HpZAo=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("MU8pTwtvi2g8QiRCBmKLaDxCJEIGYotoPEIkQgZii2g8QiRC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EW8JbytPpkU=")[iii % 8])).ToArray()));
            }

            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("VU6HpMuDr00ITty0x5Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dW78lOeunH0=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("QCNR2OzIqdU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FFE4v4ut26Y=")[iii % 8])).ToArray()));
            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("BX2FsB91ID8IcIi9EnggPwhwiL0SeCA/CHCIvRJ4ID8IcIi9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JV2lkD9VDRI=")[iii % 8])).ToArray()));
            foreach (var trigger in dto.Triggers)
            {
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("CwaVJ5qfzB8HC4Y3x4WXDwtdhHo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Kya1B7q/ty8=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("UUwbMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BTVrVx5R4QE=")[iii % 8])).ToArray()), trigger.Type);
                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("qd6OB+pS0lSl050Xt0iJRKmFn1o=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("if6uJ8pyqWQ=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("J/EjUqStkA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Yp9CMMjI9Fg=")[iii % 8])).ToArray()), trigger.Enabled);
                if (!String.IsNullOrEmpty($"{trigger.StartBoundary}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jvAklaYc2RGC/TeF+waCAY6rNcg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rtAEtYY8oiE=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("keG5PN4vVc6s8bk80w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wpXYTqptOrs=")[iii % 8])).ToArray()), trigger.StartBoundary);
                }

                if (!String.IsNullOrEmpty($"{trigger.EndBoundary}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("wJRrjO9CyhvMmXicsliRC8DPetE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("4LRLrM9isSs=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("9lsSNxUwLmbSRw8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("szV2dXpFQAI=")[iii % 8])).ToArray()), trigger.EndBoundary);
                }

                if (!String.IsNullOrEmpty($"{trigger.ExecutionTimeLimit}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Gl66WKWr+QYWU6lI+LGiFhoFqwU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("On6aeIWLgjY=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("n0zDmoJXv/u0YM+Ukm+/+bNA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2jSm+fcj1pQ=")[iii % 8])).ToArray()), trigger.ExecutionTimeLimit);
                }

                if (!String.IsNullOrEmpty($"{trigger.Duration}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("jQYQgr59wgOBCwOS42eZE41dAd8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rSYwop5duTM=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("xU/50f0V+I0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gTqLsIl8l+M=")[iii % 8])).ToArray()), trigger.Duration);
                }

                if (!String.IsNullOrEmpty($"{trigger.Interval}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("Zppq27u2JIhql3nL5qx/mGbBe4Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RrpK+5uWX7g=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("ENJzrXGDmpE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WbwHyAP1+/0=")[iii % 8])).ToArray()), trigger.Interval);
                }

                if (!String.IsNullOrEmpty($"{trigger.StopAtDurationEnd}"))
                {
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("C62h16nMSfsHoLLH9NYS6wv2sIo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K42B94nsMss=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("dnz+W3JMSg9XaeVCXFZLFEE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JQiRKzM4Dno=")[iii % 8])).ToArray()), trigger.StopAtDurationEnd);
                }

                if (trigger.Properties != null)
                {
                    foreach (var kvp in trigger.Properties)
                    {
                        if (!String.IsNullOrEmpty(kvp.Value))
                        {
                            WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("xhlpu3TQ9IbKFHqrKcqvlsZCeOY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5jlJm1Twj7Y=")[iii % 8])).ToArray()), kvp.Key, kvp.Value);
                        }
                    }
                }

                WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("0oY5La83B4TfizQgojoHhN+LNCCiOgeE34s0IKI6B4TfizQg").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8qYZDY8XKqk=")[iii % 8])).ToArray()));
            }

            WriteLine();
        }
    }
}
#nullable enable
