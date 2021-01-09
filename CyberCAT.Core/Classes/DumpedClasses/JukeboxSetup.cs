using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("JukeboxSetup")]
    public class JukeboxSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingStation")]
        public DumpedEnums.ERadioStationList? StartingStation { get; set; }
        
        [RealName("glitchSFX")]
        [RealType("CName")]
        public string GlitchSFX { get; set; }
        
        [RealName("paymentRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId PaymentRecordID { get; set; }
    }
}
