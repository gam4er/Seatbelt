using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    [Flags]
    public enum CommandGroup
    {
        All,
        User,
        System,
        Slack,
        Chromium,
        Remote,
        Misc,
    }
}