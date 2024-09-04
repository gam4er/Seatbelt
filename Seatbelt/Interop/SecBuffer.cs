using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SecBuffer : IDisposable
    {
        public int BufferSize;
        public int BufferType;
        public IntPtr BufferPtr;
        internal SecBuffer(int bufferSize)
        {
            BufferSize = bufferSize;
            BufferType = 2;
            BufferPtr = Marshal.AllocHGlobal(bufferSize);
        }

        internal SecBuffer(byte[] buffer)
        {
            BufferSize = buffer.Length;
            BufferType = 2;
            BufferPtr = Marshal.AllocHGlobal(BufferSize);
            try
            {
                Marshal.Copy(buffer, 0, BufferPtr, BufferSize);
            }
            catch (Exception)
            {
                Dispose();
                throw;
            }
        }

        internal byte[] ToArray()
        {
            if (BufferPtr == IntPtr.Zero)
            {
                return new byte[]
                {
                };
            }

            var buffer = new byte[BufferSize];
            Marshal.Copy(BufferPtr, buffer, 0, BufferSize);
            return buffer;
        }

        public void Dispose()
        {
            if (BufferPtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(BufferPtr);
                BufferPtr = IntPtr.Zero;
            }
        }
    }
}