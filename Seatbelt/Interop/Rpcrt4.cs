using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    internal class O_F8D7398B
    {
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcStringBindingCompose(string ObjUuid, string Protseq, string NetworkAddr, string Endpoint, string Options, out O_60ABF106 StringBinding);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcBindingFromStringBinding(O_60ABF106 StringBinding, out O_A6C1BE4C Binding);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern int RpcBindingToStringBinding(IntPtr Binding, out O_60ABF106 StringBinding);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcMgmtEpEltInqBegin(O_A6C1BE4C EpBinding, int InquiryType, int IfId, int VersOption, int ObjectUuid, out O_086FA7B0 InquiryContext);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Unicode)]
        public static extern uint RpcMgmtEpEltInqNext(O_086FA7B0 InquiryContext, ref RPC_IF_ID IfId, out O_A6C1BE4C Binding, int ObjectUuid, out O_60ABF106 Annotation);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcStringFree(ref IntPtr String);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcMgmtEpEltInqDone(ref IntPtr InquiryContext);
        [DllImport("rpcrt4.dll", CharSet = CharSet.Auto)]
        public static extern uint RpcBindingFree(ref IntPtr Binding);
        public struct RPC_IF_ID
        {
            public Guid Uuid;
            public ushort VersMajor;
            public ushort VersMinor;
        }

        public class O_086FA7B0 : SafeHandleZeroOrMinusOneIsInvalid
        {
            public O_086FA7B0() : base(true)
            {
            }

            protected override bool ReleaseHandle()
            {
                return O_F8D7398B.RpcMgmtEpEltInqDone(ref handle) == 0;
            }

            protected bool ReleaseHandle(string ASQkLEpA)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                            instance.GetMaxByteCount(0);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                return O_F8D7398B.RpcMgmtEpEltInqDone(ref handle) == 0;
            }
        }

        public class O_60ABF106 : SafeHandleZeroOrMinusOneIsInvalid
        {
            public O_60ABF106() : base(true)
            {
            }

            public O_60ABF106(IntPtr handle, bool owns_handle) : base(owns_handle)
            {
                SetHandle(handle);
            }

            protected override bool ReleaseHandle()
            {
                return O_F8D7398B.RpcStringFree(ref handle) == 0;
            }

            public override string ToString()
            {
                if (!IsInvalid && !IsClosed)
                {
                    return Marshal.PtrToStringUni(handle);
                }

                return string.Empty;
            }

            protected bool ReleaseHandle(string izkOlKDZ)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                            instance.GetMaxByteCount(0);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                return O_F8D7398B.RpcStringFree(ref handle) == 0;
            }

            public string ToString(string RhZTAJTZ)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                            instance.GetMaxByteCount(0);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                if (!IsInvalid && !IsClosed)
                {
                    return Marshal.PtrToStringUni(handle);
                }

                return string.Empty;
            }
        }

        public class O_A6C1BE4C : SafeHandleZeroOrMinusOneIsInvalid
        {
            public O_A6C1BE4C() : base(true)
            {
            }

            public O_A6C1BE4C(IntPtr handle, bool owns_handle) : base(owns_handle)
            {
                SetHandle(handle);
            }

            protected override bool ReleaseHandle()
            {
                return O_F8D7398B.RpcBindingFree(ref handle) == 0;
            }

            public override string ToString()
            {
                if (!IsInvalid && !IsClosed)
                {
                    if (O_F8D7398B.RpcBindingToStringBinding(handle, out O_60ABF106 str) == 0)
                    {
                        using (str)
                        {
                            return str.ToString();
                        }
                    }
                }

                return string.Empty;
            }

            public static O_A6C1BE4C Null => new O_A6C1BE4C(IntPtr.Zero, false);

            protected bool ReleaseHandle(string pJQpIrpa)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                            instance.GetMaxByteCount(0);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                return O_F8D7398B.RpcBindingFree(ref handle) == 0;
            }

            public string ToString(string ZLVRjYVt)
            {
                try
                {
                    Task.Run(() =>
                    {
                        try
                        {
                            System.Text.UTF8Encoding instance = new System.Text.UTF8Encoding();
                            instance.GetMaxByteCount(0);
                        }
                        catch (Exception)
                        {
                        }
                    }).Start();
                }
                catch (Exception)
                {
                }

                if (!IsInvalid && !IsClosed)
                {
                    if (O_F8D7398B.RpcBindingToStringBinding(handle, out O_60ABF106 str) == 0)
                    {
                        using (str)
                        {
                            return str.ToString();
                        }
                    }
                }

                return string.Empty;
            }
        }
    }
}