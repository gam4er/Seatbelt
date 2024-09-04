using System;
using System.IO;
using System.Web.Script.Serialization;
using O_F41F88FA.Commands;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Sinks
{
    internal class O_9BEF08AF : IOutputSink
    {
        private StreamWriter _stream;
        private JavaScriptSerializer _json = new JavaScriptSerializer();
        public O_9BEF08AF(string file, bool filterResults)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }

            _stream = File.CreateText(file);
            _stream.AutoFlush = true;
        }

        public void WriteOutput(O_4AED570F dto)
        {
            if (dto == null)
            {
                return;
            }

            var dtoType = dto.GetType();
            var obj = new
            {
                Type = dtoType.ToString(),
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

            _stream.WriteLine(jsonStr);
        }

        public void WriteVerbose(string message) => WriteOutput(new O_77AFBCF7(message));
        public void WriteWarning(string message) => WriteOutput(new O_56497D89(message));
        public void WriteError(string message) => WriteOutput(new O_DDA13DE3(message));
        public void WriteHost(string message) => WriteOutput(new O_75A28A1C(message));
        public string GetOutput()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LhWqoeDWJ0g=")[iii % 8])).ToArray());
        }

        public void Dispose()
        {
            _stream.Dispose();
        }

        public void WriteOutput(O_4AED570F dto, string rnpvzJbb)
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

            if (dto == null)
            {
                return;
            }

            var dtoType = dto.GetType();
            var obj = new
            {
                Type = dtoType.ToString(),
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

            _stream.WriteLine(jsonStr);
        }

        public string GetOutput(string bamzBzds)
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

            return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LhWqoeDWJ0g=")[iii % 8])).ToArray());
        }

        public void Dispose(string hxuJAsvl)
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

            _stream.Dispose();
        }
    }
}