using System;
using System.Text;
using O_F41F88FA.Interop;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.TextWriters
{
    internal class O_132E9F90 : ITextWriter
    {
        public O_132E9F90()
        {
            if (IsConsolePresent())
                Console.OutputEncoding = Encoding.UTF8;
        }

        public void Write(string str) => Console.Write(str);
        public void WriteLine() => Console.WriteLine();
        public void WriteLine(string str) => Console.WriteLine(str);
        public void WriteLine(string format, params object? [] args) => Console.WriteLine(format, args);
        public void Dispose()
        {
        }

        bool IsConsolePresent()
        {
            return Kernel32.GetConsoleWindow() != IntPtr.Zero;
        }

        public void Dispose(string kLBghaeq)
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
        }

        bool IsConsolePresent(string pxYOOZxO)
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

            return Kernel32.GetConsoleWindow() != IntPtr.Zero;
        }
    }
}