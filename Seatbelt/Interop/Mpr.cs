using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    public class O_CC45627B
    {
        [DllImport("mpr.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string localName, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder remoteName, ref int length);
    }
}