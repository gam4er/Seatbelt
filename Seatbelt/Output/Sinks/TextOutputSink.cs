using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using O_F41F88FA.Commands;
using O_F41F88FA.Output.Formatters;
using O_F41F88FA.Output.TextWriters;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Output.Sinks
{
    internal class O_E6752F82 : IOutputSink
    {
        private readonly Dictionary<Type, TextFormatterBase> _customSinks = new Dictionary<Type, TextFormatterBase>();
        private readonly TextFormatterBase _defaultTextSink;
        private readonly ITextWriter _textWriter;
        private readonly bool _filterResults;
        public O_E6752F82(ITextWriter writer, bool filterResults)
        {
            _textWriter = writer;
            _filterResults = filterResults;
            _defaultTextSink = new O_AFCC99E5(_textWriter);
            InitializeCustomTextFormatters();
        }

        private static Assembly MyAssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            return System.Reflection.Assembly.GetExecutingAssembly();
        }

        private void InitializeCustomTextFormatters()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyAssemblyResolveEventHandler);
            foreach (var formatter in currentAssembly.GetTypes().Where(t => typeof(TextFormatterBase).IsAssignableFrom(t)))
            {
                var attributes = Attribute.GetCustomAttributes(formatter);
                foreach (var t in attributes)
                {
                    if (!(t is CommandOutputTypeAttribute))
                        continue;
                    var outputTypeAttr = (CommandOutputTypeAttribute)t;
                    if (_customSinks.ContainsKey(outputTypeAttr.Type))
                    {
                        throw new Exception($"Custom sink {outputTypeAttr.Type} already assigned to {_customSinks[outputTypeAttr.Type]}. Could not associate DTO with the another formatter({formatter})");
                    }

                    _customSinks.Add(outputTypeAttr.Type, (TextFormatterBase)Activator.CreateInstance(formatter, new object[] { _textWriter }));
                    break;
                }
            }
        }

        public void WriteOutput(O_4AED570F dto)
        {
            if (dto == null)
            {
                return;
            }

            var dtoType = dto.GetType();
            if (_customSinks.ContainsKey(dtoType))
            {
                _customSinks[dtoType].FormatResult(null, dto, _filterResults);
            }
            else
            {
                _defaultTextSink.FormatResult(null, dto, _filterResults);
            }
        }

        public void WriteVerbose(string message) => WriteOutput(new O_77AFBCF7(message));
        public void WriteWarning(string message) => WriteOutput(new O_56497D89(message));
        public void WriteError(string message) => WriteOutput(new O_DDA13DE3(message));
        public void WriteHost(string message) => WriteOutput(new O_75A28A1C(message));
        public string GetOutput()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CEA9kFM5kqs=")[iii % 8])).ToArray());
        }

        public void Dispose()
        {
            _textWriter.Dispose();
        }

        private static Assembly MyAssemblyResolveEventHandler(object sender, ResolveEventArgs args, string FYFSbulk)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(10);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return System.Reflection.Assembly.GetExecutingAssembly();
        }

        private void InitializeCustomTextFormatters(string ukqNqVMC)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(10);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var currentAssembly = Assembly.GetExecutingAssembly();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.AssemblyResolve += new ResolveEventHandler(MyAssemblyResolveEventHandler);
            foreach (var formatter in currentAssembly.GetTypes().Where(t => typeof(TextFormatterBase).IsAssignableFrom(t)))
            {
                var attributes = Attribute.GetCustomAttributes(formatter);
                foreach (var t in attributes)
                {
                    if (!(t is CommandOutputTypeAttribute))
                        continue;
                    var outputTypeAttr = (CommandOutputTypeAttribute)t;
                    if (_customSinks.ContainsKey(outputTypeAttr.Type))
                    {
                        throw new Exception($"Custom sink {outputTypeAttr.Type} already assigned to {_customSinks[outputTypeAttr.Type]}. Could not associate DTO with the another formatter({formatter})");
                    }

                    _customSinks.Add(outputTypeAttr.Type, (TextFormatterBase)Activator.CreateInstance(formatter, new object[] { _textWriter }));
                    break;
                }
            }
        }

        public void WriteOutput(O_4AED570F dto, string zTYexozQ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(10);
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
            if (_customSinks.ContainsKey(dtoType))
            {
                _customSinks[dtoType].FormatResult(null, dto, _filterResults);
            }
            else
            {
                _defaultTextSink.FormatResult(null, dto, _filterResults);
            }
        }

        public string GetOutput(string eQUSQqjX)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(10);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CEA9kFM5kqs=")[iii % 8])).ToArray());
        }

        public void Dispose(string nVJwzHwU)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Threading.CancellationTokenSource instance = new System.Threading.CancellationTokenSource();
                        instance.CancelAfter(10);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _textWriter.Dispose();
        }
    }
}