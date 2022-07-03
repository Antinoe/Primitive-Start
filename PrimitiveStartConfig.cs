using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PrimitiveStart
{
    [Label("Server Config")]
    public class PrimitiveStartConfig : ModConfig
    {
        //This is here for the Config to work at all.
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static PrimitiveStartConfig Instance;
		
        [Header("General")]
		
        [Label("Give Copper Starter Set")]
        [Tooltip("If true, Players will still be granted Copper Tools upon spawning.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool giveCopperSet {get; set;}
		
        [Header("Crude Bag")]
		
        [Label("Give Wooden Stake")]
        [Tooltip("If false, Players will not receive a Wooden Stake.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveWoodenStake {get; set;}
		
        [Label("Give Wooden Club")]
        [Tooltip("If false, Players will not receive a Wooden Club.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool giveWoodenClub {get; set;}
		
        [Label("Give Stone Axe")]
        [Tooltip("If false, Players will not receive a Stone Axe.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveStoneAxe {get; set;}
		
        [Label("Give Stone Pickaxe")]
        [Tooltip("If false, Players will not receive a Stone Pickaxe.\n[Default: On]")]
        [DefaultValue(true)]
        public bool giveStonePickaxe {get; set;}
		
        [Label("Give Weed Wraps")]
        [Tooltip("How many Weed Wraps to give.\n[Default: 2]")]
        [Slider]
        [DefaultValue(2)]
        [Range(0, 10)]
        [Increment(1)]
        public int giveWeedWrap {get; set;}
		
        [Label("Give Herbal Weed Wraps")]
        [Tooltip("How many Herbal Weed Wraps to give.\n[Default: 0]")]
        [Slider]
        [DefaultValue(0)]
        [Range(0, 10)]
        [Increment(1)]
        public int giveHerbalWeedWrap {get; set;}
		
        [Header("Weapons")]
		
        [Label("Wooden Club Damage")]
        [Tooltip("How much damage the Wooden Club deals.\n[Default: 9]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(9)]
        [Range(6, 20)]
        [Increment(1)]
        public int weaponsWoodenClubDamage {get; set;}
		
        [Label("Wooden Club Swing Speed")]
        [Tooltip("How slowly the Wooden Club swings.\n[Default: 29]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(29)]
        [Range(20, 40)]
        [Increment(1)]
        public int weaponsWoodenClubUseTime {get; set;}
		
        [Label("Wooden Club Knockback")]
        [Tooltip("The Knockback value for the Wooden Club.\n[Default: 8]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(8)]
        [Range(1, 10)]
        [Increment(1)]
        public int weaponsWoodenClubKnockback {get; set;}
		
        [Label("Wooden Stake Damage")]
        [Tooltip("How much damage the Wooden Stake deals.\n[Default: 4]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(4)]
        [Range(1, 6)]
        [Increment(1)]
        public int weaponsWoodenStakeDamage {get; set;}
		
        [Label("Wooden Stake Swing Speed")]
        [Tooltip("How slowly the Wooden Stake swings.\n[Default: 13]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(13)]
        [Range(1, 15)]
        [Increment(1)]
        public int weaponsWoodenStakeUseTime {get; set;}
		
        [Header("Tools")]
		
        [Label("Stone Axe Damage")]
        [Tooltip("How much damage the Stone Axe deals.\n[Default: 2]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(2)]
        [Range(1, 4)]
        [Increment(1)]
        public int toolsStoneAxeDamage {get; set;}
		
        [Label("Stone Axe Swing Speed")]
        [Tooltip("How slowly the Stone Axe swings.\n[Default: 32]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(32)]
        [Range(20, 40)]
        [Increment(1)]
        public int toolsStoneAxeUseTime {get; set;}
		
        [Label("Stone Axe Mine Speed")]
        [Tooltip("How quickly the Stone Axe chops trees.\n[Default: 5]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(5)]
        [Range(1, 10)]
        [Increment(1)]
        public int toolsStoneAxeMineSpeed {get; set;}
		
        [Label("Stone Pickaxe Damage")]
        [Tooltip("How much damage the Stone Pickaxe deals.\n[Default: 3]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(3)]
        [Range(1, 5)]
        [Increment(1)]
        public int toolsStonePickaxeDamage {get; set;}
		
        [Label("Stone Pickaxe Swing Speed")]
        [Tooltip("How slowly the Stone Pickaxe swings.\n[Default: 30]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(30)]
        [Range(20, 40)]
        [Increment(1)]
        public int toolsStonePickaxeUseTime {get; set;}
		
        [Label("Stone Pickaxe Mine Speed")]
        [Tooltip("How quickly the Stone Pickaxe breaks blocks.\n[Default: 25]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(25)]
        [Range(1, 25)]
        [Increment(1)]
        public int toolsStonePickaxeMineSpeed {get; set;}
		
        [Header("Consumables")]
		
        [Label("Weed Wrap Heal Amount")]
        [Tooltip("How much Life the Weed Wrap will heal upon consumption.\n[Default: 5]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(5)]
        [Range(0, 10)]
        [Increment(1)]
        public int consumablesWeedWrapHealAmount {get; set;}
		
        [Label("Weed Wrap Heal Duration")]
        [Tooltip("How long the Weed Wrap's buff will last.\n[Default: 600]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(600)]
        [Range(0, 2400)]
        [Increment(100)]
        public int consumablesWeedWrapHealDuration {get; set;}
		
        [Label("Weed Wraps Craft Cost")]
        [Tooltip("How much Hay is required to craft a single Weed Wrap.\n[Default: 10]\n(REQUIRES MOD RELOAD)")]
        [Slider]
        [DefaultValue(10)]
        [Range(1, 50)]
        [Increment(1)]
        public int consumablesWeedWrapCraftCost {get; set;}
		
        [Label("Herbal Weed Wrap Heal Amount")]
        [Tooltip("How much Life the Herbal Weed Wrap will heal upon consumption.\n[Default: 10]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(10)]
        [Range(0, 10)]
        [Increment(1)]
        public int consumablesHerbalWeedWrapHealAmount {get; set;}
		
        [Label("Herbal Weed Wrap Heal Duration")]
        [Tooltip("How long the Herbal Weed Wrap's buff will last.\n[Default: 1200]\n(Requires World Reload.)")]
        [Slider]
        [DefaultValue(1200)]
        [Range(0, 2400)]
        [Increment(100)]
        public int consumablesHerbalWeedWrapHealDuration {get; set;}
		
        [Label("Herbal Weed Wraps Craft Cost")]
        [Tooltip("How much Hay is required to craft a single Herbal Weed Wrap.\n[Default: 15]\n(REQUIRES MOD RELOAD)")]
        [Slider]
        [DefaultValue(15)]
        [Range(1, 50)]
        [Increment(1)]
        public int consumablesHerbalWeedWrapCraftCost {get; set;}
		
    }
}