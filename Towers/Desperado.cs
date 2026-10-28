using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class DesperadoTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Desperado;

    public override string TextValue =>
        "<u>Revolver</u> attack (1d, 1p, 1.2s, 60r, 2 shot burst, <i>Sharp</i>). Hits instantly.";
}

public class DesperadoUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {UpgradeType.Quickdraw, "+1% attack speed per unit of distance to the target, up to +50%."},
        {UpgradeType.Standoff, "Up to +60% attack speed, reduced by 10% for each Bloon in range."},
        {
            UpgradeType.BigIron,
            "<u>Revolver</u> buffed: +1d (2), 6 shot burst, <i>Normal</i>. Standoff bonus now up to +120%, reduced by 20% per Bloon."
        },
        {UpgradeType.TwinSixes, "<u>Revolver</u> buffed: +4d (6), 12 shot burst (0.05s between shots)."},
        {
            UpgradeType.TheBlazingSun,
            "<u>Revolver</u> buffed: +14d (20), +40 Ceramic damage (60), 0.3s. " +
            "Shots build up to 75 stacks (+1% attack speed each), 50+ stacks burn Bloons."
        },

        {UpgradeType.EagleEye, "Can see Camo Bloons."},
        {UpgradeType.Bullseye, "Shots have a 2.5% chance to crit for 4x damage, +0.25% chance per unit of distance to the target."},
        {
            UpgradeType.Deadeye,
            "<u>Revolver</u> buffed: +5d (6), <i>Normal</i>, but range reduced to 40r. " +
            "Gains <u>Rifle</u> attack (10d, 4p, 1.59s, 80r, <i>Normal</i>, +10 Fortified damage, crits with +0.4% chance per unit of distance). " +
            "Ability (30s cooldown): <u>Take Aim</u>, the targeted Monkey gets more range, accuracy and Camo detection."
        },
        {
            UpgradeType.BountyHunter,
            "<u>Revolver</u> buffed: +6 Ceramic damage (12). <u>Rifle</u> bonus damage now also applies to Ceramics. " +
            "Gains <u>Mark</u> attack (2p, 6.0s, 80r) that marks Bloons; marked Bloons take more damage and give more cash. " +
            "Ability (45s cooldown): <u>Marked To Pop</u>, marks more Bloons and attacks all marked Bloons."
        },
        {
            UpgradeType.GoldenJustice,
            "<u>Revolver</u> buffed: +18d (24), +24 Ceramic damage (48), crits for 8x, hits also mark and create a blast (24d, 8p, +24 Ceramic damage). " +
            "<u>Rifle</u> buffed: +270d (280), ∞p, +280 Fortified/Ceramic damage, 3.18s, crits for 8x. <u>Mark</u> buffed: 3.0s."
        },

        {UpgradeType.Wanderer, "+45% attack speed, reduced by 9% for each other tower in range."},
        {
            UpgradeType.Nomad,
            "+2% attack speed per Bloon in range, up to +50%. When lives are lost, briefly gains range, attack speed and some cash."
        },
        {
            UpgradeType.Enforcer,
            "<u>Revolver</u> buffed: +5d (6). Gains <u>Shotgun</u> attack (3d, 3p, 3 pellets, 2 shot burst, 1.97s, 36r, <i>Shatter</i>) that knocks Bloons back."
        },
        {
            UpgradeType.Avenger,
            "<u>Revolver</u> buffed: +12d (18), +18 Ceramic damage (36). <u>Shotgun</u> pellets now release 3 shrapnel on hit (1d, 6p, <i>Sharp</i>) and knock back MOABs. " +
            "When lives are lost, weaker Bloons briefly take only 1 life."
        },
        {
            UpgradeType.TheDesertPhantom,
            "<u>Revolver</u> buffed: +32d (50), +50 Ceramic damage (100), 0.6s. <u>Shotgun</u> buffed: +7d (10), +40 MOAB damage. " +
            "Shrapnel buffed: +2d (3), sets Bloons on fire (9s) and makes them explode after 4.5s."
        },
    };
}
