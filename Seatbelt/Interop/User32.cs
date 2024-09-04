using System.Runtime.InteropServices;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    internal class O_E24FBBBE
    {
        [DllImport("User32.dll")]
        public static extern bool GetLastInputInfo(ref LastInputInfo lastInputInfo);
        [DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
        internal struct LastInputInfo
        {
            public uint Size;
            public uint Time;
        }
    }
}