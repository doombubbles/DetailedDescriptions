using System.Collections.Generic;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Enums;

namespace DetailedDescriptions.Towers;

public class BeastHandlerTower : TowerDetailedDescription
{
    protected override string TowerId => TowerType.BeastHandler;

    public override string TextValue =>
        "<u>Handler</u> attack (1d, 4p, 1.4s, 20r, 12 blast radius, <i>Energy</i>). " +
        "Upgrades replace it with a beast that does the fighting, and upgrading a second path adds that path's beast as well. Handlers with the same beast can merge to raise its Beast Power, which boosts its damage, pierce and attack speed.";
}

public class BeastHandlerUpgrades : UpgradeDetailedDescriptions
{
    public override Dictionary<string, string> Table => new()
    {
        {
            UpgradeType.Piranha,
            "Handler stops attacking, +40r (60). Gains a <u>Piranha</u> beast with <u>Leap</u> attack (1d, 1p, 0.6s, 30r, 4 blast radius, <i>Shatter</i>) that jumps at the target."
        },
        {
            UpgradeType.Barracuda,
            "Beast Power 3 (max 6). +5r (35). <u>Leap</u> buffed: +1d (2), +3p (4), 8 blast radius, knocks Bloons back."
        },
        {
            UpgradeType.GreatWhite,
            "Beast Power 8 (max 24). +5r (40). <u>Leap</u> becomes <u>Bite</u> (10p, 1.1s, 15 blast radius): drags Bloons up to Ceramic under water. " +
            "Bigger Bloons are held for up to 3s (60% speed) while it thrashes (12d, 10p, 15 blast radius, <i>Normal</i>, knockback, every 0.6s). At max Beast Power can drag MOAB-class Bloons under."
        },
        {
            UpgradeType.Orca,
            "Beast Power 16 (max 64). +10r (50). <u>Bite</u> buffed: +10p (20), 24 blast radius, drags Bloons up to BFB under faster, held MOABs take 120 damage per second. " +
            "Thrash buffed: +18d (30), +10p (20), 24 blast radius, stronger knockback that also hits MOABs. At max Beast Power can drag ZOMGs under."
        },
        {
            UpgradeType.Megalodon,
            "Needs 3 extra Orca Handlers. Beast Power 36 (max 132). +10r (60). <u>Bite</u> buffed: +30p (50), 48 blast radius, drags Bloons up to BAD under, held MOABs take 5000 damage per second (max 25% of their health per second). " +
            "Thrash buffed: +570d (600), +30p (50), 48 blast radius."
        },

        {
            UpgradeType.Microraptor,
            "Handler stops attacking, +40r (60). Gains a <u>Microraptor</u> beast with <u>Claw</u> attack (1d, 5p, 1.0s, 20r, 10 blast radius, <i>Sharp</i>)."
        },
        {
            UpgradeType.Adasaurus,
            "Beast Power 3 (max 6). <u>Claw</u> buffed: +1d (2), +3p (8), 15 blast radius, <i>Normal</i>, +1 Ceramic damage (3)."
        },
        {
            UpgradeType.Velociraptor,
            "Beast Power 8 (max 24). +4r (24). <u>Claw</u> buffed: +2d (4), +4p (12), 18 blast radius, +4 Ceramic damage (8), 1.5x damage to stunned Bloons."
        },
        {
            UpgradeType.TyrannosaurusRex,
            "Beast Power 16 (max 64). +6r (30). <u>Claw</u> buffed: +16d (20), +10p (22), +5 Ceramic damage (25). " +
            "Ability (40s cooldown): <u>T Rex Stomp</u> (150d, 400p, 100 blast radius, <i>Normal</i>, Camo) stuns Bloons for 6s, MOABs and BFBs 3s, ZOMGs and DDTs 2s."
        },
        {
            UpgradeType.Giganotosaurus,
            "Needs 3 extra T-Rex Handlers. Beast Power 36 (max 132). +20r (50), attacks through walls. <u>Claw</u> buffed: +480d (500), +11p (33), 24 blast radius, 1.25s, loses Ceramic bonus. " +
            "<u>Giga Stomp</u> (25s cooldown): +150d (300), 600p, whole map, stuns Bloons for 12s, MOABs 8s, BFBs 6s, ZOMGs and DDTs 4s."
        },

        {
            UpgradeType.Gyrfalcon,
            "Handler stops attacking, +40r (60). Gains a <u>Gyrfalcon</u> beast (60r) that grabs up to 3 Bloons (10 grab radius, 1.0s cooldown) and carries them to a chosen point. " +
            "1d on grab and 1d every 1.0s while carried, <i>Sharp</i>, +1 damage to Regrow. Can't grab Lead, Ceramic or MOAB-class Bloons."
        },
        {
            UpgradeType.HornedOwl,
            "Beast Power 3 (max 6). Camo. Grabs up to 6 Bloons (20 grab radius) and can grab Ceramics."
        },
        {
            UpgradeType.GoldenEagle,
            "Beast Power 8 (max 24). Grabs up to 30 Bloons (25 grab radius) and keeps picking up more, Ceramic grab pierce penalty 4 -> 1. " +
            "Carry damage every 0.5s. At max Beast Power can carry the smaller MOAB-class Bloons."
        },
        {
            UpgradeType.GiantCondor,
            "Beast Power 16 (max 64). Can grab MOABs and BFBs (grab pierce penalty 14 and 29). Grab damage +1d (2). Grab and carry damage +11 MOAB damage (13 / 12)."
        },
        {
            UpgradeType.Pouakai,
            "Needs 3 extra Giant Condor Handlers. Beast Power 36 (max 132). Grabs up to 150 Bloons (45 grab radius) of any type, including Lead, DDTs, ZOMGs and BADs, 80%s (0.8). " +
            "Grab damage +8d (10), carry damage +9d (10), <i>Normal</i>, +69 MOAB damage (90)."
        },
    };
}
