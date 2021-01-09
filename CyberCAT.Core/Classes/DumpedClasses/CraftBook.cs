using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("CraftBook")]
    public class CraftBook : IScriptable
    {
        [RealName("knownRecipes")]
        public ItemRecipe[] KnownRecipes { get; set; }
    }
}
