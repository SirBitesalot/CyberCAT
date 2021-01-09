using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsChoiceTypeWrapper")]
    public class GameinteractionsChoiceTypeWrapper : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("properties")]
        [RealType("Uint32")]
        public uint Properties { get; set; }
    }
}
