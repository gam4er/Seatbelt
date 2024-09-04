using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace O_F41F88FA.Commands
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class CommandOutputTypeAttribute : Attribute
    {
        public Type Type { get; set; }

        public CommandOutputTypeAttribute(Type outputDTO)
        {
            if (!typeof(O_4AED570F).IsAssignableFrom(outputDTO))
            {
                throw new Exception($"CommandOutputTypeAttribute: the specified output DTO({outputDTO}) does not inherit from CommandDTOBase");
            }

            Type = outputDTO;
        }
    }
}