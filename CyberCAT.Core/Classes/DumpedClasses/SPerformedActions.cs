using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SPerformedActions")]
    public class SPerformedActions : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("ID")]
        [RealType("CName")]
        public string ID { get; set; }
        
        [RealName("ActionContext")]
        public DumpedEnums.EActionContext?[] ActionContext { get; set; }
    }
}
