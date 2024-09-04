using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SecBufferDesc : IDisposable
    {
        public int Version;
        public int BufferCount;
        public IntPtr BuffersPtr;
        internal SecBufferDesc(int size)
        {
            Version = 0;
            BufferCount = 1;
            var secBuffer = new SecBuffer(size);
            BuffersPtr = Marshal.AllocHGlobal(Marshal.SizeOf(secBuffer));
            try
            {
                Marshal.StructureToPtr(secBuffer, BuffersPtr, false);
            }
            catch (Exception)
            {
                Marshal.FreeHGlobal(BuffersPtr);
                BuffersPtr = IntPtr.Zero;
                throw;
            }
        }

        internal SecBufferDesc(byte[] buffer)
        {
            Version = 0;
            BufferCount = 1;
            var secBuffer = new SecBuffer(buffer);
            BuffersPtr = Marshal.AllocHGlobal(Marshal.SizeOf(secBuffer));
            try
            {
                Marshal.StructureToPtr(secBuffer, BuffersPtr, false);
            }
            catch (Exception)
            {
                Marshal.FreeHGlobal(BuffersPtr);
                BuffersPtr = IntPtr.Zero;
                throw;
            }
        }

        public void Dispose()
        {
            if (BuffersPtr != IntPtr.Zero)
            {
                for (var index = 0; index < BufferCount; index++)
                {
                    var currentBufferPtr = new IntPtr(BuffersPtr.ToInt64() + (index * Marshal.SizeOf(typeof(SecBuffer))));
                    var secBuffer = (SecBuffer)Marshal.PtrToStructure(currentBufferPtr, typeof(SecBuffer));
                    secBuffer.Dispose();
                }

                Marshal.FreeHGlobal(BuffersPtr);
                BuffersPtr = IntPtr.Zero;
            }
        }

        internal byte[] ToArray()
        {
            if (BuffersPtr == IntPtr.Zero)
            {
                return new byte[]
                {
                };
            }

            var outputStream = new MemoryStream();
            for (var index = 0; index < BufferCount; index++)
            {
                var currentBufferPtr = new IntPtr(BuffersPtr.ToInt64() + (index * Marshal.SizeOf(typeof(SecBuffer))));
                var secBuffer = (SecBuffer)Marshal.PtrToStructure(currentBufferPtr, typeof(SecBuffer));
                var secBufferBytes = secBuffer.ToArray();
                outputStream.Write(secBufferBytes, 0, secBufferBytes.Length);
            }

            return outputStream.ToArray();
        }
    }
}