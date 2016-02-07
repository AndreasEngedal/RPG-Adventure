using System;

namespace Model
{
    // Most weapons are normal quality, and can be made exceptional by a Blacksmith in towns, for a price.
    public enum WeaponQuality
    {
        Low,        // - 15 Durability/Accuracy/Damage
        Normal,     // + 0 Durability/Accuracy/Damage
        Exceptional // + 5 Durability/Accuracy/Damage
    }

    public enum WeaponType
    {
        Axe,        // Axes, Hatches, etc.
        Slashing,   // Katana, Broadsword, Longsword, etc.
        Staff,      // Staves etc.
        Bashing,    // War Hammers, Maces, Mauls, etc. 
        Piercing,   // Spears, Daggers, etc.
        Polearm,    // Halberd, Bardiche etc.
        Ranged,     // Bow, Crossbows etc.
        Fists       // Fists, Fist Weapon etc.
    }

    // This is where we define the loot tier throughout the game.
    // Early game	Tier 0-1
    // Mid game	Tier 2-3
    // Late game	Tier 4-5
    // Our algorithm has to be awesome, in early game there should be a very small chance for midgame loot,
    // in midgame there should be a very small chance for endgame loot. Depending on events/monster diffculty.	
    public enum WeaponRarity
    {
        Common,     // Tier 0
        Uncommon,   // Tier 1
        Rare,       // Tier 2
        Unique,     // Tier 3
        Mythical,   // Tier 4
        Legendary   // Tier 5
    }

    // Property that gives the weapon extra accuracy.	
    public enum WeaponAccuracy
    {
        Regular,    // +0 Base Accuracy
        Accurate,   // +1 Base Accuracy
        Surpassingly,   // +2 Base Accuracy
        Eminently,  // +3 Base Accuracy
        Exceedingly,    // +4 Base Accuracy
        Supremely   // +5 Base Accuracy
    }

    // Property that gives the weapon extra durability.
    public enum WeaponDurabilityLevel
    {
        Regular,    // +0 base durability
        Durable,    // +5 base durability
        Fortified,  // +25 base durability
        Indestructible  // +50 base durability
    }
}