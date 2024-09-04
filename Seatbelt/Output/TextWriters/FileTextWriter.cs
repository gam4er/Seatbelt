using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.TextWriters
{
    internal class O_2636E887 : ITextWriter
    {
        private readonly StreamWriter _stream;
        public O_2636E887(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            _stream = File.CreateText(fileName);
            _stream.AutoFlush = true;
        }

        public void Write(string str) => _stream.Write(str);
        public void WriteLine() => _stream.WriteLine();
        public void WriteLine(string str) => _stream.WriteLine(str);
        public void WriteLine(string format, params object? [] args) => _stream.WriteLine(format, args);
        public void Dispose()
        {
            _stream.Dispose();
        }

        public void Dispose(string kLBghaeq)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.Cryptography.DSACryptoServiceProvider instance = new System.Security.Cryptography.DSACryptoServiceProvider();
                        instance.ExportCspBlob(true);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _stream.Dispose();
        }
    }
}