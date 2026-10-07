using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using BindingOfRounds.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using RarityLib.Utils;
using UnityEngine;

namespace BindingOfRounds
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.rarity.lib", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("Systems.R00t.Luck", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]
    
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

            //Add rarities
            RarityUtils.AddRarity("Epic", 0.05f, new UnityEngine.Color(1, 0, 1, 1), new UnityEngine.Color(0.588f, 0, 0.588f, 1));
            RarityUtils.AddRarity("Legendary", 0.025f, new UnityEngine.Color(1, 1, 0, 1), new UnityEngine.Color(0.7f, 0.7f, 0, 1));
            RarityUtils.AddRarity("???", 0.01f, new UnityEngine.Color(1, 0, 0, 1), new UnityEngine.Color(0.5f, 0, 0, 1));
            RarityUtils.AddRarity("Unobtainable", 0, new UnityEngine.Color(1, 0, 0, 1), new UnityEngine.Color(0, 0, 0, 1));
            RarityUtils.AddRarity("Lazy", 0.001f, new UnityEngine.Color(0, 0, 0, 1), new UnityEngine.Color(0, 0, 0, 1));
        }
        void Start()
        {
            instance = this;
            //CustomCard.BuildCard<MyCardName>();
        }
        public static BindingOfRounds instance { get; private set; }
    }
}
