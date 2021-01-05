using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameSEquipmentSet")]
    public class GameSEquipmentSet : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("setItems")]
        public GameSItemInfo[] SetItems { get; set; }
        
        [RealName("setName")]
        [RealType("CName")]
        public string SetName { get; set; }
        
        [RealName("setType")]
        public DumpedEnums.gameEquipmentSetType? SetType { get; set; }
    }
}