using System.Linq;
using System.Collections.Generic;
using O_F41F88FA.Output.TextWriters;
using O_F41F88FA.Output.Formatters;
using System;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
internal class O_0D077059 : O_2183A68D
{
    public override string Command => Encoding.UTF8.GetString(Convert.FromBase64String("/Uqj7pDG").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sQXvrNGVkHg=")[iii % 8])).ToArray());
    public override string Description => Encoding.UTF8.GetString(Convert.FromBase64String("D4X/dj3q4UgPg+p+J+iyJyWMvEMh6rIkIoT4Nwvm/Akxg/lkae78DGO5/2Ug/+YbY8LQWAXN0ztqyvN5afv6DWOZ5WQ96v9GY6TzYyy1shwigflkaeH9Bm6e7n4/5vMEY571eiyh").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q+qcF0mPkmg=")[iii % 8])).ToArray());
    public override CommandGroup[] Group => new[]
    {
        CommandGroup.Misc
    };
    public override bool SupportRemote => false;

    private static readonly HashSet<string> Lolbas = new HashSet<string>()
    {
        Encoding.UTF8.GetString(Convert.FromBase64String("O73rV9MInNY+tfE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WtmdJ7Jr9/g=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("5XltCmt2g2/8bA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hAkdfAcGrQo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("t+1jNX0U").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1plNUAVxIs4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("edNTPHuN5Hc2wkkr").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GKcxThTmgQU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("hPYuDbuh1KA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("5pddZZXErMU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("N+QO8V8Mnvkt5g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VYNnnzljsJw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("apmrCTSPGkZm3roCMA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("CPDfelXrdy8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("41Ykr8aw7nDhThKpxujxYLE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("gDp7xqjGgRM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("sAlzt80IsOulAF6z3hWw4aBLXKmJ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("02Us2rh81ZM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("vajWLn6MeQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3sy0ABv0HKk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("TcA+DcnmJnwAwDQc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("LqVMebySTxA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("PbU5GGJZUA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XthdNgchNRA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("5VfUyPu4tUb+Xw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("hjqwo57BmyM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("eGmjhfhT9ah+").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("GwTQ8Yh9kNA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("qnuI5ENUde6teIk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yRTllzU3BsA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2AWHGe6i1vreEow=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("u2rpbZzNutQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("dfeB6ObzWQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FoTixoOLPDw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("06Ony5rvgDfVqKE=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sNDEufOf9Bk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("8hr5gJQovVn7GO6ElymhVORR75OF").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ln+K6+BHzTA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("+JVD0ykupunwkUDJJSmv6LKVTcI=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nPA1p0ZBypo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Z7ceD7wh861m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("A9Fted8PltU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("LNvIlXNJWcknxZWbeEQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("SLK7/gAhOK0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("HFgf6zOFgUsAUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("eDZsiF7hry4=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("SgJ0IllnzTFWCA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Lm0ATDwT41Q=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("A2hw457LnUAC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZxATgu7l+Dg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("DaKCptYfVgtGtJ+t").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aNHnyKJqImc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("mLpGsiiQXpbTqVu5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("/cwj3FzmKeQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pKKWJxcw/mKk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wdr1Qnsemxo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("WXtrgsPdGcpEZg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PAMb4625N68=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2hu1S2LObFLLTaRWfw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("v2PBLhq+AyA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("dMsIpKS5F/4/1gSz").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EbN81sXaJMw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pk4iLei7NGqlXyk=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wCdMSZvPRkQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("M11tem0fhaJ7V2d5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VTIfHARz4NE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("rq52fOsGdg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yNoGUo5+Ezs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("YtHw9RmiwC9q1uzmBLTeM2DFpvQOsA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BbeIkXbVrkM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("XqodSXaURrgXvxZP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("OdpuKgT9Nsw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("8Wr3ubgP").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mQLZ3MBq+aw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("q4QfpkpKk4LshFO2").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wuEr0yMk+vY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("CRL2qXqhH14LWfOhYA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YHeXzQzRfj0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("voB2TgxU1Cb5gXtE").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1+UXKH41uUM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("OMRI3WjumMApxA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UaEtpQ2NtqU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("uPoViV5rdVK0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0ZZ0+jNFECo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("1AFMkde9htzRG0Obwa+GxdFBT43X").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vW8q9bLb56k=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Pkdz6WjFyw0jQGyzbNHC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VykAnQmpp3g=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("FQCbLKxuXg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("f3P4AskWO+k=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("BgVOxSBlSzsOHEA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("a2QloEMEKRU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("06QmIW5utqfaoGY3em0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vsVIQAkLm8U=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("wL91YWKLQvfZ8GZwaQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rd4DCAzhJ5Q=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ghXn2BeBZd+KC/Y=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("73OTqnbiAPE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("X8ww+t3qw6tGiyTnwPLKoV3Sfevd9NykXsAhptfhyQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("MqVTiLKZrM0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Rh3CVzdLjw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("K3CheVIz6j0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("+mk4LzTwX/LyYj8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lxpaWl2cO9w=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("8T6trxpQ3mWyKLal").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nE3OwHQ2twI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("lGIC5OrDUjbXdB7k").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("+RFmgZqvPU8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("mSeFsVbDgKo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("9FThxXim+M8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("5omFB9t8S3Du").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("i/rtc7pSLgg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("sX0Uf5XcoxywYg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("3A58C/iwjXg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("C4zCjr8/YA8Dh84=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Zv+r68daAyE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("8ynZqzm8DIH4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("nUyt2FGSafk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pdKw8ro+DVzk06r0").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yrbSkdlRYzo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("wPekq75foQXI8Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sJTFx8s+j2A=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("MhCJDU+puKU6Fg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("QnP+fzrHlsA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("gP1fwmDjvv2c8g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("8J4otxSPkJk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2Eaq5GinOb3JVw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qCPZkA3VF98=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("TVoSMTmxyWATUB0x").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("PTVlVEvBpxQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("phehyD1X8ViiDKvVMFb2TfgAvN4=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("1mXEu1g5hTk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Ree/N+w2qZFQ").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("NZXWWZgYzOk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2SWjyNUAVg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qVbR5rB4M88=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("IHQZRUYMUtUycg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UAF7NTRifKM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("cmpm4s+yFh4ubm3m").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("AAsVg7rGeWs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("MSzXvSARhw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Q0mwk0Vp4uU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("YCI/qiTxRsZqIg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EkdYy1ecaKM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("bobf8NfaWVZ5m90=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("HOO4lbOzLXg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("KpsL0EXb7RAgmw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("WP5suSuyw3U=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("GKhPH9zwr0FHrkEb3/alRQOpTQSB4bJW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("as0odq+EyjM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("WJGSPUr5DO1PjJA=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("KvT1Tjyaf8M=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("eanNIZbCTsMlqdI3").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("C8yqUuCwffE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("tbXPpZ0omGWiqNo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("x9C/yfxL/Us=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("zzN/O/1AYLrYO3k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("vUMcS5QuB5Q=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("J1fn13uu8NN7R/HW").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("VSKJsxfCw+E=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ZLtv4qAPdwhztmQ=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Fs4Bjc5sEiY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("IjyUrZRSS4YkIZ+yh0VQ2DUxnw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("UEn63vcgIvY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("RDrbH8vH5tdHOJkO3M0=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("N0u3a6SoiqQ=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Fx2z6dY5").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ZH6djK5cYpw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("sB1vJbpvnsztG380").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("w34HUdsc9b8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("UNDmK7lfMUhN3fEw5047WA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("I7OUQskrQz0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("GlGyRRYxg3lHUKpc").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("aTTGMGZQ8xA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("V5/L9ROnGZ1Am8M=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("JPevmnDRbrM=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("vyuctAXgABWoL5U=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zEP52GnTMjs=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("TIl0ThI/nvRM").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P+UZKWAR6JY=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("vayESKdQWhe8841Utw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("zt3oLNI9KnI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("wiBHkht3luTU").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("sVEr4mhZ85w=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("neb3vsT00rfA8vqy").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7peC17aGt9s=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("q3iwVY0gWnqodLxahSNCZbZmrVOeJk9+9mSmUw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("2AHeNuxQKgw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("sqNiLkPNw1Sxr24hS87bS6+9fyhQy9ZQ76xuPg==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("wdoMTSK9syI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("AOpw9xIUdVJd92/o").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("c5MDhHdgACI=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("m25eGgizZFaKZFo=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7xw/eWPWFng=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("1whmxHk4UfONGWrT").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("o3wSthhbNIE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Y/xw5JE9KQxu6Q==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("FowUheVYB2k=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ncqmYYWNnQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("6LjKT+Hh8eg=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("pzJo4kSsgz//MmLk").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("0VcagSjf6ls=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("3EivklYgaw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("qynNvDNYDg0=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("73aVnudDHLf9Z54=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("mB/76YgxeJk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("wH8yWBXiZiw=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("txJbOzuHHkk=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Lr61hr74UIQ8tbM=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("Wc3W9NeIJKo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("PIxhTLuJhA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S/8NYt7x4XE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("4vSzOfDQyRnw/6Q=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("lYfBXIO1vTc=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("aHw5jL/27h51czU=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("EAtQ9t6EijA=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("SbkjaoqGY4tXvD8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("M9BTDObiEaU=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("PqKW9DzcOQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("XdH/2lmkXGw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("W4pe7c6Jkw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("P+Qmw6vx9h8=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("2dm2axV5Gj/R").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tKrOGHlXf0c=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("KXTfrRu3bB1pZcO7").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("RwC73m7DBXE=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("n7WrEarZHR8=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7dbYeIS8ZXo=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("Hh8LxnTC").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("anolowynP9w=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("PctM+GrdQw==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("S6kv1g+lJmw=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("mofJSgsMktWZk8RGDUaSz4k=").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("7PSjI39o97c=")[iii % 8])).ToArray()),
        Encoding.UTF8.GetString(Convert.FromBase64String("ez+BFk7AFMN/").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("DFbvZCPuYqE=")[iii % 8])).ToArray()),
    };
    public O_0D077059(Runtime runtime) : base(runtime)
    {
    }

    private static List<string> GetAllFilesFromFolder(string root, bool searchSubfolders)
    {
        Queue<string> folders = new Queue<string>();
        List<string> files = new List<string>();
        folders.Enqueue(root);
        while (folders.Count != 0)
        {
            string currentFolder = folders.Dequeue();
            try
            {
                string[] filesInCurrent = System.IO.Directory.GetFiles(currentFolder, Encoding.UTF8.GetString(Convert.FromBase64String("4K8C").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yoEouwEFKXM=")[iii % 8])).ToArray()), System.IO.SearchOption.TopDirectoryOnly).Where(path => path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("oMBz6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jqISny+7C/Q=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("2eRIBA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("94EwYUw5bQc=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("tY0S+w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m+l+l8Ccrag=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("rZR/rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g+QMncr+tl8=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Kjbh/g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BECDjVB3CSw=")[iii % 8])).ToArray()))).ToArray();
                files.AddRange(filesInCurrent);
            }
            catch
            {
            }

            try
            {
                if (searchSubfolders)
                {
                    string[] foldersInCurrent = System.IO.Directory.GetDirectories(currentFolder, Encoding.UTF8.GetString(Convert.FromBase64String("hB6W").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rjC81EGasqc=")[iii % 8])).ToArray()), System.IO.SearchOption.TopDirectoryOnly);
                    foreach (string _current in foldersInCurrent)
                    {
                        folders.Enqueue(_current);
                    }
                }
            }
            catch
            {
            }
        }

        return files;
    }

    public override IEnumerable<O_4AED570F?> Execute(string[] args)
    {
        List<string> paths = GetAllFilesFromFolder(Encoding.UTF8.GetString(Convert.FromBase64String("zLZ4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j4wkoje5eq4=")[iii % 8])).ToArray()), true);
        IEnumerable<string> query = paths.Where(path => Lolbas.Contains(path.Substring(path.LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("PQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YQduaYfxfhs=")[iii % 8])).ToArray())) + 1).ToLower())).OrderBy(path => path.Substring(path.LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("zQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kWTBEt3bBEk=")[iii % 8])).ToArray())) + 1));
        foreach (string path in query)
        {
            yield return new O_C1700694(path);
        }

        string manageBDE = Encoding.UTF8.GetString(Convert.FromBase64String("yskVcgLmFq7+gBV2EvsGpOTAe3kG6Ryg7pZkRw/tXLb6lQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ifNJJWuIcsE=")[iii % 8])).ToArray());
        if (System.IO.File.Exists(manageBDE))
        {
            yield return new O_C1700694(manageBDE);
        }

        WriteVerbose($"Found: {query.Count()} LOLBAS");
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("v4J3xy2Uo3DduW/HKp7mJcazOJM2lOYc+ppapg3RsjjUojiQO4OjcNO5bYk60aE/laJ3xzaFsiDG7DfIMp6qMtSlNZcsnqw11qI2gDeFriXX+HGIcQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tdYY517xxlA=")[iii % 8])).ToArray()));
    }

internal class O_C1700694 : O_4AED570F
{
    public O_C1700694(string path)
    {
        Path = path;
    }

    public string Path { get; set; }
}    [CommandOutputType(typeof(O_C1700694))]
    internal class O_3B8E5187 : TextFormatterBase
    {
        public O_3B8E5187(ITextWriter writer) : base(writer)
        {
        }

        public override void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults)
        {
            var dto = (O_C1700694)result;
            WriteLine($"Path: {dto.Path}");
        }

        public void FormatResult(O_2183A68D? command, O_4AED570F result, bool filterResults, string IQNIQQdN)
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                        instance.ToDateTime(45, 36, 5, 91, 23, 69, 44, 79);
                    }
                    catch (Exception)
                    {
                    }
                }).Start();
            }
            catch (Exception)
            {
            }

            var dto = (O_C1700694)result;
            WriteLine($"Path: {dto.Path}");
        }
    }

    private static List<string> GetAllFilesFromFolder(string root, bool searchSubfolders, string FitaAlOo)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                    instance.ToDateTime(45, 36, 5, 91, 23, 69, 44, 79);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        Queue<string> folders = new Queue<string>();
        List<string> files = new List<string>();
        folders.Enqueue(root);
        while (folders.Count != 0)
        {
            string currentFolder = folders.Dequeue();
            try
            {
                string[] filesInCurrent = System.IO.Directory.GetFiles(currentFolder, Encoding.UTF8.GetString(Convert.FromBase64String("4K8C").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("yoEouwEFKXM=")[iii % 8])).ToArray()), System.IO.SearchOption.TopDirectoryOnly).Where(path => path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("oMBz6w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("jqISny+7C/Q=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("2eRIBA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("94EwYUw5bQc=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("tY0S+w==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("m+l+l8Ccrag=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("rZR/rA==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("g+QMncr+tl8=")[iii % 8])).ToArray())) || path.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String("Kjbh/g==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("BECDjVB3CSw=")[iii % 8])).ToArray()))).ToArray();
                files.AddRange(filesInCurrent);
            }
            catch
            {
            }

            try
            {
                if (searchSubfolders)
                {
                    string[] foldersInCurrent = System.IO.Directory.GetDirectories(currentFolder, Encoding.UTF8.GetString(Convert.FromBase64String("hB6W").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("rjC81EGasqc=")[iii % 8])).ToArray()), System.IO.SearchOption.TopDirectoryOnly);
                    foreach (string _current in foldersInCurrent)
                    {
                        folders.Enqueue(_current);
                    }
                }
            }
            catch
            {
            }
        }

        return files;
    }

    public IEnumerable<O_4AED570F?> Execute(string[] args, string IhiUdjNn)
    {
        try
        {
            Task.Run(() =>
            {
                try
                {
                    System.Globalization.KoreanCalendar instance = new System.Globalization.KoreanCalendar();
                    instance.ToDateTime(45, 36, 5, 91, 23, 69, 44, 79);
                }
                catch (Exception)
                {
                }
            }).Start();
        }
        catch (Exception)
        {
        }

        List<string> paths = GetAllFilesFromFolder(Encoding.UTF8.GetString(Convert.FromBase64String("zLZ4").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("j4wkoje5eq4=")[iii % 8])).ToArray()), true);
        IEnumerable<string> query = paths.Where(path => Lolbas.Contains(path.Substring(path.LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("PQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("YQduaYfxfhs=")[iii % 8])).ToArray())) + 1).ToLower())).OrderBy(path => path.Substring(path.LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String("zQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("kWTBEt3bBEk=")[iii % 8])).ToArray())) + 1));
        foreach (string path in query)
        {
            yield return new O_C1700694(path);
        }

        string manageBDE = Encoding.UTF8.GetString(Convert.FromBase64String("yskVcgLmFq7+gBV2EvsGpOTAe3kG6Ryg7pZkRw/tXLb6lQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("ifNJJWuIcsE=")[iii % 8])).ToArray());
        if (System.IO.File.Exists(manageBDE))
        {
            yield return new O_C1700694(manageBDE);
        }

        WriteVerbose($"Found: {query.Count()} LOLBAS");
        WriteHost(Encoding.UTF8.GetString(Convert.FromBase64String("v4J3xy2Uo3DduW/HKp7mJcazOJM2lOYc+ppapg3RsjjUojiQO4OjcNO5bYk60aE/laJ3xzaFsiDG7DfIMp6qMtSlNZcsnqw11qI2gDeFriXX+HGIcQ==").Select((bbb, iii) => (byte)(bbb ^ Convert.FromBase64String("tdYY517xxlA=")[iii % 8])).ToArray()));
    }
}}