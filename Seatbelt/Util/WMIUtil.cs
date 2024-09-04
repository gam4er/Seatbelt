using System;
using System.Management;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    public class O_88B64416
    {
        public static ManagementClass WMIRegConnection()
        {
            return WMIRegConnection(Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EBPBgFhj7K8=")[iii % 8])).ToArray()));
        }

        public static ManagementClass WMIRegConnection(string computerName)
        {
            return WMIRegConnection(computerName, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D9H2uu8LmMc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zDgUhbb+XW8=")[iii % 8])).ToArray()));
        }

        public static ManagementClass WMIRegConnection(string computerName, string userName, string password)
        {
            ManagementScope scope;
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;
            if (!String.IsNullOrEmpty(userName))
            {
                try
                {
                    if (userName.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WBBv0xmAlGM=")[iii % 8])).ToArray())))
                    {
                        string[] parts = userName.Split('\\');
                        connection.Username = parts[1];
                        connection.Authority = $"NTLMDOMAIN:{parts[0]}";
                    }
                    else
                    {
                        connection.Username = userName;
                    }

                    connection.Password = password;
                }
                catch
                {
                }
            }

            scope = new ManagementScope($"\\\\{computerName}\\root\\default", connection);
            scope.Connect();
            return new ManagementClass(scope, new ManagementPath(Encoding.UTF8.GetString(Convert.FromBase64String("HRbDKuoKwBYhFA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TmKneI9tkGQ=")[iii % 8])).ToArray())), null);
        }

        public static ManagementClass WMIRegConnection(string computerName, string nMsyHLmV)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.SecureString instance = new System.Security.SecureString();
                        instance.AppendChar('x');
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return WMIRegConnection(computerName, Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("D9H2uu8LmMc=")[iii % 8])).ToArray()), Encoding.UTF8.GetString(Convert.FromBase64String("").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zDgUhbb+XW8=")[iii % 8])).ToArray()));
        }

        public static ManagementClass WMIRegConnection(string computerName, string userName, string password, string PitUxYbc)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Security.SecureString instance = new System.Security.SecureString();
                        instance.AppendChar('x');
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            ManagementScope scope;
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;
            if (!String.IsNullOrEmpty(userName))
            {
                try
                {
                    if (userName.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("BA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WBBv0xmAlGM=")[iii % 8])).ToArray())))
                    {
                        string[] parts = userName.Split('\\');
                        connection.Username = parts[1];
                        connection.Authority = $"NTLMDOMAIN:{parts[0]}";
                    }
                    else
                    {
                        connection.Username = userName;
                    }

                    connection.Password = password;
                }
                catch
                {
                }
            }

            scope = new ManagementScope($"\\\\{computerName}\\root\\default", connection);
            scope.Connect();
            return new ManagementClass(scope, new ManagementPath(Encoding.UTF8.GetString(Convert.FromBase64String("HRbDKuoKwBYhFA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("TmKneI9tkGQ=")[iii % 8])).ToArray())), null);
        }
    }
}