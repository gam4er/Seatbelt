using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    public class O_4AED570F
    {
        private string CommandVersion { get; set; }

        protected O_4AED570F()
        {
            CommandVersion = Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("70hJNKsKUtU=")[iii % 8])).ToArray());
        }

        public void SetCommandVersion(string commandVersion)
        {
            CommandVersion = commandVersion;
        }

        public string GetCommandVersion()
        {
            return CommandVersion;
        }

        public void SetCommandVersion(string commandVersion, string WduUwicD)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.TaiwanCalendar instance = new System.Globalization.TaiwanCalendar();
                        instance.GetDayOfYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            CommandVersion = commandVersion;
        }

        public string GetCommandVersion(string jhpPRlQg)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.TaiwanCalendar instance = new System.Globalization.TaiwanCalendar();
                        instance.GetDayOfYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return CommandVersion;
        }
    }
}