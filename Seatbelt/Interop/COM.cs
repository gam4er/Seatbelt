using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Interop
{
    internal class O_FC331D1C
    {
        [Flags]
        public enum FirewallProfiles : int
        {
            DOMAIN = 1,
            PRIVATE = 2,
            PUBLIC = 4,
            ALL = 2147483647
        }
    }
}