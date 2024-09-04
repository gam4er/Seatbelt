using O_F41F88FA.Commands;
using O_F41F88FA.Output.Sinks;
using O_F41F88FA.Output.TextWriters;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA
{
    public class O_F41F88FA : IDisposable
    {
        public bool FilterResults { get; }

        private readonly IOutputSink _outputSink;
        private readonly Runtime _runtime;
        private const string Version = "1.2.2";
        private O_F2A11310 Options { get; set; }

        public O_F41F88FA(string[] args)
        {
            Options = (new O_5579F5CE(args)).Parse();
            _outputSink = OutputSinkFromArgs(Options.OutputFile);
            _runtime = new Runtime(_outputSink, Options.Commands, Options.CommandGroups, Options.FilterResults, Options.RandomizeOrder, Options.DelayCommands, Options.ComputerName, Options.UserName, Options.Password);
        }

        public string GetOutput()
        {
            return _outputSink.GetOutput();
        }

        private IOutputSink OutputSinkFromArgs(string? outputFileArg)
        {
            if (outputFileArg == null)
                return new O_E6752F82(new O_132E9F90(), FilterResults);
            if (outputFileArg == string.Empty)
                throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("x6mCny5HAmzorpibLE8LKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jsf0/kIuZkw=")[iii % 8])).ToArray()));
            if (outputFileArg.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("cicmBYA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XE1Vau7VOhI=")[iii % 8])).ToArray())))
            {
                return new O_9BEF08AF(outputFileArg, FilterResults);
            }

            if (outputFileArg == Encoding.UTF8.GetString(Convert.FromBase64String("my5GmDd1Jc6fOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8V0p9kQBV6c=")[iii % 8])).ToArray()))
            {
                return new O_60BBEB9A(outputFileArg, FilterResults);
            }

            return new O_E6752F82(new O_2636E887(outputFileArg), FilterResults);
        }

        public void Start()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (!Options.Commands.Any() && !Options.CommandGroups.Any())
            {
                PrintLogo();
                Usage();
                return;
            }

            if (!Options.QuietMode)
                PrintLogo();
            _runtime.Execute();
            watch.Stop();
            if (!Options.QuietMode)
            {
                _outputSink.WriteVerbose($"\n\n[*] Completed collection in {(watch.ElapsedMilliseconds / 1000.0)} seconds\n");
            }
        }

        public void PrintLogo()
        {
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("aqlv78UAu89Ag2/vxQC7z0CDb+/FALvPQINq6cNg269GhW/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YKNPz+Ugm+8=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("0Q7c5nnTytfRDtzmedPK19EO3OZ508rX1wja4H/VzNLUC9DmedPK19EO3OZ508rX0Q7c5nnTytfRDt/gf7Oqt7FuvON81s/S1A3f5XrQydTSDd/letDJ1NQO3OZ508rX0Q7c5nnTytfRDtzmedPK19EO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8S78xlnz6vc=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("GGJJl8Kr2NAYYkmXwqvY0BhiSZfCq9jQHmdPl8Kr3dYdZ0mXwqvY0BhiSZfCq9jQGGJJl8Kr2NAYYk+YzaTX2BBqT5LHrt3VG2dKlMGo29MbYUqUwajb0xthRpjKo9DYG2FKkseu3dUdZ0ySx67d1R1n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OEJpt+KL+PA=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("i5PTuVAu+B6Lk9O/Vij+GI2T07lWLvgYjZXVuVUr+x6LnNy/VSv9G46W1rxVK/0bjpbWvFUr/RuOlrazWiTyE4ae0LlQLvgei5XVv1Yo/hiNldW/Vij+GI2V1b9WKP4Thp7etF0j9ROGnt60XSP1E4ae").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rrb2nHUL3Ts=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("SRzhOBNVhXRPHOE+FVODckkc4TgTU4NySRrhPhZQhXdPFe4xGlyMfUYV7jEaXIx9RhniPRZQgHFKGYIyGV+PeUIR5DgTVYV0SRzhPhVTg3JJGuE+FVODckka4T4VU4N5QhHqNR5YiHlCEeo1HliIeUIR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ajnCHTZwoFE=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("bsjGT9Nm8uxozsZJ1WDy7G7Ixk/TYPTqbs7GSdZj8uxowclG2m/76W3ByUTWY/flYc3FStZj9+ltzaVF2Wz44WXFw0/TZvLsaMjGSdVg9OpuzsZJ1WD06m7OxknVYPTqZc7NQt5g/+plxc1C3mv/4WXF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Te3lavZD18k=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DQEQ5eJ36vsNARDl4nHs/Q0BEOXicez9DQEQ5eFy6fsLDB3o73zh/g4MHejhcu/wAAIT5uFy7/4OAnPp7n3g9gYKFePkd+r7CwcQ5eJx7P0NARDl4nHs/Q0HEOXicez9BgoQ7uJ67P0NARvu6Xrn9gYK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LiIzxsFSz94=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("F6v1l8UIKmoXq/WXxQgqbBer85fFCCpsF6v1l8YLLGoRpviayAUnbxSm+JrGCylhGqj2lMYLKW8UqJabyQQmZxyg8JHDDixqF6v1l8UIKmwXq/WXxQgqbBer9ZfFCCpsF6D1nMUIKmwXq/WczggqbBer").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NIjWtOYrCU8=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("cYOjHDqqLB1xg6MaOqoqG3GDoxo6qiobcYOjGjmpLx13jq4XN6cnFnyOrhc3pycWcoCgGTmpKRhygMAWNqYmEHqIphw8rCwdd4WlGjqqKhtxg6MaOqoqG3GFoxo6qiobcYijGjqqKhtxg6MRMaoqG3GD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UqCAORmJCTg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("qw6aBAcpbPKrDpoEBy9s8qsOmgQHL2zyqw6aBAQsavStA5cHBCxv8agNmQcELG/xqA2ZBwQsb/GoDfkICyNg+aAFnwIBKWr0rQiaBAcvbPKrDpoEBy9s8qsOmQcELG/xqA2ZBwQsb/GoDZkHBCxv8agN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iC25JyQMT9E=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Jr3HZSQ1DmMmvcdlJDUOYya9x2UkNQ5jILjBZSQ1C2YjuMJlJDUOYybOgiRwd0svcr3HZSQ1DmMmvcJqKzoBay61wWAhMAtmI7jCZic2DWAlvsRmJzYNYCy9x2UkNQ5jJr3HZSQ1DmMmvcdlJDUOYya9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bp3nRQQVLkM=")[iii % 8])).ToArray()));
            _outputSink.WriteHost($"                        &%%&&&%%%%%        v{Version}         ,(((&%%%%%%%%%%%%%%%%%,                                 ");
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("VwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwtDhF8sX5dbCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIbKs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dyhmoXoJfLQ=")[iii % 8])).ToArray()));
        }

        private void Usage()
        {
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("mAggQbktTCC8XiJHuCFPIr0NYQD+bEMpuBAyCKcpQyOtG2Fdpi1JKfkXMgimOV48tgw1TbFlFEY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2X5BKNVMLkw=")[iii % 8])).ToArray()));
            _runtime.AllCommands.ForEach(c =>
            {
                if (c.SupportRemote)
                {
                    _outputSink.WriteHost($"    + {c.Command, -22} - {c.Description}");
                }
                else
                {
                    _outputSink.WriteHost($"      {c.Command, -22} - {c.Description}");
                }
            });
            var commandGroups = Enum.GetNames(typeof(CommandGroup)).ToArray();
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DmKE0hbqy8FoHPffFu2J0GwN99EY8sXLcwG50Ff9xslpCbnTV/nby3EYpI1X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BGjXt3eeqaQ=")[iii % 8])).ToArray()) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("qEo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hGpZAzeoDLI=")[iii % 8])).ToArray()), commandGroups));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dn8y8Bun651cPHO+G5fqnhM0d/BYkemFHTF28FyM650MLDKnUorsyFx/MvAb3qTIXgx3sU+c4YQIcXeoXt64jw4wZ6AF3I4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fF8S0Dv+hOg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("vNgrkNcqXVzVl2bdlgtLXNGKZMWHFg8ZzptuwINFXAzTm2LWngYPH9mVZtGZAVxclKtu0YMHShDC1m7IkkUTG8SXfsDJRQI/2ZVm0ZkBDXY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tvgLsPdlL3w=")[iii % 8])).ToArray()));
            var sb = new StringBuilder();
            foreach (var group in commandGroups)
            {
                if (group == Encoding.UTF8.GetString(Convert.FromBase64String("n9Cv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3rzDhwlK+5Y=")[iii % 8])).ToArray()))
                {
                    sb.Append($"   \"Seatbelt.exe -group={group.ToLower()}\" runs all commands\n\n");
                    continue;
                }

                sb.Append($"   \"Seatbelt.exe -group={group.ToLower()}\" runs the following commands:\n\n        ");
                var groupCommands = _runtime.AllCommands.Where(c => c.Group.Contains((CommandGroup)Enum.Parse(typeof(CommandGroup), group))).Select(c => c.Command).ToArray();
                for (var i = 0; i < groupCommands.Length; i++)
                {
                    sb.Append(groupCommands[i]);
                    if (i != groupCommands.Length - 1)
                    {
                        sb.Append(Encoding.UTF8.GetString(Convert.FromBase64String("PkE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EmGy8SukblY=")[iii % 8])).ToArray()));
                    }

                    if (i % 4 == 0 && i != 0)
                    {
                        sb.Append(Encoding.UTF8.GetString(Convert.FromBase64String("4gbTCOgWCCXI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CbzKMg2KAU=")[iii % 8])).ToArray()));
                    }
                }

                sb.AppendLine(Encoding.UTF8.GetString(Convert.FromBase64String("bQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z06OuI+CtAo=")[iii % 8])).ToArray()));
            }

            _outputSink.WriteHost(sb.ToString());
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("uQvro89//7rG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/HOKzr8Tmsk=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("S2WXpWTtavkfJ9LpN5Bq4A5li8Ys02L5BSGJpRj9YPUGJNnhceMvtkVrkKU012P0SzfC62PRYf1LKsWlLtF9/Us2x+Ag12nxDiGX5ivbbPMYZdjrL8c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a0W3hUO+D5g=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("OzCxBcMVYKlvcvRJkGhgsH4wrWaLK2ipdXSvBckgcKR3N7FSjSpp6Gl15VCWKCWrdH3hSYEyYOhpdeJQiDJ26H1/4wWFZmandn3wS4BmcqFveP5QkGZkpmIw90yIMmC6cn72Cw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GxCRJeRGBcg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("JQJ1ouBNzV1xQDDuszDNRGACd76EccVRZEwxvOdFyU5iVzjnqWr1HiICIuurcohMZFEmoqZwiF13RSDvonDcHHFNdePnfcdRaEM75udqwF1xAib3t27HTnFRdeuzPoBSalYworN2zRx0Vzr2om2BEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BSJVgsceqDw=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("yIDBBFBCnP+cwoRIAz+c5o2AzEMFfozu1cGNSFAxjveEzMFWAn/Z36TswUEZZJT7msGVTRh/2f2AxYJPBD3Z/YnOwUYSMZrxhcKIShJ12emB1IkEVTyf64TMwwo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6KDhJHcR+Z4=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("VvhKHBEZ0HoCug9QQmTQYxP4R1tEJcBrS7kGUBZn9G4SsR5sWSbceB+9GRsWPdx3GvgYSVhq1Hca+A9SQyfQaResA1NYatZzE7sBTxYP7VgziD4cdz/RcgKIBVBfKdx+BfRKX1cklXkT+AlTWyjcdRO8SktfPt07VPUMSVomlzU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dthqPDZKtRs=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("+xRyQamCI+qvVjcN+v8j874UbiLhvCvqtVBsQaOyKearQSYE/L8n5r4JES7DgRPfnmZ8JcGcB8KVGhEuw/Edpq5HNxPgsCvu5nAdLM+YCNeOZxczrvw26qhHJQ78tXvbmmcBNsGDAtb8FCUI4r1m+a5acgDg8Sf7q1g7Au+zKu77VzoE7bpm+b5ZPRXrvT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2zRSYY7RRos=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("gSq2zUejfPrVaPOBFN5848Qqu4oSn2zrnHjzgA+EfLuMafmAEIVt/tNk94AFzVrU7FrDuSWiN9/uR9ekLt5a1OwqzcAVg3zpz2v7iF20VtbgQ9ixNaNcyYEn5owTg270026rvSGjSszuWNKwR9Bu8s1mtp8VnjnpxGf5mQXQauvEaf+LCZM5+Mlv9YYT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oQqW7WDwGZs=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dttQjbRWSPAimRXB5ytI6TPbXcrhaljha4gJ3udgQLF7lAXZ43BZ9z+XFZCxRhfNAp4d3c9qWOV4jwjZsSIN5j+XHI3hcEOxJYID2fZoDfI+nhPG4CVM/zLbH9jndVjldo8fjfIlA+Uuj1DL+mlIvw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VvtwrZMFLZE=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("kzk5dS1FffvHe3w5fjh94tY5NDJ4eW3qjmxqMHg2NeuTNHYgfmZt7tVwdTA3NFug7018OHpKd+/HN3MmZXg6vZNucDlmNmrv3TlwOypnbfPWbTk4ZXJ9usRwbT0qY2v/wTl6PW91c+mTeHcxKnlt7sNsbXV+eTj7kzdzJmV4OPzadXx7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sxkZVQoWGJo=")[iii % 8])).ToArray()));
        }

        public void Dispose()
        {
            _outputSink.Dispose();
        }

        public string GetOutput(string vTWmbpqH)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            return _outputSink.GetOutput();
        }

        private IOutputSink OutputSinkFromArgs(string? outputFileArg, string DOyCaPcj)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            if (outputFileArg == null)
                return new O_E6752F82(new O_132E9F90(), FilterResults);
            if (outputFileArg == string.Empty)
                throw new Exception(Encoding.UTF8.GetString(Convert.FromBase64String("x6mCny5HAmzorpibLE8LKQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jsf0/kIuZkw=")[iii % 8])).ToArray()));
            if (outputFileArg.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("cicmBYA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XE1Vau7VOhI=")[iii % 8])).ToArray())))
            {
                return new O_9BEF08AF(outputFileArg, FilterResults);
            }

            if (outputFileArg == Encoding.UTF8.GetString(Convert.FromBase64String("my5GmDd1Jc6fOg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8V0p9kQBV6c=")[iii % 8])).ToArray()))
            {
                return new O_60BBEB9A(outputFileArg, FilterResults);
            }

            return new O_E6752F82(new O_2636E887(outputFileArg), FilterResults);
        }

        public void Start(string yHherJnZ)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (!Options.Commands.Any() && !Options.CommandGroups.Any())
            {
                PrintLogo();
                Usage();
                return;
            }

            if (!Options.QuietMode)
                PrintLogo();
            _runtime.Execute();
            watch.Stop();
            if (!Options.QuietMode)
            {
                _outputSink.WriteVerbose($"\n\n[*] Completed collection in {(watch.ElapsedMilliseconds / 1000.0)} seconds\n");
            }
        }

        public void PrintLogo(string cTmHnsMO)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("aqlv78UAu89Ag2/vxQC7z0CDb+/FALvPQINq6cNg269GhW/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+/FALvPQINv78UAu89Ag2/vxQC7z0CDb+8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YKNPz+Ugm+8=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("0Q7c5nnTytfRDtzmedPK19EO3OZ508rX1wja4H/VzNLUC9DmedPK19EO3OZ508rX0Q7c5nnTytfRDt/gf7Oqt7FuvON81s/S1A3f5XrQydTSDd/letDJ1NQO3OZ508rX0Q7c5nnTytfRDtzmedPK19EO").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8S78xlnz6vc=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("GGJJl8Kr2NAYYkmXwqvY0BhiSZfCq9jQHmdPl8Kr3dYdZ0mXwqvY0BhiSZfCq9jQGGJJl8Kr2NAYYk+YzaTX2BBqT5LHrt3VG2dKlMGo29MbYUqUwajb0xthRpjKo9DYG2FKkseu3dUdZ0ySx67d1R1n").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OEJpt+KL+PA=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("i5PTuVAu+B6Lk9O/Vij+GI2T07lWLvgYjZXVuVUr+x6LnNy/VSv9G46W1rxVK/0bjpbWvFUr/RuOlrazWiTyE4ae0LlQLvgei5XVv1Yo/hiNldW/Vij+GI2V1b9WKP4Thp7etF0j9ROGnt60XSP1E4ae").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rrb2nHUL3Ts=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("SRzhOBNVhXRPHOE+FVODckkc4TgTU4NySRrhPhZQhXdPFe4xGlyMfUYV7jEaXIx9RhniPRZQgHFKGYIyGV+PeUIR5DgTVYV0SRzhPhVTg3JJGuE+FVODckka4T4VU4N5QhHqNR5YiHlCEeo1HliIeUIR").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ajnCHTZwoFE=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("bsjGT9Nm8uxozsZJ1WDy7G7Ixk/TYPTqbs7GSdZj8uxowclG2m/76W3ByUTWY/flYc3FStZj9+ltzaVF2Wz44WXFw0/TZvLsaMjGSdVg9OpuzsZJ1WD06m7OxknVYPTqZc7NQt5g/+plxc1C3mv/4WXF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Te3lavZD18k=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DQEQ5eJ36vsNARDl4nHs/Q0BEOXicez9DQEQ5eFy6fsLDB3o73zh/g4MHejhcu/wAAIT5uFy7/4OAnPp7n3g9gYKFePkd+r7CwcQ5eJx7P0NARDl4nHs/Q0HEOXicez9BgoQ7uJ67P0NARvu6Xrn9gYK").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LiIzxsFSz94=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("F6v1l8UIKmoXq/WXxQgqbBer85fFCCpsF6v1l8YLLGoRpviayAUnbxSm+JrGCylhGqj2lMYLKW8UqJabyQQmZxyg8JHDDixqF6v1l8UIKmwXq/WXxQgqbBer9ZfFCCpsF6D1nMUIKmwXq/WczggqbBer").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NIjWtOYrCU8=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("cYOjHDqqLB1xg6MaOqoqG3GDoxo6qiobcYOjGjmpLx13jq4XN6cnFnyOrhc3pycWcoCgGTmpKRhygMAWNqYmEHqIphw8rCwdd4WlGjqqKhtxg6MaOqoqG3GFoxo6qiobcYijGjqqKhtxg6MRMaoqG3GD").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UqCAORmJCTg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("qw6aBAcpbPKrDpoEBy9s8qsOmgQHL2zyqw6aBAQsavStA5cHBCxv8agNmQcELG/xqA2ZBwQsb/GoDfkICyNg+aAFnwIBKWr0rQiaBAcvbPKrDpoEBy9s8qsOmQcELG/xqA2ZBwQsb/GoDZkHBCxv8agN").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("iC25JyQMT9E=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("Jr3HZSQ1DmMmvcdlJDUOYya9x2UkNQ5jILjBZSQ1C2YjuMJlJDUOYybOgiRwd0svcr3HZSQ1DmMmvcJqKzoBay61wWAhMAtmI7jCZic2DWAlvsRmJzYNYCy9x2UkNQ5jJr3HZSQ1DmMmvcdlJDUOYya9").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Bp3nRQQVLkM=")[iii % 8])).ToArray()));
            _outputSink.WriteHost($"                        &%%&&&%%%%%        v{Version}         ,(((&%%%%%%%%%%%%%%%%%,                                 ");
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("VwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwtDhF8sX5dbCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIRoFaKVyUVwhGgVopXJRXCEaBWilclFcIbKs=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dyhmoXoJfLQ=")[iii % 8])).ToArray()));
        }

        private void Usage(string PgSfQBgp)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("mAggQbktTCC8XiJHuCFPIr0NYQD+bEMpuBAyCKcpQyOtG2Fdpi1JKfkXMgimOV48tgw1TbFlFEY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2X5BKNVMLkw=")[iii % 8])).ToArray()));
            _runtime.AllCommands.ForEach(c =>
            {
                if (c.SupportRemote)
                {
                    _outputSink.WriteHost($"    + {c.Command, -22} - {c.Description}");
                }
                else
                {
                    _outputSink.WriteHost($"      {c.Command, -22} - {c.Description}");
                }
            });
            var commandGroups = Enum.GetNames(typeof(CommandGroup)).ToArray();
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("DmKE0hbqy8FoHPffFu2J0GwN99EY8sXLcwG50Ff9xslpCbnTV/nby3EYpI1X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BGjXt3eeqaQ=")[iii % 8])).ToArray()) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String("qEo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hGpZAzeoDLI=")[iii % 8])).ToArray()), commandGroups));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dn8y8Bun651cPHO+G5fqnhM0d/BYkemFHTF28FyM650MLDKnUorsyFx/MvAb3qTIXgx3sU+c4YQIcXeoXt64jw4wZ6AF3I4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("fF8S0Dv+hOg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("vNgrkNcqXVzVl2bdlgtLXNGKZMWHFg8ZzptuwINFXAzTm2LWngYPH9mVZtGZAVxclKtu0YMHShDC1m7IkkUTG8SXfsDJRQI/2ZVm0ZkBDXY=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tvgLsPdlL3w=")[iii % 8])).ToArray()));
            var sb = new StringBuilder();
            foreach (var group in commandGroups)
            {
                if (group == Encoding.UTF8.GetString(Convert.FromBase64String("n9Cv").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3rzDhwlK+5Y=")[iii % 8])).ToArray()))
                {
                    sb.Append($"   \"Seatbelt.exe -group={group.ToLower()}\" runs all commands\n\n");
                    continue;
                }

                sb.Append($"   \"Seatbelt.exe -group={group.ToLower()}\" runs the following commands:\n\n        ");
                var groupCommands = _runtime.AllCommands.Where(c => c.Group.Contains((CommandGroup)Enum.Parse(typeof(CommandGroup), group))).Select(c => c.Command).ToArray();
                for (var i = 0; i < groupCommands.Length; i++)
                {
                    sb.Append(groupCommands[i]);
                    if (i != groupCommands.Length - 1)
                    {
                        sb.Append(Encoding.UTF8.GetString(Convert.FromBase64String("PkE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EmGy8SukblY=")[iii % 8])).ToArray()));
                    }

                    if (i % 4 == 0 && i != 0)
                    {
                        sb.Append(Encoding.UTF8.GetString(Convert.FromBase64String("4gbTCOgWCCXI").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6CbzKMg2KAU=")[iii % 8])).ToArray()));
                    }
                }

                sb.AppendLine(Encoding.UTF8.GetString(Convert.FromBase64String("bQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Z06OuI+CtAo=")[iii % 8])).ToArray()));
            }

            _outputSink.WriteHost(sb.ToString());
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("uQvro89//7rG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/HOKzr8Tmsk=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("S2WXpWTtavkfJ9LpN5Bq4A5li8Ys02L5BSGJpRj9YPUGJNnhceMvtkVrkKU012P0SzfC62PRYf1LKsWlLtF9/Us2x+Ag12nxDiGX5ivbbPMYZdjrL8c=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a0W3hUO+D5g=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("OzCxBcMVYKlvcvRJkGhgsH4wrWaLK2ipdXSvBckgcKR3N7FSjSpp6Gl15VCWKCWrdH3hSYEyYOhpdeJQiDJ26H1/4wWFZmandn3wS4BmcqFveP5QkGZkpmIw90yIMmC6cn72Cw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GxCRJeRGBcg=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("JQJ1ouBNzV1xQDDuszDNRGACd76EccVRZEwxvOdFyU5iVzjnqWr1HiICIuurcohMZFEmoqZwiF13RSDvonDcHHFNdePnfcdRaEM75udqwF1xAib3t27HTnFRdeuzPoBSalYworN2zRx0Vzr2om2BEg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BSJVgsceqDw=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("yIDBBFBCnP+cwoRIAz+c5o2AzEMFfozu1cGNSFAxjveEzMFWAn/Z36TswUEZZJT7msGVTRh/2f2AxYJPBD3Z/YnOwUYSMZrxhcKIShJ12emB1IkEVTyf64TMwwo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6KDhJHcR+Z4=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("VvhKHBEZ0HoCug9QQmTQYxP4R1tEJcBrS7kGUBZn9G4SsR5sWSbceB+9GRsWPdx3GvgYSVhq1Hca+A9SQyfQaResA1NYatZzE7sBTxYP7VgziD4cdz/RcgKIBVBfKdx+BfRKX1cklXkT+AlTWyjcdRO8SktfPt07VPUMSVomlzU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("dthqPDZKtRs=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("+xRyQamCI+qvVjcN+v8j874UbiLhvCvqtVBsQaOyKearQSYE/L8n5r4JES7DgRPfnmZ8JcGcB8KVGhEuw/Edpq5HNxPgsCvu5nAdLM+YCNeOZxczrvw26qhHJQ78tXvbmmcBNsGDAtb8FCUI4r1m+a5acgDg8Sf7q1g7Au+zKu77VzoE7bpm+b5ZPRXrvT8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2zRSYY7RRos=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("gSq2zUejfPrVaPOBFN5848Qqu4oSn2zrnHjzgA+EfLuMafmAEIVt/tNk94AFzVrU7FrDuSWiN9/uR9ekLt5a1OwqzcAVg3zpz2v7iF20VtbgQ9ixNaNcyYEn5owTg270026rvSGjSszuWNKwR9Bu8s1mtp8VnjnpxGf5mQXQauvEaf+LCZM5+Mlv9YYT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("oQqW7WDwGZs=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("dttQjbRWSPAimRXB5ytI6TPbXcrhaljha4gJ3udgQLF7lAXZ43BZ9z+XFZCxRhfNAp4d3c9qWOV4jwjZsSIN5j+XHI3hcEOxJYID2fZoDfI+nhPG4CVM/zLbH9jndVjldo8fjfIlA+Uuj1DL+mlIvw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VvtwrZMFLZE=")[iii % 8])).ToArray()));
            _outputSink.WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("kzk5dS1FffvHe3w5fjh94tY5NDJ4eW3qjmxqMHg2NeuTNHYgfmZt7tVwdTA3NFug7018OHpKd+/HN3MmZXg6vZNucDlmNmrv3TlwOypnbfPWbTk4ZXJ9usRwbT0qY2v/wTl6PW91c+mTeHcxKnlt7sNsbXV+eTj7kzdzJmV4OPzadXx7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sxkZVQoWGJo=")[iii % 8])).ToArray()));
        }

        public void Dispose(string AVhLbdXG)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.GetYear(new System.DateTime());
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            _outputSink.Dispose();
        }
    }
}