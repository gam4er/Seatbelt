using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using O_F41F88FA.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    public enum RegistryHiveType
    {
        X86,
        X64
    }

    [Flags]
    public enum RegistryAccessMask
    {
        QueryValue = 0x0001,
        SetValue = 0x0002,
        CreateSubKey = 0x0004,
        EnumerateSubKeys = 0x0008,
        Notify = 0x0010,
        CreateLink = 0x0020,
        WoW6432 = 0x0200,
        Wow6464 = 0x0100,
        Write = 0x20006,
        Read = 0x20019,
        Execute = 0x20019,
        AllAccess = 0xF003F
    }

    public class O_D9B753E7
    {
        public O_D9B753E7(string path, RegistryValueKind kind, object value)
        {
            Path = path;
            Kind = kind;
            Value = value;
        }

        public string Path { get; }
        public RegistryValueKind Kind { get; }
        public object Value { get; }
    }

    public static class RegistryUtil
    {
        public static RegistryKey? OpenBaseKey(RegistryHive registryHive, RegistryHiveType registryType)
        {
            var _hiveKeys = new Dictionary<RegistryHive, UIntPtr>
            {
                {
                    RegistryHive.ClassesRoot,
                    new UIntPtr(0x80000000u)
                },
                {
                    RegistryHive.CurrentConfig,
                    new UIntPtr(0x80000005u)
                },
                {
                    RegistryHive.CurrentUser,
                    new UIntPtr(0x80000001u)
                },
                {
                    RegistryHive.DynData,
                    new UIntPtr(0x80000006u)
                },
                {
                    RegistryHive.LocalMachine,
                    new UIntPtr(0x80000002u)
                },
                {
                    RegistryHive.PerformanceData,
                    new UIntPtr(0x80000004u)
                },
                {
                    RegistryHive.Users,
                    new UIntPtr(0x80000003u)
                }
            };
            var _accessMasks = new Dictionary<RegistryHiveType, RegistryAccessMask>
            {
                {
                    RegistryHiveType.X64,
                    RegistryAccessMask.Wow6464
                },
                {
                    RegistryHiveType.X86,
                    RegistryAccessMask.WoW6432
                }
            };
            if (Environment.OSVersion.Platform != PlatformID.Win32NT || Environment.OSVersion.Version.Major <= 5)
                throw new PlatformNotSupportedException(Encoding.UTF8.GetString(Convert.FromBase64String("7MALdgnRpJ3exxw7WdK3ydfYCyQYyayH34gdLwrJoISYxRslDZ2njJj/Bzgd0rKamPA+dhbP5YXZ3AskVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uKhuVnm9xek=")[iii % 8])).ToArray()));
            var hiveKey = _hiveKeys[registryHive];
            var flags = RegistryAccessMask.QueryValue | RegistryAccessMask.EnumerateSubKeys | _accessMasks[registryType];
            var result = Advapi32.RegOpenKeyEx(hiveKey, string.Empty, 0, (uint)flags, out var keyHandlePointer);
            if (result == 0)
            {
                var safeRegistryHandleType = typeof(SafeHandleZeroOrMinusOneIsInvalid).Assembly.GetType(Encoding.UTF8.GetString(Convert.FromBase64String("ddTbFM5uvA1Mk+8Pzy7hRWvc3gPpfL0PVNjLSPJ8tQ5q2N8P0mmhEnDc1gLNeA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OL24ZqEd02s=")[iii % 8])).ToArray()));
                var safeRegistryHandleConstructor = safeRegistryHandleType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(IntPtr), typeof(bool) }, null);
                if (safeRegistryHandleConstructor == null)
                {
                    safeRegistryHandleConstructor = safeRegistryHandleType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(IntPtr), typeof(bool) }, null);
                }

                var keyHandle = safeRegistryHandleConstructor.Invoke(new object[] { keyHandlePointer, true });
                var net3Constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { safeRegistryHandleType, typeof(bool) }, null);
                var net4Constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(IntPtr), typeof(bool), typeof(bool), typeof(bool), typeof(bool) }, null);
                object key;
                if (net4Constructor != null)
                {
                    key = net4Constructor.Invoke(new object[] { keyHandlePointer, true, false, false, hiveKey == _hiveKeys[RegistryHive.PerformanceData] });
                }
                else if (net3Constructor != null)
                {
                    key = net3Constructor.Invoke(new object[] { keyHandle, true });
                }
                else
                {
                    var keyFromHandleMethod = typeof(RegistryKey).GetMethod(Encoding.UTF8.GetString(Convert.FromBase64String("6j4m9hDnrb7AKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rExJm1iGw9o=")[iii % 8])).ToArray()), BindingFlags.Static | BindingFlags.Public, null, new[] { safeRegistryHandleType }, null);
                    key = keyFromHandleMethod.Invoke(null, new object[] { keyHandle });
                }

                var field = typeof(RegistryKey).GetField(Encoding.UTF8.GetString(Convert.FromBase64String("zYl44buBjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("puwBr9rs6Mw=")[iii % 8])).ToArray()), BindingFlags.Instance | BindingFlags.NonPublic);
                if (field != null)
                {
                    field.SetValue(key, string.Empty);
                }

                return (RegistryKey)key;
            }

            if (result == 2)
            {
                return null;
            }

            throw new Win32Exception(result);
        }

        private static O_D9B753E7? GetValue(RegistryHive hive, string path, string value, RegistryHiveType view = RegistryHiveType.X64)
        {
            var regKey = OpenBaseKey(hive, view)?.OpenSubKey(path, RegistryKeyPermissionCheck.Default, RegistryRights.QueryValues);
            var regKeyValue = regKey?.GetValue(value);
            if (regKey == null || regKeyValue == null)
                return null;
            var kind = regKey.GetValueKind(value);
            return new O_D9B753E7(path, kind, regKeyValue);
        }

        public static string? GetStringValue(RegistryHive hive, string path, string value, RegistryHiveType view = RegistryHiveType.X64)
        {
            var regValue = GetValue(hive, path, value, view);
            return regValue?.Value.ToString();
        }

        public static string? GetStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("WibXkGmEwuR6FcKvaJM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HUOjwx32q4o=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("JkSNqQLn3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TgDoz0mCp80=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("numoVBaja6eM17g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7brdNl3GEuk=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("RnTjwBuoQ8RYRw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NSKCrG7NDaU=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("7zcOhPQWlkbPBBu79QE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qFJ614Bk/yg=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("9q+DLWDj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hfniQRWGWmQ=")[iii % 8])).ToArray())) == null ? null : (string)outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("DxframAB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fEGKBhVk6C0=")[iii % 8])).ToArray()));
            }
            catch
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hbuBm4UiahU=")[iii % 8])).ToArray());
            }
        }

        public static string[] GetMultiStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("42Nysgo92xz3cnSWETb5FMhzYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pAYG/39Rr3U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("N0DeOWRRZw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XwS7Xy80HjY=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("yjovhKHexrzYBD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uWla5uq7v/I=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("AlcrxchYNPAcZA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cQFKqb09epE=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("E+hJnjY6vd4H+U+6LTGf1jj4WA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VI0900NWybc=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("D2F+zwFt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fDcfo3QIsG4=")[iii % 8])).ToArray())) == null ? new string[]
                {
                }

                : (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("YQssZzSC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("El1NC0HnsHQ=")[iii % 8])).ToArray()));
            }
            catch
            {
                return new string[]
                {
                };
            }
        }

        public static string? GetExpandedStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("fQwgQ27c+5ReDDBVYt7zlF0/NWpjyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OmlUBhasmvo=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("jffnObzEUQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5bOCX/ehKOI=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("jntBQwAQX3WcRVE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/Sg0IUt1Jjs=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("CwGomDOV/6sVMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eFfJ9Ebwsco=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("v/4YPyS/uR2c/ggpKL2xHZ/NDRYpqg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+JtselzP2HM=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("9PlksXYz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h68F3QNWo8E=")[iii % 8])).ToArray())) == null ? null : (string)outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("ChpnWcqM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eUwGNb/pOe8=")[iii % 8])).ToArray()));
            }
            catch
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zUKqYLG7VZg=")[iii % 8])).ToArray());
            }
        }

        public static uint? GetDwordValue(RegistryHive hive, string path, string value, RegistryHiveType view = RegistryHiveType.X64)
        {
            var regValue = GetValue(hive, path, value, view);
            if (regValue == null)
                return null;
            if (uint.TryParse($"{regValue.Value}", out var output))
            {
                return output;
            }

            try
            {
                return unchecked((uint)(int)regValue.Value);
            }
            catch
            {
                return null;
            }
        }

        public static uint? GetDwordValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("tBpi7h42OTGlHnrfLA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("838Wqkl5a3U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("k+EGtlPTNA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+6Vj0Bi2Tds=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("T84vmpJCCm9d8D8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PJ1a+NkncyE=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("5PfYoGX/4HX6xA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l6G5zBCarhQ=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("4h9P6OwtFXPzG1fZ3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pXo7rLtiRzc=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("gcXU1ML0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9JO1uLeRwRQ=")[iii % 8])).ToArray())) == null ? null : (uint? )outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("nck6wIWv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6J9brPDKIbs=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static long? GetQwordValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("KYaXT9IpObE4go9r4A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("buPjHoVma/U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("XbPTT7gniA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nfe2KfNC8bw=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("cQTHdBW3UpljOtc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AleyFl7SK9c=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("qT+3ldWPhzS3DA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2mnW+aDqyVU=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("5W7lcgA9jR/0av1WMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oguRI1dy31s=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("d0MsyYoB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AhVNpf9kU4A=")[iii % 8])).ToArray())) == null ? null : (long? )outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("m5086duz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7stdha7WPHg=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static byte[]? GetBinaryValue(RegistryHive hive, string path, string value, RegistryHiveType view = RegistryHiveType.X64)
        {
            var regValue = GetValue(hive, path, value, view);
            return (byte[]? )regValue?.Value;
        }

        public static byte[]? GetBinaryValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("f05Ddpw60IpBfVZYgDE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OCs3NPVUsfg=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("Yf4oqrsDNg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CbpNzPBmT/w=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("WULQE8UBgUxLfMA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KhGlcY5k+AI=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("6Zf1KzBsUTr3pA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("msGUR0UJH1s=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("zqHtPAjTksrwkvgSFNg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("icSZfmG987g=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("8hN6E3Zo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h0UbfwMNAbw=")[iii % 8])).ToArray())) == null ? null : (byte[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("6kj3+2rR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nx6Wlx+0uIQ=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static Dictionary<string, object> GetValues(RegistryHive hive, string path, string computer = "")
        {
            RegistryKey? rootHive = null;
            RegistryKey? key = null;
            try
            {
                rootHive = RegistryKey.OpenRemoteBaseKey(hive, computer);
                key = rootHive.OpenSubKey(path, false) ?? throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("gpQ0nRFenVOn1jmdEEmRU70=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yfFNvXUx+CA=")[iii % 8])).ToArray()));
                var valueNames = key.GetValueNames();
                var keyValuePairs = valueNames.ToDictionary(name => name, key.GetValue);
                return keyValuePairs;
            }
            catch
            {
                return new Dictionary<string, object>();
            }
            finally
            {
                key?.Close();
                rootHive?.Close();
            }
        }

        public static Dictionary<string, object> GetValues(RegistryHive hive, string path, ManagementClass wmiRegProv)
        {
            var results = new Dictionary<string, object>();
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("hC7SGRUePS+kMw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wUCndEN/UVo=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("dHMpaLl16A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HDdMDvIQkRQ=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("368vOPT6ABnNkT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rPxaWr+feVc=")[iii % 8])).ToArray())] = path;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("3OnfkZR8rVr89A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mYeq/MIdwS8=")[iii % 8])).ToArray()), inParams, null);
                var valueNames = (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("/S2Ka1LJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jmPrBje6fM4=")[iii % 8])).ToArray()));
                var valueTypes = (int[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("YRLfP7M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NWuvWsAJOGE=")[iii % 8])).ToArray()));
                for (var i = 0; i < valueNames.Length; ++i)
                {
                    object? value = null;
                    switch (valueTypes[i])
                    {
                        case 1:
                        {
                            value = GetStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 2:
                        {
                            value = GetExpandedStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 3:
                        {
                            value = GetBinaryValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 4:
                        {
                            value = GetDwordValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 7:
                        {
                            value = GetMultiStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 11:
                        {
                            value = GetQwordValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        default:
                            throw new Exception($"Unhandled WMI registry value type: {valueTypes[i]}");
                    }

                    if (value != null)
                        results.Add($"{valueNames[i]}", value);
                }
            }
            catch
            {
            }

            return results;
        }

        public static string[]? GetSubkeyNames(RegistryHive hive, string path, string computer = "")
        {
            RegistryKey? rootHive = null;
            RegistryKey? key = null;
            try
            {
                rootHive = RegistryKey.OpenRemoteBaseKey(hive, computer);
                key = rootHive.OpenSubKey(path, false);
                return key?.GetSubKeyNames();
            }
            catch
            {
                return null;
            }
            finally
            {
                key?.Close();
                rootHive?.Close();
            }
        }

        public static string[]? GetSubkeyNames(RegistryHive hive, string path, ManagementClass wmiRegProv)
        {
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("84ee+CyoXg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tunrlWfNJyA=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("FrsGyNyxHw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fv9jrpfUZjU=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("RJDcyzw6wvFWrsw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N8OpqXdfu78=")[iii % 8])).ToArray())] = path;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("/bbGXoeb6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uNizM8z+kd4=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("772dO0DD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nPP8ViWwOQ8=")[iii % 8])).ToArray())) == null ? new string[]
                {
                }

                : (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("ND4NOhil").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R3BsV33WuvY=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static string[] GetUserSIDs(ManagementClass wmiRegProv)
        {
            return GetSubkeyNames(RegistryHive.Users, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o2vSdbnLEHw=")[iii % 8])).ToArray()), wmiRegProv) ?? new string[]
            {
            };
        }

        public static string[] GetUserSIDs()
        {
            return Registry.Users.GetSubKeyNames() ?? new string[]
            {
            };
        }

        public static RegistryHive GetHive(string name)
        {
            switch (name.ToUpper())
            {
                case "HKCR":
                case "HKEY_CLASSES_ROOT":
                    return RegistryHive.ClassesRoot;
                case "HKEY_CURRENT_CONFIG":
                    return RegistryHive.CurrentConfig;
                case "HKCU":
                case "HKEY_CURRENT_USER":
                    return RegistryHive.CurrentUser;
                case "HKLM":
                case "HKEY_LOCAL_MACHINE":
                    return RegistryHive.LocalMachine;
                case "HKEY_PERFORMANCE_DATA":
                    return RegistryHive.PerformanceData;
                case "HKU":
                case "HKEY_USERS":
                    return RegistryHive.Users;
                default:
                    throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("wbXWAXXOrcDxvNQcbsu62v2t2A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lNu9bxq5w5I=")[iii % 8])).ToArray()));
            }
        }

        public static RegistryKey? OpenBaseKey(RegistryHive registryHive, RegistryHiveType registryType, string hKLtsnWa)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            var _hiveKeys = new Dictionary<RegistryHive, UIntPtr>
            {
                {
                    RegistryHive.ClassesRoot,
                    new UIntPtr(0x80000000u)
                },
                {
                    RegistryHive.CurrentConfig,
                    new UIntPtr(0x80000005u)
                },
                {
                    RegistryHive.CurrentUser,
                    new UIntPtr(0x80000001u)
                },
                {
                    RegistryHive.DynData,
                    new UIntPtr(0x80000006u)
                },
                {
                    RegistryHive.LocalMachine,
                    new UIntPtr(0x80000002u)
                },
                {
                    RegistryHive.PerformanceData,
                    new UIntPtr(0x80000004u)
                },
                {
                    RegistryHive.Users,
                    new UIntPtr(0x80000003u)
                }
            };
            var _accessMasks = new Dictionary<RegistryHiveType, RegistryAccessMask>
            {
                {
                    RegistryHiveType.X64,
                    RegistryAccessMask.Wow6464
                },
                {
                    RegistryHiveType.X86,
                    RegistryAccessMask.WoW6432
                }
            };
            if (Environment.OSVersion.Platform != PlatformID.Win32NT || Environment.OSVersion.Version.Major <= 5)
                throw new PlatformNotSupportedException(Encoding.UTF8.GetString(Convert.FromBase64String("7MALdgnRpJ3exxw7WdK3ydfYCyQYyayH34gdLwrJoISYxRslDZ2njJj/Bzgd0rKamPA+dhbP5YXZ3AskVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uKhuVnm9xek=")[iii % 8])).ToArray()));
            var hiveKey = _hiveKeys[registryHive];
            var flags = RegistryAccessMask.QueryValue | RegistryAccessMask.EnumerateSubKeys | _accessMasks[registryType];
            var result = Advapi32.RegOpenKeyEx(hiveKey, string.Empty, 0, (uint)flags, out var keyHandlePointer);
            if (result == 0)
            {
                var safeRegistryHandleType = typeof(SafeHandleZeroOrMinusOneIsInvalid).Assembly.GetType(Encoding.UTF8.GetString(Convert.FromBase64String("ddTbFM5uvA1Mk+8Pzy7hRWvc3gPpfL0PVNjLSPJ8tQ5q2N8P0mmhEnDc1gLNeA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OL24ZqEd02s=")[iii % 8])).ToArray()));
                var safeRegistryHandleConstructor = safeRegistryHandleType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(IntPtr), typeof(bool) }, null);
                if (safeRegistryHandleConstructor == null)
                {
                    safeRegistryHandleConstructor = safeRegistryHandleType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new[] { typeof(IntPtr), typeof(bool) }, null);
                }

                var keyHandle = safeRegistryHandleConstructor.Invoke(new object[] { keyHandlePointer, true });
                var net3Constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { safeRegistryHandleType, typeof(bool) }, null);
                var net4Constructor = typeof(RegistryKey).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new[] { typeof(IntPtr), typeof(bool), typeof(bool), typeof(bool), typeof(bool) }, null);
                object key;
                if (net4Constructor != null)
                {
                    key = net4Constructor.Invoke(new object[] { keyHandlePointer, true, false, false, hiveKey == _hiveKeys[RegistryHive.PerformanceData] });
                }
                else if (net3Constructor != null)
                {
                    key = net3Constructor.Invoke(new object[] { keyHandle, true });
                }
                else
                {
                    var keyFromHandleMethod = typeof(RegistryKey).GetMethod(Encoding.UTF8.GetString(Convert.FromBase64String("6j4m9hDnrb7AKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rExJm1iGw9o=")[iii % 8])).ToArray()), BindingFlags.Static | BindingFlags.Public, null, new[] { safeRegistryHandleType }, null);
                    key = keyFromHandleMethod.Invoke(null, new object[] { keyHandle });
                }

                var field = typeof(RegistryKey).GetField(Encoding.UTF8.GetString(Convert.FromBase64String("zYl44buBjQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("puwBr9rs6Mw=")[iii % 8])).ToArray()), BindingFlags.Instance | BindingFlags.NonPublic);
                if (field != null)
                {
                    field.SetValue(key, string.Empty);
                }

                return (RegistryKey)key;
            }

            if (result == 2)
            {
                return null;
            }

            throw new Win32Exception(result);
        }

        public static string? GetStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string OHoTKJNS)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("WibXkGmEwuR6FcKvaJM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HUOjwx32q4o=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("JkSNqQLn3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TgDoz0mCp80=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("numoVBaja6eM17g=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7brdNl3GEuk=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("RnTjwBuoQ8RYRw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NSKCrG7NDaU=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("7zcOhPQWlkbPBBu79QE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qFJ614Bk/yg=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("9q+DLWDj").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hfniQRWGWmQ=")[iii % 8])).ToArray())) == null ? null : (string)outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("DxframAB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fEGKBhVk6C0=")[iii % 8])).ToArray()));
            }
            catch
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hbuBm4UiahU=")[iii % 8])).ToArray());
            }
        }

        public static string[] GetMultiStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string nIZzRpUu)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("42Nysgo92xz3cnSWETb5FMhzYw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pAYG/39Rr3U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("N0DeOWRRZw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XwS7Xy80HjY=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("yjovhKHexrzYBD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uWla5uq7v/I=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("AlcrxchYNPAcZA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("cQFKqb09epE=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("E+hJnjY6vd4H+U+6LTGf1jj4WA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VI0900NWybc=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("D2F+zwFt").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fDcfo3QIsG4=")[iii % 8])).ToArray())) == null ? new string[]
                {
                }

                : (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("YQssZzSC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("El1NC0HnsHQ=")[iii % 8])).ToArray()));
            }
            catch
            {
                return new string[]
                {
                };
            }
        }

        public static string? GetExpandedStringValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string qdqKwMEY)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("fQwgQ27c+5ReDDBVYt7zlF0/NWpjyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OmlUBhasmvo=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("jffnObzEUQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5bOCX/ehKOI=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("jntBQwAQX3WcRVE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/Sg0IUt1Jjs=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("CwGomDOV/6sVMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eFfJ9Ebwsco=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("v/4YPyS/uR2c/ggpKL2xHZ/NDRYpqg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+JtselzP2HM=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("9PlksXYz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h68F3QNWo8E=")[iii % 8])).ToArray())) == null ? null : (string)outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("ChpnWcqM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eUwGNb/pOe8=")[iii % 8])).ToArray()));
            }
            catch
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zUKqYLG7VZg=")[iii % 8])).ToArray());
            }
        }

        public static uint? GetDwordValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string bhoJtJFx)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("tBpi7h42OTGlHnrfLA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("838Wqkl5a3U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("k+EGtlPTNA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+6Vj0Bi2Tds=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("T84vmpJCCm9d8D8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PJ1a+NkncyE=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("5PfYoGX/4HX6xA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("l6G5zBCarhQ=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("4h9P6OwtFXPzG1fZ3g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("pXo7rLtiRzc=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("gcXU1ML0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9JO1uLeRwRQ=")[iii % 8])).ToArray())) == null ? null : (uint? )outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("nck6wIWv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6J9brPDKIbs=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static long? GetQwordValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string TYXOtAdu)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("KYaXT9IpObE4go9r4A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("buPjHoVma/U=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("XbPTT7gniA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Nfe2KfNC8bw=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("cQTHdBW3UpljOtc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AleyFl7SK9c=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("qT+3ldWPhzS3DA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2mnW+aDqyVU=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("5W7lcgA9jR/0av1WMg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oguRI1dy31s=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("d0MsyYoB").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AhVNpf9kU4A=")[iii % 8])).ToArray())) == null ? null : (long? )outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("m5086duz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7stdha7WPHg=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static byte[]? GetBinaryValue(RegistryHive hive, string path, string value, ManagementClass wmiRegProv, string mWWmfmhr)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("f05Ddpw60IpBfVZYgDE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OCs3NPVUsfg=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("Yf4oqrsDNg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CbpNzPBmT/w=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("WULQE8UBgUxLfMA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KhGlcY5k+AI=")[iii % 8])).ToArray())] = path;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("6Zf1KzBsUTr3pA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("msGUR0UJH1s=")[iii % 8])).ToArray())] = value;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("zqHtPAjTksrwkvgSFNg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("icSZfmG987g=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("8hN6E3Zo").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("h0UbfwMNAbw=")[iii % 8])).ToArray())) == null ? null : (byte[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("6kj3+2rR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nx6Wlx+0uIQ=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static Dictionary<string, object> GetValues(RegistryHive hive, string path, ManagementClass wmiRegProv, string pRDOxLeC)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            var results = new Dictionary<string, object>();
            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("hC7SGRUePS+kMw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wUCndEN/UVo=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("dHMpaLl16A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HDdMDvIQkRQ=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("368vOPT6ABnNkT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rPxaWr+feVc=")[iii % 8])).ToArray())] = path;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("3OnfkZR8rVr89A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mYeq/MIdwS8=")[iii % 8])).ToArray()), inParams, null);
                var valueNames = (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("/S2Ka1LJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jmPrBje6fM4=")[iii % 8])).ToArray()));
                var valueTypes = (int[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("YRLfP7M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NWuvWsAJOGE=")[iii % 8])).ToArray()));
                for (var i = 0; i < valueNames.Length; ++i)
                {
                    object? value = null;
                    switch (valueTypes[i])
                    {
                        case 1:
                        {
                            value = GetStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 2:
                        {
                            value = GetExpandedStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 3:
                        {
                            value = GetBinaryValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 4:
                        {
                            value = GetDwordValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 7:
                        {
                            value = GetMultiStringValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        case 11:
                        {
                            value = GetQwordValue(hive, $"{path}", $"{valueNames[i]}", wmiRegProv);
                            break;
                        }

                        default:
                            throw new Exception($"Unhandled WMI registry value type: {valueTypes[i]}");
                    }

                    if (value != null)
                        results.Add($"{valueNames[i]}", value);
                }
            }
            catch
            {
            }

            return results;
        }

        public static string[]? GetSubkeyNames(RegistryHive hive, string path, ManagementClass wmiRegProv, string CPsdVEZd)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            try
            {
                var inParams = wmiRegProv.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String("84ee+CyoXg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tunrlWfNJyA=")[iii % 8])).ToArray()));
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("FrsGyNyxHw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fv9jrpfUZjU=")[iii % 8])).ToArray())] = (UInt32)hive;
                inParams[Encoding.UTF8.GetString(Convert.FromBase64String("RJDcyzw6wvFWrsw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N8OpqXdfu78=")[iii % 8])).ToArray())] = path;
                var outParams = wmiRegProv.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String("/bbGXoeb6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("uNizM8z+kd4=")[iii % 8])).ToArray()), inParams, null);
                return outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("772dO0DD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nPP8ViWwOQ8=")[iii % 8])).ToArray())) == null ? new string[]
                {
                }

                : (string[])outParams.GetPropertyValue(Encoding.UTF8.GetString(Convert.FromBase64String("ND4NOhil").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("R3BsV33WuvY=")[iii % 8])).ToArray()));
            }
            catch
            {
                return null;
            }
        }

        public static string[] GetUserSIDs(ManagementClass wmiRegProv, string DcgtSFAp)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            return GetSubkeyNames(RegistryHive.Users, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o2vSdbnLEHw=")[iii % 8])).ToArray()), wmiRegProv) ?? new string[]
            {
            };
        }

        public static string[] GetUserSIDs(string AvXZpRso)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            return Registry.Users.GetSubKeyNames() ?? new string[]
            {
            };
        }

        public static RegistryHive GetHive(string name, string AwTcFqzH)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
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

            switch (name.ToUpper())
            {
                case "HKCR":
                case "HKEY_CLASSES_ROOT":
                    return RegistryHive.ClassesRoot;
                case "HKEY_CURRENT_CONFIG":
                    return RegistryHive.CurrentConfig;
                case "HKCU":
                case "HKEY_CURRENT_USER":
                    return RegistryHive.CurrentUser;
                case "HKLM":
                case "HKEY_LOCAL_MACHINE":
                    return RegistryHive.LocalMachine;
                case "HKEY_PERFORMANCE_DATA":
                    return RegistryHive.PerformanceData;
                case "HKU":
                case "HKEY_USERS":
                    return RegistryHive.Users;
                default:
                    throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("wbXWAXXOrcDxvNQcbsu62v2t2A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lNu9bxq5w5I=")[iii % 8])).ToArray()));
            }
        }
    }
}