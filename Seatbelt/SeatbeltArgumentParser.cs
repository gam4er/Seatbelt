using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA
{
    class O_5579F5CE
    {
        private string[] Arguments { get; set; }

        public O_5579F5CE(string[] args)
        {
            Arguments = args;
        }

        public O_F2A11310 Parse()
        {
            var originalArgs = Arguments;
            try
            {
                var quietMode = ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("fJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ue4r86IByqU=")[iii % 8])).ToArray()));
                var filterResults = !ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Mj6tSJw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H3jYJPAAznA=")[iii % 8])).ToArray()));
                var randomizeOrder = ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("35O7EsbaaNOIpJUOxtB3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8sHafKK1Bbo=")[iii % 8])).ToArray()));
                var commandGroups = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Y/P70oRm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TrSJvfEWwk0=")[iii % 8])).ToArray()));
                var outputFile = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("/nJ7Y7EIh3u6UWs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0z0OF8F98z0=")[iii % 8])).ToArray()));
                var computerName = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("6aOzfHSZ8Pi2rr18YQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xODcEQTshJ0=")[iii % 8])).ToArray()));
                var userName = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Zp/bTb09P68u").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S8qoKM9TXsI=")[iii % 8])).ToArray()));
                var password = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("D1BxOrhtURRG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IgAQScsaPmY=")[iii % 8])).ToArray()));
                var delayCommands = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("9f5f90GNQhS111v1RIc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2Lo6myD0AXs=")[iii % 8])).ToArray()));
                return new O_F2A11310(Arguments.ToList(), commandGroups == null ? new List<string>() : commandGroups.Split(',').Select(g => g.Trim()).ToList(), outputFile, filterResults, randomizeOrder, quietMode, delayCommands, computerName, userName, password);
            }
            finally
            {
                Arguments = originalArgs;
            }
        }

        private bool ParseAndRemoveSwitchArgument(string key)
        {
            if (Arguments.Contains(key, StringComparer.CurrentCultureIgnoreCase))
            {
                Arguments = Arguments.Where(c => c.ToLower() != key.ToLower()).ToArray();
                return true;
            }

            return false;
        }

        private string? ParseAndRemoveKeyValueArgument(string key)
        {
            var arg = Arguments.FirstOrDefault(c => c.ToLower().StartsWith($"{key.ToLower()}="));
            if (string.IsNullOrEmpty(arg))
                return null;
            try
            {
                var value = arg.Substring(arg.IndexOf('=') + 1);
                Arguments = Arguments.Where(c => !c.ToLower().StartsWith(key.ToLower())).ToArray();
                return value;
            }
            catch (Exception e)
            {
                throw new Exception($"Error parsing password argument \"{key}\": {e}");
            }
        }

        public O_F2A11310 Parse(string YytByceE)
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

            var originalArgs = Arguments;
            try
            {
                var quietMode = ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("fJ8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Ue4r86IByqU=")[iii % 8])).ToArray()));
                var filterResults = !ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Mj6tSJw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("H3jYJPAAznA=")[iii % 8])).ToArray()));
                var randomizeOrder = ParseAndRemoveSwitchArgument(Encoding.UTF8.GetString(Convert.FromBase64String("35O7EsbaaNOIpJUOxtB3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8sHafKK1Bbo=")[iii % 8])).ToArray()));
                var commandGroups = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Y/P70oRm").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TrSJvfEWwk0=")[iii % 8])).ToArray()));
                var outputFile = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("/nJ7Y7EIh3u6UWs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0z0OF8F98z0=")[iii % 8])).ToArray()));
                var computerName = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("6aOzfHSZ8Pi2rr18YQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xODcEQTshJ0=")[iii % 8])).ToArray()));
                var userName = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("Zp/bTb09P68u").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S8qoKM9TXsI=")[iii % 8])).ToArray()));
                var password = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("D1BxOrhtURRG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("IgAQScsaPmY=")[iii % 8])).ToArray()));
                var delayCommands = ParseAndRemoveKeyValueArgument(Encoding.UTF8.GetString(Convert.FromBase64String("9f5f90GNQhS111v1RIc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2Lo6myD0AXs=")[iii % 8])).ToArray()));
                return new O_F2A11310(Arguments.ToList(), commandGroups == null ? new List<string>() : commandGroups.Split(',').Select(g => g.Trim()).ToList(), outputFile, filterResults, randomizeOrder, quietMode, delayCommands, computerName, userName, password);
            }
            finally
            {
                Arguments = originalArgs;
            }
        }

        private bool ParseAndRemoveSwitchArgument(string key, string IZyBzAmh)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.IsLeapDay(31, 38, 36, 22);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (Arguments.Contains(key, StringComparer.CurrentCultureIgnoreCase))
            {
                Arguments = Arguments.Where(c => c.ToLower() != key.ToLower()).ToArray();
                return true;
            }

            return false;
        }

        private string? ParseAndRemoveKeyValueArgument(string key, string CAUynPck)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.ThaiBuddhistCalendar instance = new System.Globalization.ThaiBuddhistCalendar();
                        instance.IsLeapDay(31, 38, 36, 22);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var arg = Arguments.FirstOrDefault(c => c.ToLower().StartsWith($"{key.ToLower()}="));
            if (string.IsNullOrEmpty(arg))
                return null;
            try
            {
                var value = arg.Substring(arg.IndexOf('=') + 1);
                Arguments = Arguments.Where(c => !c.ToLower().StartsWith(key.ToLower())).ToArray();
                return value;
            }
            catch (Exception e)
            {
                throw new Exception($"Error parsing password argument \"{key}\": {e}");
            }
        }
    }
}