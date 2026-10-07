using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using BindingOfRounds.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace BindingOfRounds
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class BindingOfRounds : BaseUnityPlugin
    {
        private const string ModId = "com.bitcrush.binding.rounds";
        private const string ModName = "Binding Of Rounds";
        public const string Version = "0.1.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "BoR";

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            //CustomCard.BuildCard<MyCardName>();
        }
        public static SimplyCards instance { get; private set; }
    }
}
