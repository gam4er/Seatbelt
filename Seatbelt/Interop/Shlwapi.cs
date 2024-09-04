using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    class O_210F4320
    {
        public static bool IsWindowsServer()
        {
            return IsOS(OS_ANYSERVER);
        }

        const int OS_ANYSERVER = 29;
        [DllImport("shlwapi.dll", SetLastError = true, EntryPoint = "#437")]
        private static extern bool IsOS(int os);
        public static bool IsWindowsServer(string xRayWRhk)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ChineseLunisolarCalendar instance = new System.Globalization.ChineseLunisolarCalendar();
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

            return IsOS(OS_ANYSERVER);
        }
    }
}