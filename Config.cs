using System.ComponentModel;
using Terraria.ModLoader.Config;


namespace CTMI {
    public class ConfigClient : ModConfig {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Recipes")]

        [BackgroundColor(99, 180, 209)]
        [Label("Vanity Recipes")]
        [Tooltip("Turns vanity item recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool VanityRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Acessory Recipes")]
        [Tooltip("Turns accessory recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool AccessoryRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Weapon Recipes")]
        [Tooltip("Turns weapon recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool WeaponRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Placeable Recipes")]
        [Tooltip("Turns placeable item recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool PlaceableRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Armor Recipes")]
        [Tooltip("Turns armor recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool ArmorRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Tool Recipes")]
        [Tooltip("Turns tool recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool ToolRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Consumable Recipes")]
        [Tooltip("Turns consumable recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool ConsumableRecipes { get; set; }

        [BackgroundColor(99, 180, 209)]
        [Label("Summon Recipes")]
        [Tooltip("Turns summon recipes on/off.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool SummonRecipes { get; set; }

        [Header("Mod Specific")]

        [BackgroundColor(99, 180, 209)]
        [Label("Calamity Mod Specific Recipes")]
        [Tooltip("Turns Calamity mod specific recipes on/off - this includes adding recipes which are already in Calamity.\n" +
            "Note: If you don't have Calamity enabled, this value won't make a difference.")]
        [ReloadRequired]
        [DefaultValue(true)]
        public bool CalamityRecipes { get; set; }

    }

}
