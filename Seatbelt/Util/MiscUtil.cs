using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Util
{
    class MiscUtil
    {
        public static DateTime UnixEpochToDateTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            try
            {
                return epoch.AddMilliseconds(unixTime).ToLocalTime();
            }
            catch
            {
                return epoch;
            }
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            return first.Concat(second).ToArray();
        }

        public static bool IsBase64String(string s)
        {
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, Encoding.UTF8.GetString(Convert.FromBase64String("PTvOB9xAEnJTTZZ2jS5iAl4bnwaVfBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y2CvKqYBPyg=")[iii % 8])).ToArray()), RegexOptions.None);
        }

        public static IEnumerable<string> GetFileList(string fileSearchPatterns, string rootFolderPath)
        {
            string[] searchPatterns = fileSearchPatterns.Split('|');
            if (Directory.Exists(rootFolderPath))
            {
                Queue<string> pending = new Queue<string>();
                pending.Enqueue(rootFolderPath);
                string[] tmp;
                while (pending.Count > 0)
                {
                    rootFolderPath = pending.Dequeue();
                    foreach (string searchPattern in searchPatterns)
                    {
                        try
                        {
                            tmp = Directory.GetFiles(rootFolderPath, searchPattern);
                        }
                        catch
                        {
                            continue;
                        }

                        for (int i = 0; i < tmp.Length; i++)
                        {
                            yield return tmp[i];
                        }
                    }

                    try
                    {
                        tmp = Directory.GetDirectories(rootFolderPath);
                    }
                    catch
                    {
                        continue;
                    }

                    for (int i = 0; i < tmp.Length; i++)
                    {
                        pending.Enqueue(tmp[i]);
                    }
                }
            }
        }

        public static Regex[] GetProcessCmdLineRegex()
        {
            Regex[] processCmdLineRegex =
            {
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("4wo5XdUAbA+fJntgxgZrCa4aIkHKC3lV4QglY88EdxWfLC5HjU83").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y0lWM6NlHns=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("l/6lZHm+ap3auf8+e+V8gM2w7jp4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v5DAEFGQD+U=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("O4lxqsxUUSd2zivwzg9HOjPJPvc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E+cU3uR6NF8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("+Shx+Div20b/LmT5evWMRP47fe8g8IxE+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0UscnFPKom4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PB2x/X44SC1xR/27fDtEdTpE6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FG7ClVYWLVU=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("mr8J/mGkHMmcqgL+MP5Ry5+/WrUz6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ss96mxnBf+E=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("R2oX6ua/2W5bMkrq5r+TZ0EwSf++9JBx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bxpkj57aulg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("t4hCyLfxJ9PpnViP+rIl0O/fBYzs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n/8rpsWcD/0=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("KxHQY8azXFJmHtwki+5eU3NO2H7HtxsOZ0+GLZrqXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A2a5DbTAdHw=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("edl7bkSEv8k00WszD9O9yiHeLjQa1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UakOGjD9l+c=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("xV+Nvm6LPq2VStfiMIk9uJoP0Pc3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7S/+3R6jEMg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("ULAVeWSOoIkdoxkkL9mij1WrC3E9h+nUC/JcIzre").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eNt8DRD3iKc=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("TKvQEPoW1NMNp5FK7A/Vl1vnk0ymJdXTC7/cJ/sS1NsKvdAF5QTMkTeszSf7EtTbCr3QBeUEmZ5K45A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZMm5ZIl3sL4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("BVE+1MgQ0oQFHTTD2VqLzQccIZuSWZ0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTNRu7xztOM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("2ltTaVDYFlLaFlNjQYNMDdgVRjsKgFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8jg2GySqcyM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("n0KTnJOZW2HbCdiLn4kGN5kL257HwgUh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tyH27ufsLwg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("8ml3zRFzp+avaHfdTziw778kOopNOaW39Ccs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2g0FpGcW1Zc=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("7jMQtpLdzZyjNxK21IfLlqN/Wf3Wht7O6HxP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xlZm0/ypru4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("uLoK/fLg//u+uBfstr6y+b+tT6e1qA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kN1viZ+BnNM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("y733AAm5wWPL9OIeBeiLPcn19xEE+5o5yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("49qHZmDBtBM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("j+3ZMUzLlXPToocmUd3JIImghjMJlso2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p4qpQym44B8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("IuETYcSO2wlkpFx03Y+fXySmX2GFxJxJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CoxyEaXqtmA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("aNnbBGjPXAwlzNFYOZVeDzCOmlsv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QLS0cQa7dCI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("Mzne1Buxfxl1f5bCArA7TzV9ldda+zhZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G1e4p3rVEnA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("+/ZXCQOu87C26g9CCLD/9ey3DUMd6LT2+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("05knbG3Imtw=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("HN78rmMPNZwal6K6MUhvwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NL2PzRFmReg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("YjgAQylTVb05Y01OJVcP6WRhSwQtTgmkOmJDBXcb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SktjK10yJtY=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("6QyrOM6XXKe5GudzmJVdsuFR5GU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wX/OTLa/csI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("uFIcYZ3Dcqr+Rwo6x8NnprkeSzjG1j/tugg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kCFlEummH8M=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("AkT12j8rB5ECHvHJP21P0QAf5JF0blk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KjCUsVpEcP8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("XeXCHsWBQwUZuY0I1o8DVlu7jB2OxABA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dZGjba7qKmk=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("e1A/0g/NWzY2XCmYX41ZNyNFP8IXzAF8aQpmmA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyRMsWCjcxg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("UamZt3znS45R8JmsbLodzFP206F57w2BDK6A+3m6GMxT9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ed781AmTIuI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("3/zEd9TkSxGP7oAhmeZKBJb42mnYvgFO2aGA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("94upHrfMZXQ=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
            return processCmdLineRegex;
        }

        public static DateTime UnixEpochToDateTime(long unixTime, string UciwKNeF)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.FlushAsync(new System.Threading.CancellationToken());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            try
            {
                return epoch.AddMilliseconds(unixTime).ToLocalTime();
            }
            catch
            {
                return epoch;
            }
        }

        public static byte[] Combine(byte[] first, byte[] second, string RsTjRXXL)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.FlushAsync(new System.Threading.CancellationToken());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return first.Concat(second).ToArray();
        }

        public static bool IsBase64String(string s, string UEIUMUsH)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.FlushAsync(new System.Threading.CancellationToken());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, Encoding.UTF8.GetString(Convert.FromBase64String("PTvOB9xAEnJTTZZ2jS5iAl4bnwaVfBs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Y2CvKqYBPyg=")[iii % 8])).ToArray()), RegexOptions.None);
        }

        public static IEnumerable<string> GetFileList(string fileSearchPatterns, string rootFolderPath, string tDgLPokr)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.FlushAsync(new System.Threading.CancellationToken());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            string[] searchPatterns = fileSearchPatterns.Split('|');
            if (Directory.Exists(rootFolderPath))
            {
                Queue<string> pending = new Queue<string>();
                pending.Enqueue(rootFolderPath);
                string[] tmp;
                while (pending.Count > 0)
                {
                    rootFolderPath = pending.Dequeue();
                    foreach (string searchPattern in searchPatterns)
                    {
                        try
                        {
                            tmp = Directory.GetFiles(rootFolderPath, searchPattern);
                        }
                        catch
                        {
                            continue;
                        }

                        for (int i = 0; i < tmp.Length; i++)
                        {
                            yield return tmp[i];
                        }
                    }

                    try
                    {
                        tmp = Directory.GetDirectories(rootFolderPath);
                    }
                    catch
                    {
                        continue;
                    }

                    for (int i = 0; i < tmp.Length; i++)
                    {
                        pending.Enqueue(tmp[i]);
                    }
                }
            }
        }

        public static Regex[] GetProcessCmdLineRegex(string WoDBBlBE)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.IO.MemoryStream instance = new System.IO.MemoryStream();
                        instance.FlushAsync(new System.Threading.CancellationToken());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            Regex[] processCmdLineRegex =
            {
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("4wo5XdUAbA+fJntgxgZrCa4aIkHKC3lV4QglY88EdxWfLC5HjU83").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("y0lWM6NlHns=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("l/6lZHm+ap3auf8+e+V8gM2w7jp4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v5DAEFGQD+U=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("O4lxqsxUUSd2zivwzg9HOjPJPvc=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("E+cU3uR6NF8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("+Shx+Div20b/LmT5evWMRP47fe8g8IxE+A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0UscnFPKom4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("PB2x/X44SC1xR/27fDtEdTpE6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FG7ClVYWLVU=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("mr8J/mGkHMmcqgL+MP5Ry5+/WrUz6A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ss96mxnBf+E=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("R2oX6ua/2W5bMkrq5r+TZ0EwSf++9JBx").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("bxpkj57aulg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("t4hCyLfxJ9PpnViP+rIl0O/fBYzs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("n/8rpsWcD/0=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("KxHQY8azXFJmHtwki+5eU3NO2H7HtxsOZ0+GLZrqXQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A2a5DbTAdHw=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("edl7bkSEv8k00WszD9O9yiHeLjQa1A==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UakOGjD9l+c=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("xV+Nvm6LPq2VStfiMIk9uJoP0Pc3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7S/+3R6jEMg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("ULAVeWSOoIkdoxkkL9mij1WrC3E9h+nUC/JcIzre").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eNt8DRD3iKc=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("TKvQEPoW1NMNp5FK7A/Vl1vnk0ymJdXTC7/cJ/sS1NsKvdAF5QTMkTeszSf7EtTbCr3QBeUEmZ5K45A=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZMm5ZIl3sL4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("BVE+1MgQ0oQFHTTD2VqLzQccIZuSWZ0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LTNRu7xztOM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("2ltTaVDYFlLaFlNjQYNMDdgVRjsKgFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8jg2GySqcyM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("n0KTnJOZW2HbCdiLn4kGN5kL257HwgUh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tyH27ufsLwg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("8ml3zRFzp+avaHfdTziw778kOopNOaW39Ccs").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2g0FpGcW1Zc=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("7jMQtpLdzZyjNxK21IfLlqN/Wf3Wht7O6HxP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("xlZm0/ypru4=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("uLoK/fLg//u+uBfstr6y+b+tT6e1qA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kN1viZ+BnNM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("y733AAm5wWPL9OIeBeiLPcn19xEE+5o5yg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("49qHZmDBtBM=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("j+3ZMUzLlXPToocmUd3JIImghjMJlso2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("p4qpQym44B8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("IuETYcSO2wlkpFx03Y+fXySmX2GFxJxJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CoxyEaXqtmA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("aNnbBGjPXAwlzNFYOZVeDzCOmlsv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QLS0cQa7dCI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("Mzne1Buxfxl1f5bCArA7TzV9ldda+zhZ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("G1e4p3rVEnA=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("+/ZXCQOu87C26g9CCLD/9ey3DUMd6LT2+g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("05knbG3Imtw=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("HN78rmMPNZwal6K6MUhvwQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NL2PzRFmReg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("YjgAQylTVb05Y01OJVcP6WRhSwQtTgmkOmJDBXcb").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SktjK10yJtY=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("6QyrOM6XXKe5GudzmJVdsuFR5GU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wX/OTLa/csI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("uFIcYZ3Dcqr+Rwo6x8NnprkeSzjG1j/tugg=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kCFlEummH8M=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("AkT12j8rB5ECHvHJP21P0QAf5JF0blk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KjCUsVpEcP8=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("XeXCHsWBQwUZuY0I1o8DVlu7jB2OxABA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dZGjba7qKmk=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("e1A/0g/NWzY2XCmYX41ZNyNFP8IXzAF8aQpmmA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UyRMsWCjcxg=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("UamZt3znS45R8JmsbLodzFP206F57w2BDK6A+3m6GMxT9w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ed781AmTIuI=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline),
                new Regex(Encoding.UTF8.GetString(Convert.FromBase64String("3/zEd9TkSxGP7oAhmeZKBJb42mnYvgFO2aGA").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("94upHrfMZXQ=")[iii % 8])).ToArray()), RegexOptions.IgnoreCase & RegexOptions.Multiline)
            };
            return processCmdLineRegex;
        }
    }
}