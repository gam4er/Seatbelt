using O_F41F88FA.Commands;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Formatters
{
    internal class O_AFCC99E5 : TextFormatterBase
    {
        public O_AFCC99E5(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            if (result == null)
            {
                return;
            }

            var type = result.GetType();
            foreach (var p in type.GetProperties())
            {
                if (p.PropertyType.IsArray)
                {
                    var value = (object[])p.GetValue(result, null);
                    Write($"  {p.Name, -30} : ");
                    for (var i = 0; i < value.Length; i++)
                    {
                        Write(value[i].ToString());
                        if (value.Length - 1 != i)
                        {
                            Write(Encoding.UTF8.GetString(Convert.FromBase64String("7tw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wvzUL63jlks=")[iii % 8])).ToArray()));
                        }
                    }

                    WriteLine();
                }
                else
                {
                    var value = p.GetValue(result, null);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EEE0pT/DH4BNQXW1aN9R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MGFPlRPuLLA=")[iii % 8])).ToArray()), p.Name, value);
                }
            }

            WriteLine();
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string kLBghaeq)
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

            if (result == null)
            {
                return;
            }

            var type = result.GetType();
            foreach (var p in type.GetProperties())
            {
                if (p.PropertyType.IsArray)
                {
                    var value = (object[])p.GetValue(result, null);
                    Write($"  {p.Name, -30} : ");
                    for (var i = 0; i < value.Length; i++)
                    {
                        Write(value[i].ToString());
                        if (value.Length - 1 != i)
                        {
                            Write(Encoding.UTF8.GetString(Convert.FromBase64String("7tw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wvzUL63jlks=")[iii % 8])).ToArray()));
                        }
                    }

                    WriteLine();
                }
                else
                {
                    var value = p.GetValue(result, null);
                    WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String("EEE0pT/DH4BNQXW1aN9R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MGFPlRPuLLA=")[iii % 8])).ToArray()), p.Name, value);
                }
            }

            WriteLine();
        }
    }
}