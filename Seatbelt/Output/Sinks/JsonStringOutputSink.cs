using System;
using System.IO;
using System.Web.Script.Serialization;
using O_F41F88FA.Commands;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Sinks
{
    internal class O_60BBEB9A : IOutputSink
    {
        private StreamWriter _streamWriter;
        private MemoryStream _stream;
        private JavaScriptSerializer _json = new JavaScriptSerializer();
        public O_60BBEB9A(string file, bool filterResults)
        {
            _stream = new MemoryStream();
            _streamWriter = new StreamWriter(_stream);
            _streamWriter.AutoFlush = true;
        }

        public void WriteOutput(O_4AED570F dto)
        {
            if (dto == null)
            {
                return;
            }

            var dtoType = dto.GetType();
            if (dtoType == typeof(O_75A28A1C))
                return;
            var obj = new
            {
                Type = dtoType.ToString(),
                CommandVersion = dto.GetCommandVersion(),
                Data = dto
            };
            string jsonStr;
            try
            {
                jsonStr = _json.Serialize(obj);
            }
            catch (Exception e)
            {
                jsonStr = _json.Serialize(new { Type = typeof(O_DDA13DE3).ToString(), Data = _json.Serialize(new O_DDA13DE3(e.ToString())) });
            }

            _streamWriter.WriteLine(jsonStr);
        }

        public void WriteVerbose(string message) => WriteOutput(new O_77AFBCF7(message));
        public void WriteWarning(string message) => WriteOutput(new O_56497D89(message));
        public void WriteError(string message) => WriteOutput(new O_DDA13DE3(message));
        public void WriteHost(string message) => WriteOutput(new O_75A28A1C(message));
        public string GetOutput()
        {
            _stream.Flush();
            _streamWriter.Flush();
            _stream.Position = 0;
            StreamReader sr = new StreamReader(_stream);
            return sr.ReadToEnd();
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
            _stream.Dispose();
        }

        public void WriteOutput(O_4AED570F dto, string YytByceE)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                        instance.IsLeapDay(47, 98, 87, 2);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (dto == null)
            {
                return;
            }

            var dtoType = dto.GetType();
            if (dtoType == typeof(O_75A28A1C))
                return;
            var obj = new
            {
                Type = dtoType.ToString(),
                CommandVersion = dto.GetCommandVersion(),
                Data = dto
            };
            string jsonStr;
            try
            {
                jsonStr = _json.Serialize(obj);
            }
            catch (Exception e)
            {
                jsonStr = _json.Serialize(new { Type = typeof(O_DDA13DE3).ToString(), Data = _json.Serialize(new O_DDA13DE3(e.ToString())) });
            }

            _streamWriter.WriteLine(jsonStr);
        }

        public string GetOutput(string IZyBzAmh)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                        instance.IsLeapDay(47, 98, 87, 2);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _stream.Flush();
            _streamWriter.Flush();
            _stream.Position = 0;
            StreamReader sr = new StreamReader(_stream);
            return sr.ReadToEnd();
        }

        public void Dispose(string CAUynPck)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.HijriCalendar instance = new System.Globalization.HijriCalendar();
                        instance.IsLeapDay(47, 98, 87, 2);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _streamWriter.Dispose();
            _stream.Dispose();
        }
    }
}