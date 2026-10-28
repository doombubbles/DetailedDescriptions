using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class MermonkeyTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Mermonkey;

    public override string TextValue =>
        "<u>Trident</u> attack (2p, 1.2s, 28r): each Bloon hit creates a splash (2d, 3p, <i>Shatter</i>). " +
        "+35% range when placed on water.";
}

public class MermonkeyUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.TridentEfficiency, "<u>Trident</u> buffed: 80%s (0.96)."},
        {UpgradeType.TridentSwiftness, "<u>Trident</u> buffed: 0.66s, +50% projectile speed."},
        {
            UpgradeType.AbyssDweller,
            "Splash buffed: +2d (4). Gains 8 <u>Tentacle</u> attacks, one per 45° sector (8d, 15p, 8 radius blast, 3.0s, <i>Shatter</i>). " +
            "Nearby towers get +10% pierce."
        },
        {
            UpgradeType.AbyssalWarrior,
            "Splash buffed: +4d (8), slows Bloons to 60% speed for 10s (MOABs slowed less, DDTs and ZOMGs not at all). " +
            "<u>Tentacles</u> buffed: +4d (12), +10p (25), +6 Ceramic damage (18), 12 radius, 2.5s. Pierce buff now +20%."
        },
        {
            UpgradeType.LordOfTheAbyss,
            "+4r (32). <u>Trident</u> buffed: +7p (9), 0.33s. Splash buffed: +2d (10). " +
            "<u>Tentacles</u> buffed: +38d (50), +25p (50), +6 Ceramic damage (56), 24 radius, 1.5s. Pierce buff now +40%. Creates water around itself."
        },

        {UpgradeType.SharperProngs, "<u>Trident</u> buffed: +1p (3). Splash buffed: +3p (6)."},
        {UpgradeType.TidalChill, "Splash buffed: bigger (3 to 4.5 radius), freezes Bloons for 0.5s (up to 4 layers, not MOABs)."},
        {
            UpgradeType.RiptideChampion,
            "+4r (32). <u>Trident</u> reworked: 4d, 25p, 1.5s, no splash, pops Lead, freezes non-MOABs for 1s (Ceramics 0.5s), +2d to frozen Bloons. " +
            "Grows in size and damage while flying (1x, +0.5x per second, up to 3x), and releases 2 shards with the same stats."
        },
        {
            UpgradeType.ArcticKnight,
            "<u>Trident</u> buffed: +4d (8), +8md (16), +4d to frozen Bloons, damage grows faster (+0.75x per second). " +
            "Ability (45s cooldown): for 3s replaces its attacks with bouncing ice balls every 0.1s (20d, 240p, freeze 3 layers for 3s, last 15s)."
        },
        {
            UpgradeType.Popseidon,
            "+8r (40). <u>Trident</u> buffed: +7d (15), +15md (30), +7.5d to frozen Bloons, 50%s (0.75), throws 2 extra tridents. " +
            "Ability buffed: ice balls +10d (30), last 20s, bounce off map edges. Also sends a wave over the map (70d, +70d to frozen Bloons, ∞p, Camo) that slows to 50% for 8s."
        },

        {UpgradeType.EchosensePrecision, "Can see Camo Bloons. <u>Trident</u> homes in on targets."},
        {UpgradeType.EchosenseNetwork, "All Mermonkeys with 2+ bottom path upgrades get +7.5% range for each such Mermonkey, up to 10 stacks."},
        {
            UpgradeType.AlluringMelody,
            "Splash buffed: +6p (9). Gains <u>Trance</u> attack (6p, 12.0s, tower range radius, Camo, pauses other attacks 1.2s) that entrances non-MOAB Bloons for 6s, " +
            "removes Camo and detonates their damage-over-time effects. Ceramics use 2p."
        },
        {
            UpgradeType.SymphonicResonance,
            "+4r (32). <u>Trance</u> now comes from a totem placed within range (12p, 32 radius), and also affects MOABs (3p) and DDTs (4p), but not BFBs, ZOMGs or BADs."
        },
        {
            UpgradeType.TheFinalHarmonic,
            "+6r (38). Splash buffed: +9p (18). Totem can be placed anywhere, affects all MOAB-class Bloons, has 38 radius and much stronger damage-over-time detonation. " +
            "Totem gives Heroes in range +15% range and 15% faster ability recharge, and Magic Monkeys +3p."
        },
    };
}
