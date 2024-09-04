using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    class FileUtil
    {
        public static bool IsDotNetAssembly(string fileName)
        {
            try
            {
                using (Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    if (fileStream.Length < 64)
                    {
                        return false;
                    }

                    fileStream.Position = 0x3C;
                    uint peHeaderPointer = binaryReader.ReadUInt32();
                    if (peHeaderPointer == 0)
                    {
                        peHeaderPointer = 0x80;
                    }

                    if (peHeaderPointer > fileStream.Length - 256)
                    {
                        return false;
                    }

                    fileStream.Position = peHeaderPointer;
                    uint peHeaderSignature = binaryReader.ReadUInt32();
                    if (peHeaderSignature != 0x00004550)
                    {
                        return false;
                    }

                    fileStream.Position += 20;
                    const ushort PE32 = 0x10b;
                    const ushort PE32Plus = 0x20b;
                    var peFormat = binaryReader.ReadUInt16();
                    if (peFormat != PE32 && peFormat != PE32Plus)
                    {
                        return false;
                    }

                    ushort dataDictionaryStart = (ushort)(peHeaderPointer + (peFormat == PE32 ? 232 : 248));
                    fileStream.Position = dataDictionaryStart;
                    uint cliHeaderRva = binaryReader.ReadUInt32();
                    if (cliHeaderRva == 0)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsDotNetAssembly(string fileName, string BsYbzOVE)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(3);
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
                using (Stream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    if (fileStream.Length < 64)
                    {
                        return false;
                    }

                    fileStream.Position = 0x3C;
                    uint peHeaderPointer = binaryReader.ReadUInt32();
                    if (peHeaderPointer == 0)
                    {
                        peHeaderPointer = 0x80;
                    }

                    if (peHeaderPointer > fileStream.Length - 256)
                    {
                        return false;
                    }

                    fileStream.Position = peHeaderPointer;
                    uint peHeaderSignature = binaryReader.ReadUInt32();
                    if (peHeaderSignature != 0x00004550)
                    {
                        return false;
                    }

                    fileStream.Position += 20;
                    const ushort PE32 = 0x10b;
                    const ushort PE32Plus = 0x20b;
                    var peFormat = binaryReader.ReadUInt16();
                    if (peFormat != PE32 && peFormat != PE32Plus)
                    {
                        return false;
                    }

                    ushort dataDictionaryStart = (ushort)(peHeaderPointer + (peFormat == PE32 ? 232 : 248));
                    fileStream.Position = dataDictionaryStart;
                    uint cliHeaderRva = binaryReader.ReadUInt32();
                    if (cliHeaderRva == 0)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    public static class O_391D9844
    {
        public static int capacity = 512;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string filePath);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string? section, string? key, string defaultValue, [In, Out] char[] value, int size, string filePath);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileSection(string section, IntPtr keyValue, int size, string filePath);
        public static string[] ReadSections(string filePath)
        {
            while (true)
            {
                var chars = new char[capacity];
                var size = GetPrivateProfileString(null, null, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HA+2E45dXBo=")[iii % 8])).ToArray()), chars, capacity, filePath);
                if (size == 0)
                    return new string[]
                    {
                    };
                if (size < capacity - 2)
                {
                    var result = new string (chars, 0, size);
                    var sections = result.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
                    return sections;
                }

                capacity *= 2;
            }
        }

        public static string[] ReadKeyValuePairs(string section, string filePath)
        {
            while (true)
            {
                var returnedString = Marshal.AllocCoTaskMem(capacity * sizeof(char));
                var size = GetPrivateProfileSection(section, returnedString, capacity, filePath);
                if (size == 0)
                {
                    Marshal.FreeCoTaskMem(returnedString);
                    return new string[]
                    {
                    };
                }

                if (size < capacity - 2)
                {
                    var result = Marshal.PtrToStringAuto(returnedString, size - 1);
                    Marshal.FreeCoTaskMem(returnedString);
                    var keyValuePairs = result.Split('\0');
                    return keyValuePairs;
                }

                Marshal.FreeCoTaskMem(returnedString);
                capacity *= 2;
            }
        }

        public static string[] ReadSections(string filePath, string SxeKRGNL)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(3);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            while (true)
            {
                var chars = new char[capacity];
                var size = GetPrivateProfileString(null, null, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HA+2E45dXBo=")[iii % 8])).ToArray()), chars, capacity, filePath);
                if (size == 0)
                    return new string[]
                    {
                    };
                if (size < capacity - 2)
                {
                    var result = new string (chars, 0, size);
                    var sections = result.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
                    return sections;
                }

                capacity *= 2;
            }
        }

        public static string[] ReadKeyValuePairs(string section, string filePath, string iIlJGYHc)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Diagnostics.StackTrace instance = new System.Diagnostics.StackTrace();
                        instance.GetFrame(3);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            while (true)
            {
                var returnedString = Marshal.AllocCoTaskMem(capacity * sizeof(char));
                var size = GetPrivateProfileSection(section, returnedString, capacity, filePath);
                if (size == 0)
                {
                    Marshal.FreeCoTaskMem(returnedString);
                    return new string[]
                    {
                    };
                }

                if (size < capacity - 2)
                {
                    var result = Marshal.PtrToStringAuto(returnedString, size - 1);
                    Marshal.FreeCoTaskMem(returnedString);
                    var keyValuePairs = result.Split('\0');
                    return keyValuePairs;
                }

                Marshal.FreeCoTaskMem(returnedString);
                capacity *= 2;
            }
        }
    }
}