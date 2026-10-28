using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class SkywardenTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.Skywarden;

    public override string TextValue =>
        "<u>Bow</u> attack (1d, 4p, 1.55s, 48r, <i>Sharp</i>). " +
        "Each hit gives +5% attack speed, up to 10 stacks (+50%), lost after 2s without hitting.";
}

public class SkywardenUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            "AerialAttunement",
            "+10r (58), arrows travel further. Monkeys in range (up to tier 2) get +3r, stacks up to 3 times."
        },
        {
            "ZephyrSense",
            "Can see Camo Bloons. Can toggle <u>Focus</u> stance: 135% range, homing arrows, but 125%s (1.94). Range buff now reaches tier 3 Monkeys."
        },
        {
            "WindWeaver",
            "Hits apply a 2s Wind combo (not MOABs): first blows Bloons back 10-20 units every 0.5s, " +
            "then shoots 2 extra arrows from the target (1d, 4p), then pulls other Bloons back toward it (4p, 20-40 units)."
        },
        {
            "Galesage",
            "<u>Bow</u> buffed: +1d (2), 3 shot burst (0.15s between shots). Combo arrows +1d (2). Removes Camo from Bloons in range."
        },
        {
            "FarwindSeer",
            "<u>Bow</u> buffed: +3d (5). Combo arrows +3d (5), 4 arrows. +1d for every 5 range above 65, up to +20."
        },

        {
            "StormsPulse",
            "<u>Bow</u> buffed: <i>Energy</i>, 150% projectile speed. Attack speed stacks up to 20 (+100%)."
        },
        {
            "ThunderingArc",
            "<u>Bow</u> now lobs an arrow over walls that explodes at the target (1d, 4p, 10 radius, <i>Plasma</i>), " +
            "+1p and +1 radius per 10 units travelled. Can target a chosen point."
        },
        {
            "GalvanicConduit",
            "Explosion buffed: +3 Ceramic/MOAB/Lead damage. Hits apply a 2s Galvanize combo: first pulls Energy and Plasma projectiles toward the Bloon, " +
            "then <i>Sharp</i>/<i>Shatter</i> hits on it make chain lightning (3d, 4p, 1 jump, +4 damage to Frozen, <i>Plasma</i>), then stuns it for 3s with 10d."
        },
        {
            "ThundersDecree",
            "Explosion buffed: +1.5p per 10 units travelled. Galvanize combo can now stun ZOMGs. " +
            "Ability (45s cooldown): <u>Thunder Charge</u>, for 9s Monkeys in range get faster projectiles that ricochet up to 2 times and can pop Frozen Bloons."
        },
        {
            "StormwrathArchon",
            "Explosion buffed: +9 Ceramic/MOAB/Lead damage. Chain lightning +47d (50), stun +90d (100). " +
            "Explosions leave Lightning Rods (12s) that zap nearby Bloons hit by Energy or Plasma (40d, 5p, <i>Plasma</i>). " +
            "<u>Thunder Charge</u>: 30s cooldown, also links all Lightning Rods for 15s (40d, 50p, every 0.25s, 35% chance to stun for 2s)."
        },

        {
            "Shatterpoint",
            "<u>Bow</u> buffed: +2p (6), much better accuracy, can pop Frozen, +7 damage to Frozen Blue/Green/Yellow/Pink Bloons."
        },
        {
            "Icebore",
            "<u>Bow</u> buffed: +1 damage to Frozen. Popping a Frozen Bloon gives 150% pierce for 1s."
        },
        {
            "Coldchain",
            "Hits apply a 2s Chill combo (not MOABs): first slows to 75% speed, then the Bloon slows Bloons near it (3s), " +
            "then releases 2 ice shards (3d, 3p, +3 damage to Frozen) with a 35% chance to freeze for 1.5s."
        },
        {
            "FrozenVerdict",
            "<u>Bow</u> buffed: +1d (2), +3 damage to Frozen (4). Chill combo now slows MOABs; shards +3d (6), +3 damage to Frozen (6) and can freeze MOABs. " +
            "Popped Frozen Bloons leave remains (6p) that slow to 50% for 3s, then explode after 2-4s (3d, 3p, 12 radius, freezes for 1s)."
        },
        {
            "WintersMercy",
            "<u>Bow</u> buffed: +2d (4), +4 damage to Frozen (8). +1d per 3 Frozen Bloons in range, up to +8; destroying Frozen Bloons boosts damage for 6s. " +
            "Shards +6 damage to Frozen (12), longer range. Hitting Frozen MOABs also leaves remains. Remains explosion: +2d (5), 24 radius, deals 50/100/150/400/10000 to MOAB/DDT/BFB/ZOMG/BAD."
        },
    };
}
